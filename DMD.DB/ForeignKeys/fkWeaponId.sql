--WeaponDamageTypes to Weapon Connection
ALTER TABLE [dbo].[tblWeaponDamageTypes]
	ADD CONSTRAINT [fkWeaponId-WeaponDamageTypes]
	FOREIGN KEY (Weapon_Id)
	REFERENCES [tblWeapon] (Id)
GO;

--CharacterWeapons to Weapon Connection
ALTER TABLE [dbo].[tblCharacterWeapons]
	ADD CONSTRAINT [fkWeaponId-CharacterWeapons]
	FOREIGN KEY (Weapon_Id)
	REFERENCES [tblWeapon] (Id)
GO;


