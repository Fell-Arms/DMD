BEGIN
	DECLARE @Armor_Id1 uniqueidentifier, @Armor_Id2 uniqueidentifier, @Armor_Id3 uniqueidentifier,
			@Character_Id1 uniqueidentifier, @Character_Id2 uniqueidentifier, @Character_Id3 uniqueidentifier;

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