BEGIN
	DECLARE @Spell_Id1 uniqueindentifier, @Spell_Id2 uniqueindentifier, @Spell_Id3 uniqueindentifier,
			@Class_Id1 uniqueindentifier, @Class_Id2 uniqueindentifier, @Class_Id3 uniqueindentifier;

	SELECT @Spell_Id1 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id2 = Id FROM tblSpell WHERE Name = 'Summon Undead'
	SELECT @Spell_Id3 = Id FROM tblSpell WHERE Name = 'Fireball'

	SELECT @Class_Id1 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id2 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id3 = Id FROM tblClass WHERE Name = 'Ranger'

	INSERT INTO dbo.tblClassSpells (Spell_Id, Class_Id)
	VALUES
	(@Spell_Id1, @Class_Id1),
	(@Spell_Id2, @Class_Id2),
	(@Spell_Id3, @Class_Id3)
END