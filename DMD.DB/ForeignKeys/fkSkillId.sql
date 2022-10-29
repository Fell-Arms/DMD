--CharacterSkillProficiency - Skill Table Connection
ALTER TABLE [dbo].[tblCharacterSkillProficiency]
	ADD CONSTRAINT [fkSkillId-CharacterSkillProficiency]
	FOREIGN KEY (Skill_Id)
	REFERENCES [tblSkill] (Id)
GO;

