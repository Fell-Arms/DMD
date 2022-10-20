BEGIN
	DECLARE @Language_Id1 uniqueindentifier, @Language_Id2 uniqueindentifier, @Language_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Language_Id1 = Id FROM tblLanguage WHERE Name = 'Dwarvish'
	SELECT @Language_Id2 = Id FROM tblLanguage WHERE Name = 'Gnomish'
	SELECT @Language_Id3 = Id FROM tblLanguage WHERE Name = 'Common'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterLanguages (Id, Character_Id, Language_Id)
	VALUES
	(NEWID(), @Character_Id1, @Language_Id1),
	(NEWID(), @Character_Id2, @Language_Id2),
	(NEWID(), @Character_Id3, @Language_Id3)
END