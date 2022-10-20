BEGIN
	DECLARE @Stat_Id1 uniqueindentifier, @Stat_Id2 uniqueindentifier, @Stat_Id3 uniqueindentifier,
			@Weapon_Id1 uniqueindentifier, @Weapon_Id2 uniqueindentifier, @Weapon_Id3 uniqueindentifier;

	SELECT @Stat_Id1 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id2 = Id FROM tblStat WHERE Name = 'Intelligence'
	SELECT @Stat_Id3 = Id FROM tblStat WHERE Name = 'Dexterity'

	SELECT @WeaponType_Id1 = Id FROM tblWeaponType WHERE Type = 'Sword'
	SELECT @WeaponType_Id2 = Id FROM tblWeaponType WHERE Type = 'Staff'
	SELECT @WeaponType_Id3 = Id FROM tblWeaponType WHERE Type = 'Dagger'

	INSERT INTO dbo.tblWeapon (Id, WeaponType_Id, Stats_Id, Name, Cost)
	VALUES
	(NEWID(), @WeaponType_Id1, @Stat_Id1, 'Steel Hammer', 250),
	(NEWID(), @WeaponType_Id3, @Stat_Id3, 'Oak Bow', 50),
	(NEWID(), @WeaponType_Id2, @Stat_Id2, 'Eye of Selune', 10000)
END