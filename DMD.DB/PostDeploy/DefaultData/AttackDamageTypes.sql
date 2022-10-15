BEGIN
	INSERT INTO dbo.tblAttackDamageTypes (DamageType_Id, Attack_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	('FK-DamageTypeID', 'FK-AttackID-GUID', 4, 4, 3),
	('FK-DamageTypeID', 'FK-AttackID-GUID', 6, 3, 2),
	('FK-DamageTypeID', 'FK-AttackID-GUID', 20, 8, 1)
END