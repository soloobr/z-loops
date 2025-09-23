import os
import pyzipper
import rarfile
import py7zr


def try_password(file_path: str, password: str) -> bool:
    ext = os.path.splitext(file_path)[1].lower()

    try:
        if ext == ".zip":
            with pyzipper.AESZipFile(file_path) as zf:
                zf.extractall(pwd=password.encode("utf-8"))
            return True

        elif ext == ".rar":
            with rarfile.RarFile(file_path) as rf:
                rf.extractall(pwd=password)
            return True

        elif ext == ".7z":
            with py7zr.SevenZipFile(file_path, mode="r", password=password) as zf:
                zf.extractall()
            return True

        else:
            raise ValueError(f"Tipe file tidak didukung: {ext}")

    except Exception:
        return False


def check_batch_archive(file_path: str,
                        batch: list[str],
                        stop_event,
                        offset: int = 0,
                        total: int = 0,
                        verbose: bool = True,
                        step: int = 10000) -> str | None:
    for i, pwd in enumerate(batch, start=1):
        if stop_event.is_set():
            return None

        idx = offset + i

        if verbose and total and idx % step == 0:
            print(f"[*] Mencoba kandidat [{idx}/{total}]")

        try:
            if try_password(file_path, pwd):
                stop_event.set()
                return pwd
        except Exception:
            continue

    return None
