# Counting
Exam

Execute to create the table of the sql server

USE [Exam]
GO

/****** Object:  Table [dbo].[Incrementer]    Script Date: 06/29/2016 18:44:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Incrementer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_Incrementer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Incrementer] ADD  DEFAULT ((0)) FOR [Count]
GO


