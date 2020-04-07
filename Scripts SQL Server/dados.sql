USE [Basement]
GO

/****** Object:  Table [dbo].[Dados]    Script Date: 05/09/2017 16:26:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dados](
	[Nome] [nvarchar](50) NOT NULL,
	[CPF] [nvarchar](50) NOT NULL,
	[RG] [nvarchar](50) NOT NULL,
	[Telefone] [nvarchar](50) NOT NULL,
	[Cidade] [nvarchar](50) NOT NULL,
	[Profissão] [nvarchar](50) NOT NULL,
	[CNPJ] [nvarchar](50) NOT NULL,
	[Data] [nvarchar](50) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

