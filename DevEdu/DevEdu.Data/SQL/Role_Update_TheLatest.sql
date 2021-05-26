USE [DevEducation]
GO
/****** Object:  StoredProcedure [dbo].[Role_Update]    Script Date: 27.02.2020 12:14:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Role_Update]
	@id int,
	@name nvarchar(100)
AS
BEGIN
	UPDATE dbo.Role
	SET Name = @name
	WHERE ID = @id
END

