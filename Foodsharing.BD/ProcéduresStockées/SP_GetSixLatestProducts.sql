--CREATE PROCEDURE [dbo].[SP_GetSixLatestProducts]
--AS

----SELECT TOP 6 Bio, Title, [Type].[Label], Produit.Nom, [Description], DatePeremption, Quantite, Utilisateur.Nom, Utilisateur.Prenom 
----FROM Produit, Marque, [Type], Etat, Photo, Utilisateur INNER JOIN Adresse On Adresse.IdUtilisateur = Utilisateur.IdUtilisateur ORDER BY DatePeremption

--SELECT dbo.Type.Label, dbo.Utilisateur.Nom AS Expr1, dbo.Utilisateur.Prenom, dbo.Produit.Nom, dbo.Produit.DatePeremption, dbo.Produit.Quantite, dbo.Produit.Description, dbo.Produit.Bio
--FROM     dbo.Produit INNER JOIN
--                  dbo.Type ON dbo.Produit.IdType = dbo.Type.IdType CROSS JOIN
--                  dbo.Utilisateur ORDER BY DatePeremption
--RETURN 0