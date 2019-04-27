CREATE TABLE [dbo].[Payment] (
    [ID]      INT          IDENTITY (1, 1) NOT NULL,
    [Amount]  FLOAT (53)   NULL,
    [Date]    VARCHAR (30) NULL,
    [Time]    VARCHAR (15) NULL,
    [EventId] VARCHAR (30) NULL,
    [UserId]  VARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

