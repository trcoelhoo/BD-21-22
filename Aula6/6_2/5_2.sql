create schema Stocks;
GO

CREATE TABLE Stocks.FORNECEDOR(
	NIF		    CHAR(9)	        NOT NULL		PRIMARY KEY,
	endereco	VARCHAR(35),
	nome		VARCHAR(35)		NOT NULL,
	condpag	VARCHAR(50) NOT NULL,
	FAX			CHAR(9),
	tipo	INT,
);

CREATE TABLE Stocks.ENCOMENDA(
	NumEncomenda    INT	        NOT NULL	    PRIMARY KEY,
	data			datetime	NOT NULL,
	Fornecedor_NIF			CHAR(9),
);


CREATE TABLE Stocks.PRODUTO(
	Codigo		INT             NOT NULL        PRIMARY KEY,
	Stock		INT	            NOT NULL,
	Preço		DECIMAL(10,2)	NOT NULL,
	IVA			INT	            NOT NULL,
	NOME		VARCHAR(25)		NOT NULL
);

CREATE TABLE Stocks.TIPO_FORNECEDOR(
	Designacao		varchar(30) ,
	codigo	        INT         NOT NULL        PRIMARY KEY,
);

CREATE TABLE Stocks.ITEM(
	codProd			INT		    NOT NULL,
	NumEncomenda	INT,
	Unidades		INT		    NOT NULL,
	PRIMARY KEY(codProd, NumEncomenda)
);

ALTER TABLE Stocks.FORNECEDOR  ADD constraint codTipoFr FOREIGN KEY (tipo) REFERENCES Stocks.TIPO_FORNECEDOR(codigo);
ALTER TABLE Stocks.ENCOMENDA ADD constraint Fornecedor_NIF FOREIGN KEY (Fornecedor_NIF) REFERENCES Stocks.FORNECEDOR(NIF);
ALTER TABLE Stocks.ITEM ADD constraint ProdCodigo FOREIGN KEY (codProd) REFERENCES Stocks.PRODUTO(Codigo);
ALTER TABLE Stocks.ITEM ADD constraint NumEnc FOREIGN KEY (NumEncomenda) REFERENCES Stocks.ENCOMENDA(NumEncomenda);

/** b) Introduza dados nas bases de dados criadas. Sugere-se que utilize o dataset fornecido
na última aula (disponível no Moodle); **/

INSERT INTO Stocks.TIPO_FORNECEDOR(codigo, designacao)VALUES(101,'Carnes')
INSERT INTO Stocks.TIPO_FORNECEDOR(codigo, designacao)VALUES(102,'Laticinios')
INSERT INTO Stocks.TIPO_FORNECEDOR(codigo, designacao)VALUES(103,'Frutas e Legumes')
INSERT INTO Stocks.TIPO_FORNECEDOR(codigo, designacao)VALUES(104,'Mercearia')
INSERT INTO Stocks.TIPO_FORNECEDOR(codigo, designacao)VALUES(105,'Bebidas')
INSERT INTO Stocks.TIPO_FORNECEDOR(codigo, designacao)VALUES(106,'Peixe')
INSERT INTO Stocks.TIPO_FORNECEDOR(codigo, designacao)VALUES(107,'Detergentes')

INSERT INTO Stocks.FORNECEDOR(NIF,nome,FAX,endereco,condpag,tipo)VALUES(509111222,'LactoSerrano',234872372,NULL,'60 dias',102)
INSERT INTO Stocks.FORNECEDOR(NIF,nome,FAX,endereco,condpag,tipo)VALUES(509121212,'FrescoNorte',221234567,'Rua do Complexo Grande - Edf 3','60 dias',102)
INSERT INTO Stocks.FORNECEDOR(NIF,nome,FAX,endereco,condpag,tipo)VALUES(509294734,'PinkDrinks',2123231732,'Rua Poente 723','30 dias',105)
INSERT INTO Stocks.FORNECEDOR(NIF,nome,FAX,endereco,condpag,tipo)VALUES(509827353,'LactoSerrano',234872372,NULL,'60 dias',102)
INSERT INTO Stocks.FORNECEDOR(NIF,nome,FAX,endereco,condpag,tipo)VALUES(509836433,'LeviClean',229343284,'Rua Sol Poente 6243','30 dias',107)
INSERT INTO Stocks.FORNECEDOR(NIF,nome,FAX,endereco,condpag,tipo)VALUES(509987654,'MaduTex',234873434,'Estrada da Cincunvalacao 213','30 dias',104)
INSERT INTO Stocks.FORNECEDOR(NIF,nome,FAX,endereco,condpag,tipo)VALUES(590972623,'ConservasMac',234112233,'Rua da Recta 233','30 dias',104)

