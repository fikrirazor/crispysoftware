-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 06 Feb 2019 pada 17.43
-- Versi server: 10.1.37-MariaDB
-- Versi PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `poliklinik`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `dokter`
--

CREATE TABLE `dokter` (
  `id_dokter` int(11) NOT NULL,
  `nama_dokter` varchar(30) NOT NULL,
  `spesialis` text NOT NULL,
  `sallary_dokter` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `laporan_jumlah_pasien/bulan`
--

CREATE TABLE `laporan_jumlah_pasien/bulan` (
  `id_laporan_pasien` int(11) NOT NULL,
  `jumlah_pasien` decimal(10,0) NOT NULL,
  `bulan_ke` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `laporan_keuangan`
--

CREATE TABLE `laporan_keuangan` (
  `idlaporankeuangan` int(11) NOT NULL,
  `tanggallaporan` date NOT NULL,
  `pemasukkan` float NOT NULL,
  `pengeluaran` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `laporan_transaksi_poliklinik`
--

CREATE TABLE `laporan_transaksi_poliklinik` (
  `id_laporan_transaksi` int(11) NOT NULL,
  `total_transaksi` float NOT NULL,
  `bulan_ke` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `pasien`
--

CREATE TABLE `pasien` (
  `id_pasien` int(11) NOT NULL,
  `nama_pasien` varchar(30) NOT NULL,
  `umur_pasien` int(11) NOT NULL,
  `gender_pasien` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `pegawai_poliklinik`
--

CREATE TABLE `pegawai_poliklinik` (
  `id_pegawai` int(11) NOT NULL,
  `nama_pegawai` varchar(30) NOT NULL,
  `salary_pegawai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `pemilik_poliklinik`
--

CREATE TABLE `pemilik_poliklinik` (
  `id_pemilik` int(11) NOT NULL,
  `nama_poliklinik` varchar(30) NOT NULL,
  `alamat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `poliklinik`
--

CREATE TABLE `poliklinik` (
  `id_poliklinik` int(11) NOT NULL,
  `jenis_poliklinik` text NOT NULL,
  `alamat_poliklinik` text NOT NULL,
  `nama_pemilik` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi_poli`
--

CREATE TABLE `transaksi_poli` (
  `id_transaksi` int(11) NOT NULL,
  `waktu_transaksi` datetime NOT NULL,
  `total_biaya` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `laporan_keuangan`
--
ALTER TABLE `laporan_keuangan`
  ADD PRIMARY KEY (`idlaporankeuangan`);

--
-- Indeks untuk tabel `pasien`
--
ALTER TABLE `pasien`
  ADD PRIMARY KEY (`id_pasien`);

--
-- Indeks untuk tabel `pegawai_poliklinik`
--
ALTER TABLE `pegawai_poliklinik`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indeks untuk tabel `pemilik_poliklinik`
--
ALTER TABLE `pemilik_poliklinik`
  ADD PRIMARY KEY (`id_pemilik`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
