CREATE TABLE [dbo].[TelevisionSeasons] (
    [pk_SeasonID]        INT            IDENTITY (1, 1) NOT NULL,
    [fk_ShowID]          INT            NOT NULL,
    [SeasonName]         NVARCHAR (15)  NOT NULL,
    [SeasonHomePath]     NVARCHAR (100) NOT NULL,
    [SeasonNumEpisodes]  INT            CONSTRAINT [DF_sdnTelevisionSeasons_SeasonNumEpisodes] DEFAULT ((0)) NOT NULL,
    [SeasonAlbumArtPath] NVARCHAR (150) CONSTRAINT [DF_sdnTelevisionSeasons_SeasonAlbumArt] DEFAULT (N'~/tmp/img/0-0.jpg') NOT NULL,
    [IsEnabled]          BIT            CONSTRAINT [DF_sdnTelevisionSeasons_IsEnabled] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_sdnTelevisionSeasons] PRIMARY KEY CLUSTERED ([pk_SeasonID] ASC),
    CONSTRAINT [FK_sdnTelevisionSeasons_ShowID_sdnTelevisionShows] FOREIGN KEY ([fk_ShowID]) REFERENCES [dbo].[TelevisionShows] ([pk_ShowID])
);

