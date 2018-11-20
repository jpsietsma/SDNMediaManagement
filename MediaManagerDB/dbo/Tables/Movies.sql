CREATE TABLE [dbo].[Movies] (
    [pk_MovieID]     INT            NOT NULL,
    [MovieTitle]     NVARCHAR (200) NOT NULL,
    [MovieYear]      INT            NULL,
    [fk_MovieGenre]  INT            CONSTRAINT [DF_sdnMovies_fk_MovieGenre] DEFAULT ((0)) NOT NULL,
    [FilePath]       NVARCHAR (200) NULL,
    [ImdbID]         NVARCHAR (25)  NULL,
    [TvdbID]         NVARCHAR (25)  NULL,
    [SubtitlesExist] INT            CONSTRAINT [DF_sdnMovies_SubtitlesExist] DEFAULT ((0)) NOT NULL,
    [fk_MediaID]     INT            NULL,
    [fk_MediaType]   INT            NOT NULL,
    CONSTRAINT [PK_sdnMovies] PRIMARY KEY CLUSTERED ([pk_MovieID] ASC),
    CONSTRAINT [FK_sdnMovies_list_MediaTypes] FOREIGN KEY ([fk_MediaType]) REFERENCES [dbo].[list_MediaTypes] ([pk_MediaTypeID]),
    CONSTRAINT [FK_sdnMovies_list_MovieGenres] FOREIGN KEY ([fk_MovieGenre]) REFERENCES [dbo].[list_MovieGenres] ([pk_GenreID]),
    CONSTRAINT [FK_sdnMovies_sortItems] FOREIGN KEY ([fk_MediaID]) REFERENCES [dbo].[sortItems] ([pk_MediaID])
);

