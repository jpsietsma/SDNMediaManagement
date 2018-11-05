CREATE TABLE [dbo].[list_MediaTypes] (
    [pk_MediaTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [mediaTypeName]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_list_MediaTypes] PRIMARY KEY CLUSTERED ([pk_MediaTypeID] ASC)
);

