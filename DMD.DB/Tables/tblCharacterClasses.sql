CREATE TABLE [dbo].[tblCharacterClasses]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] VARCHAR(36) NULL, 
    [Class_Id] VARCHAR(36) NULL, 
    [Class_Level] INT NULL
)
