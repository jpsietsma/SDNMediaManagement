
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetShowEpisodesBySeason] 
	-- Pass the PK of the season to return all Episodes
	@seasonID INT

AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM TelevisionEpisodes WHERE fk_SeasonID = @seasonID

END