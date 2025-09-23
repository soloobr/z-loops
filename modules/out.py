import os

def save_output(result: str, out_file: str):
    try:
        os.makedirs("output", exist_ok=True)
        if not os.path.dirname(out_file):
            out_file = os.path.join("output", out_file)
        with open(out_file, "a") as f:  
            f.write(result) 
        print(f"[OK] Hasil disimpan ke {out_file}")
    except Exception as e:
        print(f"[!] Gagal menyimpan hasil ke {out_file}: {e}")

def success_singel(h, result, ht):
    return (f"\n[SUCCESS] Password {h} ditemukan: {result} (hash type: {ht})")
    
def success_multiple(h, result, ht):
    return (f"\n[SUCCESS] Hash: {h} -> Password: {result} (type: {ht})")
    
def success_zip(h, result):
    return (f"\n[SUCCESS] Password {h} -> Ditemukan: {result}")

def success_ssh(h, p, result):
    return (f"\n[SUCCESS] {h}:{p} -> {result}")

def failed_ssh(h, p):
    return (f"\n[FAIL] {h}:{p} -> Gagal ditemukan")

def failed_zip(h):
    return (f"\n[FAIL] Password {h} -> Gagal ditemukan")
    
def failed(h):
    return (f"\n[FAIL] Hash: {h} -> Password tidak ditemukan.")
