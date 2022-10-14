CREATE TABLE [dbo].[tblCharacterWeaponTypeProficiency]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [WeaponType_Id] VARCHAR(36) NOT NULL, 
    [Character_Id] VARCHAR(36) NOT NULL
)
