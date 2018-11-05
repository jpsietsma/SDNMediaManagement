CREATE TABLE [dbo].[TelevisionShows] (
    [pk_ShowID]        INT            IDENTITY (1, 1) NOT NULL,
    [ShowName]         NVARCHAR (150) NOT NULL,
    [ShowDriveLetter]  NVARCHAR (1)   NOT NULL,
    [ShowHomePath]     NVARCHAR (200) NOT NULL,
    [ShowNumSeasons]   INT            CONSTRAINT [DF_sdnTelevisionShows_ShowNumSeasons] DEFAULT ((0)) NOT NULL,
    [ShowNumEpisodes]  INT            CONSTRAINT [DF_sdnTelevisionShows_ShowNumEpisodes] DEFAULT ((0)) NOT NULL,
    [ShowAlbumArtPath] NVARCHAR (200) CONSTRAINT [DF_sdnTelevisionShows_ShowAlbumArtPath] DEFAULT (N'~/tmp/img/0.jpg') NOT NULL,
    [IsEnabled]        INT            CONSTRAINT [DF_sdnTelevisionShows_IsEnabled] DEFAULT ((1)) NOT NULL,
    [TvdbID]           NVARCHAR (50)  NULL,
    [ImdbID]           NVARCHAR (50)  NULL,
    [fk_MediaType]     INT            NULL,
    CONSTRAINT [PK_sdnTelevisionShows] PRIMARY KEY CLUSTERED ([pk_ShowID] ASC)
);

