CREATE TABLE [dbo].[tblCharacterSpellCharges]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Spell_Charges_By_Level_Id] VARCHAR(36) NOT NULL, 
    [ChargesAvaliable] INT NOT NULL
)
