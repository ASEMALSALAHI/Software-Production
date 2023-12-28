USE [yazılımyapımı]
GO

/****** Object:  Table [dbo].[soru_tbl]    Script Date: 18.05.2022 16:12:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[soru_tbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[soru_photo] [image] NOT NULL,
	[soru_cevap] [nvarchar](50) NOT NULL,
	[soru_puan] [int] NOT NULL,
	[konu_adi] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_soru_tbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


