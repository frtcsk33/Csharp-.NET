CREATE TABLE [dbo].[Musteriler]
(
	[musteriID] INT NOT NULL PRIMARY KEY, 
    [musteriAdi] VARCHAR(30) NULL, 
    [musteriSoyadi] VARCHAR(30) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([musteriID]), 
    
)
