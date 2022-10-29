BEGIN
	DECLARE @DamageType_Id1 uniqueidentifier, @DamageType_Id2 uniqueidentifier, @DamageType_Id3 uniqueidentifier,
			@Attack_Id1 uniqueidentifier, @Attack_Id2 uniqueidentifier, @Attack_Id3 uniqueidentifier;

	SELECT @DamageType_Id1 = Id FROM tblDamageType WHERE Name = 'Fire'
	SELECT @DamageType_Id2 = Id FROM tblDamageType WHERE Name = 'Force'
	SELECT @DamageType_Id3 = Id FROM tblDamageType WHERE Name = 'Poison'
	
	SELECT @Attack_Id1 = Id FROM tblAttack WHERE Name = 'Slash'
	SELECT @Attack_Id2 = Id FROM tblAttack WHERE Name = 'Throw Pebble'
	SELECT @Attack_Id3 = Id FROM tblAttack WHERE Name = 'Attack'

	INSERT INTO dbo.tblAttackDamageTypes (Attack_Id, DamageType_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	(@Attack_Id1, @DamageType_Id1, 4, 4, 3),
	(@Attack_Id2, @DamageType_Id2, 6, 3, 2),
	(@Attack_Id3, @DamageType_Id3, 20, 8, 1)
END