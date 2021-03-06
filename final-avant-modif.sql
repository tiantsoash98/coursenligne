USE [master]
GO
/****** Object:  Database [CoursEnLigne]    Script Date: 03/11/2018 16:56:25 ******/
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
/****** Object:  UserDefinedDataType [dbo].[DOM_ACCOUNTTYPE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_ACCOUNTTYPE] FROM [int] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_ADDRESS]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_ADDRESS] FROM [varchar](75) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_ANSWERCONTENT]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_ANSWERCONTENT] FROM [varchar](1000) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_BIRTHDAY]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_BIRTHDAY] FROM [datetime] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_CHAPTERNUMBER]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_CHAPTERNUMBER] FROM [smallint] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_CODE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_CODE] FROM [uniqueidentifier] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_COMMENTCONTENT]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_COMMENTCONTENT] FROM [varchar](2000) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_DATETIME]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_DATETIME] FROM [datetime] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_DESCRIPTION]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_DESCRIPTION] FROM [varchar](2000) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_DURATION]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_DURATION] FROM [bigint] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_EMAIL]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_EMAIL] FROM [varchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_EXCERCICENUMBER]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_EXCERCICENUMBER] FROM [smallint] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_FAX]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_FAX] FROM [varchar](20) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_FIELDSIZE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_FIELDSIZE] FROM [int] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_FILE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_FILE] FROM [varchar](100) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_GENDER]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_GENDER] FROM [uniqueidentifier] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_ID]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_ID] FROM [uniqueidentifier] NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_LESSONCONTENT]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_LESSONCONTENT] FROM [varchar](max) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_NAME]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_NAME] FROM [varchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_PASSWORD]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_PASSWORD] FROM [varchar](255) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_PHONE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_PHONE] FROM [varchar](20) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_POINTS]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_POINTS] FROM [numeric](5, 2) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_POSTALCODE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_POSTALCODE] FROM [varchar](5) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_TITLE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_TITLE] FROM [varchar](200) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_TOWN]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_TOWN] FROM [varchar](25) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_WEBSITE]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_WEBSITE] FROM [varchar](100) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[DOM_WORDING]    Script Date: 03/11/2018 16:56:26 ******/
CREATE TYPE [dbo].[DOM_WORDING] FROM [varchar](25) NULL
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Account]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AccountStudent]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AccountStudy]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AccountTeacher]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AccountType]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Comment]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[CommentAnswer]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Country]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Culture]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Curriculum]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[CurriculumCategory]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[CurriculumLessons]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[CurriculumSubscription]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[DocumentConfidentiality]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[DocumentState]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[EntityStrings]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Exercice]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[ExerciceCorrection]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[ExerciceDone]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[ExerciceQuestion]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[ExerciceQuestionAnswer]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[ExerciceQuestionChoice]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[ExerciceQuestionType]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[FieldType]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[FollowState]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Gender]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Lesson]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[LessonChapter]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[LessonFollowed]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[LessonPart]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[Study]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  Table [dbo].[SubscribeActivity]    Script Date: 03/11/2018 16:56:26 ******/
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
/****** Object:  View [dbo].[LessonAlternative]    Script Date: 03/11/2018 16:56:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[LessonAlternative] as 
select l.LSNID, l.STDCODE, l.ACCID, l.DCFCODE, l.LSNTITLE, l.LSNDESCRIPTION, l.LSNTARGET, l.LSNDATE, isnull(l.LSNPICTURE, s.STDPICTURE) as LSNPICTURE, l.LSNDURATION, CAST(CASE WHEN l.LSNPICTURE IS NOT NULL THEN 'False' ELSE 'True' END AS BIT) as ISALTERNATIVE from Lesson l
join Study s
on l.STDCODE = s.STDCODE;
GO
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'ce24bec5-9fda-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'09ee69af-a191-e811-821f-2c600c6934be', N'jean@itu.local', N'', N'', NULL, CAST(0x0000A98700F58A9A AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'39b3ef12-a1da-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'rakoto@itu.local', N'', N'+261 34 00 001 02', N'39b3ef12-a1da-e811-822a-2c600c6934be.jpg', CAST(0x0000A98700F81A10 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'25aabd6e-a8da-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'soa@itu.local', N'', N'+261 34 00 002 01', N'25aabd6e-a8da-e811-822a-2c600c6934be.jpg', CAST(0x0000A987010691AA AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'31c2e92f-adda-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'philo@itu.local', N'', N'+261 33 00 000 00', N'31c2e92f-adda-e811-822a-2c600c6934be.jpg', CAST(0x0000A987010FEAD0 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'91b435ea-b0da-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'droit@itu.local', N'', N'+261 32 02 000 00', N'91b435ea-b0da-e811-822a-2c600c6934be.jpg', CAST(0x0000A98701173EED AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'd93df4ba-b1da-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'sciences@itu.local', N'', N'+261 34 00 000 00', NULL, CAST(0x0000A9870118D977 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'fa216878-b2da-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'management@itu.local', N'', N'+261 34 00 001 02', N'fa216878-b2da-e811-822a-2c600c6934be.jpg', CAST(0x0000A987011A4DF3 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'5a174f87-b5da-e811-822a-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'4650653e-e49a-e811-821f-2c600c6934be', N'tech@itu.local', N'', N'+261 34 00 000 00', N'5a174f87-b5da-e811-822a-2c600c6934be.jpg', CAST(0x0000A98701205126 AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'fe3e0db4-2dc3-e811-822b-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'09ee69af-a191-e811-821f-2c600c6934be', N'etudiant1@itu.local', N'', N'', NULL, CAST(0x0000A96901363AAF AS DateTime))
INSERT [dbo].[Account] ([ACCID], [CTRCODE], [ATPCODE], [ACCEMAIL], [ACCPASSWORD], [ACCPHONECONTACT], [ACCPICTURE], [ACCINSCRIPTIONDATE]) VALUES (N'd4387f0e-2fc3-e811-822b-2c600c6934be', N'a7e8fac3-9f91-e811-821f-2c600c6934be', N'09ee69af-a191-e811-821f-2c600c6934be', N'etudiant3@itu.local', N'', NULL, N'd4387f0e-2fc3-e811-822b-2c600c6934be.jpg', CAST(0x0000A9690138E3D1 AS DateTime))
INSERT [dbo].[AccountStudent] ([ACSID], [ACCID], [GENCODE], [ACSFIRSTNAME], [ACSNAME], [ACSBIRTHDAY]) VALUES (N'cf24bec5-9fda-e811-822a-2c600c6934be', N'ce24bec5-9fda-e811-822a-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Jean', N'Rabe', CAST(0x000088B300000000 AS DateTime))
INSERT [dbo].[AccountStudent] ([ACSID], [ACCID], [GENCODE], [ACSFIRSTNAME], [ACSNAME], [ACSBIRTHDAY]) VALUES (N'ff3e0db4-2dc3-e811-822b-2c600c6934be', N'fe3e0db4-2dc3-e811-822b-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Ravelo', N'Kiady', CAST(0x00008BDC00000000 AS DateTime))
INSERT [dbo].[AccountStudent] ([ACSID], [ACCID], [GENCODE], [ACSFIRSTNAME], [ACSNAME], [ACSBIRTHDAY]) VALUES (N'd5387f0e-2fc3-e811-822b-2c600c6934be', N'd4387f0e-2fc3-e811-822b-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Fabrice', N'Théodore', CAST(0x00008A0200000000 AS DateTime))
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'3ab3ef12-a1da-e811-822a-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Mahery', N'Rakoto', CAST(0x0000786600000000 AS DateTime), N'Antananarivo', N'101', N'Lot IIII A Analakely ', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'26aabd6e-a8da-e811-822a-2c600c6934be', N'25aabd6e-a8da-e811-822a-2c600c6934be', N'244eedbd-cc9b-e811-8220-2c600c6934be', N'Soa', N'Rahery', CAST(0x00006B5400000000 AS DateTime), N'Antananarivo', N'101', N'SII 26 Isotry', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'32c2e92f-adda-e811-822a-2c600c6934be', N'31c2e92f-adda-e811-822a-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Robert', N'Ramahazo', CAST(0x00005EEE00000000 AS DateTime), N'Antananarivo', N'101', N'Ampefiloha', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'92b435ea-b0da-e811-822a-2c600c6934be', N'91b435ea-b0da-e811-822a-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Solofo', N'Njaka', CAST(0x0000704C00000000 AS DateTime), N'Antananarivo', N'101', N'Ambohijatovo', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'da3df4ba-b1da-e811-822a-2c600c6934be', N'd93df4ba-b1da-e811-822a-2c600c6934be', N'244eedbd-cc9b-e811-8220-2c600c6934be', N'Christelle', N'Ravohangy', CAST(0x00005BEC00000000 AS DateTime), N'Antananarivo', N'101', N'Ampefiloha', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'fb216878-b2da-e811-822a-2c600c6934be', N'fa216878-b2da-e811-822a-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Louis', N'Zaka', CAST(0x0000789600000000 AS DateTime), N'Antananarivo', N'101', N'Lot IIII A Analakely ', NULL)
INSERT [dbo].[AccountTeacher] ([ACTID], [ACCID], [GENCODE], [ACTFIRSTNAME], [ACTNAME], [ACTBIRTHDAY], [ACTTOWN], [ACTPOSTALCODE], [ACTADDRESS], [ACTCV]) VALUES (N'5b174f87-b5da-e811-822a-2c600c6934be', N'5a174f87-b5da-e811-822a-2c600c6934be', N'234eedbd-cc9b-e811-8220-2c600c6934be', N'Mamy', N'Razafy', CAST(0x00007BE800000000 AS DateTime), N'Antananarivo', N'101', N'Maison', NULL)
INSERT [dbo].[AccountType] ([ATPCODE], [ATPWORDING]) VALUES (N'09ee69af-a191-e811-821f-2c600c6934be', N'STUDENT')
INSERT [dbo].[AccountType] ([ATPCODE], [ATPWORDING]) VALUES (N'4650653e-e49a-e811-821f-2c600c6934be', N'TEACHER')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1da5870-be8c-4c82-9755-d364518b3fc9', N'STUDENT')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991', N'TEACHER')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'17811fab-e070-4714-8f15-a0513c672231', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'677add0a-c94c-4d09-bb81-6d1691850fd1', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6b3f614a-ff68-4a5d-aded-96362607b747', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'95f4be5b-936c-4a8c-8898-727be55f98a4', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bb5f293e-efee-4663-95ae-db65c60afeeb', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c8cb2906-1a53-4e7b-8237-1f7676ed1c3a', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fcd5db5d-fc74-4d81-adcb-d039d3d31ad9', N'1fb8f104-e7b2-4c79-a3ca-013a20ab5991')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a702220d-55e3-4ac6-8984-0f3a2612e58f', N'd1da5870-be8c-4c82-9755-d364518b3fc9')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd575d7de-695d-41a2-a316-1af19bcfefd2', N'd1da5870-be8c-4c82-9755-d364518b3fc9')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'de629f8d-017e-4838-9341-8666070e7aa1', N'd1da5870-be8c-4c82-9755-d364518b3fc9')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'17811fab-e070-4714-8f15-a0513c672231', N'tech@itu.local', 0, N'AGfqbL9Ub1GqEl+1vTScoIcz1YrYKxZycz7pvAhbxMwerA4kZcLCiZHKkDwOy+tknQ==', N'04d1518f-51cd-46f7-957d-7e89e12e1cd1', NULL, 0, 0, NULL, 1, 0, N'tech@itu.local', N'5a174f87-b5da-e811-822a-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'677add0a-c94c-4d09-bb81-6d1691850fd1', N'sciences@itu.local', 0, N'ALCNWpnX/pqnJ+LhABZPJ21bvMNX+80xNLD/ein7D4Rq5562fFhZsaKrqNhA6HKUqw==', N'a75f8a31-54de-4ee5-ae1f-8a348ec3df76', NULL, 0, 0, NULL, 1, 0, N'sciences@itu.local', N'd93df4ba-b1da-e811-822a-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'6b3f614a-ff68-4a5d-aded-96362607b747', N'droit@itu.local', 0, N'AJt/3Tp4SaAe/Oy7CIzoKcMLogbsZ7DpyRQ1yQtPa8Ph7ucg22sgWxWHBl3vevkBAg==', N'626953fc-5421-4ee3-82ec-d37da46583b3', NULL, 0, 0, NULL, 1, 0, N'droit@itu.local', N'91b435ea-b0da-e811-822a-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'95f4be5b-936c-4a8c-8898-727be55f98a4', N'rakoto@itu.local', 0, N'AM9wwU30ohlKZAnqf/7hsJ7J7olaA2/6cS0btr5AIg+OYAv/s6JpPVo4KXiFKRUtoA==', N'c5de482f-9b52-40cc-985e-fcb423ef008f', NULL, 0, 0, NULL, 1, 0, N'rakoto@itu.local', N'39b3ef12-a1da-e811-822a-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'a702220d-55e3-4ac6-8984-0f3a2612e58f', N'etudiant3@itu.local', 0, N'AJS0VUyiCmLuPRxe4fAYT0h7QGawYT8OtjuwekG//cMHwGPkX6rVPIy2yMUnffLSoQ==', N'2af331dc-58c9-433a-8dc7-9e53803075b0', NULL, 0, 0, NULL, 1, 0, N'etudiant3@itu.local', N'd4387f0e-2fc3-e811-822b-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'bb5f293e-efee-4663-95ae-db65c60afeeb', N'soa@itu.local', 0, N'AMmRR4x10U0+fR/SaEYfwaKpcJNRg8MNbl78kJABy5BuPFOGnH2jRCAG+EbA1InViw==', N'96a79491-6252-4bd3-a5db-519f612e6d02', NULL, 0, 0, NULL, 1, 0, N'soa@itu.local', N'25aabd6e-a8da-e811-822a-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'c8cb2906-1a53-4e7b-8237-1f7676ed1c3a', N'management@itu.local', 0, N'AEFwvizQ05i0MOfhDjqSBBgd5jCimHbHE8phZirpnGFVnn01G2cuyXBh2l5eZz6siw==', N'b25b8bac-03eb-493c-956f-1a53f08ea3a7', NULL, 0, 0, NULL, 1, 0, N'management@itu.local', N'fa216878-b2da-e811-822a-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'd575d7de-695d-41a2-a316-1af19bcfefd2', N'jean@itu.local', 0, N'AGQo/UNdGjYFmFPpfDEN6uKYv/EGVqdCBl6CXq/qdJiw+/gHFO/5U7sjsNPF3MxTCQ==', N'745288bc-34cb-4089-b93a-d443d36f5f66', NULL, 0, 0, NULL, 1, 0, N'jean@itu.local', N'ce24bec5-9fda-e811-822a-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'de629f8d-017e-4838-9341-8666070e7aa1', N'etudiant1@itu.local', 0, N'AGss8kPh2c4gx7x6FozdkR8hf1uSYP9NZmsKXjPlyyPIXDMiOoFwvOa2h0qeiU8O+Q==', N'a9bc9d75-b334-47dc-bf27-81b7ec9867ba', NULL, 0, 0, NULL, 1, 0, N'etudiant1@itu.local', N'fe3e0db4-2dc3-e811-822b-2c600c6934be')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Account_Id]) VALUES (N'fcd5db5d-fc74-4d81-adcb-d039d3d31ad9', N'philo@itu.local', 0, N'AHclln/mmIPRxaj3kWjQpc5ExnuEdWVsUyXAY3HprZ9Y4tLJja2qiGV71jbDYUKt5Q==', N'0bd0e4ab-c428-44f6-9d45-126b93918bf1', NULL, 0, 0, NULL, 1, 0, N'philo@itu.local', N'31c2e92f-adda-e811-822a-2c600c6934be')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'a69f0436-2cc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'66dc8cb6-b5da-e811-822a-2c600c6934be', N'ce24bec5-9fda-e811-822a-2c600c6934be', CAST(0x0000A96901334A65 AS DateTime), N'Excellent cours')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'b3a8cf56-2cc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'66dc8cb6-b5da-e811-822a-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', CAST(0x0000A96901338C15 AS DateTime), N'Commentaire 2')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'4a60d286-2cc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'16589c8b-b3da-e811-822a-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', CAST(0x0000A9690133EA7A AS DateTime), N'Angular est-il encore intéressant en 2018?')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'79acc9d5-2cc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', N'ce24bec5-9fda-e811-822a-2c600c6934be', CAST(0x0000A969013485BB AS DateTime), N'Python peut-il un langage multiplateforme?')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'a5dff2cb-2dc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', N'fe3e0db4-2dc3-e811-822b-2c600c6934be', CAST(0x0000A969013669B3 AS DateTime), N'Super, j''ai toujours voulu apprendre le Python')
INSERT [dbo].[Comment] ([COMID], [DCSCODE], [LSNID], [ACCID], [COMDATE], [COMCONTENT]) VALUES (N'1a440a7f-2fc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', N'd4387f0e-2fc3-e811-822b-2c600c6934be', CAST(0x0000A9690139C120 AS DateTime), N'J''ai eu un peu de problème au niveau de  l''installationau début mais j''ai réussi finalement')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'b78ad744-2cc3-e811-822b-2c600c6934be', N'a69f0436-2cc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', CAST(0x0000A969013368BE AS DateTime), N'Je trouve aussi, et je recommande d''ailleurs')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'bb10c764-2dc3-e811-822b-2c600c6934be', N'79acc9d5-2cc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', CAST(0x0000A96901359EDB AS DateTime), N'Oui, c''est un langage de programmation  qui peut être utilisé depuis n''importe quelle plateforme, Windows, Linux ou Mac')
INSERT [dbo].[CommentAnswer] ([CANID], [COMID], [DCSCODE], [ACCID], [CANDATE], [CANCONTENT]) VALUES (N'4a5a2db7-cbda-e811-822b-2c600c6934be', N'1a440a7f-2fc3-e811-822b-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'ce24bec5-9fda-e811-822a-2c600c6934be', CAST(0x0000A987014BF03B AS DateTime), N'Il suffit d''installer la dernière version, disponible sur le site')
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
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'2c2649ca-a2da-e811-822a-2c600c6934be', N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Apprendre à programmer en Python', N'Vous n''y connaissez rien en programmation et vous souhaitez apprendre un langage clair et intuitif ? Ce cours d’initiation à Python est fait pour vous !', N' Manipuler les bases de Python| Utiliser l''interpréteur Python| Créer un premier programme', CAST(0x0000A98700FB79BD AS DateTime), N'2c2649ca-a2da-e811-822a-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'96e98c4b-a9da-e811-822a-2c600c6934be', N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'25aabd6e-a8da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Les bases du marketing', N'Voici un cours qui reprend les notions de base du marketing. A travers plusieurs chapitres, vous reviendrez sur deux aspects principaux du marketing qui répondront chacun à plusieurs questions :

 - Un tour rapide de la discipline : définition du marketing, objectifs
 - Un focus sur le consommateur : comment définir son profil, quels sont les types de consommateurs, etc.', N' Définir ce qu''est le marketing| Apprendre les bases du marketing
', CAST(0x0000A987010843E5 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'592ccb6f-abda-e811-822a-2c600c6934be', N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'25aabd6e-a8da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Développez votre personal branding', N'Lorsque vous faites des courses, vous avez sûrement remarqué que vous reconnaissez certains produits en une fraction de seconde. Logo, couleurs, nom : les marques vous sautent aux yeux et tissent une relation avec vous. Elles vous guident dans votre choix.

Il vous est sûrement arrivé de préférer un produit plus cher, simplement parce qu’il était d’une marque que vous reconnaissez, ou parce que vous l’aviez vu à la télé. Parfois les produits ont beau être identiques, nous allons préférer celui d’une marque !

Comme n’importe quelle marque, dans un univers professionnel concurrentiel, vous devez, vous aussi, vous vendre. Vous devez, comme ces produits, vous démarquer.

Quels que soient votre fonction ou vos objectifs, avoir une marque personnelle forte est un atout pour créer plus d’opportunités et avancer professionnellement.

Je suis François Decaux, Customer Success Manager chez LinkedIn et je vais vous accompagner dans la construction pas à pas de votre personal branding.', N' Appliquer une réflexion marketing à vous-même| Elaborer une stratégie marketing pour votre marque| Créer votre plateforme de marque personelle| Déployer votre présence sur les bons canaux| Créer des opportunités professionnelles', CAST(0x0000A987010C79D3 AS DateTime), N'592ccb6f-abda-e811-822a-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'86d09884-adda-e811-822a-2c600c6934be', N'de237780-1da1-e811-8221-2c600c6934be', N'31c2e92f-adda-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Qu''est-ce que la philosophie?', N'Il  est  « naturel »  qu’un  débutant  en  philosophie commence  par  s’enquérir  de  l’essence  de  la discipline à laquelle il est appelé à s’initier -lanature de l’homme étant de penser ce qu’il fait- et se pose  la  question  « Qu’est-ce  que  la  Philosophie ? » et  ce  d’autant  qu’il  est  censé  tout  en  ignorer, contrairement  aux  autres  matières,  Mathématique,  Physique  ou  Histoire,  dont  il  est  plus  familier. Chaque  philosophe,  et  par  ce  terme  nous  entendrons  pour  l’instant  tout  auteur  que  la  tradition  a dénommé  tel,  s’est  d’ailleurs  posé  cette  question.  Depuis  Platon,  qui  projetait  un  dialogue  sur Le  Philosophe,  jusqu''à  M.  Heidegger,  qui  a  prononcé  une  conférence sur "  ce thème  très  vaste  ", tous se sont interrogés sur la définition de leur propre pratique. ', N' Tenter de définir ce qu''est la philosophie', CAST(0x0000A9870110915C AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'7b2333fc-b0da-e811-822a-2c600c6934be', N'89b16d41-9c9c-e811-8220-2c600c6934be', N'91b435ea-b0da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Droit international public', N'Description', N' Cible 1| Cible 2', CAST(0x0000A98701176266 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'b0e98440-b1da-e811-822a-2c600c6934be', N'89b16d41-9c9c-e811-8220-2c600c6934be', N'91b435ea-b0da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Le droit administratif', N'La description', N'Les cibles', CAST(0x0000A9870117E8C8 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'21ba0205-b2da-e811-822a-2c600c6934be', N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'd93df4ba-b1da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Théorie des cordes', N'La description', N' Les cibles', CAST(0x0000A98701196B19 AS DateTime), N'21ba0205-b2da-e811-822a-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'7acb52b0-b2da-e811-822a-2c600c6934be', N'18c841d9-1ca1-e811-8221-2c600c6934be', N'fa216878-b2da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Qu''apporte le management à la gestion des organisations?', N'La description', N'Les cibles', CAST(0x0000A987011ABBE8 AS DateTime), N'7acb52b0-b2da-e811-822a-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'0efa6239-b3da-e811-822a-2c600c6934be', N'18c841d9-1ca1-e811-8221-2c600c6934be', N'fa216878-b2da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'La croissance économique', N'La description', N'Les cibles', CAST(0x0000A987011BC964 AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'16589c8b-b3da-e811-822a-2c600c6934be', N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Les bases du développement web', N'La description', N'Les cibles', CAST(0x0000A987011C6B0D AS DateTime), N'16589c8b-b3da-e811-822a-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'3446b4bd-b4da-e811-822a-2c600c6934be', N'de237780-1da1-e811-8221-2c600c6934be', N'31c2e92f-adda-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'La philosophie critique de Kant', N'La description', N'Les cibles', CAST(0x0000A987011EC4D0 AS DateTime), N'3446b4bd-b4da-e811-822a-2c600c6934be.jpg', NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'66dc8cb6-b5da-e811-822a-2c600c6934be', N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'5a174f87-b5da-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Le design Pattern MVC', N'La description', N'Les cibles', CAST(0x0000A9870120AE1A AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'69042504-d0da-e811-822b-2c600c6934be', N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', N'980a694a-40ba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Développement avancé en C#', N'Ce cours vous enseignera le développement avancé en C#', N' Fonction delegate| Tâches asynchrones| Evènements
', CAST(0x0000A987015464CE AS DateTime), NULL, NULL)
INSERT [dbo].[Lesson] ([LSNID], [STDCODE], [ACCID], [DCSCODE], [DCFCODE], [LSNTITLE], [LSNDESCRIPTION], [LSNTARGET], [LSNDATE], [LSNPICTURE], [LSNDURATION]) VALUES (N'4d71146c-d7da-e811-822b-2c600c6934be', N'18c841d9-1ca1-e811-8221-2c600c6934be', N'31c2e92f-adda-e811-822a-2c600c6934be', N'03529c5e-3fba-e811-8225-2c600c6934be', N'7ccaf4e2-cf9e-e811-8220-2c600c6934be', N'Sociologie et structure sociale', N'Cours sur la sociologie', N' Appréhender la structure sociale', CAST(0x0000A9870162F459 AS DateTime), N'4d71146c-d7da-e811-822b-2c600c6934be.jpg', NULL)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'dd80034c-a3da-e811-822a-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', 1, N'Pourquoi apprendre Python ?', N'Bienvenue dans ce cours à la découverte du monde fabuleux de la programmation ! Nous allons ensemble apprendre Python, un langage bien connu des scientifiques, des startups et des amateurs d’un certain groupe d’humoristes britanniques.', N'<p>Oui, vous avez bien lu ! Pour expliquer l&rsquo;origine du langage, revenons un peu en arri&egrave;re. En 1989, par une froide nuit n&eacute;erlandaise, un d&eacute;veloppeur du plat pays nomm&eacute;&nbsp;<a href="https://en.wikipedia.org/wiki/Guido_van_Rossum">Guido van Rossum</a>&nbsp;s&rsquo;ennuie. Il cherche un moyen de s&rsquo;occuper pendant la p&eacute;riode qui pr&eacute;c&egrave;de No&euml;l car les bureaux de son entreprise sont ferm&eacute;s. Quand certains auraient d&eacute;vor&eacute; l&rsquo;int&eacute;grale d&rsquo;Urgences ou d&eacute;cor&eacute; un sapin, lui se lance dans l&rsquo;invention d&rsquo;un langage. Etant un grand fan des&nbsp;<a href="https://en.wikipedia.org/wiki/Monty_Python">Monty Python</a>&nbsp;et d&rsquo;humeur irr&eacute;v&eacute;rencieuse, il l&rsquo;appelle Python. Voil&agrave; pourquoi les d&eacute;veloppeurs Python&nbsp;<a href="https://www.python.org/doc/humor/">ont de l&rsquo;humour</a>&nbsp;et s&rsquo;amusent &agrave; glisser des petites blagues dans leur code !&nbsp;</p>
', 12000000000)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'12d805d7-a4da-e811-822a-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', 2, N'Installez Python !', NULL, N'<p>Rendez-vous sur&nbsp;<a href="https://www.python.org/">le site officiel de Python</a>&nbsp;et cliquez sur Downloads.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'f1295dfd-a4da-e811-822a-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', 3, N'Découvrez le vocabulaire de Python', NULL, N'<p>C&rsquo;est parti pour enregistrer notre premi&egrave;re citation dans l&rsquo;interpr&eacute;teur ! Commen&ccedil;ons par nous amuser un peu avec ce dernier. Vous avez d&eacute;j&agrave; vu que vous pouviez vous en servir comme calculatrice. Mais saviez-vous que vous pouviez &eacute;galement lui demander de conserver des informations en m&eacute;moire ? Comme &agrave; un ami &agrave; qui vous diriez : &ldquo;Peux-tu retenir que le num&eacute;ro de t&eacute;l&eacute;phone de Laur&egrave;ne est le 07XXXXXXXX ? J&rsquo;en aurai besoin tout &agrave; l&rsquo;heure pour l&rsquo;appeler.&rdquo;.</p>

<p>Comment faire ?</p>

<p>Il suffit d&rsquo;enregistrer le num&eacute;ro de t&eacute;l&eacute;phone dans une&nbsp;<strong>variable</strong>.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'da00008d-aada-e811-822a-2c600c6934be', N'96e98c4b-a9da-e811-822a-2c600c6934be', 1, N'Introduction au marketing', NULL, N'<p>Avec l&#39;intensification de la concurrence, il est devenu n&eacute;cessaire de segmenter la client&egrave;le et de conna&icirc;tre les go&ucirc;ts des consommateurs. On parle de&nbsp;<strong>marketing individualis&eacute;</strong>&nbsp;ou&nbsp;<strong>marketing one-to-one</strong>.</p>

<p>&nbsp;</p>

<p>Internet a &eacute;galement pris une place importante dans le marketing puisque les consommateurs sont toujours plus nombreux &agrave;&nbsp;<strong>consulter les avis d&#39;autres consommateurs</strong>&nbsp;avant d&#39;effectuer un achat. C&#39;est aussi un bon moyen de comparer les produits afin de faire la meilleure acquisition possible.</p>

<p>&nbsp;</p>

<p>Autre particularit&eacute; du consommateur &agrave; notre &eacute;poque : il est d&eacute;sireux de faire une bonne affaire &agrave; chaque achat. Pour cela, ils cherchent parfois &agrave; acheter de fa&ccedil;on collective pour faire baisser les prix. On parle de &quot;<strong>team buying</strong>&quot;.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'd6126bad-abda-e811-822a-2c600c6934be', N'592ccb6f-abda-e811-822a-2c600c6934be', 1, N'Faites vos premiers pas dans le personal branding', NULL, N'<p>Bienvenue dans notre premier chapitre. Pour d&eacute;marrer ce cours, nous allons d&eacute;finir ce qu&rsquo;est le personal branding. Pour cela, nous commencerons par essayer de comprendre ce qu&rsquo;est une marque, tout simplement. Nous nous int&eacute;resserons &eacute;galement aux id&eacute;es re&ccedil;ues et termes associ&eacute;s que vous devez avoir en t&ecirc;te pour bien avancer dans cette d&eacute;marche.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'8b0fa915-acda-e811-822a-2c600c6934be', N'592ccb6f-abda-e811-822a-2c600c6934be', 3, N'Pourquoi devriez-vous investir dans votre marque personnelle ?', N'Aujourd’hui, vous êtes ce que Google, Facebook, LinkedIn, Twitter, YouTube disent de vous. Vous êtes une somme de perceptions, de réputations et d’expériences, visible dans votre écosystème. Travailler votre marque, c’est contrôler et influencer tout cela au service de vos intérêts.', N'<p>Pour cultiver votre marque professionnelle, vous devez vous mettre en t&ecirc;te que vous &ecirc;tes le produit &agrave; vendre. Vous devez donc investir en vous-m&ecirc;me et rester focalis&eacute; sur vos objectifs : vous cr&eacute;er des opportunit&eacute;s, avancer dans votre carri&egrave;re, vous positionner pour &eacute;voluer.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'eab1c904-afda-e811-822a-2c600c6934be', N'86d09884-adda-e811-822a-2c600c6934be', 1, N'Le problème du lien social', NULL, N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify">Une premi&egrave;re mani&egrave;re de penser le lien social est par l&rsquo;&eacute;change. Nous avons vu cette id&eacute;e dans le cours pr&eacute;c&eacute;dent. On la trouve chez Platon, pour qui la satisfaction des besoins individuels par la division du travail et l&rsquo;&eacute;change est le fondement de la soci&eacute;t&eacute;. On la retrouve chez Durkheim, sous la forme de la &laquo; solidarit&eacute; organique &raquo;. On la trouve enfin chez Adam Smith, avec l&rsquo;id&eacute;e de &laquo; main invisible &raquo; : si les individus poursuivent leurs int&eacute;r&ecirc;ts priv&eacute;s, le plus grand bien g&eacute;n&eacute;ral en r&eacute;sultera car une main invisible les guide vers les actions les plus profitables &agrave; la collectivit&eacute; : &laquo; l&rsquo;individu est conduit par une main invisible &agrave; remplir une fin qui n&rsquo;entre nullement dans ses intentions &raquo; . Dans ce paradigme &eacute;conomique, c&rsquo;est l&rsquo;int&eacute;r&ecirc;t qui assure le lien social et la coh&eacute;sion entre les individus.</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'3b052c07-b1da-e811-822a-2c600c6934be', N'7b2333fc-b0da-e811-822a-2c600c6934be', 1, N'Chapitre 1', NULL, N'<p>Contenu du chapitre 1</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'9d4b460d-b1da-e811-822a-2c600c6934be', N'7b2333fc-b0da-e811-822a-2c600c6934be', 2, N'Chapitre 2', NULL, N'<p>Contenu du chapitre 2</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'2d015614-b1da-e811-822a-2c600c6934be', N'7b2333fc-b0da-e811-822a-2c600c6934be', 3, N'Chapitre 3', NULL, N'<p>Contenu du chapitre 3</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'3d86531b-b1da-e811-822a-2c600c6934be', N'7b2333fc-b0da-e811-822a-2c600c6934be', 4, N'Chapitre 4', NULL, N'<p>Contenu du chapitre 4</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'b1e98440-b1da-e811-822a-2c600c6934be', N'b0e98440-b1da-e811-822a-2c600c6934be', 1, N'Le chapitre', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'1a2e574b-b1da-e811-822a-2c600c6934be', N'b0e98440-b1da-e811-822a-2c600c6934be', 2, N'Le chapitre ', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'1b2e574b-b1da-e811-822a-2c600c6934be', N'b0e98440-b1da-e811-822a-2c600c6934be', 3, N'Le titre', NULL, N'<p>Le titre</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'fc5a5056-b1da-e811-822a-2c600c6934be', N'b0e98440-b1da-e811-822a-2c600c6934be', 4, N'Le chapitre', NULL, N'<p>Le chapitre</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'f92a2a0e-b2da-e811-822a-2c600c6934be', N'21ba0205-b2da-e811-822a-2c600c6934be', 1, N'Mon titre', N'Ma description', N'<p>Mon contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'335cb117-b2da-e811-822a-2c600c6934be', N'21ba0205-b2da-e811-822a-2c600c6934be', 2, N'Le contenu du titre', NULL, N'<p>Le titre du contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'0cbe03b7-b2da-e811-822a-2c600c6934be', N'7acb52b0-b2da-e811-822a-2c600c6934be', 1, N'Chap 1', NULL, N'<p>Content 1</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'474244bd-b2da-e811-822a-2c600c6934be', N'7acb52b0-b2da-e811-822a-2c600c6934be', 2, N'Chapt 2', NULL, N'<p>Content 2</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'484244bd-b2da-e811-822a-2c600c6934be', N'7acb52b0-b2da-e811-822a-2c600c6934be', 3, N'Chap 3', NULL, N'<p>Content 3</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'3c9a6f3f-b3da-e811-822a-2c600c6934be', N'0efa6239-b3da-e811-822a-2c600c6934be', 1, N'Le chapitre', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'3d9a6f3f-b3da-e811-822a-2c600c6934be', N'0efa6239-b3da-e811-822a-2c600c6934be', 2, N'Le titre', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'f2dbcd91-b3da-e811-822a-2c600c6934be', N'16589c8b-b3da-e811-822a-2c600c6934be', 1, N'Le titre', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'f3dbcd91-b3da-e811-822a-2c600c6934be', N'16589c8b-b3da-e811-822a-2c600c6934be', 2, N'Les cibles', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'ad6b4ae8-abda-e811-822a-2c600c6934be', N'592ccb6f-abda-e811-822a-2c600c6934be', 2, N'Soyez inspiré et engagé', N'Afin de mieux comprendre ce qu’est une marque personnelle forte, le plus évident est sans nul doute de vous présenter quelques acteurs du monde économique, artistique ou encore people qui ont su créer une marque forte. C’est cette marque personnelle qui leur permet d’être facilement identifiés et de se créer des opportunités.', N'<p>Une bonne piste pour d&eacute;marrer la r&eacute;flexion sur votre propre marque est de rechercher dans votre &eacute;cosyst&egrave;me actuel, ou dans celui o&ugrave; vous souhaitez &eacute;voluer, des acteurs reconnus qui ont r&eacute;ussi &agrave; cr&eacute;er une marque forte. Cela vous permettra de d&eacute;couvrir des traits qui pourraient &eacute;galement fonctionner pour vous, les &eacute;l&eacute;ments desquels vous devrez &eacute;ventuellement vous diff&eacute;rencier, ou les erreurs &agrave; &eacute;viter.</p>

<p>En personal branding, gardez l&rsquo;esprit ouvert et soyez curieux. Ici, ce sera une vraie force pour mieux appr&eacute;hender l&rsquo;exercice et d&eacute;finir une marque qui vous ressemble vraiment. Dites-vous que tout peut &ecirc;tre int&eacute;ressant et inspirant dans votre d&eacute;marche.</p>

<p>Pour chaque nom qui sera &eacute;crit ci-dessous, avant de passer &agrave; la suite de votre lecture, je vous invite &agrave; prendre quelques minutes de pause. R&eacute;fl&eacute;chissez &agrave; ce que vous inspire ce nom, la perception que vous avez de cette personne, votre exp&eacute;rience avec sa marque, les &eacute;l&eacute;ments qui la distinguent.</p>

<p>Recherchez les &eacute;l&eacute;ments identifiables, reconnaissables et forts. Vous constaterez que ces &eacute;l&eacute;ments, selon les personnalit&eacute;s, peuvent &ecirc;tre de diff&eacute;rents types :</p>

<ul>
	<li>
	<p>Comp&eacute;tences</p>
	</li>
	<li>
	<p>Engagements</p>
	</li>
	<li>
	<p>Phrases ou mots cl&eacute;s</p>
	</li>
	<li>
	<p>Style vestimentaire</p>
	</li>
	<li>
	<p>Comportements</p>
	</li>
	<li>
	<p>Actions</p>
	</li>
	<li>
	<p>&hellip;</p>
	</li>
</ul>

<p>Vous remarquerez &eacute;galement que vous retrouvez chez chacun les 5 piliers d&rsquo;un personal branding fort. Leurs marques sont<strong>&nbsp;claires, authentiques, coh&eacute;rentes, actualis&eacute;es et diff&eacute;renciantes</strong>. Recherchez ces caract&eacute;ristiques dans ces portraits, pour mieux les appr&eacute;hender.</p>

<p>Vous &ecirc;tes pr&ecirc;ts ? Allons-y !</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'c684029c-b3da-e811-822a-2c600c6934be', N'16589c8b-b3da-e811-822a-2c600c6934be', 3, N'Les cibles', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'c784029c-b3da-e811-822a-2c600c6934be', N'16589c8b-b3da-e811-822a-2c600c6934be', 4, N'Les cibles', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'3546b4bd-b4da-e811-822a-2c600c6934be', N'3446b4bd-b4da-e811-822a-2c600c6934be', 1, N'Le chapitre', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'2b29dac9-b4da-e811-822a-2c600c6934be', N'3446b4bd-b4da-e811-822a-2c600c6934be', 2, N'Le contenu', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'2c29dac9-b4da-e811-822a-2c600c6934be', N'3446b4bd-b4da-e811-822a-2c600c6934be', 3, N'Le contenu', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'98b41fd4-b4da-e811-822a-2c600c6934be', N'3446b4bd-b4da-e811-822a-2c600c6934be', 4, N'Le contenu', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'99b41fd4-b4da-e811-822a-2c600c6934be', N'3446b4bd-b4da-e811-822a-2c600c6934be', 5, N'Le titre', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'9e9106c3-b5da-e811-822a-2c600c6934be', N'66dc8cb6-b5da-e811-822a-2c600c6934be', 1, N'Le chapitre', N'La description', N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'd237b3c9-b5da-e811-822a-2c600c6934be', N'66dc8cb6-b5da-e811-822a-2c600c6934be', 2, N'Le chapitre', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'fba91ad0-b5da-e811-822a-2c600c6934be', N'66dc8cb6-b5da-e811-822a-2c600c6934be', 3, N'Le contenu', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'e3952273-d7da-e811-822b-2c600c6934be', N'4d71146c-d7da-e811-822b-2c600c6934be', 1, N'Chapitre 1', NULL, N'<p>Contenu 1</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'03f2a57e-d7da-e811-822b-2c600c6934be', N'4d71146c-d7da-e811-822b-2c600c6934be', 2, N'Chapitre 2', NULL, N'<p>Contenu 2</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'05f2a57e-d7da-e811-822b-2c600c6934be', N'4d71146c-d7da-e811-822b-2c600c6934be', 3, N'Chapitre 3', NULL, N'<p>Contenu 3</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'1652a589-d7da-e811-822b-2c600c6934be', N'4d71146c-d7da-e811-822b-2c600c6934be', 4, N'Chapitre 4', NULL, N'<p>Contenu 4</p>
', 0)
INSERT [dbo].[LessonChapter] ([LSCCODE], [LSNID], [LSCNUMBER], [LSCTITLE], [LSCDESCRIPTION], [LSCCONTENT], [LSCDURATION]) VALUES (N'6968a7a5-b3da-e811-822a-2c600c6934be', N'16589c8b-b3da-e811-822a-2c600c6934be', 5, N'Les cibles', NULL, N'<p>Le contenu</p>
', 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'ce24bec5-9fda-e811-822a-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A96901348BC3 AS DateTime), 2, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'ce24bec5-9fda-e811-822a-2c600c6934be', N'16589c8b-b3da-e811-822a-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A96901342374 AS DateTime), 4, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'ce24bec5-9fda-e811-822a-2c600c6934be', N'66dc8cb6-b5da-e811-822a-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A9690132E6F4 AS DateTime), 1, 1)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'39b3ef12-a1da-e811-822a-2c600c6934be', N'96e98c4b-a9da-e811-822a-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A98A014AE94D AS DateTime), 1, 2)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'39b3ef12-a1da-e811-822a-2c600c6934be', N'3446b4bd-b4da-e811-822a-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A96901339F4D AS DateTime), 2, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'39b3ef12-a1da-e811-822a-2c600c6934be', N'66dc8cb6-b5da-e811-822a-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A9690132E4EA AS DateTime), 1, NULL)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'fe3e0db4-2dc3-e811-822b-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', N'11937790-52b7-e811-8225-2c600c6934be', CAST(0x0000A96901367448 AS DateTime), 1, 0)
INSERT [dbo].[LessonFollowed] ([ACCID], [LSNID], [FLSCODE], [LSFDATE], [LSFCHAPTER], [LSFPART]) VALUES (N'd4387f0e-2fc3-e811-822b-2c600c6934be', N'2c2649ca-a2da-e811-822a-2c600c6934be', N'7abd2a4e-52b7-e811-8225-2c600c6934be', CAST(0x0000A969013A3186 AS DateTime), 1, 1)
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'de80034c-a3da-e811-822a-2c600c6934be', N'dd80034c-a3da-e811-822a-2c600c6934be', 1, N'Pourquoi apprendre Python ?', N'<p>Avant tout car&nbsp;<strong>c&rsquo;est fun</strong>&nbsp;! Oui oui, croyez-moi, nous allons nous amuser &agrave; cr&eacute;er rapidement et facilement des programmes qui rendront jaloux tous vos amis ! Gr&acirc;ce &agrave; ce langage, vous pourrez cr&eacute;er des programmes pour votre ordinateur, des sites web et m&ecirc;me des jeux ! Pinterest, Instagram et le site du New York Times ont &eacute;t&eacute; d&eacute;velopp&eacute;s en Python !</p>

<p>&nbsp;</p>

<ul>
	<li><strong>D&eacute;buter facilement</strong></li>
</ul>

<p>Python est un langage parfait pour d&eacute;buter. Il fonctionne sur tous les syst&egrave;mes d&rsquo;exploitation (Windows, Mac et Linux) et vous n&rsquo;avez pas &agrave; utiliser un logiciel sp&eacute;cifique pour voir le r&eacute;sultat de votre code. Vous avez juste besoin d&rsquo;un ordinateur. Et de votre t&ecirc;te. Alouette.</p>

<ul>
	<li><strong>Gagner des sous.</strong>&nbsp;</li>
</ul>

<p>Le salaire moyen d&rsquo;un d&eacute;veloppeur Python&nbsp;<strong>junior</strong>&nbsp;en France se situe entre 35 000 et 40 000&nbsp;<a href="http://www.journaldunet.com/solutions/reseau-social-d-entreprise/1188855-le-salaire-des-developpeurs-python-en-graphiques/">selon Hired</a>&nbsp;et est en croissance selon&nbsp;<a href="https://www.urbanlinker.com/le-webzine/etude-des-salaires-des-metiers-tech-2016-en-idf-52">Urban Linker</a>, un cabinet de recrutement sp&eacute;cialis&eacute; dans les Startups.</p>

<ul>
	<li><strong>Apprendre un langage reconnu.</strong>&nbsp;</li>
</ul>

<p>Python est le 4e langage le plus populaire selon l&rsquo;<a href="http://www.tiobe.com/tiobe-index/python/">index TIOBE</a>&nbsp;et son usage est rest&eacute; stable depuis une dizaine d&rsquo;ann&eacute;es. Vous avez la garantie d&rsquo;utiliser longtemps ce que vous apprendrez dans ce cours !</p>

<p>Fan de statistiques ou de big data ? Python est un des langages principaux utilis&eacute;s en&nbsp;<em>data analysis</em>&nbsp;(analyse de donn&eacute;es) et en&nbsp;<em>machine learning&nbsp;</em>(apprentissage par la machine).<br />
Envie de cr&eacute;er un robot qui vous servirait le caf&eacute; le matin ? Python est &eacute;galement le langage de r&eacute;f&eacute;rence pour apprendre la robotique.&nbsp;<a href="https://fr.wikipedia.org/wiki/Raspberry_Pi">L&rsquo;ordinateur le moins cher du monde</a>&nbsp;($25) a d&rsquo;ailleurs &eacute;t&eacute; con&ccedil;u dans cet objectif : rendre l&rsquo;informatique abordable et ludique.</p>

<ul>
	<li><strong>Rejoindre une communaut&eacute; mondiale.</strong>&nbsp;</li>
</ul>

<p>Active et dr&ocirc;le, la communaut&eacute; Python saura vous accueillir. Avec 27 000 membres sur&nbsp;<a href="https://www.meetup.com/fr-FR/topics/python/">Meetup</a>&nbsp;et plus de 40 groupes, il s&rsquo;agit d&rsquo;une des plus grandes communaut&eacute;s de France. En cherchant un peu vous trouverez certainement des rendez-vous dans la ville la plus proche pour aller boire un verre, parler code et d&eacute;bugger votre dernier programme. Vous rencontrez un souci ? Vous trouverez toujours une r&eacute;ponse sur Stack Overflow.</p>

<p>Guido van Rossum &eacute;tant un fervent contributeur &agrave; des projets Open Source, il n&rsquo;est pas &eacute;tonnant que le langage soit tr&egrave;s utilis&eacute; dans de nombreux projets libres. Il s&rsquo;agit d&rsquo;une des forces de la communaut&eacute;.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'df80034c-a3da-e811-822a-2c600c6934be', N'dd80034c-a3da-e811-822a-2c600c6934be', 2, N'Comment tirer parti de ce cours ?', N'<p>Une de mes convictions p&eacute;dagogiques les plus profondes est qu&rsquo;<strong>on apprend en faisant</strong>, et uniquement en faisant. C&rsquo;est pourquoi ce cours est organis&eacute; autour d&rsquo;un projet que je d&eacute;velopperai au fur et &agrave; mesure.</p>

<p>Chaque chapitre sera ponctu&eacute; de petits exercices pratiques que vous pourrez r&eacute;aliser directement dans notre console interactive. Entrez votre r&eacute;ponse et cliquez sur Run Code. Votre exercice est corrig&eacute; instantan&eacute;ment !</p>

<p>&nbsp;C&#39;est le moment de vous entrainer !</p>

<p>Vous pouvez lire le cours sans pratiquer&hellip; mais ce serait un peu comme si vous appreniez &agrave; faire du v&eacute;lo en lisant un manuel. Vous avez beau conna&icirc;tre la th&eacute;orie, vous ne serez pas plus avanc&eacute;&middot;e.</p>

<p>Le projet fil-rouge de ce cours est un programme qui ira chercher des citations de&nbsp;<a href="https://fr.wikipedia.org/wiki/San-Antonio_(s%C3%A9rie)">San Antonio</a>&nbsp;sur Internet et les fera dire par un personnage de dessin anim&eacute; au hasard. Pour celles et ceux qui ne connaissent pas San Antonio, vous d&eacute;couvrirez bien vite pourquoi cela m&rsquo;a fait tant rire de d&eacute;velopper ce programme !</p>

<p>Dans ce cours, je vais vous accompagner dans la r&eacute;alisation des &eacute;tapes suivantes :</p>

<ul>
	<li>
	<p>Installer Python et faire connaissance avec la Console ??</p>
	</li>
	<li>
	<p>Trouver comment &ldquo;enregistrer&rdquo; une citation et la retrouver plus tard.</p>
	</li>
	<li>
	<p>Cr&eacute;er des phrases sous la forme &lsquo;&lt;personnage&gt; a dit : &ldquo;&lt;citation&gt;&rdquo;&rsquo; et la modifier automatiquement.</p>
	</li>
	<li>
	<p>Cr&eacute;er des listes pour stocker plusieurs citations et plusieurs personnages.</p>
	</li>
	<li>
	<p>Cr&eacute;er des &ldquo;dictionnaires&rdquo; pour attribuer plusieurs citations &agrave; un m&ecirc;me personnage.</p>
	</li>
	<li>
	<p>Enregistrer votre programme dans un fichier externe car il commence &agrave; faire plusieurs lignes !</p>
	</li>
	<li>
	<p>Interagir avec notre utilisateur : quand il tape &ldquo;entr&eacute;e&rdquo;, le programme doit afficher une nouvelle citation. Quand il tape &ldquo;B&rdquo;, le programme s&rsquo;arr&ecirc;te. ?</p>
	</li>
	<li>
	<p>Afficher une citation au hasard quand on lance le programme.</p>
	</li>
	<li>
	<p>BONUS : Stocker nos citations et nos personnages dans un fichier externe.</p>
	</li>
	<li>
	<p>BONUS : Coder un petit robot qui va parcourir le Web &agrave; la recherche de citations et de personnages puis les stocker dans un fichier sur votre ordinateur.</p>
	</li>
</ul>

<p>Allez, maintenant que je vous ai donn&eacute; envie, il est temps de s&rsquo;y mettre !</p>

<p>&nbsp;</p>

<p>&nbsp;</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'f2295dfd-a4da-e811-822a-2c600c6934be', N'f1295dfd-a4da-e811-822a-2c600c6934be', 1, N'Variables', N'<p>Chaque information que vous souhaitez r&eacute;utiliser plus tard s&rsquo;appelle une variable. Il s&rsquo;agit d&rsquo;un concept basique en programmation et que vous retrouverez dans tous les langages.</p>

<p>Nous connaissons tous les variables, sans le savoir, car nous avons tous fait (ou essay&eacute; de faire !) des maths.</p>

<p>Une variable garde en m&eacute;moire&nbsp;une information tant que l&rsquo;interpr&eacute;teur Python est ouvert. Si vous quittez le programme puis le red&eacute;marrez (en tapant &nbsp;<code>exit()</code>&nbsp; puis &nbsp;<code>python3</code>&nbsp; par exemple), toutes vos variables seront effac&eacute;es. Python a la m&eacute;moire courte !</p>

<p>Nous pouvons voir une variable comme une &eacute;tiquette que vous colleriez sur un objet pour vous souvenir de son nom. Afin de mieux comprendre ce concept, revenons &agrave; notre tendre enfance et souvenons-nous de la mani&egrave;re dont nous avons appris &agrave; parler.&nbsp;Une personne vous d&eacute;signait les choses et vous disait son nom. &quot;Ceci est du brocoli. Ceci est une table. Ceci est du feu&quot;. Cela vous a permis, par la suite, de faire r&eacute;f&eacute;rence &agrave; ces objets par ces m&ecirc;mes termes : &quot;Z&#39;aime pas les brocolis. Veux monter sur la table. Le feu &ccedil;a fait mal.&quot;.&nbsp;</p>

<p>Nous tenons ce concept de Bergson, philosophe du langage, qui s&#39;est profond&eacute;ment int&eacute;ress&eacute; aux mots que nous utilisons pour repr&eacute;senter les choses. Selon lui, &quot;<em>Nous ne voyons pas les choses m&ecirc;mes; nous nous bornons, le plus souvent, &agrave; lire des &eacute;tiquettes coll&eacute;es sur elles</em>.&quot;.&nbsp;<a href="http://www.philosophie-spiritualite.com/textes_1/Bergson24.htm">En savoir plus</a>&nbsp;</p>

<p>Il en est de m&ecirc;me en programmation. Vous pouvez indiquer &agrave; l&#39;ordinateur que vous souhaitez&nbsp;associer tel terme &agrave; tel objet.&nbsp;</p>

<p>Pour d&eacute;finir une variable, nous allons taper son nom, un signe &eacute;gal puis sa valeur. Par exemple :</p>

<pre>
<samp>&gt;&gt;&gt; laurene_phone_number = &quot;07XXXXXXXX&quot;</samp></pre>

<p>Pour afficher le contenu d&rsquo;une variable, vous &eacute;crivez simplement son nom.</p>

<pre>
<samp>&gt;&gt;&gt; laurene_phone_number
0759039203
</samp></pre>

<p>Comment la modifier ? En la red&eacute;finissant, tout simplement !</p>

<pre>
<samp>&gt;&gt;&gt; laurene_phone_number = &quot;07XXXXXXXX&quot;</samp></pre>

<p>Et comment la supprimer ? En utilisant le mot-cl&eacute; &nbsp;<code>del</code>&nbsp; (nous en parlerons plus tard):</p>

<pre>
<samp>&gt;&gt;&gt; del(laurene_phone_number)</samp></pre>

<p>Nous allons d&eacute;finir une variable correspondant &agrave; une citation. &Agrave; vous de jouer !</p>

<p><a href="https://www.codevolve.com/api/v1/publishable_key/2A9CAA3419124E3E8C3F5AFCE5306292?content_id=6bd4e510-796a-47c3-87f1-b1f00e420a49">Cliquez sur ce lien.</a></p>

<p>&nbsp;</p>

<p>Vous aurez certainement remarqu&eacute; que j&rsquo;ai mis des guillemets autour de la valeur associ&eacute;e. Si nous essayons sans, nous avons un beau message. Oh, la jolie SyntaxError !</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'db00008d-aada-e811-822a-2c600c6934be', N'da00008d-aada-e811-822a-2c600c6934be', 1, N'L''environnement du marketing', N'<p>Les individus et les groupes&nbsp;ont :</p>

<ul>
	<li>Des besoins : Na&icirc;t d&#39;un&nbsp;sentiment de manque&nbsp;(Manger, se v&ecirc;tir, s&#39;abriter, se&nbsp;sentir en s&eacute;curit&eacute;, se sentir&nbsp;membre d&#39;un groupe).</li>
	<li>Des d&eacute;sirs : Moyen privil&eacute;gi&eacute;&nbsp;de satisfaire un besoin.&nbsp;Besoin de manger et d&eacute;sir&nbsp;manger un steak. Besoin de&nbsp;se v&ecirc;tir et d&eacute;sir un costume Pierre Cardin.&nbsp;</li>
</ul>

<p>Le marketing ne cr&eacute;e pas les besoins, ceux-ci&nbsp;pr&eacute;existent, &nbsp;mais &nbsp;il &nbsp;influence &nbsp;les &nbsp;d&eacute;sirs. &nbsp;Il&nbsp;sugg&egrave;re au consommateur qu&#39;une MERCEDES peut&nbsp;servir &nbsp;&agrave; &nbsp;satisfaire &nbsp;un &nbsp;besoin &nbsp;d&#39;estime. &nbsp;Il &nbsp;ne &nbsp;cr&eacute;e&nbsp;<br />
pas le besoin d&#39;estime, mais propose un moyen de&nbsp;le &nbsp;satisfaire. &nbsp;(Les &nbsp;besoins &nbsp;sont &nbsp;limit&eacute;s. &nbsp;Par &nbsp;contre,&nbsp;<br />
les d&eacute;sirs culturellement diff&eacute;renci&eacute;s, sont infinis).</p>

<p>Des demandes : D&eacute;sir d&#39;acheter certains produits, soutenu&nbsp;par un pouvoir et vouloir d&#39;achat. Beaucoup de ersonnes&nbsp;d&eacute;sirent s&#39;acheter un bijou en or mais seul 1 personne sur 7&nbsp;parvient &agrave; se l&#39;acheter.&nbsp;Il y a, bien s&ucirc;r, plusieurs types de demandes :&nbsp;<br />
o &nbsp;N&eacute;gative : Faire engager un d&eacute;tenu,<br />
o &nbsp;Absente : Nouvelle r&eacute;forme scolaire,<br />
o &nbsp;Latente : Produit qui n&#39;existe pas encore,<br />
o &nbsp;D&eacute;clinante : T&eacute;lex,<br />
o &nbsp;Irr&eacute;guli&egrave;re : (saisonni&egrave;re) Skis,<br />
o &nbsp;Soutenue : nourriture,<br />
o &nbsp;Excessive : circulation (bison Fut&eacute;),<br />
o &nbsp;Ind&eacute;sirable : drogue.</p>

<p><br />
&Agrave; chacune de ces demandes, correspond un type de&nbsp;marketing particulier.Nous voyons que les individus ont plusieurs moyens de&nbsp;satisfaire leur demande : l&#39;autoproduction, la force, la&nbsp;supplication et l&#39;&eacute;change.Le marketing se concentre sur l&#39;&eacute;change.</p>

<p>&nbsp;</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'dc00008d-aada-e811-822a-2c600c6934be', N'da00008d-aada-e811-822a-2c600c6934be', 2, N'Schématisation du système', N'<p>L&#39;entreprise &eacute;met des produits, des services et des&nbsp;communications &agrave; destination des march&eacute;s qui lui renvoient&nbsp;de l&#39;argent et de l&#39;information.Dans une entreprise, le principe du marketing peut s&#39;appliquer&nbsp;&agrave; la gestion des relations avec n&#39;importe quel march&eacute; :&nbsp;<br />
Introduction au marketing</p>

<ul>
	<li>Le directeur du personnel intervient sur le march&eacute; du travail.</li>
	<li>Le directeur des approvisionnements sur celui des&nbsp;mati&egrave;res premi&egrave;res.</li>
	<li>Le directeur financier sur le march&eacute; mon&eacute;taire.</li>
</ul>

<p>&nbsp;</p>

<p>Cependant, la FONCTION MARKETING est historiquement&nbsp;associ&eacute;e au march&eacute; des clients.<br />
L&#39;image la plus courante du responsable marketing est celle&nbsp;d&#39;un homme charg&eacute;, en priorit&eacute;, de stimuler la demande pour&nbsp;les produits de l&#39;entreprise. En d&#39;autres termes, son activit&eacute;&nbsp;<br />
regroupe tous les efforts &agrave; accomplir en vue d&#39;obtenir les&nbsp;&eacute;changes souhait&eacute;s avec les march&eacute;s vis&eacute;s.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'dd00008d-aada-e811-822a-2c600c6934be', N'da00008d-aada-e811-822a-2c600c6934be', 3, N'La fonction marketing au sein de l''entreprise', N'<p>Afin d&#39;obtenir les &eacute;changes souhait&eacute;s avec les march&eacute;s vis&eacute;s,&nbsp;un organisme (qu&#39;il soit ou non commercial) peut choisir entre&nbsp;quatre options dans la conduite de ses activit&eacute;s&nbsp;<br />
marketing :</p>

<ul>
	<li><strong>L&rsquo;optique production (la demande exc&egrave;de l&rsquo;offre).</strong></li>
</ul>

<p>L&rsquo;optique produit (la technologie est dominante).<br />
L&rsquo;optique vente (stimulation de l&rsquo;int&eacute;r&ecirc;t pour le produit).<br />
L&rsquo;optique marketing (satisfaction des besoins).</p>

<p><br />
1) L&#39;optique production.</p>

<p><br />
S&#39;applique typiquement lorsque la demande exc&egrave;de l&#39;offre (par&nbsp;exemple dans un pays en voie de d&eacute;veloppement).&nbsp;Quelquefois &eacute;galement lorsque le co&ucirc;t doit &ecirc;tre abaiss&eacute; pour&nbsp;<br />
&eacute;tendre le march&eacute;.&nbsp;</p>

<p><br />
Le consommateur choisit les produits en fonction de leur&nbsp;prix et disponibilit&eacute;. Le r&ocirc;le prioritaire du gestionnaire est&nbsp;alors d&#39;accro&icirc;tre la capacit&eacute; de production et d&#39;am&eacute;liorer&nbsp;<br />
l&#39;efficacit&eacute; de la distribution. A abouti dans certains cas &agrave; de retentissants &eacute;checs :&nbsp;<br />
Par exemple, les parfums BIC incompatible avec&nbsp;l&#39;image que le consommateur attend de lui.</p>

<p>2) L&#39;optique produit.</p>

<p><br />
Domaine o&ugrave; la technologie est dominante, souvent &agrave; tort&nbsp;adopt&eacute; par les h&ocirc;pitaux, &eacute;coles, mus&eacute;e, administration.&nbsp;Le consommateur pr&eacute;f&egrave;re le produit qui offre de&nbsp;<br />
meilleures performances. L&#39;entreprise doit donc se&nbsp;consacrer en priorit&eacute; &agrave; am&eacute;liorer la qualit&eacute; de sa&nbsp;production.</p>

<p><br />
Concorde est un exemple o&ugrave; l&#39;innovation technologique&nbsp;a d&eacute;p&eacute;ri faute d&#39;un nombre d&#39;acheteur insuffisant.</p>

<p><br />
3) L&#39;optique vente.</p>

<p><br />
Partis politiques, vendeurs de meubles, promoteurs&nbsp;immobiliers, certaines assurances.<br />
Le consommateur n&#39;ach&egrave;tera pas de lui-m&ecirc;me&nbsp;suffisamment &agrave; l&#39;entreprise &agrave; moins que celle-ci ne&nbsp;consacre beaucoup d&#39;efforts &agrave; stimuler l&#39;int&eacute;r&ecirc;t pour le&nbsp;<br />
produit.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'd7126bad-abda-e811-822a-2c600c6934be', N'd6126bad-abda-e811-822a-2c600c6934be', 1, N'Pourquoi entretenir une marque ?', N'<p>&Agrave; quoi sert une marque ? Vous ne le savez peut-&ecirc;tre pas, mais cr&eacute;er et entretenir une marque prend &eacute;norm&eacute;ment de temps et co&ucirc;te tr&egrave;s cher aux entreprises. Il faut trouver le nom, cr&eacute;er une identit&eacute; visuelle, investir en publicit&eacute;, r&eacute;pondre aux interrogations des consommateurs, aux crises potentielles&hellip;</p>

<p>Alors vous vous demandez s&ucirc;rement pourquoi elles le font. Et vous avez bien raison ! Si vous comprenez pourquoi les entreprises investissent dans leurs marques, vous saurez pourquoi investir dans la v&ocirc;tre.</p>

<blockquote>
<p><em>Faisons ensemble une exp&eacute;rience :</em></p>

<p>Pensez &agrave; la derni&egrave;re fois o&ugrave; vous avez &eacute;t&eacute; faire des courses. Imaginez-vous dans les rayons, regardez les produits, et rappelez-vous ce que vous avez achet&eacute;&hellip;</p>

<p>En faisant ce simple test, vous vous &ecirc;tes sans doute rendu compte de l&rsquo;impact des marques. Dans de nombreux cas, certains produits vous ont saut&eacute; aux yeux. Vous avez reconnu un logo, des couleurs, une forme, un slogan&hellip; Et vous avez &eacute;galement s&ucirc;rement achet&eacute; des produits parce que vous les aviez vus &agrave; la t&eacute;l&eacute; ou parce que vous avez une bonne opinion de la marque, pour des raisons tout &agrave; fait personnelles.</p>
</blockquote>

<p>Une marque, c&rsquo;est cela. C&rsquo;est&nbsp;<strong>un rep&egrave;re mental pour le consommateur</strong>. Sur un march&eacute; tr&egrave;s concurrentiel, les entreprises doivent pouvoir se diff&eacute;rencier. Les marques vont permettre cela. La marque est un ensemble de signes distinctifs qui va permettre de diff&eacute;rencier un produit de ses concurrents, tout en cr&eacute;ant une relation avec les consommateurs.</p>

<p>Une marque forte va &eacute;galement permettre :</p>

<ul>
	<li>
	<p>de&nbsp;<strong>prot&eacute;ger&nbsp;</strong><strong>un produit, un savoir-faire</strong>&nbsp;: lorsqu&rsquo;une marque est tr&egrave;s forte, il est plus compliqu&eacute; de l&rsquo;imiter, de la concurrencer de mani&egrave;re directe</p>
	</li>
	<li>
	<p>de<strong>&nbsp;rassurer&nbsp;</strong><strong>le consommateur</strong>&nbsp;: une marque c&rsquo;est une garantie de recherches avanc&eacute;es, d&rsquo;&eacute;tudes, d&rsquo;un savoir-faire auxquels on peut faire confiance</p>
	</li>
	<li>
	<p>de&nbsp;<strong>garantir les revenus</strong>&nbsp;: une marque recherch&eacute;e permet d&rsquo;augmenter les marges tout en &eacute;tant certain de conserver un volume important.&nbsp;</p>
	</li>
</ul>

<p>D&rsquo;apr&egrave;s G. Lewi, sp&eacute;cialiste des marques reconnu, une marque s&rsquo;appuie sur des atouts<strong>&nbsp;tangibles</strong>&nbsp;et&nbsp;<strong>intangibles</strong>. Si vous souhaitez en savoir plus, n&rsquo;h&eacute;sitez pas &agrave; suivre le cours<a href="https://openclassrooms.com/courses/construisez-votre-plateforme-de-marque">&nbsp;Construisez et pilotez une marque dans le temps</a>. Si vous souhaitez simplement mieux comprendre ces &laquo; atouts&nbsp;&raquo; des marques, c&rsquo;est dans&nbsp;<a href="https://openclassrooms.com/courses/construisez-votre-plateforme-de-marque/initiez-vous-au-branding#/id/r-5037307">le premier chapitre</a>&nbsp;!</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'd8126bad-abda-e811-822a-2c600c6934be', N'd6126bad-abda-e811-822a-2c600c6934be', 2, N'Qu’est-ce qui fait réellement une marque ?', N'<p>Faisons un deuxi&egrave;me test. Pour cela, pensez &agrave; une marque que vous appr&eacute;ciez particuli&egrave;rement. Ou au contraire, pensez &agrave; une marque que vous d&eacute;testez vraiment.</p>

<p>Vous l&rsquo;avez ? Maintenant demandez-vous &laquo; pourquoi ? &raquo;.</p>

<p>Il y a peu de chances que cette opinion soit due au design du logo, aux couleurs de la charte graphique, au nom ou au slogan de la marque. Pourtant, ce sont ces &eacute;l&eacute;ments qui vous ont permis de reconna&icirc;tre les marques, lors de notre premier test.</p>

<p>Ce qui va impacter votre opinion d&rsquo;une marque est en r&eacute;alit&eacute; bien plus personnel. Et cela se jouera sur 3 aspects :</p>

<ul>
	<li>
	<p>La perception que vous en avez ;&nbsp;</p>
	</li>
	<li>
	<p>Sa r&eacute;putation sur son march&eacute; ;&nbsp;</p>
	</li>
	<li>
	<p>L&rsquo;exp&eacute;rience que vous ou votre entourage proche avez de cette marque.</p>
	</li>
</ul>

<p>Perception, r&eacute;putation, exp&eacute;rience. Retenez bien ces trois mots, ils vous seront essentiels tout au long de ce cours. C&rsquo;est en effet ce que vous allez chercher &agrave; influencer en mettant en place votre strat&eacute;gie de marque personnelle.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'd9126bad-abda-e811-822a-2c600c6934be', N'd6126bad-abda-e811-822a-2c600c6934be', 3, N'Personal branding, comment le définir ?', N'<p>Le personal branding, c&rsquo;est le fait d&rsquo;utiliser diff&eacute;rents leviers, online ou offline, pour se positionner sur un march&eacute; et s&rsquo;assurer d&rsquo;y &ecirc;tre reconnu pour y cr&eacute;er des opportunit&eacute;s. Gr&acirc;ce &agrave; une approche construite et coh&eacute;rente, le personal branding permet d&rsquo;impacter positivement la perception que vos cibles auront de vous.</p>

<p>Il y a deux d&eacute;finitions plus &laquo; officielles &raquo; que je trouve particuli&egrave;rement int&eacute;ressantes.</p>

<p>La premi&egrave;re est celle de Peter Montoya. C&rsquo;est l&rsquo;un des principaux th&eacute;oriciens du personal branding. Il a &eacute;t&eacute; le premier &agrave; d&eacute;finir une v&eacute;ritable m&eacute;thode. Il a publi&eacute; deux livres de r&eacute;f&eacute;rence,&nbsp;<em>The Personal Branding Phenomenon</em>, en 2002 et&nbsp;<em>The Brand Called You</em>&nbsp;en 2003.&nbsp;</p>

<p>Sa d&eacute;finition du personal branding est la suivante :</p>

<blockquote>
<p>&laquo; Votre marque, c&rsquo;est l&rsquo;id&eacute;e<strong>&nbsp;claire, forte et positive</strong>&nbsp;qui vient &agrave; l&rsquo;esprit des personnes quand elles pensent &agrave; vous. &raquo;&nbsp;</p>
</blockquote>

<p>Il d&eacute;finit la marque comme une id&eacute;e. C&rsquo;est donc bien une perception. Vous retrouvez &eacute;galement dans cette d&eacute;finition 3 mots cl&eacute;s d&rsquo;une marque personnelle forte :</p>

<ul>
	<li>
	<p><strong>Claire&nbsp;</strong><strong>:</strong>&nbsp;le personal branding permet de pr&eacute;ciser qui vous &ecirc;tes et la valeur que vous apportez, pour mieux le communiquer ;&nbsp;</p>
	</li>
	<li>
	<p><strong>Forte :</strong>&nbsp;pour pouvoir mieux vous diff&eacute;rencier et impacter vos cibles ;</p>
	</li>
	<li>
	<p><strong>Positive :</strong>&nbsp;car il est essentiel que les personnes qui sont expos&eacute;es &agrave; votre marque aient envie de travailler avec vous.</p>
	</li>
</ul>

<p>La deuxi&egrave;me d&eacute;finition est celle de Jeff Bezos, fondateur et CEO d&rsquo;Amazon, qui a lui-m&ecirc;me une marque personnelle exemplaire :</p>

<blockquote>
<p>&laquo; Votre marque, c&rsquo;est ce que les gens disent de vous lorsque vous n&rsquo;&ecirc;tes plus dans la pi&egrave;ce.&nbsp;&raquo;&nbsp;</p>
</blockquote>

<p>Ce que j&rsquo;aime ici, c&rsquo;est cette id&eacute;e de &laquo; pi&egrave;ce &raquo;. Il y a encore quelques ann&eacute;es, lorsque vous quittiez la pi&egrave;ce, les discussions se prolongeaient relativement peu. Elles duraient le temps d&rsquo;une soir&eacute;e, ou d&rsquo;un &eacute;v&eacute;nement. Aujourd&#39;hui, cette pi&egrave;ce est sans cesse ouverte, et les discussions y sont constantes. Cette pi&egrave;ce, c&rsquo;est Internet et les r&eacute;seaux sociaux, et, que vous en soyez conscient ou non, on y parle de vous.</p>

<p>Entretenir votre marque personnelle, c&rsquo;est faire en sorte que ces discussions, que vous ignorez peut-&ecirc;tre, soient positives et servent vos objectifs. C&rsquo;est aussi apprendre &agrave; mieux ma&icirc;triser ces discussions, mais &eacute;galement &agrave; les cr&eacute;er, si elles n&rsquo;existaient pas.</p>

<p>Visibilit&eacute; et cr&eacute;dibilit&eacute; sont s&ucirc;rement les deux mots que vous retrouverez le plus dans ce cours. Ce sont en effet les deux cibles principales de votre personal branding, que l&rsquo;on retrouve tr&egrave;s bien dans ces diff&eacute;rentes d&eacute;finitions.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'da126bad-abda-e811-822a-2c600c6934be', N'd6126bad-abda-e811-822a-2c600c6934be', 4, N'Quelques idées reçues sur le personal branding', N'<p>Afin d&rsquo;&ecirc;tre aussi pr&eacute;cis que possible, voici quelques raccourcis souvent faits avec le personal branding.</p>

<blockquote>
<p>&laquo; Le personal branding, c&rsquo;est un CV.&nbsp;&raquo;</p>
</blockquote>

<p>Loin de l&agrave;. Si votre CV va en effet &ecirc;tre l&rsquo;une des repr&eacute;sentations de votre marque, surtout si vous &ecirc;tes en recherche d&rsquo;emploi, ce n&rsquo;est pas tout.</p>

<p>Un CV est relativement fig&eacute;. C&rsquo;est au mieux une expression de votre marque, &agrave; un instant T. Votre personal branding va bien au-del&agrave;, et c&rsquo;est avant tout&nbsp;<strong>une somme d&rsquo;outils et d&rsquo;actions</strong><strong>&nbsp;compl&eacute;mentaires</strong>. R&eacute;sumer le personal branding &agrave; un simple outil, aussi important soit-il, est donc faux.&nbsp;</p>

<blockquote>
<p>&laquo; Ce qui compte, c&rsquo;est le nombre de followers.&nbsp;&raquo;</p>
</blockquote>

<p>L&agrave; encore, c&rsquo;est un raccourci un peu facile, et assez &eacute;loign&eacute; de la r&eacute;alit&eacute;. Bien entendu, avoir un grand nombre de followers, ou de connexions (selon les r&eacute;seaux sociaux) est un atout pour votre marque, car ce r&eacute;seau va amplifier votre visibilit&eacute;.</p>

<p>Mais encore faut-il que cette communaut&eacute; soit&nbsp;<strong>compos&eacute;e des bonnes personnes</strong>. Clients potentiels, partenaires, acteurs de votre &eacute;cosyst&egrave;me, ambassadeurs, influenceurs&hellip; auront un impact r&eacute;el pour votre marque.</p>

<p>En effet, &ecirc;tre tr&egrave;s visible aupr&egrave;s des &eacute;tudiants qui vous suivent pour la qualit&eacute; des articles explicatifs que vous faites, ne sera que peu pertinent si vous &ecirc;tes en recherche de missions freelance par exemple. Ce ne sont tout simplement pas les bons interlocuteurs.</p>

<p>&nbsp;</p>

<blockquote>
<p>&laquo; Une marque personnelle mesure la notori&eacute;t&eacute;.&nbsp;&raquo;</p>
</blockquote>

<p>Cela est assez proche du point pr&eacute;c&eacute;dent et du nombre de followers. L&agrave; encore, &ecirc;tre connu est une chose, encore faut-il l&rsquo;&ecirc;tre aupr&egrave;s de la bonne cible. La notori&eacute;t&eacute; est un point important pour votre marque, puisqu&rsquo;elle ne pourra pas avoir d&rsquo;impact si elle est inconnue. Mais ce n&rsquo;est pas une fin en soi, sauf peut-&ecirc;tre si vous &ecirc;tes artiste.</p>

<p>Outre la notori&eacute;t&eacute;, ce qui va avoir de l&rsquo;importance en personal branding, c&rsquo;est<strong>&nbsp;la consid&eacute;ration</strong>. Vous avez peut-&ecirc;tre d&eacute;j&agrave; particip&eacute; &agrave; des enqu&ecirc;tes sur des marques. Un classique est de demander dans un premier temps &laquo; quelles marques connaissez-vous ? &raquo;. Une question suivante sera de savoir &laquo; quelles marques vous avez d&eacute;j&agrave; achet&eacute;es, ou envisag&eacute;es d&rsquo;acheter ? &raquo;. Enfin, la derni&egrave;re question sera parfois &laquo; laquelle de ces marques recommanderiez-vous &agrave; vos proches ? &raquo;.&nbsp;</p>

<p>Si &ecirc;tre dans la premi&egrave;re liste (notori&eacute;t&eacute;) est un bon point pour une marque, signe qu&rsquo;elle est bien positionn&eacute;e et a bien communiqu&eacute;, l&rsquo;objectif est bien d&rsquo;&ecirc;tre dans les deux autres listes, car c&rsquo;est l&agrave; que se trouvent les opportunit&eacute;s business. Pensez de m&ecirc;me pour votre marque.</p>

<p>&nbsp;</p>

<blockquote>
<p>&laquo; Cr&eacute;er et entretenir sa marque c&rsquo;est facile.&nbsp;&raquo;</p>
</blockquote>

<p>Pas tant que &ccedil;a (et heureusement sinon ce cours serait inutile !). En effet, l&rsquo;exercice dans lequel vous allez vous lancer, et qui sera extr&ecirc;mement enrichissant, demande tout d&rsquo;abord un peu de temps. Au d&eacute;but bien s&ucirc;r, mais &eacute;galement par la suite, pour faire durer votre marque et l&rsquo;installer dans le dur&eacute;e.</p>

<p>D&rsquo;autre part, pour cr&eacute;er une marque forte, il vous faudra porter plusieurs casquettes en m&ecirc;me temps. Community manager certains jours, journaliste les autres. D&eacute;veloppeur de votre propre site le matin, blogueur ou YouTuber l&rsquo;apr&egrave;s-midi&hellip; Bien entendu, toutes ces comp&eacute;tences sont totalement accessibles, via des cours en ligne par exemple, et je les approcherai tout au long de ce cours, pour vous simplifier votre travail autant que possible !</p>

<p>Enfin, il est important de garder en t&ecirc;te que si cr&eacute;er et entretenir votre marque prend du temps, la d&eacute;truire se fait bien plus rapidement. Un mauvais tweet, une recommandation d&eacute;sastreuse, et tous vos efforts pourraient partir en fum&eacute;e, d&rsquo;o&ugrave; l&rsquo;int&eacute;r&ecirc;t d&rsquo;avoir une approche construite, pragmatique et pr&eacute;cise comme celle que je vous propose dans ce cours.</p>

<p>Pour continuer dans notre d&eacute;couverte et mieux cerner ce qu&rsquo;est une marque personnelle, voyons quelques exemples particuli&egrave;rement forts.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'ae6b4ae8-abda-e811-822a-2c600c6934be', N'ad6b4ae8-abda-e811-822a-2c600c6934be', 1, N'Steve Jobs', N'<p>Sans doute l&rsquo;une des meilleures r&eacute;f&eacute;rences en termes de marque personnelle. En lisant ce nom, vous avez s&ucirc;rement pens&eacute; &agrave; plusieurs &eacute;l&eacute;ments. Les produits Apple, bien s&ucirc;r. Ses keynotes, qui aujourd&rsquo;hui encore sont une r&eacute;f&eacute;rence, notamment ceux du lancement du premier iPhone ou du Macbook air.<br />
Vous avez s&ucirc;rement en t&ecirc;te &eacute;galement son style vestimentaire : Jean, baskets blanches, pull &agrave; col roul&eacute;. Et bien s&ucirc;r, ses lunettes. Tous ces &eacute;l&eacute;ments identifient Steve Jobs, le rendent reconnaissable et portent sa marque.</p>

<p>Les autres id&eacute;es qui vous sont s&ucirc;rement venues &agrave; l&rsquo;esprit sont celles de l&rsquo;innovation et de la technologie, qui lui sont attach&eacute;es. Si vous connaissez un peu mieux l&rsquo;histoire de Steve Jobs, vous aurez &eacute;galement s&ucirc;rement en t&ecirc;te une image de &laquo; sauveur &raquo;, puisqu&rsquo;apr&egrave;s avoir &eacute;t&eacute; &eacute;vinc&eacute; de la marque qu&rsquo;il avait lui-m&ecirc;me cr&eacute;&eacute;e, il a &eacute;t&eacute; rappel&eacute; alors qu&rsquo;elle &eacute;tait au plus bas, et en a fait ce que l&rsquo;on conna&icirc;t aujourd&rsquo;hui.<br />
Enfin, si vous le connaissez, vous avez s&ucirc;rement pens&eacute; &agrave; son discours &agrave; Stanford en 2005. Un discours des plus inspirants o&ugrave; Steve Jobs va se livrer comme jamais avec une authenticit&eacute; bluffante. Les conseils prodigu&eacute;s dans ce que certains appellent son &laquo; discours testament&nbsp;&raquo; guident et inspirent aujourd&rsquo;hui de nombreux professionnels.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'af6b4ae8-abda-e811-822a-2c600c6934be', N'ad6b4ae8-abda-e811-822a-2c600c6934be', 2, N'Elon Musk', N'<p>L&agrave; encore, vous avez s&ucirc;rement pens&eacute; &agrave; des choses tr&egrave;s fortes. Science, pionnier, innovation, ambition, d&eacute;mesure, milliardaire sont s&ucirc;rement les mots qui vous sont venus naturellement.<br />
Vous avez pens&eacute; &agrave; l&rsquo;empire qu&rsquo;il a cr&eacute;&eacute;, &agrave; son obsession de l&rsquo;espace et pourquoi pas &agrave; sa m&eacute;galomanie, puisqu&rsquo;il a quand m&ecirc;me d&eacute;cid&eacute; d&rsquo;envoyer l&rsquo;un de ses v&eacute;hicules dans l&rsquo;espace ! Vous avez peut-&ecirc;tre &eacute;galement pens&eacute; &agrave; des conf&eacute;rences qu&rsquo;il a pu donner, &agrave; des interviews o&ugrave; vous l&rsquo;avez trouv&eacute; visionnaire ou, au contraire, pr&eacute;tentieux.</p>

<p>Vous avez imm&eacute;diatement eu un sentiment sur cette personne, positif ou n&eacute;gatif, li&eacute; &agrave; ce qu&rsquo;il communique, lors de conf&eacute;rences, ou sur les r&eacute;seaux sociaux notamment. Sa marque personnelle vous inspire peut-&ecirc;tre sur un plan professionnel, ou ne vous parle peut-&ecirc;tre pas du tout. Mais imaginez-vous en investisseur millionnaire&hellip; vous investiriez dans ses activit&eacute;s sans h&eacute;siter une seule seconde !</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'b06b4ae8-abda-e811-822a-2c600c6934be', N'ad6b4ae8-abda-e811-822a-2c600c6934be', 3, N'Salvador Dalí', N'<p>Aujourd&rsquo;hui encore, ses tableaux se vendent &agrave; des millions d&rsquo;euros. Cela est d&ucirc;, outre son style artistique, au fait que Dali &eacute;tait un personnage. Si vous connaissez peu ou pas ses oeuvres, vous avez s&ucirc;rement pens&eacute; &agrave; son embl&eacute;matique moustache, &agrave; son grain de folie, son excentricit&eacute;.</p>

<p>Vous avez pu penser &agrave; son regard un peu fou ou d&eacute;cal&eacute; sur les photos. Vous l&rsquo;associez au monde du r&ecirc;ve, de l&rsquo;inconscient et bien s&ucirc;r du surr&eacute;alisme. Sans forc&eacute;ment conna&icirc;tre bien son oeuvre, vous avez une perception tr&egrave;s pr&eacute;cise de cet artiste. Cela est d&ucirc; &agrave; l&rsquo;impact laiss&eacute; par sa marque personnelle. Alors qu&rsquo;il y avait bien d&rsquo;autres peintres, il lui a fallu se d&eacute;marquer. Cette personnalit&eacute; unique, tout comme son style artistique, l&rsquo;ont aid&eacute; &agrave; atteindre ses objectifs.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'b16b4ae8-abda-e811-822a-2c600c6934be', N'ad6b4ae8-abda-e811-822a-2c600c6934be', 4, N'Gary Vaynerchuk', N'<p>Ce n&rsquo;est s&ucirc;rement pas le plus connu des diff&eacute;rentes personnes que je vous propose ici. Pourtant, il a pouss&eacute; sa marque personnelle &agrave; un niveau tr&egrave;s avanc&eacute;. Gary Vaynerchuk a su jouer avec les r&eacute;seaux sociaux et les technologies tout au long de sa carri&egrave;re pour devenir un v&eacute;ritable gourou de la communication.</p>

<p>C&rsquo;est un pro du &laquo; storytelling &raquo;, notion que nous aborderons plus tard dans ce cours. &Agrave; presque chaque intervention, chaque keynote, il revient sur la mani&egrave;re dont il a cr&eacute;&eacute; son business et construit son succ&egrave;s. Il r&eacute;p&egrave;te sans cesse qu&rsquo;il a repris le business de son p&egrave;re pour le faire passer de 3 &agrave; 60 millions de dollars, gr&acirc;ce notamment &agrave; YouTube, qu&rsquo;il a &eacute;t&eacute; le premier &agrave; exploiter v&eacute;ritablement.<br />
Il aime aussi rappeler que son objectif est de racheter les Jets de New-York, une &eacute;quipe de football am&eacute;ricain dont il est fan depuis son enfance. Il en profite pour rappeler qu&rsquo;enfant, son premier business &eacute;tait justement d&rsquo;acheter et de revendre des cartes de sport de collection, que c&rsquo;est ainsi que tout a commenc&eacute;.<br />
&Agrave; force de r&eacute;p&eacute;ter ses histoires (je vous invite &agrave; toutes les d&eacute;couvrir dans ses nombreuses vid&eacute;os et podcasts), Gary s&rsquo;est construit un v&eacute;ritable personnage. Business angel ou consultant pour Uber, Twitter, Facebook, Snapchat et bien d&rsquo;autres, il est connu et reconnu pour son expertise web, son franc-parler et son intuition, qui lui a souvent rapport&eacute; gros ! Il est extr&ecirc;mement actif sur Instagram principalement, mais aussi sur d&rsquo;autres r&eacute;seaux et donne de nombreuses conf&eacute;rences, gr&acirc;ce &agrave; cette marque personnelle tr&egrave;s puissante.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'b26b4ae8-abda-e811-822a-2c600c6934be', N'ad6b4ae8-abda-e811-822a-2c600c6934be', 5, N'Leonardo DiCaprio', N'<p>Bien entendu, vous avez tout d&rsquo;abord pens&eacute; &agrave; l&rsquo;acteur. Leo a r&eacute;ussi &agrave; passer du statut d&rsquo;acteur pour adolescentes &agrave; celui de v&eacute;ritable star d&rsquo;Hollywood, d&eacute;sormais oscaris&eacute;, ce qui est un v&eacute;ritable tour de force.<br />
Mais au-del&agrave; de son statut d&rsquo;acteur, il a su cr&eacute;er une marque forte sur la th&eacute;matique de l&rsquo;environnement. Aujourd&rsquo;hui, il est aussi connu pour ses films que pour ses nombreuses prises de parole et de position pour la protection de notre plan&egrave;te. Il a d&rsquo;ailleurs cr&eacute;&eacute; sa propre fondation et a &eacute;crit et produit un documentaire sur le r&eacute;chauffement climatique &laquo; La 11e heure, le dernier virage &raquo;.<br />
Cet engagement est un v&eacute;ritable acte fondateur pour r&eacute;orienter sa marque et utiliser sa notori&eacute;t&eacute; pour atteindre de nouveaux objectifs. Cela lui conf&egrave;re un statut particulier et il met souvent sa marque au service de causes ou d&rsquo;entreprises proches de ses valeurs.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'b36b4ae8-abda-e811-822a-2c600c6934be', N'ad6b4ae8-abda-e811-822a-2c600c6934be', 6, N'Bono de U2', N'<p>Au m&ecirc;me titre que Leonardo DiCaprio, vous avez s&ucirc;rement dans un premier temps pens&eacute; &agrave; l&rsquo;artiste et &agrave; ses tubes rocks et engag&eacute;s, comme Sunday, Bloody Sunday par exemple.</p>

<p>Mais au-del&agrave; de sa musique, Bono a r&eacute;ussi &agrave; r&eacute;orienter sa marque pour la mettre au service d&rsquo;autres objectifs. Il milite ainsi dans la lutte contre la pauvret&eacute;, au travers de Campagne ONE dont il est cofondateur, ou encore dans la lutte contre le sida, notamment au travers de (Product) RED, un nom aujourd&rsquo;hui associ&eacute; &agrave; d&rsquo;autres marques dont Apple.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'8c0fa915-acda-e811-822a-2c600c6934be', N'8b0fa915-acda-e811-822a-2c600c6934be', 1, N'Les 4 objectifs principaux du personal branding', N'<p>Votre strat&eacute;gie de personal branding vous permettra de r&eacute;pondre &agrave; plusieurs objectifs. Ceux-l&agrave; sont personnels. Ainsi, vos objectifs seront diff&eacute;rents de ceux de vos coll&egrave;gues, pairs, ami(e)s ou connaissances. Ils s&rsquo;articulent cependant toujours autour de quatre enjeux principaux :</p>

<h4><strong>1. Contr&ocirc;ler&nbsp;</strong>&nbsp;</h4>

<p>Lorsque vous vous lancez dans un projet de marque personnelle, le contr&ocirc;le sera sans aucun doute votre premi&egrave;re pr&eacute;occupation. Aujourd&rsquo;hui, tout ce que vous dites, faites ou partagez, notamment sur Internet, est archiv&eacute; et peut ressortir &agrave; tout moment, parfois au plus mauvais. Travailler votre marque personnelle, c&rsquo;est vous assurer au maximum que les traces que vous laissez sur Internet et aupr&egrave;s des personnes que vous rencontrez sont positives et peuvent devenir un atout pour la suite de votre carri&egrave;re.</p>

<h4><strong>2. Accro&icirc;tre sa visibilit&eacute;</strong>&nbsp;</h4>

<p>Construire une plateforme de marque solide va vous permettre d&rsquo;&ecirc;tre plus visible et d&rsquo;exister dans votre &eacute;cosyst&egrave;me. Cela vous permettra ensuite d&rsquo;&ecirc;tre rep&eacute;r&eacute; de mani&egrave;re naturelle par vos cibles potentielles. Par exemple, je n&rsquo;ai pas postul&eacute; pour faire ce cours, j&rsquo;ai &eacute;t&eacute; contact&eacute; directement par l&rsquo;&eacute;quipe d&rsquo;OpenClassrooms, car j&rsquo;&eacute;tais visible sur Internet et sur les r&eacute;seaux sociaux.</p>

<h4><strong>3. Gagner en cr&eacute;dibilit&eacute;</strong>&nbsp;</h4>

<p>Savoir faire est une chose, faire savoir en est une autre. Au-del&agrave; d&rsquo;exister, il est important que votre marque personnelle vous permette de vous positionner fortement dans votre &eacute;cosyst&egrave;me. Si l&rsquo;on continue l&rsquo;exemple pr&eacute;c&eacute;dent, apr&egrave;s m&rsquo;avoir trouv&eacute; via une recherche, l&rsquo;&eacute;quipe a regard&eacute; mes diff&eacute;rents profils, publications et recommandations afin de s&rsquo;assurer que je pourrais cr&eacute;er et d&eacute;livrer ce cours. Avant m&ecirc;me d&rsquo;avoir &eacute;chang&eacute; avec eux, ils ont estim&eacute; que j&rsquo;&eacute;tais un bon candidat pour ce projet, simplement &agrave; travers ma marque.</p>

<h4><strong>4. Se diff&eacute;rencier</strong>&nbsp;</h4>

<p>Vous &ecirc;tes unique, certes. Mais vos qualifications, exp&eacute;riences, projets&hellip; vous mettent en concurrence avec une multitude de candidats, quel que soit le contexte. Aujourd&rsquo;hui, &ecirc;tre bon dans ce que vous faites n&rsquo;est plus suffisant. Il faut que cela se sache, et il faut que vous apportiez quelque chose de diff&eacute;rent par rapport aux dizaines ou centaines de personnes qui convoitent la m&ecirc;me opportunit&eacute;. En travaillant votre marque professionnelle, vous serez capable de d&eacute;tecter vos facteurs diff&eacute;renciants et de les valoriser pour apporter plus que des comp&eacute;tences ou un savoir-faire.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'8d0fa915-acda-e811-822a-2c600c6934be', N'8b0fa915-acda-e811-822a-2c600c6934be', 2, N'Pour qui ?', N'<p>Lorsque l&rsquo;on conna&icirc;t les principaux objectifs de l&rsquo;entretien de sa marque personnelle, la r&eacute;ponse est simple, pour tous ! &Eacute;tudiants, freelances, employ&eacute;s ou entrepreneurs, tous ont int&eacute;r&ecirc;t &agrave; d&eacute;velopper une marque personnelle. Mais rentrons dans le d&eacute;tail, afin que vous compreniez comment vous allez pouvoir capitaliser sur votre marque et cr&eacute;er plus d&rsquo;opportunit&eacute;s.</p>

<h4>&Eacute;tudiant</h4>

<p>La premi&egrave;re fois que j&rsquo;ai donn&eacute; un cours de personal branding en &eacute;cole de commerce, apr&egrave;s quelques slides sur l&rsquo;id&eacute;e de marque et des enjeux principaux d&rsquo;une marque personnelle, voici la discussion que j&rsquo;ai eue avec une &eacute;tudiante :</p>

<blockquote>
<p>&laquo; - Mais Monsieur, &ccedil;a, c&rsquo;est bien lorsque l&rsquo;on a quelque chose &agrave; vendre. Mais nous, on n&#39;a rien &agrave; vendre !<br />
- Ok&hellip; on est en mars l&agrave;, c&rsquo;est bien &ccedil;a ?<br />
- Oui, mais je ne vois pas le rapport&hellip;<br />
- L&rsquo;ann&eacute;e se termine fin mai, c&rsquo;est &ccedil;a ?<br />
- Oui, apr&egrave;s on doit faire 2 &agrave; 3 mois de stage.<br />
- Ok, et &ccedil;a avance comment les recherches de stage ? (rires et discussions entre les &eacute;tudiants)<br />
- Pas tr&egrave;s bien. J&rsquo;ai envoy&eacute; quelques CV mais je n&rsquo;ai pas eu de r&eacute;ponses, mais c&rsquo;est un peu t&ocirc;t, c&rsquo;est pareil pour nous tous en fait, ce n&#39;est pas facile, on est en deuxi&egrave;me ann&eacute;e donc on n&rsquo;a pas beaucoup d&rsquo;exp&eacute;rience et les entreprises, elles cherchent des personnes qui ont au moins trois ans d&rsquo;exp&eacute;rience&hellip; ou alors faut avoir des contacts, mais c&rsquo;est compliqu&eacute;&hellip;<br />
- Si je te disais que mon agence vient de proposer un stage &agrave; un &eacute;tudiant de Bordeaux que nous avons rep&eacute;r&eacute; sur Twitter ? &Ccedil;a t&rsquo;inspire quoi ?<br />
- Comment &ccedil;a &ldquo;rep&eacute;r&eacute; sur Twitter&rdquo; ? Il a fait quoi ?<br />
- Il a partag&eacute; du contenu int&eacute;ressant, a tagu&eacute; l&rsquo;agence et les personnes qui y travaillent, a &eacute;tabli son r&eacute;seau et semblait tr&egrave;s &agrave; l&rsquo;aise en marketing digital, alors on a &eacute;chang&eacute; avec lui, et comme il cherchait un stage on lui a propos&eacute;&hellip;<br />
- La chance !<br />
- Ce n&#39;est pas de la chance. Il a travaill&eacute; sa marque personnelle, tout simplement. Et toi aussi, vous aussi, cela peut vous aider &agrave; trouver un stage plus facilement, mais aussi pourquoi pas, &agrave; faire en sorte que ce soient les employeurs qui viennent &agrave; vous et vous proposent des opportunit&eacute;s de stage et demain d&rsquo;emploi. Alors, &ccedil;a vous int&eacute;resse ?&rdquo;</p>

<p>Apr&egrave;s cette discussion, je n&rsquo;ai jamais vu des &eacute;tudiants aussi int&eacute;ress&eacute;s et impliqu&eacute;s dans un cours !</p>
</blockquote>

<p>En tant qu&rsquo;&eacute;tudiant, vous &ecirc;tes s&ucirc;rement parmi les mieux plac&eacute;s et les plus int&eacute;ress&eacute;s par la mise en place d&rsquo;une marque professionnelle, que ce soit durant vos &eacute;tudes, pour trouver un stage, ou une fois votre dipl&ocirc;me en poche pour trouver un premier emploi qui r&eacute;pond &agrave; vos attentes. La concurrence est rude et une marque professionnelle forte permet de sortir du lot et vous cr&eacute;er les meilleures opportunit&eacute;s.</p>

<p>Autres avantages pour les &eacute;tudiants : vous &ecirc;tes au d&eacute;but de votre carri&egrave;re, tout est encore possible, toutes les portes sont ouvertes et votre marque est encore tr&egrave;s faible, &agrave; vous de choisir dans quelle direction vous allez la travailler. Vous avez tous les outils &agrave; disposition (cours, professeurs, intervenants ext&eacute;rieurs, opportunit&eacute;s, salons...) pour progresser et cr&eacute;er votre r&eacute;seau. De plus, vous b&eacute;n&eacute;ficiez d&rsquo;une ressource aussi importante que rare : le temps. Cr&eacute;er, positionner et entretenir sa marque prend du temps, autant commencer t&ocirc;t et vous y investir d&egrave;s maintenant.</p>

<h4>Freelance</h4>

<p>Pourquoi faire appel &agrave; un directeur artistique &agrave; plus de 100 &euro;/jour lorsque l&rsquo;on peut trouver quelqu&rsquo;un qui cr&eacute;e des logos pour 20 &euro; sur une plateforme comme Fiverr ? Pourquoi passer par un web designer pour cr&eacute;er son site Internet alors qu&rsquo;une connaissance peut le faire pour 5 fois moins cher &agrave; partir d&rsquo;un template Wordpress ?</p>

<p>Aujourd&rsquo;hui, la France compterait, selon une &eacute;tude Malt et Ouishare de 2017, plus de 830 000 freelances, soit une augmentation de 126 % en 10 ans. Aux &Eacute;tats-Unis, certains organismes estiment que la majorit&eacute; des travailleurs sera freelance d&rsquo;ici &agrave; 2027, et cette tendance pourrait &ecirc;tre la m&ecirc;me en France. Avec une telle concurrence et un acc&egrave;s de plus en plus ais&eacute; &agrave; l&rsquo;information et &agrave; la formation, il vous sera imp&eacute;ratif de vous d&eacute;marquer et de prouver votre valeur. Avoir une marque personnelle forte est pour les freelances bien plus qu&rsquo;un atout, c&rsquo;est devenu un&nbsp;<strong>imp&eacute;ratif.</strong></p>

<p>En travaillant votre marque personnelle en tant que freelance, vous allez pouvoir :</p>

<ul>
	<li>
	<p>Pr&eacute;senter votre travail au plus grand nombre</p>
	</li>
	<li>
	<p>&Ecirc;tre recommand&eacute; par vos clients</p>
	</li>
	<li>
	<p>&Eacute;tablir votre cr&eacute;dibilit&eacute;</p>
	</li>
	<li>
	<p>D&eacute;montrer votre expertise</p>
	</li>
	<li>
	<p>G&eacute;n&eacute;rer plus d&rsquo;opportunit&eacute;s et de business</p>
	</li>
	<li>
	<p>&Ecirc;tre au courant des derni&egrave;res tendances de votre secteur</p>
	</li>
	<li>
	<p>P&eacute;renniser votre activit&eacute;</p>
	</li>
</ul>

<h4>Employ&eacute;</h4>

<p>Contrairement &agrave; ce que beaucoup pensent, travailler sa marque personnelle n&rsquo;est pas utile qu&rsquo;aux personnes en qu&ecirc;te d&rsquo;emploi ou de missions. Cela peut servir &agrave; bien d&rsquo;autres niveaux, y compris lorsque l&rsquo;on a d&eacute;j&agrave; un emploi ou que l&rsquo;on est son propre patron !</p>

<p>Si vous avez d&eacute;j&agrave; un emploi, travailler votre marque professionnelle, avec un focus interne tout particulier va vous permettre de :</p>

<ul>
	<li>
	<p>Gagner en visibilit&eacute; vis-&agrave;-vis de vos coll&egrave;gues</p>
	</li>
	<li>
	<p>Promouvoir votre travail</p>
	</li>
	<li>
	<p>Acc&eacute;l&eacute;rer une promotion</p>
	</li>
	<li>
	<p>Devenir un point de contact privil&eacute;gi&eacute; sur une th&eacute;matique</p>
	</li>
	<li>
	<p>&Ecirc;tre reconnu et mis en avant (lors d&rsquo;&eacute;v&egrave;nements internes par exemple)</p>
	</li>
	<li>
	<p>&Ecirc;tre plus facilement rep&eacute;r&eacute; et recrut&eacute; par d&rsquo;autres entreprises</p>
	</li>
	<li>
	<p>R&eacute;orienter votre carri&egrave;re plus facilement</p>
	</li>
</ul>

<p>Capitaliser sur votre marque, m&ecirc;me lorsque vous avez d&eacute;j&agrave; un emploi, c&rsquo;est donc un investissement sur l&rsquo;avenir. En entretenant le capital de votre marque, vous pourrez plus facilement atteindre vos objectifs &agrave; long terme, m&ecirc;me au sein de votre organisation.</p>

<p>Une fois que l&rsquo;on a obtenu le poste de ses r&ecirc;ves, atteint son objectif, il est parfois tentant de laisser sa marque de c&ocirc;t&eacute; en se disant qu&rsquo;on l&rsquo;a retravaillera lorsque l&rsquo;on sera de nouveau en recherche active. C&rsquo;est une grave erreur. Comme pour n&rsquo;importe quelle marque, lorsque l&rsquo;on arr&ecirc;te de la communiquer ou de l&rsquo;entretenir, votre marque personnelle perd de sa valeur, et il faudra travailler dur pour la relancer. Privil&eacute;giez une approche sur le long terme, en prenant des actions r&eacute;guli&egrave;res pour entretenir votre marque. Nous reviendrons sur ces actions d&rsquo;entretien &agrave; la fin de ce cours.</p>

<h4>&nbsp;</h4>

<h4>Cr&eacute;ateur d&rsquo;entreprise / chef d&rsquo;entreprise</h4>

<p>Cr&eacute;er et g&eacute;rer une entreprise est toute une aventure, avec beaucoup de freins et de difficult&eacute;s sur le parcours. Avec une marque professionnelle forte, certains de ces obstacles deviennent plus facilement surmontables :</p>

<ul>
	<li>
	<p><strong>Trouver des investisseurs</strong>&nbsp;: si vous montez une start-up, vous allez investir beaucoup de temps &agrave; convaincre des investisseurs. Si Xavier Niel ou Elon Musk lancent le m&ecirc;me projet, il ne leur faudra que quelques minutes pour lever les fonds n&eacute;cessaires. Sans en arriver l&agrave;, une marque professionnelle forte servira votre cr&eacute;dibilit&eacute; et vous aidera &agrave; convaincre les banques ou les investisseurs de votre projet.</p>
	</li>
	<li>
	<p><strong>Attirer et retenir les talents</strong>&nbsp;: avoir les bonnes personnes dans ses &eacute;quipes et pouvoir les garder est un r&eacute;el facteur cl&eacute; de succ&egrave;s pour une entreprise et permet d&rsquo;assurer la p&eacute;rennit&eacute; d&rsquo;une activit&eacute;. Avoir une marque forte qui inspire vos &eacute;quipes, qui les repr&eacute;sente de mani&egrave;re positive lors d&rsquo;&eacute;v&egrave;nements, sur les r&eacute;seaux sociaux ou dans les m&eacute;dias va pouvoir jouer un r&ocirc;le cl&eacute; dans ce que l&rsquo;on nomme aujourd&rsquo;hui la &ldquo;guerre des talents&rdquo;.</p>
	</li>
	<li>
	<p><strong>Promouvoir votre offre / vos produits</strong>&nbsp;: lorsque Steve Jobs monte sur sc&egrave;ne le 9 janvier 2007 pour pr&eacute;senter le premier iPhone, celui-ci n&rsquo;est absolument pas pr&ecirc;t. Les bugs sont encore nombreux, et les &eacute;quipes confieront par la suite avoir jou&eacute; avec plusieurs t&eacute;l&eacute;phones, et beaucoup de stress durant toute cette keynote qui restera pourtant dans les annales. Effectivement, le succ&egrave;s est imm&eacute;diat et les commandes affluent. Et cela tient en grande partie &agrave; Steve Jobs et sa marque personnelle. Sa cr&eacute;dibilit&eacute; est un atout cl&eacute; devant les m&eacute;dias, son style, les mots qu&rsquo;il utilise, le ton et le tempo de sa pr&eacute;sentation ont jou&eacute; un r&ocirc;le cl&eacute; dans la commercialisation de ce nouvel outil.</p>
	</li>
</ul>

<p>Cr&eacute;er et entretenir votre marque personnelle va donc &ecirc;tre un atout consid&eacute;rable pour acc&eacute;l&eacute;rer votre carri&egrave;re et vos opportunit&eacute;s, et ce quels que soient vos objectifs et votre statut actuel. Si nous ne sommes pas entr&eacute;s dans le d&eacute;tail ici, cela est &eacute;galement valable pour d&rsquo;autres types d&rsquo;activit&eacute;s, peut-&ecirc;tre moins &eacute;vidents, comme les professions sportives ou artistiques, o&ugrave; l&agrave; aussi la concurrence est rude et o&ugrave; il faut r&eacute;ussir &agrave; se d&eacute;marquer par ce que l&rsquo;on fait mais &eacute;galement par qui l&rsquo;on est.</p>

<p>Ne pas g&eacute;rer votre marque personnelle, c&rsquo;est vous priver de nombreuses opportunit&eacute;s qui sont disponibles mais qui seront propos&eacute;es &agrave; d&rsquo;autres, qui apparaissent plus l&eacute;gitimes. C&rsquo;est aussi prendre le risque de ne pas savoir ce qui est dit sur vous et donc de ne pas pouvoir influer sur la perception que vont avoir, parfois &agrave; tort, des clients, partenaires, employ&eacute;s, employeurs&hellip; potentiels.</p>

<p>Voyons maintenant comment construire cette marque personnelle en partant de ce que vous &ecirc;tes et de l&rsquo;image que vous projetez aujourd&rsquo;hui, sur Internet notamment.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'9f9106c3-b5da-e811-822a-2c600c6934be', N'9e9106c3-b5da-e811-822a-2c600c6934be', 1, N'La partie', N'<p>Le contenu</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'04f2a57e-d7da-e811-822b-2c600c6934be', N'03f2a57e-d7da-e811-822b-2c600c6934be', 1, N'Partie 2', N'<p>Contenu 1</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'4c0303be-25dd-e811-822b-2c600c6934be', N'12d805d7-a4da-e811-822a-2c600c6934be', 1, N'To Python 2, or to Python 3-- that is the question.', N'<p>Le site vous offre la possibilit&eacute; de t&eacute;l&eacute;charger deux versions : Python 2 ou Python 3.</p>

<p>Quelle diff&eacute;rence me direz-vous ?</p>

<p>Tout logiciel est amen&eacute; &agrave; &ecirc;tre mis &agrave; jour r&eacute;guli&egrave;rement pour am&eacute;liorer ses fonctionnalit&eacute;s ou r&eacute;parer des bugs. Vous avez certainement d&eacute;j&agrave; vu un petit message &ldquo;Une nouvelle version de votre logiciel est pr&ecirc;te &agrave; &ecirc;tre install&eacute;e !&rdquo;. Souvent, ces mises &agrave; jour sont r&eacute;trocompatibles, c&rsquo;est-&agrave;-dire que vous pouvez toujours ouvrir vos anciens fichiers avec la nouvelle version.</p>

<p>Par exemple, vous pouvez ouvrir un document Microsoft Word .doc cr&eacute;&eacute; sous Word 1998 avec la version de Word 2016 mais vous ne pourrez pas faire l&rsquo;inverse !</p>

<p>&Agrave; la fin des ann&eacute;es 2000, la Python Software Foundation a travaill&eacute; &agrave; la cr&eacute;ation d&rsquo;une toute nouvelle version du langage qui r&egrave;glerait de nombreux soucis. Malheureusement, il &eacute;tait impossible d&rsquo;assurer la r&eacute;trocompatibilit&eacute;. Lorsque la version 3 de Python est sortie en f&eacute;vrier 2009, la communaut&eacute; a hurl&eacute; car utiliser Python 3 supposait r&eacute;&eacute;crire tous les projets qui utilisaient alors la version 2. Pourtant, les avanc&eacute;es &eacute;taient vraiment s&eacute;duisantes. Vous comprenez un peu le dilemme ?!</p>

<p>Le d&eacute;bat Python 2 versus Python 3 continue de faire rage, m&ecirc;me si de plus en plus de d&eacute;veloppeurs se rangent vers la derni&egrave;re version. Cela va faire bient&ocirc;t 10 ans qu&rsquo;elle est sortie et les modules les plus utilis&eacute;s ont d&eacute;j&agrave; migr&eacute; &agrave; Python 3. C&rsquo;est pourquoi j&rsquo;utiliserai cette version dans ce cours.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'4d0303be-25dd-e811-822b-2c600c6934be', N'12d805d7-a4da-e811-822a-2c600c6934be', 2, N'Installer Python', N'<p>Cliquez sur Download Python 3.X.X (X &eacute;tant les derni&egrave;res versions en date)</p>

<h4><strong>Sous Mac</strong></h4>

<p>D&eacute;compressez le dossier que vous avez t&eacute;l&eacute;charg&eacute; en double-cliquant dessus. Puis cliquez de nouveau sur le document afin de lancer l&rsquo;installation et laissez-vous guider !</p>

<p>Vous utilisez d&eacute;j&agrave; votre console et vous souhaitez utiliser Brew ? Super ! Tapez simplement &nbsp;<code>brew install python3</code>&nbsp; et c&rsquo;est fini !</p>

<h4><strong>Sous Windows</strong></h4>

<p>Enregistrez le dossier &agrave; t&eacute;l&eacute;charger puis suivez les instructions. Quand l&rsquo;installation est termin&eacute;e, vous pouvez vous rendre dans D&eacute;marrer &gt; Tous les Programmes. Vous devriez y voir un nouveau dossier Python contenant, notamment, Python et IDLE.</p>

<h4><strong>Sous Linux</strong></h4>

<p>Python est pr&eacute;-install&eacute; dans la plupart des distributions Linux mais sa version est certainement obsol&egrave;te. Utilisez APT-GET pour l&#39;installer ou mettre &agrave; jour Python.&nbsp;</p>

<p>Tapez &nbsp;<code>sudo apt-get install python3</code>&nbsp; dans votre console.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'4e0303be-25dd-e811-822b-2c600c6934be', N'12d805d7-a4da-e811-822a-2c600c6934be', 3, N'Premiers pas avec la console', N'<h3><strong>Sous Mac et Linux</strong></h3>

<p>La console est un petit programme qui vous permet d&rsquo;interagir directement avec votre ordinateur en parlant son langage. Lorsque vous utilisez un logiciel, n&rsquo;importe lequel, chaque action que vous effectuez avec votre souris est traduite en langage informatique puis ex&eacute;cut&eacute;e par votre ordinateur. La console vous permet d&rsquo;aller plus vite puisque vous n&rsquo;utilisez plus d&rsquo;interface graphique pour traduire vos commandes.</p>

<p>Au d&eacute;but, on a du mal &agrave; s&rsquo;y faire. On se demande &ldquo;Mais pourquoi ? C&rsquo;est si simple avec une souris ! L&agrave; je dois retenir plein de commandes&hellip;&rdquo;. C&rsquo;est plus simple, certes, mais infiniment plus long ! Prenons un exemple basique : supprimer un fichier d&eacute;finitivement.</p>

<p>Normalement, vous allez effectuer un clic droit puis cliquer sur &ldquo;supprimer&rdquo; et votre fichier va &ecirc;tre d&eacute;plac&eacute; dans la corbeille. Vous allez ensuite ouvrir la corbeille et cliquer sur &ldquo;Supprimer d&eacute;finitivement&rdquo;. Le syst&egrave;me d&rsquo;exploitation va alors vous demander si vous &ecirc;tes s&ucirc;r&middot;e de vouloir supprimer ce fichier pour toujours. Vous cliquez &ldquo;oui&rdquo;. Une bonne minute a d&ucirc; s&rsquo;&eacute;couler.</p>

<p>En utilisant votre console, une seule commande suffit. &nbsp;<code>rm -rf nomdudossier</code>&nbsp;. Et voil&agrave;. C&rsquo;est tout, fini, done, acabado, finito, ??. Moins d&rsquo;une seconde !</p>

<p>Cette console vous permet de vous d&eacute;placer dans l&rsquo;ordinateur, d&rsquo;en manipuler les fichiers et m&ecirc;me de cr&eacute;er de petits programmes qui automatiseront certaines t&acirc;ches. Lorsque vous interagissez avec la console, vous parlez en langage bash (sur Linux et Mac) ou en DOS (Windows). bash et DOS n&rsquo;ont pas les m&ecirc;mes super-pouvoirs que Python. Leur fonction est simplement de vous permettre d&rsquo;interagir avec votre ordinateur ! Tandis que Python vous permet de cr&eacute;er des programmes, des sites, des jeux, ...</p>

<p>L&#39;autre nom de la console est &quot;terminal&quot;.</p>

<p>Ce cours n&rsquo;a pas vocation &agrave; vous apprendre &agrave; utiliser la console et vous pouvez vous en sortir sans elle&hellip; pour l&rsquo;instant. Mais vous serez tr&egrave;s vite limit&eacute;. C&rsquo;est pourquoi je vous propose de lire, d&egrave;s maintenant, l&rsquo;excellent chapitre&nbsp;<a href="https://openclassrooms.com/courses/reprenez-le-controle-a-l-aide-de-linux/la-console-ca-se-mange">La Console, &ccedil;a se mange ?</a>&nbsp;du cours&nbsp;<a href="https://openclassrooms.com/courses/reprenez-le-controle-a-l-aide-de-linux">Reprenez le contr&ocirc;le &agrave; l&rsquo;aide de Linux !&nbsp;</a>(pr&eacute;voyez un quart d&rsquo;heure environ).</p>

<p>Retrouvez-moi juste apr&egrave;s !</p>

<h3><strong>Sous Windows</strong></h3>

<p>Windows met &agrave; votre disposition un outil qui s&#39;appelle &quot;Invite de commande&quot; et&nbsp;est tr&egrave;s similaire &agrave; la console dont je viens de parler. Il vous permet de vous d&eacute;placer dans votre ordinateur et de lui demander d&#39;ex&eacute;cuter des actions pour vous. De mani&egrave;re sch&eacute;matique, vous pouvez&nbsp;r&eacute;aliser gr&acirc;ce &agrave; cet outil la majorit&eacute; des actions que vous effectuez avec la souris : ouvrir un fichier, supprimer un document, ex&eacute;cuter un programme, ...</p>

<p>N&eacute;anmoins, il existe de nombreuses diff&eacute;rences qui le rendent difficile &agrave; manier pour un d&eacute;butant (et d&eacute;sagr&eacute;able pour les plus exp&eacute;riment&eacute;s).&nbsp;</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'caa0705e-28dd-e811-822b-2c600c6934be', N'eab1c904-afda-e811-822a-2c600c6934be', 1, N'Les échanges', N'<p style="margin-left:0cm; margin-right:0cm; text-align:justify">Une premi&egrave;re mani&egrave;re de penser le lien social est par l&rsquo;&eacute;change. Nous avons vu cette id&eacute;e dans le cours pr&eacute;c&eacute;dent. On la trouve chez Platon, pour qui la satisfaction des besoins individuels par la division du travail et l&rsquo;&eacute;change est le fondement de la soci&eacute;t&eacute;. On la retrouve chez Durkheim, sous la forme de la &laquo; solidarit&eacute; organique &raquo;. On la trouve enfin chez Adam Smith, avec l&rsquo;id&eacute;e de &laquo; main invisible &raquo; : si les individus poursuivent leurs int&eacute;r&ecirc;ts priv&eacute;s, le plus grand bien g&eacute;n&eacute;ral en r&eacute;sultera car une main invisible les guide vers les actions les plus profitables &agrave; la collectivit&eacute; : &laquo; l&rsquo;individu est conduit par une main invisible &agrave; remplir une fin qui n&rsquo;entre nullement dans ses intentions &raquo; . Dans ce paradigme &eacute;conomique, c&rsquo;est l&rsquo;int&eacute;r&ecirc;t qui assure le lien social et la coh&eacute;sion entre les individus.</p>
')
INSERT [dbo].[LessonPart] ([LSPCODE], [LSCCODE], [LSPNUMBER], [LSPTITLE], [LSPCONTENT]) VALUES (N'cba0705e-28dd-e811-822b-2c600c6934be', N'eab1c904-afda-e811-822a-2c600c6934be', 2, N'Les sentiments', N'<p style="margin-right:0cm; text-align:justify">On peut aussi penser le lien social &agrave; partir des <strong>sentiments</strong>, des <strong>affects</strong>, des <strong>passions</strong>. C&rsquo;est ce que fait Hegel avec l&rsquo;id&eacute;e selon laquelle la passion est une &laquo; ruse de la raison &raquo; qui pousse les hommes &agrave; r&eacute;aliser de grandes choses dont ils n&rsquo;ont pas n&eacute;cessairement conscience, et qui concourent &agrave; l&rsquo;av&egrave;nement d&rsquo;un ordre rationnel et donc au bien de tous. Par exemple, &agrave; travers sont d&eacute;sir personnel de gloire, Napol&eacute;on a r&eacute;pandu les id&eacute;es de la R&eacute;volution et des Lumi&egrave;res en Europe.&nbsp;</p>

<p style="margin-right:0cm; text-align:justify">Selon Freud, l&rsquo;&eacute;change ne suffit pas &agrave; assurer le lien social, il faut ajouter aux lien par l&rsquo;int&eacute;r&ecirc;t un lien d&rsquo;ordre affectif :</p>

<p style="margin-right:0cm; text-align:justify">&nbsp;</p>

<blockquote>
<p style="margin-left:35.45pt; margin-right:42.4pt; text-align:justify"><span style="font-size:10pt"><span style="font-family:&quot;Times New Roman&quot;,serif">L&rsquo;int&eacute;r&ecirc;t de la communaut&eacute; de travail n&rsquo;assurerait pas la coh&eacute;sion [de la soci&eacute;t&eacute;], les passions pulsionnelles sont plus fortes que les int&eacute;r&ecirc;ts rationnels. Il faut que la culture mette tout en &oelig;uvre pour assigner des limites aux pulsions d&rsquo;agression des hommes, pour tenir en soumission leurs manifestations par des formations r&eacute;actionnelles psychiques. De l&agrave; donc la mise en &oelig;uvre de m&eacute;thodes qui doivent inciter les hommes &agrave; des identifications et &agrave; des relations d&rsquo;amour inhib&eacute;es quant au but, de l&agrave; la restriction de la vie sexuelle et de l&agrave; aussi ce commandement de l&rsquo;id&eacute;al&nbsp;: aimer le prochain comme soi-m&ecirc;me, qui se justifie effectivement par le fait que rien d&rsquo;autre ne va autant &agrave; contre-courant de la nature humaine originelle.</span></span></p>
</blockquote>

<p style="margin-left:35.45pt; margin-right:42.4pt; text-align:right"><span style="font-size:10pt"><span style="font-family:&quot;Times New Roman&quot;,serif">Sigmund Freud, <em>Le Malaise dans la culture</em> (1929), V</span></span></p>

<p style="margin-left:35.45pt; margin-right:42.4pt; text-align:justify">&nbsp;</p>

<p>Pour Freud les liens entres les hommes sont essentiellement libidinaux, et il faut l&rsquo;int&eacute;riorisation des exigences sociales dans le psychisme avec l&rsquo;&eacute;rection du surmoi pour que la concorde et la paix puisse &ecirc;tre assur&eacute;e entre les individus. Et c&rsquo;est par amour des autres &ndash; ou plus exactement par angoisse devant la perte d&rsquo;amour &ndash; que les hommes respectent les pr&eacute;ceptes moraux et les lois. Le nerf du lien social est donc, chez Freud, essentiellement li&eacute; &agrave; la libido, elle-m&ecirc;me d&rsquo;origine sexuelle.<br />
Montesquieu admet aussi qu&rsquo;il existe un sentiment propre &agrave; chaque r&eacute;gime politique. Il appelle &laquo; principe &raquo; ce sentiment qui doit animer les hommes pour que le r&eacute;gime en question fonctionne correctement. Le principe de la r&eacute;publique (qu&rsquo;elle soit d&eacute;mocratique ou aristocratique) est la vertu. Le principe de la monarchie est l&rsquo;honneur. Le principe de la tyrannie est la crainte.&nbsp;</p>

<p><br />
Enfin, on peut mentionner Spinoza qui distingue deux grands affects par lesquels les hommes ob&eacute;issent : la crainte et l&rsquo;espoir. Puisqu&rsquo;il vaut mieux &ecirc;tre m&ucirc; par un affect de joie que par une passion triste, Spinoza recommande de faire en sorte que les citoyens soient plut&ocirc;t mus par l&rsquo;espoir que par la crainte. Mais l&rsquo;id&eacute;al est qu&rsquo;ils soient mus par leur raison elle-m&ecirc;me, qui leur commande naturellement de rechercher l&rsquo;utile propre dans l&rsquo;association politique.<br />
&nbsp;</p>
')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'8cde8a70-9b9c-e811-8220-2c600c6934be', N'Sciences et technologies', N'', N'8cde8a70-9b9c-e811-8220-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'e97dc2f7-9b9c-e811-8220-2c600c6934be', N'Marketing', N'', N'e97dc2f7-9b9c-e811-8220-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'89b16d41-9c9c-e811-8220-2c600c6934be', N'Droit', N'', N'89b16d41-9c9c-e811-8220-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'18c841d9-1ca1-e811-8221-2c600c6934be', N'Economie, social et Management', N'', N'18c841d9-1ca1-e811-8221-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'de237780-1da1-e811-8221-2c600c6934be', N'Philosophie et lettres', N'', N'de237780-1da1-e811-8221-2c600c6934be.jpg')
INSERT [dbo].[Study] ([STDCODE], [STDNAME], [STDDESCRIPTION], [STDPICTURE]) VALUES (N'f79b7a04-1ea1-e811-8221-2c600c6934be', N'Technologies d''information et de communication', N'', N'f79b7a04-1ea1-e811-8221-2c600c6934be.jpg')
INSERT [dbo].[SubscribeActivity] ([SUBID], [ACCSUBSCRIBER], [ACCSUBSCRIBED], [SUBDATE]) VALUES (N'99838009-d5da-e811-822b-2c600c6934be', N'ce24bec5-9fda-e811-822a-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', CAST(0x0000A987015E43FB AS DateTime))
INSERT [dbo].[SubscribeActivity] ([SUBID], [ACCSUBSCRIBER], [ACCSUBSCRIBED], [SUBDATE]) VALUES (N'9d540fbd-2dc3-e811-822b-2c600c6934be', N'fe3e0db4-2dc3-e811-822b-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', CAST(0x0000A96901364C6F AS DateTime))
INSERT [dbo].[SubscribeActivity] ([SUBID], [ACCSUBSCRIBER], [ACCSUBSCRIBED], [SUBDATE]) VALUES (N'd6387f0e-2fc3-e811-822b-2c600c6934be', N'd4387f0e-2fc3-e811-822b-2c600c6934be', N'39b3ef12-a1da-e811-822a-2c600c6934be', CAST(0x0000A9690138EEE1 AS DateTime))
INSERT [dbo].[SubscribeActivity] ([SUBID], [ACCSUBSCRIBER], [ACCSUBSCRIBED], [SUBDATE]) VALUES (N'9a838009-d5da-e811-822b-2c600c6934be', N'ce24bec5-9fda-e811-822a-2c600c6934be', N'5a174f87-b5da-e811-822a-2c600c6934be', CAST(0x0000A987015E4C26 AS DateTime))
/****** Object:  Index [PK_ACCOUNT]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [PK_ACCOUNT] PRIMARY KEY NONCLUSTERED 
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [COUNTRY_OF_ACCOUNT_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [COUNTRY_OF_ACCOUNT_FK] ON [dbo].[Account]
(
	[CTRCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [TYPE_OF_ACCOUNT_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [TYPE_OF_ACCOUNT_FK] ON [dbo].[Account]
(
	[ATPCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ACCOUNTSTUDENT]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[AccountStudent] ADD  CONSTRAINT [PK_ACCOUNTSTUDENT] PRIMARY KEY NONCLUSTERED 
(
	[ACSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_STUDENT2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_STUDENT2_FK] ON [dbo].[AccountStudent]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [GENDER_OF_STUDENT_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [GENDER_OF_STUDENT_FK] ON [dbo].[AccountStudent]
(
	[GENCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNTSTUDY_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNTSTUDY_FK] ON [dbo].[AccountStudy]
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNTSTUDY2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNTSTUDY2_FK] ON [dbo].[AccountStudy]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ACCOUNTTEACHER]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[AccountTeacher] ADD  CONSTRAINT [PK_ACCOUNTTEACHER] PRIMARY KEY NONCLUSTERED 
(
	[ACTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_TEACHER2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_TEACHER2_FK] ON [dbo].[AccountTeacher]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [GENDER_OF_TEACHER_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [GENDER_OF_TEACHER_FK] ON [dbo].[AccountTeacher]
(
	[GENCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ACCOUNTTYPE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[AccountType] ADD  CONSTRAINT [PK_ACCOUNTTYPE] PRIMARY KEY NONCLUSTERED 
(
	[ATPCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 03/11/2018 16:56:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 03/11/2018 16:56:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_CATEGORY]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [PK_CATEGORY] PRIMARY KEY NONCLUSTERED 
(
	[CTGID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_COMMENT]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Comment] ADD  CONSTRAINT [PK_COMMENT] PRIMARY KEY NONCLUSTERED 
(
	[COMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_COMMENT_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_COMMENT_FK] ON [dbo].[Comment]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [COMMENTS_OF_LESSON_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [COMMENTS_OF_LESSON_FK] ON [dbo].[Comment]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STATE_OF_COMMENT_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [STATE_OF_COMMENT_FK] ON [dbo].[Comment]
(
	[DCSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_COMMENTANSWER]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[CommentAnswer] ADD  CONSTRAINT [PK_COMMENTANSWER] PRIMARY KEY NONCLUSTERED 
(
	[CANID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_COMMENTANSWER_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_COMMENTANSWER_FK] ON [dbo].[CommentAnswer]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ANSWER_OF_COMMENT_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ANSWER_OF_COMMENT_FK] ON [dbo].[CommentAnswer]
(
	[COMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STATE_OF_COMMENTANSWER_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [STATE_OF_COMMENTANSWER_FK] ON [dbo].[CommentAnswer]
(
	[DCSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_COUNTRY]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [PK_COUNTRY] PRIMARY KEY NONCLUSTERED 
(
	[CTRCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_CULTURE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Culture] ADD  CONSTRAINT [PK_CULTURE] PRIMARY KEY NONCLUSTERED 
(
	[CLTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_CURRICULUM]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Curriculum] ADD  CONSTRAINT [PK_CURRICULUM] PRIMARY KEY NONCLUSTERED 
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STUDY_OF_CURRICULUM_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [STUDY_OF_CURRICULUM_FK] ON [dbo].[Curriculum]
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMCATEGORY_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMCATEGORY_FK] ON [dbo].[CurriculumCategory]
(
	[CTGID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMCATEGORY2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMCATEGORY2_FK] ON [dbo].[CurriculumCategory]
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMLESSONS_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMLESSONS_FK] ON [dbo].[CurriculumLessons]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMLESSONS2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMLESSONS2_FK] ON [dbo].[CurriculumLessons]
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMSUBSCRIPTION_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMSUBSCRIPTION_FK] ON [dbo].[CurriculumSubscription]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CURRICULUMSUBSCRIPTION2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CURRICULUMSUBSCRIPTION2_FK] ON [dbo].[CurriculumSubscription]
(
	[CURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_DOCUMENTCONFIDENTIALITY]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[DocumentConfidentiality] ADD  CONSTRAINT [PK_DOCUMENTCONFIDENTIALITY] PRIMARY KEY NONCLUSTERED 
(
	[DCFCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_DOCUMENTSTATE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[DocumentState] ADD  CONSTRAINT [PK_DOCUMENTSTATE] PRIMARY KEY NONCLUSTERED 
(
	[DCSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CULTURE_OF_ENTITY_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CULTURE_OF_ENTITY_FK] ON [dbo].[EntityStrings]
(
	[CLTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Exercice] ADD  CONSTRAINT [PK_EXERCICE] PRIMARY KEY NONCLUSTERED 
(
	[EXCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXCERCICE_OF_LESSON_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [EXCERCICE_OF_LESSON_FK] ON [dbo].[Exercice]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICECORRECTION_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [EXERCICECORRECTION_FK] ON [dbo].[ExerciceCorrection]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICECORRECTION2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [EXERCICECORRECTION2_FK] ON [dbo].[ExerciceCorrection]
(
	[EXDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEDONE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[ExerciceDone] ADD  CONSTRAINT [PK_EXERCICEDONE] PRIMARY KEY NONCLUSTERED 
(
	[EXDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_EXERCICE_DONE_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_EXERCICE_DONE_FK] ON [dbo].[ExerciceDone]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICE_OF_EXERCICE_DONE_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [EXERCICE_OF_EXERCICE_DONE_FK] ON [dbo].[ExerciceDone]
(
	[EXCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEQUESTION]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[ExerciceQuestion] ADD  CONSTRAINT [PK_EXERCICEQUESTION] PRIMARY KEY NONCLUSTERED 
(
	[EXQCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FIELD_TYPE_OF_QUESTION_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [FIELD_TYPE_OF_QUESTION_FK] ON [dbo].[ExerciceQuestion]
(
	[FLDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [QUESTIONS_OF_EXERCICE_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [QUESTIONS_OF_EXERCICE_FK] ON [dbo].[ExerciceQuestion]
(
	[EXCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [TYPE_OF_QUESTION_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [TYPE_OF_QUESTION_FK] ON [dbo].[ExerciceQuestion]
(
	[EQTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [VALUES_CHOICE_OF_QUESTION_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [VALUES_CHOICE_OF_QUESTION_FK] ON [dbo].[ExerciceQuestion]
(
	[EQCCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICEQUESTIONANSWER_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [EXERCICEQUESTIONANSWER_FK] ON [dbo].[ExerciceQuestionAnswer]
(
	[EXDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EXERCICEQUESTIONANSWER2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [EXERCICEQUESTIONANSWER2_FK] ON [dbo].[ExerciceQuestionAnswer]
(
	[EXQCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEQUESTIONCHOICE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[ExerciceQuestionChoice] ADD  CONSTRAINT [PK_EXERCICEQUESTIONCHOICE] PRIMARY KEY NONCLUSTERED 
(
	[EQCCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_EXERCICEQUESTIONTYPE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[ExerciceQuestionType] ADD  CONSTRAINT [PK_EXERCICEQUESTIONTYPE] PRIMARY KEY NONCLUSTERED 
(
	[EQTCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_FIELDTYPE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[FieldType] ADD  CONSTRAINT [PK_FIELDTYPE] PRIMARY KEY NONCLUSTERED 
(
	[FLDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_FOLLOWSTATE]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[FollowState] ADD  CONSTRAINT [PK_FOLLOWSTATE] PRIMARY KEY NONCLUSTERED 
(
	[FLSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_GENDER]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Gender] ADD  CONSTRAINT [PK_GENDER] PRIMARY KEY NONCLUSTERED 
(
	[GENCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_LESSON]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Lesson] ADD  CONSTRAINT [PK_LESSON] PRIMARY KEY NONCLUSTERED 
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CONFIDENTIALITY_OF_LESSON_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CONFIDENTIALITY_OF_LESSON_FK] ON [dbo].[Lesson]
(
	[DCFCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSON_POSTED_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [LESSON_POSTED_FK] ON [dbo].[Lesson]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [STUDY_OF_LESSON_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [STUDY_OF_LESSON_FK] ON [dbo].[Lesson]
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_LESSONCHAPTER]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[LessonChapter] ADD  CONSTRAINT [PK_LESSONCHAPTER] PRIMARY KEY NONCLUSTERED 
(
	[LSCCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CHAPTER_OF_LESSON_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [CHAPTER_OF_LESSON_FK] ON [dbo].[LessonChapter]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSONFOLLOWED_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [LESSONFOLLOWED_FK] ON [dbo].[LessonFollowed]
(
	[ACCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSONFOLLOWED2_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [LESSONFOLLOWED2_FK] ON [dbo].[LessonFollowed]
(
	[LSNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LESSONFOLLOWED3_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [LESSONFOLLOWED3_FK] ON [dbo].[LessonFollowed]
(
	[FLSCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_STUDY]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[Study] ADD  CONSTRAINT [PK_STUDY] PRIMARY KEY NONCLUSTERED 
(
	[STDCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_SUBSCRIBEACTIVITY]    Script Date: 03/11/2018 16:56:27 ******/
ALTER TABLE [dbo].[SubscribeActivity] ADD  CONSTRAINT [PK_SUBSCRIBEACTIVITY] PRIMARY KEY NONCLUSTERED 
(
	[SUBID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_SUBSCRIBED_FK]    Script Date: 03/11/2018 16:56:27 ******/
CREATE NONCLUSTERED INDEX [ACCOUNT_OF_SUBSCRIBED_FK] ON [dbo].[SubscribeActivity]
(
	[ACCSUBSCRIBER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ACCOUNT_OF_SUBSCRIBER_FK]    Script Date: 03/11/2018 16:56:27 ******/
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
