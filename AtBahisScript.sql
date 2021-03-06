USE [master]
GO
/****** Object:  Database [AtBahis]    Script Date: 20.12.2019 09:51:48 ******/
CREATE DATABASE [AtBahis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AtBahis', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WISSEN1\MSSQL\DATA\AtBahis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AtBahis_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WISSEN1\MSSQL\DATA\AtBahis_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AtBahis] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AtBahis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AtBahis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AtBahis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AtBahis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AtBahis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AtBahis] SET ARITHABORT OFF 
GO
ALTER DATABASE [AtBahis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AtBahis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AtBahis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AtBahis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AtBahis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AtBahis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AtBahis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AtBahis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AtBahis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AtBahis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AtBahis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AtBahis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AtBahis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AtBahis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AtBahis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AtBahis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AtBahis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AtBahis] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AtBahis] SET  MULTI_USER 
GO
ALTER DATABASE [AtBahis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AtBahis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AtBahis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AtBahis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AtBahis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AtBahis] SET QUERY_STORE = OFF
GO
USE [AtBahis]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [AtBahis]
GO
/****** Object:  Table [dbo].[AtBilgisi]    Script Date: 20.12.2019 09:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AtBilgisi](
	[AtID] [int] IDENTITY(1,1) NOT NULL,
	[AtAdi] [nvarchar](20) NOT NULL,
	[AnaAdi] [nvarchar](20) NULL,
	[BabaAdi] [nvarchar](20) NULL,
	[Ganyan] [float] NOT NULL,
	[Irk] [int] NOT NULL,
	[AktifMi] [bit] NOT NULL,
 CONSTRAINT [PK_AtBilgisi] PRIMARY KEY CLUSTERED 
(
	[AtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BahisTipleri]    Script Date: 20.12.2019 09:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BahisTipleri](
	[BahisTipiID] [int] IDENTITY(1,1) NOT NULL,
	[BahisAdi] [nvarchar](20) NOT NULL,
	[BahisAciklamasi] [ntext] NULL,
 CONSTRAINT [PK_BahisTipleri] PRIMARY KEY CLUSTERED 
(
	[BahisTipiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bulten]    Script Date: 20.12.2019 09:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bulten](
	[BultenID] [int] IDENTITY(1,1) NOT NULL,
	[HipodromID] [int] NOT NULL,
	[Tarih] [date] NOT NULL,
	[KosuID] [int] NOT NULL,
	[KosuAdi] [int] NULL,
	[Sira] [int] NOT NULL,
	[AtID] [int] NOT NULL,
	[PistTipi] [bit] NOT NULL,
	[YarisacakAtSayisi] [int] NOT NULL,
	[BaslangicSaati] [time](7) NULL,
	[AtAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bulten] PRIMARY KEY CLUSTERED 
(
	[BultenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hipodrom]    Script Date: 20.12.2019 09:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hipodrom](
	[HipodromID] [int] IDENTITY(1,1) NOT NULL,
	[HipodromAdi] [nvarchar](50) NOT NULL,
	[SehirID] [int] NOT NULL,
	[IlceID] [int] NOT NULL,
	[CimPistSayisi] [int] NULL,
	[KumPistSayisi] [int] NULL,
 CONSTRAINT [PK_Hipodrom] PRIMARY KEY CLUSTERED 
(
	[HipodromID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kupon]    Script Date: 20.12.2019 09:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kupon](
	[KuponID] [int] IDENTITY(1,1) NOT NULL,
	[KuponNo] [nchar](10) NULL,
	[HipodromID] [int] NOT NULL,
	[Tarih] [date] NOT NULL,
	[BahisTipiID] [int] NOT NULL,
	[KosuID] [int] NOT NULL,
	[Tahmin] [int] NOT NULL,
	[Ganyan] [float] NOT NULL,
	[Misli] [int] NOT NULL,
	[Tutar] [float] NOT NULL,
	[KuponDurumu] [bit] NULL,
 CONSTRAINT [PK_Kupon] PRIMARY KEY CLUSTERED 
(
	[KuponID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sonuc]    Script Date: 20.12.2019 09:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sonuc](
	[SonucID] [int] IDENTITY(1,1) NOT NULL,
	[HipodromID] [int] NOT NULL,
	[Tarih] [date] NULL,
	[KosuID] [int] NOT NULL,
	[Siralama] [int] NOT NULL,
	[atNo] [int] NOT NULL,
	[AtID] [int] NOT NULL,
 CONSTRAINT [PK_Sonuc] PRIMARY KEY CLUSTERED 
(
	[SonucID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AtBilgisi] ON 

INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (1, N'Gürbatur', N'MsBatur', N'MrBatur', 1.35, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (2, N'Obradovic', NULL, NULL, 2.5, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (3, N'A Drop of Love', NULL, NULL, 3.75, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (4, N'Aaron', NULL, NULL, 2.85, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (5, N'Adana Beyi', NULL, NULL, 1.25, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (6, N'Abayakankaya', NULL, NULL, 5.3, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (7, N'Acem Rüzgarı', NULL, NULL, 6.2, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (8, N'Acı Bal', NULL, NULL, 3.45, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (9, N'Adını Sen Koy', NULL, NULL, 2.8, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (10, N'Arım Balım Peteğim', NULL, NULL, 3.3, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (11, N'Baba Ferhat', NULL, NULL, 6.5, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (12, N'Baba Turbo', NULL, NULL, 1.9, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (13, N'Babaannesinin Kuzusu', NULL, NULL, 17, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (14, N'Bad Boy', NULL, NULL, 2.5, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (15, N'Bad Girl', NULL, NULL, 2.5, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (16, N'Godfather', NULL, NULL, 6, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (17, N'Iron Horse', NULL, NULL, 2.6, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (18, N'Badegül', NULL, NULL, 4.5, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (19, N'Bahattin', NULL, NULL, 2.2, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (20, N'Enes Batur', NULL, NULL, 1.1, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (21, N'Cadaloz', NULL, NULL, 2.6, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (22, N'Cadı Melis', NULL, NULL, 8, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (23, N'Cafcaflı', NULL, NULL, 7, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (24, N'Calanthe', NULL, NULL, 3, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (25, N'Camaro', NULL, NULL, 1.8, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (26, N'Camgüzeli', NULL, NULL, 4.5, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (27, N'Canarat', NULL, NULL, 2, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (28, N'Davay Devuşka', NULL, NULL, 1.3, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (29, N'Darth Wader', NULL, NULL, 2.4, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (30, N'Düldül', NULL, NULL, 1.85, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (31, N'Dance of Destiny', NULL, NULL, 9, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (32, N'Dead Pan', NULL, NULL, 7, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (33, N'Deadpool', NULL, NULL, 20, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (34, N'De Niro', NULL, NULL, 3.1, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (36, N'Al Pacino', NULL, NULL, 2.2, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (37, N'Karakaçan', NULL, NULL, 50, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (38, N'Delibaş', NULL, NULL, 4.45, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (39, N'Harun 2.0 TSI', NULL, NULL, 1.25, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (40, N'KadirSLX 1.6', NULL, NULL, 1.65, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (41, N'Emrenin Gücü', NULL, NULL, 1.55, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (42, N'Nurullah 350Z', NULL, NULL, 1.45, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (43, N'Butkan R34', NULL, NULL, 2.5, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (44, N'Ayberk RRS', NULL, NULL, 3.4, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (45, N'Yiğit Model S', NULL, NULL, 1.05, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (46, N'Özgür Evo X', NULL, NULL, 1.65, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (47, N'İlker Freelander', NULL, NULL, 6.5, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (48, N'Oğuzhan SS', NULL, NULL, 9.6, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (49, N'Büşra Cayman', NULL, NULL, 12.7, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (50, N'Eda 206', NULL, NULL, 28, 0, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (51, N'Emirhan Roadster', NULL, NULL, 33, 1, 1)
INSERT [dbo].[AtBilgisi] ([AtID], [AtAdi], [AnaAdi], [BabaAdi], [Ganyan], [Irk], [AktifMi]) VALUES (52, N'Tarfun Mustang', NULL, NULL, 45, 0, 1)
SET IDENTITY_INSERT [dbo].[AtBilgisi] OFF
SET IDENTITY_INSERT [dbo].[BahisTipleri] ON 

INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (1, N'Ganyan', N'Koşunun birincisini bulmak amacıyla oynanan oyundur. Aynı koşuda eküri atlardan birine ganyan oynamakla ekürinin o koşudaki atlarının hepsine ganyan oynamış sayılırsınız. Ancak koşuya eküri olarak katılacağı ilan edilen at veya atlardan çıkan olduğu takdirde bu atların üzerine oynanmış iştirak bedelleri iade edilir. Ganyan oyununa katılım için kupon hazırlamanıza gerek yoktur. Oynamak istediğiniz at/atları ve de tutarı terminalin başında bulunan görevliye deklare etmeniz yetecektir. Bu oyuna kupon doldurmak suretiyle de katılabilirsiniz. Kuponları doldururken, koşu numarasını BAHİS türü için de “G” harfini işaretlemeniz gerekmektedir. Oynayacağınız tutarı misli sütununda, at / atların numarasını da geniş sütunların ilkinde işaretleyince ganyan biletiniz hazır olacaktır.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (2, N'Plase', N'En az 7 atın iştirak edeceği bir koşuda bir atın birinci veya ikinci geleceğini tahmin ederek o at veya atlar üzerine oynanan bahistir.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (3, N'7''li Plase', N'7''li Plase, birbirini takip eden yedi koşunun birinci veya ikincisini bulmak amaçlı bir bahistir. Üzerine oynanan atın birinci veya ikinci gelmesi sonucu değiştirmez ve eşit kazanç sağlar. Aynı ayakta hem birinci hem ikinci gelen atları ihtiva eden bilet her iki at için de ayrı ayrı kazançlı sayılır. 7 koşunun birincilerini içeren bir bilet ile ikincilerini içeren diğer bir biletin kazanç tutarı arasında bir fark olmayacaktır.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (4, N'İkili Bahis', N'En az yedi atın katıldığı bir koşuda “birinci” ve “ikinci” gelecek atları koşunun bitiriş sırasına bakılmaksızın bulmak amacıyla oynanan oyundur. İkili bahis oyununu da terminal başında operatöre deklare etmek suretiyle oynamak mümkündür. Kupon doldurmak suretiyle bu bahse katılmak için koşu numarasını ve bahis sütununda da “I” bölümünü işaretlemeniz gerekmektedir. İkili bahse katılırken oynamak istediğimiz atları kuponlarda ilk iki kolona yazmak zorunda olduğumuzda unutulmamalıdır.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (5, N'Sıralı İkili Bahis', N'En az dört atın katıldığı bir koşuda “birinci” ve “ikinci” gelecek atları koşunun bitiriş sırasına göre bulmak amacıyla oynanan oyundur. Bu oyununu terminal başında operatöre deklare etmek suretiyle oynamak mümkündür. Kupon doldurmak suretiyle bu bahse katılmak için koşu numarasını bahis sütununda “Io” bölümünü işaretlemeniz gerekmektedir. Sıralı ikili bahiste kombine oynamak istiyorsanız bahis sütununda “IK” bölümünü işaretlemeniz gerekmektedir. Sıralı ikili bahse katılırken oynamak istediğimiz atları kuponlarda ilk iki kolona yazmak zorunda olduğumuzda unutulmamalıdır.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (6, N'Plase İkili', N'İlk 3 dereceye girecek 2 atı tahmin ederek o atlar üzerine oynanan bahistir. Bu oyununu terminal başında operatöre deklare etmek suretiyle oynamak mümkündür. Kupon doldurmak suretiyle bu bahse katılmak için koşu numarasını bahis sütununda “PI” bölümünü işaretlemeniz gerekmektedir. Plase ikili bahse katılırken oynamak istediğimiz atları kuponlarda ilk iki kolona yazmak zorunda olduğumuzda unutulmamalıdır.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (7, N'Çifte Bahis', N'İki ayrı koşunun “Birinci” lerini ayrı ayrı bulmak amacıyla oynanan oyundur. Çifte bahis oyununda da eküri kuralı geçerlidir. Bu oyununu da terminal başında operatöre deklare etmek suretiyle oynamak mümkün olduğu gibi kupon doldurmak suretiyle de bu oyuna katılabilirsiniz. Kuponlarınızda oynamak istediğiniz çiftenin ilk ayağını oluşturan koşu numarasını ve BAHİS sütununda da “C” harfini işaretlemeniz gerekmektedir. Çifte bahsimizi kuponlarda ilk iki kolona yazarak dolduracağız .')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (8, N'Tabela Bahis', N'Bir koşuda birinci, ikinci, üçüncü ve dördüncü gelecek atları yarışın bitiriş sırasına göre veya sırasız bulmak amacıyla oynanan bir oyundur. Bu bahis türü de hem kupon doldurarak hem de deklare edilerek oynanabilmektedir. Kupon doldurarak bu oyunu oynayacaksak kuponlarımızda önce koşu numarasını daha sonra bahis sütununda “T” harfini işaretlemeliyiz. Tabela (Dörtlü) bahiste kombine oynamak istiyorsanız bahis sütununda “TK” bölümünü işaretlemeniz gerekmektedir. Bu oyunda da kuponları doldururken geniş sütunların ilkinden başlamanız gerekmektedir.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (9, N'Sıralı Üçlü Bahis ', N'Bir koşunun birinci, ikinci ve üçüncü gelecek atları yarışın bitiriş sırasına göre tahmin ederek o atlar üzerine oynanan bahistir. Bu bahis türü de hem kupon doldurarak hem de deklare edilerek oynanabilmektedir. Kupon doldurarak bu oyunu oynayacaksak kuponlarımızda önce koşu numarasını daha sonra bahis sütununda “U” harfini işaretlemeliyiz. Sıralı üçlü bahiste kombine oynamak istiyorsanız bahis sütununda “UK” bölümünü işaretlemeniz gerekmektedir. Bu oyunda da kuponları doldururken geniş sütunların ilkinden başlamanız gerekmektedir.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (10, N'6''lı Ganyan', N'Aynı gün üzerine oyun konulan 6 koşunun birincilerini bulmak amacıyla oynanan oyundur. 6''lı ganyanda oyun tutarı her ayağa yazılan at sayılarının toplamlarının birbirleri ile çıkan rakamında oyun birim fiyatıyla çarpılmasıyla bulunur. 6''lı ganyanın her ayağında şans verdiğiniz at veya atların numaralarını geniş sütunların ilkinden başlayarak işaretlemeniz gerekmektedir. Bu oyunu oynamak için kuponların BAHİS sütunundaki “6G” harfini işaretlemeniz gerekmektedir Oyununuzu misli olarak oynamak isterseniz kuponunuzdaki MİSLİ sütununu da işaretlemeniz gerekmektedir.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (11, N'5''li Ganyan', N'Aynı gün üzerine bu oyun konulan 5 koşunun birincilerini bulmak amacıyla oynanan oyundur. 5''li ganyanda da oyun tutarı her ayakta oynanan at sayıları toplamlarının birbirleri ile ve çıkan rakam da oyunun birim fiyatıyla çarpılarak bulunur. Bu oyunu oynamak için kuponların BAHİS sütunundaki “5G” harfini işaretlemeniz gerekmektedir. 5''li ganyanın her ayağında şans verdiğimiz at ya da atların numaralarını geniş sütunların ilkinden başlayarak işaretleyeceğiz.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (12, N'4''lü Ganyan
', N'Aynı gün üzerine bu oyun konulan 4 koşunun birincilerini bulmak amacıyla oynanan oyundur. 4''lü ganyanda da oyun tutarı her ayakta oynanan at sayıları toplamlarının birbirleri ile ve çıkan rakam da oyunun birim fiyatıyla çarpılarak bulunur. Bu oyunu oynamak için kuponların BAHİS sütunundaki “4G” harfini işaretlemeniz gerekmektedir. 4''lü ganyanın her ayağında şans verdiğimiz at ya da atların numaralarını geniş sütunların ilkinden başlayarak işaretleyeceğiz.')
INSERT [dbo].[BahisTipleri] ([BahisTipiID], [BahisAdi], [BahisAciklamasi]) VALUES (13, N'3''lü Ganyan', N'Aynı gün üzerine bu oyun konulan 3 koşunun birincilerini bulmak amacıyla oynanan oyundur. 3''lü ganyanda da oyun tutarı her ayakta oynanan at sayıları toplamlarının birbirleri ile ve çıkan rakam da oyunun birim fiyatıyla çarpılarak bulunur. Bu oyunu oynamak için kuponların BAHİS sütunundaki “3G” harfini işaretlemeniz gerekmektedir. 3''lü ganyanın her ayağında şans verdiğimiz at ya da atların numaralarını geniş sütunların ilkinden başlayarak işaretleyeceğiz.')
SET IDENTITY_INSERT [dbo].[BahisTipleri] OFF
SET IDENTITY_INSERT [dbo].[Hipodrom] ON 

INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (1, N'TJK Şanlıurfa Hipodromu', 63, 1, 3, 3)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (2, N'TJK Adana Hipodromu', 1, 1, 2, 2)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (3, N'TJK Kocaeli Kartepe Hipodromu', 41, 1, 3, 3)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (4, N'TJK Bursa Osmangazi Hipodromu', 16, 1, 3, 3)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (5, N'TJK 75. Yıl Ankara Hipodromu', 6, 1, 3, 3)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (6, N'TJK Veliefendi Hipodromu', 34, 1, 3, 3)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (7, N'TJK Elazığ Hipodromu', 23, 1, 2, 2)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (8, N'TJK Şirinyer Hipodromu', 35, 1, 3, 3)
INSERT [dbo].[Hipodrom] ([HipodromID], [HipodromAdi], [SehirID], [IlceID], [CimPistSayisi], [KumPistSayisi]) VALUES (9, N'TJK Diyarbakır Hipodromu', 21, 1, 3, 3)
SET IDENTITY_INSERT [dbo].[Hipodrom] OFF
ALTER TABLE [dbo].[Bulten]  WITH CHECK ADD  CONSTRAINT [FK_Bulten_AtBilgisi] FOREIGN KEY([AtID])
REFERENCES [dbo].[AtBilgisi] ([AtID])
GO
ALTER TABLE [dbo].[Bulten] CHECK CONSTRAINT [FK_Bulten_AtBilgisi]
GO
ALTER TABLE [dbo].[Bulten]  WITH CHECK ADD  CONSTRAINT [FK_Bulten_Hipodrom] FOREIGN KEY([HipodromID])
REFERENCES [dbo].[Hipodrom] ([HipodromID])
GO
ALTER TABLE [dbo].[Bulten] CHECK CONSTRAINT [FK_Bulten_Hipodrom]
GO
ALTER TABLE [dbo].[Kupon]  WITH CHECK ADD  CONSTRAINT [FK_Kupon_BahisTipleri] FOREIGN KEY([BahisTipiID])
REFERENCES [dbo].[BahisTipleri] ([BahisTipiID])
GO
ALTER TABLE [dbo].[Kupon] CHECK CONSTRAINT [FK_Kupon_BahisTipleri]
GO
ALTER TABLE [dbo].[Kupon]  WITH CHECK ADD  CONSTRAINT [FK_Kupon_Hipodrom] FOREIGN KEY([HipodromID])
REFERENCES [dbo].[Hipodrom] ([HipodromID])
GO
ALTER TABLE [dbo].[Kupon] CHECK CONSTRAINT [FK_Kupon_Hipodrom]
GO
ALTER TABLE [dbo].[Sonuc]  WITH CHECK ADD  CONSTRAINT [FK_Sonuc_AtBilgisi] FOREIGN KEY([AtID])
REFERENCES [dbo].[AtBilgisi] ([AtID])
GO
ALTER TABLE [dbo].[Sonuc] CHECK CONSTRAINT [FK_Sonuc_AtBilgisi]
GO
USE [master]
GO
ALTER DATABASE [AtBahis] SET  READ_WRITE 
GO
