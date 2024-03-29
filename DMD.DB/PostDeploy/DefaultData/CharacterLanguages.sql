﻿BEGIN
	DECLARE @Language_Id1 uniqueidentifier, @Language_Id2 uniqueidentifier, @Language_Id3 uniqueidentifier,
			@Character_Id1 uniqueidentifier, @Character_Id2 uniqueidentifier, @Character_Id3 uniqueidentifier;

	SELECT @Language_Id1 = Id FROM tblLanguage WHERE Name = 'Dwarvish'
	SELECT @Language_Id2 = Id FROM tblLanguage WHERE Name = 'Gnomish'
	SELECT @Language_Id3 = Id FROM tblLanguage WHERE Name = 'Common'

	SELECT @Character_Id1 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterLanguages(Id, Character_Id, Language_Id)
	VALUES
	(NEWID(), @Character_Id1, @Language_Id1),
	(NEWID(), @Character_Id2, @Language_Id2),
	(NEWID(), @Character_Id3, @Language_Id3)
END