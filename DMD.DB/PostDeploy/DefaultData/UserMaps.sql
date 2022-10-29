BEGIN
	DECLARE @User_Id201 uniqueidentifier, @User_Id202 uniqueidentifier, @User_Id203 uniqueidentifier,
			@Map_Id201 uniqueidentifier, @Map_Id202 uniqueidentifier, @Map_Id203 uniqueidentifier;

	SELECT @User_Id201 = Id FROM tblUser WHERE Username = 'bfoote'
	SELECT @User_Id202 = Id FROM tblUser WHERE Username = 'ketchum'
	SELECT @User_Id203 = Id FROM tblUser WHERE Username = 'admin'

	SELECT @Map_Id201 = Id FROM tblMap WHERE Type = 'Combat'
	SELECT @Map_Id202 = Id FROM tblMap WHERE Type = 'Adventure'
	SELECT @Map_Id203 = Id FROM tblMap WHERE Type = 'Overview'

	INSERT INTO dbo.tblUserMaps (Id, User_Id, Map_Id)
	VALUES
	(NEWID(), @User_Id201, @Map_Id201),
	(NEWID(), @User_Id202, @Map_Id202),
	(NEWID(), @User_Id203, @Map_Id203)
END