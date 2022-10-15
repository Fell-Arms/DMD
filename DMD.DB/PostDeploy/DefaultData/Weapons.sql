BEGIN
	INSERT INTO dbo.tblWeapon (Id, WeaponType_Id, Stats_Id, Name, Cost)
	VALUES
	(NEWID(), 'FK-WeaponTypeID-GUID', 'FK-StatsID-GUID', 'Steel Hammer', 250),
	(NEWID(), 'FK-WeaponTypeID-GUID', 'FK-StatsID-GUID', 'Oak Bow', 50),
	(NEWID(), 'FK-WeaponTypeID-GUID', 'FK-StatsID-GUID', 'Eye of Selune', 10000)
END