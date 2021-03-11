CREATE PROCEDURE [dbo].[SP_Check_Password]
	@login VARCHAR (16),
	@password NVARCHAR(32)
	
AS
	DECLARE @hPassword VARBINARY(32)
	DECLARE @salt CHAR(8)
	DECLARE @newPassword VARBINARY(32)
	SELECT @salt = salt, @hPassword = Password FROM Utilisateur WHERE login = @login
	SELECT @newPassword = dbo.SF_EncryptedPassword (@password, @salt)
	
	IF (@newPassword = @hPassword)
	BEGIN 
		--SELECT [Login], Nom, Prenom, DateNaiss, Photo, Email, IdUtilisateur FROM Utilisateur WHERE login=@login 
	select [Login], Nom, Prenom, Datenaiss, Photo, Email, Rue, Ville, Numero, CP, IdAdresse, Utilisateur.IdUtilisateur
	FROM Utilisateur 
	INNER JOIN  Adresse ON Utilisateur.idUtilisateur = Adresse.IdUtilisateur where login = @login 
	--	SELECT Rue, Ville, Numero, CP FROM Adresse INNER JOIN Utilisateur ON Utilisateur.IdUtilisateur = Adresse.IdUtilisateur
	END 

	
