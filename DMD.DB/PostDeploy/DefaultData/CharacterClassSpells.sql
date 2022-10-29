BEGIN
	DECLARE @Spell_Id1 uniqueidentifier, @Spell_Id2 uniqueidentifier, @Spell_Id3 uniqueidentifier,
			@Class_Id1 uniqueidentifier, @Class_Id2 uniqueidentifier, @Class_Id3 uniqueidentifier,
			@Class_Spells_Id1 uniqueidentifier, @Class_Spells_Id2 uniqueidentifier, @Class_Spells3 uniqueidentifier,
			@Character_Id1 uniqueidentifier, @Character_Id2 uniqueidentifier, @Character_Id3 uniqueidentifier;

	SELECT @Spell_Id1 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id2 = Id FROM tblSpell WHERE Name = 'Summon Undead'
	SELECT @Spell_Id3 = Id FROM tblSpell WHERE Name = 'Fireball'

	SELECT @Class_Id1 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id2 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id3 = Id FROM tblClass WHERE Name = 'Ranger'

	SELECT @Class_Spells_Id1 = Id FROM tblClassSpells WHERE Spell_Id = @Spell_Id1 AND Class_Id = @Class_Id1
	SELECT @Class_Spells_Id2 = Id FROM tblClassSpells WHERE Spell_Id = @Spell_Id2 AND Class_Id = @Class_Id2
	SELECT @Class_Spells_Id3 = Id FROM tblClassSpells WHERE Spell_Id = @Spell_Id3 AND Class_Id = @Class_Id3

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterClassSpells (Id, Character_Id, Spell_Id)
	VALUES
	(NEWID(), @Character_Id1, @Class_Spells_Id1),
	(NEWID(), @Character_Id2, @Class_Spells_Id2),
	(NEWID(), @Character_Id3, @Class_Spells3)
END