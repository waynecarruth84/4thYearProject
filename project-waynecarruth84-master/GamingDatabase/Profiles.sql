CREATE TABLE [dbo].[Profiles]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SummonerName] VARCHAR(50) NULL, 
    [UserId] INT NOT NULL, 
    [Icon] NCHAR(10) NULL, 
    [Level] INT NOT NULL, 
    CONSTRAINT [FK_Profiles_ToTable] FOREIGN KEY (UserId) REFERENCES Users(Id) 
)
