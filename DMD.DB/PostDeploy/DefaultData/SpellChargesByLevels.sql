BEGIN
	INSERT INTO dbo.tblSpellChargesByLevel (Id, Class_Id, Class_Level, Spell_Charge_Level, ChargesMax)
	VALUES
	(NEWID(), 'FK-ClassID-GUID', 2, 3, 1),
	(NEWID(), 'FK-ClassID-GUID', 6, 6, 7),
	(NEWID(), 'FK-ClassID-GUID', 12, 9, 10)
END