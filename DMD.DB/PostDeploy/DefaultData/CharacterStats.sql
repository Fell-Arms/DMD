BEGIN
	DECLARE @Stat_Id11 uniqueidentifier, @Stat_Id12 uniqueidentifier, @Stat_Id13 uniqueidentifier,
			@Character_Id11 uniqueidentifier, @Character_Id12 uniqueidentifier, @Character_Id13 uniqueidentifier;

	SELECT @Stat_Id11 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id12 = Id FROM tblStat WHERE Name = 'Dexterity'
	SELECT @Stat_Id13 = Id FROM tblStat WHERE Name = 'Intelligence'

	SELECT @Character_Id11 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id12 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id13 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterStats (Id, Character_Id, Stats_Id, Value)
	VALUES
	(NEWID(), @Character_Id11, @Stat_Id11, 1),
	(NEWID(), @Character_Id12, @Stat_Id12, 2),
	(NEWID(), @Character_Id13, @Stat_Id13, 3)
END