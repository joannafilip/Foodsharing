CREATE PROCEDURE [dbo].[SP_Check_Password]
	@login VARCHAR (16),
	@password NVARCHAR(32)
AS
	DECLARE @hPassword VARBINARY(32)
	DECLARE @salt CHAR(8)
	DECLARE @newPassword VARBINARY(32)
	SELECT @salt = salt, @hPassword = Password FROM Utilisateur WHERE login=@login
	SELECT @newPassword = dbo.SF_EncryptedPassword (@password, @salt)

	IF (@newPassword = @hPassword)
	BEGIN 
		SELECT [Login], Nom, Prenom, DateNaiss, Photo, Email  FROM Utilisateur WHERE login=@login

	END 
