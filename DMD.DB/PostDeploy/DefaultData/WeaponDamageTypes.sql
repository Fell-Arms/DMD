BEGIN
	INSERT INTO dbo.tblWeaponDamageTypes (Weapon_Id, DamageType_id, DamageDie, DamageModifier, DieCount)
	VALUES
	(NEWID(), 'FK-DamageTypeID-GUID', 'FK-ArmorType_GUID', 1, 3, 2),
	(NEWID(), 'FK-DamageTypeID-GUID', 'FK-ArmorType_GUID', 2, 6, 4),
	(NEWID(), 'FK-DamageTypeID-GUID', 'FK-ArmorType_GUID', 3, 9, 6)
END