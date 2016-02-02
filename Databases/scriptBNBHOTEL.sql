USE [master]
GO
/****** Object:  Database [BNBHOTEL]    Script Date: 01/02/2016 16:56:35 ******/
CREATE DATABASE [BNBHOTEL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BNBHOTEL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BNBHOTEL.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BNBHOTEL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BNBHOTEL_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BNBHOTEL] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BNBHOTEL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BNBHOTEL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BNBHOTEL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BNBHOTEL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BNBHOTEL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BNBHOTEL] SET ARITHABORT OFF 
GO
ALTER DATABASE [BNBHOTEL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BNBHOTEL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BNBHOTEL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BNBHOTEL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BNBHOTEL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BNBHOTEL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BNBHOTEL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BNBHOTEL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BNBHOTEL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BNBHOTEL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BNBHOTEL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BNBHOTEL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BNBHOTEL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BNBHOTEL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BNBHOTEL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BNBHOTEL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BNBHOTEL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BNBHOTEL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BNBHOTEL] SET  MULTI_USER 
GO
ALTER DATABASE [BNBHOTEL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BNBHOTEL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BNBHOTEL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BNBHOTEL] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BNBHOTEL] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BNBHOTEL]
GO
/****** Object:  User [dbuser]    Script Date: 01/02/2016 16:56:35 ******/
/*CREATE USER [dbuser] FOR LOGIN [dbuser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [dbuser]*/
GO
/****** Object:  Table [dbo].[BOOK_HOTELS]    Script Date: 01/02/2016 16:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOK_HOTELS](
	[idClient] [nvarchar](50) NOT NULL,
	[idHotel] [int] NOT NULL,
	[dateFrom] [date] NOT NULL,
	[dateTo] [date] NOT NULL,
 CONSTRAINT [PK_RESA_HOTELS] PRIMARY KEY CLUSTERED 
(
	[idClient] ASC,
	[idHotel] ASC,
	[dateFrom] ASC,
	[dateTo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BOOK_HOTELS] ([idClient], [idHotel], [dateFrom], [dateTo]) VALUES (N'1                                                 ', 1, CAST(N'2015-02-01' AS Date), CAST(N'2015-02-05' AS Date))
/****** Object:  StoredProcedure [dbo].[createBookHotel]    Script Date: 01/02/2016 16:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createBookHotel]
	@idClient nvarchar(50),
	@idHotel int,
	@dateFrom date,
	@dateTo date
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO BOOK_HOTELS (idClient, idHotel, dateFrom, dateTo) VALUES (@idClient, @idHotel, @dateFrom, @dateTo);
END

GO
USE [master]
GO
ALTER DATABASE [BNBHOTEL] SET  READ_WRITE 
GO
