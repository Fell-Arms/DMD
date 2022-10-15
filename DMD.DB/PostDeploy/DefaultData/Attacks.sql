BEGIN
	INSERT INTO dbo.tblAttack (Id, Class_Id, Stat_Id, WeaponType_Id, Name, Description, Targets, MaxUses, UseWeapon, Class_Level)
	VALUES
	(NEWID(), 'FK-ClassID-GUID', 'FK-StatID_GUID', 'FK-WeaponTypeID_GUID', 'Slash', 'Swing your blade at a group of foes', 3, 4, 1, 5),
	(NEWID(), 'FK-ClassID-GUID', 'FK-StatID_GUID', 'FK-WeaponTypeID_GUID', 'Throw Pebble', 'Whip a pebble at your enemy', 1, 10, 0, 2),
	(NEWID(), 'FK-ClassID_GUID', 'FK-StatID_GUID', 'FK-WeaponTypeID_GUID', 'Shield Bash', 'Hit your enemy with your shield', 5, 2, 1, 8)
END