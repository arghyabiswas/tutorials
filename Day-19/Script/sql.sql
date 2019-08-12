USE [master]
GO

/****** Object:  Database [TutorialDay19]    Script Date: 8/12/2019 5:05:31 PM ******/
CREATE DATABASE [TutorialDay19]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TutorialDay19', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\TutorialDay19.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TutorialDay19_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\TutorialDay19_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [TutorialDay19] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TutorialDay19].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TutorialDay19] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TutorialDay19] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TutorialDay19] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TutorialDay19] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TutorialDay19] SET ARITHABORT OFF 
GO

ALTER DATABASE [TutorialDay19] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TutorialDay19] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TutorialDay19] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TutorialDay19] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TutorialDay19] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TutorialDay19] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TutorialDay19] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TutorialDay19] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TutorialDay19] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TutorialDay19] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TutorialDay19] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TutorialDay19] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TutorialDay19] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TutorialDay19] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TutorialDay19] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TutorialDay19] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TutorialDay19] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TutorialDay19] SET RECOVERY FULL 
GO

ALTER DATABASE [TutorialDay19] SET  MULTI_USER 
GO

ALTER DATABASE [TutorialDay19] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TutorialDay19] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TutorialDay19] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TutorialDay19] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [TutorialDay19] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [TutorialDay19] SET  READ_WRITE 
GO

