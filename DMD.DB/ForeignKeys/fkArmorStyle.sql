ALTER TABLE [dbo].[tblArmor] -- Name of table to add constriant to (tblArmor)
	ADD CONSTRAINT [fkArmorStyle-ArmorStyleId] -- The name of the constraint (fkArmorStyle-ArmorStyleId). Indicating foreign key of ArmorStyleId in the Armor Table.
	FOREIGN KEY (ArmorStyle_Id) -- The foreign key in the tblArmor.
	REFERENCES [tblArmorStyle] (Id) -- The table the foreign key is referring too (Primary key of tblArmorStyle) and the value.
GO;
