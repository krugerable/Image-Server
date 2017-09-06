CREATE TABLE [dbo].[tblFiles]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [dtCreated] DATETIME NULL DEFAULT GetDate(), 
    [binFile] VARBINARY(MAX) NULL
)
