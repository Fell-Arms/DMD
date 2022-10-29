CREATE TABLE [dbo].[tblAttackDamageTypes]
(
    [Attack_Id] UNIQUEIDENTIFIER NOT NULL, 
	[DamageType_Id] UNIQUEIDENTIFIER NOT NULL,
    [DamageDie] INT NOT NULL, 
    [DamageModifier] INT NOT NULL, 
    [DieCount] INT NOT NULL,
    CONSTRAINT PK_AttackDamageTypes PRIMARY KEY (DamageType_Id, Attack_Id)
)
