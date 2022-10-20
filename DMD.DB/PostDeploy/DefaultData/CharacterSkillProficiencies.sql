BEGIN
	DECLARE @Skill_Id1 uniqueindentifier, @Skill_Id2 uniqueindentifier, @Skill_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Skill_Id1 = Id FROM tblSkill WHERE Name = 'Religion'
	SELECT @Skill_Id2 = Id FROM tblSkill WHERE Name = 'Stealth'
	SELECT @Skill_Id3 = Id FROM tblSkill WHERE Name = 'Arcana'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterSkillProficiency (Id, Skill_Id, Character_Id)
	VALUES
	(NEWID(), @Skill_Id1, @Character_Id1),
	(NEWID(), @Skill_Id2, @Character_Id2),
	(NEWID(), @Skill_Id3, @Character_Id3)
END