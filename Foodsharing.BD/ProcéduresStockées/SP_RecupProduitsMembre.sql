CREATE PROCEDURE [dbo].[SP_RecupProduitsMembre]
	@idUtilisateur int
AS
	SELECT * FROM [V_GetAllProducts] WHERE IdUtilisateur = @idUtilisateur
