CREATE TABLE [dbo].[tblArmor]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ArmorStyle_Id] UNIQUEIDENTIFIER NOT NULL, 
    [ArmorType_Id] UNIQUEIDENTIFIER NOT NULL, 
    [ArmorClassBonus] INT NOT NULL, 
    [MovementPenalty] INT NOT NULL, 
    [Cost] INT NOT NULL
)
