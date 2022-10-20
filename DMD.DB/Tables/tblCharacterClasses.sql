CREATE TABLE [dbo].[tblCharacterClasses]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] UNIQUEIDENTIFIER NULL, 
    [Class_Id] UNIQUEIDENTIFIER NULL, 
    [Class_Level] INT NULL
)
