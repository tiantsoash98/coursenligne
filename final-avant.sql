USE [master]
GO
/****** Object:  Database [CoursEnLigne]    Script Date: 28/10/2018 14:32:53 ******/
CREATE DATABASE [CoursEnLigne]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoursEnLigne', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CoursEnLigne.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CoursEnLigne_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CoursEnLigne_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CoursEnLigne] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoursEnLigne].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoursEnLigne] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoursEnLigne] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoursEnLigne] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoursEnLigne] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoursEnLigne] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoursEnLigne] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoursEnLigne] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CoursEnLigne] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoursEnLigne] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoursEnLigne] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoursEnLigne] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoursEnLigne] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoursEnLigne] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoursEnLigne] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoursEnLigne] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoursEnLigne] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoursEnLigne] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoursEnLigne] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoursEnLigne] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoursEnLigne] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoursEnLigne] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoursEnLigne] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoursEnLigne] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoursEnLigne] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoursEnLigne] SET  MULTI_USER 
GO
ALTER DATABASE [CoursEnLigne] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoursEnLigne] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoursEnLigne] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoursEnLigne] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CoursEnLigne]
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_ACCOUNTTYPE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_ACCOUNTTYPE] FROM [int] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_ADDRESS]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_ADDRESS] FROM [varchar](75) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_ANSWERCONTENT]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_ANSWERCONTENT] FROM [varchar](1000) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_BIRTHDAY]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_BIRTHDAY] FROM [datetime] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_CHAPTERNUMBER]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_CHAPTERNUMBER] FROM [smallint] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_CODE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_CODE] FROM [uniqueidentifier] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_COMMENTCONTENT]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_COMMENTCONTENT] FROM [varchar](2000) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_DATETIME]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_DATETIME] FROM [datetime] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_DESCRIPTION]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_DESCRIPTION] FROM [varchar](2000) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_DURATION]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_DURATION] FROM [bigint] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_EMAIL]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_EMAIL] FROM [varchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_EXCERCICENUMBER]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_EXCERCICENUMBER] FROM [smallint] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_FAX]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_FAX] FROM [varchar](20) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_FIELDSIZE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_FIELDSIZE] FROM [int] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_FILE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_FILE] FROM [varchar](100) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_GENDER]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_GENDER] FROM [uniqueidentifier] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_ID]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_ID] FROM [uniqueidentifier] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_LESSONCONTENT]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_LESSONCONTENT] FROM [varchar](max) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_NAME]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_NAME] FROM [varchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_PASSWORD]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_PASSWORD] FROM [varchar](255) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_PHONE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_PHONE] FROM [varchar](20) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_POINTS]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_POINTS] FROM [numeric](5, 2) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_POSTALCODE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_POSTALCODE] FROM [varchar](5) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_TITLE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_TITLE] FROM [varchar](200) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_TOWN]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_TOWN] FROM [varchar](25) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_WEBSITE]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_WEBSITE] FROM [varchar](100) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_WORDING]    Script Date: 28/10/2018 14:32:53 ******/
CREATE TYPE [dbo].[DOM_WORDING] FROM [varchar](25) NULL
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Account]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[CTRCODE] [dbo].[DOM_CODE] NOT NULL,
	[ATPCODE] [dbo].[DOM_CODE] NOT NULL,
	[ACCEMAIL] [dbo].[DOM_EMAIL] NOT NULL,
	[ACCPASSWORD] [dbo].[DOM_PASSWORD] NULL,
	[ACCPHONECONTACT] [dbo].[DOM_PHONE] NULL,
	[ACCPICTURE] [dbo].[DOM_FILE] NULL,
	[ACCINSCRIPTIONDATE] [dbo].[DOM_DATETIME] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AccountStudent]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountStudent](
	[ACSID] [dbo].[DOM_ID] NOT NULL,
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[GENCODE] [dbo].[DOM_CODE] NOT NULL,
	[ACSFIRSTNAME] [dbo].[DOM_NAME] NOT NULL,
	[ACSNAME] [dbo].[DOM_NAME] NOT NULL,
	[ACSBIRTHDAY] [dbo].[DOM_BIRTHDAY] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AccountStudy]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountStudy](
	[STDCODE] [dbo].[DOM_CODE] NOT NULL,
	[ACCID] [dbo].[DOM_ID] NOT NULL,
 CONSTRAINT [PK_ACCOUNTSTUDY] PRIMARY KEY CLUSTERED 
(
	[STDCODE] ASC,
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AccountTeacher]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountTeacher](
	[ACTID] [dbo].[DOM_ID] NOT NULL,
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[GENCODE] [dbo].[DOM_CODE] NOT NULL,
	[ACTFIRSTNAME] [dbo].[DOM_NAME] NOT NULL,
	[ACTNAME] [dbo].[DOM_NAME] NOT NULL,
	[ACTBIRTHDAY] [dbo].[DOM_BIRTHDAY] NOT NULL,
	[ACTTOWN] [dbo].[DOM_TOWN] NOT NULL,
	[ACTPOSTALCODE] [dbo].[DOM_POSTALCODE] NOT NULL,
	[ACTADDRESS] [dbo].[DOM_ADDRESS] NOT NULL,
	[ACTCV] [dbo].[DOM_FILE] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AccountType]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountType](
	[ATPCODE] [dbo].[DOM_CODE] NOT NULL,
	[ATPWORDING] [dbo].[DOM_WORDING] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[Account_Id] [dbo].[DOM_ID] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[CTGID] [dbo].[DOM_ID] NOT NULL,
	[CTGNAME] [dbo].[DOM_TITLE] NOT NULL,
	[CTGDESCRIPTION] [dbo].[DOM_DESCRIPTION] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comment](
	[COMID] [dbo].[DOM_ID] NOT NULL,
	[DCSCODE] [dbo].[DOM_CODE] NOT NULL,
	[LSNID] [dbo].[DOM_ID] NOT NULL,
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[COMDATE] [dbo].[DOM_DATETIME] NOT NULL,
	[COMCONTENT] [dbo].[DOM_COMMENTCONTENT] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CommentAnswer]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CommentAnswer](
	[CANID] [dbo].[DOM_ID] NOT NULL,
	[COMID] [dbo].[DOM_ID] NOT NULL,
	[DCSCODE] [dbo].[DOM_CODE] NOT NULL,
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[CANDATE] [dbo].[DOM_DATETIME] NOT NULL,
	[CANCONTENT] [dbo].[DOM_ANSWERCONTENT] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Country]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[CTRCODE] [dbo].[DOM_CODE] NOT NULL,
	[CTRNAME] [dbo].[DOM_NAME] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Culture]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Culture](
	[CLTCODE] [dbo].[DOM_TITLE] NOT NULL,
	[CLTWORDING] [dbo].[DOM_WORDING] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Curriculum]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curriculum](
	[CURID] [dbo].[DOM_ID] NOT NULL,
	[STDCODE] [dbo].[DOM_CODE] NOT NULL,
	[CURNAME] [dbo].[DOM_NAME] NOT NULL,
	[CURDESCRIPTION] [dbo].[DOM_DESCRIPTION] NOT NULL,
	[CURCREDIT] [dbo].[DOM_POINTS] NULL,
	[CURLEVELMIN] [dbo].[DOM_DESCRIPTION] NULL,
	[CURDURATION] [dbo].[DOM_DURATION] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurriculumCategory]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCategory](
	[CTGID] [dbo].[DOM_ID] NOT NULL,
	[CURID] [dbo].[DOM_ID] NOT NULL,
 CONSTRAINT [PK_CURRICULUMCATEGORY] PRIMARY KEY CLUSTERED 
(
	[CTGID] ASC,
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumLessons]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumLessons](
	[LSNID] [dbo].[DOM_ID] NOT NULL,
	[CURID] [dbo].[DOM_ID] NOT NULL,
	[CLSCREDIT] [dbo].[DOM_POINTS] NOT NULL,
 CONSTRAINT [PK_CURRICULUMLESSONS] PRIMARY KEY CLUSTERED 
(
	[LSNID] ASC,
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumSubscription]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumSubscription](
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[CURID] [dbo].[DOM_ID] NOT NULL,
	[CSBDATE] [dbo].[DOM_DATETIME] NOT NULL,
 CONSTRAINT [PK_CURRICULUMSUBSCRIPTION] PRIMARY KEY CLUSTERED 
(
	[ACCID] ASC,
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocumentConfidentiality]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocumentConfidentiality](
	[DCFCODE] [dbo].[DOM_CODE] NOT NULL,
	[DCFWORDING] [dbo].[DOM_WORDING] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocumentState]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocumentState](
	[DCSCODE] [dbo].[DOM_CODE] NOT NULL,
	[DCSWORDING] [dbo].[DOM_WORDING] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntityStrings]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntityStrings](
	[ESTENTITYID] [dbo].[DOM_ID] NOT NULL,
	[CLTCODE] [dbo].[DOM_TITLE] NOT NULL,
	[ESTWORDING] [dbo].[DOM_TITLE] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Exercice]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Exercice](
	[EXCID] [dbo].[DOM_ID] NOT NULL,
	[LSNID] [dbo].[DOM_ID] NOT NULL,
	[EXCTITLE] [dbo].[DOM_TITLE] NULL,
	[EXCDESCRIPTION] [dbo].[DOM_DESCRIPTION] NULL,
	[EXCDATE] [dbo].[DOM_DATETIME] NOT NULL,
	[EXCCOMMENT] [dbo].[DOM_DESCRIPTION] NULL,
	[EXCDURATION] [dbo].[DOM_DURATION] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExerciceCorrection]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExerciceCorrection](
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[EXDID] [dbo].[DOM_ID] NOT NULL,
	[ECRDATE] [dbo].[DOM_DATETIME] NOT NULL,
	[ECRAPOINTS] [dbo].[DOM_POINTS] NOT NULL,
 CONSTRAINT [PK_EXERCICECORRECTION] PRIMARY KEY CLUSTERED 
(
	[ACCID] ASC,
	[EXDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExerciceDone]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExerciceDone](
	[EXDID] [dbo].[DOM_ID] NOT NULL,
	[EXCID] [dbo].[DOM_ID] NOT NULL,
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[EXDDATE] [dbo].[DOM_DATETIME] NOT NULL,
	[EXDCOMMENT] [dbo].[DOM_DESCRIPTION] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExerciceQuestion]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExerciceQuestion](
	[EXQCODE] [dbo].[DOM_CODE] NOT NULL,
	[EXCID] [dbo].[DOM_ID] NOT NULL,
	[FLDCODE] [dbo].[DOM_CODE] NULL,
	[EQTCODE] [dbo].[DOM_CODE] NOT NULL,
	[EQCCODE] [dbo].[DOM_CODE] NULL,
	[EXQNUMBER] [dbo].[DOM_EXCERCICENUMBER] NOT NULL,
	[EXQQUESTION] [dbo].[DOM_DESCRIPTION] NOT NULL,
	[EXQANSWER] [dbo].[DOM_ANSWERCONTENT] NULL,
	[EXQPOINTS] [dbo].[DOM_POINTS] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExerciceQuestionAnswer]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExerciceQuestionAnswer](
	[EXDID] [dbo].[DOM_ID] NOT NULL,
	[EXQCODE] [dbo].[DOM_CODE] NOT NULL,
	[EQAVALUE] [dbo].[DOM_ANSWERCONTENT] NULL,
 CONSTRAINT [PK_EXERCICEQUESTIONANSWER] PRIMARY KEY CLUSTERED 
(
	[EXDID] ASC,
	[EXQCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExerciceQuestionChoice]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExerciceQuestionChoice](
	[EQCCODE] [dbo].[DOM_CODE] NOT NULL,
	[EQCANWSER] [dbo].[DOM_DESCRIPTION] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExerciceQuestionType]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExerciceQuestionType](
	[EQTCODE] [dbo].[DOM_CODE] NOT NULL,
	[EQTWORDING] [dbo].[DOM_WORDING] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FieldType]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FieldType](
	[FLDCODE] [dbo].[DOM_CODE] NOT NULL,
	[FLDWORDING] [dbo].[DOM_WORDING] NOT NULL,
	[FLDMINSIZE] [dbo].[DOM_FIELDSIZE] NULL,
	[FLDMAXSIZE] [dbo].[DOM_FIELDSIZE] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FollowState]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FollowState](
	[FLSCODE] [dbo].[DOM_CODE] NOT NULL,
	[FLSWORDING] [char](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gender](
	[GENCODE] [dbo].[DOM_CODE] NOT NULL,
	[GENWORDING] [dbo].[DOM_WORDING] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lesson]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lesson](
	[LSNID] [dbo].[DOM_ID] NOT NULL,
	[STDCODE] [dbo].[DOM_CODE] NOT NULL,
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[DCSCODE] [dbo].[DOM_CODE] NOT NULL,
	[DCFCODE] [dbo].[DOM_CODE] NOT NULL,
	[LSNTITLE] [dbo].[DOM_TITLE] NOT NULL,
	[LSNDESCRIPTION] [dbo].[DOM_DESCRIPTION] NOT NULL,
	[LSNTARGET] [dbo].[DOM_DESCRIPTION] NOT NULL,
	[LSNDATE] [dbo].[DOM_DATETIME] NOT NULL,
	[LSNPICTURE] [dbo].[DOM_FILE] NULL,
	[LSNDURATION] [dbo].[DOM_DURATION] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LessonChapter]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LessonChapter](
	[LSCCODE] [dbo].[DOM_CODE] NOT NULL,
	[LSNID] [dbo].[DOM_ID] NOT NULL,
	[LSCNUMBER] [dbo].[DOM_CHAPTERNUMBER] NOT NULL,
	[LSCTITLE] [dbo].[DOM_TITLE] NOT NULL,
	[LSCDESCRIPTION] [dbo].[DOM_DESCRIPTION] NULL,
	[LSCCONTENT] [dbo].[DOM_LESSONCONTENT] NOT NULL,
	[LSCDURATION] [dbo].[DOM_DURATION] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LessonFollowed]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LessonFollowed](
	[ACCID] [dbo].[DOM_ID] NOT NULL,
	[LSNID] [dbo].[DOM_ID] NOT NULL,
	[FLSCODE] [dbo].[DOM_CODE] NOT NULL,
	[LSFDATE] [dbo].[DOM_DATETIME] NOT NULL,
	[LSFCHAPTER] [dbo].[DOM_CHAPTERNUMBER] NULL,
	[LSFPART] [dbo].[DOM_CHAPTERNUMBER] NULL,
 CONSTRAINT [PK_LessonFollowed] PRIMARY KEY CLUSTERED 
(
	[ACCID] ASC,
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LessonPart]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LessonPart](
	[LSPCODE] [dbo].[DOM_CODE] NOT NULL,
	[LSCCODE] [dbo].[DOM_CODE] NOT NULL,
	[LSPNUMBER] [dbo].[DOM_CHAPTERNUMBER] NOT NULL,
	[LSPTITLE] [dbo].[DOM_TITLE] NOT NULL,
	[LSPCONTENT] [dbo].[DOM_LESSONCONTENT] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LSPCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Study]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Study](
	[STDCODE] [dbo].[DOM_CODE] NOT NULL,
	[STDNAME] [dbo].[DOM_NAME] NOT NULL,
	[STDDESCRIPTION] [dbo].[DOM_DESCRIPTION] NULL,
	[STDPICTURE] [dbo].[DOM_FILE] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubscribeActivity]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubscribeActivity](
	[SUBID] [dbo].[DOM_ID] NOT NULL,
	[ACCSUBSCRIBER] [dbo].[DOM_ID] NOT NULL,
	[ACCSUBSCRIBED] [dbo].[DOM_ID] NOT NULL,
	[SUBDATE] [dbo].[DOM_DATETIME] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[LessonAlternative]    Script Date: 28/10/2018 14:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[LessonAlternative] as 
select l.LSNID, l.STDCODE, l.ACCID, l.DCFCODE, l.LSNTITLE, l.LSNDESCRIPTION, l.LSNTARGET, l.LSNDATE, isnull(l.LSNPICTURE, s.STDPICTURE) as LSNPICTURE, l.LSNDURATION, CAST(CASE WHEN l.LSNPICTURE IS NOT NULL THEN 'False' ELSE 'True' END AS BIT) as ISALTERNATIVE from Lesson l
join Study s
on l.STDCODE = s.STDCODE;
GO
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'09ee69af-a191-e811-821f-2c600c6934be', N'etudiant1@itu.local', N'', N'+261 34 00 000 00', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be.jpg', CAST(0x0000A93C00FA3D26 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'9eeedeac-91af-e811-8222-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'prof2@itu.local', N'', N'+261 33 34 365 36', N'9eeedeac-91af-e811-8222-2c600c6934be.jpg', CAST(0x0000A9500137A9D3 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'bbf094e2-42b3-e811-8222-2c600c6934be', N'a8e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'jean@itu.local', N'', N'+261 33 33 375 64', NULL, CAST(0x0000A95500C07C02 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'0ba7a6da-76bd-e811-8224-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'09ee69af-a191-e811-821f-2c600c6934be', N'etudiant3@itu.local', N'', N'', NULL, CAST(0x0000A96200BA376A AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'dab3e636-90be-e811-8225-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'09ee69af-a191-e811-821f-2c600c6934be', N'prof4@itu.local', N'', N'+261 34 00 001 22', N'dab3e636-90be-e811-8225-2c600c6934be.jpg', CAST(0x0000A9630157E486 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'fb436e0c-20c3-e811-8228-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'09ee69af-a191-e811-821f-2c600c6934be', N'soa@itu.local', N'', N'', NULL, CAST(0x0000A969010AE721 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'7ea5d441-59c5-e811-8228-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'tiantsoa.sh@gmail.com', N'', N'+261 34 00 001 02', NULL, CAST(0x0000A96C00C77D38 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'9ab7771d-f69f-e811-8220-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'prof1@itu.local', N'', N'020 22 234 56', NULL, CAST(0x0000A93C016E3B9C AS DateTime))
INSERT [dbo].[AccountStudent] ([ACSID], [ACCID], [GENCODE], [ACSFIRSTNAME], [ACSNAME], [ACSBIRTHDAY]) VALUES (N'4cf9efb1-8cbe-e811-8225-2c600c6934be', N'0ba7a6da-76bd-e811-8224-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Etudiant', N'Troisieme', CAST(0x000086510150F1A6 AS DateTime))
INSERT [dbo].[AccountStudent] ([ACSID], [ACCID], [GENCODE], [ACSFIRSTNAME], [ACSNAME], [ACSBIRTHDAY]) VALUES (N'42fe80dd-8cbe-e811-8225-2c600c6934be', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'244eedbd-cc9b-e811-8220-2c600c6934be', N'Sérieuse', N'Etudiante', CAST(0x00008D6200000000 AS DateTime))
INSERT [dbo].[AccountStudent] ([ACSID], [ACCID], [GENCODE], [ACSFIRSTNAME], [ACSNAME], [ACSBIRTHDAY]) VALUES (N'dbb3e636-90be-e811-8225-2c600c6934be', N'dab3e636-90be-e811-8225-2c600c6934be', N'244eedbd-cc9b-e811-8220-2c600c6934be', N'Sympa', N'Etudiante', CAST(0x0000836100000000 AS DateTime))
INSERT [dbo].[AccountStudent] ([ACSID], [ACCID], [GENCODE], [ACSFIRSTNAME], [ACSNAME], [ACSBIRTHDAY]) VALUES (N'fc436e0c-20c3-e811-8228-2c600c6934be', N'fb436e0c-20c3-e811-8228-2c600c6934be', N'244eedbd-cc9b-e811-8220-2c600c6934be', N'Rabe', N'Soa', CAST(0x000089DA00000000 AS DateTime))
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'90b6e704-8ebe-e811-8225-2c600c6934be', N'9ab7771d-f69f-e811-8220-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Premier', N'Prof', CAST(0x0000777601538AAA AS DateTime), N'Antananarivo', N'101', N'Chez lui', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'd4fedc64-8ebe-e811-8225-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Premier', N'Rabe', CAST(0x0000819D00000000 AS DateTime), N'Antananarivo', N'106', N'Lot IIII A Analakely ', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'056f9a99-8ebe-e811-8225-2c600c6934be', N'bbf094e2-42b3-e811-8222-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Jean', N'Maitre', CAST(0x0000819D0154AD79 AS DateTime), N'Antananarivo', N'102', N'Chez Jean', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'7fa5d441-59c5-e811-8228-2c600c6934be', N'7ea5d441-59c5-e811-8228-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Tiantsoa', N'Rabemananjara', CAST(0x00008BDC00000000 AS DateTime), N'Antananarivo', N'102', N'Lot IIII A Analakely ', NULL)
INSERT [dbo].[AccountType] ([ATPCODE], [ATPWORDING]) VALUES (N'09ee69af-a191-e811-821f-2c600c6934be', N'STUDENT')
INSERT [dbo].[AccountType] ([ATPCODE], [ATPWORDING]) VALUES (N'4650653e-e49a-e811-821f-2c600c6934be', N'TEACHER')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1da5870-be8c-4c82-9755-d364518b3fc9', N'STUDENT')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991', N'TEACHER')
INSERT [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [UserId]) VALUES (N'Google', N'113901245989860449082', N'f0cf913a-6d19-4bc0-8b01-c01327fea13a')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'48d64215-1210-4bfe-9dda-3028871a3d0e', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6c6d8fe0-c80f-434c-978a-a32d06a226f7', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aba61c9c-ee80-4c1c-b905-7d3c4143a90f', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f0cf913a-6d19-4bc0-8b01-c01327fea13a', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8037baa8-4321-4818-9014-db7e23255aa0', N'd1da5870-be8c-4c82-9755-d364518b3fc9')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9d48adf3-3696-441f-8735-ed5d42b8aa3a', N'd1da5870-be8c-4c82-9755-d364518b3fc9')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b6c20b3a-caca-477f-b239-0b0847a0aaf9', N'd1da5870-be8c-4c82-9755-d364518b3fc9')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c9a4c25d-5e6b-456b-bf0f-217d4db6ae59', N'd1da5870-be8c-4c82-9755-d364518b3fc9')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'48d64215-1210-4bfe-9dda-3028871a3d0e', N'prof2@itu.local', 0, N'APrDMzDLm7pV7IncAmsObgDrcAAyvLYSgwBOUf2TGzpXrvyVdPOso/wMEO1PF8WQNw==', N'f22c918e-16d5-4ddd-a158-81959505fcf3', NULL, 0, 0, NULL, 1, 0, N'prof2@itu.local', N'9eeedeac-91af-e811-8222-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'6c6d8fe0-c80f-434c-978a-a32d06a226f7', N'jean@itu.local', 0, N'AE4UpTHPZT2RV8ed9+ExFouAsnsSX9dbR9DDLIu2/pbgf2ZExJSKA8MyO//GYN0QVQ==', N'a5b32b48-3ec1-4334-9669-ba50d3c4e738', NULL, 0, 0, NULL, 1, 0, N'jean@itu.local', N'bbf094e2-42b3-e811-8222-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'8037baa8-4321-4818-9014-db7e23255aa0', N'soa@itu.local', 1, N'ABEmVgzHXPZP56FqAQX/6fw4zvDg7sX4hsvYPbMD9uexL4Neyr0lAvuHeD2uh5ZnDw==', N'd5df69e4-5923-4914-b0af-55c71917e3e7', NULL, 0, 0, NULL, 1, 0, N'soa@itu.local', N'fb436e0c-20c3-e811-8228-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'9d48adf3-3696-441f-8735-ed5d42b8aa3a', N'etudiant3@itu.local', 0, N'AJvKRbV52LbLkGcukP11eBW0sta5RQM7ZjYcvwVwj6xKOnJ24cNyyOCZ5+T+n5KPMg==', N'f89d63df-9a25-4fae-88b4-1f166f78c9d8', NULL, 0, 0, NULL, 1, 0, N'etudiant3@itu.local', N'0ba7a6da-76bd-e811-8224-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'aba61c9c-ee80-4c1c-b905-7d3c4143a90f', N'prof1@itu.local', 0, N'ACRL/woB8cwBViT9QQk61l2ve41e3WDbPYNsEc7b/hK3cVMuVgi8DpDdQOO+FGSG8g==', N'a978d938-51c9-4de8-b53a-da107494ce16', NULL, 0, 0, NULL, 1, 0, N'prof1@itu.local', N'9ab7771d-f69f-e811-8220-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'b6c20b3a-caca-477f-b239-0b0847a0aaf9', N'prof4@itu.local', 0, N'ABC6OHelkm1lQVwdPo5dEtpy7JDyEkqsxqhta+aSDvwmoBEL4SiZOm+4kL25I4dinw==', N'a830931f-e79d-4e7f-96e0-17bf6ca5c38f', NULL, 0, 0, NULL, 1, 0, N'prof4@itu.local', N'dab3e636-90be-e811-8225-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'c9a4c25d-5e6b-456b-bf0f-217d4db6ae59', N'etudiant1@itu.local', 0, N'AGaWqljOU6xpY9ndjgJxiTH4XENmLOJddAiyB6WYPftdBXU5LwODOCbvX4HeJznQ2g==', N'63cb61a8-e445-4fc3-a584-461b573b38a5', NULL, 0, 0, NULL, 1, 0, N'etudiant1@itu.local', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'f0cf913a-6d19-4bc0-8b01-c01327fea13a', N'tiantsoa.sh@gmail.com', 0, N'AJdrIn9+zeGcAGhT9+mh5bFlEMyXz0y5SNVSsdNVIhDNd9Rq7sDUGtdQFntaUcpoZw==', N'dbf1908b-9186-454f-b579-3865b4cadbc2', NULL, 0, 0, NULL, 1, 0, N'tiantsoa.sh@gmail.com', N'7ea5d441-59c5-e811-8228-2c600c6934be')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'3bcc1004-39d4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7cce715f-f7a1-e811-8221-2c600c6934be', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', CAST(0x0000A97F00BB9F34 AS DateTime), N'Phasellus sed nibh ut ipsum porta rhoncus. Morbi semper leo vel nunc hendrerit rhoncus. Integer vel elementum nunc. Nam vel diam bibendum, pretium metus molestie, viverra risus. Vivamus dignissim blandit tincidunt. Pellentesque at augue ac nulla aliquam viverra. Vestibulum a diam urna. Fusce mollis ipsum et hendrerit varius. Mauris faucibus ipsum eu ligula congue, ut laoreet justo dapibus. Aliquam mi neque, ultricies id semper et, molestie quis odio. Integer vitae feugiat nisl. Aenean vel lectus quis felis auctor finibus maximus vitae diam. Suspendisse vitae vestibulum enim. Donec lacinia, enim eu auctor rhoncus, mauris justo pulvinar ex, vitae ultrices augue arcu at mauris. Duis congue placerat eleifend.')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'9b49e8c5-3cd4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7cce715f-f7a1-e811-8221-2c600c6934be', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', CAST(0x0000A97F00C304FA AS DateTime), N'Vestibulum imperdiet, arcu ac fermentum vestibulum, massa arcu congue eros, non commodo libero nisl ac erat. Aliquam dapibus libero nibh, eu faucibus est rhoncus nec. Suspendisse quis neque et est pulvinar pulvinar. Quisque consectetur rhoncus consequat. Donec cursus imperdiet luctus. Quisque libero nibh, faucibus vel aliquet sit amet, lobortis ut est. Quisque in tellus ullamcorper, fringilla mi ac, tincidunt eros. Cras luctus libero non neque congue, vitae placerat nisi ornare. Aliquam lectus quam, rhoncus ut nisi in, mollis dignissim nunc.')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'02bba52c-58d4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'd2a6d649-abaf-e811-8222-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', CAST(0x0000A97F00F8E4ED AS DateTime), N'Vestibulum imperdiet, arcu ac fermentum vestibulum, massa arcu congue eros, non commodo libero nisl ac erat. Aliquam dapibus libero nibh, eu faucibus est rhoncus nec. Suspendisse quis neque et est pulvinar pulvinar. Quisque consectetur rhoncus consequat. Donec cursus imperdiet luctus. Quisque libero nibh, faucibus vel aliquet sit amet, lobortis ut est. Quisque in tellus ullamcorper, fringilla mi ac, tincidunt eros. Cras luctus libero non neque congue, vitae placerat nisi ornare. Aliquam lectus quam, rhoncus ut nisi in, mollis dignissim nunc.')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'e95771fe-70d4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', CAST(0x0000A97F0129BC54 AS DateTime), N'Voici le premier commentaire')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'c1702f7a-79d4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', CAST(0x0000A97F013A6A3E AS DateTime), N'Excellent cours, je recommande')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'632dc64e-fad4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', N'bbf094e2-42b3-e811-8222-2c600c6934be', CAST(0x0000A98000AC3299 AS DateTime), N'Je n''ai pas compris la première partie')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'663aa955-e1d6-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'd2a6d649-abaf-e811-8222-2c600c6934be', N'0ba7a6da-76bd-e811-8224-2c600c6934be', CAST(0x0000A9820152B765 AS DateTime), N'J''adore le concept')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'34e2a849-3dd4-e811-822a-2c600c6934be', N'3bcc1004-39d4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'dab3e636-90be-e811-8225-2c600c6934be', CAST(0x0000A97F00C40756 AS DateTime), N'Phasellus sed nibh ut ipsum porta rhoncus. Morbi semper leo vel nunc hendrerit rhoncus. Integer vel elementum nunc. Nam vel diam bibendum, pretium metus molestie, viverra risus. Vivamus dignissim blandit tincidunt. Pellentesque at augue ac nulla aliquam viverra. Vestibulum a diam urna. Fusce mollis ipsum et hendrerit varius. Mauris faucibus ipsum eu ligula congue, ut laoreet justo dapibus. Aliquam mi neque, ultricies id semper et, molestie quis odio. Integer vitae feugiat nisl. Aenean vel lectus quis felis auctor finibus maximus vitae diam. Suspendisse vitae vestibulum enim. Donec lacinia, enim eu auctor rhoncus, mauris justo pulvinar ex, vitae ultrices augue arcu at mauris. Duis congue placerat eleifend.')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'40b1ce26-04d5-e811-822a-2c600c6934be', N'e95771fe-70d4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', CAST(0x0000A98000BF8202 AS DateTime), N'Voici la première réponse')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'ec55035c-07d5-e811-822a-2c600c6934be', N'e95771fe-70d4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', CAST(0x0000A98000C5D39F AS DateTime), N'Voici la deuxième réponse')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'c8c436cc-34d5-e811-822a-2c600c6934be', N'632dc64e-fad4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', CAST(0x0000A980011F31B7 AS DateTime), N'Moi non plus')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'c88ac4e5-34d5-e811-822a-2c600c6934be', N'632dc64e-fad4-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', CAST(0x0000A980011F6405 AS DateTime), N'Haha')
INSERT [dbo].[Country] ([CTRCODE], [CTRNAME]) VALUES (N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'Madagascar')
INSERT [dbo].[Country] ([CTRCODE], [CTRNAME]) VALUES (N'a8e8fac3-9f91-e811-821f-2c600c6934be', N'France')
INSERT [dbo].[Culture] ([CLTCODE], [CLTWORDING]) VALUES (N'en-US', N'English')
INSERT [dbo].[Culture] ([CLTCODE], [CLTWORDING]) VALUES (N'fr-Fr', N'Français')
INSERT [dbo].[Culture] ([CLTCODE], [CLTWORDING]) VALUES (N'mg-MG', N'Malagasy')
INSERT [dbo].[DocumentConfidentiality] ([DCFCODE], [DCFWORDING]) VALUES (N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'PUBLIC')
INSERT [dbo].[DocumentState] ([DCSCODE], [DCSWORDING]) VALUES (N'03529c5e-3fba-e811-8225-2c600c6934be', N'VALID')
INSERT [dbo].[DocumentState] ([DCSCODE], [DCSWORDING]) VALUES (N'980a694a-40ba-e811-8225-2c600c6934be', N'WRITING')
INSERT [dbo].[DocumentState] ([DCSCODE], [DCSWORDING]) VALUES (N'c76487e0-b3d3-e811-822a-2c600c6934be', N'DELETED')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'234eedbd-cc9b-e811-8220-2c600c6934be', N'en-US', N'Man')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'244eedbd-cc9b-e811-8220-2c600c6934be', N'en-US', N'Woman')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'234eedbd-cc9b-e811-8220-2c600c6934be', N'fr-Fr', N'Homme')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'244eedbd-cc9b-e811-8220-2c600c6934be', N'fr-Fr', N'Femme')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'en-US', N'Science and Technology')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'fr-Fr', N'Sciences et technologies')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'en-US', N'Marketing')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'fr-Fr', N'Marketing')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'89b16d41-9c9c-e811-8220-2c600c6934be', N'en-US', N'Law')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'89b16d41-9c9c-e811-8220-2c600c6934be', N'fr-Fr', N'Droit')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'18c841d9-1ca1-e811-8221-2c600c6934be', N'en-US', N'Economy, Social and Management')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'18c841d9-1ca1-e811-8221-2c600c6934be', N'fr-Fr', N'Economie, social et Management')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'de237780-1da1-e811-8221-2c600c6934be', N'en-US', N'Philosophy and Letters')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'de237780-1da1-e811-8221-2c600c6934be', N'fr-Fr', N'Philosophie et Lettres')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'en-US', N'Information and Communication Techonologies')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'fr-Fr', N'Technologies d''information et de Communication')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'234eedbd-cc9b-e811-8220-2c600c6934be', N'mg-MG', N'Lahy')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'244eedbd-cc9b-e811-8220-2c600c6934be', N'mg-MG', N'Vavy')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'mg-MG', N'Siansa')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'mg-MG', N'Varotra')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'89b16d41-9c9c-e811-8220-2c600c6934be', N'mg-MG', N'Lalàna')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'18c841d9-1ca1-e811-8221-2c600c6934be', N'mg-MG', N'Economia, sosialy ary fitantanana')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'de237780-1da1-e811-8221-2c600c6934be', N'mg-MG', N'Filozofia  sy Soratra')
INSERT [dbo].[EntityStrings] ([ESTENTITYID], [CLTCODE], [ESTWORDING]) VALUES (N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'mg-MG', N'Informatika')
INSERT [dbo].[FollowState] ([FLSCODE], [FLSWORDING]) VALUES (N'7abd2a4e-52b7-e811-8225-2c600c6934be', N'STARTED   ')
INSERT [dbo].[FollowState] ([FLSCODE], [FLSWORDING]) VALUES (N'11937790-52b7-e811-8225-2c600c6934be', N'FINISHED  ')
INSERT [dbo].[Gender] ([GENCODE], [GENWORDING]) VALUES (N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Homme')
INSERT [dbo].[Gender] ([GENCODE], [GENWORDING]) VALUES (N'244eedbd-cc9b-e811-8220-2c600c6934be', N'Femme')
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'7cce715f-f7a1-e811-8221-2c600c6934be', N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'9ab7771d-f69f-e811-8220-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Développer des applications en Python', N'Grâce à la spécialisation Python / Django, vous saurez construire des scripts et des applications web robustes. Vous découvrirez les sujets centraux du développement web et serez capable, entre autre, de lancer un programme en ligne de commande. Les bases de données, les bonnes pratiques en Python ou les serveurs n''auront plus de secrets pour vous ! ', N'Créer des projets web dynamiques grâce à Python|Utiliser les outils les plus connus d''intégration continue', CAST(0x0000A93F00BCCA24 AS DateTime), N'7cce715f-f7a1-e811-8221-2c600c6934be.jpg', 90000000000)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'f078de6f-a5ab-e811-8222-2c600c6934be', N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'9ab7771d-f69f-e811-8220-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Qu''est ce que le Marketing visuel?', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt

                                ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet,
                consectetur

                                Ut enim ad minim veniam', N'Comprendre ce qu''est le marketing visuel|Apprehender sa place dans la société actuelle', CAST(0x0000A94B013ACA94 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'd2a6d649-abaf-e811-8222-2c600c6934be', N'de237780-1da1-e811-8221-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Comprendre le sens de la vie', N'Ce cours vous aidera à comprendre le sens de la vie et d''en percer ses mystères', N'Percer les mystères de la vie|Se sentir bien intérieurement', CAST(0x0000A950016A0697 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'e8a172b7-37b1-e811-8222-2c600c6934be', N'de237780-1da1-e811-8221-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'aaa', N'Hahahah', N'dsqdqd', CAST(0x0000A952015E6B64 AS DateTime), N'e8a172b7-37b1-e811-8222-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'f4536738-9bb1-e811-8222-2c600c6934be', N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Relativité restreinte', N'Et voilà le gros morceau ! Cela faisait un moment que je voulais produire quelque chose sur la relativité restreinte, mais je ne trouvais pas l’angle qui me plaisait. C’est chose faite, mais du coup c’est un peu long !', N'Etudiants en sciences|Etudiants en astronomie', CAST(0x0000A95300968B1A AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'a2f9bc01-cab1-e811-8222-2c600c6934be', N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Tuto Dota 2', N'Comment évoluer dans Dota 2', N'Noob|Bayn|Débutants', CAST(0x0000A95300F28787 AS DateTime), N'a2f9bc01-cab1-e811-8222-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'48a60e26-f1b1-e811-8222-2c600c6934be', N'18c841d9-1ca1-e811-8221-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'dddddddddddddddrgdsf', N'Blablablabla', N'zezeeee', CAST(0x0000A953013F7C4C AS DateTime), N'48a60e26-f1b1-e811-8222-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'ac5a4353-36b3-e811-8222-2c600c6934be', N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Vivamus erat lectus, iaculis vel elementum quis, molestie vel felis. Nunc mattis non nisi eu interdum. Proin ac odio semper, aliquam leo ac, egestas urna.', N'Maecenas aliquam nisi lacus. Proin tempor placerat libero quis tincidunt. Etiam magna nunc, elementum et blandit eget, ullamcorper ut nisi. Aliquam tortor orci, accumsan ac justo eget, feugiat aliquet turpis. Quisque faucibus mollis metus, sit amet tempor nisl tincidunt efficitur. Mauris nec dui lorem. Duis scelerisque purus ac gravida finibus. Aenean a leo sed diam rhoncus elementum.', N'Apprendre', CAST(0x0000A95500A7CABB AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'6b751675-6fb2-e811-8222-2c600c6934be', N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'aadsqdsqdlkjl', N'Modif description réussie!!!!', N'vvvvvvvvvvv', CAST(0x0000A95400AC4F9C AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'07615c20-00bc-e811-8225-2c600c6934be', N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Test par modif', N'Modif description réussie!!!!', N'Modif targeteeee| Ok', CAST(0x0000A96600FE8C09 AS DateTime), N'07615c20-00bc-e811-8225-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'6c764f74-a8cf-e811-822a-2c600c6934be', N'de237780-1da1-e811-8221-2c600c6934be', N'9ab7771d-f69f-e811-8220-2c600c6934be', N'980a694a-40ba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Rédiger un rapport de stage', N'L''art de la rédaction de rapport de stage', N'Maîtriser la rédaction de rapport de stage', CAST(0x0000A97901073CA9 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'be0a0ffe-b3d3-e811-822a-2c600c6934be', N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'c76487e0-b3d3-e811-822a-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Mon titre', N'Ma description', N'Mes cibles', CAST(0x0000A97E0141A3E4 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'3ca94d4b-b6d3-e811-822a-2c600c6934be', N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'aaaddddd', N'aaaaaaaaaa', N'aaaaa', CAST(0x0000A97E01462D5C AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'a556ced7-e3d6-e811-822a-2c600c6934be', N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'980a694a-40ba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'aaaaaaaaaarr', N'dssssssssssss', N'dddddddddddd', CAST(0x0000A9820157A5DF AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'8ba35141-85ba-e811-8225-2c600c6934be', N'89b16d41-9c9c-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Droit international public', N'Pour définir le Droit international on se réfère souvent à une définition proposée par le dictionnaire Basdevant des années 1960 :

« Le Droit international (public) est l’ensemble des règles juridiques 
régissant les rapports internationaux ».
', N' Apprendre le droit international public', CAST(0x0000A95E011E9EE5 AS DateTime), N'8ba35141-85ba-e811-8225-2c600c6934be.jpg', NULL)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'af0dc92e-78a7-e811-8221-2c600c6934be', N'7cce715f-f7a1-e811-8221-2c600c6934be', 1, N'Faites connaissance avec Python', N'Bienvenue dans ce cours à la découverte du monde fabuleux de la programmation ! Nous allons ensemble apprendre Python, un langage bien connu des scientifiques, des startups et des amateurs d’un certain groupe d’humoristes britanniques.', N'Oui, vous avez bien lu ! Pour expliquer l’origine du langage, revenons un peu en arrière. En 1989, par une froide nuit néerlandaise, un développeur du plat pays nommé Guido van Rossum s’ennuie. Il cherche un moyen de s’occuper pendant la période qui précède Noël car les bureaux de son entreprise sont fermés. Quand certains auraient dévoré l’intégrale d’Urgences ou décoré un sapin, lui se lance dans l’invention d’un langage. Etant un grand fan des Monty Python et d’humeur irrévérencieuse, il l’appelle Python. Voilà pourquoi les développeurs Python ont de l’humour et s’amusent à glisser des petites blagues dans leur code ! ', 18000000000)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'c8b28f67-2da8-e811-8221-2c600c6934be', N'7cce715f-f7a1-e811-8221-2c600c6934be', 2, N'Posez les fondations de votre programme', N'Avant de continuer notre programme, j’ai bien envie de ne plus utiliser l’interpréteur.', N'Attends, tu nous as fait tout un pensum sur l’utilisation de l’interpréteur et maintenant tu veux l’abandonner ?
Cher lecteur,
                vous avez raison !Je ne vais pas l’abandonner : je vais plutôt l’utiliser en complément d’un éditeur de texte.

Vous avez certainement remarqué qu’il devient de plus en plus compliqué de travailler avec l’interpréteur.Quand vous le quittez, tout s’efface.Vous devez vous souvenir du code créé.De plus, vous ne pouvez pas modifier facilement une variable.

Peut - être avez - vous déjà commencé à créer un fichier externe pour prendre des notes et conserver une trace des différentes commandes ? C’est exactement ce que nous allons faire: créer un fichier qui conservera nos commandes, une par une, puis lancer le fichier avec python. Au lieu d’entrer, à la main, chaque commande, vous lancerez le programme.C’est plus rapide, non ? !', 10000000000)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'8740251b-1cb0-e811-8222-2c600c6934be', N'd2a6d649-abaf-e811-8222-2c600c6934be', 1, N'L''expérience de la conscience', NULL, N'La conscience consiste dans la faculté qui me permet de prendre connaissance de mes actes, et en particulier de l''activité de mon esprit. Elle se définirait donc comme une forme de connaissance. C''est ce que semble confirmer l''étymologie: "cum sciens signifie "avec connaissance, accompagné de savoir. De même, les expressions "perdre conscience" ou "perdre connaissance", que l''on emploie indifféremment, témoignent d''une proximité entre conscience et connaissance.', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'4f5ca280-39b0-e811-8222-2c600c6934be', N'd2a6d649-abaf-e811-8222-2c600c6934be', 2, N'Difficultés de l''introspection', N'Pour que mon être réel et mon être tel qu''il m''apparaît coïncident exactement, il faudrait d''abord que je n''ignore rien de ce que je suis. La conscience que j''ai de moi-même, autrement dit, doit être complète, sans qu''aucune partie de mon esprit ne soit inconsciente. Pour Descartes, on l''a vu, tout ce qui est intellectuel est conscient. Parmi les opérations de nature intellectuelle, l''auteur du Discours de la méthode comprend les actes sensoriels: sentir, c''est-à-dire voir, entendre etc... Or, on peut fort bien sentir sans y penser, sans en avoir conscience. Par exemple, on sursaute lorsque le tic-tac de l''horloge, bruit familier que l''on croyait ne plus entendre tant on y est habitué, s''arrête soudain. C''est donc qu''on l''entendait bien; mais on n''en n''avait pas conscience.', N'Leibniz désigne ce genre de phénomène sous le nom de «petites perceptions» ou «perceptions insensibles», c''est-à-dire inconscientes. La perception désigne aussi bien la perception sensible que la représentation d''une idée. Penser, aussi bien que voir ou entendre, sont des formes de perception. Leibniz distingue la perception de l''aperception (de «apercevoir»). L''aperception, c''est la conscience que l''on a d''une perception. Formulée en termes leibniziens, la thèse de Descartes devient: toute perception implique aperception; toute perception est ipso facto aperception, ou toute perception est aperçue. Leibniz rompt avec Descartes et affirme l''existence de perceptions insensibles, c''est-à-dire de perceptions inaperçues. Leibniz propose cet exemple (Nouveaux essais sur l''entendement humain). Lorsque j''entends une vague s''écraser contre un rocher, ce dont j''ai conscience, c''est un bruit unique, un bruit sourd, un grondement. </ br>Or, ce bruit est en réalité composé de la multitude des petits bruits provoqués par l''infinité des gouttes d''eau qui composent la vague.Cette infinité de petits bruits, je l''entends, car si je ne les entendais pas, leur somme ne pourrait pas produire ce grondement qui est celui de la vague (une infinité de petits riens ne peut faire un bruit). Je les entends donc, mais sans pouvoir les distinguer, sans en avoir conscience, sans m''en apercevoir.Il y a donc des perceptions qui ne sont pas conscientes.Leibniz sépare ce qui était identifié par Descartes.Toute perception n''est pas aperçue. Descartes a eu tort d''assimiler les actes sensoriels aux actes intellectuels, définis comme nécessairement conscients.Ce que Leibniz révèle au sujet de la perception ne peut - il être étendu à d''autres actes?', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'aa1c6e19-cab1-e811-8222-2c600c6934be', N'a2f9bc01-cab1-e811-8222-2c600c6934be', 1, N'Choisir le bon héros', NULL, N'<h1>Pick Anti-Mage</h1>

<p>GG</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'80efc836-cab1-e811-8222-2c600c6934be', N'a2f9bc01-cab1-e811-8222-2c600c6934be', 2, N'Laning phase', N'Comment gagner sa lane et gagner du XP', N'<h1>Last Hits et Kills</h1>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'3326128a-36b3-e811-8222-2c600c6934be', N'ac5a4353-36b3-e811-8222-2c600c6934be', 1, N'Donec in tincidunt ipsum. Aenean consectetur fringilla eros nec posuere. Ut ultricies molestie eros. ', N'Praesent porttitor massa eu commodo blandit. Etiam vel mi a mauris mollis bibendum. Mauris tempor facilisis mattis. Morbi hendrerit eu ante a ultrices. Vivamus consequat tellus nunc. Duis nec mi at arcu semper porta non in nulla. Vivamus euismod mi at mattis interdum. Nam a libero massa. Ut sed vestibulum eros. Sed ornare augue risus, sit amet imperdiet urna bibendum a. Nulla ac auctor nunc.', N'<p>Proin dapibus varius leo. Pellentesque nec aliquet augue. Etiam velit velit, pellentesque eu gravida ut, consequat quis est. Nunc ultrices diam quis pellentesque rhoncus. Vivamus at interdum arcu, in congue velit. Pellentesque ut magna et urna vulputate hendrerit sed sit amet ligula. Curabitur vel ligula id orci accumsan ultricies nec eget leo. Cras velit odio, aliquam ut mauris id, finibus facilisis felis. Suspendisse sit amet lacus nec nibh scelerisque consectetur. Morbi dignissim, felis ac pulvinar varius, ligula enim sagittis sapien, id pharetra mi leo nec mauris. Aenean posuere mollis tincidunt. Ut vitae nulla id ipsum commodo suscipit at id libero. Nullam imperdiet nunc a magna pellentesque, id auctor sem rutrum. Nullam vitae iaculis enim. Quisque ut augue ante. Sed ante diam, feugiat vitae posuere non, mattis mattis risus.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'bbc62bf0-06bc-e811-8225-2c600c6934be', N'07615c20-00bc-e811-8225-2c600c6934be', 1, N'Mon petit chapitre 1', N'aaaaaaaaaaaaaaaaaaaaaaaa', N'<p>Bla vldsdqdqsdsqdq</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'153579ba-4cba-e811-8225-2c600c6934be', N'e8a172b7-37b1-e811-8222-2c600c6934be', 3, N'Le processus de formation des engagements Conventionnels', NULL, N'<p>Deux phases sont &agrave; distinguer, l&rsquo;&eacute;laboration et la ratification. En effet certains Etats &eacute;laborent un trait&eacute; mais ne le signent pas et d&rsquo;autre ne l&rsquo;&eacute;laborent pas mais participent &agrave; la ratification.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'246d0775-09bc-e811-8225-2c600c6934be', N'07615c20-00bc-e811-8225-2c600c6934be', 2, N'Titre chapitre 2', N'aaaaaaaaaaaaaa', N'<p>aaaaaaaaaaaaaa</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'f436bfeb-59c1-e811-8226-2c600c6934be', N'07615c20-00bc-e811-8225-2c600c6934be', 4, N'ffffffffffffffffffffff', N'gggggggggggggggggggggggg', N'<p>hhhhhhhhhhhhhhh</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'43e62df7-39b0-e811-8222-2c600c6934be', N'd2a6d649-abaf-e811-8222-2c600c6934be', 3, N'Sincérité et mauvaise foi', N'Une difficulté supplémentaire, c''est que l''introspection, pour être une connaissance, doit viser la vérité. Par conséquent, elle doit être sincère. Or, celui qui s''observe peut avoir intérêt à cacher une partie de ce qu''il découvre, de façon plus ou moins consciente. En réalité, même si l''introspection se présente comme une conduite de sincérité, son but réel n''est pas la connaissance de soi. C''est ce que révèle l''analyse des récits autobiographiques. Toute une littérature est dominée par le souci de l''introspection et de la sincérité.', N'Cette tradition naît avec Montaigne. Au début des Essais, l''avis au lecteur prévient, dès les premiers mots: «Ceci est un livre de bonne foi» . Plus loin, l''auteur exprime sa volonté de «se peindre (...) tout nu», sans masque. Elle est continuée par Rousseau qui déclare, dans les Confessions: «Je veux montrer à mes semblables un homme dans toute la vérité de la nature». Dans l''exercice littéraire de la connaissance de soi par soi s''annonce un souci de sincérité. Mais ce qui est visé n''est pas la connaissance de soi. Ce qui explique l''échec constaté par Rousseau, plus tard, dans les Rêveries: «Parfois j''ai caché le côté difforme en me peignant de profil» (4ème promenade). </ br>En réalité, l''enjeu est tout autre. Ce genre littéraire, qui prétend avoir pour but la connaissance de soi, ne prend en réalité son sens que si on le met en relation avec un certain type de conduite religieuse. Cet exercice ne fait que répéter un comportement religieux: celui de la confession. A cet égard, le titre du livre de Rousseau en dit plus qu''il ne voudrait.Le but de la confession ou de l''aveu n''est pas la connaissance de soi, mais la libération à l''égard du mal que l''on a commis, la délivrance du remords, une sorte d''exorcisme. Il est clair que c''est là le véritable enjeu des Confessions de Rousseau: se persuader qu''il n''est pas méchant.', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'5bcf88f5-59c1-e811-8226-2c600c6934be', N'07615c20-00bc-e811-8225-2c600c6934be', 5, N'Test update chapitre 5b', N'Une difficulté supplémentaire, c''est que l''introspection, pour être une connaissance, doit viser la vérité. Par conséquent, elle doit être sincère. Or, celui qui s''observe peut avoir intérêt à cacher une partie de ce qu''il découvre, de façon plus ou moins consciente. En réalité, même si l''introspection se présente comme une conduite de sincérité, son but réel n''est pas la connaissance de soi. C''est ce que révèle l''analyse des récits autobiographiques. Toute une littérature est dominée par le souci de l''introspection et de la sincérité.', N'<p>Cette tradition na&icirc;t avec Montaigne. Au d&eacute;but des Essais, l&#39;avis au lecteur pr&eacute;vient, d&egrave;s les premiers mots: &laquo;Ceci est un livre de bonne foi&raquo; . Plus loin, l&#39;auteur exprime sa volont&eacute; de &laquo;se peindre (...) tout nu&raquo;, sans masque. Elle est continu&eacute;e par Rousseau qui d&eacute;clare, dans les Confessions: &laquo;Je veux montrer &agrave; mes semblables un homme dans toute la v&eacute;rit&eacute; de la nature&raquo;. Dans l&#39;exercice litt&eacute;raire de la connaissance de soi par soi s&#39;annonce un souci de sinc&eacute;rit&eacute;. Mais ce qui est vis&eacute; n&#39;est pas la connaissance de soi. Ce qui explique l&#39;&eacute;chec constat&eacute; par Rousseau, plus tard, dans les R&ecirc;veries: &laquo;Parfois j&#39;ai cach&eacute; le c&ocirc;t&eacute; difforme en me peignant de profil&raquo; (4&egrave;me promenade). <!-- br-->En r&eacute;alit&eacute;, l&#39;enjeu est tout autre. Ce genre litt&eacute;raire, qui pr&eacute;tend avoir pour but la connaissance de soi, ne prend en r&eacute;alit&eacute; son sens que si on le met en relation avec un certain type de conduite religieuse. Cet exercice ne fait que r&eacute;p&eacute;ter un comportement religieux: celui de la confession. A cet &eacute;gard, le titre du livre de Rousseau en dit plus qu&#39;il ne voudrait.Le but de la confession ou de l&#39;aveu n&#39;est pas la connaissance de soi, mais la lib&eacute;ration &agrave; l&#39;&eacute;gard du mal que l&#39;on a commis, la d&eacute;livrance du remords, une sorte d&#39;exorcisme. Il est clair que c&#39;est l&agrave; le v&eacute;ritable enjeu des Confessions de Rousseau: se persuader qu&#39;il n&#39;est pas m&eacute;chant.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'07de1838-e2d6-e811-822a-2c600c6934be', N'3ca94d4b-b6d3-e811-822a-2c600c6934be', 1, N'Mon petit chapitre', N'Ma description', N'<p>GGGGGGGGGGGGGGGgg</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'd4ec5b81-3ab1-e811-8222-2c600c6934be', N'e8a172b7-37b1-e811-8222-2c600c6934be', 1, N'titre chap', N'dddddddddd', N'<p>ggggggggggggggggggggg</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'11317fc1-3ab1-e811-8222-2c600c6934be', N'e8a172b7-37b1-e811-8222-2c600c6934be', 2, N'Mon chapitre', N'La description', N'<p>Contenu chapitre 2</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'fed2097a-9bb1-e811-8222-2c600c6934be', N'f4536738-9bb1-e811-8222-2c600c6934be', 1, N'Origine historique', NULL, N'<p>La th&eacute;orie de la Relativit&eacute; Restreinte &agrave; &eacute;t&eacute; publi&eacute;e en 1905 par Albert Einstein, et la l&eacute;gende veut qu&rsquo;il l&rsquo;ait imagin&eacute;e enti&egrave;rement seul. Ce n&rsquo;est pourtant pas le cas, et des travaux bien ant&eacute;rieurs l&rsquo;ont pr&eacute;c&eacute;d&eacute;e. Tout d&rsquo;abord, les travaux de Henri Poincar&eacute; et Hendrik Lorentz sur la transformation des coordonn&eacute;es, qui ont d&eacute;j&agrave; amen&eacute; la notion d&rsquo;espace-temps. Ensuite, l&rsquo;&oelig;uvre d&rsquo;Henri Poincar&eacute;, qui a publi&eacute; d&egrave;s 1902 une version de la Relativit&eacute; bien avanc&eacute;e. Le travail de Poincar&eacute; &eacute;tait une &oelig;uvre de math&eacute;maticien, et Einstein lui a ajout&eacute; l&rsquo;interpr&eacute;tation physique indispensable. Il ne faut pas oublier qu&rsquo;Einstein &eacute;tait un th&eacute;oricien et qu&rsquo;il a exerc&eacute; son intuition sur la fa&ccedil;on dont la Nature doit fonctionner. Une fois son opinion faite, il cherchait le moyen de la transposer dans une th&eacute;orie, et en g&eacute;n&eacute;ral, celle-ci lui donnait raison.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'71d3978d-9bb1-e811-8222-2c600c6934be', N'f4536738-9bb1-e811-8222-2c600c6934be', 2, N'La lumière', NULL, N'<p>La lumi&egrave;re &eacute;tant une onde &eacute;lectromagn&eacute;tique, voyons ce qu&rsquo;elle nous r&eacute;serve. La lumi&egrave;re est une onde, c&rsquo;est une affaire entendue. Apr&egrave;s avoir longtemps h&eacute;sit&eacute; entre une th&eacute;orie corpusculaire (d&eacute;j&agrave; les grecs&hellip;) et une th&eacute;orie ondulatoire, les physiciens se sont laiss&eacute;s convaincre par les exp&eacute;riences de diffraction et d&rsquo;interf&eacute;rences, que seules les ondes pouvaient expliquer. Donc, la lumi&egrave;re est une onde. Une onde se propage dans un milieu mat&eacute;riel&nbsp;! (pensez au son, qui est une variation de pression&nbsp;; heureusement il ne se propage pas dans le vide, sans quoi le Soleil nous ferait un dr&ocirc;le de vacarme).</p>

<p>Mais la lumi&egrave;re qui nous parvient du Soleil se propage dans le vide. Comment la lumi&egrave;re peut-elle se propager sans milieu mat&eacute;riel &nbsp;?</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'4cabb5fa-f2b1-e811-8222-2c600c6934be', N'48a60e26-f1b1-e811-8222-2c600c6934be', 1, N'aaaaaaaaaa', N'ddddddddddd', N'<p>dsqdqdd</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'17b924f6-f3b1-e811-8222-2c600c6934be', N'48a60e26-f1b1-e811-8222-2c600c6934be', 2, N'aaaaaaa', N'dsqqqqqqqqqqqq', N'<p>aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'c4a3e646-f4b1-e811-8222-2c600c6934be', N'48a60e26-f1b1-e811-8222-2c600c6934be', 3, N'yyyyyyyyy', N'rrrrrrrrrrrrrrrrrrr', N'<p>a</p>
', 81000000000)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'9dbe5a8e-27bc-e811-8225-2c600c6934be', N'07615c20-00bc-e811-8225-2c600c6934be', 3, N'Articles / déterminants sur les validators de Property', N'Spécifier les champs facultatis et requis sur formulaire', N'<p>alter table EXERCICEQUESTIONANSWER<br />
&nbsp; &nbsp;add constraint FK_EXERCICE_EXERCICEQ_EXERCICE foreign key (EXQCODE)<br />
&nbsp; &nbsp; &nbsp; references EXERCICEQUESTION (EXQCODE)<br />
go</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'f8779378-85ba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', 1, N'L’histoire et les caractéristiques du Droit international', NULL, N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Cette d&eacute;finition est globalement juste, mais elle est insuffisante pour d&eacute;finir pr&eacute;cis&eacute;ment ce qu&rsquo;est le Droit international (public). Et ce car le Droit international r&eacute;git certainement des rapports internationaux mais les rapports internationaux ne sont pas r&eacute;gis exclusivement par le Droit international. Une relation internationale est une relation entre deux sujets dont les &eacute;l&eacute;ments constitutifs ne sont pas tous enferm&eacute;s dans les fronti&egrave;res d&rsquo;un m&ecirc;me Etat. Les rapports entre deux Etats sont de ce point de vus presque toujours internationaux. Les rapports entre Etats et organisation internationales intergouvernementales (ONU&hellip;) sont presque toujours des rapports internationaux, r&eacute;gis de ce fait par le Droit international.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le probl&egrave;me apparait dans les rapports entre particuliers et les rapports entre Etats et particuliers (ex&nbsp;: mariage entre 2 personnes de nationalit&eacute;s diff&eacute;rentes). Ces rapports ne sont par r&eacute;gis par le Droit international. Les rapports entre les particuliers ne sont jamais des contrats internationaux. De nombreux auteurs se r&eacute;f&egrave;rent &agrave; une qualit&eacute; mat&eacute;rielle, qui est la qualit&eacute; des sujets dont les rapports sont r&eacute;gis par le Droit international, c&rsquo;est une conception moderne selon laquelle les droits internationaux r&eacute;gissent les droits respectifs des Etats. Aujourd&rsquo;hui, le nombre des sujets du Droit international a consid&eacute;rablement augment&eacute; car ont &eacute;t&eacute; cr&eacute;&eacute;es les organisations internationales, de plus les sujets internes sont aussi des sujets du Droit international.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le Droit international ne r&eacute;girait que les rapports entre certaines cat&eacute;gories de sujet. La Convention EDH cr&eacute;e des droits aux profits des particuliers, ensuite invocable devant les particuliers. La Cour EDH est une juridiction internationale. Si les sujets internes sont sujets de Droit international, alors il n&rsquo;y a plus de limite personnelle au champ du Droit international. Ce n&rsquo;est donc plus un crit&egrave;re permettant de d&eacute;finir le Droit international, on retombe alors sur la d&eacute;finition de Basdevant&hellip;</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Il faut alors utiliser l&rsquo;&eacute;l&eacute;ment distinctif, l&rsquo;origine, le fondement des normes du Droit international. Qu&rsquo;est-ce qui diff&eacute;rencie des r&egrave;gles de Droit international et des r&egrave;gles de Droit interne&nbsp;? Les r&egrave;gles de Droit international sont produites &agrave; l&rsquo;&eacute;chelle internationale et les r&egrave;gles internes sont produites &agrave; l&rsquo;&eacute;chelle nationale.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Ensemble des normes qui tirent leur validit&eacute; de l&rsquo;ordre juridique international. Si une r&egrave;gle est pos&eacute;e par trait&eacute;, alors il s&rsquo;agit de Droit international. Si la r&egrave;gle &eacute;mane d&rsquo;une loi, alors c&rsquo;est la constitution qui donne force obligatoire &agrave; ce texte, ce n&rsquo;est donc pas du Droit international.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le Droit international priv&eacute; r&eacute;git les conflits de loi et de juridiction, correspondant &agrave; la question de savoir dans un cadre donn&eacute; quel est la loi qui r&eacute;git la question et quel peut &ecirc;tre le juge comp&eacute;tent. L&rsquo;article 14 du Code civil sert de fondement pour la d&eacute;termination des r&egrave;gles de conflit.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:center"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><em><span style="font-size:11.0pt">Le Droit international est donc plus pr&eacute;cis&eacute;ment,</span></em></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:center"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><em><span style="font-size:11.0pt">l&rsquo;ensemble des r&egrave;gles composant l&rsquo;ordre juridique international.</span></em></span></span></p>
', 144000000000)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'bee8d0ad-85ba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', 4, N'Les caractéristiques du Droit international contemporain', NULL, N'<p>Le Droit interne est construit sur un mod&egrave;le hi&eacute;rarchique reposant sur la distinction des gouvernants et des gouvern&eacute;s, au sommet duquel on retrouve l&rsquo;Etat qui dicte la conduite &agrave; avoir aux individus et sanctionne toute transgression.<br />
A l&rsquo;inverse le Droit international est un mod&egrave;le anarchique (pas de hi&eacute;rarchie). Or pour une grande partie de sujet primaire, seule la souverainet&eacute; importe. Les Etats sont donc &eacute;gaux entre eux et les Etats ne peuvent se voir dicter leurs conduite par d&rsquo;autres Etats, chaque Etat est donc libre de d&eacute;terminer les r&egrave;gles qui le lient au Droit international. Ce fait a &eacute;t&eacute; modifi&eacute; avec le temps du fait du pouvoir important du Conseil de s&eacute;curit&eacute; de l&rsquo;ONU dans le domaine de la paix, qui permet d&rsquo;imposer des d&eacute;cisions, non seulement aux Etats membres de l&rsquo;ONU et aux Etats non membres.<br />
&nbsp;</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'3bba8586-85ba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', 2, N'La diversification des fonctions du Droit international.', NULL, N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt"><span style="color:black">La vocation du Droit international contemporain n&rsquo;est plus seulement d&rsquo;assurer la coexistence pacifique des Etats mais aussi de pr&eacute;server et de promouvoir certaines valeurs communes aux diff&eacute;rents &eacute;tats et aux peuples qui les composent. Ce changement de conception est intervenu au milieu du XIX<sup>e</sup>. Ce changement s&rsquo;est manifest&eacute; &agrave; propos des personnes impliqu&eacute;es directement dans les conflits arm&eacute;s. </span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt"><span style="color:black">Cela s&rsquo;est manifest&eacute; avec le Droit international humanitaire qui eut pour vocation d&rsquo;apaiser la souffrance des individus qui participent, ou sont confront&eacute;s, &agrave; la guerre. La naissance de ce droit remonte &agrave; la bataille de Solferino&nbsp;: l&rsquo;une des batailles qui a oppos&eacute; l&rsquo;Italie &agrave; l&rsquo;Autriche. Cette bataille a &eacute;t&eacute; une des plus meurtri&egrave;res de l&rsquo;histoire de l&rsquo;humanit&eacute;. A cette bataille &eacute;tait pr&eacute;sent Henri Dunant,</span></span><span style="font-size:11.0pt"> en voyage d&#39;affaires et d&eacute;couvre les d&eacute;g&acirc;ts humains de la bataille de Solferino. &Agrave; partir de cette exp&eacute;rience, il &eacute;crit un livre qu&#39;il publie en 1862,<span style="color:black"> dans lequel il propose de s&rsquo;entendre sur un nombre de r&egrave;gles &eacute;l&eacute;mentaire comme l&rsquo;obligation de laisser passer les secours. Ce livre a &eacute;t&eacute; bien re&ccedil;u par les puissances. Les Etats Europ&eacute;ens conclurent en 1864 la Convention de Gen&egrave;ve pour l&rsquo;am&eacute;lioration du sort des militaires bless&eacute;s dans les arm&eacute;es de campagne. C&rsquo;est une modification de la vocation du Droit international. Ce Droit international s&rsquo;est d&eacute;velopp&eacute;, notamment lors des conf&eacute;rences de la Haye de 1899 et 1907. Puis dans les ann&eacute;es 1930, 4 autres Conventions ont fait l&rsquo;objet d&rsquo;une r&eacute;forme avec les protocoles de 1977. Cette &eacute;volution s&rsquo;est aussi manifest&eacute;e avec le d&eacute;veloppement post&eacute;rieur &agrave; la 2<sup>&egrave;me</sup> Guerre Mondiale du Droit international des droits de l&rsquo;Homme avec la DDUC de 1948 qui est une r&eacute;solution de l&rsquo;assembl&eacute;e g&eacute;n&eacute;rale de l&rsquo;ONU. C&rsquo;est une innovation qui a &eacute;t&eacute; suivie de peu par des trait&eacute;s cr&eacute;ant eux des normes dans le domaine de a protection des droits de l&rsquo;Homme comme la Cour EDH dans le cadre du conseil de l&rsquo;Europe en 1950. Elle a &eacute;t&eacute; suivie par de nombreuses autres Conventions comme les 2 pactes des nations unies de 66, la Convention EDH de 1969 et la Charte Africaine des DH et des Peuples de 1981. Ces trait&eacute;s sont porteurs, comme les trait&eacute;s de DIDH de valeurs que le Droit international est cens&eacute; d&eacute;fendre, il ne se limite pas aux r&egrave;glements des diff&eacute;rents entre les &eacute;tats.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Ces trait&eacute;s sont par ailleurs porteurs de valeurs que le Droit international est cens&eacute; d&eacute;fendre.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le Droit international a pour mission d&rsquo;assure la coh&eacute;sion des Etats, repos&eacute; sur l&rsquo;&eacute;quilibre des puissances. La premi&egrave;re id&eacute;e est d&eacute;pass&eacute;e depuis la seconde moiti&eacute; de XX<sup>e</sup>, car le Droit international a pour but de prot&eacute;ger les individus ainsi que celui de r&eacute;gler les probl&egrave;mes &eacute;conomiques, &agrave; l&rsquo;environnement, &agrave; la gestion des ressources. Le Droit international r&eacute;git des questions touchant tous les probl&egrave;mes de soci&eacute;t&eacute;.</span></span></span></p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'0cad9db7-85ba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', 5, N'Un système décentralisé dans son application', NULL, N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Dans la r&eacute;alisation du Droit international, la souverainet&eacute; a pour cons&eacute;quence qu&rsquo;aucun Etat n&rsquo;est oblig&eacute; de se soumettre &agrave; un juge s&rsquo;il ne l&rsquo;a pas pr&eacute;alablement accept&eacute;. La souverainet&eacute; s&rsquo;est l&rsquo;&eacute;galit&eacute; et un Etat ne peut imposer &agrave; un autre le recours au juge. C&rsquo;est pourquoi l&rsquo;intervention de ce dernier est facultative. L&rsquo;accord peut &ecirc;tre sign&eacute; avant l&rsquo;existence du diff&eacute;rend, par l&rsquo;introduction d&rsquo;une clause au trait&eacute;. Ce type de clause s&rsquo;est beaucoup d&eacute;velopp&eacute;, notamment dans des trait&eacute;s multilat&eacute;raux. Le conseil adopte les accords sauf s&rsquo;il existe un consensus pour les rejeter. De plus en plus de juridictions sont soumise &agrave; l&rsquo;appr&eacute;ciation des parties. Il existe toutefois des domaines o&ugrave; la saisine d&rsquo;une juridiction internationale n&rsquo;est pas pr&eacute;vue. Le syst&egrave;me du Droit international est de moins en moins d&eacute;centralis&eacute;.</span></span></span></p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'1d867492-85ba-e811-8225-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', 3, N'Le dépassement de l’inter-Etatisme dans les relations internationales', NULL, N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le mod&egrave;le de Droit international repose sur l&rsquo;id&eacute;e selon laquelle c&rsquo;est parce qu&rsquo;aucune puissance Europ&eacute;enne n&rsquo;a le pouvoir d&rsquo;an&eacute;antir seule les autres qu&rsquo;elle est oblig&eacute;e de traiter avec les autres sur un pied d&rsquo;&eacute;galit&eacute;. A partir de la fin du XIX<sup>e</sup>, les RI ont chang&eacute; sous l&rsquo;influences d&rsquo;au moins 3 facteurs&nbsp;:</span></span></span></p>

<ul>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">La fin de l&rsquo;homog&eacute;n&eacute;it&eacute; politique de l&rsquo;Europe (r&eacute;volution sovi&eacute;tique de 1917).</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">L&rsquo;augmentation du nombre d&rsquo;Etat et la mont&eacute;e en puissance d&rsquo;Etats non europ&eacute;ens (Am&eacute;rique latine, d&eacute;colonisation).</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le mod&egrave;le de l&rsquo;&eacute;quilibre des puissances n&rsquo;a jamais atteint son objectif qui &eacute;tait d&rsquo;atteindre la coexistence pacifique entre les Etats (1<sup>&egrave;re</sup> et 2<sup>nd</sup> Guerre Mondiale).</span></span></span></li>
</ul>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Les Etats se sont tourn&eacute;s vers un autre mod&egrave;le de RI. Cette multiplication des Etats, la fin de l&rsquo;homog&eacute;n&eacute;it&eacute; politique, ont aboutit &agrave; la cr&eacute;ation de 3 institutions&nbsp;:</span></span></span></p>

<ul>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">La <strong>Convention multilat&eacute;rale</strong>. Bien qu&rsquo;ancienne, elles se sont beaucoup d&eacute;velopp&eacute;es (ex&nbsp;: Westphalie). Au d&eacute;but, il ne s&rsquo;agissait que d&rsquo;accords entre un petit nombre de pays. D&eacute;sormais, il s&rsquo;agit de l&rsquo;acte le plus important en Droit international.</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Les <strong>Conf&eacute;rences internationales</strong>. Les n&eacute;gociations aboutissant &agrave; des trait&eacute;s &eacute;taient men&eacute;es d&rsquo;Etat &agrave; Etat. Ce mode n&rsquo;a pas disparu, mais s&rsquo;est d&eacute;velopp&eacute; celui des conf&eacute;rences internationales. Tous les repr&eacute;sentants des Etats se r&eacute;unissent en un m&ecirc;me lieu pour discuter d&rsquo;un trait&eacute;. Le changement dans la mani&egrave;re de n&eacute;gocier les trait&eacute;s s&rsquo;est produit en 1856, lors du trait&eacute; de Paris relative &agrave; la guerre de Crim&eacute;e. La premi&egrave;re innovation est que pour la premi&egrave;re fois, une conf&eacute;rence &eacute;tait ouverte &agrave; de petits Etats (Sardaigne et Turquie) alors que jusqu&rsquo;&agrave; la deuxi&egrave;me moiti&eacute; du XIX<sup>e</sup> seuls les grands Etats &eacute;taient convi&eacute;s. La deuxi&egrave;me innovation fut la ratification de textes &agrave; port&eacute;e g&eacute;n&eacute;rale pr&eacute;vus pour s&rsquo;appliquer en temps de paix.</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><strong><span style="font-size:11.0pt">L&rsquo;organisation Internationale</span></strong><span style="font-size:11.0pt"> <strong>&agrave; vocation universelles</strong>. La premi&egrave;re fut la soci&eacute;t&eacute; des nations (SDN) fond&eacute;e en 1919 ayant pour vocation d&rsquo;assurer la paix entre les Etats en constituant un cadre dans lequel les Etats pouvaient dialoguer. Or ni les USA ni l&rsquo;URSS n&rsquo;y ont adh&eacute;r&eacute; d&egrave;s l&rsquo;origine. Elle fut un &eacute;chec concernant ces objectifs de pr&eacute;servation de la guerre. C&rsquo;est sur ses cendres, que fut fond&eacute;e l&rsquo;ONU. L&rsquo;ONU a &eacute;t&eacute; cr&eacute;&eacute;e par la charte de San-Francisco du 25 juin 1945, en m&ecirc;me temps que le <em>Syst&egrave;me des Nations Unis</em>. L&rsquo;ONU est une organisation a vocation g&eacute;n&eacute;raliste, structur&eacute;e autour 5 organes&nbsp;: </span></span></span>
	<ul style="list-style-type:circle">
		<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Deux organes politiques, 1 principale (l&rsquo;Assembl&eacute;e G&eacute;n&eacute;rale) et 1 restreinte (Conseil de s&eacute;curit&eacute; de l&rsquo;ONU compos&eacute; de 15 membres&nbsp;: 5 Permanents + 10 Elus).</span></span></span></li>
		<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Un organe administratif (le secr&eacute;tariat).</span></span></span></li>
		<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le Conseil &eacute;conomique sociale.</span></span></span></li>
		<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">La Cour internationale de justice.</span></span></span></li>
	</ul>
	</li>
</ul>

<p><span style="font-size:11.0pt"><span style="font-family:&quot;Times New Roman&quot;,serif">Un grand nombre d&rsquo;organisation internationales ont &eacute;t&eacute; cr&eacute;es depuis 1945 pour tenter d&rsquo;assurer la paix dans le monde. Mais c&rsquo;est l&rsquo;ONU qui a le plus boulevers&eacute; les RI, notamment du fait de l&rsquo;existence du Forum, ouvert en permanence, dans lequel les Etats peuvent discuter des sujets qu&rsquo;ils souhaitent (guerre, &eacute;conomie, environnement) sans qu&rsquo;une convocation ne soit n&eacute;cessaire. De plus le bouleversement provient du fait que la cr&eacute;ation s&rsquo;est accompagn&eacute;e du relancement des Etats. L&rsquo;interdiction de la guerre entre les Etats est ant&eacute;rieure &agrave; la cr&eacute;ation de l&rsquo;ONU (accord bilat&eacute;ral dans les ann&eacute;es 20). La charte &agrave; non seulement interdit la guerre, mais elle a reconnu au Conseil de s&eacute;curit&eacute; de l&rsquo;ONU le droit d&rsquo;utiliser la force militaire si n&eacute;cessaire. Depuis la cr&eacute;ation de l&rsquo;ONU de nombreux autres organisations internationales ont vu le jour aussi bien universelles (OMC) que r&eacute;gionales (Conseil de l&rsquo;Europe, OTAN, MERCOSUR). La diplomatie multilat&eacute;rale montre que les RI ont totalement chang&eacute; depuis les trait&eacute;s de Westphalie. L&rsquo;interd&eacute;pendance et la solidarit&eacute; sont &agrave; la base des relations entre Etats</span></span></p>
', 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'7cce715f-f7a1-e811-8221-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A97800F604BE AS DateTime), 2, 1)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'd2a6d649-abaf-e811-8222-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A95F00E4C61F AS DateTime), 1, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'ac5a4353-36b3-e811-8222-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A961013A871B AS DateTime), 1, NULL)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'8ba35141-85ba-e811-8225-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A95F00E29D28 AS DateTime), 1, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'9eeedeac-91af-e811-8222-2c600c6934be', N'7cce715f-f7a1-e811-8221-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A95E00D906F1 AS DateTime), 1, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'0ba7a6da-76bd-e811-8224-2c600c6934be', N'd2a6d649-abaf-e811-8222-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A95B00AD2DC0 AS DateTime), 3, 4)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'0ba7a6da-76bd-e811-8224-2c600c6934be', N'f4536738-9bb1-e811-8222-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A95B00B14170 AS DateTime), 1, 2)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'0ba7a6da-76bd-e811-8224-2c600c6934be', N'a2f9bc01-cab1-e811-8222-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A95B00AA14E2 AS DateTime), 2, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'0ba7a6da-76bd-e811-8224-2c600c6934be', N'48a60e26-f1b1-e811-8222-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A95B00AFDD75 AS DateTime), 0, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'7ea5d441-59c5-e811-8228-2c600c6934be', N'07615c20-00bc-e811-8225-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A986011A5E58 AS DateTime), 1, 0)
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'1b403639-56c1-e811-8226-2c600c6934be', N'af0dc92e-78a7-e811-8221-2c600c6934be', 1, N'Pourquoi apprendre Python ?', N'<h4>Débuter facilement.</h4> Python est un langage parfait pour débuter. Il fonctionne sur tous les systèmes d’exploitation (Windows, Mac et Linux) et vous n’avez pas à utiliser un logiciel spécifique pour voir le résultat de votre code. Vous avez juste besoin d’un ordinateur. Et de votre tête. Alouette.

                            <h4>Gagner des sous.</h4>Le salaire moyen d’un développeur Python <strong>junior</strong> en France se situe entre 35 000 et 40 000 selon Hired et est en croissance selon Urban Linker,
                                            un cabinet de recrutement spécialisé dans les Startups.

                            <h4>Apprendre un langage reconnu.</h4>Python est le 4e langage le plus populaire selon l’index TIOBE et son usage est resté stable depuis une dizaine d’années.Vous avez la garantie d’utiliser longtemps ce que vous apprendrez dans ce cours !
                            Fan de statistiques ou de big data ? Python est un des langages principaux utilisés en data analysis(analyse de données) et en machine learning(apprentissage par la machine).
                            Envie de créer un robot qui vous servirait le café le matin ? Python est également le langage de référence pour apprendre la robotique.L’ordinateur le moins cher du monde($25) a d’ailleurs été conçu dans cet objectif : rendre l’informatique abordable et ludique.

                            <h4>Rejoindre une communauté mondiale.</h4> Active et drôle, la communauté Python saura vous accueillir. Avec 27 000 membres sur Meetup et plus de 40 groupes, il s’agit d’une des plus grandes communautés de France.En cherchant un peu vous trouverez certainement des rendez - vous dans la ville la plus proche pour aller boire un verre, parler code et débugger votre dernier programme.Vous rencontrez un souci ? Vous trouverez toujours une réponse sur Stack Overflow.
                            Guido van Rossum étant un fervent contributeur à des projets Open Source, il n’est pas étonnant que le langage soit très utilisé dans de nombreux projets libres. Il s’agit d’une des forces de la communauté.')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'1c403639-56c1-e811-8226-2c600c6934be', N'c8b28f67-2da8-e811-8221-2c600c6934be', 1, N'Créer un fichier externe', N'Sous Linux et Mac
