BEGIN
	DECLARE @Currency_Id171 uniqueidentifier, @Currency_Id172 uniqueidentifier, @Currency_Id173 uniqueidentifier,
			@Character_Id171 uniqueidentifier, @Character_Id172 uniqueidentifier, @Character_Id173 uniqueidentifier;

	SELECT @Currency_Id171 = Id FROM tblCurrency WHERE Name = 'Copper'
	SELECT @Currency_Id172 = Id FROM tblCurrency WHERE Name = 'Silver'
	SELECT @Currency_Id173 = Id FROM tblCurrency WHERE Name = 'Gold'

	SELECT @Character_Id171 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id172 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id173 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterCurrency (Id, Currency_Id, Character_Id, Amount)
	VALUES
	(NEWID(), @Currency_Id171, @Character_Id171, 20),
	(NEWID(), @Currency_Id172, @Character_Id172, 50),
	(NEWID(), @Currency_Id173, @Character_Id173, 300)
END