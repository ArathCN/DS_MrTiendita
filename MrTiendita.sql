USE [master]
GO
/****** Object:  Database [MrTiendita]    Script Date: 03/01/2022 02:56:58 p. m. ******/
CREATE DATABASE [MrTiendita]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mr.Tiendita', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MrTiendita.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mr.Tiendita_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MrTiendita_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MrTiendita] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MrTiendita].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MrTiendita] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MrTiendita] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MrTiendita] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MrTiendita] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MrTiendita] SET ARITHABORT OFF 
GO
ALTER DATABASE [MrTiendita] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MrTiendita] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MrTiendita] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MrTiendita] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MrTiendita] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MrTiendita] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MrTiendita] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MrTiendita] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MrTiendita] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MrTiendita] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MrTiendita] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MrTiendita] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MrTiendita] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MrTiendita] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MrTiendita] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MrTiendita] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MrTiendita] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MrTiendita] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MrTiendita] SET  MULTI_USER 
GO
ALTER DATABASE [MrTiendita] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MrTiendita] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MrTiendita] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MrTiendita] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MrTiendita] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MrTiendita] SET QUERY_STORE = OFF
GO
USE [MrTiendita]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 03/01/2022 02:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[atributo] [varchar](100) NOT NULL,
	[valor] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED 
(
	[atributo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 03/01/2022 02:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[ap_materno] [varchar](60) NOT NULL,
	[ap_paterno] [varchar](60) NOT NULL,
	[telefono] [bigint] NOT NULL,
	[sueldo] [decimal](10, 2) NOT NULL,
	[tipo_empleado] [varchar](50) NOT NULL,
	[clave] [varchar](255) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada_almacen]    Script Date: 03/01/2022 02:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada_almacen](
	[id_entrada] [int] IDENTITY(1,1) NOT NULL,
	[codigo_barra] [bigint] NOT NULL,
	[fecha] [datetime] NULL,
	[cantidad] [decimal](10, 3) NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
	[id_proveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimientos]    Script Date: 03/01/2022 02:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos](
	[id_movimiento] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
	[caja] [decimal](10, 2) NOT NULL,
	[concepto] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 03/01/2022 02:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[codigo_barra] [bigint] NOT NULL,
	[descripcion] [varchar](120) NULL,
	[precio_venta] [decimal](10, 2) NOT NULL,
	[precio_compra] [decimal](10, 2) NOT NULL,
	[cantidad_actual] [decimal](10, 3) NOT NULL,
	[medida] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_barra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 03/01/2022 02:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[telefono] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 03/01/2022 02:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[codigo_barra] [bigint] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[metodo_pago] [varchar](60) NOT NULL,
	[fecha] [datetime] NULL,
	[cantidad] [decimal](10, 2) NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Caja] ([atributo], [valor]) VALUES (N'Total', N'183.9')
INSERT [dbo].[Caja] ([atributo], [valor]) VALUES (N'UltimoCorte', N'2021-11-08 09:00:00')
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario]) VALUES (16, N'admin', N'admin', N'admin', 9999999999, CAST(9999.99 AS Decimal(10, 2)), N'Encargado', N'$2a$10$khbJCyrVsEFIzCDuKsqxauDlutfb1qBR9d1uPXmtaey9TalqP9iX6', N'admin')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[Entrada_almacen] ON 

INSERT [dbo].[Entrada_almacen] ([id_entrada], [codigo_barra], [fecha], [cantidad], [importe], [id_proveedor]) VALUES (1022, 1112223334445, CAST(N'2022-01-01T12:00:00.000' AS DateTime), CAST(1.000 AS Decimal(10, 3)), CAST(12.55 AS Decimal(10, 2)), 1009)
SET IDENTITY_INSERT [dbo].[Entrada_almacen] OFF
SET IDENTITY_INSERT [dbo].[Movimientos] ON 

INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (35, N'Venta', CAST(N'2022-01-02T22:59:57.010' AS DateTime), CAST(60.90 AS Decimal(10, 2)), CAST(183.90 AS Decimal(10, 2)), N'Venta')
SET IDENTITY_INSERT [dbo].[Movimientos] OFF
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1112223334445, N'Sabritas Doritos Nachos 65 Gr.', CAST(15.00 AS Decimal(10, 2)), CAST(12.55 AS Decimal(10, 2)), CAST(12.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1213141516178, N'Coca Cola 3L', CAST(45.90 AS Decimal(10, 2)), CAST(28.45 AS Decimal(10, 2)), CAST(9.000 AS Decimal(10, 3)), 0)
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (1008, N'Coca Cola SA de CV', 6621293845)
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (1009, N'Sabritas SA de CV', 6620143732)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (26, 1213141516178, 16, N'Efectivo', CAST(N'2022-01-02T22:59:56.873' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(60.90 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (27, 1112223334445, 16, N'Efectivo', CAST(N'2022-01-02T22:59:57.007' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(60.90 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Venta] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Empleado__9AFF8FC65D77A33B]    Script Date: 03/01/2022 02:57:02 p. m. ******/
ALTER TABLE [dbo].[Empleado] ADD UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Entrada_almacen]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_almacen_Producto] FOREIGN KEY([codigo_barra])
REFERENCES [dbo].[Producto] ([codigo_barra])
GO
ALTER TABLE [dbo].[Entrada_almacen] CHECK CONSTRAINT [FK_Entrada_almacen_Producto]
GO
ALTER TABLE [dbo].[Entrada_almacen]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_almacen_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[Entrada_almacen] CHECK CONSTRAINT [FK_Entrada_almacen_Proveedor]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleado]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([codigo_barra])
REFERENCES [dbo].[Producto] ([codigo_barra])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto]
GO
USE [master]
GO
ALTER DATABASE [MrTiendita] SET  READ_WRITE 
GO
