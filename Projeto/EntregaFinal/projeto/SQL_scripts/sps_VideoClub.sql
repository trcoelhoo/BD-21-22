/*	
	Tiago Coelho e Frederico Vieira : VideoClub Stored Procedures
	98385 e 98518
 */

--DROP PROCEDURE addConteudo;
GO

CREATE PROCEDURE addConteudo
	@ano INT,
	@preco FLOAT,
	@categoria VARCHAR(50),
	@taxaiva INT,
	@titulo VARCHAR(100),
	@idade INT,
	@duracao INT,
    @emailadmin VARCHAR(255),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
        IF EXISTS(SELECT email FROM admin WHERE email=@emailadmin)
            BEGIN
                INSERT INTO Conteudo (Ano, Preco, Categoria, TaxaIva, Titulo, Idade, Duracao) VALUES (@ano, @preco, @categoria, @taxaiva, @titulo, @idade, @duracao) 
				SET @responseMessage='Success'
            END
        ELSE
            SET @responseMessage='Permition denied'
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH
END

--DROP PROCEDURE addCoupon;
GO

CREATE PROCEDURE addCoupon
    @id CHAR(10),
    @datain SMALLDATETIME,
    @dataen SMALLDATETIME,
    @pontos INT,
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
        IF EXISTS(SELECT id FROM cupao WHERE id=@id)
            SET @responseMessage = 'Coupon Id already exists'
        ELSE
        BEGIN
            INSERT INTO cupao (id, datain, dataen, pontos) VALUES(@id, @datain, @dataen, @pontos) 
            SET @responseMessage='Success'
        END
    END TRY
    BEGIN CATCH
        SET @responseMessage='Failed'
    END CATCH

END
--DROP PROCEDURE addPromocao;
GO

CREATE PROCEDURE addPromocao
    @desconto TINYINT,
    @datain SMALLDATETIME,
    @dataen SMALLDATETIME,
	@nome VARCHAR(40),
    @emailadmin VARCHAR(255),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
        IF EXISTS(SELECT email FROM admin WHERE email=@emailadmin)
            BEGIN
                INSERT INTO promocao (desconto, datain, dataen, nome) VALUES(@desconto, @datain, @dataen, @nome) 
                SET @responseMessage='Success'
            END
        ELSE
            SET @responseMessage='Permition denied'
    END TRY
    BEGIN CATCH
        SET @responseMessage='Failed'
    END CATCH

END

--DROP PROCEDURE AlugarConteudo;
GO

CREATE PROCEDURE AlugarConteudo
    @id_aluguer INT,
	@id_conteudo INT,
    @responseMessage VARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
        INSERT INTO Pertence (ID_Aluguer, ID_Conteudo) VALUES(@id_aluguer, @id_conteudo) 
        SET @responseMessage='Success'
    END TRY
    BEGIN CATCH
        SET @responseMessage='Failure' 
    END CATCH

END

--DROP PROCEDURE ChangeConteudo
GO


CREATE PROCEDURE ChangeConteudo
    @id INT,
	@ano INT,
	@preco FLOAT,
	@categoria VARCHAR(50),
	@taxaiva INT,
	@titulo VARCHAR(100),
	@idade INT,
	@duracao INT,
    @emailadmin VARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION
    SET NOCOUNT ON
    BEGIN TRY
        IF EXISTS(SELECT email FROM admin WHERE email=@emailadmin)
            BEGIN
                IF @ano <> 0
                BEGIN
                    UPDATE Conteudo SET Ano = @ano WHERE id = @id
                END

                IF @preco <> 0
                BEGIN
                    UPDATE Conteudo SET Preco = @preco WHERE id = @id
                END

                IF @categoria IS NOT NULL
                BEGIN
                    UPDATE Conteudo SET Categoria = @categoria WHERE id = @id
                END

                IF @taxaiva <> 0
                BEGIN
                    UPDATE Conteudo SET TaxaIva = @taxaiva WHERE id = @id
                END

                IF @titulo IS NOT NULL
                BEGIN
                    UPDATE Conteudo SET Titulo = @titulo WHERE id = @id
                END

                IF @idade <> 0
                BEGIN
                    UPDATE Conteudo SET Idade = @idade WHERE id = @id
                END
                
                IF @duracao <> 0
                BEGIN
                    UPDATE Conteudo SET Duracao = @duracao WHERE id = @id
                END
            END
            COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
    ROLLBACK
    END CATCH
            
