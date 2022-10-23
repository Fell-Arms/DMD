--CharacterLanguages to Language Connection
ALTER TABLE [dbo].[tblCharacterLanguages]
	ADD CONSTRAINT [fkLanguageId-Language]
	FOREIGN KEY (Language_Id)
	REFERENCES [tblLanguage] (Id)
