BEGIN
	INSERT INTO dbo.tblCharacterStats (Id, Character_Id, Stats_Id, Value)
	VALUES
	(NEWID(), 'FK-CharacterID-GUID', 'FK-StatsID-GUID', 1),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-StatsID-GUID', 2),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-StatsID-GUID', 3)
END