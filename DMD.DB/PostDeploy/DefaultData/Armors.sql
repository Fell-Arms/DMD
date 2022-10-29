BEGIN
	DECLARE @ArmorStyle_Id1 uniqueidentifier, @ArmorStyle_Id2 uniqueidentifier, @ArmorStyle_Id3 uniqueidentifier,
			@ArmorType_Id1 uniqueidentifier, @ArmorType_Id2 uniqueidentifier;

	SELECT @ArmorStyle_Id1 = Id FROM tblArmorStyle WHERE StyleName = 'Light'
	SELECT @ArmorStyle_Id2 = Id FROM tblArmorStyle WHERE StyleName = 'Medium'
	SELECT @ArmorStyle_Id3 = Id FROM tblArmorStyle WHERE StyleName = 'Heavy'

	SELECT @ArmorType_Id1 = Id FROM tblArmorType WHERE TypeName = 'Body Armor'
	SELECT @ArmorType_Id2 = Id FROM tblArmorType WHERE TypeName = 'Shield'

	INSERT INTO dbo.tblArmor (Id, ArmorStyle_Id, ArmorType_Id, ArmorClassBonus, MovementPenalty, Cost)
	VALUES
	(NEWID(), @ArmorStyle_Id1, @ArmorType_Id1, 5, 2, 20),
	(NEWID(), @ArmorStyle_Id2, @ArmorType_Id2, 7, 5, 50),
	(NEWID(), @ArmorStyle_Id3, @ArmorType_Id1, 10, 8, 100)
END