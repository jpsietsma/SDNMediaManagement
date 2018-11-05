CREATE TABLE [dbo].[DownloadQueue] (
    [pk_torrentID]     NVARCHAR (150) NOT NULL,
    [TorrentName]      NVARCHAR (150) NOT NULL,
    [DownloadFinished] DATETIME2 (3)  NULL,
    [DownloadStarted]  DATETIME2 (3)  NULL,
    [TorrentStatus]    NVARCHAR (50)  NOT NULL,
    [TorrentPath]      NVARCHAR (150) NULL,
    [DownloadDuration] AS             (datediff(minute,[DownloadStarted],[DownloadFinished])),
    [fileSize]         INT            CONSTRAINT [DF_sdnDownloadQueue_FileSize] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_sdnDownloadQueue] PRIMARY KEY CLUSTERED ([pk_torrentID] ASC)
);

