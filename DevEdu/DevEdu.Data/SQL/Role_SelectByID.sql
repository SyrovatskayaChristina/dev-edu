DROP PROC IF EXISTS dbo.Role_SelectByID
GO

CREATE PROC [dbo].Role_SelectByID	
	@id int
AS
BEGIN
	SELECT ID, Name
	FROM dbo.Role
	WHERE ID = @id
END