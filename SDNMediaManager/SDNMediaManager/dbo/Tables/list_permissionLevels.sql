CREATE TABLE [dbo].[list_permissionLevels] (
    [pk_permissionLevelNum]  INT          CONSTRAINT [DF_list_permissionLevels_pk_permissionLevelNum] DEFAULT ((300)) NOT NULL,
    [permissionLevelAuth]    VARCHAR (50) NOT NULL,
    [permissionLevelDisplay] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_list_permissionLevels] PRIMARY KEY CLUSTERED ([pk_permissionLevelNum] ASC)
);

