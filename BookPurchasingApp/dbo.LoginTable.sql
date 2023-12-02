CREATE TABLE [dbo].[LoginTable] (
    [Username] INT          IDENTITY (100, 1) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

