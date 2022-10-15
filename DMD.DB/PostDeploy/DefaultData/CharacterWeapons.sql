BEGIN
	INSERT INTO dbo.tblCharacterWeapons (Id, Weapon_Id, Character_Id, Equipped)
	VALUES
	(NEWID(), 'FK-WeaponID-GUID', 'FK-CharacterID-GUID', 1),
	(NEWID(), 'FK-WeaponID-GUID', 'FK-CharacterID-GUID', 0),
	(NEWID(), 'FK-WeaponID-GUID', 'FK-CharacterID-GUID', 1)
END