-- Race to Character Connection
ALTER TABLE [dbo].[tblCharacter]
	ADD CONSTRAINT [fkRaceId-Characters]
	FOREIGN KEY (Race_Id)
	REFERENCES [tblRace] (Id)
GO;
