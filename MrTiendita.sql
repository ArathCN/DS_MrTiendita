USE [TIENDITA2]
GO
ALTER TABLE [dbo].[PEDIDOS] DROP CONSTRAINT [FK__PEDIDOS__clave_c__398D8EEE]
GO
ALTER TABLE [dbo].[PEDIDOS] DROP CONSTRAINT [FK__PEDIDOS__clave_a__3A81B327]
GO
/****** Object:  View [dbo].[Vista8]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[Vista8]
GO
/****** Object:  View [dbo].[vista7]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[vista7]
GO
/****** Object:  View [dbo].[VistaE]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[VistaE]
GO
/****** Object:  View [dbo].[vista6]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[vista6]
GO
/****** Object:  View [dbo].[vista5]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[vista5]
GO
/****** Object:  View [dbo].[vista4]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[vista4]
GO
/****** Object:  View [dbo].[vista3]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[vista3]
GO
/****** Object:  View [dbo].[vista2]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[vista2]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP TABLE [dbo].[ARTICULOS]
GO
/****** Object:  View [dbo].[vista1]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP VIEW [dbo].[vista1]
GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP TABLE [dbo].[PEDIDOS]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP TABLE [dbo].[CLIENTES]
GO
USE [master]
GO
/****** Object:  Database [TIENDITA2]    Script Date: 09/11/2021 12:08:37 a. m. ******/
DROP DATABASE [TIENDITA2]
GO
/****** Object:  Database [TIENDITA2]    Script Date: 09/11/2021 12:08:37 a. m. ******/
CREATE DATABASE [TIENDITA2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TIENDITA2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TIENDITA2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TIENDITA2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TIENDITA2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TIENDITA2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TIENDITA2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TIENDITA2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TIENDITA2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TIENDITA2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TIENDITA2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TIENDITA2] SET ARITHABORT OFF 
GO
ALTER DATABASE [TIENDITA2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TIENDITA2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TIENDITA2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TIENDITA2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TIENDITA2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TIENDITA2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TIENDITA2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TIENDITA2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TIENDITA2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TIENDITA2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TIENDITA2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TIENDITA2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TIENDITA2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TIENDITA2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TIENDITA2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TIENDITA2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TIENDITA2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TIENDITA2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TIENDITA2] SET  MULTI_USER 
GO
ALTER DATABASE [TIENDITA2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TIENDITA2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TIENDITA2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TIENDITA2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TIENDITA2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TIENDITA2] SET QUERY_STORE = OFF
GO
USE [TIENDITA2]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[clave_cliente] [int] NOT NULL,
	[nombre] [varchar](40) NULL,
	[direccion] [varchar](40) NULL,
	[telefono] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[clave_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS](
	[clave_cli] [int] NULL,
	[clave_art] [int] NULL,
	[cantidad] [int] NULL,
	[fecha] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vista1]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista1]
AS SELECT C.clave_cliente, C.nombre, P.fecha
FROM CLIENTES AS C
INNER JOIN PEDIDOS AS P ON C.clave_cliente = P.clave_cli
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[clave_art] [int] NOT NULL,
	[costo] [decimal](4, 2) NULL,
	[descripcion] [varchar](50) NULL,
	[marca] [varchar](15) NULL,
	[modelo] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[clave_art] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vista2]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista2]
