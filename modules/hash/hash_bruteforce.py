import time
import os
from ..core import list_supported_hashes, check_batch, load_resume, clear_resume, save_resume
from concurrent.futures import ProcessPoolExecutor, as_completed

def crack_hash(target_hash: str, hash_type: str, candidates: list,
               workers: int = None, batch_size: int = 1000,
               limit: tuple = None, verbose: bool = True,
               resume: bool = False):
    found = None
    total = len(candidates)

    if workers is None:
        workers = os.cpu_count()

    if hash_type not in list_supported_hashes():
        print(f"[!] Hash type '{hash_type}' tidak didukung. Dilewati.")
        return None

    start_index = 0
    if resume:
        state = load_resume(target_hash, hash_type)
        if state and state.get("target_hash") == target_hash:
            start_index = state.get("last_index", 0)
            if verbose:
                print(f"[*] Resume dari index {start_index}/{total}")
        else:
            if verbose:
                print("[!] Resume tidak cocok atau tidak ditemukan, mulai dari awal.")

    if limit:
        chunk_size, delay = limit
    else:
        chunk_size, delay = total, 0

    try:
        for start in range(start_index, total, chunk_size):
            end = min(start + chunk_size, total)
            current_batch = candidates[start:end]

            with ProcessPoolExecutor(max_workers=workers) as executor:
                futures = []
                for i in range(0, len(current_batch), batch_size):
                    batch = current_batch[i:i+batch_size]
                    futures.append(
                        executor.submit(
                            check_batch,
                            batch,
                            target_hash,
                            hash_type,
                            offset=start + i,
                            total=total,
                            verbose=verbose
                        )
                    )

                for future in as_completed(futures):
                    try:
                        result = future.result()
                    except Exception as e:
                        if verbose:
                            print(f"[!] Worker error: {e}")
                        continue

                    if result:
                        found = result
                        for f in futures:
                            f.cancel()
                        executor.shutdown(wait=False, cancel_futures=True)
                        clear_resume(target_hash, hash_type) 
                        return found

            if resume:
                save_resume(target_hash, hash_type, {
                    "target_hash": target_hash,
                    "hash_type": hash_type,
                    "last_index": end
                })

            if delay > 0 and end < total:
                if verbose:
                    print(f"[*] Limit tercapai ({end}/{total}), menunggu {delay} detik...")
                time.sleep(delay)

        if verbose:
            print("[!] Password tidak ditemukan.")
        clear_resume(target_hash, hash_type)
        return None

    except KeyboardInterrupt:
        if resume:
            print("\n[!] Dihentikan user, progress disimpan...")
            save_resume(target_hash, hash_type, {
                "target_hash": target_hash,
                "hash_type": hash_type,
                "last_index": max(start, start_index)  
            })
        return None
