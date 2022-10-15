BEGIN
	INSERT INTO dbo.tblSpell (Id, Stat_Id, Spell_Level, Name, Description, Targets, TargetAllies, Heal)
	VALUES
	(NEWID(), 'FK-StatID_GUID', 1, 'Fireball', 'Launch a small fireball at a foe', 1, 0, 0),
	(NEWID(), 'FK-ArmorStyle_GUID', 3, 'Summon Undead', 'Summon an undead minion to fight for you', 1, 0, 0),
	(NEWID(), 'FK-ArmorStyle_GUID', 1, 'Healing Aura', 'Cast a healing ring on the ground that heals up to five allies', 5, 1, 1)
END