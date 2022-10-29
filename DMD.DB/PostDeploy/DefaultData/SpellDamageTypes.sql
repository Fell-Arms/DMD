BEGIN
	DECLARE @Spell_Id121 uniqueidentifier, @Spell_Id122 uniqueidentifier, @Spell_Id123 uniqueidentifier,
			@DamageType_Id121 uniqueidentifier, @DamageType_Id122 uniqueidentifier, @DamageType_Id123 uniqueidentifier;

	SELECT @Spell_Id121 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id122 = Id FROM tblSpell WHERE Name = 'Fireball'
	SELECT @Spell_Id123 = Id FROM tblSpell WHERE Name = 'Summon Undead'

	SELECT @DamageType_Id121 = Id FROM tblDamageType WHERE Name = 'Fire'
	SELECT @DamageType_Id122 = Id FROM tblDamageType WHERE Name = 'Force'
	SELECT @DamageType_Id123 = Id FROM tblDamageType WHERE Name = 'Radiant'

	INSERT INTO dbo.tblSpellDamageTypes (Spell_Id, DamageType_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	(@Spell_Id121, @DamageType_Id121, 1, 5, 3),
	(@Spell_Id122, @DamageType_Id122, 2, 2, 2),
	(@Spell_Id123, @DamageType_Id123 ,3, 4, 1)
END