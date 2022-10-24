
--CharacterLevel to Character Connection
ALTER TABLE [dbo].[Characters]
	ADD CONSTRAINT [fkCharacterLevelId-Characters]
	FOREIGN KEY (CharacterLevel_Id)
	REFERENCES [tblCharacterLevel] (Id)
GO;
