BEGIN
	DECLARE @Stat_Id1 uniqueidentifier, @Stat_Id2 uniqueidentifier, @Stat_Id3 uniqueidentifier,
			@Weapon_Id1 uniqueidentifier, @Weapon_Id2 uniqueidentifier, @Weapon_Id3 uniqueidentifier;

	SELECT @Stat_Id1 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id2 = Id FROM tblStat WHERE Name = 'Intelligence'
	SELECT @Stat_Id3 = Id FROM tblStat WHERE Name = 'Dexterity'

	SELECT @WeaponType_Id1 = Id FROM tblWeaponType WHERE Type = 'Sword'
	SELECT @WeaponType_Id2 = Id FROM tblWeaponType WHERE Type = 'Staff'
	SELECT @WeaponType_Id3 = Id FROM tblWeaponType WHERE Type = 'Dagger'

	INSERT INTO dbo.tblWeapon (Id, WeaponType_Id, Stats_Id, Name, Cost)
	VALUES
	(NEWID(), @WeaponType_Id1, @Stat_Id1, 'Steel Sword', 250),
	(NEWID(), @WeaponType_Id3, @Stat_Id3, 'Bone Blade', 50),
	(NEWID(), @WeaponType_Id2, @Stat_Id2, 'Eye of Selune', 10000)
END