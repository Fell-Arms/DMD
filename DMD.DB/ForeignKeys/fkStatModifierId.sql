ALTER TABLE [dbo].[tblCharacterStats] -- Name of table to add constraint to (Characters)
	ADD CONSTRAINT [fkValueId-CharacterStats] -- The name of the constraint ("fkValueId-CharacterStats") - indicating a foreign key constraint of ValueId in the CharacterStats table.
	FOREIGN KEY (Value) -- the foreign key in the CharacterStats table
	REFERENCES [tblStatModifier] (Value) -- the table the foreign key is referring to (The primary key of tblStatModifier is the foreign key in CharacterStats).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.
