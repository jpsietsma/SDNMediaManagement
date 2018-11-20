
-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 2018-10-18
-- Description:	returns daily downloads, counts reset at midnight
-- =============================================
CREATE PROCEDURE [dbo].[GetDailyDownloads] 

AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @date NVARCHAR(50) = (SELECT CONVERT (DATE, SYSDATETIME()))

	SELECT * FROM dbo.DownloadQueue WHERE DownloadStarted LIKE @date + '%'

END