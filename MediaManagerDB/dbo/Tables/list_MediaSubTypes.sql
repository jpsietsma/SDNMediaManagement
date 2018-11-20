CREATE TABLE [dbo].[list_MediaSubTypes] (
    [pk_MediaSubTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [MediaSubType]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_list_MediaSubTypes] PRIMARY KEY CLUSTERED ([pk_MediaSubTypeID] ASC)
);

