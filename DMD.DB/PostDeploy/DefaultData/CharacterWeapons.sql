BEGIN
	DECLARE @Weapon_Id1 uniqueidentifier, @Weapon_Id2 uniqueidentifier, @Weapon_Id3 uniqueidentifier,
			@Character_Id1 uniqueidentifier, @Character_Id2 uniqueidentifier, @Character_Id3 uniqueidentifier;

	SELECT @Weapon_Id1 = Id FROM tblWeapon WHERE Name = 'Steel Sword'
	SELECT @Weapon_Id2 = Id FROM tblWeapon WHERE Name = 'Bone Blade'
	SELECT @Weapon_Id3 = Id FROM tblWeapon WHERE Name = 'Eye of Selune'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterWeapons (Id, Weapon_Id, Character_Id, Equipped)
	VALUES
	(NEWID(), @Weapon_Id1, @Character_Id1, 1),
	(NEWID(), @Weapon_Id2, @Character_Id2, 0),
	(NEWID(), @Weapon_Id3, @Character_Id3, 1)
END