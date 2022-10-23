ALTER TABLE [dbo].[Characters]
	ADD CONSTRAINT [fkRaceId-Characters]
	FOREIGN KEY (RaceId)
	REFERENCES [tblRace] (Id)
