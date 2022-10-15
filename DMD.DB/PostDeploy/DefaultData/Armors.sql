BEGIN
	INSERT INTO dbo.tblArmor (Id, ArmorStyle_Id, ArmorType_Id, ArmorClassBonus, MovementPenalty, Cost)
	VALUES
	(NEWID(), 'FK-ArmorStyle_GUID', 'FK-ArmorType_GUID', 5, 2, 20),
	(NEWID(), 'FK-ArmorStyle_GUID', 'FK-ArmorType_GUID', 7, 5, 50),
	(NEWID(), 'FK-ArmorStyle_GUID', 'FK-ArmorType_GUID', 10, 8, 100)
END