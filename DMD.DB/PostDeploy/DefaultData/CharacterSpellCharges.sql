BEGIN
	DECLARE @SpellChargesByLevel_Id1 uniqueindentifier, @SpellChargesByLevel_Id2 uniqueindentifier, @SpellChargesByLevel_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @SpellChargesByLevel_Id1 = Id FROM tblSpellChargesByLevel WHERE Class_Level = 2
	SELECT @SpellChargesByLevel_Id2 = Id FROM tblSpellChargesByLevel WHERE Class_Level = 6
	SELECT @SpellChargesByLevel_Id3 = Id FROM tblSpellChargesByLevel WHERE Class_Level = 12

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterSpellCharges (Id, Character_Id, Spell_Charges_By_Level_Id, ChargesAvaliable)
	VALUES
	(NEWID(), @Character_Id1, @SpellChargesByLevel_Id1, 3),
	(NEWID(), @Character_Id2, @SpellChargesByLevel_Id2, 5),
	(NEWID(), @Character_Id3, @SpellChargesByLevel_Id3, 7)
END