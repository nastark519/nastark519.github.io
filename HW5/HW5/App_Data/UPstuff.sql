CREATE TABLE [dbo].[stuff]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[DateOfBirth] DATE NOT NULL,
	[NewAddress] VARCHAR (200) NOT NULL,
	[County] VARCHAR (45) NOT NULL,
	[FullName] VARCHAR (45) NOT NULL,
	[City] VARCHAR (45) NOT NULL,
	[NewState] VARCHAR (30) NULL,
	[Zip] INT (25) NOT NULL,
	[SignDate] DATE NOT NULL
);

INSERT INTO dbo.Addresses (ID, DateOfBirth, NewAddress, County, FullName, City, NewState, Zip, SignDate) VALUES
(12345, '03/16/1990', 'Tower of the Hand', 'The Reach', 'Nathan Stark', 'Kings Landing', 'GOT', 97239, '09/27/2011'),
(12346, '03/16/1991', '221B Baker Street', 'London', 'Amanda Stark', 'London', 'UK', 99999, '09/27/2015'),
(12347, '09/27/1960', '2607 SW Sunset Blvd.', 'Multnoma', 'John Stark', 'Portland', 'OR', 98899, '05/10/1991'),
(12348, '09/27/1960', '2608 SW Sunset Blvd.', 'Multnoma', 'Dagny Ann Stark', 'Portland', 'OR', 98799, '05/10/2016'),
(12349, '09/27/1980', '2609 SW Sunset Blvd.', 'Multnoma', 'J. Tyler Stark', 'Portland', 'CA', 98699, '05/10/1991')
GO


