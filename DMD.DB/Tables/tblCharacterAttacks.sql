﻿CREATE TABLE [dbo].[tblCharacterAttacks]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] UNIQUEIDENTIFIER NOT NULL, 
    [Attack_Id] UNIQUEIDENTIFIER NOT NULL, 
    [CurrentUses] INT NOT NULL
)
