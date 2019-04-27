CREATE TABLE [dbo].[Booking] (
    [BookingID]     INT           NOT NULL,
    [BookingDate]   DATE          NULL,
    [BookingStatus] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([BookingID] ASC)
);

