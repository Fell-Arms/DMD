BEGIN
	DECLARE @Spell_Id81 uniqueidentifier, @Spell_Id82 uniqueidentifier, @Spell_Id83 uniqueidentifier,
			@Class_Id81 uniqueidentifier, @Class_Id82 uniqueidentifier, @Class_Id83 uniqueidentifier,
			@Class_Spells_Id81 uniqueidentifier, @Class_Spells_Id82 uniqueidentifier, @Class_Spells_Id83 uniqueidentifier,
			@Character_Id81 uniqueidentifier, @Character_Id82 uniqueidentifier, @Character_Id83 uniqueidentifier;

	SELECT @Spell_Id81 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id82 = Id FROM tblSpell WHERE Name = 'Summon Undead'
	SELECT @Spell_Id83 = Id FROM tblSpell WHERE Name = 'Fireball'

	SELECT @Class_Id81 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id82 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id83 = Id FROM tblClass WHERE Name = 'Ranger'

	SELECT @Class_Spells_Id81 = Id FROM tblClassSpells WHERE Spell_Id = @Spell_Id81 AND Class_Id = @Class_Id81
	SELECT @Class_Spells_Id82 = Id FROM tblClassSpells WHERE Spell_Id = @Spell_Id82 AND Class_Id = @Class_Id82
	SELECT @Class_Spells_Id83 = Id FROM tblClassSpells WHERE Spell_Id = @Spell_Id83 AND Class_Id = @Class_Id83

	SELECT @Character_Id81 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id82 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id83 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterClassSpells (Id, Character_Id, ClassSpells_Id)
	VALUES
	(NEWID(), @Character_Id81, @Class_Spells_Id81),
	(NEWID(), @Character_Id82, @Class_Spells_Id82),
	(NEWID(), @Character_Id83, @Class_Spells_Id83)
END