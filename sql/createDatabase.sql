set nocount on;
USE [DrapperTesting]
GO

ALTER DATABASE [DrapperTesting] SET SINGLE_USER WITH ROLLBACK IMMEDIATE

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'DrapperTesting')
BEGIN
	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_CreateTable]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [dbo].[usp_CreateTable]
	
	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Poco]') AND type in (N'U'))
	DROP TABLE [dbo].[Poco]

END

USE [master]
GO
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'DrapperTesting')
DROP DATABASE [DrapperTesting]
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DrapperTesting')
BEGIN
CREATE DATABASE [DrapperTesting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DrapperTesting', FILENAME = N'C:\Users\sexto\DrapperTesting.mdf' , SIZE = 78848KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DrapperTesting_log', FILENAME = N'C:\Users\sexto\DrapperTesting_log.ldf' , SIZE = 568896KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [DrapperTesting] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DrapperTesting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DrapperTesting] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DrapperTesting] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DrapperTesting] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DrapperTesting] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DrapperTesting] SET ARITHABORT OFF 
GO
ALTER DATABASE [DrapperTesting] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DrapperTesting] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DrapperTesting] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DrapperTesting] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DrapperTesting] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DrapperTesting] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DrapperTesting] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DrapperTesting] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DrapperTesting] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DrapperTesting] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DrapperTesting] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DrapperTesting] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DrapperTesting] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DrapperTesting] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DrapperTesting] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DrapperTesting] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DrapperTesting] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DrapperTesting] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DrapperTesting] SET  MULTI_USER 
GO
ALTER DATABASE [DrapperTesting] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DrapperTesting] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DrapperTesting] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DrapperTesting] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DrapperTesting] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DrapperTesting]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Currencies]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Currencies](
	[NumericCode] [varchar](3) NULL,
	[AlphabeticCode] [varchar](3) NULL,
	[Name] [varchar](125) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[Poco]    Script Date: 28/08/2016 10:27:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Poco]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Poco](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Value] [decimal](18, 2) NULL,
	[Modified] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateTable]    Script Date: 28/08/2016 10:27:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_CreateTable]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[usp_CreateTable] AS' 
END
GO

ALTER procedure [dbo].[usp_CreateTable](@tableName varchar(max))
as 
begin
declare  @template nvarchar(max)
		,@sql nvarchar(max)

select @template = N'
if exists (
		select *
		from sys.objects
		where object_id = OBJECT_ID(N''[dbo].[%tableName]'')
			and type in (N''U'')
		)
begin
	drop table [dbo].[%tableName];
end

if not exists (
		select *
		from sys.objects
		where object_id = OBJECT_ID(N''[dbo].[%tableName]'')
			and type in (N''U'')
		)
begin
	create table [dbo].[%tableName] (
		[Id] [int] IDENTITY(1, 1) not null
		,[Name] [varchar](50) null
		,[Value] [decimal](18, 2) null
		,[Modified] [datetime] null
		);
end;

'

select @sql = REPLACE(@template, '%tableName', @tableName);

exec sp_executesql @sql
end

GO
GO
USE [master]
GO
ALTER DATABASE [DrapperTesting] SET  READ_WRITE 
ALTER DATABASE [DrapperTesting] SET MULTI_USER
GO

USE [DrapperTesting]
go

declare @loop int = 1

while @loop != 43
begin
	insert into [Poco] (
		[Name]
		,[Value]
		,[Modified]
		)
	select convert(varchar(50), @loop)
		,@loop + 14
		,getutcdate()

	select @loop = @loop + 1
end
go