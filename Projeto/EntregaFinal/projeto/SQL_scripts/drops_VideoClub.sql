/*	
	Tiago Coelho e Frederico Vieira : VideoClub DROPS
	98385 e 98518
 */

GO
IF OBJECT_ID('Filme', 'U') IS NOT NULL
BEGIN

ALTER TABLE Filme DROP CONSTRAINT Filme_conteudo_id_FK;
ALTER TABLE Filme DROP CONSTRAINT Filme_PK;
DROP TABLE Filme;
END
GO

IF OBJECT_ID('Serie', 'U') IS NOT NULL
BEGIN

ALTER TABLE Serie DROP CONSTRAINT Serie_conteudo_id_FK;
ALTER TABLE Serie DROP CONSTRAINT Serie_PK;
DROP TABLE Serie;
END
GO

IF OBJECT_ID('usuario_usa_cupao', 'U') IS NOT NULL
BEGIN
ALTER TABLE usuario_usa_cupao DROP CONSTRAINT usuario_usa_cupao_pk;
DROP TABLE usuario_usa_cupao;
END
GO

IF OBJECT_ID('Pertence', 'U') IS NOT NULL

ALTER TABLE Pertence DROP CONSTRAINT Pertence_aluguer_id_FK;
ALTER TABLE Pertence DROP CONSTRAINT Pertence_conteudo_id_FK;
ALTER TABLE Pertence DROP CONSTRAINT Pertence_PK;

DROP TABLE Pertence;
GO

IF OBJECT_ID('aluguer', 'U') IS NOT NULL
BEGIN

ALTER TABLE aluguer DROP CONSTRAINT Aluguer_usuario_id_FK;
ALTER TABLE aluguer DROP CONSTRAINT aluguer_pk;
DROP TABLE aluguer;
END
GO



IF OBJECT_ID('admin', 'U') IS NOT NULL
BEGIN
ALTER TABLE admin DROP CONSTRAINT admin_pk;
DROP TABLE admin;
END
GO

IF OBJECT_ID('usuario', 'U') IS NOT NULL
BEGIN
ALTER TABLE usuario DROP CONSTRAINT usuario_pk;
DROP TABLE usuario
END
GO

IF OBJECT_ID('cupao', 'U') IS NOT NULL
BEGIN
ALTER TABLE cupao DROP CONSTRAINT cupao_pk;
DROP TABLE cupao;
END
GO

IF OBJECT_ID('cont_tem_promocao', 'U') IS NOT NULL
BEGIN
ALTER TABLE cont_tem_promocao DROP CONSTRAINT cont_tem_promocao_pk;
ALTER TABLE cont_tem_promocao DROP CONSTRAINT tem_promocao_promocaoid_FK;
ALTER TABLE cont_tem_promocao DROP CONSTRAINT tem_promocao_contid_FK;


DROP TABLE cont_tem_promocao;
END
GO

IF OBJECT_ID('promocao', 'U') IS NOT NULL
BEGIN
DROP TABLE promocao;
END
GO

IF OBJECT_ID('Conteudo', 'U') IS NOT NULL
BEGIN

ALTER TABLE Conteudo DROP CONSTRAINT Conteudo_categoria_FK ;
ALTER TABLE Conteudo DROP CONSTRAINT Conteudo_taxaiva_FK;
ALTER TABLE Conteudo DROP CONSTRAINT Conteudo_PK;
DROP TABLE Conteudo;
END
GO

IF OBJECT_ID('Conteudo_Taxa', 'U') IS NOT NULL
BEGIN
ALTER TABLE Conteudo_Taxa DROP CONSTRAINT Conteudo_Taxa_PK;
DROP TABLE Conteudo_Taxa;
END
GO

IF OBJECT_ID('Tipo_Conteudo', 'U') IS NOT NULL
BEGIN
ALTER TABLE Tipo_Conteudo DROP CONSTRAINT Tipo_Conteudo_PK;
DROP TABLE Tipo_Conteudo;
END
GO