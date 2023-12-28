USE [yazılımyapımı]
GO

/****** Object:  Table [dbo].[sonuc]    Script Date: 18.05.2022 16:11:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sonuc](
	[ogrenci_id] [int] NOT NULL,
	[dogru_soru_sayisi] [int] NOT NULL,
	[yanlis_soru_sayisi] [int] NOT NULL,
	[bos_soru_sayisi] [int] NOT NULL,
	[toplam_puan] [float] NULL,
	[ogrenci_adi] [nchar](50) NOT NULL
) ON [PRIMARY]
GO


