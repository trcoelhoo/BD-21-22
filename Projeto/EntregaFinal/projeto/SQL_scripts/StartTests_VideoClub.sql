/*	
	Tiago Coelho e Frederico Vieira : VideoClub Start Tests
	98385 e 98518
 */

--SELECT * FROM Conteudo
--select * from Conteudo Where Titulo='teste'
--DELETE FROM Conteudo WHERE Titulo like '%teste%'
--SELECT * FROM cupao WHERE id ='VALETESTE1'
--SELECT * FROM cupao
--DELETE FROM cupao WHERE id like '%VALETESTE1%'
--SELECT * FROM promocao WHERE nome ='teste'
--DELETE FROM promocao WHERE nome like '%teste%'
--SELECT * FROM promocao
--SELECT * FROM cont_tem_promocao
--SELECT * FROM admin WHERE nome='teste'
--DELETE FROM admin WHERE nome like '%teste%'
--SELECT * FROM admin
--SELECT * FROM usuario WHERE email='teste@gamil.com'
--DELETE FROM usuario WHERE email like '%teste@gamil.com%'
--SELECT * FROM usuario
--SELECT TOP 1 email,nome,contribuinte,pass,dataNasc,pontos FROM usuario WHERE email='teste@gmail.com'
--INSERT INTO usuario_usa_cupao(cupao_id,usuario_email) VALUES ('VALEPONTO1','teste@gmail.com');
--INSERT INTO usuario_usa_cupao(cupao_id,usuario_email) VALUES ('VALEPONTO2','teste@gmail.com');
--INSERT INTO usuario_usa_cupao(cupao_id,usuario_email) VALUES ('VALEPONTO3','teste@gmail.com');
--SELECT id, datain, dataen, pontos FROM (usuario_usa_cupao JOIN cupao ON cupao_id=id) WHERE usuario_email='teste@gmail.com' ORDER BY datain DESC OFFSET 0 ROWS
--INSERT INTO aluguer(datain,dataen,pagamento,usuario_email,contribuinte,pontos_usados,pontos_acumulados) VALUES ('2020-02-26','2020-03-04','VISA','rickiboy@gmail.com','234567891',0,200);
--DELETE FROM aluguer WHERE id = (SELECT MAX(id) FROM aluguer)
--SELECT * FROM aluguer
--SELECT * FROM aluguer WHERE id = (SELECT MAX(id) FROM aluguer)
--INSERT INTO cupao(id,datain,dataen,pontos) VALUES ('teste150','2022-06-21','2022-07-01',150);
--SELECT * FROM usuario_usa_cupao
--SELECT ID,Titulo,Ano,Categoria,Idade,Preco,TaxaIva,Duracao FROM (Pertence JOIN Conteudo ON ID_Conteudo=ID)
--SELECT Titulo FROM (aluguer JOIN usuario ON usuario_email='joaopedro@gmail.com') JOIN (Pertence JOIN Conteudo ON ID_Conteudo=ID) ON aluguer.id=ID_Aluguer
--SELECT * FROM (Pertence JOIN Conteudo ON ID_Conteudo=ID)
--INSERT INTO cupao(id,datain,dataen,pontos) VALUES ('M6POINT100','2022-06-21','2022-07-21',100);
--INSERT INTO cupao(id,datain,dataen,pontos) VALUES ('M6POINT200','2022-06-21','2022-08-06',200);
--INSERT INTO cupao(id,datain,dataen,pontos) VALUES ('M6POINT300','2022-06-21','2022-08-16',300);
--DELETE FROM cupao WHERE id like 'M6POINT300'
--SELECT * FROM cupao
--(SELECT id FROM aluguer JOIN usuario ON aluguer.usuario_email=email WHERE usuario.email='joaopedro@gmail.com') JOIN ((Pertence JOIN Conteudo ON ID_Conteudo=ID) ON aluguer.id=ID_Aluguer)
--SELECT id, titulo FROM ((aluguer JOIN usuario ON aluguer.usuario_email=email) JOIN (((Pertence JOIN Conteudo ON ID_Conteudo=ID ))
--SELECT Titulo, Preco, pagamento, pontos_acumulados FROM (aluguer JOIN Pertence ON id= ID_Aluguer) JOIN Conteudo ON ID_Conteudo=Conteudo.ID WHERE usuario_email= 'joaopedro@gmail.com'
--SELECT * FROM promocao
--INSERT INTO cupao(id,datain,dataen,pontos) VALUES ('M6POINT150','2022-06-21','2022-08-16',150);