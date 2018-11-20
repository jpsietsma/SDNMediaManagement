-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 10/21/2018
-- Description:	Returns streaming url for kendo media player
-- =============================================
CREATE PROCEDURE BuildEpisodeStreamingUrl 

	@fileName NVARCHAR(150),
	@showName NVARCHAR(75),
	@showFile NVARCHAR(100),
	@showSeason NVARCHAR(25)

AS
BEGIN
	SET NOCOUNT ON;
		
    -- Declare our variables here
	DECLARE @baseUrl NVARCHAR(250),
			@showDrive NVARCHAR(3)
			

	--Begin the body of our code
	SET @baseUrl = 'http://www.jimmysietsma.com/media/tv/'
	SET @showDrive = SUBSTRING((@fileName), 1, 1)

	SET	@baseUrl = CONCAT(@baseUrl, @showDrive, '/TV Shows/', @showName + '/', @showSeason + '/', @showFile)
	
	SELECT @baseUrl AS 'Url'
END