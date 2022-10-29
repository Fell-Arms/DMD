BEGIN
	DECLARE @Attack_Id51 uniqueidentifier, @Attack_Id52 uniqueidentifier, @Attack_Id53 uniqueidentifier,
			@Character_Id51 uniqueidentifier, @Character_Id52 uniqueidentifier, @Character_Id53 uniqueidentifier;

	SELECT @Attack_Id51 = Id FROM tblAttack WHERE Name = 'Slash'
	SELECT @Attack_Id52 = Id FROM tblAttack WHERE Name = 'Throw Pebble'
	SELECT @Attack_Id53 = Id FROM tblAttack WHERE Name = 'Attack'

	SELECT @Character_Id51 = Id FROM tblCharacter WHERE LastName = 'Bobbinson'
	SELECT @Character_Id52 = Id FROM tblCharacter WHERE LastName = 'Gravydog'
	SELECT @Character_Id53 = Id FROM tblCharacter WHERE LastName = 'Greywall'

	INSERT INTO dbo.tblCharacterAttacks (Id, Character_Id, Attack_Id, CurrentUses)
	VALUES
	(NEWID(), @Character_Id51, @Attack_Id51, 2),
	(NEWID(), @Character_Id52, @Attack_Id52, 5),
	(NEWID(), @Character_Id53, @Attack_Id53, 3)
END