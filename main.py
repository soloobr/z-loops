import sys
import os
import time
import threading
from typing import List
from modules.out import save_output, success_multiple, success_singel, success_zip, failed, failed_zip, failed_ssh, success_ssh
from modules.banner import build_parser, banner, alert, benchmark
from modules.hash import crack_hash
from modules.hash import identify_hash
from modules.zip import crack_archive, identify_zip
from modules.web.form_bruteforce import bruteforce_form
from modules.os import crack_ssh
from modules.core import generate_patterns, MONTHS, DAYS, DATES, generate_from_mask, incremental_generator, parse_charset, load_rules_file, generate_with_rules

def identify(args):
    if args.hash:
        types = identify_hash(args.hash)
        print(f"\n[INFO] Hash kemungkinan bertipe: {', '.join(types)}")
    elif args.file:
        with open(args.file, "r") as f:
            hashes = [h.strip() for h in f if h.strip()]
        for idx, h in enumerate(hashes, start=1):
            types = identify_hash(h)
            print(f"\n[START] Hash ({idx}/{len(hashes)}): {h}")
            print(f"[INFO] Hash kemungkinan bertipe: {', '.join(types)}")
    return

def zip_identify(args):
    if args.file:
        types = identify_zip(args.file)
        print(f"\n[INFO] File kemungkinan bertipe: {types}")
    return

def load_candidates(args) -> List[str]:
    bases: List[str] = []

    if getattr(args, "wordlist", None):
        if not os.path.isfile(args.wordlist):
            print(f"[!] Wordlist tidak ditemukan: {args.wordlist}")
        else:
            try:
                with open(args.wordlist, "r", encoding="latin-1", errors="ignore") as f:
                    for line in f:
                        candidate = line.strip()
                        if candidate:
                            bases.append(candidate)
            except Exception as e:
                print(f"[!] Gagal baca wordlist: {e}")

    if getattr(args, "mask", None):
        try:
            bases.extend(list(generate_from_mask(args.mask)))
        except Exception as e:
            print(f"[!] Gagal generate dari mask: {e}")

    if getattr(args, "pattern", False) and getattr(args, "name", None):
        try:
            patterns = generate_patterns(
                [args.name],
                years=args.year,
                months=MONTHS if args.use_months else None,
                days=DAYS if args.use_days else None,
                dates=DATES if args.use_dates else None,
                symbols=args.symbols
            )
            bases.extend(patterns)
        except Exception as e:
            print(f"[!] Gagal generate pattern: {e}")

    if getattr(args, "increment", None) and getattr(args, "charset", None):
        try:
            min_len, max_len = args.increment
            if min_len > max_len or min_len < 1:
                print("[!] Increment range tidak valid.")
            else:
                charset = parse_charset(args.charset)
                if not charset:
                    print("[!] Charset kosong setelah parsing.")
                else:
                    bases.extend(list(incremental_generator(min_len, max_len, charset)))
        except Exception as e:
            print(f"[!] Gagal generate incremental: {e}")

    if not bases:
        return []

    if getattr(args, "rules", None):
        try:
            rules = load_rules_file(args.rules)
            max_per_base = getattr(args, "rule_limit", None)
            candidates = list(generate_with_rules(bases, rules, max_per_base=max_per_base))
        except Exception as e:
            print(f"[!] Gagal membaca/mengenerate rules: {e}. Menggunakan bases saja.")
            candidates = list(bases)
    else:
        candidates = list(bases)

    seen = set()
    final = []
    for c in candidates:
        if c not in seen:
            seen.add(c)
            final.append(c)

    return final

def run_with_benchmark(fargs, func, *args, benchmark_enabled=False, workers=1, candidates=None, **kwargs):
    
    if candidates is not None:
        kwargs.setdefault("candidates", candidates)
    if workers is not None:
        kwargs.setdefault("workers", workers)

    start_time = time.time() if benchmark_enabled else None
    
    result = func(*args, **kwargs)

    if benchmark_enabled and start_time is not None and kwargs.get("candidates"):
        elapsed = time.time() - start_time
        trials = len(kwargs.get("candidates"))
        speed = trials / elapsed if elapsed > 0 else 0
        stats = benchmark(workers, trials, elapsed, speed)
        print(stats)
        if fargs.out:
            save_output(stats, fargs.out)

    return result

