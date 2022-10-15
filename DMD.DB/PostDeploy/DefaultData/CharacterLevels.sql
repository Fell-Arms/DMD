BEGIN
	INSERT INTO dbo.tblCharacterLevel (Id, Level, Experience, ProficencyBonus)
	VALUES
	(NEWID(), 1, 15, 1),
	(NEWID(), 2, 50, 2),
	(NEWID(), 3, 200, 3)
END