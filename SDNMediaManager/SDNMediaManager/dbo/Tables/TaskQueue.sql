CREATE TABLE [dbo].[TaskQueue] (
    [pk_TaskID]       INT            NOT NULL,
    [TaskTitle]       NVARCHAR (50)  NOT NULL,
    [TaskStartTime]   DATETIME2 (3)  NOT NULL,
    [TaskEndTime]     DATETIME2 (3)  NULL,
    [fk_ParentTaskID] INT            NULL,
    [fk_TaskStatus]   INT            NOT NULL,
    [fk_TaskOwner]    NVARCHAR (128) NOT NULL,
    [TaskDetails]     TEXT           NOT NULL,
    [fk_ActionType]   INT            NOT NULL,
    CONSTRAINT [PK_sdnTaskQueue] PRIMARY KEY CLUSTERED ([pk_TaskID] ASC),
    CONSTRAINT [FK_sdnTaskQueue_list_AutomationActions] FOREIGN KEY ([fk_ActionType]) REFERENCES [dbo].[list_AutomationActions] ([pk_ActionType]),
    CONSTRAINT [FK_sdnTaskQueue_list_AutomationStatuses] FOREIGN KEY ([fk_TaskStatus]) REFERENCES [dbo].[list_AutomationStatuses] ([pk_automationStatus]),
    CONSTRAINT [FK_sdnTaskQueue_sdnParentTask] FOREIGN KEY ([fk_ParentTaskID]) REFERENCES [dbo].[TaskQueue] ([pk_TaskID]),
    CONSTRAINT [FK_sdnTaskQueue_sdnTaskOwner] FOREIGN KEY ([fk_TaskOwner]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

