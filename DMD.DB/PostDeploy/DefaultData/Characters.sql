BEGIN
	DECLARE 
			@User_Id1 uniqueidentifier, @User_Id2 uniqueidentifier, @User_Id3 uniqueidentifier,
			@Race_Id1 uniqueidentifier, @Race_Id2 uniqueidentifier, @Race_Id3 uniqueidentifier, 
			@CharacterLevel_Id1 uniqueidentifier, @CharacterLevel_Id2 uniqueidentifier, @CharacterLevel_Id3 uniqueidentifier;

	SELECT @User_Id1 = Id FROM tblUser WHERE Username = 'ketchum'
	SELECT @User_Id2 = Id FROM tblUser WHERE Username = 'bfoote'
	SELECT @User_Id3 = Id FROM tblUser WHERE Username = 'admin'

	SELECT @Race_Id1 = Id FROM tblRace WHERE Name = 'Dwarf'
	SELECT @Race_Id2 = Id FROM tblRace WHERE Name = 'Elf'
	SELECT @Race_Id3 = Id FROM tblRace WHERE Name = 'Human'

	SELECT @CharacterLevel_Id1 = Id FROM tblCharacterLevel WHERE Level = 1
	SELECT @CharacterLevel_Id2 = Id FROM tblCharacterLevel WHERE Level = 2
	SELECT @CharacterLevel_Id3 = Id FROM tblCharacterLevel WHERE Level = 3


	INSERT INTO dbo.tblCharacter (Id, User_Id, Race_Id, CharacterLevel_Id, FirstName, LastName, MaxHitpoints, CurrentHitpoints, Background, Experience, Image)
	VALUES
	(NEWID(), @User_Id1, @Race_Id1, @CharacterLevel_Id1, 'Bobby', 'Bobbinson', 18, 3, 
	'Lone dwarf who traveled around the world in utter misfortune. Happened across a god of blacksmithing who convinced him to take up adventuring.', 20, 'bobby-bobbinson.png' ),

	(NEWID(), @User_Id2, @Race_Id2, @CharacterLevel_Id2, 'Meatball', 'Gravydog', 18, 3, 
	'Shunned from the elven community, Meatball Gravydog took up residence with the trolls and received a new name.', 50, 'meatball-gravydog.png' ),

	(NEWID(), @User_Id3, @Race_Id3, @CharacterLevel_Id3, 'Synthia', 'Greywall', 18, 3, 
	'A hero from the north, Synthia travels to spread her name and create a vast fortune for an early retirement.', 200, 'synthia-greywall.png' )
END