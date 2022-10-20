BEGIN
	DECLARE @Armor_Id1 uniqueindentifier, @Armor_Id2 uniqueindentifier, @Armor_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Armor_Id1 = Id FROM tblArmor WHERE Cost = 20
	SELECT @Armor_Id2 = Id FROM tblArmor WHERE Cost = 50
	SELECT @Armor_Id3 = Id FROM tblArmor WHERE Cost = 100

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterArmor (Id, Armor_Id, Character_Id, Equipped)
	VALUES
	(NEWID(), @Armor_Id1, @Character_Id1, 0),
	(NEWID(), @Armor_Id2, @Character_Id2, 0),
	(NEWID(), @Armor_Id3, @Character_Id3, 1)
END