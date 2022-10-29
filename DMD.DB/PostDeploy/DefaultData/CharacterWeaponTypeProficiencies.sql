BEGIN
	DECLARE @WeaponType_Id151 uniqueidentifier, @WeaponType_Id152 uniqueidentifier, @WeaponType_Id153 uniqueidentifier,
			@Character_Id151 uniqueidentifier, @Character_Id152 uniqueidentifier, @Character_Id153 uniqueidentifier;

	SELECT @WeaponType_Id151 = Id FROM tblWeaponType WHERE Type = 'Sword'
	SELECT @WeaponType_Id152 = Id FROM tblWeaponType WHERE Type = 'Dagger'
	SELECT @WeaponType_Id153 = Id FROM tblWeaponType WHERE Type = 'Staff'

	SELECT @Character_Id151 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id152 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id153 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterWeaponTypeProficiency (Id, WeaponType_Id, Character_Id)
	VALUES
	(NEWID(), @WeaponType_Id151, @Character_Id151),
	(NEWID(), @WeaponType_Id152, @Character_Id152),
	(NEWID(), @WeaponType_Id153, @Character_Id153)
END