def run_single_hash(args, candidates, verbose):
    if args.auto:
        hash_types = identify_hash(args.hash)
        if "unknown" in hash_types:
            print(f"[!] Tidak bisa mengidentifikasi hash: {args.hash}")
            return
        print(f"[*] Deteksi otomatis: kemungkinan hash = {', '.join(hash_types)}")
    else:
        if not args.type:
            print("[!] Harus gunakan --type atau --auto")
            return
        hash_types = [args.type]

    for ht in hash_types:
        print(f"[*] Mulai brute force untuk hash: {args.hash} (type: {ht})")

        
        result = run_with_benchmark(
            args,
            crack_hash,
            args.hash,            
            ht,                   
            workers=args.workers,
            limit=tuple(args.limit) if args.limit else None,
            verbose=verbose,
            benchmark_enabled=args.benchmark,
            candidates=candidates,  
            resume=args.resume
        )

        if result:
            print(success_singel(args.hash, result, ht))
            if args.out:
                save_output(success_singel(args.hash, result, ht), args.out)
            return

    print(failed(args.hash))
    if args.out:
        save_output(failed(args.hash), args.out)


def run_file_hashes(args, candidates, verbose):
    print(f"[*] Membaca daftar hash dari {args.file}")
    with open(args.file, "r") as f:
        hashes = [h.strip() for h in f if h.strip()]

    for idx, h in enumerate(hashes, start=1):
        print(f"\n[*] ({idx}/{len(hashes)}) Hash: {h}")

        if args.auto:
            hash_types = identify_hash(h)
            if "unknown" in hash_types:
                print(f"[!] Tidak bisa mengidentifikasi hash: {h}")
                continue
            print(f"[*] Deteksi otomatis: kemungkinan hash = {', '.join(hash_types)}")
        else:
            if not args.type:
                print("[!] Harus gunakan --type atau --auto")
                return
            hash_types = [args.type]

        found = False
        for ht in hash_types:
            print(f"[*] Brute force type {ht} ...")

            result = run_with_benchmark(
                args,
                crack_hash,
                h,                     
                ht,                    
                workers=args.workers,
                limit=tuple(args.limit) if args.limit else None,
                verbose=verbose,
                benchmark_enabled=args.benchmark,
                candidates=candidates,   
                resume=args.resume
            )

            if result:
                print(success_multiple(h, result, ht))
                if args.out:
                    save_output(success_multiple(h, result, ht), args.out)
                found = True
                break

        if not found:
            print(failed(h))
            if args.out:
                save_output(failed(h), args.out)


def run_zip(args, candidates, verbose):
    print(f"[*] Target ZIP: {args.file}")
    print(f"[*] Jumlah kandidat: {len(candidates)}")

    result = run_with_benchmark(
        args,
        crack_archive,            
        args.file,               
        workers=args.workers,
        limit=tuple(args.limit) if args.limit else None,
        verbose=verbose,
        benchmark_enabled=args.benchmark,
        candidates=candidates     
    )

    if result:
        print(f"[SUCCESS] Password ditemukan → {result}")
        if args.out:
            save_output(success_zip(args.file, result), args.out)
    else:
        print(f"[FAIL] Password tidak ditemukan untuk {args.file}")
        if args.out:
            save_output(failed_zip(args.file), args.out)


def run_ssh(args, usernames, candidates, verbose):
    print(f"[*] Target SSH: {args.host}")
    print(f"[*] Jumlah kandidat: {len(candidates)}")
    
    result = run_with_benchmark(
        args,
        crack_ssh,                          
        host=args.host,
        port=args.port,
        users=usernames,
        candidates=candidates,
        methods=getattr(args, "methods", ["password"]),
        ssh_key=getattr(args, "ssh_key", None),
        workers=getattr(args, "workers", os.cpu_count()),
        timeout=getattr(args, "timeout", 8),
        verbose=not getattr(args, "silent", True),
        benchmark_enabled=args.benchmark,
        limit=tuple(args.limit) if args.limit else None  
    )
    
    if result:
        print(success_ssh(args.host, args.port, result))
        if args.out:
            save_output(success_ssh(args.host, args.port, result), args.out)
    else:
        print(failed_ssh(args.host, args.port))
        if args.out:
            save_output(failed_ssh(args.host, args.port), args.out)

