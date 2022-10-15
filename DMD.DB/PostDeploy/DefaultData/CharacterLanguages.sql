BEGIN
	INSERT INTO dbo.tblCharacterLanguages (Id, Character_Id, Language_Id)
	VALUES
	(NEWID(), 'FK-CharacterID-GUID', 'FK-LanguageID-GUID'),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-LanguageID-GUID'),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-LanguageID-GUID')
END