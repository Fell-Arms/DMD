﻿CREATE TABLE [dbo].[tblCharacterStats]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] UNIQUEIDENTIFIER NOT NULL, 
    [Stats_Id] UNIQUEIDENTIFIER NOT NULL, 
    [Value] INT NOT NULL
)
