ALTER TABLE [dbo].[tblCharacterCurrency] -- Name of table to add constraint.
	ADD CONSTRAINT [fkCurrencyId-Currency] --Name of constraint "fkCurrencyID-Currency" indicating connection to Currency table.
	FOREIGN KEY (Currency_Id) -- Foreign key in the CharacterCurrency Table
	REFERENCES [tblCurrency] (Id) -- The table foreign key is referring to (primary key of tblCurrency]
GO;