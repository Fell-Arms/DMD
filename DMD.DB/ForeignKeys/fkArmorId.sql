ALTER TABLE [dbo].[tblCharacterArmor] -- Name of table to add constriant to (tblCharacterArmor)
	ADD CONSTRAINT [fkArmorId-CharacterArmor] -- The name of the constraint (fkArmorId-CharacterArmor). Indicating foreign key of ArmorId in the CharacterArmor Table.
	FOREIGN KEY (Armor_Id) -- The foreign key in the tblCharacterArmorTable.
	REFERENCES [tblArmor] (Id) -- The table the foreign key is referring too (Primary key of tblArmor) and the value.
GO;
