BEGIN
	DECLARE @Currency_Id1 uniqueidentifier, @Currency_Id2 uniqueidentifier, @Currency_Id3 uniqueidentifier,
			@Character_Id1 uniqueidentifier, @Character_Id2 uniqueidentifier, @Character_Id3 uniqueidentifier;

	SELECT @Currency_Id1 = Id FROM tblCurrency WHERE Name = 'Copper'
	SELECT @Currency_Id2 = Id FROM tblCurrency WHERE Name = 'Silver'
	SELECT @Currency_Id3 = Id FROM tblCurrency WHERE Name = 'Gold'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterCurrency (Id, Curreny_Id, Character_Id, Amount)
	VALUES
	(NEWID(), @Currency_Id1, @Character_Id1, 20),
	(NEWID(), @Currency_Id2, @Character_Id2, 50),
	(NEWID(), @Currency_Id3, @Character_Id3, 300)
END