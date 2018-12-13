CREATE TABLE [dbo].[global_notifications] (
    [pk_NotificationID]    INT           IDENTITY (1, 1) NOT NULL,
    [notificationTitle]    NVARCHAR (50) NULL,
    [notificationMessage]  NVARCHAR (50) NOT NULL,
    [notificationSeverity] NVARCHAR (50) NOT NULL,
    [addedOn]              DATETIME      NOT NULL,
    [fk_userID]            INT           NULL,
    CONSTRAINT [PK_global_notifications] PRIMARY KEY CLUSTERED ([pk_NotificationID] ASC)
);

