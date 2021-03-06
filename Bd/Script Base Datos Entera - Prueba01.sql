USE [master]
GO

/****** Object:  Database [Users]    Script Date: 5/2/2019 20:41:10 ******/
CREATE DATABASE [Users2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Users', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Users.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Users_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Users_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Users] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Users].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Users] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Users] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Users] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Users] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Users] SET ARITHABORT OFF 
GO

ALTER DATABASE [Users] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Users] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Users] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Users] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Users] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Users] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Users] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Users] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Users] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Users] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Users] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Users] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Users] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Users] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Users] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Users] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Users] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Users] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Users] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Users] SET  MULTI_USER 
GO

ALTER DATABASE [Users] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Users] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Users] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Users] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Users] SET  READ_WRITE 
GO


