CREATE TABLE [dbo].[Product] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [item_number ] INT          NULL,
    [item_name]    NCHAR (10)   NULL,
    [amount]       DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

