﻿CREATE TABLE [dbo].[tblClass]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(45) NOT NULL, 
    [Description] VARCHAR(45) NOT NULL, 
    [HPUpDieOnLevel] INT NOT NULL
)
