CREATE TABLE [dbo].[TrackedShows] (
    [pk_trackingID] INT            IDENTITY (1, 1) NOT NULL,
    [fk_userID]     NVARCHAR (128) NOT NULL,
    [fk_showID]     INT            NOT NULL,
    CONSTRAINT [PK_TrackedShows] PRIMARY KEY CLUSTERED ([pk_trackingID] ASC),
    CONSTRAINT [FK_TrackedShows_AspNetUsers] FOREIGN KEY ([fk_userID]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_TrackedShows_TelevisionShows] FOREIGN KEY ([fk_showID]) REFERENCES [dbo].[TelevisionShows] ([pk_ShowID])
);

