BEGIN
	INSERT INTO dbo.tblCharacterSpellCharges (Id, Character_Id, Spell_Charges_By_Level_Id, ChargesAvaliable)
	VALUES
	(NEWID(), 'FK-CharacterID-GUID', 'FK-SpellChargesByLevelID-GUID', 3),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-SpellChargesByLevelID-GUID', 5),
	(NEWID(), 'FK-CharacterID-GUID', 'FK-SpellChargesByLevelID-GUID', 7)
END