
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetShowSeasons] 
	-- Pass the PK of the show to return all seasons
	@showID INT

AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM TelevisionSeasons WHERE fk_ShowID = @showID

END