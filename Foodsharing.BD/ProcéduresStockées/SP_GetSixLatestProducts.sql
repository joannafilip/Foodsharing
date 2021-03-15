CREATE PROCEDURE [dbo].[SP_GetSixLatestProducts]
AS

SELECT Bio, Title, [Type].[Label], Produit.Nom, [Description], DatePeremption, Quantite, Utilisateur.Nom, Utilisateur.Prenom 
FROM Produit, Marque, [Type], Etat, Photo, Utilisateur INNER JOIN Adresse On Adresse.IdUtilisateur = Utilisateur.IdUtilisateur ORDER BY DatePeremption

RETURN 0