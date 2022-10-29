BEGIN
	DECLARE @SpellChargesByLevel_Id101 uniqueidentifier, @SpellChargesByLevel_Id102 uniqueidentifier, @SpellChargesByLevel_Id103 uniqueidentifier,
			@Character_Id101 uniqueidentifier, @Character_Id102 uniqueidentifier, @Character_Id103 uniqueidentifier;

	SELECT @SpellChargesByLevel_Id101 = Id FROM tblSpellChargesByLevel WHERE Class_Level = 2
	SELECT @SpellChargesByLevel_Id102 = Id FROM tblSpellChargesByLevel WHERE Class_Level = 6
	SELECT @SpellChargesByLevel_Id103 = Id FROM tblSpellChargesByLevel WHERE Class_Level = 12

	SELECT @Character_Id101 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id102 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id103 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterSpellCharges (Id, Character_Id, Spell_Charges_By_Level_Id, ChargesAvaliable)
	VALUES
	(NEWID(), @Character_Id101, @SpellChargesByLevel_Id101, 3),
	(NEWID(), @Character_Id102, @SpellChargesByLevel_Id102, 5),
	(NEWID(), @Character_Id103, @SpellChargesByLevel_Id103, 7)
END