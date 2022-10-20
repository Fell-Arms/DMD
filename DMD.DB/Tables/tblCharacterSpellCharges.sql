CREATE TABLE [dbo].[tblCharacterSpellCharges]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Character_Id] UNIQUEIDENTIFIER NOT NULL, 
    [Spell_Charges_By_Level_Id] UNIQUEIDENTIFIER NOT NULL, 
    [ChargesAvaliable] INT NOT NULL
)
