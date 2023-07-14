USE [master]
GO
/****** Object:  Database [EXE221]    Script Date: 14/07/2023 13:38:04 ******/
CREATE DATABASE [EXE221]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EXE221', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.BAROHOANG\MSSQL\DATA\EXE221.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EXE221_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.BAROHOANG\MSSQL\DATA\EXE221_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EXE221] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EXE221].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EXE221] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EXE221] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EXE221] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EXE221] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EXE221] SET ARITHABORT OFF 
GO
ALTER DATABASE [EXE221] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EXE221] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EXE221] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EXE221] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EXE221] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EXE221] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EXE221] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EXE221] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EXE221] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EXE221] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EXE221] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EXE221] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EXE221] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EXE221] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EXE221] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EXE221] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EXE221] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EXE221] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EXE221] SET  MULTI_USER 
GO
ALTER DATABASE [EXE221] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EXE221] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EXE221] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EXE221] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EXE221] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EXE221] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EXE221] SET QUERY_STORE = OFF
GO
USE [EXE221]
GO
/****** Object:  Table [dbo].[BillingAddress]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillingAddress](
	[BillingId] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](20) NOT NULL,
	[BankNumber] [varchar](20) NOT NULL,
	[PriorityUsage] [tinyint] NOT NULL,
	[StudentId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](20) NOT NULL,
	[DateAdded] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employer]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employer](
	[EmployerId] [int] IDENTITY(1,1) NOT NULL,
	[EmployerName] [nvarchar](70) NOT NULL,
	[Company] [nvarchar](20) NULL,
	[Email] [varchar](50) NOT NULL,
	[Pwd] [varchar](50) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[EmployerStatus] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[JobId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateUpdated] [datetime] NOT NULL,
	[WorkLocation] [nvarchar](20) NOT NULL,
	[WorkType] [nvarchar](20) NOT NULL,
	[SalaryRate] [float] NOT NULL,
	[SalaryType] [nvarchar](10) NOT NULL,
	[JobStatus] [tinyint] NOT NULL,
	[EmployerId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobApplication]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobApplication](
	[JobId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[ReviewId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[JobId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[ReviewId] [int] IDENTITY(1,1) NOT NULL,
	[StudentComment] [nvarchar](100) NULL,
	[StudentSatisfaction] [tinyint] NULL,
	[EmployerComment] [nvarchar](100) NULL,
	[EmployerSatisfaction] [tinyint] NULL,
	[ReviewStatus] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Pwd] [varchar](50) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[StudentAddress] [nvarchar](100) NOT NULL,
	[StudentStatus] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 14/07/2023 13:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetail](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[TransactionCode] [varchar](15) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Purpose] [tinyint] NOT NULL,
	[TransStatus] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BillingAddress] ON 

INSERT [dbo].[BillingAddress] ([BillingId], [BankName], [BankNumber], [PriorityUsage], [StudentId]) VALUES (1, N'VCB', N'0123456789123', 1, 1)
SET IDENTITY_INSERT [dbo].[BillingAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName], [DateAdded]) VALUES (1, N'Web', CAST(N'2023-06-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [DateAdded]) VALUES (3, N'Shop Assisstant', CAST(N'2023-06-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [DateAdded]) VALUES (4, N'Shipper', CAST(N'2023-06-04T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Employer] ON 

INSERT [dbo].[Employer] ([EmployerId], [EmployerName], [Company], [Email], [Pwd], [Phone], [EmployerStatus]) VALUES (1, N'Dong Bui Huu', N'FPT', N'dongbh@fpt.vn', N'1', N'0111111111', 1)
SET IDENTITY_INSERT [dbo].[Employer] OFF
GO
SET IDENTITY_INSERT [dbo].[Review] ON 

INSERT [dbo].[Review] ([ReviewId], [StudentComment], [StudentSatisfaction], [EmployerComment], [EmployerSatisfaction], [ReviewStatus]) VALUES (1, N'string', 0, N'string', 0, 1)
SET IDENTITY_INSERT [dbo].[Review] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [FirstName], [LastName], [Email], [Pwd], [Phone], [StudentAddress], [StudentStatus]) VALUES (1, N'Bao', N'Hoang Le Gia', N'baohlgse161429@fpt.edu.vn', N'1', N'0123456789', N'HCM city', 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Student__A9D105342BA91720]    Script Date: 14/07/2023 13:38:04 ******/
ALTER TABLE [dbo].[Student] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BillingAddress]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD FOREIGN KEY([EmployerId])
REFERENCES [dbo].[Employer] ([EmployerId])
GO
ALTER TABLE [dbo].[JobApplication]  WITH CHECK ADD FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[JobApplication]  WITH CHECK ADD FOREIGN KEY([ReviewId])
REFERENCES [dbo].[Review] ([ReviewId])
GO
ALTER TABLE [dbo].[JobApplication]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[TransactionDetail]  WITH CHECK ADD FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([JobId])
GO
USE [master]
GO
ALTER DATABASE [EXE221] SET  READ_WRITE 
GO
