CREATE TABLE [dbo].[tblAttackDamageTypes]
(
	[DamageType_Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
    [Attack_Id] VARCHAR(36) NOT NULL, 
    [DamageDie] INT NULL, 
    [DamageModifier] INT NULL, 
    [DieCount] INT NULL
)
