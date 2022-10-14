CREATE TABLE [dbo].[tblCharacterLevel]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Level] INT NOT NULL, 
    [Experience] INT NOT NULL, 
    [ProficencyBonus] INT NOT NULL
)
