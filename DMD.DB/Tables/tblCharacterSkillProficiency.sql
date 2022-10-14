CREATE TABLE [dbo].[tblCharacterSkillProficiency]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Skill_Id] VARCHAR(36) NOT NULL, 
    [Character_Id] VARCHAR(36) NOT NULL
)
