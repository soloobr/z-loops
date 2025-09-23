import itertools
import string
import json
import os

SAVE_DIR = "save"
RESUME_FILE = os.path.join(SAVE_DIR, "resume.json")

os.makedirs(SAVE_DIR, exist_ok=True)

MASK_CHARSETS = {
    "?l": string.ascii_lowercase,
    "?u": string.ascii_uppercase,
    "?d": string.digits,
    "?s": "!@#$%^&*()-_=+[]{}",
    "?a": string.ascii_letters + string.digits + "!@#$%^&*()-_=+[]{}",
}

MONTHS = [
    "01","02","03","04","05","06","07","08","09","10","11","12",
    "jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec"
]

DAYS = [
    "senin","selasa","rabu","kamis","jumat","sabtu","minggu",
    "monday","tuesday","wednesday","thursday","friday","saturday","sunday"
]

DATES = [str(i).zfill(2) for i in range(1,32)]

def incremental_generator(min_len: int, max_len: int, charset: str):
    for length in range(min_len, max_len + 1):
        for combo in itertools.product(charset, repeat=length):
            yield "".join(combo)

def parse_charset(charset_opts: list[str]) -> str:
    available_sets = {
        "lower": "abcdefghijklmnopqrstuvwxyz",
        "upper": "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
        "digits": "0123456789",
        "symbols": "!@#$%^&*()-_=+[]{};:,.<>?/\\|",
    }

    charset = ""
    for opt in charset_opts:
        if opt in available_sets:
            charset += available_sets[opt]
        else:
            charset += opt  
    return "".join(sorted(set(charset))) 


def get_resume_file(target_hash: str, hash_type: str) -> str:
    safe_hash = target_hash[:12] 
    return os.path.join(SAVE_DIR, f"resume_{hash_type}_{safe_hash}.json")


def save_resume(target_hash: str, hash_type: str, state: dict):
    path = get_resume_file(target_hash, hash_type)
    with open(path, "w") as f:
        json.dump(state, f, indent=4)


def load_resume(target_hash: str, hash_type: str):
    path = get_resume_file(target_hash, hash_type)
    if os.path.exists(path):
        with open(path, "r") as f:
            return json.load(f)
    return None


def clear_resume(target_hash: str, hash_type: str):
    path = get_resume_file(target_hash, hash_type)
    if os.path.exists(path):
        os.remove(path)

def parse_mask(mask):
    pools = []
    i = 0
    while i < len(mask):
        if mask[i] == "?" and i + 1 < len(mask):
            token = mask[i:i+2]
            if token in MASK_CHARSETS:
                pools.append(MASK_CHARSETS[token])
                i += 2
                continue
        pools.append(mask[i])
        i += 1
    return pools

def generate_from_mask(mask):
    pools = parse_mask(mask)
    pools = [p if isinstance(p, str) and len(p) > 1 else [p] for p in pools]

    for combo in itertools.product(*pools):
        yield "".join(combo)

def generate_patterns(base_words: list, years: list = None, months: list = None, days: list = None, dates: list = None, symbols: list = None):
    candidates = set()
    candidates.update(base_words)

    if years:
        for word in base_words:
            for year in years:
                candidates.add(f"{word}{year}")
                candidates.add(f"{year}{word}")

    if months:
        for word in base_words:
            for m in months:
                candidates.add(f"{word}{m}")
                candidates.add(f"{m}{word}")

    if dates:
        for word in base_words:
            for d in dates:
                candidates.add(f"{word}{d}")
                candidates.add(f"{d}{word}")

    if days:
        for word in base_words:
            for h in days:
                candidates.add(f"{word}{h}")
                candidates.add(f"{h}{word}")

    if symbols:
        for word in base_words:
            for sym in symbols:
                candidates.add(f"{word}{sym}")
                candidates.add(f"{sym}{word}")

    if years and symbols and months and dates and days:
        for word in base_words:
            for year in years:
                for m in months:
                    for d in dates:
                        for h in days:
                            for sym in symbols:
                                candidates.add(f"{word}{year}{m}{d}{h}{sym}")
                                candidates.add(f"{sym}{word}{h}{d}{m}{year}")

    return list(candidates)

def brute_force_charset(length: int, charset: str = "abcdefghijklmnopqrstuvwxyz0123456789"):
    for combo in itertools.product(charset, repeat=length):
        yield "".join(combo)
