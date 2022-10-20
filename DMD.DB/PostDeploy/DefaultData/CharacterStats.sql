BEGIN
	DECLARE @Stat_Id1 uniqueindentifier, @Stat_Id2 uniqueindentifier, @Stat_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Stat_Id1 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id2 = Id FROM tblStat WHERE Name = 'Dexterity'
	SELECT @Stat_Id3 = Id FROM tblStat WHERE Name = 'Intelligence'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterStats (Id, Character_Id, Stats_Id, Value)
	VALUES
	(NEWID(), @Character_Id1, @Stat_Id1, 1),
	(NEWID(), @Character_Id2, @Stat_Id2, 2),
	(NEWID(), @Character_Id3, @Stat_Id3, 3)
END