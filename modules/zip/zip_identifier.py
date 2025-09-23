import struct
import os

def identify_zip(zip_path: str) -> str:
    ext = os.path.splitext(zip_path)[1].lower()
    if ext == ".rar":
        return "RAR/Unknown"
    elif ext == ".7z":
        return "7z/Unknown"
    

    with open(zip_path, "rb") as f:
        data = f.read()

    pos = data.find(b'\x01\x99')
    if pos != -1:
        extra = data[pos+4:pos+11]

        if len(extra) >= 7:
            version = struct.unpack("<H", extra[0:2])[0]
            vendor = extra[2:4].decode(errors="ignore")
            strength = extra[4]
            method = struct.unpack("<H", extra[5:7])[0]

            strength_map = {1: 128, 2: 192, 3: 256}
            bits = strength_map.get(strength, "Unknown")

            return f"AES-{bits} (Vendor={vendor}, Version={version}, Method={method})"

    return "ZipCrypto/Unknown"
