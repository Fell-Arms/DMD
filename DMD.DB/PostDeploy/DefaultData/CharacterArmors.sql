BEGIN
	DECLARE @Armor_Id191 uniqueidentifier, @Armor_Id192 uniqueidentifier, @Armor_Id193 uniqueidentifier,
			@Character_Id191 uniqueidentifier, @Character_Id192 uniqueidentifier, @Character_Id193 uniqueidentifier;

	SELECT @Armor_Id191 = Id FROM tblArmor WHERE Cost = 20
	SELECT @Armor_Id192 = Id FROM tblArmor WHERE Cost = 50
	SELECT @Armor_Id193 = Id FROM tblArmor WHERE Cost = 100

	SELECT @Character_Id191 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id192 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id193 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterArmor (Id, Armor_Id, Character_Id, Equipped)
	VALUES
	(NEWID(), @Armor_Id191, @Character_Id191, 0),
	(NEWID(), @Armor_Id192, @Character_Id192, 0),
	(NEWID(), @Armor_Id193, @Character_Id193, 1)
END