Travailler avec un fichier externe se fait en deux étapes : vous créez le document puis vous l''exécutez. 

Utilisation d''un document externe
Commencez par créer un dossier concernant ce cours (évitez les noms à rallonge, même si  supercourstropinteressantsurpython.py  me flattera beaucoup !). A l’intérieur, créez un nouveau fichier  san_antonio.py . 

C''est bien, vous avez votre premier script ! A présent, comment l''ouvrir et le modifier ? En utilisant un éditeur de texte, un petit logiciel conçu pour écrire du code. Il en existe à foison mais je vous conseille Sublime Text. 

Vous pouvez réaliser ces actions en utilisant votre souris mais pourquoi ne pas le faire en ligne de commande ? En tant que véritable développeur·se en herbe, je suis sûre que vous avez très envie de savoir comment !

Ouvrez votre console (ou quittez l''interpréteur) et écrivez ces commandes : 

-  cd dossierdetravail  : déplacez-vous dans votre dossier de travail. Si votre dossier est enregistré dans votre bureau, tapez : cd  desktop/dossierdetravail .

-  touch nomdevotrefichier.py  : créer un nouveau fichier à l''endroit où vous êtes. 

-  subl nomdevotrefichier.py  : ouvrir le fichier avec Sublime Text pour pouvoir le modifier. 
                            Guido van Rossum étant un fervent contributeur à des projets Open Source, il n’est pas étonnant que le langage soit très utilisé dans de nombreux projets libres. Il s’agit d’une des forces de la communauté.')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'1d403639-56c1-e811-8226-2c600c6934be', N'8740251b-1cb0-e811-8222-2c600c6934be', 1, N'Le vrai moi est intérieur', N'<h4>Que suis-je?</h4> Qu''est-ce qui fait mon identité? On pourra être tenté de répondre que c''est mon apparence physique, en particulier mon visage. Cela est personnel. Seulement, mes traits changent avec le temps, au point qu''un ami perdu de vue aura du mal à me reconnaître après une longue absence. "Celui qui aime quelqu''un à cause de sa beauté, l''aime - t - il ? Non; car la petite vérole, qui tuera la beauté sans tuer la personne, fera qu''il ne l''aimera plus" (Pascal, Pensées, 323 Br.). La "personne" ne se réduit donc pas à l''apparence physique. Si l''on m''aime pour ma beauté, on ne m''aime pas, moi. Qu''est-ce donc que ce moi? Mon code génétique? Les scientifiques nous disent qu''il est unique.Pourtant, deux frères jumeaux possèdent une identité qui interdit de les confondre.Il consisterait plutôt en quelque chose d''intérieur - ce qu''on appelle la personnalité. Certes, mon caractère peut changer lui aussi. Mais on pourrait supposer l''existence d''un noyau stable, que l''on pourra appeler le moi. Si j''ai conscience d''une identité, il faut donc en chercher l''origine dans la conscience plutôt que dans le corps.Plutôt dans ce "je", sujet de pensée et d''action, qui commande au corps. Moi seul puis donc savoir qui je suis. En effet, ce que je donne à voir à mon entourage, cela est - il vraiment moi ? Est - ce que ce ne sont pas seulement des apparences trompeuses? Il se peut que je porte un masque.Balzac a parlé de la "comédie humaine".Un empereur romain avait eu pour dernier mot: "comedia finita est".On trouvera chez Sartre cette idée que chacun, en société, joue un rôle qu''il prend plus ou moins au sérieux, auquel il s''identifie plus ou moins bien.Par conséquent, ma véritable personnalité, pourra-t - on penser, s''identifie avec la partie la plus intime, la plus cachée de moi-même, celle que moi seul puis connaître: l''intériorité de ma conscience. Le vrai moi est caché. Le domaine de la conscience est celui de l''intériorité, une intériorité inaccessible et impénétrable pour l''autre.Ma subjectivité est comme une forteresse où je peux me réfugier et trouver la paix si l''on m''agresse.Personne ne peut venir y troubler la paix que je décide d''y faire régner. Pressé de questions, si je décide de garder le silence, personne ne pourra violer cette intimité. L''intériorité de la conscience est un refuge.On peut bien m''obliger à faire ce que je réprouve, on ne peut pas contraindre mes pensées. L''esclave peut ainsi rêver qu''il est libre. La contrepartie, c''est que "mon jardin secret est une prison"(Gaston Berger, Du prochain au semblable: esquisse d''une phénoménologie de la solitude).')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'1e403639-56c1-e811-8226-2c600c6934be', N'43e62df7-39b0-e811-8222-2c600c6934be', 1, N'How Did Van Gogh''s Turbulent Mind Depict One of the Most Complex Concepts in Physics?', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'1f403639-56c1-e811-8226-2c600c6934be', N'43e62df7-39b0-e811-8222-2c600c6934be', 2, N'incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,', N'architecto beatae vitae dicta sunt explicabo.')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'20403639-56c1-e811-8226-2c600c6934be', N'43e62df7-39b0-e811-8222-2c600c6934be', 3, N'ed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'21403639-56c1-e811-8226-2c600c6934be', N'43e62df7-39b0-e811-8222-2c600c6934be', 4, N'How Did Van Gogh''s Turbulent Mind Depict One of the Most Complex Concepts in Physics?', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'22403639-56c1-e811-8226-2c600c6934be', N'43e62df7-39b0-e811-8222-2c600c6934be', 5, N'incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,', N'architecto beatae vitae dicta sunt explicabo.')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'23403639-56c1-e811-8226-2c600c6934be', N'43e62df7-39b0-e811-8222-2c600c6934be', 6, N'ed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque', N'Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'24403639-56c1-e811-8226-2c600c6934be', N'd4ec5b81-3ab1-e811-8222-2c600c6934be', 1, N'ok', N'<p>contenu ok</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'25403639-56c1-e811-8226-2c600c6934be', N'80efc836-cab1-e811-8222-2c600c6934be', 1, N'Farmer', N'<p>Farmer est essentiel</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'26403639-56c1-e811-8226-2c600c6934be', N'c8b28f67-2da8-e811-8221-2c600c6934be', 2, N'Comparez des valeurs avec les opérateurs', N'Intéressons-nous maintenant à l’interaction avec l’utilisateur. La première phrase qui s’affichera sera une citation au hasard. Puis, nous proposerons deux alternatives :

