BEGIN
	INSERT INTO dbo.tblArmorType (Id, TypeName, Description)
	VALUES
	(NEWID(), 'Light', 'A light armor for mages'),
	(NEWID(), 'Medium', 'A medium armor for rogues'),
	(NEWID(), 'Heavy', 'A heavy armor for warriors')
END