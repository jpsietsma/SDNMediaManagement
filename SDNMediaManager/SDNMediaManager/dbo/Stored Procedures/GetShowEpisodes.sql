
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetShowEpisodes] 
	-- Pass the PK of the show to return all Episodes
	@showID INT

AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM TelevisionEpisodes WHERE fk_ShowID = @showID

END
