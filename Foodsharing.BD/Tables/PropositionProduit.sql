CREATE TABLE [dbo].[PropositionProduit]
(
	[IdProposition] INT NOT NULL IDENTITY, 
    [IdUtilisateur] INT NOT NULL, 
    [IdProduit] INT NOT NULL, 
    [DateProposition] DATETIME2 NOT NULL, 
    [DateFin] DATETIME2 NOT NULL,
    PRIMARY KEY CLUSTERED ([IdProposition]),
    CONSTRAINT FK_PropositionProduit_IdUtilisateur FOREIGN KEY ([IdUtilisateur]) REFERENCES [Utilisateur]([IdUtilisateur]),
    CONSTRAINT FK_PropositionProduit_IdProduit FOREIGN KEY ([IdProduit]) REFERENCES [Produit] ([IdProduit]),
)
