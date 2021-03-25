CREATE PROCEDURE [dbo].[SP_GetTypeProduit]
	@type nvarchar(50)
AS
	SELECT * FROM [V_GetAllProducts] WHERE Type = @type

