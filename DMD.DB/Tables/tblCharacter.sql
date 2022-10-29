CREATE TABLE [dbo].[tblCharacter]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [User_Id] UNIQUEIDENTIFIER NOT NULL,
    [Race_Id] UNIQUEIDENTIFIER NOT NULL,
    [CharacterLevel_Id] UNIQUEIDENTIFIER NOT NULL,
    [FirstName] VARCHAR(30) NOT NULL, 
    [LastName] VARCHAR(30) NOT NULL, 
    [MaxHitpoints] INT NOT NULL,
    [CurrentHitpoints] INT NOT NULL,
    [Background] VARCHAR(1000) NULL,
    [Experience] INT NOT NULL,
    [Image] VARCHAR(100)
)
