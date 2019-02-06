USE [Users]
GO

/****** Object:  Table [dbo].[Test]    Script Date: 5/2/2019 15:46:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON

GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[surname] [varchar](50) NULL,
	[email] [varchar](70) NOT NULL,
	[password] [varchar](70) NOT NULL,
	CONSTRAINT PK_Id_Key PRIMARY KEY CLUSTERED (id)
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


