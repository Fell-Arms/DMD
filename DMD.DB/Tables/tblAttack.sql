CREATE TABLE [dbo].[tblAttack]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Class_Id] VARCHAR(36) NOT NULL, 
    [Stat_Id] VARCHAR(36) NOT NULL, 
    [WeaponType_Id] VARCHAR(36) NOT NULL, 
    [Name] VARCHAR(45) NOT NULL, 
    [Description] VARCHAR(45) NOT NULL, 
    [Targets] INT NOT NULL, 
    [MaxUses] INT NOT NULL, 
    [UseWeapon] BIT NOT NULL, 
    [Class_Level] INT NULL
)
