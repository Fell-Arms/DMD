CREATE TABLE [dbo].[tblCharacterCurrency]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Curreny_Id] VARCHAR(36) NOT NULL, 
    [Character_Id] VARCHAR(36) NOT NULL, 
    [Amount] INT NOT NULL
)
