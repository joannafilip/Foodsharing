CREATE TABLE [dbo].[PriseProduit]
(
	[IdPriseProduit] INT NOT NULL, 
    [IdUtilisateur] INT NOT NULL, 
    [IdProduit] INT NOT NULL, 
    [DatePrise] DATETIME2 NOT NULL,
    PRIMARY KEY CLUSTERED ([IdPriseProduit]),
    CONSTRAINT FK_PriseProduit_IdUtilisateur FOREIGN KEY ([IdUtilisateur]) REFERENCES [Utilisateur]
    ([IdUtilisateur]),
    CONSTRAINT FK_PriseProduit_IdProduit FOREIGN KEY ([IdProduit]) REFERENCES [Produit] ([IdProduit]),
)
