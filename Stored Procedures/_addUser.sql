CREATE PROCEDURE dbo.addUser
    @pLogin NVARCHAR(50), 
    @pPassword NVARCHAR(50),
    @pRole INT,
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        INSERT INTO dbo.[User] (LoginName, PasswordHash, Role)
        VALUES(@pLogin, HASHBYTES('SHA2_512', @pPassword), @pRole)

        SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END