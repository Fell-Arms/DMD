CREATE TABLE [dbo].[tblSpellDamageTypes]
(
	[DamageType_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Spell_Id] UNIQUEIDENTIFIER NOT NULL, 
    [DamageDie] INT NULL, 
    [DamageModifier] INT NULL, 
    [DieCount] INT NULL
)
