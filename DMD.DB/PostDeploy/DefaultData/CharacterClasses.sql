BEGIN
	INSERT INTO dbo.tblCharacterClasses(Id, Character_Id, Class_Id, Class_Level)
	VALUES
	(NEWID(), 'FK-CharacterID_GUID', 'FK-ClassID_GUID', 1),
	(NEWID(), 'FK-CharacterID_GUID', 'FK-ClassID_GUID', 2),
	(NEWID(), 'FK-CharacterID_GUID', 'FK-ClassID_GUID', 3)
END