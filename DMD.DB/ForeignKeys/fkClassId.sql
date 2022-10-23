--CharacterClasses to Class Connection
ALTER TABLE [dbo].[tblCharacterClasses]
	ADD CONSTRAINT [fkClassId-CharacterClasses]
	FOREIGN KEY (Class_Id)
	REFERENCES [tblClass] (Id)
GO;

--Attack to Class Connection
ALTER TABLE [dbo].[tblAttack]
	ADD CONSTRAINT [fkClassId-Attack]
	FOREIGN KEY (Class_Id)
	REFERENCES [tblClass] (Id)
GO;

--ClassSpells to Class Connection
ALTER TABLE [dbo].[tblClassSpells]
	ADD CONSTRAINT [fkClassId-Class Spells]
	FOREIGN KEY (Class_Id)
	REFERENCES [tblClass] (Id)
GO;

--SpellChargesByLevel to Class Connection
ALTER TABLE [dbo].[tblSpellChargesByLevel]
	ADD CONSTRAINT [fkClassId-SoellChargesByLevel]
	FOREIGN KEY (Class_Id)
	REFERENCES [tblClass] (Id)
GO;
