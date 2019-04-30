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
           (1 ,1, NULL, NULL, NULL, 1, GETDATE(), 'Note1', 1),
		   (1 ,1, NULL, NULL, NULL, 1, GETDATE(), 'Note2', 1),
		   (1 ,1, NULL, NULL, NULL, 1, GETDATE(), 'Note3', 1),
		   (1 ,1, NULL, NULL, NULL, 1, GETDATE(), 'Note4', 1)



