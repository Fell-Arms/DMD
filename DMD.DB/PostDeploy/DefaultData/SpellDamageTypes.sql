BEGIN
	INSERT INTO dbo.tblSpellDamageTypes (DamageType_Id, Spell_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	(NEWID(), 'FK-SpellID_GUID', 1, 5, 3),
	(NEWID(), 'FK-SpellID_GUID', 2, 2, 2),
	(NEWID(), 'FK-SpellID_GUID', 3, 4, 1)
END