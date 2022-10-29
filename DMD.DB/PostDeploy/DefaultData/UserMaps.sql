BEGIN
	DECLARE @User_Id1 uniqueidentifier, @User_Id2 uniqueidentifier, @User_Id3 uniqueidentifier,
			@Map_Id1 uniqueidentifier, @Map_Id2 uniqueidentifier, @Map_Id3 uniqueidentifier;

	SELECT @User_Id1 = Id FROM tblUser WHERE Username = 'bfoote'
	SELECT @User_Id2 = Id FROM tblUser WHERE Username = 'ketchum'
	SELECT @User_Id3 = Id FROM tblUser WHERE Username = 'admin'

	SELECT @Map_Id1 = Id FROM tblMap WHERE Type = 'Combat'
	SELECT @Map_Id2 = Id FROM tblMap WHERE Type = 'Adventure'
	SELECT @Map_Id3 = Id FROM tblMap WHERE Type = 'Overview'

	INSERT INTO dbo.tblUserMaps (Id, User_Id, Map_Id)
	VALUES
	(NEWID(), @User_Id1, @Map_Id1, 5, 2, 20),
	(NEWID(), @User_Id2, @Map_Id2, 7, 5, 50),
	(NEWID(), @User_Id3, @Map_Id3, 10, 8, 100)
END