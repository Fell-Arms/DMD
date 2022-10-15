BEGIN
	INSERT INTO dbo.tblMap(Id, Type, ImagePath)
	VALUES
	(NEWID(), 'Combat', 'img/maps/forestCastle'), -- Example data. Map img paths need to be linked later
	(NEWID(), 'Adventure', 'img/maps/darkMarshland'),
	(NEWID(), 'Overview', 'img/maps/CityMap')
END