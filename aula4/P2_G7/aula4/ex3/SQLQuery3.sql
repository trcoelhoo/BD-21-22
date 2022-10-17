CREATE SCHEMA Gestao_Stocks;
GO

CREATE TABLE Gestao_Stocks.Armazem(
	Nome			VARCHAR(30)				NOT NULL,
	Codigo			INT		NOT NULL	PRIMARY KEY,
	Localizacao		VARCHAR(50)			NOT NULL
);

CREATE TABLE Gestao_Stocks.TipoFornecedor(
	Designacao			VARCHAR(50)		NOT NULL,
	Codigo_interno		INT				NOT NULL	PRIMARY KEY,
	
);

CREATE TABLE Gestao_Stocks.Fornecedor(
	Nome				VARCHAR(30)		NOT NULL,
	Fax					INT,
	Endereco			VARCHAR(50),
	Codigo_TipoFornecedor	INT				NOT NULL	REFERENCES Gestao_Stocks.TipoFornecedor(Codigo_interno),
	NIF					INT				NOT NULL	PRIMARY KEY
);

CREATE TABLE Gestao_Stocks.CondicoesPagamento(
	Condicao_pagamento		VARCHAR(10)		NOT NULL	PRIMARY KEY,
	NIF_Fornecedor			INT		NOT NULL	REFERENCES Gestao_Stocks.Fornecedor(NIF)
);

CREATE TABLE Gestao_Stocks.Encomenda(
	NIF_fornecedor		INT		NOT NULL	REFERENCES Gestao_Stocks.Fornecedor(NIF),
	Numero_Encomenda		INT		NOT NULL	PRIMARY KEY,
	Data_				DATE	NOT NULL,
);

CREATE TABLE Gestao_Stocks.Produto(
	
	Nome				VARCHAR(30)							NOT NULL,
	Codigo				INT				NOT NULL	PRIMARY KEY,
	Preco				INT,
	Quantidade			INT CHECK(quantidade >= 0)			NOT NULL,	
	Codigo_armazem		INT									NOT NULL	REFERENCES Gestao_Stocks.Armazem(codigo),
);

CREATE TABLE Gestao_Stocks.Contem(
	Codigo_Produto		INT		NOT NULL	REFERENCES Gestao_Stocks.Produto(Codigo),
	Numero_encomenda	INT		NOT NULL	REFERENCES Gestao_Stocks.Encomenda(Numero_Encomenda),
	Quantidade			INT		NOT NULL,
	Preco				INT		NOT NULL

);

CREATE TABLE Gestao_Stocks.Taxa(
	Valor		INT 	NOT NULL	PRIMARY KEY,
	Codigo_Produto		INT		NOT NULL	REFERENCES Gestao_Stocks.Produto(Codigo)
);