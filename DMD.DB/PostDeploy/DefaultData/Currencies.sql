BEGIN
	INSERT INTO dbo.tblCurrency (Id, Name, Value)
	VALUES
	(NEWID(), 'Copper', 1),
	(NEWID(), 'Silver', 10),
	(NEWID(), 'Electrum', 50),
	(NEWID(), 'Gold', 100),
	(NEWID(), 'Platinum', 1000)
END