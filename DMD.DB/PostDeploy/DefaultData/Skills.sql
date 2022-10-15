BEGIN
	INSERT INTO dbo.tblSkill (Id, Stats_Id, Name, Description)
	VALUES
	(NEWID(), 'FK-StatsID_GUID', 'Strength', 'Strength is how hard you hit something, how much you can carry, and how well you tend to do with strength based skill checks.'),
	(NEWID(), 'FK-StatsID_GUID', 'Dexterity', 'Dexterity determines your speed. It is how fast you are, as well as how successful you are with ranged attacks.'),
	(NEWID(), 'FK-StatsID_GUID', 'Constitution', 'Strength is the stat that has a direct effect on your hit points, as well as your resistance to poisoning, how fast you sober up, and the likes.'),
	(NEWID(), 'FK-StatsID_GUID', 'Intelligence', 'Intelligence is how smart you are. Intelligence is usually academic based intelligence – so how much you know about things.'),
	(NEWID(), 'FK-StatsID_GUID', 'Wisdom', 'Wisdom is knowing about the world around you as well as how perceptive you are. It determines what you naturally notice.'),
	(NEWID(), 'FK-StatsID_GUID', 'Charisma', 'Charisma is how good you are with people. It reflects your ability to persuade people or how well you get on with NPCs')
END