﻿CREATE TABLE [dbo].[tblCharacterArmor]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Armor_Id] UNIQUEIDENTIFIER NOT NULL, 
    [Character_Id] UNIQUEIDENTIFIER NOT NULL, 
    [Equipped] BIT NOT NULL
)
