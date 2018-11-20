CREATE TABLE [dbo].[FileMoveHistory] (
    [pk_moveID]       INT            IDENTITY (1, 1) NOT NULL,
    [MoveSource]      NVARCHAR (200) NOT NULL,
    [MoveDestination] NVARCHAR (200) NOT NULL,
    [fk_MediaID]      INT            NOT NULL,
    [MoveTime]        DATETIME2 (3)  NOT NULL,
    [fk_ProcessID]    INT            NULL,
    CONSTRAINT [PK_sdnFileMoveHistory] PRIMARY KEY CLUSTERED ([pk_moveID] ASC),
    CONSTRAINT [FK_sdnFileMoveHistory_sdnFileMoveHistory] FOREIGN KEY ([fk_MediaID]) REFERENCES [dbo].[sortItems] ([pk_MediaID]),
    CONSTRAINT [FK_sdnFileMoveHistory_sdnProcessQueue] FOREIGN KEY ([fk_ProcessID]) REFERENCES [dbo].[ProcessQueue] ([pk_ProcessID])
);

