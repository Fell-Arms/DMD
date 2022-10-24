-- Character to User Connection
ALTER TABLE [dbo].[Characters] -- Name of table to add constraint to (Characters)
	ADD CONSTRAINT [fkUserId-Characters] -- The name of the constraint ("fkUserId-Characters") - indicating a foreign key constraint of UserId in the Characters table.
	FOREIGN KEY (User_Id) -- the foreign key in the Characters table
	REFERENCES [tblUser] (Id) -- the table the foreign key is referring to (The primary key of tblUser is the foreign key in Characters).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.

--User To User Maps Connection
ALTER TABLE [dbo].[tblUserMaps] -- Name of table to add constraint to (UserMaps)
	ADD CONSTRAINT [fkUserId-UserMaps] -- The name of the constraint ("fkUserId-UserMaps") - indicating a foreign key constraint of UserId in the UserMaps table.
	FOREIGN KEY (User_Id) -- the foreign key in the UserMaps Table
	REFERENCES [tblUser] (Id) -- the table the foreign key is referring to (The primary key of tblUser is the foreign key in Characters).
GO; -- indicates this part is done, you can repeat this and GO; onto the next statement.



--REMOVE THIS ONE. NEEDS TO BE CHANGED TO REFERENCE CHARACTER ID.