END

--DROP PROCEDURE Conteudo_filter;
GO
CREATE PROCEDURE Conteudo_filter
	@Categoria VARCHAR(50) = NULL,
	@Titulo VARCHAR(100) = NULL,
    @orderby VARCHAR(50) = NULL
AS
BEGIN
        SET NOCOUNT ON
        BEGIN
            SELECT ID, Ano, Preco, Categoria, TaxaIva, Titulo, Idade, Duracao FROM Conteudo WHERE Titulo LIKE ('%'+ISNULL(@Titulo, Titulo)+'%') AND Categoria = ISNULL(@Categoria,Categoria)
            ORDER BY CASE WHEN @orderby='Título' THEN Titulo END,
                     CASE WHEN @orderby='Categoria' THEN Categoria END,
                     CASE WHEN @orderby='Preço' THEN Preco END,
					 CASE WHEN @orderby='Ano' THEN Ano END
        END
END

--DROP PROCEDURE deleteadmin;
GO

CREATE PROCEDURE deleteadmin 
	@email VARCHAR(255),
	@responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM admin WHERE email like @email
			SET @responseMessage='Success'
			COMMIT
    END TRY
    BEGIN CATCH
        SET @responseMessage='Something Went Wrong'
		ROLLBACK
    END CATCH
END

--DROP PROCEDURE getlastaluguer;
GO

CREATE PROCEDURE getlastaluguer
	@responseMessage NVARCHAR(250) OUTPUT
AS
    SET @responseMessage= (SELECT id FROM aluguer WHERE id = (SELECT MAX(id) FROM aluguer))


--DROP PROCEDURE login;
GO

CREATE PROCEDURE login
    @email VARCHAR(255),
    @pass VARCHAR(20),
    @responseMessage VARCHAR(250)='' OUTPUT,
    @type BIT=0 OUTPUT,
	@outemail VARCHAR(255) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
	SET @type=0
	SET @responseMessage='Invalid login'
    IF EXISTS (SELECT TOP 1 email FROM usuario WHERE email = @email)
    BEGIN
        SET @email=(SELECT email FROM usuario WHERE email=@email AND pass=HASHBYTES('SHA2_512', @pass))

        IF(@email IS NULL)
        BEGIN
            SET @type=0
            SET @responseMessage='Incorrect password'
        END
        ELSE 
        BEGIN
           SET @responseMessage='User successfully logged in'
		   SET @type = 1
		   SET @outemail = @email
        END
    END
    ELSE
	    IF EXISTS (SELECT TOP 1 email FROM admin WHERE email = @email)
        BEGIN
		    SET @email=(SELECT email FROM admin WHERE email=@email AND pass=HASHBYTES('SHA2_512', @pass))

			IF(@email IS NULL)
			BEGIN
				SET @type=0
				SET @responseMessage='Incorrect password'
			END
			ELSE 
			BEGIN
			   SET @responseMessage='Admin successfully logged in'
			   SET @type = 1
			   SET @outemail = @email
			END
        END

END

--DROP PROCEDURE novoAluguer;
GO

CREATE PROCEDURE novoAluguer
	@pagamento VARCHAR(10),
	@usuario_email VARCHAR(255),
	@contribuinte CHAR(9),
	@pontos_usados INT,
	@pontos_acumulados INT,
    @responseMessage VARCHAR(250) OUTPUT
AS
BEGIN
    BEGIN TRANSACTION
    SET NOCOUNT ON
    BEGIN TRY
        INSERT INTO Aluguer (datain, dataen, pagamento, usuario_email, contribuinte, pontos_usados,pontos_acumulados) VALUES(GETDATE(),GETDATE() + 7, @pagamento, @usuario_email, @contribuinte, @pontos_usados,@pontos_acumulados)        
        SET @responseMessage='Success'
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        SET @responseMessage='Failure'
        ROLLBACK
    END CATCH

