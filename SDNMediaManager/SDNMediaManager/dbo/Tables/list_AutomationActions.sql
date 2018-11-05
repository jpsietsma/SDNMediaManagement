CREATE TABLE [dbo].[list_AutomationActions] (
    [pk_ActionType]     INT           IDENTITY (1, 1) NOT NULL,
    [ActionDescription] NVARCHAR (50) NOT NULL,
    [fk_PriorityID]     INT           NOT NULL,
    CONSTRAINT [PK_list_AutomationActions] PRIMARY KEY CLUSTERED ([pk_ActionType] ASC)
);

