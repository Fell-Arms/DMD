CREATE TABLE [dbo].[tblCharacterSkillProficiency]
( 
    [Character_Id] UNIQUEIDENTIFIER NOT NULL,
    [Skill_Id] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT PK_CharacterSkill PRIMARY KEY (Character_Id, Skill_Id)
)