AS SELECT C.clave_cliente, C.nombre, A.descripcion, A.costo, P.fecha, P.cantidad
FROM CLIENTES AS C
INNER JOIN PEDIDOS AS P ON C.clave_cliente = P.clave_cli
INNER JOIN ARTICULOS AS A ON P.clave_art = A.clave_art;
GO
/****** Object:  View [dbo].[vista3]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista3]
AS SELECT C.clave_cliente, C.nombre, P.fecha, C.telefono
FROM CLIENTES AS C
INNER JOIN PEDIDOS AS P ON C.clave_cliente = P.clave_cli WHERE C.clave_cliente != 1205;
GO
/****** Object:  View [dbo].[vista4]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista4]
AS SELECT C.clave_cliente, C.nombre, C.telefono, A.descripcion, A.costo, A.marca, P.fecha, P.cantidad
FROM CLIENTES AS C
INNER JOIN PEDIDOS AS P ON C.clave_cliente = P.clave_cli
INNER JOIN ARTICULOS AS A ON P.clave_art = A.clave_art WHERE P.fecha >= '2007/11/01' AND P.fecha <= '2007/12/10';
GO
/****** Object:  View [dbo].[vista5]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista5]
AS SELECT C.clave_cliente, C.nombre, C.telefono, A.descripcion, A.costo, A.marca, P.fecha, P.cantidad
FROM CLIENTES AS C
INNER JOIN PEDIDOS AS P ON C.clave_cliente = P.clave_cli
INNER JOIN ARTICULOS AS A ON P.clave_art = A.clave_art WHERE C.clave_cliente = 1200 AND P.fecha >= '2007/11/15' AND P.fecha <= '2007/12/15';
GO
/****** Object:  View [dbo].[vista6]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista6]
AS SELECT C.clave_cliente
FROM CLIENTES AS C
LEFT JOIN PEDIDOS AS P ON C.clave_cliente = P.clave_cli WHERE P.clave_cli IS NULL;
GO
/****** Object:  View [dbo].[VistaE]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaE] AS SELECT clave_art,descripcion,costo FROM ARTICULOS WHERE NOT EXISTS(SELECT * FROM PEDIDOS WHERE ARTICULOS.clave_art=PEDIDOS.clave_art )
GO
/****** Object:  View [dbo].[vista7]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista7]
AS SELECT A.clave_art, A.descripcion, A.costo 
FROM ARTICULOS AS A
LEFT JOIN PEDIDOS AS P ON A.clave_art = P.clave_art WHERE P.clave_art IS NULL;
GO
/****** Object:  View [dbo].[Vista8]    Script Date: 09/11/2021 12:08:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista8] AS SELECT clave_cliente,nombre,descripcion,costo FROM PEDIDOS
INNER JOIN CLIENTES ON PEDIDOS.clave_cli=CLIENTES.clave_cliente
INNER JOIN ARTICULOS ON PEDIDOS.clave_art=ARTICULOS.clave_art
GO
INSERT [dbo].[ARTICULOS] ([clave_art], [costo], [descripcion], [marca], [modelo]) VALUES (728, CAST(15.25 AS Decimal(4, 2)), N'JERGA', N'3 HILOS', N'POLIESTER')
INSERT [dbo].[ARTICULOS] ([clave_art], [costo], [descripcion], [marca], [modelo]) VALUES (880, CAST(50.80 AS Decimal(4, 2)), N'TRAPEADOR', N'PATITO', N'HILO')
INSERT [dbo].[ARTICULOS] ([clave_art], [costo], [descripcion], [marca], [modelo]) VALUES (885, CAST(55.80 AS Decimal(4, 2)), N'SACUDIDOR', N'PATITO', N'TELA')
INSERT [dbo].[ARTICULOS] ([clave_art], [costo], [descripcion], [marca], [modelo]) VALUES (1002, CAST(32.20 AS Decimal(4, 2)), N'ESCOBA', N'PATITO', N'PALMA')
INSERT [dbo].[ARTICULOS] ([clave_art], [costo], [descripcion], [marca], [modelo]) VALUES (1005, CAST(28.50 AS Decimal(4, 2)), N'RECOGEDOR', N'PATITO', N'PLASTICO')
INSERT [dbo].[CLIENTES] ([clave_cliente], [nombre], [direccion], [telefono]) VALUES (1180, N'LUCERO RICO', N'REP. DE CUBA 325', N'22-11-75-78')
INSERT [dbo].[CLIENTES] ([clave_cliente], [nombre], [direccion], [telefono]) VALUES (1185, N'MARIA LOPEZ', N'MEXICO 3325', N'22-11-75-78')
INSERT [dbo].[CLIENTES] ([clave_cliente], [nombre], [direccion], [telefono]) VALUES (1200, N'AGAPITO BUELNA', N'VILLAHERMOSA 5', N'22-84-35-60')
INSERT [dbo].[CLIENTES] ([clave_cliente], [nombre], [direccion], [telefono]) VALUES (1205, N'MARIO GOMEZ', N'TABASCO 305', N'22-84-35-60')
INSERT [dbo].[CLIENTES] ([clave_cliente], [nombre], [direccion], [telefono]) VALUES (1300, N'PABLO RUIZ', N'ALAMOS 205', N'22-11-75-78')
INSERT [dbo].[PEDIDOS] ([clave_cli], [clave_art], [cantidad], [fecha]) VALUES (1200, 1002, 5, CAST(N'2007-12-01' AS Date))
INSERT [dbo].[PEDIDOS] ([clave_cli], [clave_art], [cantidad], [fecha]) VALUES (1200, 880, 5, CAST(N'2007-12-01' AS Date))
INSERT [dbo].[PEDIDOS] ([clave_cli], [clave_art], [cantidad], [fecha]) VALUES (1180, 1002, 5, CAST(N'2007-12-02' AS Date))
INSERT [dbo].[PEDIDOS] ([clave_cli], [clave_art], [cantidad], [fecha]) VALUES (1180, 880, 5, CAST(N'2007-12-02' AS Date))
INSERT [dbo].[PEDIDOS] ([clave_cli], [clave_art], [cantidad], [fecha]) VALUES (1205, 1005, 15, CAST(N'2007-12-08' AS Date))
INSERT [dbo].[PEDIDOS] ([clave_cli], [clave_art], [cantidad], [fecha]) VALUES (1185, 885, 11, CAST(N'2007-12-20' AS Date))
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD FOREIGN KEY([clave_art])
REFERENCES [dbo].[ARTICULOS] ([clave_art])
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD FOREIGN KEY([clave_cli])
REFERENCES [dbo].[CLIENTES] ([clave_cliente])
GO
USE [master]
GO
ALTER DATABASE [TIENDITA2] SET  READ_WRITE 
GO
