CREATE TABLE [dbo].[TelevisionEpisodes] (
    [pk_EpisodeID]        INT            IDENTITY (1, 1) NOT NULL,
    [fk_SeasonID]         INT            NOT NULL,
    [fk_ShowID]           INT            NOT NULL,
    [EpisodeNum]          INT            NOT NULL,
    [EpisodePath]         NVARCHAR (300) NOT NULL,
    [EpisodePlayerPath]   NVARCHAR (300) CONSTRAINT [DF_sdnTelevisionEpisodes_EpisodePlayerPath] DEFAULT (N'http://jimmysietsma.com/media/') NOT NULL,
    [EpisodeDisplayTitle] NVARCHAR (100) NOT NULL,
    [EpisodeAlbumArtPath] NVARCHAR (150) CONSTRAINT [DF_sdnTelevisionEpisodes_EpisodeAlbumArtPath] DEFAULT ('~/tmp/img/0-0-0.jpg') NOT NULL,
    [IsEnabled]           INT            CONSTRAINT [DF_sdnTelevisionEpisodes_IsEnabled] DEFAULT ((1)) NOT NULL,
    [fk_MediaID]          INT            NULL,
    [fk_MediaType]        INT            NULL,
    CONSTRAINT [PK_sdnTelevisionEpisodes] PRIMARY KEY CLUSTERED ([pk_EpisodeID] ASC),
    CONSTRAINT [FK_sdnTelevisionEpisodes_list_MediaTypes] FOREIGN KEY ([fk_MediaID]) REFERENCES [dbo].[list_MediaTypes] ([pk_MediaTypeID]),
    CONSTRAINT [FK_sdnTelevisionEpisodes_sdnTelevisionSeasons] FOREIGN KEY ([fk_SeasonID]) REFERENCES [dbo].[TelevisionSeasons] ([pk_SeasonID]),
    CONSTRAINT [FK_sdnTelevisionEpisodes_ShowID_sdnTelevisionShows] FOREIGN KEY ([fk_ShowID]) REFERENCES [dbo].[TelevisionShows] ([pk_ShowID]),
    CONSTRAINT [FK_sdnTelevisionEpisodes_sortItems] FOREIGN KEY ([fk_MediaID]) REFERENCES [dbo].[sortItems] ([pk_MediaID])
);

