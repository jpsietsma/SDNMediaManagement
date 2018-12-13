

CREATE PROCEDURE [dbo].[ActivateEpisode] 
	-- Add the parameters for the stored procedure here
	@episodeID INT
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE TelevisionEpisodes SET IsEnabled = '1' WHERE pk_EpisodeID = @episodeID
END
