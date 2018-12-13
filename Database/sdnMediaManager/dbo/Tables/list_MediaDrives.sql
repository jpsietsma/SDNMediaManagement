CREATE TABLE [dbo].[list_MediaDrives] (
    [pk_MediaDriveID]   INT           IDENTITY (1, 1) NOT NULL,
    [DriveLetter]       CHAR (1)      NOT NULL,
    [fk_MediaTypeID]    INT           NOT NULL,
    [fk_MediaSubTypeID] INT           NULL,
    [DriveFreeSpace]    NVARCHAR (50) CONSTRAINT [DF_list_MediaDrives_DriveSpace] DEFAULT (N'unscanned') NULL,
    [DriveCapacity]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_list_MediaDrives] PRIMARY KEY CLUSTERED ([pk_MediaDriveID] ASC),
    CONSTRAINT [FK_list_MediaDrives_list_MediaSubTypes] FOREIGN KEY ([fk_MediaSubTypeID]) REFERENCES [dbo].[list_MediaSubTypes] ([pk_MediaSubTypeID]),
    CONSTRAINT [FK_list_MediaDrives_list_MediaTypes] FOREIGN KEY ([fk_MediaTypeID]) REFERENCES [dbo].[list_MediaTypes] ([pk_MediaTypeID])
);