Si l’utilisateur tape “entrée”, une nouvelle citation apparaît.

S’il tape “B”, le programme se ferme.

Nous allons commencer par écrire du pseudo-code, c’est-à-dire écrire ce que nous voulons que le programme fasse avec nos propres mots. Il s’agit d’une pratique très courante chez les développeurs.

 Tout mon code est écrit en anglais. Non pas que je souhaite mettre en avant mes incroyables talents linguistiques, mais plutôt car la langue du développement est l’anglais. Qui sait ce que deviendra votre projet demain ? Vous pouvez choisir de le rendre disponible en open source pour que chacun puisse y contribuer, y compris des non-francophones. Ou bien vous pouvez le vendre. En plus les accents français ne sont pas acceptés dans les noms de variables. Bref, coder en anglais est une bonne pratique. Rassurez-vous : il s’agit de mots simples et vous comprendrez tout.

La logique voudrait qu’on utilise le signe  =  pour comparer deux valeurs. Mais, si vous vous souvenez bien, ce signe est déjà utilisé pour assigner une valeur à une variable. Nous ne pouvons donc pas l’utiliser pour comparer !

C’est pourquoi nous doublons le signe égal par un autre égal pour signifier la comparaison, comme ceci :  ==  .

Les opérateurs de comparaison renvoient un booléen ( True  ou  False ) car vous posez une question fermée : c’est vrai ou ça ne l’est pas !