def main():
    print(banner())
    alert("For now, The Web Bruteforce mode cannot be used optimally, please wait for the next update.")

    parser = build_parser()

    if len(sys.argv) == 1:
        parser.print_help()
        return

    args = parser.parse_args()
    verbose = not args.silent
    

    if args.workers:
        default_workers = os.cpu_count()
        print(f"[*] Menggunakan jumlah workers: {'(default) ' + str(default_workers) if args.workers == default_workers else args.workers}")
    print(f"[*] Mode verbose: {'OFF' if args.silent else 'ON'}")
    print(f"[*] Mode benchmark: {'ON' if args.benchmark else 'OFF'}")

    if args.mode == "hash":
        print(f"[*] Mode Resume: {'ON' if args.resume else 'OFF'}")
        if args.resume and not args.limit:
            print("[!] Tidak menggunakan --limit jika menggunakan resume membuat penyimpanan checkpoint menjadi sia sia.")
        elif args.resume and args.file:
            print("[!] --resume tidak optimal jika digunakan dengan --file.")
        if args.identify:
            identify(args)
            return
        candidates = load_candidates(args)
        if not candidates:
            print("[!] Tidak ada kandidat password.")
            return
        print(f"[*] Mulai brute force {len(candidates)} kandidat...")
        if args.hash:
            run_single_hash(args, candidates, verbose)
        elif args.file:
            run_file_hashes(args, candidates, verbose)
    elif args.mode == "archive":
        if args.identify:
            zip_identify(args)
            return
        candidates = load_candidates(args)
        if not candidates:
            print("[!] Tidak ada kandidat password.")
            return
        print(f"[*] Mulai brute force {len(candidates)} kandidat...")
        run_zip(args, candidates, verbose)
    elif args.mode == "web":
        candidates = load_candidates(args)
        if not candidates:
            print("[!] Tidak ada kandidat password.")
            return

        if args.users:
            try:
                with open(args.users, "r", encoding="utf-8", errors="ignore") as f:
                    usernames = [u.strip() for u in f if u.strip()]
            except Exception as e:
                print(f"[!] Gagal baca file users: {e}")
                return
        elif args.username:
            usernames = [args.username]
        else:
            print("[!] Harus pakai --user atau --users")
            return

        print(f"[*] Mulai brute force untuk {len(usernames)} username dan {len(candidates)} kandidat password...")

        
        success_kw_arg = getattr(args, "success_keywords", None)
        success_keywords = [k.strip() for k in (success_kw_arg or "").split(",") if k.strip()]
        failure_kw_arg = getattr(args, "failure_keywords", None)
        failure_keywords = [k.strip() for k in (failure_kw_arg or "").split(",") if k.strip()]
        cookie_names_arg = getattr(args, "cookie_names", None)
        cookie_names = [k.strip() for k in (cookie_names_arg or "").split(",") if k.strip()]

        
        username_hint = getattr(args, "username_hint", None)
        password_hint = getattr(args, "password_hint", None)

        
        user_field_override = getattr(args, "user_field", None)
        pass_field_override = getattr(args, "pass_field", None)

        chunk_size, chunk_delay = None, 0.0
        if getattr(args, "limit", None):
            try:
                chunk_size = int(args.limit[0])
                chunk_delay = float(args.limit[1])
            except Exception:
                pass

        headers, proxies = None, None
        if getattr(args, "headers", None):
            headers = {}
            for pair in args.headers.split(","):
                if ":" in pair:
                    k, v = pair.split(":", 1)
                    headers[k.strip()] = v.strip()
        if getattr(args, "proxy", None):
            p = args.proxy
            proxies = {"http": p, "https": p}

        timeout = getattr(args, "timeout", 10)
        verbose = not getattr(args, "silent", False)

        stop_all_event = threading.Event()

        for uname in usernames:
            if stop_all_event.is_set():
                break

            print(f"[*] Testing username: {uname}")
            try:
                password, info = bruteforce_form(
                    url=args.url,
                    username=uname,
                    candidates=candidates,
                    workers=getattr(args, "workers", os.cpu_count()),
                    timeout=timeout,
                    proxies=proxies,
                    headers=headers,
                    success_keywords=success_keywords or None,
                    failure_keywords=failure_keywords or None,
                    cookie_names=cookie_names or None,
                    username_hint=username_hint or user_field_override,
                    password_hint=password_hint or pass_field_override,
                    chunk_size=chunk_size,
                    chunk_delay=chunk_delay,
                    verbose=verbose,
                    stop_all_event=stop_all_event,
                )
            except Exception as e:
                print(f"[!] Error saat bruteforce web: {e}")
                continue

            if password:
                reason = info.get("reason") if isinstance(info, dict) else None
                print(f"[OK] {uname}:{password} (reason: {reason})")
                if args.out:
                    save_output(f"[WEB] {args.url} -> {uname}:{password} (reason: {reason})", args.out)
            else:
                print(f"[FAIL] {uname} (no password found)")

    elif args.mode == "ssh":
        if not args.host:
            print("[!] Harus pakai --host")
            return
        if not args.port:
            print("[!] Harus pakai --port")
            return
        candidates = load_candidates(args)
        if not candidates:
            print("[!] Tidak ada kandidat password.")
            return
        if args.username and args.users:
            print("[!] Harus pakai --username atau --users")
            return
        if args.users:
            try:
                with open(args.users, "r", encoding="utf-8", errors="ignore") as f:
                    usernames = [u.strip() for u in f if u.strip()]
            except Exception as e:
                print(f"[!] Gagal baca file users: {e}")
                return
        elif args.username:
            usernames = [args.username]
        else:
            print("[!] Harus pakai --user atau --users")
            return
            
        print(f"[*] Mulai brute force {len(candidates)} kandidat...")
        run_ssh(args, usernames, candidates, verbose)
        
if __name__ == "__main__":
    main()
