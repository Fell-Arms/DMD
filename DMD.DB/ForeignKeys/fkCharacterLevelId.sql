--Characters to CharacterLevel Connection
ALTER TABLE [dbo].[Characters]
	ADD CONSTRAINT [fkCharacterLevelId-Characters]
	FOREIGN KEY (Level) --Needs fixing??
	REFERENCES [tblCharacterLevel] (Id)
GO;
