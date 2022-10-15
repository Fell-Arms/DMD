BEGIN
	INSERT INTO dbo.tblDamageType(Id, Name, Description)
	VALUES
	(NEWID(), 'Acid', 'Corrosive damage that dissolves organic and/or inorganic matter.'),
	(NEWID(), 'Bludgeoning', 'Damage done from blunt weapons like clubs and hammers. Also includes falling and constricting.'),
	(NEWID(), 'Cold', 'Subzero temperatures and magical effects that freeze the flesh of creatures.'),
	(NEWID(), 'Fire', 'Searing heat and rampaging flames that burn creatures and objects.'),
	(NEWID(), 'Force', 'Pure magical energy focused into a single point to deal damage. This damage type results almost exclusively from spells but might come from other magical effects.'),
	(NEWID(), 'Lightning', 'Raw electrical energy that shocks a creature’s bodily functions.'),
	(NEWID(), 'Necrotic', 'Corrupting and withering damage that breaks apart living creatures and inanimate objects alike.'),
	(NEWID(), 'Piercing', 'Damage done from sharpened points that pierces through flesh.'),
	(NEWID(), 'Poison', 'Damage that results from contaminated food and water or from venomous creatures.'),
	(NEWID(), 'Psychic', 'Psychic damage affects the minds of living creatures, wracking them in immense pain originating from their skull.'),
	(NEWID(), 'Radiant', 'Holy and blinding light that burns the flesh and very soul of creatures.'),
	(NEWID(), 'Slashing', 'Sharpened blades and claws that rend flesh and cut through objects deal slashing damage.'),
	(NEWID(), 'Thunder', 'Booming, resounding, and echoing sound waves that shatter eardrums and shake the earth.')
END