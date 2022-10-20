BEGIN
	DECLARE @Attack_Id1 uniqueindentifier, @Attack_Id2 uniqueindentifier, @Attack_Id3 uniqueindentifier,
			@Character_Id1 uniqueindentifier, @Character_Id2 uniqueindentifier, @Character_Id3 uniqueindentifier;

	SELECT @Attack_Id1 = Id FROM tblAttack WHERE Name = 'Slash'
	SELECT @Attack_Id2 = Id FROM tblAttack WHERE Name = 'Throw Pebble'
	SELECT @Attack_Id3 = Id FROM tblAttack WHERE Name = 'Attack'

	SELECT @Character_Id1 = Id FROM Characters WHERE LastName = 'Bobbinson'
	SELECT @Character_Id2 = Id FROM Characters WHERE LastName = 'Gravydog'
	SELECT @Character_Id3 = Id FROM Characters WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterAttacks (Id, Character_Id, Attack_Id, CurrentUses)
	VALUES
	(NEWID(), @Character_Id1, @Attack_Id1, 2),
	(NEWID(), @Character_Id2, @Attack_Id2, 5),
	(NEWID(), @Character_Id3, @Attack_Id3, 3)
END