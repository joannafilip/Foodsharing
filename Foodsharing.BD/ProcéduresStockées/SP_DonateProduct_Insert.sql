CREATE PROCEDURE [dbo].[SP_DonateProduct_Insert]
	@nameProduct NVARCHAR(100),
	@datePeremption Date,
	@quantite INT,
	@description NVARCHAR(200),
	@bio bit,
	@nomMarque NVARCHAR(150),
	@pays NVARCHAR(50),
	@labelEtat NVARCHAR(50),
	@title NVARCHAR(50),
	@src NVARCHAR(250),
	@labelType NVARCHAR(50),
	@dateProposition date,
	@dateFin date,
	@idAdresse INT,
	@idUtilisateur INT

AS
DECLARE @idMarque INT, @idEtat INT,@idPhoto INT, @idType INT, @idProduit INT

	INSERT INTO[Marque]([Nom], [Pays])
	VALUES (@nomMarque, @pays)
	SET @idMarque= @@IDENTITY

	INSERT INTO[Etat]([Label])
	VALUES (@labelEtat)
	SET @idEtat= @@IDENTITY

	INSERT INTO[Photo]([Title], [Src])
	VALUES (@title,@src)
	SET @idPhoto= @@IDENTITY

	INSERT INTO[Type]([Label])
	VALUES (@labelType)
	SET @idType = @@IDENTITY

	INSERT INTO[Produit]([Nom], [DatePeremption],[Quantite], [Description], [Bio], [IdMarque], [IdType], [IdEtat], [IdPhoto], [IdAdresse])
	VALUES (@nameProduct,@datePeremption, @quantite, @description, @bio,@idMarque, @idType, @idEtat, @idPhoto, @idAdresse)
	SET @idProduit= @@IDENTITY

	INSERT INTO[PropositionProduit]([IdUtilisateur], [IdProduit], [DateProposition], [DateFin] )
	OUTPUT inserted.IdProposition
	VALUES (@idUtilisateur, @idProduit, @dateProposition, @dateFin)

RETURN 0
