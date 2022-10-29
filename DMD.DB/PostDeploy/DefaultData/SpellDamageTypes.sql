BEGIN
	DECLARE @Spell_Id1 uniqueidentifier, @Spell_Id2 uniqueidentifier, @Spell_Id3 uniqueidentifier,
			@DamageType_Id1 uniqueidentifier, @DamageType_Id2 uniqueidentifier, @DamageType_Id3 uniqueidentifier;

	SELECT @Spell_Id1 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id2 = Id FROM tblSpell WHERE Name = 'Fireball'
	SELECT @Spell_Id3 = Id FROM tblSpell WHERE Name = 'Summon Undead'

	SELECT @DamageType_Id1 = Id FROM tblDamageType WHERE Name = 'Fire'
	SELECT @DamageType_Id2 = Id FROM tblDamageType WHERE Name = 'Force'
	SELECT @DamageType_Id3 = Id FROM tblDamageType WHERE Name = 'Radiant'

	INSERT INTO dbo.tblSpellDamageTypes (Spell_Id, DamageType_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	(@Spell_Id1, @DamageType_Id1, 1, 5, 3),
	(@Spell_Id2, @DamageType_Id2, 2, 2, 2),
	(@Spell_Id3, @DamageType_Id3 ,3, 4, 1)
END