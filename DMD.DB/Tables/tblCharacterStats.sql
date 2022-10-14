CREATE TABLE [dbo].[tblCharacterStats]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Stats_Id] VARCHAR(36) NOT NULL, 
    [Value] INT NOT NULL
)
