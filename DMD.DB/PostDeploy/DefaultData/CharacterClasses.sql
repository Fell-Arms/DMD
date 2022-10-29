BEGIN
	DECLARE @Class_Id31 uniqueidentifier, @Class_Id32 uniqueidentifier, @Class_Id33 uniqueidentifier,
			@Character_Id31 uniqueidentifier, @Character_Id32 uniqueidentifier, @Character_Id33 uniqueidentifier;

	SELECT @Class_Id31 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id32 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id33 = Id FROM tblClass WHERE Name = 'Ranger'

	SELECT @Character_Id31 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id32 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id33 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterClasses(Id, Character_Id, Class_Id, Class_Level)
	VALUES
	(NEWID(), @Character_Id31, @Class_Id31, 1),
	(NEWID(), @Character_Id32, @Class_Id32, 2),
	(NEWID(), @Character_Id33, @Class_Id33, 3)
END