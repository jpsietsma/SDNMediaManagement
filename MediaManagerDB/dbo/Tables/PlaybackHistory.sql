CREATE TABLE [dbo].[PlaybackHistory] (
    [pk_PlaybackID]           INT            IDENTITY (1, 1) NOT NULL,
    [PlaybackDate]            DATETIME2 (3)  CONSTRAINT [DF_sdnPlaybackHistory_PlaybackDate] DEFAULT (sysdatetime()) NOT NULL,
    [fk_UserID]               NVARCHAR (128) NOT NULL,
    [PlaybackProgressStopped] INT            NOT NULL,
    [fk_EpisodeID]            INT            NOT NULL,
    [fk_ShowID]               INT            NOT NULL,
    [fk_SeasonID]             INT            NOT NULL,
    CONSTRAINT [PK_sdnPlaybackHistory] PRIMARY KEY CLUSTERED ([pk_PlaybackID] ASC),
    CONSTRAINT [FK_sdnPlaybackHistory_AspNetUsers] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_sdnPlaybackHistory_sdnTelevisionEpisodes] FOREIGN KEY ([fk_EpisodeID]) REFERENCES [dbo].[TelevisionEpisodes] ([pk_EpisodeID]),
    CONSTRAINT [FK_sdnPlaybackHistory_sdnTelevisionSeasons] FOREIGN KEY ([fk_SeasonID]) REFERENCES [dbo].[TelevisionSeasons] ([pk_SeasonID]),
    CONSTRAINT [FK_sdnPlaybackHistory_sdnTelevisionShows] FOREIGN KEY ([fk_ShowID]) REFERENCES [dbo].[TelevisionShows] ([pk_ShowID])
);

