CREATE TABLE [dbo].[stuff]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[dateOfBirth] DATE NOT NULL,
	[newAddress] NVARCHAR (200) NOT NULL,
	[county] NVARCHAR (45) NOT NULL,
	[theirName] NVARCHAR (45) NOT NULL,
	[city] NVARCHAR (45) NOT NULL,
	[newState] NVARCHAR (30) NOT NULL,
	[zip] INT (25) NOT NULL,
	[signDate] DATE NOT NULL
);