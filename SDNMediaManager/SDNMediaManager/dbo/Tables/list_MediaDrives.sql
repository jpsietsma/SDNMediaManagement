CREATE TABLE [dbo].[list_MediaDrives] (
    [pk_MediaDriveID] INT           IDENTITY (1, 1) NOT NULL,
    [DriveLetter]     CHAR (1)      NOT NULL,
    [fk_MediaTypeID]  INT           NOT NULL,
    [DriveSpace]      NVARCHAR (50) CONSTRAINT [DF_list_MediaDrives_DriveSpace] DEFAULT (N'unscanned') NOT NULL,
    CONSTRAINT [PK_list_MediaDrives] PRIMARY KEY CLUSTERED ([pk_MediaDriveID] ASC),
    CONSTRAINT [FK_list_MediaDrives_list_MediaTypes] FOREIGN KEY ([pk_MediaDriveID]) REFERENCES [dbo].[list_MediaTypes] ([pk_MediaTypeID])
);

