CREATE TABLE [dbo].[tblSpellDamageTypes]
(
	[DamageType_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Spell_Id] VARCHAR(36) NOT NULL, 
    [DamageDie] INT NULL, 
    [DamageModifier] INT NULL, 
    [DieCount] INT NULL
)
