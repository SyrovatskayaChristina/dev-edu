USE [DevEducation]
GO
/****** Object:  StoredProcedure [dbo].[Role_Insert]    Script Date: 27.02.2020 11:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Role_Insert]
	@name nvarchar(100)
AS
BEGIN
	INSERT INTO dbo.Role
	VALUES (@name)
	SELECT SCOPE_IDENTITY()
END