

CREATE PROCEDURE [dbo].[GetSortItems] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.sortItems
END
