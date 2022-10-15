BEGIN
	INSERT INTO dbo.tblCharacterSpells (Id, Character_Id, Spell_Id)
	VALUES
	(NEWID(), 'FK-CharacterID-GUID', 'FK-SpellID-GUID'),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-SpellID-GUID'),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-SpellID-GUID')
END