BEGIN
	DECLARE @ArmorStyle_Id181 uniqueidentifier, @ArmorStyle_Id182 uniqueidentifier, @ArmorStyle_Id183 uniqueidentifier,
			@ArmorType_Id181 uniqueidentifier, @ArmorType_Id182 uniqueidentifier;

	SELECT @ArmorStyle_Id181 = Id FROM tblArmorStyle WHERE StyleName = 'Light'
	SELECT @ArmorStyle_Id182 = Id FROM tblArmorStyle WHERE StyleName = 'Medium'
	SELECT @ArmorStyle_Id183 = Id FROM tblArmorStyle WHERE StyleName = 'Heavy'

	SELECT @ArmorType_Id181 = Id FROM tblArmorType WHERE TypeName = 'Body Armor'
	SELECT @ArmorType_Id182 = Id FROM tblArmorType WHERE TypeName = 'Shield'

	INSERT INTO dbo.tblArmor (Id, ArmorStyle_Id, ArmorType_Id, ArmorClassBonus, MovementPenalty, Cost)
	VALUES
	(NEWID(), @ArmorStyle_Id181, @ArmorType_Id181, 5, 2, 20),
	(NEWID(), @ArmorStyle_Id182, @ArmorType_Id182, 7, 5, 50),
	(NEWID(), @ArmorStyle_Id183, @ArmorType_Id181, 10, 8, 100)
END