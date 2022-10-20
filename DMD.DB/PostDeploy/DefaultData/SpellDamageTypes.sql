BEGIN
	DECLARE @Spell_Id1 uniqueindentifier, @Spell_Id2 uniqueindentifier, @Spell_Id3 uniqueindentifier;

	SELECT @Spell_Id1 = Id FROM tblSpell WHERE Name = 'Healing Aura'
	SELECT @Spell_Id2 = Id FROM tblSpell WHERE Name = 'Fireball'
	SELECT @Spell_Id3 = Id FROM tblSpell WHERE Name = 'Summon Undead'

	INSERT INTO dbo.tblSpellDamageTypes (DamageType_Id, Spell_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	(NEWID(), @Spell_Id3, 1, 5, 3),
	(NEWID(), @Spell_Id2, 2, 2, 2),
	(NEWID(), @Spell_Id1, 3, 4, 1)
END