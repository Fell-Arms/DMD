CREATE TABLE [dbo].[tblCharacterSkillProficiency]
( 
    --[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    [Character_Id] UNIQUEIDENTIFIER NOT NULL,
    [Skill_Id] UNIQUEIDENTIFIER NOT NULL,
    [IsProficient] BIT NULL
    CONSTRAINT PK_CharacterSkillProficiency PRIMARY KEY (Character_Id, Skill_Id)
)
