ALTER TABLE [dbo].[Characters] -- Name of table to add constraint to (Characters)
	ADD CONSTRAINT [fkStatsId-Characters] -- The name of the constraint ("fkStatsId-Characters") - indicating a foreign key constraint of StatId in the Characters table.
	FOREIGN KEY (StatsId) -- the foreign key in the Characters table
	REFERENCES [tblStat] (Id) -- the table the foreign key is referring to (The primary key of tblStats is the foreign key in Characters).
GO;
