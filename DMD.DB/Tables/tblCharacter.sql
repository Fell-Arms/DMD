CREATE TABLE [dbo].[Characters]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(30) NOT NULL, 
    [LastName] VARCHAR(30) NULL, 
    [Race] VARCHAR(20) NOT NULL, 
    [Class] VARCHAR(20) NOT NULL, 
    [Level] INT NOT NULL, 
    [ArmorClass] INT NOT NULL, 
    [MaxHealth] NCHAR(10) NOT NULL, 
    [CurrentHealth] NCHAR(10) NOT NULL, 
    [CreationDate] DATETIME NOT NULL, 
    [LanguageId] UNIQUEIDENTIFIER NOT NULL, 
    [StatsId] UNIQUEIDENTIFIER NOT NULL, 
    [AttacksId] UNIQUEIDENTIFIER NOT NULL, 
    [Alignment] VARCHAR(20) NOT NULL, 
    [Portrait] VARCHAR(50) NULL, 
    [Age] INT NULL, 
    [Height] VARCHAR(10) NULL, 
    [Weight] FLOAT NULL, 
    [EyeColor] VARCHAR(15) NULL, 
    [HairColor] NCHAR(10) NULL, 
    [HairStyle] NCHAR(10) NULL
)
