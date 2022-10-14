CREATE TABLE [dbo].[tblCharacterArmor]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Armor_Id] VARCHAR(36) NOT NULL, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Equipped] BIT NOT NULL
)
