BEGIN
	INSERT INTO dbo.tblClass(Id, Name, Description, HPUpDieOnLevel)
	VALUES
	(NEWID(), 'Paladin', 'Paladins are the holy knights, crusading in the name of good and order.', 8),
	(NEWID(), 'Warlock', 'Warlocks are seekers of the knowledge that lies hidden in the fabric of the multiverse.', 2),
	(NEWID(), 'Ranger', 'Rangers specialize in hunting the monsters that threaten the edges of civilization', 4)
END