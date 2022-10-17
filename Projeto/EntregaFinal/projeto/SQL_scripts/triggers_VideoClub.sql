/*	
	Tiago Coelho e Frederico Vieira : VideoClub Triggers
	98385 e 98518
 */

--DROP TRIGGER usaCupaoTrigger;
GO

CREATE TRIGGER usaCupaoTrigger ON [usuario_usa_cupao]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @cupao as CHAR(10);
    DECLARE @email as VARCHAR(255);
    DECLARE @pontos as INT;
    SELECT @cupao = cupao_id, @email = usuario_email FROM inserted;
    SELECT @pontos = cupao.pontos FROM cupao WHERE id = @cupao;
    BEGIN TRY
        UPDATE usuario SET usuario.pontos += @pontos WHERE email = @email
    END TRY
    BEGIN CATCH
        RAISERROR ('Não foi possível atribuir os pontos', 16, 1);
		ROLLBACK TRAN
    END CATCH

END
GO