CREATE TABLE [dbo].[list_MovieGenres] (
    [pk_GenreID]    INT            NOT NULL,
    [GenreName]     NVARCHAR (50)  NOT NULL,
    [GenreEnabled]  INT            CONSTRAINT [DF_list_MovieGenres_GenreEnabled] DEFAULT ((1)) NOT NULL,
    [GenreHomePath] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_list_MovieGenres] PRIMARY KEY CLUSTERED ([pk_GenreID] ASC)
);

