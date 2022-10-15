BEGIN
	INSERT INTO dbo.tblCharacterWeaponTypeProficiency (Id, WeaponType_Id, Character_Id)
	VALUES
	(NEWID(), 'FK-WeaponTypeID-GUID', 'FK-CharacterID-GUID'),
	(NEWID(), 'FK-WeaponTypeID-GUID', 'FK-CharacterID-GUID'),
	(NEWID(), 'FK-WeaponTypeID-GUID', 'FK-CharacterID-GUID')
END