Integer egestas, neque eget pellentesque lacinia, sem magna fermentum purus, et blandit neque lorem id ipsum. In hac habitasse platea dictumst. Etiam semper est lacus, a consectetur tortor malesuada id. Nunc egestas massa sapien, nec tempus eros ullamcorper nec. Nam eros risus, efficitur et hendrerit non, ultricies sit amet sem. Fusce varius diam eu iaculis varius. Praesent sodales, tortor a gravida pharetra, nulla ligula accumsan sem, quis suscipit erat eros ut massa. Aenean dictum nibh posuere neque rutrum, quis congue turpis pharetra. Curabitur sed cursus justo, nec facilisis tortor. Integer nec justo vehicula, pharetra eros in, consectetur mi. Fusce hendrerit rhoncus arcu nec convallis. Proin quis neque vitae dolor lacinia mollis a id ipsum. Nulla ornare lorem vitae lacus accumsan semper. Donec iaculis est mauris, ut varius magna maximus vel.

Vestibulum ornare at orci in volutpat. Etiam ac risus vitae lectus laoreet scelerisque. Vivamus ut vestibulum ipsum. Quisque malesuada ante pretium nunc ultricies, et congue enim faucibus. Sed lobortis diam eget ipsum mattis feugiat. Vestibulum rutrum imperdiet pellentesque. Suspendisse tristique varius risus. Proin vel pharetra nisi. Ut ante tellus, eleifend eget tortor sed, posuere sollicitudin dui. Morbi elementum tellus non condimentum aliquam. Mauris eget vulputate nisl. Curabitur pharetra tortor neque, eget sodales leo pretium eu.

