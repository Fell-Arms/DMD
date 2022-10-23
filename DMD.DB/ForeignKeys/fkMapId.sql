ALTER TABLE [dbo].[tblMap] -- Name of table to add constraint to (tblMap)
	ADD CONSTRAINT [fkMapId-Map] --Name of constraint (fkMapId-Map] indicating connection to tblMap.
	FOREIGN KEY (Id) -- Foreign Key in UserMaps Table.
	REFERENCES [tblUserMaps] (Map_Id) --The table the foreign key is referring to (Map_Id value of tblUserMaps).
GO;
