CREATE TABLE [dbo].[tblWeaponDamageTypes]
(
	[Weapon_Id] UNIQUEIDENTIFIER NOT NULL, 
    [DamageType_id] UNIQUEIDENTIFIER NOT NULL, 
    [DamageDie] INT NOT NULL, 
    [DamageModifier] INT NOT NULL, 
    [DieCount] INT NOT NULL,
    CONSTRAINT PK_WeaponDamageTypes PRIMARY KEY (Weapon_Id, DamageType_Id)
)
