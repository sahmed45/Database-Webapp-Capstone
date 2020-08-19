CREATE TABLE [dbo].[PDFFiles] (
    [id]   INT             IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (50)    NULL,
    [type] NVARCHAR (200)  NULL,
	    [Project_ID]     INT          NULL,

    [data] VARBINARY (MAX) NULL
	    FOREIGN KEY ([Project_ID]) REFERENCES [dbo].[Projects] ([Project_ID])

);

