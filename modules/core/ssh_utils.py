import socket
import time
from typing import List, Optional, Tuple, Any
import paramiko


def _peek_ssh_banner(host: str, port: int, timeout: float = 3.0) -> bool:
    try:
        with socket.create_connection((host, port), timeout=timeout) as s:
            s.settimeout(timeout)
            data = s.recv(256)
            if not data:
                return False
            return data.startswith(b"SSH-")
    except Exception:
        return False


def try_ssh_password(
    host: str,
    port: int,
    username: str,
    password: str,
    timeout: float = 8.0,
    banner_timeout: float = 8.0,
    max_retries: int = 1,
    backoff_base: float = 0.5,
) -> Tuple[bool, str]:
    
    if not _peek_ssh_banner(host, port, timeout=min(3.0, timeout)):
        return False, "no_ssh_banner"

    attempt = 0
    while attempt <= max_retries:
        attempt += 1
        client: Optional[paramiko.SSHClient] = None
        try:
            client = paramiko.SSHClient()
            client.set_missing_host_key_policy(paramiko.AutoAddPolicy())
            client.connect(
                hostname=host,
                port=port,
                username=username,
                password=password,
                timeout=timeout,
                banner_timeout=banner_timeout,
                auth_timeout=timeout,
                allow_agent=False,
                look_for_keys=False,
            )
            try:
                stdin, stdout, stderr = client.exec_command("echo __ssh_ok__", timeout=3)
                out = stdout.read().decode(errors="ignore")
                client.close()
                if "__ssh_ok__" in out:
                    return True, "password"
                return True, "password_no_echo"
            except Exception:
                try:
                    client.close()
                except Exception:
                    pass
                return True, "password_no_cmd"
        except paramiko.AuthenticationException:
            return False, "auth_failed"
        except paramiko.SSHException as e:
            if attempt > max_retries:
                return False, f"ssh_exception:{e}"
            sleep = backoff_base * (2 ** (attempt - 1))
            time.sleep(sleep)
            continue
        except (socket.timeout, socket.error, OSError) as e:
            if attempt > max_retries:
                return False, f"network_error:{e}"
            sleep = backoff_base * (2 ** (attempt - 1))
            time.sleep(sleep)
            continue
        except Exception as e:
            return False, f"unknown_error:{e}"
        finally:
            try:
                if client:
                    client.close()
            except Exception:
                pass

    return False, "unknown_error"




def try_ssh_keyfile(
    host: str,
    port: int,
    username: str,
    key_path: str,
    timeout: float = 8.0,
    banner_timeout: float = 8.0,
    max_retries: int = 1,
    backoff_base: float = 0.5,
) -> Tuple[bool, str]:
    if not _peek_ssh_banner(host, port, timeout=min(3.0, timeout)):
        return False, "no_ssh_banner"

    pkey = None
    loaders = [paramiko.Ed25519Key, paramiko.RSAKey, paramiko.ECDSAKey, paramiko.DSSKey]
    for L in loaders:
        try:
            pkey = L.from_private_key_file(key_path)
            break
        except Exception:
            pkey = None
            continue
    if pkey is None:
        return False, "key_load_failed"

    attempt = 0
    while attempt <= max_retries:
        attempt += 1
        client: Optional[paramiko.SSHClient] = None
        try:
            client = paramiko.SSHClient()
            client.set_missing_host_key_policy(paramiko.AutoAddPolicy())
            client.connect(
                hostname=host,
                port=port,
                username=username,
                pkey=pkey,
                timeout=timeout,
                banner_timeout=banner_timeout,
                auth_timeout=timeout,
                allow_agent=False,
                look_for_keys=False,
            )
            try:
                stdin, stdout, stderr = client.exec_command("echo __ssh_ok__", timeout=3)
                out = stdout.read().decode(errors="ignore")
                client.close()
                if "__ssh_ok__" in out:
                    return True, "key"
                return True, "key_no_echo"
            except Exception:
                try:
                    client.close()
                except Exception:
                    pass
                return True, "key_no_cmd"

        except paramiko.AuthenticationException:
            return False, "auth_failed"

        except paramiko.SSHException as e:
            if attempt > max_retries:
                return False, f"ssh_exception:{e}"
            time.sleep(backoff_base * (2 ** (attempt - 1)))
            continue

        except (socket.timeout, socket.error, OSError) as e:
            if attempt > max_retries:
                return False, f"network_error:{e}"
            time.sleep(backoff_base * (2 ** (attempt - 1)))
            continue

        except Exception as e:
            return False, f"unknown_error:{e}"

        finally:
            try:
                if client:
                    client.close()
            except Exception:
                pass

    return False, "unknown_error"


def check_batch_ssh_password(
    host: str,
    port: int,
    user: str,
    batch: List[str],
    stop_event,
    offset: int = 0,
    total: int = 0,
    verbose: bool = True,
    log_step: int = 1000,
    timeout: float = 8.0,
    banner_timeout: float = 8.0,
    max_retries: int = 1,
) -> Optional[str]:
    for i, pwd in enumerate(batch, start=1):
        if stop_event.is_set():
            return None

        idx = offset + i
        if verbose and total and idx % log_step == 0:
            print(f"[*] [{user}] trying [{idx}/{total}] -> {pwd}", flush=True)

        ok, reason = try_ssh_password(
            host, port, user, pwd,
            timeout=timeout,
            banner_timeout=banner_timeout,
            max_retries=max_retries
        )

       
        if ok:
            try:
                stop_event.set()
            except Exception:
                pass
            return f"{user}:{pwd}"
        if verbose and reason not in ("auth_failed", "unknown_error"):
            print(f"[!] [{user}] attempt {pwd} -> {reason}", flush=True)

    return None


def check_batch_ssh_keys(
    host: str,
    port: int,
    user: str,
    key_batch: List[str],
    stop_event,
    offset: int = 0,
    total_keys: int = 0,
    verbose: bool = True,
    log_step: int = 100,
    timeout: float = 8.0,
    banner_timeout: float = 8.0,
    max_retries: int = 1,
) -> Optional[str]:
    for i, keypath in enumerate(key_batch, start=1):
        if stop_event.is_set():
            return None

        idx = offset + i
        if verbose and total_keys and idx % log_step == 0:
            print(f"[*] [{user}] trying key [{idx}/{total_keys}] -> {keypath}", flush=True)

        ok, reason = try_ssh_keyfile(
            host, port, user, keypath,
            timeout=timeout,
            banner_timeout=banner_timeout,
            max_retries=max_retries
        )

        if ok:
            try:
                stop_event.set()
            except Exception:
                pass
            return f"{user}:{keypath}"

        if verbose and reason not in ("auth_failed", "key_load_failed", "unknown_error"):
            print(f"[!] [{user}] key {keypath} -> {reason}", flush=True)

    return None
