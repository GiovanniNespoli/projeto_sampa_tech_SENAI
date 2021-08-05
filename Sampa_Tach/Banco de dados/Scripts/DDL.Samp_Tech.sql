CREATE DATABASE Sampa_tech;
GO

USE SAMPA_Tech;
GO

CREATE TABLE Usuario
(
	idUsuario  INT PRIMARY KEY IDENTITY
	,nomeUsuario  VARCHAR(100) NOT NULL
	,Email        VARCHAR(255) UNIQUE NOT NULL
	,Senha        VARCHAR(255) NOT NULL
	,TipoUsuario  BIT NOT NULL
);
GO

CREATE TABLE Sala
(
		idSala    INT PRIMARY KEY IDENTITY
		,Andar     VARCHAR(50) NOT NULL
		,Nome      VARCHAR(100)NOT NULL
		,MetragemSala   VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Equipamento
(
  idEquipamento int primary key identity
    ,Marca varchar (100) not null
    ,TipoEquipamento varchar (200) not null
    ,NumeroSerie    varchar (255) not null
    ,Descricao        varchar (255) not null
    ,AtivoInativo    BIT NOT NULL
	,NumeroPatrimonio    VARCHAR (50) NOT NULL
);
GO

CREATE TABLE SalaEquip
(
	idSalaEquip INT primary key identity
	,idSala INT FOREIGN KEY REFERENCES Sala(idSala)
	,idEquipamento INT FOREIGN KEY REFERENCES Equipamento(idEquipamento)
	,DataEntrada  DATE NOT NULL
	,DataSaida    DATE 
);
GO
drop database Sampa_tech