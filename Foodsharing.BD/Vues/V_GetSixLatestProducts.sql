CREATE VIEW [dbo].[V_GetSixLatestProducts]
	AS SELECT TOP 6 dbo.Type.Label AS Type, dbo.Utilisateur.Nom, dbo.Utilisateur.Prenom, dbo.Produit.Nom AS NomProduit, dbo.Produit.DatePeremption, dbo.Produit.Quantite, dbo.Produit.Description, dbo.Produit.Bio
FROM     dbo.Produit INNER JOIN
                  dbo.Type ON dbo.Produit.IdType = dbo.Type.IdType CROSS JOIN
                  dbo.Utilisateur
