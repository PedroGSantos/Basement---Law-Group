USE [Basement]
GO

/****** Object:  Table [dbo].[DireitoComercial]    Script Date: 05/09/2017 16:27:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DireitoComercial](
	[Empresa] [nvarchar](50) NOT NULL,
	[Multinacional] [nvarchar](50) NOT NULL,
	[Conflitos_com_outras_empresas] [nvarchar](50) NOT NULL,
	[Conflitos_com_o_governo] [nvarchar](50) NOT NULL,
	[Sociedade] [nvarchar](50) NOT NULL,
	[Orçamento] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

