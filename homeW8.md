
# Home Work Eight 


### Strating

+ I began with Opening a new MVC Web App. using Visual Studio.

+ I then moved right in to creating my Database schema.

    + I always like to draw out my E-R diagram by hand becuase, changes are easily done and thought out, this is especially true when the data model is small.

    + I have provided the instructor with the origenal copy of this diagram.

    + Below is the up and the down files that I used for the relational table.

+ Here is the Up SQL file with the seed data inclueded.

```sql

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

```

+ Here below is the DOWN file note that the order of the tables being dropped is important, as you must drop the tables with Foreign keys first to avoid any errors in the opperation.

```sql

DROP TABLE dbo.Classification;
DROP TABLE dbo.Genre;
DROP TABLE dbo.ArtWork;
DROP TABLE dbo.Artist;

GO

```

+ From there it was just a matter of connecting to the local Datatbase that I had set up and running my script.

+ I also may mentchen that I have been using `git add .`, `git commit -m "some message"`, to my project's process saved, aswell as using `git push` to save it remaotely.

+ I then used Visual Studio to genrate my CRUD functionality for Artists.

    + I did this by going into my "Solution Explorer" scrolling down to the "Models" folder `right clicking` selecting `new item...`
    + This opened up a new window from wwich I selected from the "Data" link on the left I was then presented with a list of choises from which I chose "ADO.NET Entity Data Model"
    + I then entered the information needed for my context class.

+ I then added attribute checking to my Edit page.

    + Below is a check in the Model to so that the name is not longer than 50 characters.

```c#

	[Required]
	[StringLength(45)]
	public string ArtistName { get; set; }
```

    + To make sure that the birthday couldn't be in the future I added in a lot of code in the controller inorder to parse through the string and to and check that it is a proper input.

```c#
//Vareables to check the date and compare for non-sencical dates.
	int toDateY = DateTime.Now.Year;
	int toDateM = DateTime.Now.Month;
	int toDateD = DateTime.Now.Day;
	// artBY => Artist birth year ect. ect.
	int artBY, artBM, artBD;

	string[] artDates = artist.BirthDate.Split('-');
	// they will only parse if valide enteries
	if (int.TryParse(artDates[0], out artBY)) { }
	else
	{
		artBY = 9999;
	}
	if (int.TryParse(artDates[1], out artBM)) { }
	else
	{
		artBM = 99;
	}
	if (int.TryParse(artDates[2], out artBD)) { }
	else
	{
		artBD = 99;
	}


	if (artBY > toDateY)
	{
		TempData["testmsg"] = "<script>alert('This is an invalide date.');</script>";
		return View();

	}
	else if ((artBY == toDateY) && (artBM > toDateM))
	{
		TempData["testmsg"] = "<script>alert('This is an invalide date.');</script>";
		return View();

	}
	else if ((artBY == toDateY) && (artBM == toDateM) && (artBD > toDateD))
	{
		TempData["testtmsg"] = "<script>alert('This is an invalide date.');</script>";
		return View();
	}
	else if (ModelState.IsValid)
	{
		db.Artists.Add(artist);
		db.SaveChanges();
		return RedirectToAction("Index");
	}

```

+ Below is the Ajax.

```javascript

function Ajax(id) {
    var source = "/Artists/Genre/" + id;
    console.log(source);
    $.ajax({
        type: "GET",
        dataType: "json",
        data: { id: id },
        url: source,
        success: displayResults,
        error: errorOnAjax
    });
}

function displayResults(data) {
    console.log("AJAX Success!");
    console.log(data);

    $('#results').empty();

    //var item = document.getElementById("results");
    $("#results").append("<p><ul>");
    $.each(data, function (i, item) {
        $("#results").append(
            "<li>" + item["title"] + " by " + item["artist"] +"</li>"
        );
    });
    $("#results").append("</ul></p>");

}

function errorOnAjax() {
    console.log("Error");
}

```













