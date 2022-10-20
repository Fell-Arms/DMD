BEGIN
	DECLARE @Class_Id1 uniqueindentifier, @Class_Id2 uniqueindentifier, @Class_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Class_Id1 = Id FROM tblClass WHERE Name = 'Paladin'
	SELECT @Class_Id2 = Id FROM tblClass WHERE Name = 'Warlock'
	SELECT @Class_Id3 = Id FROM tblClass WHERE Name = 'Ranger'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterClasses(Id, Character_Id, Class_Id, Class_Level)
	VALUES
	(NEWID(), @Character_Id1, @Class_Id1, 1),
	(NEWID(), @Character_Id2, @Class_Id2, 2),
	(NEWID(), @Character_Id3, @Class_Id3, 3)
END