

# Home Work Five


### Starting point

+ My first step was to make the database's single table in the up.sql file and then add in the down file that drops the table.

```sql
CREATE TABLE [dbo].[stuff]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[dateOfBirth] DATE NOT NULL,
	[newAddress] VARCHAR (200) NOT NULL,
	[county] VARCHAR (45) NOT NULL,
	[fullName] VARCHAR (45) NOT NULL,
	[city] VARCHAR (45) NOT NULL,
	[newState] VARCHAR (30) NOT NULL,
	[zip] INT (25) NOT NULL,
	[signDate] DATE NOT NULL
);

INSERT INTO dbo.Addresses (Id, dateOfBirth, newAddress, county, fullName, city, newState, zip, signDate) VALUES
(12345, '03/16/1990', 'Tower of the Hand', 'The Reach', 'Nathan Stark', 'Kings Landing', 'GOT', 97239, '09/27/2011'),
(12346, '03/16/1991', '221B Baker Street', 'London', 'Amanda Stark', 'London', 'UK', 99999, '09/27/2015'),
(12347, '09/27/1960', '2607 SW Sunset Blvd.', 'Multnoma', 'John Stark', 'Portland', 'OR', 98899, '05/10/1991'),
(12348, '09/27/1960', '2608 SW Sunset Blvd.', 'Multnoma', 'Dagny Ann Stark', 'Portland', 'OR', 98799, '05/10/2016'),
(12349, '09/27/1980', '2609 SW Sunset Blvd.', 'Multnoma', 'J. Tyler Stark', 'Portland', 'CA', 98699, '05/10/1991')
GO
```
+ and the down file is a simple

```sql
DROP TABLE dbo.UPstuff;
```
+ I did this in notepad++ and then added it to my project in VS.

+ Having downloaded the data storage when I downloaded VS I'm using the LocalDB.

### Working with the Database.

+ added the connection string  to `Web.config`

```xml
<connectionStrings>
    <add name="DbStuff" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nstar\Desktop\CS\460\homework460\HW5\HW5\App_Data\DMVDatabase1.mdf;Integrated Security=True" providerName="System.Data.SqlClient"/>
</connectionStrings>
```



