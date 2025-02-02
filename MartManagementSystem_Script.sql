USE [master]
GO
/****** Object:  Database [MartManagementSystem]    Script Date: 11/25/2024 3:12:37 AM ******/
CREATE DATABASE [MartManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MartManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MartManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MartManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MartManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MartManagementSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MartManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MartManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MartManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MartManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MartManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MartManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [MartManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MartManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MartManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MartManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MartManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MartManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MartManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MartManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MartManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MartManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MartManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MartManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MartManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MartManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MartManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MartManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MartManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MartManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MartManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [MartManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MartManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MartManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MartManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MartManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MartManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MartManagementSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [MartManagementSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MartManagementSystem]
GO
/****** Object:  Table [dbo].[tbCategories]    Script Date: 11/25/2024 3:12:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCategories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category] [varchar](250) NULL,
	[date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrderHistory]    Script Date: 11/25/2024 3:12:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrderHistory](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[prod_id] [int] NULL,
	[prod_name] [nvarchar](100) NULL,
	[qty] [int] NULL,
	[orig_price] [float] NULL,
	[total_price] [float] NULL,
	[order_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrders]    Script Date: 11/25/2024 3:12:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NULL,
	[prod_id] [varchar](250) NULL,
	[prod_name] [varchar](250) NULL,
	[category] [varchar](250) NULL,
	[qty] [int] NULL,
	[orig_price] [float] NULL,
	[total_price] [float] NULL,
	[order_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProducts]    Script Date: 11/25/2024 3:12:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProducts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[prod_id] [varchar](250) NULL,
	[prod_name] [varchar](250) NULL,
	[category] [varchar](250) NULL,
	[price] [float] NULL,
	[stock] [int] NULL,
	[image_path] [varchar](250) NULL,
	[status] [varchar](250) NULL,
	[date_insert] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStaffInfo]    Script Date: 11/25/2024 3:12:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStaffInfo](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[StaffName] [nvarchar](100) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[StaffPosition] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](255) NULL,
	[PhoneNumber] [nvarchar](15) NULL,
	[HiredDate] [date] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[Photo] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUsers]    Script Date: 11/25/2024 3:12:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbCategories] ON 

INSERT [dbo].[tbCategories] ([id], [category], [date]) VALUES (1, N'Drink', CAST(N'2024-11-03' AS Date))
INSERT [dbo].[tbCategories] ([id], [category], [date]) VALUES (3, N'Snack', CAST(N'2024-11-03' AS Date))
INSERT [dbo].[tbCategories] ([id], [category], [date]) VALUES (4, N'Food', CAST(N'2024-11-11' AS Date))
INSERT [dbo].[tbCategories] ([id], [category], [date]) VALUES (5, N'Meat', CAST(N'2024-11-08' AS Date))
SET IDENTITY_INSERT [dbo].[tbCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[tbOrderHistory] ON 

INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (1, 2, N'Potato Chip', 3, 2, 6, CAST(N'2024-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (2, 2, N'Potato Chip', 4, 2, 8, CAST(N'2024-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (3, 2, N'Potato Chip', 3, 2, 6, CAST(N'2024-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (4, 2, N'Potato Chip', 5, 2, 10, CAST(N'2024-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (5, 1, N'Coca Cola', 6, 1, 6, CAST(N'2024-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (6, 2, N'Potato Chip', 5, 2, 10, CAST(N'2024-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (7, 2, N'Potato Chip', 5, 2, 10, CAST(N'2024-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (8, 2, N'Potato Chip', 5, 2, 10, CAST(N'2024-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (9, 2, N'Potato Chip', 3, 2, 6, CAST(N'2024-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (10, 1, N'Coca Cola', 3, 1, 3, CAST(N'2024-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (1006, 1, N'Coca Cola', 2, 1, 2, CAST(N'2024-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[tbOrderHistory] ([order_id], [prod_id], [prod_name], [qty], [orig_price], [total_price], [order_date]) VALUES (1007, 3, N'Prime', 2, 15, 30, CAST(N'2024-11-23T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbOrderHistory] OFF
GO
SET IDENTITY_INSERT [dbo].[tbProducts] ON 

INSERT [dbo].[tbProducts] ([id], [prod_id], [prod_name], [category], [price], [stock], [image_path], [status], [date_insert]) VALUES (1, N'001', N'Coca Cola', N'System.Data.DataRowView', 1, 4, N'Images\Logo.png', N'Active', CAST(N'2024-11-05' AS Date))
INSERT [dbo].[tbProducts] ([id], [prod_id], [prod_name], [category], [price], [stock], [image_path], [status], [date_insert]) VALUES (2, N'002', N'Potato Chip', N'System.Data.DataRowView', 2, 5, N'Images\login.png', N'Inactive', CAST(N'2024-11-05' AS Date))
INSERT [dbo].[tbProducts] ([id], [prod_id], [prod_name], [category], [price], [stock], [image_path], [status], [date_insert]) VALUES (1005, N'003', N'Prime', N'System.Data.DataRowView', 15, 10, N'Images\kitkat.jpg', N'Active', CAST(N'2024-11-23' AS Date))
SET IDENTITY_INSERT [dbo].[tbProducts] OFF
GO
SET IDENTITY_INSERT [dbo].[tbUsers] ON 

INSERT [dbo].[tbUsers] ([UserId], [Username], [PhoneNumber], [Password], [Role]) VALUES (1, N'Thing', N'09633022332', N'1234', N'Cashier')
INSERT [dbo].[tbUsers] ([UserId], [Username], [PhoneNumber], [Password], [Role]) VALUES (2, N'Vanda', N'0963303484', N'1234', N'Cashier')
INSERT [dbo].[tbUsers] ([UserId], [Username], [PhoneNumber], [Password], [Role]) VALUES (3, N'Sopheak', N'096383833', N'2323', N'Admin')
INSERT [dbo].[tbUsers] ([UserId], [Username], [PhoneNumber], [Password], [Role]) VALUES (4, N'Thing', N'09633022332', N'1234', N'Manager')
SET IDENTITY_INSERT [dbo].[tbUsers] OFF
GO
USE [master]
GO
ALTER DATABASE [MartManagementSystem] SET  READ_WRITE 
GO
