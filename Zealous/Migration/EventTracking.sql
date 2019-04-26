
CREATE TABLE [dbo].[EventTracking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[OrganizerId] [int] NULL,
	[SupplierId] [int] NOT NULL,
	[ActionId] [int] NOT NULL,
	[PaymentId] [int] NULL,
	[Date] [datetime] NOT NULL,
	[Note] [nvarchar](250) NULL,
	[EventStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_EventTracking] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


