﻿CREATE TABLE [dbo].[Message]
(
	[IdMessage] INT NOT NULL IDENTITY,
	Nom NVARCHAR(50) NOT NULL,
	Email NVARCHAR(323) NOT NULL,
	Phone NVARCHAR(12) NOT NULL,
	[Subject] NVARCHAR(150) NOT NULL,
	Information NVARCHAR(MAX) NOT NULL, 
	[DateEnvoie] DATETIME NOT NULL 
	PRIMARY KEY CLUSTERED ([IdMessage] ASC),
)