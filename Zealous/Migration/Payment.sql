CREATE TABLE [dbo].[Payment] (
    [ID]      INT          IDENTITY (1, 1) NOT NULL,
    [Amount]  float (53)   NULL,
    [Date]    datetime NULL,
    [EventId] Int NULL,
    [UserId]  NVARCHAR (128) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

