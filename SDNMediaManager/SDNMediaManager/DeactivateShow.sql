

CREATE PROCEDURE [dbo].[DeactivateShow] 
	-- Add the parameters for the stored procedure here
	@showID INT
AS
BEGIN
	SET NOCOUNT OFF;

    UPDATE TelevisionShows SET IsEnabled = '0' WHERE pk_ShowID = @showID
END
