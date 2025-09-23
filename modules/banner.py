import argparse
import os
from modules.core import list_supported_hashes

def build_parser():
    parser = argparse.ArgumentParser(
        description="🔑 Advanced Brute Force Tool"
    )

    parent_parser = argparse.ArgumentParser(add_help=False)
    parent_parser.add_argument("--limit", nargs=2, type=int, help="Limit eksekusi (contoh: --limit 3 4 -> 3 kandidat lalu jeda 4 detik)")
    parent_parser.add_argument("--silent", action="store_true", help="Non-verbose mode (silent)")
    parent_parser.add_argument("--workers", type=int, default=os.cpu_count(), help=f"Jumlah workers (default = {os.cpu_count()} CPU core)")
    parent_parser.add_argument("--benchmark", action="store_true", help="Gunakan mode benchmark")
    parent_parser.add_argument("--wordlist", help="Wordlist password")
    parent_parser.add_argument("--out", help="Simpan hasil ke file (contoh: --out hasil.txt)")
    parent_parser.add_argument("--mask", help="Gunakan pola mask (contoh: ?l?l?d?d untuk 2 huruf kecil + 2 angka)")
    parent_parser.add_argument("--increment", nargs=2, metavar=("MIN", "MAX"), type=int, help="Gunakan mode incremental brute force dengan panjang MIN sampai MAX")
    parent_parser.add_argument("--charset",  nargs="+", help="Charset yang digunakan (contoh: lower, upper, digits, symbols, atau kombinasi)")
    parent_parser.add_argument("--rules", help="File rules (Hashcat-style subset)")
    parent_parser.add_argument("--rule-limit", type=int, default=None, help="Max varian rules per base (default=None => semua)")
    parent_parser.add_argument("--pattern", action="store_true", help="Gunakan generator pola")
    parent_parser.add_argument("--name", help="Nama dasar untuk pola (opsional)")
    parent_parser.add_argument("--year", nargs="*", type=int, help="Daftar tahun (ex: 1999 2001 2025)")
    parent_parser.add_argument("--symbols", nargs="*", help="Simbol tambahan (ex: ! @ #)")
    parent_parser.add_argument("--use-months", action="store_true", help="Tambahkan bulan ke pola")
    parent_parser.add_argument("--use-dates", action="store_true", help="Tambahkan tanggal (01-31)")
    parent_parser.add_argument("--use-days", action="store_true", help="Tambahkan nama hari")

    subparsers = parser.add_subparsers(dest="mode", help="Mode bruteforce yang tersedia")

    hash_parser = subparsers.add_parser("hash", parents=[parent_parser], help="Bruteforce hash")
    hash_parser.add_argument("--hash", help="Hash target yang ingin di-crack")
    hash_parser.add_argument("--file", help="File berisi daftar hash (satu baris = satu hash)")
    hash_parser.add_argument(
        "--type",
        help=f"Jenis hash (contoh: md5, sha1, sha256, dll). Didukung: {', '.join(list_supported_hashes())}"
    )
    hash_parser.add_argument("--resume", action="store_true", help="Gunakan resume untuk checkpoint")
    hash_parser.add_argument("--auto", action="store_true", help="Deteksi otomatis jenis hash")
    hash_parser.add_argument("--identify", action="store_true", help="Identifikasi tipe hash target")

    archive_parser = subparsers.add_parser("archive", parents=[parent_parser], help="Bruteforce file archive")
    archive_parser.add_argument("--file", required=True, help="Path ke file archive")
    archive_parser.add_argument("--identify", action="store_true", help="Identifikasi tipe archive target")

    web_parser = subparsers.add_parser("web", parents=[parent_parser], help="Bruteforce login web")

    web_parser.add_argument("--url", required=True, help="Target login page URL")
    web_parser.add_argument("--username", help="Single username")
    web_parser.add_argument("--users", help="File berisi list username")
    web_parser.add_argument("--user-field", help="Override nama field username")
    web_parser.add_argument("--pass-field", help="Override nama field password")
    web_parser.add_argument("--success-keywords", help="Kata kunci menandakan login berhasil (comma separated)")
    web_parser.add_argument("--failure-keywords", help="Kata kunci menandakan login gagal (comma separated)")  
    web_parser.add_argument("--cookie-names", help="Nama cookie menandakan login berhasil (comma separated)") 
    web_parser.add_argument("--csrf-token-selector", dest="csrf_token_selector",
                        help='CSS selector untuk mencari token CSRF (contoh: \'input[name=csrf_token]\')')
    web_parser.add_argument("--username-hint", help="Hint pencarian field username")
    web_parser.add_argument("--password-hint", help="Hint pencarian field password")
    web_parser.add_argument("--proxy", help="Gunakan proxy, ex: http://127.0.0.1:8080")
    web_parser.add_argument("--headers", help="Tambahan HTTP headers, format k:v,k:v")
    web_parser.add_argument("--timeout", type=int, default=10, help="Timeout request (default=10)")

    ssh_parser = subparsers.add_parser("ssh", parents=[parent_parser], help="Bruteforce login web")
    ssh_parser.add_argument("--host", required=True, help="Target SSH host")
    ssh_parser.add_argument("--port", type=int, default=22, help="SSH port (default=22)")
    ssh_parser.add_argument("--username", help="Single username")
    ssh_parser.add_argument("--users", help="File berisi list username")
    ssh_parser.add_argument("--method", choices=["password", "key"], default="password", help="Metode login (default=password)")
    ssh_parser.add_argument("--ssh-key", help="Path ke file SSH key")
    ssh_parser.add_argument("--timeout", type=int, default=8, help="Timeout request (default=8)")
    
    

    return parser

def banner():
    return (r"""
__________         .____                               
\____    /         |    |    ____   ____ ______  ______
  /     /   ______ |    |   /  _ \ /  _ \\____ \/  ___/
 /     /_  /_____/ |    |__(  <_> |  <_> )  |_> >___ \ 
/_______ \         |_______ \____/ \____/|   __/____  >
        \/  v1.09          \/            |__|       \/ 
        
 | By : Adli (Leexy) - Vibe Coding
 | Github : https://github.com/AdliXSec""")
    
def alert(alert = None):
    print(f"""
[!] WARNING: This tool is for research, CTF, and authorized security testing only.
[!] DO NOT use against systems without explicit permission.
[!] Misuse of this tool may be illegal and punishable under law.""")
    print('\n[!] ' + alert + '\n' if alert else '')
    
def benchmark(workers, trials, elapsed, speed):
    return (f"""
[!] Benchmark Report
    Workers   : {workers or 'default (CPU cores)'}
    Trials    : {trials}
    Waktu     : {elapsed:.2f} detik
    Kecepatan : {speed:.2f} hash/sec""")
