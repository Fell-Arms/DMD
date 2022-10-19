ALTER TABLE [dbo].[Characters] -- Name of table to add constraint to (Characters)
	ADD CONSTRAINT [fkUserId-Characters] -- The name of the constraint ("fkUserId-Characters") - indicating a foreign key constraint of UserId in the Characters table.
	FOREIGN KEY (UserId) -- the foreign key in the Characters table
	REFERENCES [tblUser] (Id) -- the table the foreign key is referring to (The primary key of tblUser is the foreign key in Characters).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.