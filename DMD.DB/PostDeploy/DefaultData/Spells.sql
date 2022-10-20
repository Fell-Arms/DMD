﻿BEGIN
	DECLARE @Stat_Id1 uniqueindentifier, @Stat_Id2 uniqueindentifier, @Stat_Id3 uniqueindentifier;

	SELECT @Stat_Id1 = Id FROM tblStat WHERE Name = 'Wisdom'
	SELECT @Stat_Id2 = Id FROM tblStat WHERE Name = 'Intelligence'
	SELECT @Stat_Id3 = Id FROM tblStat WHERE Name = 'Charisma'

	INSERT INTO dbo.tblSpell (Id, Stat_Id, Spell_Level, Name, Description, Targets, TargetAllies, Heal)
	VALUES
	(NEWID(), @Stat_Id1, 1, 'Fireball', 'Launch a small fireball at a foe', 1, 0, 0),
	(NEWID(), @Stat_Id2, 3, 'Summon Undead', 'Summon an undead minion to fight for you', 1, 0, 0),
	(NEWID(), @Stat_Id3, 1, 'Healing Aura', 'Cast a healing ring on the ground that heals up to five allies', 5, 1, 1)
END