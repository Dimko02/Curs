USE [master]
GO
/****** Object:  Database [curs]    Script Date: 22.05.2019 8:30:49 ******/
CREATE DATABASE [curs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'curs', FILENAME = N'D:\sql2\MSSQL14.MSSQLSERVER1\MSSQL\DATA\curs.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'curs_log', FILENAME = N'D:\sql2\MSSQL14.MSSQLSERVER1\MSSQL\DATA\curs_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [curs] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [curs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [curs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [curs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [curs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [curs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [curs] SET ARITHABORT OFF 
GO
ALTER DATABASE [curs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [curs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [curs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [curs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [curs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [curs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [curs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [curs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [curs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [curs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [curs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [curs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [curs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [curs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [curs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [curs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [curs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [curs] SET RECOVERY FULL 
GO
ALTER DATABASE [curs] SET  MULTI_USER 
GO
ALTER DATABASE [curs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [curs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [curs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [curs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [curs] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'curs', N'ON'
GO
ALTER DATABASE [curs] SET QUERY_STORE = OFF
GO
USE [curs]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 22.05.2019 8:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[CodeClient] [int] NOT NULL,
	[Title] [varchar](40) NULL,
	[AddressTo] [varchar](30) NULL,
	[Post] [varchar](30) NULL,
	[Address] [varchar](60) NULL,
	[City] [varchar](15) NULL,
	[IIndex] [varchar](10) NULL,
	[Country] [varchar](10) NULL,
	[Telephone] [varchar](24) NULL,
	[Fax] [varchar](24) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[CodeClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goods]    Script Date: 22.05.2019 8:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods](
	[CodeGoods] [int] NOT NULL,
	[Mark] [varchar](40) NULL,
	[Price] [numeric](10, 3) NULL,
	[InWarehouse] [int] NULL,
	[Expected] [int] NULL,
	[MinimalStock] [int] NULL,
	[DeliveriesStopped] [varchar](3) NULL,
 CONSTRAINT [PK_Goods] PRIMARY KEY CLUSTERED 
(
	[CodeGoods] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 22.05.2019 8:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[CodeSuppliers] [int] NOT NULL,
	[Title] [varchar](40) NULL,
	[AddressTo] [varchar](30) NULL,
	[Post] [varchar](30) NULL,
	[Address] [varchar](60) NULL,
	[City] [varchar](15) NULL,
	[IIndex] [varchar](10) NULL,
	[Country] [varchar](20) NULL,
	[Telephone] [varchar](24) NULL,
	[Fax] [varchar](24) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[CodeSuppliers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22.05.2019 8:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[CodeOrders] [int] NOT NULL,
	[CodeClient] [int] NOT NULL,
	[CodeGoods] [int] NOT NULL,
	[CodeSuppliers] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[CodeOrders] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Order]    Script Date: 22.05.2019 8:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Order]
AS
SELECT       dbo.Orders.CodeOrders, dbo.Clients.Title AS TitleClient, dbo.Goods.Mark, dbo.Goods.Price, dbo.Suppliers.Title AS TitleSupplier
FROM            dbo.Clients INNER JOIN
                         dbo.Orders ON dbo.Clients.CodeClient = dbo.Orders.CodeClient INNER JOIN
                         dbo.Goods ON dbo.Orders.CodeGoods = dbo.Goods.CodeGoods INNER JOIN
                         dbo.Suppliers ON dbo.Orders.CodeSuppliers = dbo.Suppliers.CodeSuppliers
GO
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (1, N'Ovihkc', N'Андрей Ханавин', N'Координатор', N'ул. Бергуса, 8', N'Лулео', N'S-958 22', N'Швеция', N'0921-12 34 65', N'0921-12')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (2, N'Белкантон', N'Андрей Карпухин', N'Главный менеджер', N'ул. Гарсиа, 9993', N'Мехико', N'05022', N'Мексика', N'(5) 555-3392', N'(5) 5557293')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (3, N'Дамодара-Сервис', N'Лидия Кулаева', N'Совладелец', N'ул. Эдальго, 29', N'Берн', N'3012', N'Швейцария', N'0452-076545', NULL)
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (4, N'E-Life', N'Роланд Мендель', N'Менеджер по продажам', N'Vi. Кировская. 6', N'Трасс', N'8010', N'Авария', N'7675-3425', N'7675-3426')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (5, N'IMC Computers', N'Мария Ларсон', N'Совладелец', N'ул. Ксргатая. 24', N'Nрекке', N'S-844 67', N'Швеция', N'0695-34 67 2', NULL)
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (6, N'Верса', N'Питер Франкен', N'Главный менеджер', N'Берлинская пл., 43', N'Мюнхен', N'80805', N'Термания', N'089-0877310', N'089-087745')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (7, N'Comtris', N'Мария Хосе', N'Совладелец', N'ул. Палое. 5S', N'Каракас', N'108', N'Венесуэла', N'(2) 283-295 Г', N'(2) 283-3397')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (8, N'Net Line', N'Марио Ионтес', N'Бухгалтер', N'ул. Ракко, 67', N'Риоде-Жанейро', N'05454-876', N'Бразилия', N'(21) 555-009Г', N'(21) 555-8765')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (9, N'NTTs', N'Карлос Хемандос', N'11релсгавигель', N'ул. Карлос, 22', N'Сан-Кристобаль', N'5022', N'Венесуэла', N'(5) 555-1340', N'(5) 555-1948')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (10, N'Интеллекте', N'Патрисия Кемма', N'Ученик продавца', N'Джонстоун шоссе, 8', N'Корк', NULL, N'Ирландия', N'2967 542', N'2967 3333')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (11, N'ZS', N'Максим Анищенко', N'Бухгалтер', N'Бодиварская, 52', N'Bаркисимею', N'3508', N'Венесуэла', N'(9) 331-6954', N'(9) 331-7256')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (12, N'Медиа-софт', N'Джовани Ровелли', N'Главный .менеджер', N'ул. Людовика. 22', N'Бергамо', N'24100', N'Италия', N'035-640230', N'035-640231')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (13, N'Эликон-М', N'Александр Боровик-', N'Представитель', N'ул. Беринговая. 2743', N'Анкоридж', N'99508', N'США', N'(907) 555-7584', N'(907) 555- 2880')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (14, N'Stop', N'Игнат Довидовский', N'Бухгалтер', N'Тачерстрасе, 10', N'Ккжевальд', N'01307', N'Германия', N'0372-035 188', NULL)
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (15, N'Соло', N'Андрей Савельев', N'Ученик продавца', N'ул. Провинциальная, 124', N'Реджио-Эмилио', N'42100', N'Италия', N'0522556721', N'0522- 556722')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (16, N'Olymp', N'Юрий Макаров', N'Бухгалтер', N'ул. Виа, Г', N'Мадрид', N'28001', N'Испания', N'(91) 745 6200', N'(91) 745 6210')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (17, N'Oki', N'Александр Гронский', N'Представитель', N'ул. Кастро. 414', N'Сан-Паулс', N'05634-030', N'Бразилия', N'(11) 555-2167', N'(11) 555-2168')
INSERT [dbo].[Clients] ([CodeClient], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (18, N'Ichi', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (1, N'Genius SP-G06', CAST(9.000 AS Numeric(10, 3)), 15, 10, 8, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (2, N'Наушники Dialog М-750НУ+микрофон', CAST(9.000 AS Numeric(10, 3)), 15, 10, 8, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (3, N'ATX 2.03 300W', CAST(35.000 AS Numeric(10, 3)), 15, 5, 10, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (4, N'ATX Midi Tower 350W', CAST(55.000 AS Numeric(10, 3)), 5, 8, 21, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (5, N'Блок питания ATX 235/250/300W', CAST(14.000 AS Numeric(10, 3)), 20, 10, 5, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (6, N'HDD Maxtor 30Gb', CAST(69.000 AS Numeric(10, 3)), 10, 2, 8, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (7, N'HDD Seagate Baracuda 4 40Gb', CAST(87.000 AS Numeric(10, 3)), 8, 4, 12, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (8, N'HDD IBM 60Gb', CAST(9.000 AS Numeric(10, 3)), 5, 6, 8, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (9, N'T E A C', CAST(9.000 AS Numeric(10, 3)), 15, 10, 10, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (11, N'Samsung 52x', CAST(23.000 AS Numeric(10, 3)), 5, 5, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (12, N'TEAC 52x CD-522E', CAST(42.000 AS Numeric(10, 3)), 7, NULL, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (13, N'CD-RW/ROM TEAC', CAST(42.000 AS Numeric(10, 3)), 7, NULL, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (14, N'Verbatim', CAST(0.280 AS Numeric(10, 3)), 300, 100, 50, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (15, N'CD-R TDK 12x', CAST(0.620 AS Numeric(10, 3)), 200, 100, 50, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (16, N'ACORP 56EMS. USB', CAST(40.000 AS Numeric(10, 3)), 5, NULL, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (17, N'HUB 10/t00Mbit', CAST(32.000 AS Numeric(10, 3)), 10, 5, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (18, N'ACORP 56EMS. USB', CAST(40.000 AS Numeric(10, 3)), 5, NULL, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (19, N'3COM SOHO 100TX', CAST(22.000 AS Numeric(10, 3)), 15, 5, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (20, N'HUB 10/t00Mbit', CAST(32.000 AS Numeric(10, 3)), 10, 5, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (21, N'Switch 10/100Mbit', CAST(32.000 AS Numeric(10, 3)), 10, 10, 5, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (22, N'Кабель "витая пара" UTP cat.5', CAST(0.180 AS Numeric(10, 3)), 100, 100, 20, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (23, N'Canon LBP810', CAST(185.000 AS Numeric(10, 3)), 39, 5, 7, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (24, N'Accorp VlA266i815D', CAST(61.000 AS Numeric(10, 3)), 29, NULL, 10, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (25, N'TNT2 M64 32Mb', CAST(28.000 AS Numeric(10, 3)), NULL, NULL, NULL, N'YES')
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (26, N'DDR 128Mb', CAST(38.000 AS Numeric(10, 3)), 34, NULL, 25, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (27, N'Samsung 550B', CAST(150.000 AS Numeric(10, 3)), 20, NULL, NULL, N'YES')
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (28, N'Gigabyte GA-60XTA', CAST(64.000 AS Numeric(10, 3)), 76, NULL, 30, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (29, N'Creative Labs SB Life', CAST(9.000 AS Numeric(10, 3)), 26, NULL, NULL, N'YES')
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (30, N'Mouse Logitech B69', CAST(15.000 AS Numeric(10, 3)), 10, NULL, 15, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (31, N'Epson EPL520', CAST(90.000 AS Numeric(10, 3)), 76, NULL, NULL, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (32, N'Celeron 1000MHz', CAST(51.000 AS Numeric(10, 3)), 26, NULL, 15, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (33, N'Intel P4 1700MHz Box', CAST(137.000 AS Numeric(10, 3)), NULL, 70, 20, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (34, N'AMD Athlon 1333MHz', CAST(53.000 AS Numeric(10, 3)), 40, 9, 25, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (35, N'Samtron 76E', CAST(180.000 AS Numeric(10, 3)), 11, NULL, 15, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (36, N'Коврики пластиковые', CAST(0.500 AS Numeric(10, 3)), 112, NULL, 20, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (37, N'Chicony PS/2 820 2981', CAST(6.000 AS Numeric(10, 3)), 23, NULL, 30, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (38, N'SDRAM 128Mb', CAST(19.000 AS Numeric(10, 3)), 26, NULL, NULL, N'YES')
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (39, N'Asus A7S333', CAST(86.000 AS Numeric(10, 3)), 35, NULL, 30, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (40, N'Creative Labs SB Life 5.1+FM radio', CAST(39.000 AS Numeric(10, 3)), 10, NULL, 10, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (41, N'GeForce 2 MX 400 64Mb', CAST(36.000 AS Numeric(10, 3)), 10, 15, 24, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (42, N'DIMM PC 133 128Mb Micron', CAST(15.000 AS Numeric(10, 3)), 21, 10, 30, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (43, N'AND Duron 1000MHz', CAST(36.000 AS Numeric(10, 3)), 22, 10, 10, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (44, N'Lexmark Z35', CAST(62.000 AS Numeric(10, 3)), 12, NULL, 25, NULL)
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (45, N'TV-tuner Aver MediaTV Studio', CAST(75.000 AS Numeric(10, 3)), 29, NULL, NULL, N'YES')
INSERT [dbo].[Goods] ([CodeGoods], [Mark], [Price], [InWarehouse], [Expected], [MinimalStock], [DeliveriesStopped]) VALUES (46, N'sad', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([CodeOrders], [CodeClient], [CodeGoods], [CodeSuppliers]) VALUES (1, 3, 4, 13)
INSERT [dbo].[Orders] ([CodeOrders], [CodeClient], [CodeGoods], [CodeSuppliers]) VALUES (2, 6, 12, 1)
INSERT [dbo].[Orders] ([CodeOrders], [CodeClient], [CodeGoods], [CodeSuppliers]) VALUES (3, 5, 5, 4)
INSERT [dbo].[Orders] ([CodeOrders], [CodeClient], [CodeGoods], [CodeSuppliers]) VALUES (4, 9, 11, 3)
INSERT [dbo].[Orders] ([CodeOrders], [CodeClient], [CodeGoods], [CodeSuppliers]) VALUES (5, 10, 2, 11)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (1, N'EtelSoft', N'Андрей Герасимов', N'Представитель', N'707 Оксфорд', N'Анн-Арбор', N'48104', N'США', N'(313) 555-5753', N'(313) 555-3349')
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (2, N'Iven', N'Антон Сеткин', N'Главный менеджер', N'9-8 Секимаи', N'Токио', N'100', N'Япония', N'(03) 3555-5011', N'(313) 555-3349')
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (3, N'SV-Trading', N'Валерия Евенкова', N'Директор', N'92 Сетсако', N'Осака', N'545', N'Япония', N'(06) 431 -7877', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (4, N'CD-Life', N'Наталия Отока', N'Главный менеджер', N'74 ул. Роз', N'Мельбурн', N'3058', N'Австралия', N'(03) 444-2343', N'(03) 444-6588')
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (5, N'Stepfor', N'Павел Фокин', N'Представитель', N'ул. Королевского пути, 29', N'Манчестер', N'М14 GSD', N'Великобритания', N'(161) 555-4448', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (6, N'B.S.T.Group', N'Евгений Шаматранов', N'Продавец', N'Каладоган 13', N'Тетеборг', N'S-345 67', N'Швеция', N'031-987 65 43', N'031-987 65 9')
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (7, N'Biocom', N'Вячеслав Путеев', N'Главный менеджер', N'ул. Американская 12.890', N'Сан-Паулу', N'5442', N'Бразилия', N'(11) 555-4640', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (8, N'DAAS', N'Петр Моргунов', N'Менеджер по продажам', N'Тверская 5', N'Москва', N'101785', N'Россия', N'(095)998-4510', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (9, N'Конструктив', N'Федор Куполов', N'Представитель', N'ул. Данте 75', N'Равенна', N'48100', N'Италия', N'(0544) 60323', N'(0544) 60603')
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (10, N'Виола-Сервис', N'Виктор Кухарчук', N'Главный менеджер', N'ул. Хатлевеген, 5', N'Сандвикен', N'1320', N'Норвегия', N'(0)2-953010', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (11, N'Гвин-Медиа', N'Артем Столяров', N'Местный представитель', N'3400-8 Авеню', N'Бенд', N'97101', N'США', N'(503) 555-993', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (12, N'Senter', N'Александр Осипенко', N'Представитель', N'ул. Бровайдер, 231', N'Стокгольм', N'S-I23 45', N'Швеция', N'08-12.3 45 67', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (13, N'Техинтерторг', N'Дарья Борщева', N'Агент по продажам', N'Частный Департамент', N'Бостон', N'02134', N'США', N'(617) 555-3267', N'(617) 555-3389')
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (14, N'Ситипринт', N'Инна Риякевич', N'Совладелец', N'ул. Серашун. 471', N'Сингапур', N'0512', N'Сингапур', N'555-8787', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (15, N'Юнити Сервис', N'Алексей Жолнсрович', N'Менеджер по продажам', N'ул. Лингбиеилд', N'Лингби', N'2800', N'Дания', N'43844108', N'43844115')
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (16, N'ПК Сервис', N'Юрий Бартошек', N'Менеджер по продажам', N'ул. Войрон, 22', N'Монсо', N'71300', N'Франция', N'85-57-00-07', NULL)
INSERT [dbo].[Suppliers] ([CodeSuppliers], [Title], [AddressTo], [Post], [Address], [City], [IIndex], [Country], [Telephone], [Fax]) VALUES (17, N'Астлайн', N'Руслан Сидкж', N'Бухгалтер', N'ул. Чессер, 148', N'Оге-Хиацинте', N'J2S 7S8', N'Канада', N'(514) 555-2955', N'(514) 555-292 ')
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Goods] FOREIGN KEY([CodeGoods])
REFERENCES [dbo].[Goods] ([CodeGoods])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Goods]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Suppliers] FOREIGN KEY([CodeSuppliers])
REFERENCES [dbo].[Suppliers] ([CodeSuppliers])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Suppliers]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[25] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Clients"
            Begin Extent = 
               Top = 0
               Left = 36
               Bottom = 130
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Goods"
            Begin Extent = 
               Top = 104
               Left = 232
               Bottom = 234
               Right = 415
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Orders_1"
            Begin Extent = 
               Top = 0
               Left = 452
               Bottom = 130
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Suppliers"
            Begin Extent = 
               Top = 98
               Left = 706
               Bottom = 228
               Right = 880
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Order'
GO
USE [master]
GO
ALTER DATABASE [curs] SET  READ_WRITE 
GO
