CREATE TRIGGER dbo.AfterTrigger
ON dbo.tblUsers
AFTER INSERT
AS
BEGIN
	SELECT *
	FROM inserted

	SELECT *
	FROM tblUsers

	SELECT @@ROWCOUNT
END