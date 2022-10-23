--Character Attacks to Attacks Connection
ALTER TABLE [dbo].[tblCharacterAttacks]
	ADD CONSTRAINT [fkAttacksId-CharacterAttacks]
	FOREIGN KEY (Attack_Id)
	REFERENCES [tblAttack] (Id)
GO;

--Attack Damage Types to Attacks Connection
ALTER TABLE [dbo].[tblAttackDamageTypes]
	ADD CONSTRAINT [fkAttacksId-AttackDamageTypes]
	FOREIGN KEY (Attack_Id)
	REFERENCES [tblAttack] (Id)
GO;
