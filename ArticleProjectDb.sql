USE [master]
GO
/****** Object:  Database [ArticleProjectDb]    Script Date: 6.09.2020 16:04:28 ******/
CREATE DATABASE [ArticleProjectDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ArticleProjectDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ArticleProjectDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ArticleProjectDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ArticleProjectDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ArticleProjectDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ArticleProjectDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ArticleProjectDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ArticleProjectDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ArticleProjectDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ArticleProjectDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ArticleProjectDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ArticleProjectDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ArticleProjectDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ArticleProjectDb] SET  MULTI_USER 
GO
ALTER DATABASE [ArticleProjectDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ArticleProjectDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ArticleProjectDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ArticleProjectDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ArticleProjectDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ArticleProjectDb] SET QUERY_STORE = OFF
GO
USE [ArticleProjectDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6.09.2020 16:04:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 6.09.2020 16:04:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedDate] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 6.09.2020 16:04:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedDate] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](max) NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PostID] [int] NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 6.09.2020 16:04:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedDate] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NOT NULL,
	[PostID] [int] NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 6.09.2020 16:04:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedDate] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CategoryID] [int] NOT NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200905170630_Mig1', N'3.1.7')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Title], [Description]) VALUES (1, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Yazılım', N'Yazılıma Dair Her Şey')
INSERT [dbo].[Categories] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Title], [Description]) VALUES (2, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Spor', N'Spora Dair Her Şey')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [FullName], [Email], [PostID]) VALUES (1, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Kadir DİNÇ', N'kadirdinc34@gmail.com', 1)
INSERT [dbo].[Comments] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [FullName], [Email], [PostID]) VALUES (2, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Kadir DİNÇ', N'kadirdinc34@gmail.com', 3)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Description], [ImageUrl], [PostID]) VALUES (1, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Yazılım Hayattır', N'../yazilim.jpg', 1)
INSERT [dbo].[Images] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Description], [ImageUrl], [PostID]) VALUES (2, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'DÖRT BÜYÜKLER LOGO', N'../dortBuyukler.jpg', 3)
SET IDENTITY_INSERT [dbo].[Images] OFF
GO
SET IDENTITY_INSERT [dbo].[Posts] ON 

INSERT [dbo].[Posts] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Title], [Description], [CategoryID]) VALUES (1, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Yazılıma Başlangıç', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', 1)
INSERT [dbo].[Posts] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Title], [Description], [CategoryID]) VALUES (2, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Asp.Net Core Başlangıç', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', 1)
INSERT [dbo].[Posts] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Title], [Description], [CategoryID]) VALUES (3, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Dört Büyüklerde Transfer Hız Kesmiyor !', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', 2)
INSERT [dbo].[Posts] ([ID], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Title], [Description], [CategoryID]) VALUES (4, N'09.05.2020 20:06:29', N'Admin', N'09.05.2020 20:06:29', N'Admin', N'Basketbol Takımımız Avrupa Yolcusu', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', 2)
SET IDENTITY_INSERT [dbo].[Posts] OFF
GO
/****** Object:  Index [IX_Comments_PostID]    Script Date: 6.09.2020 16:04:28 ******/
CREATE NONCLUSTERED INDEX [IX_Comments_PostID] ON [dbo].[Comments]
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Images_PostID]    Script Date: 6.09.2020 16:04:28 ******/
CREATE NONCLUSTERED INDEX [IX_Images_PostID] ON [dbo].[Images]
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Posts_CategoryID]    Script Date: 6.09.2020 16:04:28 ******/
CREATE NONCLUSTERED INDEX [IX_Posts_CategoryID] ON [dbo].[Posts]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Posts_PostID] FOREIGN KEY([PostID])
REFERENCES [dbo].[Posts] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Posts_PostID]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Posts_PostID] FOREIGN KEY([PostID])
REFERENCES [dbo].[Posts] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Posts_PostID]
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Categories_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Categories_CategoryID]
GO
USE [master]
GO
ALTER DATABASE [ArticleProjectDb] SET  READ_WRITE 
GO
