------------Comandos básicos SQL (DDL - Data Defination Languege)------------------
--Cria uma base de dados
CREATE DATABASE MuriloSouza;
CREATE DATABASE Health_Clinic_Tarde;

USE Health_Clinic_Tarde;

CREATE TABLE TipoDeUsuario(
	IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
	TituloTipoDeUsuario VARCHAR(13) NOT NULL UNIQUE
);

CREATE TABLE Especialidade(
	IdEspecialidade INT PRIMARY KEY IDENTITY,
	TituloEspecialidade VARCHAR (200) NOT NULL UNIQUE
);

CREATE TABLE Clinica(
	IdClinica INT PRIMARY KEY IDENTITY,
	NomeFantasia VARCHAR (200) NOT NULL,
	RazaoSocial VARCHAR (200) NOT NULL UNIQUE,
	CNPJ CHAR(14) NOT NULL UNIQUE,
	EnderecoClinica VARCHAR (200) NOT NULL,
	HorarioFuncionamento VARCHAR(20) NOT NULL
);