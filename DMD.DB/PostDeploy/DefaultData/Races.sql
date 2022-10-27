BEGIN
	INSERT INTO dbo.tblRace (Id, Name, Description)
	VALUES
	(NEWID(), 'Dragonborn', ' Shaped by draconic gods or the dragons themselves, dragonborn originally hatched from dragon eggs as a unique race, combining the best attributes of dragons and humanoids.'),
	(NEWID(), 'Dwarf', 'Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal. '),
	(NEWID(), 'Elf', 'Elves are a magical people of otherworldly grace, living in the world but not entirely part of it.'),
	(NEWID(), 'Gnome', 'A Gnomes energy and enthusiasm for living shines through every inch of his or her tiny body.'),
	(NEWID(), 'Half-Elf', 'Half-Elves combine what some say are the best qualities of their elf and human parents.'),
	(NEWID(), 'Halfling', 'The diminutive halflings survive in a world full of larger creatures by avoiding notice, or barring that, avoiding offense.'),
	(NEWID(), 'Half-Orc', 'Some Half-Orcs rise to become proud leaders of orc communities. Some venture into the world to prove their worth. Many of them become adventurers, achieving greatness for their mighty deeds.'),
	(NEWID(), 'Human', 'Humans are the most adaptable and ambitious people among the common races. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.'),
	(NEWID(), 'Tiefling', 'To be greeted with stares and whispers, to suffer violence and insult, to see mistrust and fear in every eye: this is the lot of the tiefling.')
END