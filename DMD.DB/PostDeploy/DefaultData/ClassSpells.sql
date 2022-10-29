BEGIN
	DECLARE @Spell_Id71 uniqueidentifier, @Spell_Id72 uniqueidentifier, @Spell_Id73 uniqueidentifier,
			@Class_Id71 uniqueidentifier, @Class_Id72 uniqueidentifier, @Class_Id73 uniqueidentifier;

	SELECT @Spell_Id71 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id72 = Id FROM tblSpell WHERE Name = 'Summon Undead'
	SELECT @Spell_Id73 = Id FROM tblSpell WHERE Name = 'Fireball'

	SELECT @Class_Id71 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id72 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id73 = Id FROM tblClass WHERE Name = 'Ranger'

	INSERT INTO dbo.tblClassSpells (Id, Spell_Id, Class_Id)
	VALUES
	(NEWID(), @Spell_Id71, @Class_Id71),
	(NEWID(), @Spell_Id72, @Class_Id72),
	(NEWID(), @Spell_Id73, @Class_Id73)
END