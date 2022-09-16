BEGIN
	INSERT INTO dbo.tblUser SELECT NEWID(), 'admin', 'password', 'admin@dmd.com', 'Danny', 'Phantom'
END