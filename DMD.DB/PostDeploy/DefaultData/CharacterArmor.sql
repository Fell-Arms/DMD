BEGIN
	INSERT INTO dbo.tblCharacterArmor (Id, Armor_Id, Character_Id, Equipped)
	VALUES
	(NEWID(), 'FK-ArmorID_GUID', 'FK-CharacterID_GUID', 0),
	(NEWID(), 'FK-ArmorID_GUID', 'FK-CharacterID_GUID', 1),
	(NEWID(), 'FK-ArmorID_GUID', 'FK-CharacterID_GUID', 1)
END