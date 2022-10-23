--AttackDamageTypes to DamageType Connection
ALTER TABLE [dbo].[tblAttackDamageTypes]
	ADD CONSTRAINT [fkDamageTypeId-AttackDamageTypes]
	FOREIGN KEY (DamageType_Id)
	REFERENCES [tblDamageType] (Id)
GO;

--SpellDamageTypes to DamageType Connection
ALTER TABLE [dbo].[tblSpellDamageTypes]
	ADD CONSTRAINT [fkDamageTypeId-SpellDamageTypes]
	FOREIGN KEY (DamageType_Id)
	REFERENCES [tblDamageType] (Id)
GO;

--WeaponDamageTypes to DamageType Connection
ALTER TABLE [dbo].[tblWeaponDamageTypes]
	ADD CONSTRAINT [fkDamageTypeId-WeaponDamageTypes]
	FOREIGN KEY (DamageType_Id)
	REFERENCES [tblDamageType] (Id)
GO;

