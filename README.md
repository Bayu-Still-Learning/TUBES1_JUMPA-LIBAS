# TUBES 1 IF2211 – Robocode Tank Royale

## Implementasi Algoritma Greedy pada Robocode Tank Royale

### Kelompok Jumpa-Libas

| Nama                        | NIM       |
| ----------------------      | --------- |
| Bayu Aditya Tarigan         | 124140134 |
| Rafael Alfredo Ginting      | 124140109 |
| Ganda Tua Hamonangan Sitio  | 124140111 |

---

# Deskripsi Project

Project ini merupakan implementasi algoritma greedy pada permainan **Robocode Tank Royale** menggunakan bahasa pemrograman **C# (.NET 6)**.

Pada project ini dibuat 4 bot dengan strategi greedy yang berbeda-beda untuk bertanding secara otomatis di arena Robocode Tank Royale.

Tujuan utama project adalah menganalisis efektivitas berbagai strategi greedy dalam permainan real-time dan menentukan bot dengan performa terbaik berdasarkan hasil pertandingan.

---

# Bot dan Strategi

## 1. BotPertama – Greedy by Distance

Bot akan selalu mengejar musuh terdekat dan menyerang secara agresif.

### Karakteristik

* Fokus pada pertarungan jarak dekat
* Bergerak langsung menuju musuh
* Fire power menyesuaikan jarak

### Kelebihan

* Agresif
* Sederhana
* Efektif pada jarak dekat

### Kekurangan

* Mudah terkena serangan balik
* Kurang efektif melawan bot cepat

---

## 2. BotKedua – Greedy by Hit Probability

Bot menggunakan prediksi posisi musuh untuk meningkatkan akurasi tembakan.

### Karakteristik

* Menggunakan linear prediction
* Menembak ke posisi prediksi musuh
* Menggunakan radar lock

### Kelebihan

* Akurasi tinggi
* Efisien dalam penggunaan peluru

### Kekurangan

* Kurang efektif melawan gerakan acak

---

## 3. BotKetiga – Greedy by Safe Movement

Bot fokus pada pergerakan aman di sekitar arena sambil tetap menyerang lawan.

### Karakteristik

* Bergerak di sepanjang dinding arena
* Menjaga mobilitas tinggi
* Menyerang sambil bergerak

### Kelebihan

* Sulit ditembak
* Stabil dan hemat energi

### Kekurangan

* Damage lebih kecil
* Kurang agresif

---

## 4. BotKeempat – Greedy by Chaos Movement (BOT UTAMA)

Bot menggunakan gerakan acak dan zigzag untuk mempersulit lawan memprediksi posisi bot.

### Karakteristik

* Gerakan chaos dan zigzag
* Perubahan arah mendadak
* Menembak secara agresif

### Kelebihan

* Sangat sulit diprediksi
* Survival tinggi
* Damage besar
* Menjadi pemenang pada hasil pertandingan

### Kekurangan

* Penggunaan energi lebih besar
* Akurasi tidak selalu stabil

---

# Hasil Pertandingan

Berdasarkan hasil pertandingan 10 ronde:

* **BotKeempat memperoleh total score tertinggi**
* Survival score tertinggi
* Bullet damage terbesar
* Menjadi bot dengan kemenangan terbanyak

Strategi **Greedy by Chaos Movement** terbukti menjadi strategi paling efektif pada pengujian project ini.

---

# Teknologi yang Digunakan

* C#
* .NET 6
* Robocode Tank Royale
* Java JDK 11+

---

# Cara Menjalankan Project

## 1. Install Dependencies

### Install:

* Java JDK 11+
* .NET SDK 6.0

---

## 2. Jalankan GUI Robocode

```bash
java -jar robocode-tankroyale-gui-0.30.0.jar
```

---

## 3. Jalankan Bot

Masuk ke folder bot lalu jalankan:

```bash
dotnet run
```

Lakukan untuk setiap bot yang ingin dimainkan.

---

# Struktur Folder

```bash
Tubes_Jumpa-Libas/
│
├── BotPertama.cs
├── BotKedua.cs
├── BotKetiga.cs
├── BotKeempat.cs
│
├── BotPertama.json
├── BotKedua.json
├── BotKetiga.json
├── BotKeempat.json
│
├── Laporan_Final_BotKeempat.docx
│
└── README.md
```

---

# Kesimpulan

Implementasi algoritma greedy pada Robocode Tank Royale berhasil dilakukan melalui empat strategi berbeda. Dari seluruh strategi yang diuji, BotKeempat dengan strategi **Greedy by Chaos Movement** menjadi bot terbaik karena mampu memperoleh score tertinggi dan memenangkan pertandingan terbanyak.

---

# Repository

```bash
git clone ttps://github.com/Bayu-Still-Learning/TUBES1_JUMPA-LIBAS.git  
```

---

# Mata Kuliah

IF2211 – Strategi Algoritma
Institut Teknologi Sumatera
Semester Genap 2026
