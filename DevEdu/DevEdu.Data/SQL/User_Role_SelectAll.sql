USE [DevEducation]
GO
/****** Object:  StoredProcedure [dbo].[User_Role_SelectAll]    Script Date: 25.02.2020 13:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[User_Role_SelectAll]

AS

BEGIN

SELECT ID, UserID, RoleID FROM User_Role;

END