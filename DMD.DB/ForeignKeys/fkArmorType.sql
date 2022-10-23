ALTER TABLE [dbo].[tblArmor] -- Name of table to add constriant to (tblArmor)
	ADD CONSTRAINT [fkArmorType-ArmorTypeId] -- The name of the constraint (fkArmorType-ArmorTypeId). Indicating foreign key of ArmorTypeId in the Armor Table.
	FOREIGN KEY (ArmorType_Id) -- The foreign key in the tblArmor.
	REFERENCES [tblArmorType] (Id) -- The table the foreign key is referring too (Primary key of tblArmorType) and the value.
GO;
