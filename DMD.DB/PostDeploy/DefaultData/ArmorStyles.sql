BEGIN
	INSERT INTO dbo.tblArmorStyle (Id, StyleName, Description)
	VALUES
	(NEWID(), 'Leather', 'A leather armor made from deer hide'),
	(NEWID(), 'Chainmail', 'Chainmail made from the finest steel'),
	(NEWID(), 'Plate', 'Invincible plate armor from the gods')
END