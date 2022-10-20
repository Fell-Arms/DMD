BEGIN
	DECLARE @Class_Id1 uniqueindentifier, @Class_Id2 uniqueindentifier, @Class_Id3 uniqueindentifier,
			@Stat_Id1 uniqueindentifier, @Stat_Id2 uniqueindentifier, @Stat_Id3 uniqueindentifier,
			@WeaponType_Id1 uniqueindentifier, @WeaponType_Id2 uniqueindentifier, @WeaponType_Id3 uniqueindentifier;

	SELECT @Class_Id1 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id2 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id3 = Id FROM tblClass WHERE Name = 'Ranger'
	
	SELECT @Stat_Id1 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id2 = Id FROM tblStat WHERE Name = 'Wisdom'
	SELECT @Stat_Id3 = Id FROM tblStat WHERE Name = 'Dexterity'

	SELECT @WeaponType_Id1 = Id FROM tblWeaponType WHERE Type = 'Shortsword'
	SELECT @WeaponType_Id2 = Id FROM tblWeaponType WHERE Type = 'Staff'
	SELECT @WeaponType_Id3 = Id FROM tblWeaponType WHERE Type = 'Dagger'

	INSERT INTO dbo.tblAttack (Id, Class_Id, Stat_Id, WeaponType_Id, Name, Description, Targets, MaxUses, UseWeapon, Class_Level)
	VALUES
	(NEWID(), @Class_Id1, @Stat_Id1, @WeaponType_Id1, 'Slash', 'Swing your blade at a group of foes', 3, 4, 1, 5),
	(NEWID(), @Class_Id2, @Stat_Id2, @WeaponType_Id2, 'Throw Pebble', 'Whip a pebble at your enemy', 1, 10, 0, 2),
	(NEWID(), @Class_Id3, @Stat_Id3, @WeaponType_Id3, 'Attack', 'Default attack', 1, 999999999, 1, 1)
END