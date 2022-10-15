BEGIN
	INSERT INTO dbo.tblStat (Id, Name, Description)
	VALUES
	(NEWID(), 'Strength', 'Strength (STR) is how hard you hit something, how much you can carry, and how well you tend to do with strength based skill checks.'),
	(NEWID(), 'Dexterity', 'Dexterity (DEX) determines speed. It is how fast you are, as well as how successful you are with ranged attacks.'),
	(NEWID(), 'Constitution', 'Constitution (CON) is around your actual fortitude as a player. It is the stat that has a direct effect on your hit points, as well as your resistance to poisoning, how fast you sober up, and the likes.'),
	(NEWID(), 'Intelligence', 'Intelligence (INT) is how smart you are. It’s that simple really – Intelligence is usually academic intelligence – so how much you know about things.'),
	(NEWID(), 'Wisdom', 'Wisdom (WIS) is knowing about the world around you as well as how perceptive you are. It determines what you naturally notice.'),
	(NEWID(), 'Charisma', 'Charisma (CHA) is how good you are with people. It is how good you are at persuading people you are a good guy or how well you get on with NPCs.')
END