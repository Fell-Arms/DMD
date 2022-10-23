--Weapon to WeaponTypes Connection
ALTER TABLE [dbo].[tblWeapon]
	ADD CONSTRAINT [fkWeaponTypeId-Weapon]
	FOREIGN KEY (WeaponType_Id)
	REFERENCES [tblWeaponType] (Id)
GO;

--CharacterWeaponTypeProficiency to WeaponType Connection
ALTER TABLE [dbo].[tblCharacterWeaponTypeProficiency]
	ADD CONSTRAINT [fkWeaponTypeId-CharacterWeaponTypeProficiency]
	FOREIGN KEY (WeaponType_Id)
	REFERENCES [tblWeaponType] (Id)
GO;

--Attack to WeaponType Connection
ALTER TABLE [dbo].[tblAttack]
	ADD CONSTRAINT [fkWeaponTypeId-Attack]
	FOREIGN KEY (WeaponType_Id)
	REFERENCES [tblWeaponType] (Id)
GO;