Nam ullamcorper metus non urna lacinia porttitor. Nulla facilisis ligula sit amet tellus consectetur, a feugiat quam egestas. Nam ac faucibus lorem. Duis tristique nibh vel ligula tristique efficitur. Morbi dapibus egestas ex, quis finibus neque semper vitae. Aenean est mi, dictum quis urna ut, euismod scelerisque diam. Nunc molestie ipsum at facilisis molestie. Maecenas imperdiet nunc nunc, vitae faucibus justo eleifend sagittis. Pellentesque accumsan dictum urna sollicitudin ornare. Vestibulum efficitur nibh ac ex pulvinar, quis sollicitudin augue facilisis. Praesent posuere, lorem ut maximus aliquet, urna nibh aliquet libero, id faucibus nulla erat et mi. Ut auctor metus quis est sodales hendrerit. Nullam orci erat, aliquet eu fermentum et, maximus quis ipsum.

Maecenas enim ipsum, molestie vitae consectetur in, sagittis ac tellus. Suspendisse interdum urna ac orci elementum, luctus sodales ligula lacinia. Nunc id pharetra sem, ac interdum ipsum. Phasellus tempus feugiat odio sagittis mattis. Cras tempus rutrum sem ac sodales. Nullam sapien odio, finibus id turpis quis, vulputate ullamcorper felis. Fusce felis massa, molestie ac vestibulum nec, eleifend ac sem. Quisque vitae risus velit. Sed euismod urna quis auctor aliquet. Suspendisse accumsan metus leo, eleifend dapibus sem cursus at. Vivamus condimentum interdum ante, vel egestas arcu ornare et. Donec mollis non nulla nec mattis.')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'27403639-56c1-e811-8226-2c600c6934be', N'11317fc1-3ab1-e811-8222-2c600c6934be', 1, N'La partie 1', N'<p>Centenu chapitre 2 part 1</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'28403639-56c1-e811-8226-2c600c6934be', N'11317fc1-3ab1-e811-8222-2c600c6934be', 2, N'La partie 2', N'<p>Centenu chapitre 2 part 2</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'29403639-56c1-e811-8226-2c600c6934be', N'11317fc1-3ab1-e811-8222-2c600c6934be', 3, N'La partie 3', N'<p>Centenu chapitre 2 part 3</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'2a403639-56c1-e811-8226-2c600c6934be', N'fed2097a-9bb1-e811-8222-2c600c6934be', 1, N'Justification', N'<p>Pourquoi a-t-on remis en question la&nbsp;<a href="https://astronomia.fr/6eme_partie/RelativiteGalileenne.php">Relativit&eacute; Galil&eacute;enne</a>, alors que toutes les exp&eacute;riences de M&eacute;canique &eacute;taient si bien expliqu&eacute;es&nbsp;?</p>

