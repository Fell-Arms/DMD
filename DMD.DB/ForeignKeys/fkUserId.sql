ALTER TABLE [dbo].[Characters]
	ADD CONSTRAINT [fkUserId]
	FOREIGN KEY (UserId)
	REFERENCES [tblUser] (Id)
