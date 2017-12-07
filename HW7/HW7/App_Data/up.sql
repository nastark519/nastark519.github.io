create table log (
	id int identity(0,1) primary key,
	IPAddress nvarchar(128) not null,
	AgentString nvarchar(1024) not null,
	SearchTerm nvarchar(255) not null
);
