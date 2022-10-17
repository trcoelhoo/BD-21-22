/*	
	Tiago Coelho e Frederico Vieira : VideoClub Indexes
	98385 e 98518
 */

--DROP INDEX idx_conteudo on Conteudo;
GO
CREATE INDEX idx_conteudo ON Conteudo (Preco, Categoria,TaxaIva, Titulo, Idade);
GO