BEGIN
	DECLARE @Language_Id1 uniqueindentifier, @Language_Id2 uniqueindentifier, @Language_Id3 uniqueindentifier,
			@Stat_Id1 uniqueindentifier, @Stat_Id2 uniqueindentifier, @Stat_Id3 uniqueindentifier,
			@Attack_Id1 uniqueindentifier, @Attack_Id2 uniqueindentifier, @Attack_Id3 uniqueindentifier,
			@User_Id1 uniqueindentifier, @User_Id2 uniqueindentifier, @User_Id3 uniqueindentifier;

	SELECT @Language_Id1 = Id FROM tblLanguage WHERE Name = 'Dwarvish'
	SELECT @Language_Id2 = Id FROM tblLanguage WHERE Name = 'Gnomish'
	SELECT @Language_Id3 = Id FROM tblLanguage WHERE Name = 'Common'

	SELECT @Stat_Id1 = Id FROM tblStat WHERE Name = 'Dexterity'
	SELECT @Stat_Id2 = Id FROM tblStat WHERE Name = 'Wisdom'
	SELECT @Stat_Id3 = Id FROM tblStat WHERE Name = 'Intelligence'

	SELECT @Attack_Id1 = Id FROM tblAttack WHERE Name = 'Slash'
	SELECT @Attack_Id2 = Id FROM tblAttack WHERE Name = 'Throw Pebble'
	SELECT @Attack_Id3 = Id FROM tblAttack WHERE Name = 'Attack'

	SELECT @User_Id1 = Id FROM tblUser WHERE Username = 'ketchum'
	SELECT @User_Id2 = Id FROM tblUser WHERE Username = 'bfoote'
	SELECT @User_Id3 = Id FROM tblUser WHERE Username = 'admin'


	INSERT INTO dbo.Characters (Id, FirstName, LastName, Race, Class, Level, ArmorClass, MaxHealth, --Character table name inconsistent. Change Later?
									CurrentHealth, CreationDate, LanguageId, StatsId, AttacksId, Alignment,
									Portrait, Age, Height, Weight, EyeColor, HairColor, HairStyle, UserId)
	VALUES
	(NEWID(), 'Bobby', 'Bobbinson', 'Dwarf', 'Paladin', 18, 3, '200',
			'200', GETDATE(2022-11-20), @Language_Id1, @Stat_Id1, @Attack_Id1, 'Lawful Good', --Test GETDATE function
			'img/BobbyBobbinson/portrait', 32, '4ft 3in', 210.5, 'Green', 'Brown', 'Manbun', @User_Id1),
			
	(NEWID(), 'Meatball', 'Gravydog', 'Gnome', 'Ranger', 5, 6, '100',
			'90', GETDATE(2022-10-12), @Language_Id2, @Stat_Id2, @Attack_Id2, 'Neutral', --Test GETDATE function
			'img/MeatballGravydog/portrait', 20, '1ft 10in', 32.8, 'Black', 'White', 'Buzzcut', @User_Id2), 

	(NEWID(), 'Synthia', 'Greywall', 'Human', 'Warlock', 60, 15, '1000',
			'950', GETDATE(2022-10-01), @Language_Id3, @Stat_Id3, @Attack_Id3, 'Chaotic Evil', --Test GETDATE function
			'img/SynthiaGreywall/portrait', 26, '5ft 4in', 120.5, 'Purple', 'Black', 'Wavy Down', @User_Id3) 
END