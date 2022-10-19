USE [dbLogin]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 16.10.2022 23:35:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usr] [nvarchar](50) NULL,
	[pwd] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON 

INSERT [dbo].[tblUser] ([id], [usr], [pwd], [name]) VALUES (1, N'sa', N'1234', N'Sabri Uzun')
INSERT [dbo].[tblUser] ([id], [usr], [pwd], [name]) VALUES (2, N'admin', N'1234', N'Aysel Kısa')
INSERT [dbo].[tblUser] ([id], [usr], [pwd], [name]) VALUES (3, N'Veysel', N'2345', N'Veysel Perü')
SET IDENTITY_INSERT [dbo].[tblUser] OFF
USE [master]
GO
ALTER DATABASE [dbLogin] SET  READ_WRITE 
GO