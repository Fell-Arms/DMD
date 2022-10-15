BEGIN
	INSERT INTO dbo.tblLanguage (Id, Name, Description)
	VALUES
	(NEWID(), 'Common', 'Typical speakers are Humans, Halflings, Half-Elves, and Half-Orcs.'),
	(NEWID(), 'Dwarvish', 'Typical speakers are Dwarves.'),
	(NEWID(), 'Elvish', 'Typical speakers are Elves.'),
	(NEWID(), 'Giant', 'Typical speakers are Ogres and Giants.'),
	(NEWID(), 'Gnomish', 'Typical speakers are Gnomes.'),
	(NEWID(), 'Goblin', 'Typical speakers are Goblinoids.'),
	(NEWID(), 'Halfling', 'Typical speakers are Halflings.'),
	(NEWID(), 'Orc', 'Typical speakers are Orcs.'),
	(NEWID(), 'Abyssal', 'Typical speakers are Demons and chaotic-evil outsiders.'),
	(NEWID(), 'Celestial', 'Typical speakers are Celestials.'),
	(NEWID(), 'Draconic', 'Typical speakers are Dragons and Dragonborn.'),
	(NEWID(), 'Deep Speech', 'Typical speakers are Mind Flayers and Beholders.'),
	(NEWID(), 'Infernal', 'Typical speakers are Devils and Tieflings.'),
	(NEWID(), 'Primordial', 'Typical speakers are Elementals.'),
	(NEWID(), 'Sylvan', 'Typical speakers are Fey creatures such as Dryads, Brownies, Leprechauns, etc.'),
	(NEWID(), 'Undercommon', 'Typical speakers are Drow and Underdark traders.'),
	(NEWID(), 'Aquan', 'Typical speakers are water-based creatures.'),
	(NEWID(), 'Auran', 'Typical speakers are air-based creatures.'),
	(NEWID(), 'Druidic', 'Only druids can speak this language.'),
	(NEWID(), 'Gnoll', 'Typical speakers are Gnolls.'),
	(NEWID(), 'Ignan', 'Typical speakers are fire-based creatures.'),
	(NEWID(), 'Terran', 'Typical speakers are Xorns and other earth-based creatures.')
END