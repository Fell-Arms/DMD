﻿CREATE TABLE [dbo].[tblUserMaps]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [User_Id] VARCHAR(36) NOT NULL, 
    [Map_Id] VARCHAR(36) NOT NULL
)