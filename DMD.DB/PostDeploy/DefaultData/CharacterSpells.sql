BEGIN
	DECLARE @Spell_Id1 uniqueindentifier, @Spell_Id2 uniqueindentifier, @Spell_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Spell_Id1 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id2 = Id FROM tblSpell WHERE Name = 'Fireball'
	SELECT @Spell_Id3 = Id FROM tblSpell WHERE Name = 'Summon Undead'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterSpells (Id, Character_Id, Spell_Id)
	VALUES
	(NEWID(), @Character_Id1, @Spell_Id1),
	(NEWID(), @Character_Id2, @Spell_Id2),
	(NEWID(), @Character_Id3, @Spell_Id3)
END