-- Race to Character Connection
ALTER TABLE [dbo].[Characters]
	ADD CONSTRAINT [fkRaceId-Characters]
	FOREIGN KEY (Race_Id)
	REFERENCES [tblRace] (Id)
GO;
