CREATE DATABASE Exercicio_1_4;

USE Exercicio_1_4;

CREATE TABLE Permissao(
	IdPermissao INT PRIMARY KEY IDENTITY,
	TipoPermissao VARCHAR(15) NOT NULL
);

CREATE TABLE Usuario(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdPermissao INT FOREIGN KEY REFERENCES Permissao(IdPermissao) NOT NULL,
	NomeUsuario VARCHAR(30) NOT NULL
);

CREATE TABLE Empresa(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	NomeEmpresa VARCHAR(15) NOT NULL,
	EmailEmpresa VARCHAR(100) NOT NULL UNIQUE,
	TelefoneEmpresa VARCHAR(15) NOT NULL UNIQUE
);

CREATE TABLE Plataforma(
	IdPlataforma INT PRIMARY KEY IDENTITY,
	IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa) NOT NULL,
	NomePlataforma VARCHAR(25) NOT NULL
);

--Alterar o tipo de dado de uma coluna
ALTER TABLE Plataforma ALTER COLUMN NomePlataforma VARCHAR(100);

CREATE TABLE [Login](
	IdLogin INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
	IdPlataforma INT FOREIGN KEY REFERENCES Plataforma(IdPlataforma) NOT NULL,
	EmailLogin VARCHAR(100) NOT NULL UNIQUE,
	SenhaLogin VARCHAR(100) NOT NULL 
);

CREATE TABLE Artista(
	IdArtista INT PRIMARY KEY IDENTITY,
	NomeArtista VARCHAR(50) NOT NULL
);

CREATE TABLE Estilo(
	IdEstilo INT PRIMARY KEY IDENTITY,
	NomeEstilo VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Album(
	IdAlbum INT PRIMARY KEY IDENTITY,
	IdPlataforma INT FOREIGN KEY REFERENCES Plataforma(IdPlataforma) NOT NULL,
	IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa) NOT NULL,
	IdArtista INT FOREIGN KEY REFERENCES Artista(IdArtista) NOT NULL,
	TituloAlbum VARCHAR(100) NOT NULL,
	LancamentoAlbum DATE NOT NULL,
	AlbumAtivo CHAR(1) NOT NULL,
	DuracaoAlbum TIME NOT NULL,
	LocalizacaoAlbum VARCHAR(100) NOT NULL
);

CREATE TABLE AlbumEstilo(
	IdAlbumEstilo INT PRIMARY KEY IDENTITY,
	IdAlbum INT FOREIGN KEY REFERENCES Album(IdAlbum) NOT NULL,
	IdEstilo INT FOREIGN KEY REFERENCES Estilo(IdEstilo) NOT NULL
);

SELECT * FROM Usuario;