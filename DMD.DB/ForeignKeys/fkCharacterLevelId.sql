
--CharacterLevel to Character Connection
ALTER TABLE [dbo].[tblCharacter]
	ADD CONSTRAINT [fkCharacterLevelId-Characters]
	FOREIGN KEY (CharacterLevel_Id)
	REFERENCES [tblCharacterLevel] (Level)
GO;
