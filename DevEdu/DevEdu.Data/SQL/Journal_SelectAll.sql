DROP PROC IF EXISTS dbo.Journal_SelectAll
GO

CREATE PROC dbo.Journal_SelectAll 	
AS
BEGIN
	SELECT ID, UserID, LessonID, IsAbsent, Feadback, AbsentReason FROM dbo.Journal
END
