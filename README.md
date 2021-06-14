# rmind

Project pembuatan aplikasi untuk Praktikum PBO

Anggota Kelompok:

Nur Wulan Febriani (20/460557/TK/51146)

Raden Muhammad Banendra Bagaskara (20/460560/TK/51149)

Aplikasi Rmind adalah aplikasi berbasis windows form yang akan membantu penggunanya dalam mengingat-ingat tanggal kadaluwarsa pada barang-barang miliknya. Digunakan 
basis windows form agar notifikasi dapat muncul ketika pengguna sedang menggunakan laptop.

Untuk fitur yang kami tawarkan pada aplikasi ini adalah:

1. User akan diminta untuk menambahkan entry baru. User dapat memberi nama sesuai dengan barang apa yang ingin di-input, kemudian memilih kategori barang tersebut, seperti makanan, minuman, obat-obatan, produk kecantikan, serta dokumen. 
2. Pengguna kemudian memasukkan tanggal kadaluwarsa barang tersebut dan memilih tanggal pengingat yang diinginkan.
3. Pengguna juga dapat menambahkan catatan pada entry apabila diinginkan. 
4. Setelah selesai dan tersimpan, pengguna bisa melihat daftar entry yang sudah dimasukkan. 
5. Pengguna juga dapat melakukan pengurutan berdasarkan nama, tanggal kadaluwarsa terdekat, serta kategori. 
6. Pengguna juga dapat melakukan pencarian dari daftar entry tersebut.
7. Pengguna juga dapat mengedit entry serta menghapusnya

Panduan Penggunaan Aplikasi
1. Pada tampilan awal aplikasi, masukkan entri baru dengan mengisi kolom-kolom yang disediakan. Kolom yang wajib diisi adalah Title, Expired Date, Reminder Date, serta Category, sedangkan kolom Notes dapat dikosongkan.
2. Jika kolom sudah terisi lengkap dan benar, tekan tombol Save agar entri dapat tersimpan.
3. Setelah muncul pemberitahuan bahwa entri telah tersimpan, pengguna dapat melihat daftar entri yang telah tersimpan dengan menekan tombol View All Reminders.
4. Melalui form baru ini, pengguna juga dapat melakukan pengeditan serta penghapusan data yang sudah ada.
5. Sebelum melakukan pengeditan, tekan kolom di samping kiri ID pada entri yang ingin diedit. Setelah data dari entri tersebut tertulis di kolom yang tersedia di sebelah kiri (Title, dll), pengguna dapat mengedit data tersebut jika diinginkan.
6. Setelah melakukan pengeditan, pengguna menekan tombol Update dan melakukan konfirmasi untuk memperbarui entri serta memuat ulang tabel.
7. Jika ingin menghapus entri yang sudah ada, tekan kolom di samping kiri ID pada entri yang ingin dihapus, kemudian tekan tombol Remove dan tabel akan termuat ulang.
8. Pengguna juga dapat melakukan pencarian dengan memasukkan Title lengkap dari entri yang ingin dicari ke dalam kolom bertuliskan Search by title kemudian menekan tombol Search.
9. Tombol back pada tampilan ini dapat digunakan sebagai alternatif untuk kembali ke tampilan awal aplikasi.
10. Tombol reset pada tampilan awal aplikasi dapat digunakan untuk menghapus semua isi kolom apabila diinginkan.
11. Untuk mengecek apakah ada pengingat yang telah diset untuk hari ini, tekan tombol bersimbol .
12. Apabila ada, tabel akan memuat data entri yang memiliki pengingat pada hari tersebut. Jika tidak ada, tabel akan kosong dan apabila pengguna menekan kolom di sebelah kiri ID, maka akan muncul pemberitahuan bahwa tidak ada pengingat untuk hari ini.
13. Pengguna dapat menekan tombol Exit pada tampilan awal aplikasi untuk keluar dari aplikasi.

Class Diagram:

![CASE1-Class](https://user-images.githubusercontent.com/72687883/121920771-8e21c900-cd62-11eb-939d-569f922042b6.png)

Database Diagram:

![diagram](https://user-images.githubusercontent.com/72687883/117361249-fe2b6c80-aee3-11eb-9d4e-65621e6a38b3.jpg)
![BasisData](https://user-images.githubusercontent.com/72687883/117361254-01265d00-aee4-11eb-860a-6b79657d52a1.png)