INSERT INTO Stocks.PRODUTO(Codigo,NOME,Preço,iva,Stock)VALUES(10001,'Bife da Pa',8.75,23,125)
INSERT INTO Stocks.PRODUTO(Codigo,NOME,Preço,iva,Stock)VALUES(10002,'Laranja Algarve',1.25,23,1000)
INSERT INTO Stocks.PRODUTO(Codigo,NOME,Preço,iva,Stock)VALUES(10003,'Pera Rocha',1.45,23,2000)
INSERT INTO Stocks.PRODUTO(Codigo,NOME,Preço,iva,Stock)VALUES(10004,'Secretos de Porco Preto',10.15,23,342)
INSERT INTO Stocks.PRODUTO(Codigo,NOME,Preço,iva,Stock)VALUES(10005,'Vinho Rose Plus',2.99,13,5232)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10006,'Queijo de Cabra da Serra',15.00,23,3243)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10007,'Queijo Fresco do Dia',0.65,23,452)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10008,'Cerveja Preta Artesanal',1.65,13,937)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10009,'Lixivia de Cor',1.85,23,9382)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10010,'Amaciador Neutro',4.05,23,932432)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10011,'Agua Natural',0.55,6,919323)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10012,'Pao de Leite',0.15,6,5434)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10013,'Arroz Agulha',1.00,13,7665)
INSERT INTO Stocks.PRODUTO(Codigo,nome,Preço,iva,Stock)VALUES(10014,'Iogurte Natural',0.40,13,998)

INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(1,'2015-03-03',509111222)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(2,'2015-03-04',509121212)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(3,'2015-03-05',509987654)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(4,'2015-03-06',509827353)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(5,'2015-03-07',509294734)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(6,'2015-03-08',509836433)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(7,'2015-03-09',509121212)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(8,'2015-03-10',509987654)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(9,'2015-03-11',509836433)
INSERT INTO Stocks.ENCOMENDA(NumEncomenda,data,Fornecedor_NIF)VALUES(10,'2015-03-12',509987654)

INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(1,10001,200)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(1,10004,300)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(2,10002,1200)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(2,10003,3200)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(3,10013,900)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(4,10006,50)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(4,10007,40)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(4,10014,200)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(5,10005,500)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(5,10008,10)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(5,10011,1000)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(6,10009,200)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(6,10010,200)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(7,10003,1200)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(8,10013,350)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(9,10009,100)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(9,10010,300)
INSERT INTO Stocks.ITEM(NumEncomenda,codProd,unidades)VALUES(10,10012,200)

/** c) Converta as queries AR em queries SQL. **/

select NIF,Nome from (Stocks.ENCOMENDA right outer join Stocks.FORNECEDOR ON Fornecedor_NIF=NIF) 
where NumEncomenda is null

select codProd, avg(unidades) as MediaDeUnidades from (Stocks.PRODUTO join Stocks.ITEM on codigo=codProd)
group by codProd; 

select avg(Unidades) as NumProdutos from Stocks.ITEM
group by NumEncomenda;

select Stocks.FORNECEDOR.Nome, Stocks.PRODUTO.Nome,sum(Stocks.ITEM.Unidades) as Quant
from (Stocks.PRODUTO join (Stocks.ITEM join (Stocks.FORNECEDOR join Stocks.ENCOMENDA on NIF = Fornecedor_NIF) on Stocks.ENCOMENDA.NumEncomenda = Stocks.ITEM.NumEncomenda) on codigo = codProd)
group by Stocks.PRODUTO.Nome, Stocks.FORNECEDOR.Nome