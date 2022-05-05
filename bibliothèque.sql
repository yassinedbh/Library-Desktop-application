-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 05 mai 2022 à 01:48
-- Version du serveur :  10.4.18-MariaDB
-- Version de PHP : 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bibliothèque`
--

-- --------------------------------------------------------

--
-- Structure de la table `cd`
--

CREATE TABLE `cd` (
  `id` int(11) NOT NULL,
  `auteur` varchar(255) NOT NULL,
  `Titre` varchar(255) NOT NULL,
  `quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `cd`
--

INSERT INTO `cd` (`id`, `auteur`, `Titre`, `quantite`) VALUES
(1, 'J. K. Rowling', 'Harry Potter', 15);

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
--

CREATE TABLE `emprunt` (
  `id` int(11) NOT NULL,
  `cin` varchar(255) NOT NULL,
  `idouvrage` int(11) NOT NULL,
  `DebutEmprunt` date NOT NULL,
  `FinEmprunt` date DEFAULT NULL,
  `dateRetour` date NOT NULL,
  `typeouvrage` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `emprunt`
--

INSERT INTO `emprunt` (`id`, `cin`, `idouvrage`, `DebutEmprunt`, `FinEmprunt`, `dateRetour`, `typeouvrage`) VALUES
(1, 'AZECD5E58EE', 1, '2022-05-01', '2022-05-05', '2022-05-04', 'livre'),
(2, 'AKZKAZDDCE', 1, '2022-05-03', '2022-05-04', '0000-00-00', 'livre');

-- --------------------------------------------------------

--
-- Structure de la table `livre`
--

CREATE TABLE `livre` (
  `id` int(11) NOT NULL,
  `auteur` varchar(255) NOT NULL,
  `Titre` varchar(255) NOT NULL,
  `Editeur` varchar(255) NOT NULL,
  `quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `livre`
--

INSERT INTO `livre` (`id`, `auteur`, `Titre`, `Editeur`, `quantite`) VALUES
(1, 'Robert Kiyosaki', 'Père riche Père pauvre', 'Paul', 8),
(2, 'Marc Levy', 'Où es-tu ?', 'Elsa', 7);

-- --------------------------------------------------------

--
-- Structure de la table `periodicite`
--

CREATE TABLE `periodicite` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `periodicite` varchar(255) NOT NULL,
  `quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `periodicite`
--

INSERT INTO `periodicite` (`id`, `nom`, `periodicite`, `quantite`) VALUES
(1, 'Periodicité 1', 'Periodicité 1', 5);

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL,
  `modifiedby` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `username`, `email`, `password`, `role`, `modifiedby`) VALUES
(1, 'admin', 'admin', 'admin', 'admin', ''),
(3, 'test', 'test@gmail.com', 'test', 'user', 'user');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `cd`
--
ALTER TABLE `cd`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `livre`
--
ALTER TABLE `livre`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `periodicite`
--
ALTER TABLE `periodicite`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `cd`
--
ALTER TABLE `cd`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `emprunt`
--
ALTER TABLE `emprunt`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `livre`
--
ALTER TABLE `livre`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `periodicite`
--
ALTER TABLE `periodicite`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