<p>Rappellons que la M&eacute;canique C&eacute;leste s&rsquo;est d&eacute;velopp&eacute;e au cours du XVII<sup>e</sup>&nbsp;si&egrave;cle, et que ses performances sont exceptionnelles&nbsp;! Elles ont permis de pr&eacute;dire les &eacute;clipses avec une pr&eacute;cision de quelques secondes (la th&eacute;orie de la Lune sera am&eacute;lior&eacute;e par Brown en 1930). Alors, pourquoi changer une &eacute;quipe qui gagne&nbsp;?</p>

<p>Le probl&egrave;me n&rsquo;est pas venu de la M&eacute;canique, mais de l&rsquo;Electricit&eacute;. Plus pr&eacute;cis&eacute;ment, de la th&eacute;orie de l&rsquo;Electromagn&eacute;tisme achev&eacute;e par Maxwell.</p>

<p>Le texte qui suit&nbsp;<em>n&rsquo;est pas</em>&nbsp;un cours de Relativit&eacute; Restreinte. Son but est de montrer comment la Relativit&eacute; r&eacute;soud les probl&egrave;mes pos&eacute;s par les th&eacute;ories ant&eacute;rieures, et comment elle s&rsquo;est d&eacute;velopp&eacute;e.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'2b403639-56c1-e811-8226-2c600c6934be', N'71d3978d-9bb1-e811-8222-2c600c6934be', 1, N'L’éther', N'<p>Pour contourner cette difficult&eacute;, les physiciens ont imagin&eacute; l&rsquo;existence d&rsquo;un milieu qui baignerait tout l&rsquo;espace, vide ou non, et dans lequel la lumi&egrave;re se propagerait&nbsp;; c&rsquo;est un milieu&nbsp;<em>ad-hoc</em>&nbsp;qu&rsquo;ils ont nomm&eacute;&nbsp;<em>&eacute;ther</em>. Tous les ph&eacute;nom&egrave;nes que l&rsquo;on consid&egrave;re en physique sont des&nbsp;<strong>ph&eacute;nom&egrave;nes locaux</strong>&nbsp;! Leur distance spatiale et temporelle est petite. Par contre, la notion d&rsquo;&eacute;ther est une&nbsp;<strong>notion globale</strong>.</p>

<p>Le probl&egrave;me &eacute;tait alors de le mettre en &eacute;vidence, et d&rsquo;en d&eacute;finir les propri&eacute;t&eacute;s exactes (par rapport &agrave; la mati&egrave;re en particulier).</p>

<p>L&rsquo;&eacute;ther, s&rsquo;il existait, constituerait un r&eacute;f&eacute;rentiel absolu, par rapport auquel on pourrait d&eacute;terminer tous les mouvements. Le repos par rapport &agrave; l&rsquo;&eacute;ther serait envisageable, contrairement &agrave; ce qu&rsquo;on a dit au sujet de la Relativit&eacute; Galil&eacute;enne. Mais l&rsquo;&eacute;ther n&rsquo;&eacute;tant pas directement accessible (on ne peut y poser un rep&egrave;re), il n&rsquo;y a pas de contradiction dans la th&eacute;orie.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'2c403639-56c1-e811-8226-2c600c6934be', N'4f5ca280-39b0-e811-8222-2c600c6934be', 1, N'La distance à soi', N'Etre conscient de ce que l''on est, c''est aussitôt ne plus l''être, être déjà au-delà, c''est avoir pris un recul. Prendre conscience de soi, suppose une sorte de dédoublement («une sorte de»: je suis un) entre moi comme objet et moi comme sujet. On ne peut prendre conscience que de quelque chose de différent de soi, on ne peut observer quelque chose que si l''on s''en distingue, qu''en l''observant de l''extérieur, en le surplombant. Je ne peux contempler le panorama que si je prends de la hauteur. De la même façon, si j''adhère à moi-même, si je coïncide avec ce que je suis, la conscience de moi-même est impossible. </br></br> La conscience de soi est impossible si ne s''introduit pas en moi une distance, une séparation, un dédoublement (de même que si j''ai les yeux collés sur l''objet, il m''est impossible de le voir; il faut un recul). La conscience d''objet est négation de l''objet.Si cet objet est soi - même, de la même façon, la conscience doit produire un recul, une mise à distance. La conscience est la capacité d''un recul par rapport à soi. Avoir conscience d''être ceci ou cela, c''est déjà ne l''être plus tout à fait, ou ne l''être plus de la même façon. Autrement dit, à la manière de tout instrument d''observation, la conscience risque de dénaturer, d''altérer son objet.</br> <b>Exemple 1</b>: prendre conscience que l''on est amoureux, c''est déjà ne plus l''être de la même façon (on cesse de se contenter de vivre son amour). Ex. 2: avoir conscience d''être heureux produit une modification de ce sentiment, susceptible de le mettre en danger.Je cesse en effet de vivre mon bonheur pour le penser.Si je cesse de le vivre, le suis - je encore? On se gâche facilement un plaisir quand on perçoit froidement sa situation au lieu de la vivre, d''y être pleinement engagé (ex.: dans une fête). Ex. 3 : avoir conscience que l''on a commis une faute, c''est déjà être en voie de la dépasser, c''est déjà s''en repentir. L''avouer, c''est une façon de s''en libérer. La faute dont j''ai conscience perd de son poids car elle n''est plus vécue, elle devient un objet de conscience, voire un objet de connaissance, d''analyse. La conscience fait de la faute un objet, quelque chose qui existe désormais comme séparé, détaché de moi, que je peux analyser froidement. Ex. 4 : cf. Montaigne, Essais, I, 20 (p. 152): le danger est toujours plus effrayant vu de loin. La méditation sur le danger est angoissante; une fois dans l''action, on s''aperçoit qu''il n''était pas si terrible. Le danger comme objet de conscience et le danger vécu, auquel on n''a pas le temps de penser parce que l''on est davantage concentré sur les gestes à accomplir, n''est pas le même. La conscience grossit le danger.L''appréhension est toujours pour beaucoup dans la douleur.')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'2d403639-56c1-e811-8226-2c600c6934be', N'fed2097a-9bb1-e811-8222-2c600c6934be', 2, N'Principe de la Relativité', N'<p>La Relativit&eacute; Galil&eacute;enne prend en compte les r&eacute;f&eacute;rentiels galil&eacute;ens, et impose que les lois de la M&eacute;canique soient invariantes par la transformation de Galil&eacute;e (lorsque les vitesses sont petites devant celle de la lumi&egrave;re, mais ceci n&rsquo;est pas indiqu&eacute;, et n&rsquo;appara&icirc;tra que plus tard comme un d&eacute;faut de la th&eacute;orie).</p>

<p>La Relativit&eacute; Restreinte conserve les r&eacute;f&eacute;rentiels galil&eacute;ens, mais g&eacute;n&eacute;ralise en levant la restriction sur les vitesses, et en imposant l&rsquo;invariance des lois de l&rsquo;&eacute;lectromagn&eacute;tisme. Elle impose donc l&rsquo;invariance de toutes les lois de la Physique dans la transformation de Lorentz-Poincar&eacute; (qui remplace la transformation de Galil&eacute;e).</p>

<p>Remarquez le principe de construction des deux th&eacute;ories&nbsp;: elles &eacute;tablissent par l&rsquo;observation un principe d&rsquo;invariance, puis l&rsquo;appliquent pour construire des lois math&eacute;matiques qui respectent ce principe.<br />
Le principe d&rsquo;invariance &eacute;tablit que les lois sont les m&ecirc;mes pour des observateurs en mouvement l&rsquo;un par rapport &agrave; l&rsquo;autre&nbsp;: &agrave; vitesse constante faible pour la Relativit&eacute; Galil&eacute;enne, &agrave; vitesse constante quelconque pour la Relativit&eacute; Restreinte.<br />
Les lois doivent &ecirc;tre les m&ecirc;mes pour un physicien sur le quai de la gare, et son coll&egrave;gue dans le train.<br />
Les lois de la Relativit&eacute; Restreinte sont litt&eacute;ralement construites &agrave; partir des lois de la Relativit&eacute; Galil&eacute;enne, modifi&eacute;es de fa&ccedil;ons &agrave; &ecirc;tre invariantes par la transformation de Lorentz.</p>

<p>&nbsp;</p>

<table>
	<tbody>
		<tr>
			<td><strong>Remarque</strong>&nbsp;:</td>
			<td>La Relativit&eacute; Restreinte se limite aux r&eacute;f&eacute;rentiels galil&eacute;ens.</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>La Relativit&eacute; G&eacute;n&eacute;rale englobera tous les r&eacute;f&eacute;rentiels.</td>
		</tr>
	</tbody>
</table>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'2e403639-56c1-e811-8226-2c600c6934be', N'71d3978d-9bb1-e811-8222-2c600c6934be', 2, N'Vitesse de la lumière', N'<p>La lumi&egrave;re pose un probl&egrave;me tout &agrave; fait particulier. La M&eacute;canique Classique admettait les interactions &agrave; distance instantan&eacute;es (la gravitation en particulier est une force ne d&eacute;pendant pas du temps pour sa transmission, mais attention, gravitation et lumi&egrave;re ne sont pas la m&ecirc;me chose). Par cons&eacute;quent, dans la physique classique, la lumi&egrave;re se propage instantan&eacute;ment. Or ceci est faux. La vitesse de la lumi&egrave;re est tr&egrave;s grande, mais finie. La premi&egrave;re d&eacute;monstration en a &eacute;t&eacute; donn&eacute;e par R&ouml;mer, qui a expliqu&eacute; une erreur p&eacute;riodique entre les positions calcul&eacute;es et mesur&eacute;es des satellites de Jupiter (sur les ph&eacute;nom&egrave;nes remarquables que sont leurs &eacute;clipses). La p&eacute;riode de cette erreur &eacute;tait &eacute;gale &agrave; la r&eacute;volution synodique de la plan&egrave;te, donc elle &eacute;tait li&eacute;e aux mouvements combin&eacute;s de Jupiter et de la Terre. R&ouml;mer a montr&eacute; qu&rsquo;il fallait tenir compte du temps que met la lumi&egrave;re pour nous parvenir, selon que Jupiter est en opposition ou en conjonction, la distance changeant de 300 millions de km entre ces deux points. Si la vitesse de la lumi&egrave;re est finie, l&rsquo;erreur s&rsquo;explique par la diff&eacute;rence de temps pour parcourir un trajet plus ou moins long. R&ouml;mer avait trouv&eacute; une vitesse de l&rsquo;ordre de 200.000 km s<sup>-1</sup>, ce qui est d&eacute;j&agrave; tr&egrave;s bien &eacute;tant donn&eacute;es les difficult&eacute;s de la m&eacute;thode. Remarquez que cette premi&egrave;re mesure a utilis&eacute; une distance de plusieurs centaines de millions de kilom&egrave;tres pour mettre cet effet en &eacute;vidence.</p>

<p>Par la suite, Foucault a r&eacute;alis&eacute; un montage permettant de mesurer la vitesse de la lumi&egrave;re sur une distance faible (quelques kilom&egrave;tres). Puis des m&eacute;thodes &eacute;lectriques ont &eacute;t&eacute; utilis&eacute;es, avec une bien meilleure pr&eacute;cision (la vitesse de la lumi&egrave;re intervient dans les &eacute;quations de l&rsquo;&eacute;lectromagn&eacute;tisme, puisque la lumi&egrave;re&nbsp;<em>est</em>&nbsp;un ph&eacute;nom&egrave;ne &eacute;lectromagn&eacute;tique).</p>

<p>Ces exp&eacute;riences mesuraient la vitesse de la lumi&egrave;re dans le vide (R&ouml;mer) puis dans l&rsquo;air (Foucault)&nbsp;; les mesures &eacute;lectromagn&eacute;tiques donnent la vitesse dans le vide, celle qui intervient dans les &eacute;quations de l&rsquo;&eacute;lectromagn&eacute;tisme.</p>

<p>Ensuite, de nombreuses exp&eacute;riences, dont celles, c&eacute;l&egrave;bres, de Fizeau et de Michelson-Morlay, ont prouv&eacute; que la vitesse de la lumi&egrave;re est la m&ecirc;me pour tous les observateurs galil&eacute;ens, que ceux-ci soient au repos ou en mouvement. Les physiciens se sont ensuite tourn&eacute;s vers les ph&eacute;nom&egrave;nes fins, li&eacute;s aux conditions de la mesure.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'2f403639-56c1-e811-8226-2c600c6934be', N'f8779378-85ba-e811-8225-2c600c6934be', 2, N'Naissance du droit moderne entre les XVe et XVIIe', N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Deux &eacute;v&egrave;nements majeurs ont boulevers&eacute; le Droit international</span></span></span></p>

<ul>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">La naissance des Etats au sens moderne (entit&eacute; disposant de la souverainet&eacute;).</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">La comp&eacute;tition que se livre les Etats &agrave; partir de la d&eacute;couverte de l&rsquo;Am&eacute;rique. Cette conqu&ecirc;te va attiser les tensions nationales.</span></span></span></li>
</ul>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le schisme d&rsquo;occident qui a fragilis&eacute; la Papaut&eacute; a &eacute;t&eacute; rallong&eacute; par le d&eacute;veloppement du Protestantisme. Puis les Etats vont se d&eacute;velopper &agrave; la suite de l&rsquo;Etat anglais. La finalisation de l&rsquo;Etat Fran&ccedil;ais eut lieu sous l&rsquo;empire de Louis XI. Deux &eacute;crits ont marqu&eacute; l&rsquo;histoire, l&rsquo;&oelig;uvre <u>le Prince</u> de Machiavel (&eacute;laboration de la raison d&rsquo;Etat) et <u>Les six livres de la R&eacute;publique</u> de Gaudin en 1576 (l&rsquo;Etat dispose du monopole de la contrainte sur les sujets s sur le territoire. L&rsquo;Etat ne saurait avoir un sup&eacute;rieur qui lui dicte son action). Le processus de la d&eacute;sint&eacute;gration de la Chr&eacute;tient&eacute; au profit de la cr&eacute;ation d&rsquo;Etat a atteint son apog&eacute;e avec le trait&eacute; de Westphalie le 24 octobre 1648. Tous les peuples europ&eacute;ens ont particip&eacute; &agrave; cette guerre de 30 ans. Ces accords prennent en consid&eacute;ration plusieurs changements&nbsp;:</span></span></span></p>

<ul>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Prennent acte de la fin du Saint Empire Germanique et son &eacute;clatement en 355 Etats dot&eacute;s d&rsquo;une ind&eacute;pendance relative.</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Reconnaissent l&rsquo;existence de nouveaux Etats (conf&eacute;d&eacute;ration Helv&eacute;tique et Hollande)</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Posent comme principe fondamentaux des RI&nbsp;: la souverainet&eacute; et l&rsquo;&eacute;galit&eacute; des Etats.</span></span></span></li>
</ul>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le Droit international moderne est bas&eacute; sur le consentement des Etats, avec une certaine forme d&rsquo;immunit&eacute; des Etats qui ne peuvent se voir imposer de r&egrave;gles, l&rsquo;engagement est &agrave; la base de toute r&egrave;gle de Droit international. Ces principes, cette conception des rapports internationaux, est la base du Droit international contemporain.</span></span></span></p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'33403639-56c1-e811-8226-2c600c6934be', N'9dbe5a8e-27bc-e811-8225-2c600c6934be', 1, N'Google/Facebook login btn', N'<p>&lt;table class=&quot;table table-striped table-bordered table-hover&quot;&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;thead&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;tr&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;th&gt;Etudiant&lt;/th&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;th&gt;Progression&lt;/th&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;th&gt;Chapitre / Partie&lt;/th&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;/tr&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;/thead&gt;</p>

<p>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;tbody&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;tr&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;td&gt;a&lt;/td&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;td&gt;10%&lt;/td&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;td&gt;02 / 01&lt;/td&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;/tr&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;/tbody&gt;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&lt;/table&gt;</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'34403639-56c1-e811-8226-2c600c6934be', N'9dbe5a8e-27bc-e811-8225-2c600c6934be', 2, N'aaaaaaaaa', N'<p>Looooooooooool</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'35403639-56c1-e811-8226-2c600c6934be', N'f8779378-85ba-e811-8225-2c600c6934be', 3, N'Evolution du Droit international, du droit moderne au droit contemporain', N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le droit issu du trait&eacute; de Westphalie &eacute;tait bas&eacute; sur une maxime et un principe&nbsp;:</span></span></span></p>

