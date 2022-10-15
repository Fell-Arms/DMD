BEGIN
	INSERT INTO dbo.Characters (Id, FirstName, LastName, Race, Class, Level, ArmorClass, MaxHealth, --Character table name inconsistent. Change Later?
									CurrentHealth, CreationDate, LanguageId, StatsId, AttacksId, Alignment,
									Portrait, Age, Height, Weight, EyeColor, HairColor, HairStyle, UserId)
	VALUES
	(NEWID(), 'Bobby', 'Bobbinson', 'Dwarf', 'Paladin', 18, 3, '200',
			'200', GETDATE(2022-11-20), 'FK-LanguageID-GUID','FK-StatsID-GUID', 'FK-AttacksID-GUID', 'Good', --Test GETDATE function
			'img/BobbyBobbinson/portrait', 32, '4ft 3in', 210.5, 'Green', 'Black', 'Manbun', 'FK-AttacksID-GUID') 
END