END

--DROP PROCEDURE Register_Admin
GO

CREATE PROCEDURE Register_Admin
    @email VARCHAR(255),
	@nome VARCHAR(255),
	@pass VARCHAR(20),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    BEGIN TRANSACTION
    SET NOCOUNT ON

    BEGIN TRY
        INSERT INTO admin (email, nome, pass) VALUES (@email, @nome,HASHBYTES('SHA2_512', @pass))
		SET @responseMessage='Success'
		COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        ROLLBACK
    END CATCH

END

--DROP PROCEDURE RegisterUsuario
GO

CREATE PROCEDURE RegisterUsuario
    @email VARCHAR(255),
	@nome VARCHAR(255),
	@contribuinte CHAR(9),
	@pass VARCHAR(20),
	@dataNasc DATE,
    @responseMessage VARCHAR(250) OUTPUT
AS
BEGIN
    BEGIN TRANSACTION
    SET NOCOUNT ON
    BEGIN TRY
        INSERT INTO usuario (email, nome, contribuinte, pass, dataNasc,pontos) VALUES(@email, @nome, @contribuinte, HASHBYTES('SHA2_512', @pass), @dataNasc,0)
		SET @responseMessage='Success'
		COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        ROLLBACK
    END CATCH

END

--DROP PROCEDURE updateadmin;
GO

CREATE PROCEDURE updateadmin
	@email VARCHAR(255),
	@nome VARCHAR(255),
	@pass VARCHAR(20),
    @responseMsg nvarchar(250) output
AS
BEGIN
    BEGIN TRANSACTION
	SET NOCOUNT ON

	BEGIN TRY
        IF @email IS NOT NULL
		BEGIN
            IF EXISTS (SELECT email FROM admin WHERE email = @email)
            BEGIN
                UPDATE admin SET email = @email WHERE  email = @email
				SET @responseMsg='Success'
            END
            ELSE
                SET @responseMsg='Failed'
		END

        IF @nome IS NOT NULL
		BEGIN
            IF EXISTS (SELECT @nome FROM admin WHERE email = @email)
            BEGIN
                UPDATE admin SET @nome = @nome WHERE  email = @email
				SET @responseMsg='Success'
            END
            ELSE
                SET @responseMsg='Failed'
		END

        IF @pass IS NOT NULL
            BEGIN
                UPDATE admin SET pass = hashbytes('SHA2_512', @pass) WHERE  email = @email SET @responseMsg='Success'
            END
    COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		SET @responseMsg='Failed'
        ROLLBACK
	END CATCH
END

--DROP PROCEDURE updateUsuario;
GO

CREATE PROCEDURE updateUsuario
	@email VARCHAR(255),
	@pontos INT,
    @responseMsg nvarchar(250) output
AS
BEGIN
	BEGIN TRANSACTION
	SET NOCOUNT ON
	BEGIN TRY

		IF @pontos IS NOT NULL
		BEGIN
			UPDATE usuario SET pontos = @pontos WHERE  email = @email
		END

		SET @responseMsg='Success'
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		SET @responseMsg='Erro'
		ROLLBACK
	END CATCH
END

--DROP PROCEDURE user_usa_cupao;
GO

CREATE PROCEDURE user_usa_cupao
    @cupao_id CHAR(10),
	@usuario_email VARCHAR(255),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
        IF EXISTS(SELECT email FROM usuario WHERE email=@usuario_email) AND EXISTS(SELECT id, datain, dataen FROM cupao WHERE (id=@cupao_id) AND (GETDATE() BETWEEN datain AND dataen))
            BEGIN
                INSERT INTO usuario_usa_cupao (cupao_id, usuario_email) VALUES(@cupao_id, @usuario_email) 
                SET @responseMessage='Success'
            END
        ELSE
            SET @responseMessage='Failed'
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE()
    END CATCH

END
GO