

CREATE PROCEDURE [dbo].[GetUsers] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.AspNetUsers
END