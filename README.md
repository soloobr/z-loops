# z-loops v1.09

<div align="center">

```
__________         .____
\____    /         |    |    ____   ____ ______  ______
  /     /   ______ |    |   /  _ \ /  _ \\____ \/  ___/
 /     /_  /_____/ |    |__(  <_> |  <_> )  |_> >___ \
/_______ \         |_______ \____/ \____/|   __/____  >
        \/  v1.09          \/           |__|       \/

```
**By: Adli (Leexy) - Vibe Coding | GitHub: [https://github.com/AdliXSec](https://github.com/AdliXSec)**

</div>

<p align="center">
  <img src="https://img.shields.io/badge/python-3.x-blue.svg" alt="Python 3.x">
  <img src="https://img.shields.io/badge/version-1.09-orange.svg" alt="Version 1.09">
  <img src="https://img.shields.io/badge/license-MIT-green.svg" alt="License MIT">
</p>

**z-loops** adalah sebuah tool bruteforce serbaguna yang canggih, ditulis dalam Python dan dirancang untuk keperluan uji penetrasi, tantangan Capture The Flag (CTF), dan riset keamanan. Tool ini dilengkapi dengan berbagai mode serangan, termasuk cracking hash, brute force pada file arsip (ZIP/RAR), form login web, dan layanan SSH. Dengan fitur seperti serangan berbasis pola (mask), aturan (rules), dan dukungan multi-threading, z-loops menjadi solusi yang fleksibel dan kuat untuk para profesional keamanan siber.

---

## ⚠️ Peringatan Penting

Tool ini dibuat untuk tujuan **penelitian**, **edukasi**, **CTF**, dan **pengujian keamanan yang sah**.

- **JANGAN** gunakan tool ini terhadap sistem apa pun tanpa izin tertulis yang jelas dari pemilik sistem.
- Penyalahgunaan tool ini untuk menyerang target tanpa izin adalah ilegal dan dapat dikenakan sanksi hukum yang serius.
- Pengembang tidak bertanggung jawab atas segala kerusakan atau tindakan ilegal yang disebabkan oleh penggunaan tool ini.

> **Catatan:** Untuk saat ini, mode `web` (Web Bruteforce) belum dapat digunakan secara optimal. Mohon tunggu pembaruan selanjutnya untuk fungsionalitas penuh.

---

## ✨ Daftar Fitur Lengkap

Berikut adalah rincian fitur yang tersedia di z-loops:

### 🎯 Metode Serangan Fleksibel
- **Serangan Kamus (Wordlist Attack)**: Menggunakan daftar kata sandi dari sebuah file (`--wordlist`).
- **Serangan Pola (Mask Attack)**: Membuat kandidat kata sandi berdasarkan pola tertentu, contoh: `?l?l?d?d` untuk dua huruf kecil diikuti dua digit (`--mask`).
- **Serangan Inkremental (Incremental Attack)**: Mencoba semua kemungkinan kombinasi karakter dalam rentang panjang tertentu (`--increment`, `--charset`).
- **Serangan Berbasis Aturan (Rule-Based Attack)**: Memanipulasi kata dari wordlist menggunakan aturan gaya Hashcat untuk menciptakan variasi kata sandi (`--rules`).
- **Generator Pola Cerdas (Smart Pattern Generator)**: Membuat wordlist yang ditargetkan secara dinamis berdasarkan informasi personal seperti nama, tahun, tanggal, dan simbol-simbol umum (`--pattern`, `--name`, `--year`, dll).

### ⚙️ Manajemen Sesi & Performa
- **Multi-threading**: Memanfaatkan beberapa core CPU untuk mempercepat proses cracking secara signifikan (`--workers`).
- **Mode Hening (Silent Mode)**: Menjalankan tool tanpa output verbose untuk proses yang lebih bersih (`--silent`).
- **Pembatasan Eksekusi (Rate Limiting)**: Mengatur jumlah percobaan dan jeda waktu untuk menghindari blokir atau mengurangi beban pada target (`--limit`).
- **Mode Benchmark**: Menguji kecepatan cracking hash pada sistem Anda (`--benchmark`).

### 📦 Fitur Spesifik per Mode

#### 🔐 Mode `hash`
- **Dukungan Hash Luas**: Mampu men-crack berbagai algoritma hash populer, termasuk MD5, SHA1, SHA256, Bcrypt, Argon2, dan banyak lagi.
- **Deteksi Otomatis**: Secara cerdas mendeteksi tipe hash dari input yang diberikan (`--auto`).
- **Identifikasi Hash**: Membantu mengidentifikasi kemungkinan jenis hash jika Anda tidak yakin (`--identify`).
- **Input Fleksibel**: Menerima input hash tunggal dari argumen (`--hash`) atau daftar hash dari sebuah file (`--file`).
- **Lanjutkan Sesi (Resume)**: Kemampuan untuk menghentikan dan melanjutkan sesi cracking tanpa kehilangan progres (`--resume`).

#### 🗂️ Mode `archive`
- **Brute Force Arsip**: Mendukung cracking file arsip yang diproteksi kata sandi (misalnya ZIP, RAR, 7z).
- **Identifikasi Tipe Arsip**: Mengenali jenis file arsip yang menjadi target (`--identify`).

#### 🌐 Mode `web`
- **Deteksi Keberhasilan/Kegagalan**: Mengidentifikasi status login berdasarkan kata kunci di respons HTML atau nama cookie yang diterima (`--success-keywords`, `--failure-keywords`, `--cookie-names`).
- **Penanganan Token CSRF**: Secara otomatis mengekstrak dan mengirim token CSRF untuk melewati proteksi dasar (`--csrf-token-selector`).
- **Kustomisasi Penuh**: Mengizinkan override nama field username/password, penambahan custom HTTP headers, dan pengaturan timeout (`--user-field`, `--pass-field`, `--headers`, `--timeout`).
- **Dukungan Proxy**: Melewatkan semua traffic melalui proxy untuk anonimitas atau debugging (`--proxy`).
- **Input User Ganda**: Menerima input username tunggal (`--username`) atau dari sebuah file daftar user (`--users`).

#### 💻 Mode `ssh`
- **Metode Login Ganda**: Mendukung brute force menggunakan kata sandi (`--method password`) atau melalui file kunci SSH (`--method key`).
- **Port Kustom**: Kemampuan untuk menargetkan layanan SSH yang berjalan di port non-standar (`--port`).
- **Manajemen Timeout**: Mengatur batas waktu koneksi untuk menangani server yang lambat merespons (`--timeout`).

### 📄 Output & Pelaporan
- **Simpan Hasil**: Menyimpan kata sandi yang berhasil ditemukan ke dalam file teks untuk analisis lebih lanjut (`--out`).

---

## 🛠️ Instalasi

1.  **Clone repository ini:**
    ```bash
    git clone [https://github.com/AdliXSec/z-loops.git](https://github.com/AdliXSec/z-loops.git)
    ```

2.  **Masuk ke direktori proyek:**
    ```bash
    cd z-loops
    ```

3.  **Install dependensi yang dibutuhkan:**
    *(Pastikan Anda sudah membuat file `requirements.txt`)*
    ```bash
    pip install -r requirements.txt
    ```

---

## 🚀 Penggunaan (Contoh)

Berikut adalah beberapa contoh penggunaan dasar untuk setiap mode.

### 1. Mode `hash`

- **Mengidentifikasi tipe hash:**
  ```bash
  python main.py hash --identify --hash '5f4dcc3b5aa765d61d8327deb882cf99'
  ```

- **Cracking hash MD5 menggunakan wordlist:**
  ```bash
  python main.py hash --type md5 --hash '5f4dcc3b5aa765d61d8327deb882cf99' --wordlist /usr/share/wordlists/rockyou.txt
  ```

### 2. Mode `archive`

- **Brute force file ZIP menggunakan wordlist:**
  ```bash
  python main.py archive --file rahasia.zip --wordlist /path/to/passwords.txt
  ```

### 3. Mode `web`

- **Brute force login dengan username tunggal:**
  ```bash
  python main.py web --url [http://192.168.1.5/login.php](http://192.168.1.5/login.php) --username admin --wordlist passwords.txt --failure-keywords "Invalid"
  ```

### 4. Mode `ssh`

- **Brute force SSH dengan username tunggal:**
  ```bash
  python main.py ssh --host 10.10.10.2 --username root --wordlist /path/to/passwords.txt
  ```

---

## 📖 Daftar Opsi Lengkap

Untuk melihat semua opsi yang tersedia untuk setiap mode, gunakan flag `-h` atau `--help`.

- **Opsi Utama:**
  ```bash
  python main.py -h
  ```
- **Opsi Mode Hash:**
  ```bash
  python main.py hash -h
  ```
- **Opsi Mode Archive:**
  ```bash
  python main.py archive -h
  ```
- **Opsi Mode Web:**
  ```bash
  python main.py web -h
  ```
- **Opsi Mode SSH:**
  ```bash
  python main.py ssh -h
  ```

---

## 📜 Lisensi

Proyek ini dilisensikan di bawah **Lisensi MIT**. Lihat file `LICENSE` untuk detail lebih lanjut.

---

## 🤝 Kontribusi

Kontribusi sangat diterima! Jika Anda ingin membantu mengembangkan z-loops, silakan buka *issue* untuk mendiskusikan ide atau *submit pull request* untuk perbaikan.