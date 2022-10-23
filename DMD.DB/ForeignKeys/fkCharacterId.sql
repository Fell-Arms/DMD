--Character to CharacterArmor Connection
ALTER TABLE [dbo].[tblCharacterArmor] -- Name of table to add constraint to (tblCharacterArmor)
	ADD CONSTRAINT [fkCharacterId-CharacterArmor] -- The name of the constraint ("fkCharacter-CharacterArmor") - indicating a foreign key constraint of CharacterId in the CharacterArmor table.
	FOREIGN KEY (Character_Id) -- the foreign key in the CharacterArmor table
	REFERENCES [Characters] (Id) -- the table the foreign key is referring to (The primary key of tblCharacter is the foreign key in CharacterArmor).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.

--Character to CharacterArmor Connection
ALTER TABLE [dbo].[tblCharacterCurrency] -- Name of table to add constraint to (tblCharacterCurrency)
	ADD CONSTRAINT [fkCharacterId-CharacterCurrency] -- The name of the constraint ("fkCharacter-CharacterCurrency") - indicating a foreign key constraint of CharacterId in the CharacterCurrency table.
	FOREIGN KEY (Character_Id) -- the foreign key in the CharacterCurrency table
	REFERENCES [Characters] (Id) -- the table the foreign key is referring to (The primary key of tblCharacter is the foreign key in CharacterCurrency).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.

