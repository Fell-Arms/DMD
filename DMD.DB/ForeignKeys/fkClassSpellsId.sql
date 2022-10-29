--Character Spells to Spell Connection
ALTER TABLE [dbo].[tblCharacterClassSpells]
	ADD CONSTRAINT [fkClassSpellsId-CharacterSpells]
	FOREIGN KEY ([ClassSpells_Id])
	REFERENCES [tblClassSpells] (Id)
GO;
