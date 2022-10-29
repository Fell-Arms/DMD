BEGIN
	DECLARE @WeaponType_Id1 uniqueidentifier, @WeaponType_Id2 uniqueidentifier, @WeaponType_Id3 uniqueidentifier,
			@Character_Id1 uniqueidentifier, @Character_Id2 uniqueidentifier, @Character_Id3 uniqueidentifier;

	SELECT @WeaponType_Id1 = Id FROM tblWeaponType WHERE Type = 'Sword'
	SELECT @WeaponType_Id2 = Id FROM tblWeaponType WHERE Type = 'Dagger'
	SELECT @WeaponType_Id3 = Id FROM tblWeaponType WHERE Type = 'Staff'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterWeaponTypeProficiency (Id, WeaponType_Id, Character_Id)
	VALUES
	(NEWID(), @WeaponType_Id1, @Character_Id1),
	(NEWID(), @WeaponType_Id2, @Character_Id2),
	(NEWID(), @WeaponType_Id3, @Character_Id3)
END