<ul>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">La paix et la tranquillit&eacute; &eacute;taient assur&eacute;es sur un juste &eacute;quilibre des puissances entre les Etats.</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le Droit international avait pour but de r&eacute;gler les diff&eacute;rents avant qu&rsquo;ils ne d&eacute;g&eacute;n&egrave;rent en guerre.</span></span></span></li>
</ul>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'36403639-56c1-e811-8226-2c600c6934be', N'f8779378-85ba-e811-8225-2c600c6934be', 1, N'Les racines du Droit international moderne', N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Le droit des gens antiques et m&eacute;di&eacute;vales.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Ce droit pr&eacute;sentait une caract&eacute;ristique tr&egrave;s diff&eacute;rente du droit moderne car ne concernait pas le comportement des Etats car la notion d&rsquo;Etat n&rsquo;existait pas (notion nait &agrave; l&rsquo;&eacute;poque moderne). A l&rsquo;&eacute;poque on ne parlait que de peuple. Ce droit naturel &eacute;tait pour l&rsquo;essentiel d&rsquo;essence divine. Les premi&egrave;res manifestations de ce droit sont tr&egrave;s anciennes. Le premier trait&eacute; remonte &agrave; 3000 av. JC, conclu en M&eacute;sopotamie entre Eanatoun (souverain de Nagash) et la ville d&rsquo;Ounna dont il avait r&eacute;ussi &agrave; repousser l&rsquo;attaque. L&rsquo;acte avait alors pour but de fixer une fronti&egrave;re entre ces deux territoires. Le premier trait&eacute; en notre possession r&eacute;dig&eacute; litt&eacute;ralement est un acte du milieu du 3<sup>&egrave;me</sup> mill&eacute;naire av. JC entre 2 souverains (D&rsquo;Ebla et le Roi d&rsquo;Assyrie) &eacute;tablissant des relations amicales et commerciales.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">2000 av JC le monde &eacute;tait divis&eacute; en 5 Empires&nbsp;: Babylone, l&rsquo;Egypte, le royaume Hittite, le Mitanni et l&rsquo;Assyrie.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Entre ces 5 royaumes existaient de nombreux &eacute;changes, notamment commerciales. Par ailleurs, afin de r&eacute;guler les relations entre ces Empires, de nombreux accords furent sign&eacute;s. Le plus connu fut celui sign&eacute; en 1279 av. JC entre Rams&egrave;s II et le souverain Khattousil III qui a mis fin &agrave; la bataille de Kadesh, &eacute;tablissant un pacte de non agression, la garantie mutuelle de la succession au tr&ocirc;ne, une assistance contre les rebelles et un r&eacute;gime d&rsquo;extradition des fuyards.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Cr&eacute;ation a cette p&eacute;riode des ambassadeurs, prox&egrave;ne (sorte de consul)&hellip; A cette p&eacute;riode fut aussi pos&eacute;e la r&egrave;gle de la d&eacute;claration officielle de guerre. Les conflits territoriaux &eacute;tant nombreux &agrave; l&rsquo;&eacute;poque, il a &eacute;t&eacute; mis en place des syst&egrave;mes de d&eacute;limitation des fronti&egrave;res par des bornes de pierre. Au cours de la Rome antique, les r&egrave;gles des droits des gens se sont encore plus d&eacute;velopp&eacute;es, mais se sont juridicis&eacute;es, port&eacute;es par des pratiques et des traditions. Les romains ont &eacute;tablis un corps de r&egrave;gles destin&eacute;es &agrave; r&eacute;gir les relations entre les diff&eacute;rents peuples de l&rsquo;empire romain. Et ce dans le but de r&eacute;gir les rapports priv&eacute;s et commerciaux entre les citoyens romains et les autres. Le <em>Jus Civil</em>&nbsp;: droit applicable entre citoyens romains uniquement. <em>Jus Gentium</em>&nbsp;: droit applicable entre tous.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Les invasions barbares ont conduit &agrave; la scission de l&rsquo;empire Romain. Chaque royaume ainsi form&eacute; connu une grande instabilit&eacute;, dont la pouvoir des chefs &eacute;tait bas&eacute; sur une puissance exclusivement territoriale&nbsp;; laissant de cot&eacute; les relations internationales.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Elles sont r&eacute;apparues au XI<sup>e</sup>. La situation g&eacute;opolitique n&rsquo;&eacute;tait pas tr&egrave;s propice &agrave; la mise en place de relations internationales, car le principal dirigeant &eacute;tait le Pape pr&eacute;tendant avoir sont pouvoir de Dieu. Ayant pour principales cons&eacute;quences la prolif&eacute;ration des guerres intestines. Au Moyen-&acirc;ge s&rsquo;est ensuite d&eacute;velopp&eacute;e la doctrine de la guerre juste (initialement d&eacute;velopp&eacute;e par St Augustin) ainsi que la <em>summa divisio</em> du droit de la paix et de la guerre. On a par la suite d&eacute;velopp&eacute; des droits de la mer.</span></span></span></p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'37403639-56c1-e811-8226-2c600c6934be', N'bee8d0ad-85ba-e811-8225-2c600c6934be', 1, N'Un système anarchique, dans sa production', N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">La souverainet&eacute;, qui signifie l&rsquo;&eacute;galit&eacute; a pour cons&eacute;quence qu&rsquo;aucun Etat ne peut se voir appliquer des normes qu&rsquo;il n&rsquo;a pas accept&eacute;. Il s&rsquo;agit d&rsquo;un mod&egrave;le contractuel. Les relations sont r&eacute;gies par des accords, un &eacute;change de consentement entre des personnes qui seront li&eacute;es par ces accords. On distingue 2 caract&eacute;ristiques du Droit international&nbsp;:</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<ul>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Les normes juridiques internationales sont toujours intersubjectives ou relatives. Ces normes ne sont opposables qu&rsquo;entre sujets ayant sign&eacute; le trait&eacute;.</span></span></span></li>
	<li style="text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">L&rsquo;ordre juridique international rejette toute diff&eacute;renciation juridique des normes. Ce mod&egrave;le hi&eacute;rarchique est normalement exclu en droit national car les Etats sont souverains et que la cr&eacute;ation de toute norme repose sur la volont&eacute; des Etats. La norme issue d&rsquo;un trait&eacute; &agrave; l&rsquo;autorit&eacute; qu&rsquo;un accord <em>solo consensu</em>, toutes les normes ont la m&ecirc;me valeur. Cette exclusion logique, li&eacute;e &agrave; la souverainet&eacute;, soul&egrave;ve une contradiction importante, cons&eacute;cration d&rsquo;une norme intransgressible (<em>jus cogens</em>) et donc sup&eacute;rieure &agrave; toutes les autres&nbsp;: Convention de Vienne. Ratifi&eacute; ni par les USA ni par la France &agrave; cause de ce fait l&agrave;. Lors de l&rsquo;ouverture du TPI en 1995 pour l&rsquo;ex-Yougoslavie, le TPI a d&eacute;clar&eacute; que certaines normes &eacute;taient sup&eacute;rieures &agrave; d&rsquo;autres. <strong><em>Arr&ecirc;t Youssouf du 21 septembre 2005</em></strong>&nbsp;: sur le contr&ocirc;le de validit&eacute; des d&eacute;cisions du Conseil de s&eacute;curit&eacute; de l&rsquo;ONU.</span></span></span></li>
