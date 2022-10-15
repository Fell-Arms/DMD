BEGIN
	INSERT INTO dbo.tblCharacterAttacks (Id, Character_Id, Attack_Id, CurrentUses)
	VALUES
	(NEWID(), 'FK-CharacterID_GUID', 'FK-AttackID_GUID', 2),
	(NEWID(), 'FK-CharacterID_GUID', 'FK-AttackID_GUID', 5),
	(NEWID(), 'FK-CharacterID_GUID', 'FK-AttackID_GUID', 3)
END