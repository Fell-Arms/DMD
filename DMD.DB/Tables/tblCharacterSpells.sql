CREATE TABLE [dbo].[tblCharacterSpells]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Spell_Id] VARCHAR(36) NOT NULL
)