</ul>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm; text-align:justify"><span style="font-size:12pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="font-size:11.0pt">Il s&rsquo;agit d&rsquo;un conflit de logique entre le respect de la souverainet&eacute; et l&rsquo;existence d&rsquo;une hi&eacute;rarchie des normes. Si il existe des normes <em>jus cogens (interdiction de la torture, interdiction de l&rsquo;esclavage)</em> il n&rsquo;y en a que tr&egrave;s peu. Le bouleversement provoqu&eacute; par des lois <em>jus cogens</em>, elle m&ecirc;me cr&eacute;&eacute;e par la volont&eacute; des Etats. Le syst&egrave;me de production des normes &agrave; l&rsquo;international est profond&eacute;ment anarchique.</span></span></span></p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'17993d8f-23c2-e811-8227-2c600c6934be', N'246d0775-09bc-e811-8225-2c600c6934be', 1, N'aaaaaaaaaaaaaa', N'<p>aaaaaaaaaaaaaaeeeeeeee</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'18993d8f-23c2-e811-8227-2c600c6934be', N'246d0775-09bc-e811-8225-2c600c6934be', 2, N'bbbbef', N'<p>aaae</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'19993d8f-23c2-e811-8227-2c600c6934be', N'246d0775-09bc-e811-8225-2c600c6934be', 3, N'aaaaaaaaaaaaaaeeeeaaaaaaaaaaaaaaeeee', N'<p>aaaaaaaaaaaaaaeeeeaaaaaaaaaaaaaaeeee</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'82e99e85-64c2-e811-8228-2c600c6934be', N'5bcf88f5-59c1-e811-8226-2c600c6934be', 1, N'Titre partie 1 new', N'<p>Contenu partie 1</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'83e99e85-64c2-e811-8228-2c600c6934be', N'5bcf88f5-59c1-e811-8226-2c600c6934be', 2, N'Titre partie 2 new ', N'<p>Contenu partie 2</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'84e99e85-64c2-e811-8228-2c600c6934be', N'5bcf88f5-59c1-e811-8226-2c600c6934be', 3, N'Titre partie 2 b new ', N'<p>Contenu partie 2 b</p>
')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'Sciences et technologies', N'', N'8cde8a70-9b9c-e811-8220-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'Marketing', N'', N'e97dc2f7-9b9c-e811-8220-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'89b16d41-9c9c-e811-8220-2c600c6934be', N'Droit', N'', N'89b16d41-9c9c-e811-8220-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'18c841d9-1ca1-e811-8221-2c600c6934be', N'Economie, social et Management', N'', N'18c841d9-1ca1-e811-8221-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'de237780-1da1-e811-8221-2c600c6934be', N'Philosophie et lettres', N'', N'de237780-1da1-e811-8221-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'Technologies d''information et de communication', N'', N'f79b7a04-1ea1-e811-8221-2c600c6934be.jpg')
INSERT [dbo].[SubscribeActivity] ([SUBID], [ACCSUBSCRIBER], [ACCSUBSCRIBED], [SUBDATE]) VALUES (N'253d56f0-e0d6-e811-822a-2c600c6934be', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', CAST(0x0000A9820151F92C AS DateTime))
INSERT [dbo].[SubscribeActivity] ([SUBID], [ACCSUBSCRIBER], [ACCSUBSCRIBED], [SUBDATE]) VALUES (N'e1588589-e1d6-e811-822a-2c600c6934be', N'bbf094e2-42b3-e811-8222-2c600c6934be', N'9eeedeac-91af-e811-8222-2c600c6934be', CAST(0x0000A98201531D6C AS DateTime))
INSERT [dbo].[SubscribeActivity] ([SUBID], [ACCSUBSCRIBER], [ACCSUBSCRIBED], [SUBDATE]) VALUES (N'6fc9ba0d-a5d7-e811-822a-2c600c6934be', N'e8bc0c1e-bb9f-e811-8220-2c600c6934be', N'9ab7771d-f69f-e811-8220-2c600c6934be', CAST(0x0000A98301480215 AS DateTime))
/****** Object:  Index [PK_ACCOUNT]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [PK_ACCOUNT] PRIMARY KEY NONCLUSTERED 
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [COUNTRY_OF_ACCOUNT_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [COUNTRY_OF_ACCOUNT_FK] ON [dbo].[Account]
(
	[CTRCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [TYPE_OF_ACCOUNT_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [TYPE_OF_ACCOUNT_FK] ON [dbo].[Account]
(
	[ATPCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ACCOUNTSTUDENT]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[AccountStudent] ADD  CONSTRAINT [PK_ACCOUNTSTUDENT] PRIMARY KEY NONCLUSTERED 
(
	[ACSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_STUDENT2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_STUDENT2_FK] ON [dbo].[AccountStudent]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [GENDER_OF_STUDENT_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [GENDER_OF_STUDENT_FK] ON [dbo].[AccountStudent]
(
	[GENCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNTSTUDY_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNTSTUDY_FK] ON [dbo].[AccountStudy]
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNTSTUDY2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNTSTUDY2_FK] ON [dbo].[AccountStudy]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ACCOUNTTEACHER]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[AccountTeacher] ADD  CONSTRAINT [PK_ACCOUNTTEACHER] PRIMARY KEY NONCLUSTERED 
(
	[ACTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_TEACHER2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_TEACHER2_FK] ON [dbo].[AccountTeacher]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [GENDER_OF_TEACHER_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [GENDER_OF_TEACHER_FK] ON [dbo].[AccountTeacher]
(
	[GENCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ACCOUNTTYPE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[AccountType] ADD  CONSTRAINT [PK_ACCOUNTTYPE] PRIMARY KEY NONCLUSTERED 
(
	[ATPCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 28/10/2018 14:32:54 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 28/10/2018 14:32:54 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_CATEGORY]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [PK_CATEGORY] PRIMARY KEY NONCLUSTERED 
(
	[CTGID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_COMMENT]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Comment] ADD  CONSTRAINT [PK_COMMENT] PRIMARY KEY NONCLUSTERED 
(
	[COMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_COMMENT_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_COMMENT_FK] ON [dbo].[Comment]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [COMMENTS_OF_LESSON_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [COMMENTS_OF_LESSON_FK] ON [dbo].[Comment]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STATE_OF_COMMENT_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [STATE_OF_COMMENT_FK] ON [dbo].[Comment]
(
	[DCSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_COMMENTANSWER]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[CommentAnswer] ADD  CONSTRAINT [PK_COMMENTANSWER] PRIMARY KEY NONCLUSTERED 
(
	[CANID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_COMMENTANSWER_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_COMMENTANSWER_FK] ON [dbo].[CommentAnswer]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ANSWER_OF_COMMENT_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ANSWER_OF_COMMENT_FK] ON [dbo].[CommentAnswer]
(
	[COMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STATE_OF_COMMENTANSWER_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [STATE_OF_COMMENTANSWER_FK] ON [dbo].[CommentAnswer]
(
	[DCSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_COUNTRY]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [PK_COUNTRY] PRIMARY KEY NONCLUSTERED 
(
	[CTRCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_CULTURE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Culture] ADD  CONSTRAINT [PK_CULTURE] PRIMARY KEY NONCLUSTERED 
(
	[CLTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_CURRICULUM]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Curriculum] ADD  CONSTRAINT [PK_CURRICULUM] PRIMARY KEY NONCLUSTERED 
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STUDY_OF_CURRICULUM_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [STUDY_OF_CURRICULUM_FK] ON [dbo].[Curriculum]
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMCATEGORY_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMCATEGORY_FK] ON [dbo].[CurriculumCategory]
(
	[CTGID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMCATEGORY2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMCATEGORY2_FK] ON [dbo].[CurriculumCategory]
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMLESSONS_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMLESSONS_FK] ON [dbo].[CurriculumLessons]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMLESSONS2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMLESSONS2_FK] ON [dbo].[CurriculumLessons]
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMSUBSCRIPTION_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMSUBSCRIPTION_FK] ON [dbo].[CurriculumSubscription]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMSUBSCRIPTION2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMSUBSCRIPTION2_FK] ON [dbo].[CurriculumSubscription]
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_DOCUMENTCONFIDENTIALITY]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[DocumentConfidentiality] ADD  CONSTRAINT [PK_DOCUMENTCONFIDENTIALITY] PRIMARY KEY NONCLUSTERED 
(
	[DCFCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_DOCUMENTSTATE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[DocumentState] ADD  CONSTRAINT [PK_DOCUMENTSTATE] PRIMARY KEY NONCLUSTERED 
(
	[DCSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CULTURE_OF_ENTITY_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CULTURE_OF_ENTITY_FK] ON [dbo].[EntityStrings]
(
	[CLTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Exercice] ADD  CONSTRAINT [PK_EXERCICE] PRIMARY KEY NONCLUSTERED 
(
	[EXCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXCERCICE_OF_LESSON_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [EXCERCICE_OF_LESSON_FK] ON [dbo].[Exercice]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICECORRECTION_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [EXERCICECORRECTION_FK] ON [dbo].[ExerciceCorrection]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICECORRECTION2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [EXERCICECORRECTION2_FK] ON [dbo].[ExerciceCorrection]
(
	[EXDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEDONE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[ExerciceDone] ADD  CONSTRAINT [PK_EXERCICEDONE] PRIMARY KEY NONCLUSTERED 
(
	[EXDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_EXERCICE_DONE_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_EXERCICE_DONE_FK] ON [dbo].[ExerciceDone]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICE_OF_EXERCICE_DONE_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [EXERCICE_OF_EXERCICE_DONE_FK] ON [dbo].[ExerciceDone]
(
	[EXCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEQUESTION]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[ExerciceQuestion] ADD  CONSTRAINT [PK_EXERCICEQUESTION] PRIMARY KEY NONCLUSTERED 
(
	[EXQCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FIELD_TYPE_OF_QUESTION_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [FIELD_TYPE_OF_QUESTION_FK] ON [dbo].[ExerciceQuestion]
(
	[FLDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [QUESTIONS_OF_EXERCICE_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [QUESTIONS_OF_EXERCICE_FK] ON [dbo].[ExerciceQuestion]
(
	[EXCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [TYPE_OF_QUESTION_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [TYPE_OF_QUESTION_FK] ON [dbo].[ExerciceQuestion]
(
	[EQTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [VALUES_CHOICE_OF_QUESTION_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [VALUES_CHOICE_OF_QUESTION_FK] ON [dbo].[ExerciceQuestion]
(
	[EQCCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICEQUESTIONANSWER_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [EXERCICEQUESTIONANSWER_FK] ON [dbo].[ExerciceQuestionAnswer]
(
	[EXDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICEQUESTIONANSWER2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [EXERCICEQUESTIONANSWER2_FK] ON [dbo].[ExerciceQuestionAnswer]
(
	[EXQCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEQUESTIONCHOICE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[ExerciceQuestionChoice] ADD  CONSTRAINT [PK_EXERCICEQUESTIONCHOICE] PRIMARY KEY NONCLUSTERED 
(
	[EQCCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEQUESTIONTYPE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[ExerciceQuestionType] ADD  CONSTRAINT [PK_EXERCICEQUESTIONTYPE] PRIMARY KEY NONCLUSTERED 
(
	[EQTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_FIELDTYPE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[FieldType] ADD  CONSTRAINT [PK_FIELDTYPE] PRIMARY KEY NONCLUSTERED 
(
	[FLDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_FOLLOWSTATE]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[FollowState] ADD  CONSTRAINT [PK_FOLLOWSTATE] PRIMARY KEY NONCLUSTERED 
(
	[FLSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_GENDER]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Gender] ADD  CONSTRAINT [PK_GENDER] PRIMARY KEY NONCLUSTERED 
(
	[GENCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_LESSON]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Lesson] ADD  CONSTRAINT [PK_LESSON] PRIMARY KEY NONCLUSTERED 
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CONFIDENTIALITY_OF_LESSON_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CONFIDENTIALITY_OF_LESSON_FK] ON [dbo].[Lesson]
(
	[DCFCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSON_POSTED_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [LESSON_POSTED_FK] ON [dbo].[Lesson]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STUDY_OF_LESSON_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [STUDY_OF_LESSON_FK] ON [dbo].[Lesson]
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_LESSONCHAPTER]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[LessonChapter] ADD  CONSTRAINT [PK_LESSONCHAPTER] PRIMARY KEY NONCLUSTERED 
(
	[LSCCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CHAPTER_OF_LESSON_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [CHAPTER_OF_LESSON_FK] ON [dbo].[LessonChapter]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSONFOLLOWED_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [LESSONFOLLOWED_FK] ON [dbo].[LessonFollowed]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSONFOLLOWED2_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [LESSONFOLLOWED2_FK] ON [dbo].[LessonFollowed]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSONFOLLOWED3_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [LESSONFOLLOWED3_FK] ON [dbo].[LessonFollowed]
(
	[FLSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_STUDY]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[Study] ADD  CONSTRAINT [PK_STUDY] PRIMARY KEY NONCLUSTERED 
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_SUBSCRIBEACTIVITY]    Script Date: 28/10/2018 14:32:54 ******/
ALTER TABLE [dbo].[SubscribeActivity] ADD  CONSTRAINT [PK_SUBSCRIBEACTIVITY] PRIMARY KEY NONCLUSTERED 
(
	[SUBID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_SUBSCRIBED_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_SUBSCRIBED_FK] ON [dbo].[SubscribeActivity]
(
	[ACCSUBSCRIBER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_SUBSCRIBER_FK]    Script Date: 28/10/2018 14:32:54 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_SUBSCRIBER_FK] ON [dbo].[SubscribeActivity]
(
	[ACCSUBSCRIBED] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (newsequentialid()) FOR [ACCID]
GO
ALTER TABLE [dbo].[AccountStudent] ADD  DEFAULT (newsequentialid()) FOR [ACSID]
GO
ALTER TABLE [dbo].[AccountTeacher] ADD  DEFAULT (newsequentialid()) FOR [ACTID]
GO
ALTER TABLE [dbo].[AccountType] ADD  CONSTRAINT [DF_ATPCODE]  DEFAULT (newsequentialid()) FOR [ATPCODE]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (newsequentialid()) FOR [CTGID]
GO
ALTER TABLE [dbo].[Comment] ADD  DEFAULT (newsequentialid()) FOR [COMID]
GO
ALTER TABLE [dbo].[CommentAnswer] ADD  DEFAULT (newsequentialid()) FOR [CANID]
GO
ALTER TABLE [dbo].[Country] ADD  DEFAULT (newsequentialid()) FOR [CTRCODE]
GO
ALTER TABLE [dbo].[Curriculum] ADD  DEFAULT (newsequentialid()) FOR [CURID]
GO
ALTER TABLE [dbo].[DocumentConfidentiality] ADD  DEFAULT (newsequentialid()) FOR [DCFCODE]
GO
ALTER TABLE [dbo].[DocumentState] ADD  DEFAULT (newsequentialid()) FOR [DCSCODE]
GO
ALTER TABLE [dbo].[Exercice] ADD  DEFAULT (newsequentialid()) FOR [EXCID]
GO
ALTER TABLE [dbo].[ExerciceDone] ADD  DEFAULT (newsequentialid()) FOR [EXDID]
GO
ALTER TABLE [dbo].[ExerciceQuestion] ADD  DEFAULT (newsequentialid()) FOR [EXQCODE]
GO
ALTER TABLE [dbo].[ExerciceQuestionChoice] ADD  DEFAULT (newsequentialid()) FOR [EQCCODE]
GO
ALTER TABLE [dbo].[ExerciceQuestionType] ADD  DEFAULT (newsequentialid()) FOR [EQTCODE]
GO
ALTER TABLE [dbo].[FieldType] ADD  DEFAULT (newsequentialid()) FOR [FLDCODE]
GO
ALTER TABLE [dbo].[FollowState] ADD  DEFAULT (newsequentialid()) FOR [FLSCODE]
GO
ALTER TABLE [dbo].[Gender] ADD  CONSTRAINT [DF_GENCODE]  DEFAULT (newsequentialid()) FOR [GENCODE]
GO
ALTER TABLE [dbo].[Lesson] ADD  DEFAULT (newsequentialid()) FOR [LSNID]
GO
ALTER TABLE [dbo].[LessonChapter] ADD  DEFAULT (newsequentialid()) FOR [LSCCODE]
GO
ALTER TABLE [dbo].[LessonPart] ADD  DEFAULT (newsequentialid()) FOR [LSPCODE]
GO
ALTER TABLE [dbo].[Study] ADD  DEFAULT (newsequentialid()) FOR [STDCODE]
GO
ALTER TABLE [dbo].[SubscribeActivity] ADD  DEFAULT (newsequentialid()) FOR [SUBID]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_COUNTRY_O_COUNTRY] FOREIGN KEY([CTRCODE])
REFERENCES [dbo].[Country] ([CTRCODE])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_ACCOUNT_COUNTRY_O_COUNTRY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_TYPE_OF_A_ACCOUNTT] FOREIGN KEY([ATPCODE])
REFERENCES [dbo].[AccountType] ([ATPCODE])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_ACCOUNT_TYPE_OF_A_ACCOUNTT]
GO
ALTER TABLE [dbo].[AccountStudent]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNTS_ACCOUNT_O_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[AccountStudent] CHECK CONSTRAINT [FK_ACCOUNTS_ACCOUNT_O_ACCOUNT]
GO
ALTER TABLE [dbo].[AccountStudent]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNTS_GENDER_OF_GENDER] FOREIGN KEY([GENCODE])
REFERENCES [dbo].[Gender] ([GENCODE])
GO
ALTER TABLE [dbo].[AccountStudent] CHECK CONSTRAINT [FK_ACCOUNTS_GENDER_OF_GENDER]
GO
ALTER TABLE [dbo].[AccountStudy]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNTS_ACCOUNTST_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[AccountStudy] CHECK CONSTRAINT [FK_ACCOUNTS_ACCOUNTST_ACCOUNT]
GO
ALTER TABLE [dbo].[AccountStudy]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNTS_ACCOUNTST_STUDY] FOREIGN KEY([STDCODE])
REFERENCES [dbo].[Study] ([STDCODE])
GO
ALTER TABLE [dbo].[AccountStudy] CHECK CONSTRAINT [FK_ACCOUNTS_ACCOUNTST_STUDY]
GO
ALTER TABLE [dbo].[AccountTeacher]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNTT_ACCOUNT_O_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[AccountTeacher] CHECK CONSTRAINT [FK_ACCOUNTT_ACCOUNT_O_ACCOUNT]
GO
ALTER TABLE [dbo].[AccountTeacher]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNTT_GENDER_OF_GENDER] FOREIGN KEY([GENCODE])
REFERENCES [dbo].[Gender] ([GENCODE])
GO
ALTER TABLE [dbo].[AccountTeacher] CHECK CONSTRAINT [FK_ACCOUNTT_GENDER_OF_GENDER]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUsers_dbo.Account_Id] FOREIGN KEY([Account_Id])
REFERENCES [dbo].[Account] ([ACCID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_dbo.AspNetUsers_dbo.Account_Id]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_COMMENT_ACCOUNT_O_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_COMMENT_ACCOUNT_O_ACCOUNT]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_COMMENT_COMMENTS__LESSON] FOREIGN KEY([LSNID])
REFERENCES [dbo].[Lesson] ([LSNID])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_COMMENT_COMMENTS__LESSON]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_COMMENT_STATE_OF__DOCUMENT] FOREIGN KEY([DCSCODE])
REFERENCES [dbo].[DocumentState] ([DCSCODE])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_COMMENT_STATE_OF__DOCUMENT]
GO
ALTER TABLE [dbo].[CommentAnswer]  WITH CHECK ADD  CONSTRAINT [FK_COMMENTA_ACCOUNT_O_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[CommentAnswer] CHECK CONSTRAINT [FK_COMMENTA_ACCOUNT_O_ACCOUNT]
GO
ALTER TABLE [dbo].[CommentAnswer]  WITH CHECK ADD  CONSTRAINT [FK_COMMENTA_ANSWER_OF_COMMENT] FOREIGN KEY([COMID])
REFERENCES [dbo].[Comment] ([COMID])
GO
ALTER TABLE [dbo].[CommentAnswer] CHECK CONSTRAINT [FK_COMMENTA_ANSWER_OF_COMMENT]
GO
ALTER TABLE [dbo].[CommentAnswer]  WITH CHECK ADD  CONSTRAINT [FK_COMMENTA_STATE_OF__DOCUMENT] FOREIGN KEY([DCSCODE])
REFERENCES [dbo].[DocumentState] ([DCSCODE])
GO
ALTER TABLE [dbo].[CommentAnswer] CHECK CONSTRAINT [FK_COMMENTA_STATE_OF__DOCUMENT]
GO
ALTER TABLE [dbo].[Curriculum]  WITH CHECK ADD  CONSTRAINT [FK_CURRICUL_STUDY_OF__STUDY] FOREIGN KEY([STDCODE])
REFERENCES [dbo].[Study] ([STDCODE])
GO
ALTER TABLE [dbo].[Curriculum] CHECK CONSTRAINT [FK_CURRICUL_STUDY_OF__STUDY]
GO
ALTER TABLE [dbo].[CurriculumCategory]  WITH CHECK ADD  CONSTRAINT [FK_CURRICUL_CURRICULU_CATEGORY] FOREIGN KEY([CTGID])
REFERENCES [dbo].[Category] ([CTGID])
GO
ALTER TABLE [dbo].[CurriculumCategory] CHECK CONSTRAINT [FK_CURRICUL_CURRICULU_CATEGORY]
GO
ALTER TABLE [dbo].[CurriculumCategory]  WITH CHECK ADD  CONSTRAINT [FK_CURRICUL_CURRICULU_CURRICUL2] FOREIGN KEY([CURID])
REFERENCES [dbo].[Curriculum] ([CURID])
GO
ALTER TABLE [dbo].[CurriculumCategory] CHECK CONSTRAINT [FK_CURRICUL_CURRICULU_CURRICUL2]
GO
ALTER TABLE [dbo].[CurriculumLessons]  WITH CHECK ADD  CONSTRAINT [FK_CURRICUL_CURRICULU_CURRICUL3] FOREIGN KEY([CURID])
REFERENCES [dbo].[Curriculum] ([CURID])
GO
ALTER TABLE [dbo].[CurriculumLessons] CHECK CONSTRAINT [FK_CURRICUL_CURRICULU_CURRICUL3]
GO
ALTER TABLE [dbo].[CurriculumSubscription]  WITH CHECK ADD  CONSTRAINT [FK_CURRICUL_CURRICULU_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[CurriculumSubscription] CHECK CONSTRAINT [FK_CURRICUL_CURRICULU_ACCOUNT]
GO
ALTER TABLE [dbo].[CurriculumSubscription]  WITH CHECK ADD  CONSTRAINT [FK_CURRICUL_CURRICULU_CURRICUL] FOREIGN KEY([CURID])
REFERENCES [dbo].[Curriculum] ([CURID])
GO
ALTER TABLE [dbo].[CurriculumSubscription] CHECK CONSTRAINT [FK_CURRICUL_CURRICULU_CURRICUL]
GO
ALTER TABLE [dbo].[EntityStrings]  WITH CHECK ADD  CONSTRAINT [FK_ENTITYST_CULTURE_O_CULTURE] FOREIGN KEY([CLTCODE])
REFERENCES [dbo].[Culture] ([CLTCODE])
GO
ALTER TABLE [dbo].[EntityStrings] CHECK CONSTRAINT [FK_ENTITYST_CULTURE_O_CULTURE]
GO
ALTER TABLE [dbo].[ExerciceCorrection]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_EXERCICEC_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[ExerciceCorrection] CHECK CONSTRAINT [FK_EXERCICE_EXERCICEC_ACCOUNT]
GO
ALTER TABLE [dbo].[ExerciceCorrection]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_EXERCICEC_EXERCICE] FOREIGN KEY([EXDID])
REFERENCES [dbo].[ExerciceDone] ([EXDID])
GO
ALTER TABLE [dbo].[ExerciceCorrection] CHECK CONSTRAINT [FK_EXERCICE_EXERCICEC_EXERCICE]
GO
ALTER TABLE [dbo].[ExerciceDone]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_ACCOUNT_O_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[ExerciceDone] CHECK CONSTRAINT [FK_EXERCICE_ACCOUNT_O_ACCOUNT]
GO
ALTER TABLE [dbo].[ExerciceDone]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_EXERCICE__EXERCICE] FOREIGN KEY([EXCID])
REFERENCES [dbo].[Exercice] ([EXCID])
GO
ALTER TABLE [dbo].[ExerciceDone] CHECK CONSTRAINT [FK_EXERCICE_EXERCICE__EXERCICE]
GO
ALTER TABLE [dbo].[ExerciceQuestion]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_FIELD_TYP_FIELDTYP] FOREIGN KEY([FLDCODE])
REFERENCES [dbo].[FieldType] ([FLDCODE])
GO
ALTER TABLE [dbo].[ExerciceQuestion] CHECK CONSTRAINT [FK_EXERCICE_FIELD_TYP_FIELDTYP]
GO
ALTER TABLE [dbo].[ExerciceQuestion]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_QUESTIONS_EXERCICE] FOREIGN KEY([EXCID])
REFERENCES [dbo].[Exercice] ([EXCID])
GO
ALTER TABLE [dbo].[ExerciceQuestion] CHECK CONSTRAINT [FK_EXERCICE_QUESTIONS_EXERCICE]
GO
ALTER TABLE [dbo].[ExerciceQuestion]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_TYPE_OF_Q_EXERCICE] FOREIGN KEY([EQTCODE])
REFERENCES [dbo].[ExerciceQuestionType] ([EQTCODE])
GO
ALTER TABLE [dbo].[ExerciceQuestion] CHECK CONSTRAINT [FK_EXERCICE_TYPE_OF_Q_EXERCICE]
GO
ALTER TABLE [dbo].[ExerciceQuestion]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_VALUES_CH_EXERCICE] FOREIGN KEY([EQCCODE])
REFERENCES [dbo].[ExerciceQuestionChoice] ([EQCCODE])
GO
ALTER TABLE [dbo].[ExerciceQuestion] CHECK CONSTRAINT [FK_EXERCICE_VALUES_CH_EXERCICE]
GO
ALTER TABLE [dbo].[ExerciceQuestionAnswer]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_EXERCICEQ_EXERCICE] FOREIGN KEY([EXQCODE])
REFERENCES [dbo].[ExerciceQuestion] ([EXQCODE])
GO
ALTER TABLE [dbo].[ExerciceQuestionAnswer] CHECK CONSTRAINT [FK_EXERCICE_EXERCICEQ_EXERCICE]
GO
ALTER TABLE [dbo].[ExerciceQuestionAnswer]  WITH CHECK ADD  CONSTRAINT [FK_EXERCICE_EXERCICEQ_EXERCICE2] FOREIGN KEY([EXDID])
REFERENCES [dbo].[ExerciceDone] ([EXDID])
GO
ALTER TABLE [dbo].[ExerciceQuestionAnswer] CHECK CONSTRAINT [FK_EXERCICE_EXERCICEQ_EXERCICE2]
GO
ALTER TABLE [dbo].[LessonChapter]  WITH CHECK ADD  CONSTRAINT [FK_LESSONCH_CHAPTER_O_LESSON] FOREIGN KEY([LSNID])
REFERENCES [dbo].[Lesson] ([LSNID])
GO
ALTER TABLE [dbo].[LessonChapter] CHECK CONSTRAINT [FK_LESSONCH_CHAPTER_O_LESSON]
GO
ALTER TABLE [dbo].[LessonFollowed]  WITH CHECK ADD  CONSTRAINT [FK_LESSONFO_LESSONFOL_ACCOUNT] FOREIGN KEY([ACCID])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[LessonFollowed] CHECK CONSTRAINT [FK_LESSONFO_LESSONFOL_ACCOUNT]
GO
ALTER TABLE [dbo].[LessonFollowed]  WITH CHECK ADD  CONSTRAINT [FK_LESSONFO_LESSONFOL_FOLLOWST] FOREIGN KEY([FLSCODE])
REFERENCES [dbo].[FollowState] ([FLSCODE])
GO
ALTER TABLE [dbo].[LessonFollowed] CHECK CONSTRAINT [FK_LESSONFO_LESSONFOL_FOLLOWST]
GO
ALTER TABLE [dbo].[LessonPart]  WITH CHECK ADD  CONSTRAINT [FK_LESSONPA_PART_OF_C_LESSONCH] FOREIGN KEY([LSCCODE])
REFERENCES [dbo].[LessonChapter] ([LSCCODE])
GO
ALTER TABLE [dbo].[LessonPart] CHECK CONSTRAINT [FK_LESSONPA_PART_OF_C_LESSONCH]
GO
ALTER TABLE [dbo].[SubscribeActivity]  WITH CHECK ADD  CONSTRAINT [FK_SUBSCRIB_ACCOUNT_O_ACCOUNT] FOREIGN KEY([ACCSUBSCRIBER])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[SubscribeActivity] CHECK CONSTRAINT [FK_SUBSCRIB_ACCOUNT_O_ACCOUNT]
GO
ALTER TABLE [dbo].[SubscribeActivity]  WITH CHECK ADD  CONSTRAINT [FK_SUBSCRIB_ACCOUNT_O_ACCOUNT2] FOREIGN KEY([ACCSUBSCRIBED])
REFERENCES [dbo].[Account] ([ACCID])
GO
ALTER TABLE [dbo].[SubscribeActivity] CHECK CONSTRAINT [FK_SUBSCRIB_ACCOUNT_O_ACCOUNT2]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Study (FR: filière) types for students' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Study'
GO
USE [master]
GO
ALTER DATABASE [CoursEnLigne] SET  READ_WRITE 
GO
