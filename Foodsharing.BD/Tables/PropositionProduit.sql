CREATE TABLE [dbo].[PropositionProduit] (
    [IdProposition]   INT           IDENTITY (1, 1) NOT NULL,
    [IdUtilisateur]   INT           NOT NULL,
    [IdProduit]       INT           NOT NULL,
    [DateProposition] DATETIME2 (7) NOT NULL,
    [DateFin]         DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdProposition] ASC),
    CONSTRAINT [FK_PropositionProduit_IdProduit] FOREIGN KEY ([IdProduit]) REFERENCES [dbo].[Produit] ([IdProduit]),
    CONSTRAINT [FK_PropositionProduit_IdUtilisateur] FOREIGN KEY ([IdUtilisateur]) REFERENCES [dbo].[Utilisateur] ([IdUtilisateur])
);

