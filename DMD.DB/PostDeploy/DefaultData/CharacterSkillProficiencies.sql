BEGIN
	INSERT INTO dbo.tblCharacterSkillProficiency (Id, Skill_Id, Character_Id)
	VALUES
	(NEWID(), 'FK-SkillID-GUID', 'FK-CharacterID-GUID'),
	(NEWID(), 'FK-SkillID-GUID', 'FK-CharacterID-GUID'),
	(NEWID(), 'FK-SkillID-GUID', 'FK-CharacterID-GUID')
END