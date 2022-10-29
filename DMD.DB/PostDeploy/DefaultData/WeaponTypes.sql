BEGIN
	INSERT INTO dbo.tblWeaponType (Id, Type, Description)
	VALUES
	(NEWID(), 'Sword', 'A simple steel blade.'),
	(NEWID(), 'Staff', 'A staff for magic users.'),
	(NEWID(), 'Dagger', 'A small pointy blade.')
END