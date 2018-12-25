-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  mar. 25 déc. 2018 à 13:27
-- Version du serveur :  10.1.35-MariaDB
-- Version de PHP :  7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `poc`
--

-- --------------------------------------------------------

--
-- Structure de la table `bibliothecaire`
--

CREATE TABLE `bibliothecaire` (
  `user` varchar(50) NOT NULL,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

CREATE TABLE `compte` (
  `user` varchar(50) NOT NULL,
  `passe` varchar(100) NOT NULL,
  `type` enum('Etudiant','Enseignant') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `compte`
--

INSERT INTO `compte` (`user`, `passe`, `type`) VALUES
('fgdfgd', 'dfgdfg', 'Enseignant'),
('houssam', '123456', 'Etudiant');

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
--

CREATE TABLE `emprunt` (
  `code_emprunteur` int(10) NOT NULL,
  `code_ouvrage` int(10) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `emprunteur`
--

CREATE TABLE `emprunteur` (
  `id_emprunteur` int(10) NOT NULL,
  `user` varchar(50) NOT NULL,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `emprunteur`
--

INSERT INTO `emprunteur` (`id_emprunteur`, `user`, `nom`, `prenom`) VALUES
(1111, 'houssam', 'houssam', 'boudiar');

-- --------------------------------------------------------

--
-- Structure de la table `enseignant`
--

CREATE TABLE `enseignant` (
  `matricule` int(10) NOT NULL,
  `grade` enum('Maître Assistant A','Maître Assistant B','Maître Conférence A','Maître Conférence B','Professeur') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `enseignant`
--

INSERT INTO `enseignant` (`matricule`, `grade`) VALUES
(1111, 'Maître Conférence B');

-- --------------------------------------------------------

--
-- Structure de la table `etudiant`
--

CREATE TABLE `etudiant` (
  `num_carte` int(10) NOT NULL,
  `specialite` enum('GL','RSD','TI','SI') NOT NULL,
  `niveau` enum('L1','L2','L3','M1','M2') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `etudiant`
--

INSERT INTO `etudiant` (`num_carte`, `specialite`, `niveau`) VALUES
(1111, 'GL', 'M1');

-- --------------------------------------------------------

--
-- Structure de la table `liste_attente`
--

CREATE TABLE `liste_attente` (
  `code_emprunteur` int(10) NOT NULL,
  `code_ouvrage` int(10) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `ouvrage`
--

CREATE TABLE `ouvrage` (
  `code` int(10) NOT NULL,
  `titre` varchar(100) NOT NULL,
  `auteurs` varchar(500) NOT NULL,
  `theme` varchar(100) NOT NULL,
  `type` enum('Livre','Thèses','Mémoires') NOT NULL,
  `mots_cle` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `ouvrage`
--

INSERT INTO `ouvrage` (`code`, `titre`, `auteurs`, `theme`, `type`, `mots_cle`) VALUES
(3, 'hfghf', 'fghfgh', 'fghf', 'Thèses', 'fghfg'),
(4, 'testbook', 'houssam, test', 'testtheme', 'Livre', 'test, test');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `date_reservation` datetime NOT NULL,
  `id_emprunteur` int(10) NOT NULL,
  `code_ouvrage` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `bibliothecaire`
--
ALTER TABLE `bibliothecaire`
  ADD KEY `user` (`user`);

--
-- Index pour la table `compte`
--
ALTER TABLE `compte`
  ADD PRIMARY KEY (`user`);

--
-- Index pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD KEY `code_etudiant` (`code_emprunteur`),
  ADD KEY `code_ouvrage` (`code_ouvrage`);

--
-- Index pour la table `emprunteur`
--
ALTER TABLE `emprunteur`
  ADD PRIMARY KEY (`id_emprunteur`),
  ADD KEY `user` (`user`);

--
-- Index pour la table `enseignant`
--
ALTER TABLE `enseignant`
  ADD KEY `matricule` (`matricule`);

--
-- Index pour la table `etudiant`
--
ALTER TABLE `etudiant`
  ADD KEY `num_carte` (`num_carte`);

--
-- Index pour la table `liste_attente`
--
ALTER TABLE `liste_attente`
  ADD KEY `code_etudiant` (`code_emprunteur`),
  ADD KEY `code_ouvrage` (`code_ouvrage`);

--
-- Index pour la table `ouvrage`
--
ALTER TABLE `ouvrage`
  ADD PRIMARY KEY (`code`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD KEY `num_carte` (`id_emprunteur`),
  ADD KEY `code_ouvrage` (`code_ouvrage`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `emprunteur`
--
ALTER TABLE `emprunteur`
  MODIFY `id_emprunteur` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11111112;

--
-- AUTO_INCREMENT pour la table `ouvrage`
--
ALTER TABLE `ouvrage`
  MODIFY `code` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `bibliothecaire`
--
ALTER TABLE `bibliothecaire`
  ADD CONSTRAINT `bibliothecaire_ibfk_1` FOREIGN KEY (`user`) REFERENCES `compte` (`user`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD CONSTRAINT `emprunt_ibfk_1` FOREIGN KEY (`code_emprunteur`) REFERENCES `emprunteur` (`id_emprunteur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `emprunt_ibfk_2` FOREIGN KEY (`code_ouvrage`) REFERENCES `ouvrage` (`code`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `emprunteur`
--
ALTER TABLE `emprunteur`
  ADD CONSTRAINT `emprunteur_ibfk_1` FOREIGN KEY (`user`) REFERENCES `compte` (`user`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `enseignant`
--
ALTER TABLE `enseignant`
  ADD CONSTRAINT `enseignant_ibfk_1` FOREIGN KEY (`matricule`) REFERENCES `emprunteur` (`id_emprunteur`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `etudiant`
--
ALTER TABLE `etudiant`
  ADD CONSTRAINT `etudiant_ibfk_1` FOREIGN KEY (`num_carte`) REFERENCES `emprunteur` (`id_emprunteur`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `liste_attente`
--
ALTER TABLE `liste_attente`
  ADD CONSTRAINT `liste_attente_ibfk_1` FOREIGN KEY (`code_emprunteur`) REFERENCES `emprunteur` (`id_emprunteur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `liste_attente_ibfk_2` FOREIGN KEY (`code_ouvrage`) REFERENCES `ouvrage` (`code`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`id_emprunteur`) REFERENCES `emprunteur` (`id_emprunteur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`code_ouvrage`) REFERENCES `ouvrage` (`code`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
