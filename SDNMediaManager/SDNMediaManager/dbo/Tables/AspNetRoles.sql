CREATE TABLE [dbo].[AspNetRoles] (
    [Id]                    NVARCHAR (128) NOT NULL,
    [Name]                  NVARCHAR (256) NOT NULL,
    [fk_PermissionLevelNum] INT            CONSTRAINT [DF_AspNetRoles_fk_PermissionLevelNum] DEFAULT ((200)) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetRoles_list_permissionLevels] FOREIGN KEY ([fk_PermissionLevelNum]) REFERENCES [dbo].[list_permissionLevels] ([pk_permissionLevelNum])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [dbo].[AspNetRoles]([Name] ASC);

