ALTER TABLE [dbo].[Characters] -- Name of table to add constraint to (Characters)
	ADD CONSTRAINT [fkUserId-Characters] -- The name of the constraint ("fkUserId-Characters") - indicating a foreign key of UserId in the Characters table.
	FOREIGN KEY (UserId) -- the foreign key
	REFERENCES [tblUser] (Id) -- the table the foreign key is in.
GO;