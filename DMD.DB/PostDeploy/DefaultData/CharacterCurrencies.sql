BEGIN
	INSERT INTO dbo.tblCharacterCurrency (Id, Curreny_Id, Character_Id, Amount)
	VALUES
	(NEWID(), 'FK-CurrencyID-GUID', 'FK-CharacterID-GUID', 20),
	(NEWID(), 'FK-CurrencyID-GUID', 'FK-CharacterID-GUID', 50),
	(NEWID(), 'FK-CurrencyID-GUID', 'FK-CharacterID-GUID', 300)
END