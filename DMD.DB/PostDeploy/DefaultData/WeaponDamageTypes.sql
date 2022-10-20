BEGIN
	DECLARE @DamageType_Id1 uniqueindentifier, @DamageType_Id2 uniqueindentifier, @DamageType_Id3 uniqueindentifier,
			@Weapon_Id1 uniqueindentifier, @Weapon_Id2 uniqueindentifier, @Weapon_Id3 uniqueindentifier;

	SELECT @Weapon_Id1 = Id FROM tblWeapon WHERE Name = 'Steel Sword'
	SELECT @Weapon_Id2 = Id FROM tblWeapon WHERE Name = 'Bone Blade'
	SELECT @Weapon_Id3 = Id FROM tblWeapon WHERE Name = 'Eye of Selune'

	SELECT @DamageType_Id1 = Id FROM tblDamageType WHERE Name = 'Slashing'
	SELECT @DamageType_Id2 = Id FROM tblDamageType WHERE Name = 'Poison'
	SELECT @DamageType_Id3 = Id FROM tblDamageType WHERE Name = 'Thunder'

	INSERT INTO dbo.tblWeaponDamageTypes (Weapon_Id, DamageType_id, DamageDie, DamageModifier, DieCount)
	VALUES
	(NEWID(), @Weapon_Id1, @DamageType_Id1, 1, 3, 2),
	(NEWID(), @Weapon_Id2, @DamageType_Id2, 2, 6, 4),
	(NEWID(), @Weapon_Id3, @DamageType_Id3, 3, 9, 6)
END