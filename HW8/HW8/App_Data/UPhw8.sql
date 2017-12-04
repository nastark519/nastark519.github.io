/*constrain every field such as varchar ex. [NamesOf] VARCHAR(40) NOT NULL, ...
so that you can keep tack of whats being pop. into the tables otherwise you
may lose control and you need to be a control freak */
CREATE TABLE dbo.Artist
(
	[ArtistKey] INT IDENTITY(1,1) NOT NULL,
	[ArtistName] VARCHAR (45) NOT NULL,
	[BirthDate] VARCHAR (45) NOT NULL,
	[BirthCity] VARCHAR (45) NOT NULL,
	CONSTRAINT [PK_dbo.Artist] PRIMARY KEY (ArtistKey)
);

CREATE TABLE dbo.ArtWork
(
	[ArtWKey] INT IDENTITY(1,1) NOT NULL,
	[ArtistKey] INT NOT NULL,
	[Title] VARCHAR(80) NOT NULL,
	CONSTRAINT [PK_dbo.ArtWork] PRIMARY KEY (ArtWKey),
	CONSTRAINT [PF_dbo.ArtWork_Artist] FOREIGN KEY (ArtistKey) REFERENCES dbo.Artist (ArtistKey)
);

CREATE TABLE dbo.Genre
(
	GenreKey INT IDENTITY(1,1) NOT NULL,
	GenreName VARCHAR(45) NOT NULL,
	CONSTRAINT [PK_dbo.Genre] PRIMARY KEY (GenreKey)
);

CREATE TABLE dbo.Classification
(
	ClassKey INT IDENTITY(1,1) NOT NULL,
	ArtWKey INT NOT NULL,
	GenreKey INT NOT NULL,
	CONSTRAINT [PK_dbo.Classification] PRIMARY KEY (ClassKey),
	CONSTRAINT [PF_dbo.Classification_ArtWork] FOREIGN KEY (ArtWKey) REFERENCES dbo.ArtWork (ArtWKey),
	CONSTRAINT [PF_dbo.Classification_Genre] FOREIGN KEY (GenreKey) REFERENCES dbo.Genre (GenreKey)
);

INSERT INTO dbo.Artist (ArtistName, BirthDate, BirthCity) VALUES
('M.C. Escher', '1989-06-17', 'Leeuwarden, Netherlands'),
('Leonardo Da Vinci', '1519-05-02', 'Vinci, Italy'),
('Hatip Mehmed Efendi', '1680-11-18', 'Unknown'),
('Salvador Dali', '1904-05-11', 'Figueres, Spain');

INSERT INTO dbo.ArtWork (Title, ArtistKey) VALUES
('Circle Limit III', '1'),
('Twon Tree', '1'),
('Mona Lisa', '2'),
('The Vitruvian Man', '2'),
('Ebru', '3'),
('Honey Is Sweeter Than Blood', '4');

INSERT INTO dbo.Genre(GenreName) VALUES
('Tesselation'),
('Surrealism'),
('Portrait'),
('Renaissance');

INSERT INTO dbo.Classification (ArtWKey, GenreKey) VALUES
('1','1'),
('2','1'),
('2','2'),
('3','3'),
('3','4'),
('4','4'),
('5','1'),
('6','2');
GO
