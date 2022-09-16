BEGIN
	INSERT INTO dbo.tblUser (Id, Username, Password, Email, FirstName, LastName)
	VALUES
	(NEWID(), 'admin', 'password', 'admin@dmd.com', 'Danny', 'Phantom'),
	(NEWID(), 'bfoote', 'maple', 'test@test.com', 'Brian', 'Foote'),
	(NEWID(), 'ketchum', 'maple', 'ashketchum@test.com', 'Ash', 'Ketchum')
END