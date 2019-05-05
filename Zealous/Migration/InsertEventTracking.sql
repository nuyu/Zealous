
DECLARE @CustomerId AS NVARCHAR(120) 
DECLARE @SupplierId AS NVARCHAR(120) 
DECLARE @EventId AS INT 

SELECT @CustomerId = MIN(Id )
FROM AspNetUsers
SELECT @SupplierId = MAX(Id )
FROM AspNetUsers
SELECT @EventId = MIN(Id )
FROM [Event]

INSERT INTO [EventTracking]
           ([EventId]
           ,[CustomerId]
           ,[OrganizerId]
           ,[SupplierId]
           ,[PaymentId]
           ,[Date]
           ,[Note]
           ,[EventStatus])

     VALUES
           (@EventId ,@CustomerId, NULL, @SupplierId, NULL, GETDATE(), 'Event Created', 0),
		   (@EventId ,@CustomerId, NULL, @SupplierId, NULL, DATEADD(hour, 1, GETDATE()), 'Pending', 1),
		   (@EventId ,@CustomerId, NULL, @SupplierId, 1, DATEADD(day, 1, GETDATE()), 'Approved', 2),
		   (@EventId ,@CustomerId, NULL, @SupplierId, NULL, DATEADD(hour, 1, DATEADD(day, 1, GETDATE())), 'Wait', 3)



