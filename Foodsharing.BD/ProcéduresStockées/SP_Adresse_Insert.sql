CREATE PROCEDURE [dbo].[SP_Adresse_Insert]

	@numero VARCHAR(8),
	@rue VARCHAR(128),
	@ville VARCHAR(32),
	@cp VARCHAR(8),
	@nom NVARCHAR (64),
	@prenom NVARCHAR (64),
	@dateNaiss DATE,
	@email VARCHAR (64) ,
	@photo NVARCHAR (256),
	@login VARCHAR(16),
	@password NVARCHAR(32)
AS
DECLARE @idUtilisateur INT, @salt CHAR(8)
	SET @salt = [dbo].SF_GenerateSalt()
	INSERT INTO[Utilisateur]([Nom], [Prenom], [DateNaiss], [Email], [Photo], [Login], [Password], [Salt])
	VALUES (@nom, @prenom, @dateNaiss, @email, @photo, @login, dbo.SF_EncryptedPassword(@password, @salt),@salt)
	SET @idUtilisateur = @@IDENTITY

	INSERT INTO[Adresse]([Numero], [Rue], [Ville], [CP],[IdUtilisateur] )
	OUTPUT inserted.IdAdresse
	VALUES (@numero, @rue, @ville, @cp, @idUtilisateur)
RETURN 0
