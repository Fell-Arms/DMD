BEGIN
	DECLARE @Weapon_Id1 uniqueindentifier, @Weapon_Id2 uniqueindentifier, @Weapon_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Weapon_Id1 = Id FROM tblWeapon WHERE Name = 'Steel Hammer'
	SELECT @Weapon_Id2 = Id FROM tblWeapon WHERE Name = 'Oak Bow'
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