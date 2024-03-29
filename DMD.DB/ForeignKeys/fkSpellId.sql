﻿--Class Spells to Spell Connection
ALTER TABLE [dbo].[tblClassSpells]
	ADD CONSTRAINT [fkSpellId-ClassSpells]
	FOREIGN KEY (Spell_Id)
	REFERENCES [tblSpell] (Id)
GO;

--SpellDamageTypes to Spell Connection
ALTER TABLE [dbo].[tblSpellDamageTypes]
	ADD CONSTRAINT [fkSpellId-SpellDamageTypes]
	FOREIGN KEY (Spell_Id)
	REFERENCES [tblSpell] (Id)
GO;

