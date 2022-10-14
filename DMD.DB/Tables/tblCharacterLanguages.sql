CREATE TABLE [dbo].[tblCharacterLanguages]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Language_Id] VARCHAR(36) NOT NULL
)
