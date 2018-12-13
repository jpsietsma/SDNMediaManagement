CREATE TABLE [dbo].[list_AutomationStatuses] (
    [pk_automationStatus]     INT           IDENTITY (1, 1) NOT NULL,
    [automationStatusDisplay] VARCHAR (100) NOT NULL,
    [automationNextAction]    INT           CONSTRAINT [DF_list_automationStatuses_automationNextAction] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_list_automationStatuses] PRIMARY KEY CLUSTERED ([pk_automationStatus] ASC)
);

