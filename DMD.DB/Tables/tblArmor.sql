CREATE TABLE [dbo].[tblArmor]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ArmorStyle_Id] VARCHAR(36) NOT NULL, 
    [ArmorType_Id] VARCHAR(36) NOT NULL, 
    [ArmorClassBonus] INT NOT NULL, 
    [MovementPenalty] INT NOT NULL, 
    [Cost] INT NOT NULL
)
