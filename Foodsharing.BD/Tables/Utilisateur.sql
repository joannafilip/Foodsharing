CREATE TABLE [dbo].[Utilisateur]
(
	[IdUtilisateur] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR (64) NOT NULL,
	[Prenom] NVARCHAR (64) NOT NULL,
	[DateNaiss] DATE NOT NULL,
	[Email] VARCHAR (64) NOT NULL,
	[Photo] NVARCHAR (256)NOT NULL ,
	PRIMARY KEY CLUSTERED ([IdUtilisateur] ASC)

)
