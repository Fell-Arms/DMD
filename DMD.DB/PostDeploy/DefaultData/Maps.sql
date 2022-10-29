BEGIN
	INSERT INTO dbo.tblMap(Id, Type, ImagePath)
	VALUES
	(NEWID(), 'Combat', 'forestCastle.png'), -- Example data. Map img paths need to be linked later
	(NEWID(), 'Adventure', 'darkMarshland.png'),
	(NEWID(), 'Overview', 'CityMap.png')
END