USE [TelefonRehber]
GO
/****** Object:  Table [dbo].[Table_Rehber]    Script Date: 31.05.2023 20:27:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Rehber](
	[İd] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](20) NULL,
	[Soyad] [varchar](20) NULL,
	[Telefon] [char](10) NULL,
	[Mail] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Rehber] PRIMARY KEY CLUSTERED 
(
	[İd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_Rehber] ON 

INSERT [dbo].[Table_Rehber] ([İd], [Ad], [Soyad], [Telefon], [Mail]) VALUES (36, N'w', N'wd', N'3333333333', N'33e')
SET IDENTITY_INSERT [dbo].[Table_Rehber] OFF
GO
