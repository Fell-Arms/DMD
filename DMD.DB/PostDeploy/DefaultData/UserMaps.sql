BEGIN
	INSERT INTO dbo.tblUserMaps (Id, User_Id, Map_Id)
	VALUES
	(NEWID(), 'FK-UserID_GUID', 'FK-MapID_GUID', 5, 2, 20),
	(NEWID(), 'FK-UserID_GUID', 'FK-MapID', 7, 5, 50),
	(NEWID(), 'FK-UserID-GUID', 'FK-MapID', 10, 8, 100)
END