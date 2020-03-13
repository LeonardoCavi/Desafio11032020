USE [master]
GO

IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'DB_IMC')
DROP DATABASE DB_IMC;
GO

CREATE DATABASE [DB_IMC]
GO

USE [DB_IMC]
GO

SET ANSI_NULLS ON
GO 
SET QUOTED_IDENTIFIER ON
GO
SET LANGUAGE us_english
GO

CREATE TABLE [dbo].[TB_IMC]
([IMC_ID] [INT] IDENTITY(1,1) NOT NULL,
[IMC_NOME] [VARCHAR] (150) NOT NULL,
[IMC_IDADE] [INT] NOT NULL,
[IMC_PESO] [REAL] NOT NULL,
[IMC_ALTURA] [REAL] NOT NULL,
[IMC_IMC] [REAL] NOT NULL,
CONSTRAINT [PK_IMC] PRIMARY KEY CLUSTERED
([IMC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
