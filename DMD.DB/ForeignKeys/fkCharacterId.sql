--Character to CharacterArmor Connection
ALTER TABLE [dbo].[tblCharacterArmor] -- Name of table to add constraint to (tblCharacterArmor)
	ADD CONSTRAINT [fkCharacterId-CharacterArmor] -- The name of the constraint ("fkCharacter-CharacterArmor") - indicating a foreign key constraint of CharacterId in the CharacterArmor table.
	FOREIGN KEY (Character_Id) -- the foreign key in the CharacterArmor table
	REFERENCES [tblCharacter] (Id) -- the table the foreign key is referring to (The primary key of tblCharacter is the foreign key in CharacterArmor).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.

--Character to Currency Connection
ALTER TABLE [dbo].[tblCharacterCurrency] -- Name of table to add constraint to (tblCharacterCurrency)
	ADD CONSTRAINT [fkCharacterId-CharacterCurrency] -- The name of the constraint ("fkCharacter-CharacterCurrency") - indicating a foreign key constraint of CharacterId in the CharacterCurrency table.
	FOREIGN KEY (Character_Id) -- the foreign key in the CharacterCurrency table
	REFERENCES [tblCharacter] (Id) -- the table the foreign key is referring to (The primary key of tblCharacter is the foreign key in CharacterCurrency).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.

--Character to CharacterWeapons Connection
ALTER TABLE [dbo].[tblCharacterWeapons]
	ADD CONSTRAINT [fkCharacterId-CharacterWeapons]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;

--Character to CharacterSpells
ALTER TABLE [dbo].[tblCharacterClassSpells]
	ADD CONSTRAINT [fkCharacterId-CharacterSpells]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;

--Character to CharacterSpellCharges
ALTER TABLE [dbo].[tblCharacterSpellCharges]
	ADD CONSTRAINT [fkCharacterId-CharacterSpellCharges]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;

--Character to CharacterWeaponTypeProficiency
ALTER TABLE [dbo].[tblCharacterWeaponTypeProficiency]
	ADD CONSTRAINT [fkCharacterId-CharacterWeaponTypeProficiency]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;


--Character to CharacterSkillProficiency
ALTER TABLE [dbo].[tblCharacterSkillProficiency]
	ADD CONSTRAINT [fkCharacterId-CharacterSkillProficiency]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;

--Character to CharacterAttacks
ALTER TABLE [dbo].[tblCharacterAttacks]
	ADD CONSTRAINT [fkCharacterId-CharacterAttacks]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;

--Character to CharacterStats
ALTER TABLE [dbo].[tblCharacterStats]
	ADD CONSTRAINT [fkCharacterId-CharacterStats]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;

--Character to CharacterClasses
ALTER TABLE [dbo].[tblCharacterClasses]
	ADD CONSTRAINT [fkCharacterId-CharacterClasses]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;

--Character to CharacterLanguages
ALTER TABLE [dbo].[tblCharacterLanguages]
	ADD CONSTRAINT [fkCharacterId-CharacterLanguages]
	FOREIGN KEY (Character_Id)
	REFERENCES [tblCharacter] (Id)
GO;
