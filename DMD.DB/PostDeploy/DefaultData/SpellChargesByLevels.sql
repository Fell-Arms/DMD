BEGIN
	DECLARE @Class_Id91 uniqueidentifier, @Class_Id92 uniqueidentifier, @Class_Id93 uniqueidentifier;

	SELECT @Class_Id91 = Id FROM tblClass WHERE Name = 'Ranger'
	SELECT @Class_Id92 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id93 = Id FROM tblClass WHERE Name = 'Warlock'

	INSERT INTO dbo.tblSpellChargesByLevel (Id, Class_Id, Class_Level, Spell_Charge_Level, ChargesMax)
	VALUES
	(NEWID(), @Class_Id91, 2, 3, 1),
	(NEWID(), @Class_Id92, 6, 6, 7),
	(NEWID(), @Class_Id93, 12, 9, 10)
END