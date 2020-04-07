USE [Basement]
GO

/****** Object:  Table [dbo].[DireitoPenal]    Script Date: 05/09/2017 16:27:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DireitoPenal](
	[Ficha] [nvarchar](50) NOT NULL,
	[Conflito_com_o_Governo] [nvarchar](50) NOT NULL,
	[Cometeu_Algum_Crime] [nvarchar](50) NOT NULL,
	[Julgamento] [nvarchar](50) NOT NULL,
	[Impedido_De_Viajar] [nvarchar](50) NOT NULL,
	[Orçamento] [nvarchar](50) NOT NULL,
	[Cumplices] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

