CREATE PROCEDURE [dbo].[SP_Adresse_Insert]

	@numero VARCHAR(8),
	@rue VARCHAR(128),
	@ville VARCHAR(32),
	@cp VARCHAR(8),
	@nom NVARCHAR (64),
	@prenom NVARCHAR (64),
	@dateNaiss DATE,
	@email VARCHAR (64) ,
	@photo NVARCHAR (256)
AS
DECLARE @idUtilisateur INT
	INSERT INTO[Utilisateur]([Nom], [Prenom], [DateNaiss], [Email], [Photo])
	VALUES (@nom, @prenom, @dateNaiss, @email, @photo)
	SET @idUtilisateur = @@IDENTITY

	INSERT INTO[Adresse]([Numero], [Rue], [Ville], [CP],[IdUtilisateur] )
	OUTPUT inserted.IdAdresse
	VALUES (@numero, @rue, @ville, @cp, @idUtilisateur)
RETURN 0
