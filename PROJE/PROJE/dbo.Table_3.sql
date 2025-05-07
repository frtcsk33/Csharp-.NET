CREATE TABLE [dbo].[Bilet]
(
	[biletID] INT NOT NULL PRIMARY KEY, 
    [filmID] INT NOT NULL, 
    [musteriID] INT NOT NULL, 
    [salonID] INT NOT NULL, 
    [biletTarih] DATE NULL, 
    [biletSaat] DATETIME NULL, 
    [koltukNo] INT NULL, 
    [biletFiyat] INT NULL
)
