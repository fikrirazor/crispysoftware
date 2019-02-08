-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 07, 2019 at 04:50 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
-- Table structure for table `dokter`
--

CREATE TABLE `dokter` (
  `id_dokter` int(11) NOT NULL,
  `nama_dokter` varchar(30) NOT NULL,
  `spesialis` text NOT NULL,
  `sallary_dokter` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `laporan_jumlah_pasien/bulan`
--

CREATE TABLE `laporan_jumlah_pasien/bulan` (
  `id_laporan_pasien` int(11) NOT NULL,
  `jumlah_pasien` int(11) NOT NULL,
  `bulan_ke` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `laporan_keuangan`
--

CREATE TABLE `laporan_keuangan` (
  `idlaporankeuangan` int(11) NOT NULL,
  `tanggallaporan` date NOT NULL,
  `pemasukkan` int(11) NOT NULL,
  `pengeluaran` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `laporan_transaksi_poliklinik`
--

CREATE TABLE `laporan_transaksi_poliklinik` (
  `id_laporan_transaksi` int(11) NOT NULL,
  `total_transaksi` int(11) NOT NULL,
  `bulan_ke` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pasien`
--

CREATE TABLE `pasien` (
  `id_pasien` int(11) NOT NULL,
  `nama_pasien` varchar(30) NOT NULL,
  `umur_pasien` int(2) NOT NULL,
  `gender_pasien` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pegawai_poliklinik`
--

CREATE TABLE `pegawai_poliklinik` (
  `id_pegawai` int(11) NOT NULL,
  `nama_pegawai` varchar(30) NOT NULL,
  `salary_pegawai` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pemilik_poliklinik`
--

CREATE TABLE `pemilik_poliklinik` (
  `id_pemilik` int(11) NOT NULL,
  `nama_poliklinik` varchar(30) NOT NULL,
  `alamat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `poliklinik`
--

CREATE TABLE `poliklinik` (
  `id_poliklinik` int(11) NOT NULL,
  `jenis_poliklinik` text NOT NULL,
  `alamat_poliklinik` text NOT NULL,
  `nama_pemilik` varchar(30) NOT NULL,
  `nama_poliklinik` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_poli`
--

CREATE TABLE `transaksi_poli` (
  `id_transaksi` int(11) NOT NULL,
  `waktu_transaksi` datetime NOT NULL,
  `total_biaya` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dokter`
--
ALTER TABLE `dokter`
  ADD PRIMARY KEY (`id_dokter`);

--
-- Indexes for table `laporan_jumlah_pasien/bulan`
--
ALTER TABLE `laporan_jumlah_pasien/bulan`
  ADD PRIMARY KEY (`id_laporan_pasien`);

--
-- Indexes for table `laporan_keuangan`
--
ALTER TABLE `laporan_keuangan`
  ADD PRIMARY KEY (`idlaporankeuangan`);

--
-- Indexes for table `laporan_transaksi_poliklinik`
--
ALTER TABLE `laporan_transaksi_poliklinik`
  ADD PRIMARY KEY (`id_laporan_transaksi`);

--
-- Indexes for table `pasien`
--
ALTER TABLE `pasien`
  ADD PRIMARY KEY (`id_pasien`);

--
-- Indexes for table `pegawai_poliklinik`
--
ALTER TABLE `pegawai_poliklinik`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indexes for table `pemilik_poliklinik`
--
ALTER TABLE `pemilik_poliklinik`
  ADD PRIMARY KEY (`id_pemilik`);

--
-- Indexes for table `poliklinik`
--
ALTER TABLE `poliklinik`
  ADD PRIMARY KEY (`id_poliklinik`)
  ADD FOREIGN KEY (`nama_poliklinik`) REFERENCES `pemilik_poliklinik`(`nama_poliklinik`);

--
-- Indexes for table `transaksi_poli`
--
ALTER TABLE `transaksi_poli`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `laporan_jumlah_pasien/bulan`
--
ALTER TABLE `laporan_jumlah_pasien/bulan`
  ADD CONSTRAINT `laporan_jumlah_pasien/bulan_ibfk_1` FOREIGN KEY (`id_laporan_pasien`) REFERENCES `pegawai_poliklinik` (`id_pegawai`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
