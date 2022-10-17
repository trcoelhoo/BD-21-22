CREATE SCHEMA Rent_A_Car;
GO

CREATE TABLE Rent_A_CAR.Cliente(
	Num_Carta		INT		UNIQUE,
	Endereço		VARCHAR(50),
	Nome			VARCHAR(50),
	NIF				INT		NOT NULL		PRIMARY KEY
);

CREATE TABLE Rent_A_CAR.Balcao(
	Endereço		VARCHAR(50),
	Numero			INT			NOT NULL		PRIMARY KEY,
	Nome			VARCHAR(50)
);

CREATE TABLE Rent_A_CAR.Tipo_Veiculo(
	Designacao			VARCHAR(30),
	Codigo				INT		NOT NULL		PRIMARY KEY,
	ArCondicionado		BIT
);


CREATE TABLE Rent_A_CAR.Veiculo(
	Ano					CHAR(4),
	Matricula			CHAR(6)			PRIMARY KEY,
	Marca				VARCHAR(20),
	Codigo_tipo_veiculo		INT	REFERENCES	Rent_A_CAR.Tipo_Veiculo(Codigo),
);

CREATE TABLE Rent_A_CAR.Aluguer(
	Data_			DATE,
	Numero			INT			NOT NULL		PRIMARY KEY,
	Duracao			TIME,
	NIF_Cliente		INT		REFERENCES		Rent_A_CAR.Cliente(NIF),
	numero_balcao			INT	REFERENCES	Rent_A_CAR.Balcao(Numero),
	matricula_Veiculo		CHAR(6)	REFERENCES	Rent_A_CAR.Veiculo(Matricula),
	
);

CREATE TABLE Rent_A_CAR.Ligeiro(
	Num_lugares		TINYINT,
	Combustivel		VARCHAR(10),
	Portas			TINYINT,
	Codigo_tipo		INT			NOT NULL		PRIMARY KEY		REFERENCES Rent_A_CAR.Tipo_Veiculo(Codigo)
);

CREATE TABLE Rent_A_Car.Similaridade(
	codigo1		INT		NOT NULL	REFERENCES Rent_A_Car.Tipo_Veiculo(Codigo),
	codigo2		INT		NOT NULL	REFERENCES Rent_A_Car.Tipo_Veiculo(Codigo),
	PRIMARY KEY(codigo1,codigo2)
);


CREATE TABLE Rent_A_Car.Pesado(
	peso				SMALLINT,
	passageiros			SMALLINT,
	codigo_Tipo_Veiculo		INT		NOT NULL		PRIMARY	KEY		REFERENCES Rent_A_Car.Tipo_Veiculo(Codigo)
);