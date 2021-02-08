CREATE TABLE [dbo].[Adresse]
(
	[IdAdresse] INT NOT NULL IDENTITY,
	[Numero] VARCHAR(8) NOT NULL,
	[Rue] VARCHAR (128) NOT NULL,
	[Ville] VARCHAR (32) NOT NULL,
	[CP] VARCHAR (8) NOT NULL,
	[IdUtilisateur] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([IdAdresse] ASC),
	CONSTRAINT FK_Adresse_Utilisateur FOREIGN KEY ([IdUtilisateur]) REFERENCES [Utilisateur] ([IdUtilisateur]),


)
