DECLARE @responseMessage NVARCHAR(250)

EXEC dbo.addUser
          @pLogin = N'Admin',
          @pPassword = N'123',
          @pRole = 3,
          @responseMessage=@responseMessage OUTPUT

SELECT *
FROM [dbo].[User]