USE [master]
GO
/****** Object:  Database [EntityFrameworkValidation]    Script Date: 8/13/2019 1:06:23 PM ******/
CREATE DATABASE [EntityFrameworkValidation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntityFrameworkValidation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EntityFrameworkValidation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EntityFrameworkValidation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EntityFrameworkValidation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EntityFrameworkValidation] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EntityFrameworkValidation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EntityFrameworkValidation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET ARITHABORT OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EntityFrameworkValidation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EntityFrameworkValidation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EntityFrameworkValidation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EntityFrameworkValidation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EntityFrameworkValidation] SET  MULTI_USER 
GO
ALTER DATABASE [EntityFrameworkValidation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EntityFrameworkValidation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EntityFrameworkValidation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EntityFrameworkValidation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EntityFrameworkValidation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EntityFrameworkValidation] SET QUERY_STORE = OFF
GO
USE [EntityFrameworkValidation]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 8/13/2019 1:06:23 PM ******/
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
/****** Object:  Table [dbo].[MemberList]    Script Date: 8/13/2019 1:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Active] [bit] NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Gender] [int] NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[State] [nvarchar](max) NOT NULL,
	[Country] [nvarchar](max) NOT NULL,
	[JoinDate] [datetime2](7) NOT NULL,
	[ContactPhone] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MemberList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberList1]    Script Date: 8/13/2019 1:06:24 PM ******/
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
	[ContactPhone] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Id], [Name]) VALUES (1, N'Female')
INSERT [dbo].[Gender] ([Id], [Name]) VALUES (2, N'Male')
INSERT [dbo].[Gender] ([Id], [Name]) VALUES (3, N'Other')
SET IDENTITY_INSERT [dbo].[Gender] OFF
SET IDENTITY_INSERT [dbo].[MemberList] ON 

INSERT [dbo].[MemberList] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (1, 1, N'Karen', N'Payne', 1, N'111 Maple Lane', N'Portland', N'OR', N'USA', CAST(N'2015-07-04T00:00:00.0000000' AS DateTime2), N'5418973482')
INSERT [dbo].[MemberList] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (2, 0, N'Bill', N'Smith', 2, N'2 Mary Court', N'Grans Pass', N'OR', N'USA', CAST(N'2015-07-14T00:00:00.0000000' AS DateTime2), N'1234320987')
INSERT [dbo].[MemberList] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (4, 1, N'Mary', N'Jones', 1, N'45 Checker Lane', N'Salem', N'OR', N'USA', CAST(N'2017-08-07T00:00:00.0000000' AS DateTime2), N'5556661234')
SET IDENTITY_INSERT [dbo].[MemberList] OFF
SET IDENTITY_INSERT [dbo].[MemberList1] ON 

INSERT [dbo].[MemberList1] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (1, 1, N'Karen', N'Payne', 1, N'111 Maple Lane', N'Portland', N'OR', N'USA', CAST(N'2015-07-04T00:00:00.0000000' AS DateTime2), N'5418973482')
INSERT [dbo].[MemberList1] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (2, 0, N'Bill', N'Smith', 2, N'2 Mary Court', N'Grans Pass', N'OR', N'USA', CAST(N'2015-07-14T00:00:00.0000000' AS DateTime2), N'1234320987')
INSERT [dbo].[MemberList1] ([Id], [Active], [FirstName], [LastName], [Gender], [Street], [City], [State], [Country], [JoinDate], [ContactPhone]) VALUES (4, 1, N'Mary', N'Jones', 1, N'45 Checker Lane', N'Salem', N'OR', N'USA', CAST(N'2017-08-07T00:00:00.0000000' AS DateTime2), N'5556661234')
SET IDENTITY_INSERT [dbo].[MemberList1] OFF
ALTER TABLE [dbo].[MemberList]  WITH CHECK ADD  CONSTRAINT [FK_MemberList_Gender] FOREIGN KEY([Gender])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[MemberList] CHECK CONSTRAINT [FK_MemberList_Gender]
GO
ALTER TABLE [dbo].[MemberList1]  WITH CHECK ADD  CONSTRAINT [FK_MemberList1_Gender] FOREIGN KEY([Gender])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[MemberList1] CHECK CONSTRAINT [FK_MemberList1_Gender]
GO
USE [master]
GO
ALTER DATABASE [EntityFrameworkValidation] SET  READ_WRITE 
GO
