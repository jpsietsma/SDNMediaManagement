CREATE TABLE [dbo].[ProcessQueue] (
    [pk_ProcessID]          INT            IDENTITY (1, 1) NOT NULL,
    [RequestTimestamp]      DATETIME2 (3)  CONSTRAINT [DF_sdnProcessQueue_RequestTimestamp] DEFAULT (sysdatetime()) NOT NULL,
    [ProcessAction]         INT            NOT NULL,
    [fk_AutomationPriority] INT            NOT NULL,
    [fk_AutomationStatus]   INT            NOT NULL,
    [fk_UserID]             NVARCHAR (100) NOT NULL,
    [fk_MediaID]            INT            NULL,
    [NextAction]            INT            NULL,
    CONSTRAINT [PK_sdnProcessQueue] PRIMARY KEY CLUSTERED ([pk_ProcessID] ASC),
    CONSTRAINT [FK_sdnProcessQueue_list_AutomationPriority] FOREIGN KEY ([fk_AutomationPriority]) REFERENCES [dbo].[list_AutomationPriority] ([pk_PriorityID]),
    CONSTRAINT [FK_sdnProcessQueue_list_AutomationStatuses] FOREIGN KEY ([fk_AutomationStatus]) REFERENCES [dbo].[list_AutomationStatuses] ([pk_automationStatus])
);

