BEGIN
	DECLARE @Skill_Id21 uniqueidentifier, @Skill_Id22 uniqueidentifier, @Skill_Id23 uniqueidentifier,
			@Character_Id21 uniqueidentifier, @Character_Id22 uniqueidentifier, @Character_Id23 uniqueidentifier;

	SELECT @Skill_Id21 = Id FROM tblSkill WHERE Name = 'Religion'
	SELECT @Skill_Id22 = Id FROM tblSkill WHERE Name = 'Stealth'
	SELECT @Skill_Id23 = Id FROM tblSkill WHERE Name = 'Arcana'

	SELECT @Character_Id21 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id22 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id23 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterSkillProficiency ( Character_Id, Skill_Id, ValidRow)
	VALUES
	(@Character_Id21, @Skill_Id21, 0),
	(@Character_Id22, @Skill_Id22, 0),
	(@Character_Id23, @Skill_Id23, 0)
END