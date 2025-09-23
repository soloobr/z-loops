import os
import time
import multiprocessing
from concurrent.futures import ProcessPoolExecutor, as_completed
from ..core import check_batch_archive

def crack_archive(
    file_path: str,
    candidates: list[str],
    workers: int = None,
    batch_size: int = 1000,
    limit: tuple = None,
    verbose: bool = True,
    log_interval: int = 10000,
) -> str | None:
    found = None
    total = len(candidates)
    if workers is None:
        workers = os.cpu_count()

    if limit:
        chunk_size, delay = limit
    else:
        chunk_size, delay = total, 0

    stop_event = multiprocessing.Manager().Event()

    try:
        for start in range(0, total, chunk_size):
            end = min(start + chunk_size, total)
            current_batch = candidates[start:end]

            if verbose:
                print(f"[*] Processing batch {start}-{end} dari {total}", flush=True)

            with ProcessPoolExecutor(max_workers=workers) as executor:
                futures = []
                for i in range(0, len(current_batch), batch_size):
                    batch = current_batch[i:i + batch_size]
                    futures.append(
                        executor.submit(
                            check_batch_archive,
                            file_path,
                            batch,
                            stop_event,
                            start + i,
                            total,
                            verbose,
                            log_interval,
                        )
                    )

                for future in as_completed(futures):
                    try:
                        result = future.result()
                    except Exception as e:
                        if verbose:
                            print(f"[!] Worker error: {e}", flush=True)
                        continue

                    if result:
                        found = result
                        stop_event.set()
                        return found

            if delay > 0 and end < total:
                if verbose:
                    print(f"[*] Limit tercapai ({end}/{total}), menunggu {delay} detik...", flush=True)
                time.sleep(delay)

        if not found and verbose:
            print("[-] Password tidak ditemukan.", flush=True)

        return found

    except KeyboardInterrupt:
        if verbose:
            print("\n[!] Dihentikan user, keluar dengan aman...", flush=True)
        return None