﻿BEGIN
	INSERT INTO dbo.tblMap(Id, Type, ImagePath)
	VALUES
	(NEWID(), 'Combat', 'DungeonMap.jpg'),
	(NEWID(), 'Adventure', 'Map1.jpg'),
	(NEWID(), 'Overview', 'Map1.jpg')
END