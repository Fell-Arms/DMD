CREATE TABLE [dbo].[tblCharacterAttacks]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Attack_Id] VARCHAR(36) NOT NULL, 
    [CurrentUses] INT NOT NULL
)
