CREATE VIEW [dbo].[V_GetAllProducts]
	AS 
    SELECT dbo.PropositionProduit.IdUtilisateur, dbo.PropositionProduit.IdProduit, dbo.Utilisateur.Nom, dbo.Utilisateur.Prenom, dbo.Type.Label AS Type, dbo.Produit.Nom AS NomProduit, dbo.Produit.DatePeremption, dbo.Produit.Quantite, dbo.Produit.Description, dbo.Produit.Bio
    FROM dbo.Produit 
    INNER JOIN
    dbo.Type ON dbo.Produit.IdType = dbo.Type.IdType 
    INNER JOIN
    dbo.PropositionProduit ON dbo.Produit.IdProduit = dbo.PropositionProduit.IdProduit 
    INNER JOIN
    dbo.Utilisateur ON dbo.PropositionProduit.IdUtilisateur = dbo.Utilisateur.IdUtilisateur
