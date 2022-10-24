ALTER TABLE [dbo].[tblUserMaps] -- Name of table to add constraint to (tblMap)
	ADD CONSTRAINT [fkMapId-UserMaps] --Name of constraint (fkMapId-Map] indicating connection to tblMap.
	FOREIGN KEY (Map_Id) -- Foreign Key in UserMaps Table.
	REFERENCES [tblMap] (Id) --The table the foreign key is referring to (Map_Id value of tblUserMaps).
GO;
