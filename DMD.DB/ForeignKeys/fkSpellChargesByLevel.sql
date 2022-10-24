--CharacterSpellCharges to SpellChargesByLevel Connection
ALTER TABLE [dbo].[tblCharacterSpellCharges]
	ADD CONSTRAINT [fkSpellChargesByLevel-CharacterSpellCharges]
	FOREIGN KEY (Spell_Charges_By_Level_Id)
	REFERENCES [tblSpellChargesByLevel] (Id)
