CREATE VIEW [dbo].[V_GetSixLatestProducts]

AS SELECT TOP (6) dbo.PropositionProduit.IdUtilisateur, dbo.PropositionProduit.IdProduit AS IdProduit, dbo.Utilisateur.Nom, dbo.Utilisateur.Prenom, dbo.Type.Label AS Type, dbo.Produit.Nom AS NomProduit, dbo.Produit.DatePeremption, dbo.Produit.Quantite, 
                  dbo.Produit.Description, dbo.Produit.Bio
FROM     dbo.Produit INNER JOIN
                  dbo.Type ON dbo.Produit.IdType = dbo.Type.IdType INNER JOIN
                  dbo.PropositionProduit ON dbo.Produit.IdProduit = dbo.PropositionProduit.IdProduit INNER JOIN
                  dbo.Utilisateur ON dbo.PropositionProduit.IdUtilisateur = dbo.Utilisateur.IdUtilisateur
ORDER BY dbo.Produit.DatePeremption DESC