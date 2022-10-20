BEGIN
	DECLARE @Class_Id1 uniqueindentifier, @Class_Id2 uniqueindentifier, @Class_Id3 uniqueindentifier;

	SELECT @Class_Id1 = Id FROM tblClass WHERE Name = 'Ranger'
	SELECT @Class_Id2 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id3 = Id FROM tblClass WHERE Name = 'Warlock'

	INSERT INTO dbo.tblSpellChargesByLevel (Id, Class_Id, Class_Level, Spell_Charge_Level, ChargesMax)
	VALUES
	(NEWID(), @Class_Id1, 2, 3, 1),
	(NEWID(), @Class_Id2, 6, 6, 7),
	(NEWID(), @Class_Id3, 12, 9, 10)
END