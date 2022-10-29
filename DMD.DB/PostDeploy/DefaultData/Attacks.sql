BEGIN
	DECLARE @Class_Id41 uniqueidentifier, @Class_Id42 uniqueidentifier, @Class_Id43 uniqueidentifier,
			@Stat_Id41 uniqueidentifier, @Stat_Id42 uniqueidentifier, @Stat_Id43 uniqueidentifier,
			@WeaponType_Id41 uniqueidentifier, @WeaponType_Id42 uniqueidentifier, @WeaponType_Id43 uniqueidentifier;

	SELECT @Class_Id41 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id42 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id43 = Id FROM tblClass WHERE Name = 'Ranger'
	
	SELECT @Stat_Id41 = Id FROM tblStat WHERE Name = 'Strength'
	SELECT @Stat_Id42 = Id FROM tblStat WHERE Name = 'Wisdom'
	SELECT @Stat_Id43 = Id FROM tblStat WHERE Name = 'Dexterity'

	SELECT @WeaponType_Id41 = Id FROM tblWeaponType WHERE Type = 'Sword'
	SELECT @WeaponType_Id42 = Id FROM tblWeaponType WHERE Type = 'Staff'
	SELECT @WeaponType_Id43 = Id FROM tblWeaponType WHERE Type = 'Dagger'

	INSERT INTO dbo.tblAttack (Id, Class_Id, Stat_Id, WeaponType_Id, Name, Description, Targets, MaxUses, UseWeapon, Class_Level)
	VALUES
	(NEWID(), @Class_Id41, @Stat_Id41, @WeaponType_Id41, 'Slash', 'Swing your blade at a group of foes', 3, 4, 1, 5),
	(NEWID(), @Class_Id42, @Stat_Id42, @WeaponType_Id42, 'Throw Pebble', 'Whip a pebble at your enemy', 1, 10, 0, 2),
	(NEWID(), @Class_Id43, @Stat_Id43, @WeaponType_Id43, 'Attack', 'Default attack', 1, 999999999, 1, 1)
END