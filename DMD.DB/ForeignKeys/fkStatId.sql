--ALTER TABLE [dbo].[Characters] -- Name of table to add constraint to (Characters)
--	ADD CONSTRAINT [fkStatsId-Characters] -- The name of the constraint ("fkStatsId-Characters") - indicating a foreign key constraint of StatId in the Characters table.
--	FOREIGN KEY (StatsId) -- the foreign key in the Characters table
--	REFERENCES [tblStat] (Id) -- the table the foreign key is referring to (The primary key of tblStats is the foreign key in Characters).
--GO;

--Skill to Stat Connection
ALTER TABLE [dbo].[tblSkill]
	ADD CONSTRAINT [fkStatId-Skill]
	FOREIGN KEY (Stats_Id)
	REFERENCES [tblStat] (Id)
GO;

--Weapon to Stat Connection
ALTER TABLE [dbo].[tblWeapon]
	ADD CONSTRAINT [fkStatId-Weapon]
	FOREIGN KEY (Stats_Id)
	REFERENCES [tblStat] (Id)
GO;

--Spell To Stat Connection
ALTER TABLE [dbo].[tblSpell]
	ADD CONSTRAINT [fkStatId-Spell]
	FOREIGN KEY ([Stat_Id])
	REFERENCES [tblStat] (Id)
GO;

--Attack to Stat Connection
ALTER TABLE [dbo].[tblAttack]
	ADD CONSTRAINT [fkStatId-Attack]
	FOREIGN KEY (Stat_Id)
	REFERENCES [tblStat] (Id)
GO;

--CharacterStats to Stat

ALTER TABLE [dbo].[tblCharacterStats]
	ADD CONSTRAINT [fkStatId-CharacterStats]
	FOREIGN KEY (Stats_Id)
	REFERENCES [tblStat] (Id)
GO;