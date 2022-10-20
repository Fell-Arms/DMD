BEGIN
	INSERT INTO dbo.tblArmorType (Id, TypeName, Description)
	VALUES
	(NEWID(), 'Body Armor', 'Armor to protect your character'),
	(NEWID(), 'Shield', 'A tool for blocking')
END