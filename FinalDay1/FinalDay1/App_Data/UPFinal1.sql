/*constrain every field such as varchar ex. [NamesOf] VARCHAR(40) NOT NULL, ...
so that you can keep tack of whats being pop. into the tables otherwise you
may lose control and you need to be a control freak */
CREATE TABLE dbo.Buyer
(
	[BuyerID] INT IDENTITY(1,1) NOT NULL,
	[BuyerName] VARCHAR (45) NOT NULL,
	CONSTRAINT [PK_dbo.Buyer] PRIMARY KEY (BuyerID)
);

CREATE TABLE dbo.Seller
(
	[SellerID] INT IDENTITY(1,1) NOT NULL,
	[SellerName] VARCHAR (45) NOT NULL,
	CONSTRAINT [PK_dbo.Seller] PRIMARY KEY (SellerID)
);

CREATE TABLE dbo.Item
(
	[ItemID] INT IDENTITY(1001,1) NOT NULL,
	[SellerID] INT NOT NULL,
	[ItemName] VARCHAR(90) NOT NULL,
	[Description] VARCHAR(200) NOT NULL,
	CONSTRAINT [PK_dbo.Item] PRIMARY KEY (ItemID),
	CONSTRAINT [FK_dbo.Item_Seller] FOREIGN KEY (SellerID) REFERENCES dbo.Seller (SellerID)
);


CREATE TABLE dbo.Bid
(
	BidID INT IDENTITY(1,1) NOT NULL,
	ItemID INT NOT NULL,
	BuyerID INT NOT NULL,
	Price INT NOT NULL,
	TimeStam DATETIME NOT NULL,
	CONSTRAINT [PK_dbo.Bid] PRIMARY KEY (BidID),
	CONSTRAINT [FK_dbo.Bid_Item] FOREIGN KEY (ItemID) REFERENCES dbo.Item (ItemID),
	CONSTRAINT [FK_dbo.Bid_Buyer] FOREIGN KEY (BuyerID) REFERENCES dbo.Buyer (BuyerID)
);

INSERT INTO dbo.Buyer (BuyerName) VALUES
('Jane Stone'),
('Tom McMasters'),
('Otto Vanderwall');

INSERT INTO dbo.Seller (SellerName) VALUES
('Gayle Hardy'),
('Lyle Banks'),
('Pearl Greene');

INSERT INTO dbo.Item (ItemName, Description, SellerID) VALUES
('Abraham Lincoln Hammer', 'A bench mallet fashioned from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln', '3'),
('Albert Einsteins Telescope', 'A brass telescope owned by Albert Einstein in Germany, circa 1927', '1'),
('Bob Dylan Love Poems', 'Five versions of an original unpublished, handwritten, love poem by Bob Dylan', '2');


INSERT INTO dbo.Bid (ItemID, BuyerID, Price, TimeStam) VALUES
('1001', '3',250000,'12/04/2017 09:04:22'),
('1003', '1',95000 ,'12/04/2017 08:44:03');
GO