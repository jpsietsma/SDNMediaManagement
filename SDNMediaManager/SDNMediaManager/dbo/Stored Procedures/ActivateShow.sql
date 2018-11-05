﻿

CREATE PROCEDURE [dbo].[ActivateShow] 
	-- Add the parameters for the stored procedure here
	@showID INT
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE TelevisionShows SET IsEnabled = '1' WHERE pk_ShowID = @showID
END
