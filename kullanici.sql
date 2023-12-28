USE [yazılımyapımı]
GO

/****** Object:  Table [dbo].[kullanici]    Script Date: 18.05.2022 16:07:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[kullanici](
	[email] [nvarchar](50) NOT NULL,
	[şifre] [nvarchar](50) NOT NULL,
	[soru] [nvarchar](max) NOT NULL,
	[cevap] [nvarchar](max) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adi] [nchar](10) NOT NULL,
	[soyadi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_kullanici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


