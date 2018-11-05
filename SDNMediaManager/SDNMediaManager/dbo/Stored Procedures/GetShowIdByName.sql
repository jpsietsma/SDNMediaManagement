

CREATE PROCEDURE [dbo].[GetShowIdByName] 

	@ShowName NVARCHAR (200),
	@ShowID INT = NULL
AS
BEGIN

	SET NOCOUNT ON;

    SET @ShowID = (SELECT pk_ShowID FROM dbo.TelevisionShows WHERE ShowName = @ShowName)
	
	SELECT @ShowID AS "ShowID"

END
