CREATE TABLE [dbo].[tblSpellDamageTypes]
( 
    [Spell_Id] UNIQUEIDENTIFIER NOT NULL, 
	[DamageType_Id] UNIQUEIDENTIFIER NOT NULL, 
    [DamageDie] INT NOT NULL, 
    [DamageModifier] INT NOT NULL, 
    [DieCount] INT NOT NULL,
    CONSTRAINT PK_SpellDamageTypes PRIMARY KEY (DamageType_Id, Spell_Id)
)
