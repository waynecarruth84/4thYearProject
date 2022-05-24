CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FullName] VARCHAR(50) NULL, 
    [Date of Birth] DATE NOT NULL, 
    [SummonerName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Password] NCHAR(10) NULL 
)
