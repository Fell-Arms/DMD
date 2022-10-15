BEGIN
	INSERT INTO dbo.tblWeaponType (Id, Type, Description)
	VALUES
	(NEWID(), 'Bow', 'A simple bow and quiver.'),
	(NEWID(), 'Staff', 'A staff for magic users.'),
	(NEWID(), 'Shield', 'A mighty sheild to block and bash.')
END