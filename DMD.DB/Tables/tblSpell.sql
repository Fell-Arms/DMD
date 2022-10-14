CREATE TABLE [dbo].[tblSpell]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Stat_Id] VARCHAR(36) NOT NULL, 
    [Spell_Level] INT NOT NULL, 
    [Name] VARCHAR(45) NOT NULL, 
    [Description] TEXT NOT NULL, 
    [Targets] INT NULL, 
    [TargetAllies] BIT NULL, 
    [Heal] BIT NULL
)
