-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 12/10/2018
-- Description:	Get Episodes for a Show - Reports Server SP
-- =============================================
CREATE PROCEDURE RS_Television_GetShowEpisodes 

	-- Add the parameters for the stored procedure here
	@showID INT
AS
BEGIN
	SET NOCOUNT ON;
		
	SELECT * FROM dbo.TelevisionEpisodes WHERE fk_ShowID = @showID

END
