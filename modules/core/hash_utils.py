import hashlib

try:
    import bcrypt
    HAS_BCRYPT = True
except ImportError:
    HAS_BCRYPT = False

try:
    from argon2 import PasswordHasher
    HAS_ARGON2 = True
    argon2_hasher = PasswordHasher()
except ImportError:
    HAS_ARGON2 = False


def list_supported_hashes():
    hashes = sorted(hashlib.algorithms_available)
    if HAS_BCRYPT:
        hashes.append("bcrypt")
    hashes.append("pbkdf2")
    hashes.append("scrypt")
    if HAS_ARGON2:
        hashes.append("argon2")
    return sorted(set(hashes))


def verify_password(password: str, target_hash: str, hash_type: str) -> bool:
    if hash_type == "bcrypt":
        if not HAS_BCRYPT:
            raise RuntimeError("bcrypt tidak tersedia. Install dengan: pip install bcrypt")
        return bcrypt.checkpw(password.encode(), target_hash.encode())

    if hash_type == "pbkdf2":
        try:
            algo, iterations, salt, real_hash = target_hash.split("$", 3)
            dk = hashlib.pbkdf2_hmac(
                algo.split(":")[1].encode().decode(),
                password.encode(),
                salt.encode(),
                int(iterations)
            )
            return dk.hex() == real_hash
        except Exception:
            return False

    if hash_type == "scrypt":
        try:
            _, N, r, p, salt, real_hash = target_hash.split("$", 5)
            dk = hashlib.scrypt(
                password.encode(),
                salt=salt.encode(),
                n=int(N), r=int(r), p=int(p)
            )
            return dk.hex() == real_hash
        except Exception:
            return False

    if hash_type == "argon2":
        if not HAS_ARGON2:
            raise RuntimeError("argon2 tidak tersedia. Install dengan: pip install argon2-cffi")
        try:
            argon2_hasher.verify(target_hash, password)
            return True
        except Exception:
            return False

    if not hasattr(hashlib, hash_type):
        raise ValueError(f"Hash type '{hash_type}' tidak dikenal.")

    return getattr(hashlib, hash_type)(password.encode()).hexdigest() == target_hash.lower()


def check_batch(batch: list, target_hash: str, hash_type: str,
                offset: int = 0, total: int = 0, step: int = 10000, verbose: bool = True):
    for i, pwd in enumerate(batch, start=1):
        idx = offset + i

        if verbose and total and idx % step == 0:
            print(f"[*] Mencoba kandidat [{idx}/{total}]")

        try:
            if verify_password(pwd, target_hash, hash_type):
                return pwd
        except Exception:
            continue

    return None