CREATE SCHEMA Gestao_Conferencias;
GO

CREATE TABLE Gestao_Conferencias.Instituicao(
	Nome		VARCHAR(30)		NOT NULL,
	Endereco	VARCHAR(50)	NOT NULL	PRIMARY KEY
);

CREATE TABLE Gestao_Conferencias.Pessoa(
	Nome					VARCHAR(30)		NOT NULL,
	Endereco_Instituicao	VARCHAR(50)	NOT NULL	REFERENCES Gestao_Conferencias.Instituicao(Endereco),
	Email					VARCHAR(30)		NOT NULL	PRIMARY KEY	
);

CREATE TABLE Gestao_Conferencias.Estudante(
	Morada				VARCHAR(50)			NOT NULL,
	Data_Incricacao		DATE				NOT NULL,	
	Localizacao_Eletronica_Comprovativo		VARCHAR(50)		NOT NULL,
	Email				VARCHAR(30)			NOT NULL	REFERENCES Gestao_Conferencias.Pessoa(Email)
);

CREATE TABLE Gestao_Conferencias.NaoEstudante(
	Morada				VARCHAR(50)			NOT NULL,
	Data_Incricacao		DATE				NOT NULL,	
	Referencia_transacao_bancaria		INT		NOT NULL,
	Email				VARCHAR(30)			NOT NULL	REFERENCES Gestao_Conferencias.Pessoa(Email)
);

CREATE TABLE Gestao_Conferencias.Participante(
	Morada				VARCHAR(50)			NOT NULL,
	Data_Incricacao		DATE				NOT NULL,
	Email				VARCHAR(30)			NOT NULL	REFERENCES Gestao_Conferencias.Pessoa(Email)
);

CREATE TABLE Gestao_Conferencias.Autor(
	Email				VARCHAR(30)			NOT NULL	PRIMARY KEY	REFERENCES Gestao_Conferencias.Pessoa(Email),
	Nome				VARCHAR(30)		NOT NULL
);

CREATE TABLE Gestao_Conferencias.Artigo(
	Titulo					VARCHAR(30)		NOT NULL,
	Numero_registo			INT			NOT NULL	PRIMARY KEY,
	
);

CREATE TABLE Gestao_Conferencias.Escreve(
	Email_Autor				VARCHAR(30)			NOT NULL	REFERENCES Gestao_Conferencias.Autor(Email),
	Numero_Artigo			INT		NOT NULL	REFERENCES Gestao_Conferencias.Artigo(Numero_registo)
);

