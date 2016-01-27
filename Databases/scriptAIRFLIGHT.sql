USE [master]
GO
/****** Object:  Database [AIRFLIGHT]    Script Date: 27/01/2016 19:43:26 ******/
CREATE DATABASE [AIRFLIGHT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AIRFLIGHT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AIRFLIGHT.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AIRFLIGHT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AIRFLIGHT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AIRFLIGHT] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AIRFLIGHT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AIRFLIGHT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET ARITHABORT OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AIRFLIGHT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AIRFLIGHT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AIRFLIGHT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AIRFLIGHT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AIRFLIGHT] SET  MULTI_USER 
GO
ALTER DATABASE [AIRFLIGHT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AIRFLIGHT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AIRFLIGHT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AIRFLIGHT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AIRFLIGHT] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AIRFLIGHT]
GO
/****** Object:  User [dbuser]    Script Date: 27/01/2016 19:43:26 ******/
CREATE USER [dbuser] FOR LOGIN [dbuser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[BOOK_FLIGHTS]    Script Date: 27/01/2016 19:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOK_FLIGHTS](
	[idClient] [nchar](10) NOT NULL,
	[idFlight] [int] NOT NULL,
 CONSTRAINT [PK_BOOK_FLIGHTS] PRIMARY KEY CLUSTERED 
(
	[idClient] ASC,
	[idFlight] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FLIGHTS]    Script Date: 27/01/2016 19:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FLIGHTS](
	[id] [int] NOT NULL,
	[numPlane] [varchar](50) NOT NULL,
	[dateStart] [datetime] NOT NULL,
	[dateEnd] [datetime] NOT NULL,
	[cityFrom] [nchar](50) NOT NULL,
	[cityTo] [nchar](50) NOT NULL,
	[cityFromCode] [nchar](10) NOT NULL,
	[cityToCode] [nchar](10) NOT NULL,
 CONSTRAINT [PK_VOLS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[FLIGHTS] ([id], [numPlane], [dateStart], [dateEnd], [cityFrom], [cityTo], [cityFromCode], [cityToCode]) VALUES (1, N'PL0001', CAST(N'2016-02-01 00:00:00.000' AS DateTime), CAST(N'2016-02-02 00:00:00.000' AS DateTime), N'Nantes                                            ', N'Paris                                             ', N'NAN       ', N'PAR       ')
INSERT [dbo].[FLIGHTS] ([id], [numPlane], [dateStart], [dateEnd], [cityFrom], [cityTo], [cityFromCode], [cityToCode]) VALUES (2, N'PL0002', CAST(N'2016-02-03 00:00:00.000' AS DateTime), CAST(N'2016-02-04 00:00:00.000' AS DateTime), N'Paris                                             ', N'Nantes                                            ', N'PAR       ', N'NAN       ')
ALTER TABLE [dbo].[BOOK_FLIGHTS]  WITH CHECK ADD  CONSTRAINT [FK_BOOK_FLIGHTS] FOREIGN KEY([idFlight])
REFERENCES [dbo].[FLIGHTS] ([id])
GO
ALTER TABLE [dbo].[BOOK_FLIGHTS] CHECK CONSTRAINT [FK_BOOK_FLIGHTS]
GO
USE [master]
GO
ALTER DATABASE [AIRFLIGHT] SET  READ_WRITE 
GO
