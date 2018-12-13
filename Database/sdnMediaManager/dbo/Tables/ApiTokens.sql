CREATE TABLE [dbo].[ApiTokens] (
    [pk_tokenID]  INT            NOT NULL,
    [Token]       NVARCHAR (150) NOT NULL,
    [lastRefresh] DATETIME2 (3)  NOT NULL,
    [tokenSite]   NCHAR (10)     NOT NULL,
    [fk_UserID]   NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_sdnApiTokens] PRIMARY KEY CLUSTERED ([pk_tokenID] ASC),
    CONSTRAINT [FK_sdnApiTokens_sdnApiTokens] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

