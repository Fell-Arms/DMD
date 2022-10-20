BEGIN
	DECLARE @Stat_Id1 uniqueindentifier, @Stat_Id2 uniqueindentifier, @Stat_Id3 uniqueindentifier,
			@Stat_Id4 uniqueindentifier, @Stat_Id5 uniqueindentifier, @Stat_Id6 uniqueindentifier;

	SELECT @Stat_Id1 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id2 = Id FROM tblStat WHERE Name = 'Dexterity'
	SELECT @Stat_Id3 = Id FROM tblStat WHERE Name = 'Constitution'
	SELECT @Stat_Id4 = Id FROM tblStat WHERE Name = 'Wisdom'
	SELECT @Stat_Id5 = Id FROM tblStat WHERE Name = 'Intelligence'
	SELECT @Stat_Id6 = Id FROM tblStat WHERE Name = 'Charisma'

	INSERT INTO dbo.tblSkill (Id, Stats_Id, Name, Description)
	VALUES
	(NEWID(), @Stat_Id2, 'Acrobatics ', 'Uses DEX'),
	(NEWID(), @Stat_Id4, 'Animal Handling', 'Uses WIS'),
	(NEWID(), @Stat_Id5, 'Arcana ', 'Uses INT'),
	(NEWID(), @Stat_Id1, 'Athletics', 'Uses STR'),
	(NEWID(), @Stat_Id6, 'Deception ', 'Uses CHA'),
	(NEWID(), @Stat_Id5, 'History ', 'Uses INT'),
	(NEWID(), @Stat_Id4, 'Insight', 'Uses WIS'),
	(NEWID(), @Stat_Id6, 'Intimidation ', 'Uses CHA'),
	(NEWID(), @Stat_Id5, 'Investigation ', 'Uses INT'),
	(NEWID(), @Stat_Id4, 'Medicine ', 'Uses WIS'),
	(NEWID(), @Stat_Id5, 'Nature ', 'Uses INT'),
	(NEWID(), @Stat_Id4, 'Perception ', 'Uses WIS'),
	(NEWID(), @Stat_Id6, 'Performance ', 'Uses CHA'),
	(NEWID(), @Stat_Id6, 'Persuasion', 'Uses CHA'),
	(NEWID(), @Stat_Id5, 'Religion ', 'Uses INT'),
	(NEWID(), @Stat_Id2, 'Sleight of Hand', 'Uses DEX'),
	(NEWID(), @Stat_Id2, 'Stealth', 'Uses DEX'),
	(NEWID(), @Stat_Id4, 'Survival ', 'Uses WIS')	
END