CREATE TABLE [dbo].[list_TaskTypes] (
    [pk_TaskTypeID]   INT           NOT NULL,
    [TaskTypeName]    NVARCHAR (75) NOT NULL,
    [fk_TaskPriority] INT           NOT NULL,
    CONSTRAINT [PK_list_TaskTypes] PRIMARY KEY CLUSTERED ([pk_TaskTypeID] ASC),
    CONSTRAINT [FK_list_TaskTypes_list_TaskTypes] FOREIGN KEY ([fk_TaskPriority]) REFERENCES [dbo].[list_AutomationPriority] ([pk_PriorityID])
);

