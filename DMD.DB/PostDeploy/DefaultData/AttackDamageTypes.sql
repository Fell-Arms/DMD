BEGIN
	DECLARE @DamageType_Id1 uniqueindentifier, @DamageType_Id2 uniqueindentifier, @DamageType_Id3 uniqueindentifier,
			@Attack_Id1 uniqueindentifier, @Attack_Id2 uniqueindentifier, @Attack_Id3 uniqueindentifier;

	SELECT @DamageType_Id1 = Id FROM tblDamageType WHERE Name = 'Fire'
	SELECT @DamageType_Id2 = Id FROM tblDamageType WHERE Name = 'Radiant'
	SELECT @DamageType_Id3 = Id FROM tblDamageType WHERE Name = 'Poison'
	
	SELECT @Attack_Id1 = Id FROM tblAttack WHERE Name = 'Slash'
	SELECT @Attack_Id2 = Id FROM tblAttack WHERE Name = 'Throw Pebble'
	SELECT @Attack_Id3 = Id FROM tblAttack WHERE Name = 'Attack'

	INSERT INTO dbo.tblAttackDamageTypes (DamageType_Id, Attack_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	(@DamageType_Id1, @Attack_Id1, 4, 4, 3),
	(@DamageType_Id2,  @Attack_Id2, 6, 3, 2),
	(@DamageType_Id3,  @Attack_Id3, 20, 8, 1)
END