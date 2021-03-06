﻿CREATE PROCEDURE [dbo].[SP_DonateProduct_Insert]
	@nameProduct NVARCHAR(100),
	@datePeremption Date,
	@quantite INT,
	@description NVARCHAR(200),
	@bio bit,
	@nomMarque NVARCHAR(150),
	@pays NVARCHAR(50),
	@labelEtat NVARCHAR(50),
	@idType INT,
	@idAdresse INT,
	@idUtilisateur INT

AS
DECLARE @idMarque INT, @idEtat INT,@idPhoto INT, @idProduit INT

	INSERT INTO[Marque]([Nom], [Pays])
	VALUES (@nomMarque, @pays)
	SET @idMarque= @@IDENTITY

	INSERT INTO[Etat]([Label])
	VALUES (@labelEtat)
	SET @idEtat= @@IDENTITY

	INSERT INTO[Photo]([Title], [Src])
	VALUES (null,null)
	SET @idPhoto= @@IDENTITY

	INSERT INTO[Produit]([Nom], [DatePeremption],[Quantite], [Description], [Bio], [IdMarque], [IdType], [IdEtat], [IdPhoto], [IdAdresse])
	VALUES (@nameProduct,@datePeremption, @quantite, @description, @bio,@idMarque, @idType, @idEtat, @idPhoto, @idAdresse)
	SET @idProduit= @@IDENTITY

	INSERT INTO[PropositionProduit]([IdUtilisateur], [IdProduit], [DateProposition], [DateFin] )
	OUTPUT inserted.IdProposition
	VALUES (@idUtilisateur, @idProduit, GETDATE(), DATEADD(WEEK, 1,GETDATE()))

RETURN 0
