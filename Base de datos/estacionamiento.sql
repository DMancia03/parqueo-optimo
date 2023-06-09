USE [master]
GO
/****** Object:  Database [estacionamiento]    Script Date: 5/4/2023 00:51:11 ******/
CREATE DATABASE [estacionamiento]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'estacionamiento', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\estacionamiento.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'estacionamiento_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\estacionamiento_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [estacionamiento] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [estacionamiento].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [estacionamiento] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [estacionamiento] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [estacionamiento] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [estacionamiento] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [estacionamiento] SET ARITHABORT OFF 
GO
ALTER DATABASE [estacionamiento] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [estacionamiento] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [estacionamiento] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [estacionamiento] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [estacionamiento] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [estacionamiento] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [estacionamiento] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [estacionamiento] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [estacionamiento] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [estacionamiento] SET  DISABLE_BROKER 
GO
ALTER DATABASE [estacionamiento] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [estacionamiento] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [estacionamiento] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [estacionamiento] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [estacionamiento] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [estacionamiento] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [estacionamiento] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [estacionamiento] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [estacionamiento] SET  MULTI_USER 
GO
ALTER DATABASE [estacionamiento] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [estacionamiento] SET DB_CHAINING OFF 
GO
ALTER DATABASE [estacionamiento] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [estacionamiento] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [estacionamiento] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [estacionamiento] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [estacionamiento] SET QUERY_STORE = ON
GO
ALTER DATABASE [estacionamiento] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [estacionamiento]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 5/4/2023 00:51:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id_customer] [int] IDENTITY(1,1) NOT NULL,
	[customer_name] [varchar](50) NULL,
	[customer_lastname] [varchar](50) NULL,
	[customer_DUI] [varchar](50) NULL,
	[customer_password] [varchar](100) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parking_lot]    Script Date: 5/4/2023 00:51:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parking_lot](
	[id_parking_lot] [int] IDENTITY(1,1) NOT NULL,
	[is_parking_lot_full] [varchar](50) NOT NULL,
	[numbers_of_slots] [int] NOT NULL,
 CONSTRAINT [PK_parking_lot] PRIMARY KEY CLUSTERED 
(
	[id_parking_lot] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parking_slot]    Script Date: 5/4/2023 00:51:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parking_slot](
	[id_parking_slot] [int] IDENTITY(1,1) NOT NULL,
	[id_parking_lot] [int] NOT NULL,
	[slot_number] [int] NOT NULL,
	[is_parking_slot_free] [varchar](50) NOT NULL,
 CONSTRAINT [PK_parking_slot] PRIMARY KEY CLUSTERED 
(
	[id_parking_slot] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parking_slot_reservation]    Script Date: 5/4/2023 00:51:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parking_slot_reservation](
	[id_reservation] [int] IDENTITY(1,1) NOT NULL,
	[customer_DUI] [varchar](50) NOT NULL,
	[id_parking_slot] [int] NOT NULL,
	[hora_reserva] [datetime] NOT NULL,
	[duration_in_minutes] [int] NOT NULL,
	[hora_finalizada] [datetime] NOT NULL,
 CONSTRAINT [PK_parking_slot_reservation] PRIMARY KEY CLUSTERED 
(
	[id_reservation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_customer]    Script Date: 5/4/2023 00:51:12 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_customer] ON [dbo].[customer]
(
	[customer_DUI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[parking_lot] ADD  CONSTRAINT [DF_parking_lot_is_parking_lot_full]  DEFAULT ('falso') FOR [is_parking_lot_full]
GO
ALTER TABLE [dbo].[parking_slot] ADD  CONSTRAINT [DF_parking_slot_is_parking_slot_free]  DEFAULT ('falso') FOR [is_parking_slot_free]
GO
ALTER TABLE [dbo].[parking_slot]  WITH CHECK ADD  CONSTRAINT [FK_parking_slot_parking_lot] FOREIGN KEY([id_parking_lot])
REFERENCES [dbo].[parking_lot] ([id_parking_lot])
GO
ALTER TABLE [dbo].[parking_slot] CHECK CONSTRAINT [FK_parking_slot_parking_lot]
GO
ALTER TABLE [dbo].[parking_slot_reservation]  WITH CHECK ADD  CONSTRAINT [FK_parking_slot_reservation_customer] FOREIGN KEY([customer_DUI])
REFERENCES [dbo].[customer] ([customer_DUI])
GO
ALTER TABLE [dbo].[parking_slot_reservation] CHECK CONSTRAINT [FK_parking_slot_reservation_customer]
GO
ALTER TABLE [dbo].[parking_slot_reservation]  WITH CHECK ADD  CONSTRAINT [FK_parking_slot_reservation_parking_slot] FOREIGN KEY([id_parking_slot])
REFERENCES [dbo].[parking_slot] ([id_parking_slot])
GO
ALTER TABLE [dbo].[parking_slot_reservation] CHECK CONSTRAINT [FK_parking_slot_reservation_parking_slot]
GO
USE [master]
GO
ALTER DATABASE [estacionamiento] SET  READ_WRITE 
GO
