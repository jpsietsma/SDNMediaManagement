CREATE TABLE [dbo].[list_AutomationPriority] (
    [pk_PriorityID]       INT            IDENTITY (1, 1) NOT NULL,
    [PriorityDescription] NVARCHAR (250) NOT NULL,
    [PriorityLevel]       INT            NOT NULL,
    CONSTRAINT [PK_list_AutomationPriority] PRIMARY KEY CLUSTERED ([pk_PriorityID] ASC)
);

