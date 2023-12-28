USE [yazılımyapımı]
GO

/****** Object:  Table [dbo].[ogrenci]    Script Date: 18.05.2022 16:11:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ogrenci](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adi] [nchar](12) NOT NULL,
	[soyadi] [nchar](12) NOT NULL,
	[mail] [nchar](50) NOT NULL,
	[puan] [float] NULL,
	[sifre] [nchar](50) NOT NULL,
	[kullanci_adi] [nchar](50) NULL,
	[soru] [nvarchar](max) NOT NULL,
	[cevap] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ogrenci] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


