BEGIN
	DECLARE @DamageType_Id131 uniqueidentifier, @DamageType_Id132 uniqueidentifier, @DamageType_Id133 uniqueidentifier,
			@Attack_Id131 uniqueidentifier, @Attack_Id132 uniqueidentifier, @Attack_Id133 uniqueidentifier;

	SELECT @DamageType_Id131 = Id FROM tblDamageType WHERE Name = 'Fire'
	SELECT @DamageType_Id132 = Id FROM tblDamageType WHERE Name = 'Force'
	SELECT @DamageType_Id133 = Id FROM tblDamageType WHERE Name = 'Poison'
	
	SELECT @Attack_Id131 = Id FROM tblAttack WHERE Name = 'Slash'
	SELECT @Attack_Id132 = Id FROM tblAttack WHERE Name = 'Throw Pebble'
	SELECT @Attack_Id133 = Id FROM tblAttack WHERE Name = 'Attack'

	INSERT INTO dbo.tblAttackDamageTypes (Attack_Id, DamageType_Id, DamageDie, DamageModifier, DieCount)
	VALUES
	(@Attack_Id131, @DamageType_Id131, 4, 4, 3),
	(@Attack_Id132, @DamageType_Id132, 6, 3, 2),
	(@Attack_Id133, @DamageType_Id133, 20, 8, 1)
END