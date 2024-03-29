USE [EntityFrameworkValidation]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 8/14/2019 1:41:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberList1]    Script Date: 8/14/2019 1:41:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberList1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Active] [bit] NOT NULL,
	[FirstName] [nvarchar](10) NOT NULL,
	[LastName] [nvarchar](10) NOT NULL,
	[Gender] [int] NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[State] [nvarchar](max) NOT NULL,
	[Country] [nvarchar](max) NOT NULL,
	[JoinDate] [datetime2](7) NOT NULL,
	[ContactPhone] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MemberList1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Id], [Name]) VALUES (1, N'Female')
INSERT [dbo].[Gender] ([Id], [Name]) VALUES (2, N'Male')
INSERT [dbo].[Gender] ([Id], [Name]) VALUES (3, N'Other')
SET IDENTITY_INSERT [dbo].[Gender] OFF
SET IDENTITY_INSERT [dbo].[MemberList1] ON 

INSERT [dbo].[MemberList1] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (1, 1, N'Karen', N'Payne', 1, N'111 Maple Lane', N'Portland', N'OR', N'USA', CAST(N'2015-07-04T00:00:00.0000000' AS DateTime2), N'5418973482')
INSERT [dbo].[MemberList1] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (2, 0, N'Bill', N'Smith', 2, N'2 Mary Court', N'Grans Pass', N'OR', N'USA', CAST(N'2015-07-14T00:00:00.0000000' AS DateTime2), N'1234320987')
INSERT [dbo].[MemberList1] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (4, 1, N'Mary', N'Jones', 1, N'45 Checker Lane', N'Salem', N'OR', N'USA', CAST(N'2017-08-07T00:00:00.0000000' AS DateTime2), N'5556661234')
SET IDENTITY_INSERT [dbo].[MemberList1] OFF
ALTER TABLE [dbo].[MemberList1]  WITH CHECK ADD  CONSTRAINT [FK_MemberList1_Gender] FOREIGN KEY([Gender])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[MemberList1] CHECK CONSTRAINT [FK_MemberList1_Gender]
GO
