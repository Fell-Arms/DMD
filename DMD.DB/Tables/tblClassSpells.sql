﻿CREATE TABLE [dbo].[tblClassSpells]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Spell_Id] UNIQUEIDENTIFIER NOT NULL, 
    [Class_Id] UNIQUEIDENTIFIER NOT NULL,
)
