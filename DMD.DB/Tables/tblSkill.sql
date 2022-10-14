CREATE TABLE [dbo].[tblSkill]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Stats_Id] VARCHAR(36) NULL, 
    [Name] VARCHAR(45) NULL, 
    [Description] VARCHAR(45) NULL
)
