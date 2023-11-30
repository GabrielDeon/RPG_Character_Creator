-- Cria uma base de dados
CREATE DATABASE Database1
GO

-- Seta a base de dados atual
USE Database1
GO

-- Cria a tabela Cidades
CREATE TABLE Cidades (
	ID_Cidade INT IDENTITY(1,1),
	Nome NVARCHAR(50) NOT NULL,
	UF NVARCHAR(2) NOT NULL,
	CONSTRAINT PK_CIDADES PRIMARY KEY (ID_Cidade)
	);
GO

-- Cria a tabela Clientes
CREATE TABLE Clientes (
	ID_Cliente INT IDENTITY(1,1),
	Nome NVARCHAR(50) NOT NULL,
	DataNascimento DATE NOT NULL CONSTRAINT DF_DATANASC DEFAULT GETDATE(),
	Idade INT,
	CPF NVARCHAR(14) UNIQUE NOT NULL,
	Altura FLOAT,
	Peso FLOAT,
	ID_Cidade INT NOT NULL,
	CONSTRAINT CK_IDADE CHECK (Idade > 0),
	CONSTRAINT PK_CLIENTES PRIMARY KEY (ID_Cliente),
	CONSTRAINT FK_CLIENTES_CIDADES FOREIGN KEY (ID_Cidade) REFERENCES Cidades (ID_Cidade)
	ON DELETE CASCADE
	);
GO

-- Inserir registro na tabela Cidades (Tupla)
INSERT INTO Cidades (Nome, UF)
VALUES ('Erechim', 'RS')
GO

INSERT INTO Cidades (Nome, UF)
VALUES ('Jacutinga', 'RS'),
	   ('Curitiba', 'PR'),
	   ('Florianópolis', 'SC'),
	   ('São Paulo', 'SP')
GO

-- Inserir registro na tabela Clientes (Tupla)
INSERT INTO Clientes (Nome, DataNascimento, Idade, CPF, Altura, Peso, ID_Cidade)
VALUES ('Ana', '2000-01-16', 23, '432.123.555-99', 1.65, 60, 4),
		('Pedro', '1999-12-25', 24, '444.123.664-12', 1.77, 85, 3)
GO

