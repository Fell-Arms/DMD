CREATE TABLE [dbo].[Characters]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(30) NOT NULL, 
    [LastName] VARCHAR(30) NOT NULL, 
    [Race] VARCHAR(20) NOT NULL, 
    [Class] VARCHAR(20) NOT NULL, 
    [Level] INT NOT NULL, 
    [ArmorClass] INT NOT NULL, 
    [MaxHealth] NCHAR(10) NULL, 
    [CurrentHealth] NCHAR(10) NULL
)
