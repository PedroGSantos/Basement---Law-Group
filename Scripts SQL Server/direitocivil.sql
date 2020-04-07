USE [Basement]
GO

/****** Object:  Table [dbo].[DireitoCivil]    Script Date: 05/09/2017 16:27:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DireitoCivil](
	[Vai_Fazer_Um_Testamento] [nvarchar](50) NOT NULL,
	[Ficha] [nvarchar](50) NOT NULL,
	[Parente_Morto] [nvarchar](50) NOT NULL,
	[Estado_Civil] [nvarchar](50) NOT NULL,
	[Possui_Imovel] [nvarchar](50) NOT NULL,
	[Orçamento] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

