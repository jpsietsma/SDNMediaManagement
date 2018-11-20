

CREATE PROCEDURE [dbo].[GetOrphanSortItems] 

	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;

    SELECT s.pk_MediaID, s.filePath, s.fileName, s.hasBeenSanitized, s.fileNameSanitized, 
	   s.hasBeenProcessed, s.fileModified, s.fileAdded, s.fk_fileMediaTypeID, s.fk_automationStatus,
	   s.finalizedFilePath, s.finalizedFileName, s.finalizedShowName, s.finalizedShowSeason, 
	   s.finalizedShowEpisode, s.hasBeenFinalized, s.hasBeenDistributed, s.dlFileExists, 
	   s.finalizedStatus, dl.pk_torrentID AS 'fk_torrentID', dl.TorrentName, dl.DownloadFinished, dl.DownloadStarted, 
       dl.TorrentStatus, dl.TorrentPath, dl.DownloadDuration

FROM (SELECT pk_MediaID, filePath, fileName, hasBeenSanitized, fileNameSanitized, hasBeenProcessed,
			 fileModified, fileAdded, fk_fileMediaTypeID, fk_automationStatus, finalizedFilePath, 
			 finalizedFileName, finalizedShowName, finalizedShowSeason, finalizedShowEpisode, 
			 hasBeenFinalized, hasBeenDistributed, dlFileExists, finalizedStatus, fk_torrentID
       FROM dbo.sortItems
	   ) 
AS s 
LEFT OUTER JOIN(SELECT pk_torrentID, TorrentName, DownloadFinished, DownloadStarted, TorrentStatus, 
				  TorrentPath, DownloadDuration
           FROM dbo.DownloadQueue
		   ) 
AS dl 
ON (s.fileName = dl.TorrentName) OR (s.fk_torrentID = dl.pk_torrentID)

WHERE dl.DownloadStarted IS NULL

END
