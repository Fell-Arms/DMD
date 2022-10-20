CREATE TABLE [dbo].[tblWeaponDamageTypes]
(
	[Weapon_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [DamageType_id] UNIQUEIDENTIFIER NOT NULL, 
    [DamageDie] INT NULL, 
    [DamageModifier] INT NULL, 
    [DieCount] INT NULL
)
