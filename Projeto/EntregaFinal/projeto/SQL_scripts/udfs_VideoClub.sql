/*	
	Tiago Coelho e Frederico Vieira : VideoClub UDF's
	98385 e 98518
 */

--DROP FUNCTION getadminInfo;
GO

CREATE FUNCTION getadminInfo () RETURNS TABLE 
AS
    RETURN (SELECT email,nome,pass FROM admin) 

--DROP FUNCTION getallConteudo;
GO

CREATE FUNCTION getallConteudo () RETURNS TABLE 
AS
    RETURN (SELECT ID,Titulo,Ano,Categoria,Idade,Preco,TaxaIva,Duracao FROM Conteudo) 

--DROP FUNCTION getallConteudo_filme;
GO

CREATE FUNCTION getallConteudo_filme() RETURNS TABLE 
AS
    RETURN (SELECT Titulo,Ano,Categoria,Idade,Preco,TaxaIva,Duracao FROM (Conteudo JOIN Filme ON Conteudo.ID = Filme.ID))

--DROP FUNCTION getallConteudo_serie;
GO

CREATE FUNCTION getallConteudo_serie() RETURNS TABLE 
AS
    RETURN (SELECT Titulo,Ano,Categoria,Idade,Preco,TaxaIva,Duracao FROM (Conteudo JOIN Serie ON Conteudo.ID = Serie.ID))

--DROP FUNCTION getConteudobytitulo;
GO

CREATE FUNCTION getConteudobytitulo (@titu VARCHAR(100)) RETURNS TABLE 
AS
    RETURN (SELECT ID,Titulo,Ano,Categoria,Idade,Preco,TaxaIva,Duracao FROM Conteudo WHERE titulo = @titu) 


--DROP FUNCTION getCupao;
GO

CREATE FUNCTION getCupao () RETURNS TABLE 
AS
    RETURN (SELECT id, datain, dataen, pontos FROM cupao WHERE GETDATE() BETWEEN datain AND dataen)

--DROP FUNCTION getPromocoes;
GO

CREATE FUNCTION getPromocoes () RETURNS TABLE 
AS
    RETURN (SELECT nome, desconto, datain, dataen FROM promocao)

--DROP FUNCTION getUsuarioCoupao;
GO

CREATE FUNCTION getUsuarioCoupao (@email VARCHAR(255)) RETURNS TABLE 
AS
    RETURN (SELECT id, datain, dataen, pontos FROM (usuario_usa_cupao JOIN cupao ON cupao_id=id) WHERE usuario_email=@email ORDER BY datain DESC OFFSET 0 ROWS)
                    
--DROP FUNCTION getUsuarioInfo;
GO

CREATE FUNCTION getUsuarioInfo (@email VARCHAR(255)) RETURNS TABLE 
AS
    RETURN (SELECT TOP 1 email,nome,contribuinte,pass,dataNasc,pontos FROM usuario WHERE email = @email) 

--DROP FUNCTION historico_aluguer;
GO

CREATE FUNCTION historico_aluguer (@email VARCHAR(255)) RETURNS TABLE 
AS
    RETURN (SELECT Titulo, Preco, pagamento, pontos_acumulados FROM (aluguer JOIN Pertence ON aluguer.id= Pertence.ID_Aluguer) JOIN Conteudo ON Pertence.ID_Conteudo=Conteudo.ID WHERE usuario_email= @email ORDER BY aluguer.datain DESC OFFSET 0 ROWS)
GO