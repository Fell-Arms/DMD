BEGIN
	DECLARE @DamageType_Id141 uniqueidentifier, @DamageType_Id142 uniqueidentifier, @DamageType_Id143 uniqueidentifier,
			@Weapon_Id141 uniqueidentifier, @Weapon_Id142 uniqueidentifier, @Weapon_Id143 uniqueidentifier;

	SELECT @Weapon_Id141 = Id FROM tblWeapon WHERE Name = 'Steel Sword'
	SELECT @Weapon_Id142 = Id FROM tblWeapon WHERE Name = 'Bone Blade'
	SELECT @Weapon_Id143 = Id FROM tblWeapon WHERE Name = 'Eye of Selune'

	SELECT @DamageType_Id141 = Id FROM tblDamageType WHERE Name = 'Slashing'
	SELECT @DamageType_Id142 = Id FROM tblDamageType WHERE Name = 'Poison'
	SELECT @DamageType_Id143 = Id FROM tblDamageType WHERE Name = 'Thunder'

	INSERT INTO dbo.tblWeaponDamageTypes (Weapon_Id, DamageType_id, DamageDie, DamageModifier, DieCount)
	VALUES
	(@Weapon_Id141, @DamageType_Id141, 1, 3, 2),
	(@Weapon_Id142, @DamageType_Id142, 2, 6, 4),
	(@Weapon_Id143, @DamageType_Id143, 3, 9, 6)
END