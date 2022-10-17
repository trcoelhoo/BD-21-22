/*	
	Tiago Coelho e Frederico Vieira : VideoClub Setup
	98385 e 98518
 */

GO
CREATE TABLE promocao(
	id INT UNIQUE NOT NULL IDENTITY(1,1),
	desconto TINYINT CHECK(desconto BETWEEN 0 and 100) NOT NUll,
	datain SMALLDATETIME NOT NULL,
	dataen SMALLDATETIME NOT NULL,
	nome VARCHAR(40) NOT NULL
);
GO
CREATE TABLE cont_tem_promocao(
	contid INT NOT NULL,
	promocaoid INT NOT NULL,
	CONSTRAINT cont_tem_promocao_pk PRIMARY KEY (contid,promocaoid)
);
GO
CREATE TABLE Conteudo(
	ID INT UNIQUE NOT NULL IDENTITY(1,1),
	Ano INT NOT NULL,
	Preco FLOAT NOT NULL,
	Categoria VARCHAR(50) NOT NULL,
	TaxaIva INT NOT NULL,
	Titulo VARCHAR(100) NOT NULL,
	Idade INT NOT NULL,
	Duracao INT NOT NULL,
	CONSTRAINT Conteudo_PK PRIMARY KEY (ID)
);
GO

CREATE TABLE Serie(
	ID INT NOT NULL,
	Episodios INT NOT NULL,

	CONSTRAINT Serie_PK PRIMARY KEY (ID)
);
GO
CREATE TABLE Filme(
	ID INT NOT NULL,
	CONSTRAINT Filme_PK PRIMARY KEY (ID)
);
GO

CREATE TABLE cupao(
	id CHAR(10) NOT NULL,
	datain SMALLDATETIME NOT NULL,
	dataen SMALLDATETIME NOT NULL,
	pontos INT NOT NULL,
	CONSTRAINT cupao_pk PRIMARY KEY (id)
);
GO

CREATE TABLE usuario_usa_cupao(
	cupao_id CHAR(10) NOT NULL,
	usuario_email VARCHAR(255) NOT NULL,
	CONSTRAINT usuario_usa_cupao_pk PRIMARY KEY (cupao_id,usuario_email)
);
GO


CREATE TABLE usuario(
	email VARCHAR(255) NOT NULL,
	nome VARCHAR(255) NOT NULL,
	contribuinte CHAR(9) NOT NULL,
	pass BINARY(64) NOT NULL,
	dataNasc DATE NOT NULL,
	pontos INT NOT NULL,
	CONSTRAINT usuario_pk PRIMARY KEY (email)
);
GO

CREATE TABLE admin(
	email VARCHAR(255) NOT NULL,
	nome VARCHAR(255) NOT NULL,
	pass BINARY(64) NOT NULL,
	CONSTRAINT admin_pk PRIMARY KEY (email)
);
GO

CREATE TABLE Pertence(
	ID_Aluguer INT NOT NULL,
	ID_Conteudo INT NOT NULL,

	CONSTRAINT Pertence_PK PRIMARY KEY (ID_Aluguer,ID_Conteudo)
);
GO

CREATE TABLE aluguer(
	id INT NOT NULL IDENTITY(1,1),
	datain SMALLDATETIME NOT NULL,
	dataen SMALLDATETIME NOT NULL,
	pagamento VARCHAR(10) NOT NULL,
	usuario_email VARCHAR(255) NOT NULL,
	contribuinte CHAR(9) NOT NULL,
	pontos_usados INT,
	pontos_acumulados INT,
	CONSTRAINT aluguer_pk PRIMARY KEY (id)
);
GO

CREATE TABLE Conteudo_Taxa(
	TaxaIva INT NOT NULL,

	CONSTRAINT Conteudo_Taxa_PK PRIMARY KEY (TaxaIva)
);
GO
CREATE TABLE Tipo_Conteudo(
	Categoria VARCHAR(50) NOT NULL,

	CONSTRAINT Tipo_Conteudo_PK PRIMARY KEY (Categoria)
);
GO


ALTER TABLE cont_tem_promocao ADD CONSTRAINT tem_promocao_contid_FK FOREIGN KEY (contid) REFERENCES Conteudo(ID);
ALTER TABLE cont_tem_promocao ADD CONSTRAINT tem_promocao_promocaoid_FK FOREIGN KEY (promocaoid) REFERENCES promocao(id);

ALTER TABLE Serie ADD CONSTRAINT Serie_conteudo_id_FK FOREIGN KEY (ID) REFERENCES Conteudo(ID);

ALTER TABLE Filme ADD CONSTRAINT Filme_conteudo_id_FK FOREIGN KEY (ID) REFERENCES Conteudo(ID);

ALTER TABLE usuario_usa_cupao ADD CONSTRAINT usuario_usa_cupao_usuarioemail_FK FOREIGN KEY (usuario_email) REFERENCES usuario(email);
ALTER TABLE usuario_usa_cupao ADD CONSTRAINT usuario_usa_cupao_cupaoid_FK FOREIGN KEY (cupao_id) REFERENCES cupao(id);

ALTER TABLE Aluguer ADD CONSTRAINT Aluguer_usuario_id_FK FOREIGN KEY(usuario_email) REFERENCES usuario(email);

ALTER TABLE Pertence ADD CONSTRAINT Pertence_aluguer_id_FK FOREIGN KEY (ID_Aluguer) REFERENCES aluguer(id);
ALTER TABLE Pertence ADD CONSTRAINT Pertence_conteudo_id_FK FOREIGN KEY (ID_Conteudo) REFERENCES Conteudo(ID);

ALTER TABLE Conteudo ADD CONSTRAINT Conteudo_taxaiva_FK FOREIGN KEY (TaxaIva) REFERENCES Conteudo_Taxa(TaxaIva);
ALTER TABLE Conteudo ADD CONSTRAINT Conteudo_categoria_FK FOREIGN KEY (Categoria) REFERENCES Tipo_Conteudo(Categoria);