﻿CREATE TABLE [dbo].[tblSpellChargesByLevel]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Class_Id] VARCHAR(36) NOT NULL, 
    [Class_Level] INT NOT NULL, 
    [Spell_Charge_Level] INT NOT NULL, 
    [ChargesMax] INT NOT NULL
)