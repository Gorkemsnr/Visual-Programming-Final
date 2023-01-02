-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 02 Oca 2023, 19:56:19
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `spor_salonu`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `membertbl`
--

DROP TABLE IF EXISTS `membertbl`;
CREATE TABLE IF NOT EXISTS `membertbl` (
  `MId` int(11) NOT NULL AUTO_INCREMENT,
  `MName` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `MPhone` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `MGen` varchar(6) COLLATE utf8_turkish_ci NOT NULL,
  `MAge` int(11) NOT NULL,
  `MAmount` int(11) NOT NULL,
  `MTiming` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`MId`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `membertbl`
--

INSERT INTO `membertbl` (`MId`, `MName`, `MPhone`, `MGen`, `MAge`, `MAmount`, `MTiming`) VALUES
(1, 'Görkem', '123123', 'Erkek', 20, 15000, '18:00-20:00'),
(2, '', '', '', 0, 0, ''),
(3, '', '', '', 0, 0, ''),
(4, '', '', '', 0, 0, ''),
(5, 'Murat', '123', 'Erkek', 15, 1, '20:00-22:00'),
(6, 'sadasdsadas', '1232', 'Erkek', 12, 2200, '08:00-10:00'),
(7, 'buuuuseeee', '126465', 'Kadin', 21, 2000, '18:00-20:00'),
(8, 'ilaydaaaaa', '545454', 'Kadin', 20, 145, '08:00-10:00'),
(9, 'muslih', '5454', 'Erkek', 10, 3000, '08:00-10:00'),
(10, 'çagatay', '5454545', 'Erkek', 21, 2500, '18:00-20:00'),
(11, 'qweqwe', '123123', 'Kadin', 23, 12312, '08:00-10:00');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odeme`
--

DROP TABLE IF EXISTS `odeme`;
CREATE TABLE IF NOT EXISTS `odeme` (
  `Pid` int(11) NOT NULL AUTO_INCREMENT,
  `PMonth` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `PMember` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `PAmount` int(11) NOT NULL,
  PRIMARY KEY (`Pid`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `odeme`
--

INSERT INTO `odeme` (`Pid`, `PMonth`, `PMember`, `PAmount`) VALUES
(1, '122022', 'Görkem', 33),
(2, '122022', 'sadasdsadas', 5000),
(3, '122022', 'buuuuseeee', 3000),
(4, '122022', 'ilaydaaaaa', 300),
(5, '122022', 'çagatay', 2000),
(6, '12023', 'Görkem', 50);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
