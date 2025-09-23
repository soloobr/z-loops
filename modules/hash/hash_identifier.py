import re
import base64

HASH_ALGORITHMS = {
    "md2": 32,
    "md4": 32,
    "md5": 32,
    "sha1": 40,
    "sha224": 56,
    "sha256": 64,
    "sha384": 96,
    "sha512": 128,
    "sha3_224": 56,
    "sha3_256": 64,
    "sha3_384": 96,
    "sha3_512": 128,
    "ripemd160": 40,
    "ripemd256": 64,
    "ripemd320": 80,
    "whirlpool": 128,
    "blake2b": 128,
    "blake2s": 64,
    "crc32": 8,
    "adler32": 8,
    "tiger": 48,
    "gost": 64,
    "skein256": 64,
    "skein512": 128,
    "skein1024": 256,
    "keccak224": 56,
    "keccak256": 64,
    "keccak384": 96,
    "keccak512": 128
}

def is_hex(s):
    return re.fullmatch(r"[0-9a-fA-F]+", s) is not None

def is_base64(s):
    try:
        if len(s) % 4 != 0:
            return False
        base64.b64decode(s, validate=True)
        return True
    except Exception:
        return False

def is_numeric(s):
    return s.isdigit()

def identify_hash(hash_str: str):
    target_hash = hash_str
    hash_str = hash_str.strip()
    length = len(hash_str)
    hash_str_lower = hash_str.lower()

    candidates = []

    for algo, algo_len in HASH_ALGORITHMS.items():
        if length == algo_len:
            candidates.append(algo)

    if is_hex(hash_str_lower):
        candidates = [c for c in candidates if c not in ["blake2b", "blake2s"]]
    elif is_base64(hash_str):
        candidates = [c for c in candidates if c in ["blake2b", "blake2s", "sha3_256", "sha3_512"]]
    elif is_numeric(hash_str):
        candidates = [c for c in candidates if c in ["crc32", "adler32"]]

    if target_hash.startswith(("$2a$", "$2b$", "$2y$")):
        candidates.append("bcrypt")
    elif target_hash.startswith("$argon2"):
        candidates.append("argon2")
    elif target_hash.startswith("pbkdf2:"):
        candidates.append("pbkdf2")
    elif target_hash.startswith("scrypt$"):
        candidates.append("scrypt")

    if not candidates:
        return ["unknown"]

    return candidates
