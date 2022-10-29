BEGIN
	DECLARE @Weapon_Id161 uniqueidentifier, @Weapon_Id162 uniqueidentifier, @Weapon_Id163 uniqueidentifier,
			@Character_Id161 uniqueidentifier, @Character_Id162 uniqueidentifier, @Character_Id163 uniqueidentifier;

	SELECT @Weapon_Id161 = Id FROM tblWeapon WHERE Name = 'Steel Sword'
	SELECT @Weapon_Id162 = Id FROM tblWeapon WHERE Name = 'Bone Blade'
	SELECT @Weapon_Id163 = Id FROM tblWeapon WHERE Name = 'Eye of Selune'

	SELECT @Character_Id161 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id162 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id163 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterWeapons (Id, Weapon_Id, Character_Id, Equipped)
	VALUES
	(NEWID(), @Weapon_Id161, @Character_Id161, 1),
	(NEWID(), @Weapon_Id162, @Character_Id162, 0),
	(NEWID(), @Weapon_Id163, @Character_Id163, 1)
END