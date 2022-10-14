CREATE TABLE [dbo].[tblCharacterWeapons]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Weapon_Id] VARCHAR(36) NOT NULL, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Equipped] BIT NOT NULL
)
