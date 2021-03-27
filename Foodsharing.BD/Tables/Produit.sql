CREATE TABLE [dbo].[Produit] (
    [IdProduit]      INT            IDENTITY (1, 1) NOT NULL,
    [Nom]            NVARCHAR (100) NOT NULL,
    [DatePeremption] DATE           NOT NULL,
    [Quantite]       INT            NOT NULL,
    [Description]    NVARCHAR (200) NOT NULL,
    [Bio]            BIT            NULL,
    [IdMarque]       INT            NOT NULL,
    [IdType]         INT            NOT NULL,
    [IdEtat]         INT            NOT NULL,
    [IdPhoto]        INT            NULL,
    [IdAdresse]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([IdProduit] ASC),
    CONSTRAINT [FK_Produit_Adresse] FOREIGN KEY ([IdAdresse]) REFERENCES [dbo].[Adresse] ([IdAdresse]),
    CONSTRAINT [FK_Produit_Etat] FOREIGN KEY ([IdEtat]) REFERENCES [dbo].[Etat] ([IdEtat]),
    CONSTRAINT [FK_Produit_Marque] FOREIGN KEY ([IdMarque]) REFERENCES [dbo].[Marque] ([IdMarque]),
    CONSTRAINT [FK_Produit_Photo] FOREIGN KEY ([IdPhoto]) REFERENCES [dbo].[Photo] ([IdPhoto]),
    CONSTRAINT [FK_Produit_Type] FOREIGN KEY ([IdType]) REFERENCES [dbo].[Type] ([IdType])
);






