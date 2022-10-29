BEGIN
	DECLARE @Stat_Id111 uniqueidentifier, @Stat_Id112 uniqueidentifier, @Stat_Id113 uniqueidentifier,
			@WeaponType_Id111 uniqueidentifier, @WeaponType_Id112 uniqueidentifier, @WeaponType_Id113 uniqueidentifier;

	SELECT @Stat_Id111 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id112 = Id FROM tblStat WHERE Name = 'Intelligence'
	SELECT @Stat_Id113 = Id FROM tblStat WHERE Name = 'Dexterity'

	SELECT @WeaponType_Id111 = Id FROM tblWeaponType WHERE Type = 'Sword'
	SELECT @WeaponType_Id112 = Id FROM tblWeaponType WHERE Type = 'Staff'
	SELECT @WeaponType_Id113 = Id FROM tblWeaponType WHERE Type = 'Dagger'

	INSERT INTO dbo.tblWeapon (Id, WeaponType_Id, Stats_Id, Name, Cost)
	VALUES
	(NEWID(), @WeaponType_Id111, @Stat_Id111, 'Steel Sword', 250),
	(NEWID(), @WeaponType_Id112, @Stat_Id112, 'Bone Blade', 50),
	(NEWID(), @WeaponType_Id113, @Stat_Id113, 'Eye of Selune', 10000)
END