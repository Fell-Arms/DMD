CREATE TABLE [dbo].[tblAttackDamageTypes]
(
	[DamageType_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Attack_Id] UNIQUEIDENTIFIER NOT NULL, 
    [DamageDie] INT NULL, 
    [DamageModifier] INT NULL, 
    [DieCount] INT NULL
)
