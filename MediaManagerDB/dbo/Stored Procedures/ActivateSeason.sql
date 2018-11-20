

CREATE PROCEDURE [dbo].[ActivateSeason] 
	-- Add the parameters for the stored procedure here
	@seasonID INT
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE TelevisionSeasons SET IsEnabled = '1' WHERE pk_SeasonID = @seasonID
END