USE [master]
GO
/****** Object:  Database [MrTiendita]    Script Date: 06/12/2021 10:30:23 p. m. ******/
CREATE DATABASE [MrTiendita]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mr.Tiendita', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Mr.Tiendita.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mr.Tiendita_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Mr.Tiendita_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Caja]    Script Date: 06/12/2021 10:30:24 p. m. ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 06/12/2021 10:30:24 p. m. ******/
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
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada_almacen]    Script Date: 06/12/2021 10:30:24 p. m. ******/
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
/****** Object:  Table [dbo].[Movimientos]    Script Date: 06/12/2021 10:30:24 p. m. ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 06/12/2021 10:30:24 p. m. ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 06/12/2021 10:30:24 p. m. ******/
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
/****** Object:  Table [dbo].[Venta]    Script Date: 06/12/2021 10:30:24 p. m. ******/
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
INSERT [dbo].[Caja] ([atributo], [valor]) VALUES (N'Total', N'950.5')
INSERT [dbo].[Caja] ([atributo], [valor]) VALUES (N'UltimoCorte', N'2021-11-08 09:00:00')
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave]) VALUES (9, N'Sebastian', N'Cañedo', N'Nuñez', 66, CAST(10.00 AS Decimal(10, 2)), N'Cajero', N'29091909')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[Entrada_almacen] ON 

INSERT [dbo].[Entrada_almacen] ([id_entrada], [codigo_barra], [fecha], [cantidad], [importe], [id_proveedor]) VALUES (1012, 1211, CAST(N'2021-12-06T18:32:26.000' AS DateTime), CAST(4.000 AS Decimal(10, 3)), CAST(35.80 AS Decimal(10, 2)), 2)
INSERT [dbo].[Entrada_almacen] ([id_entrada], [codigo_barra], [fecha], [cantidad], [importe], [id_proveedor]) VALUES (1013, 1216, CAST(N'2021-12-06T20:02:02.000' AS DateTime), CAST(20.000 AS Decimal(10, 3)), CAST(200.00 AS Decimal(10, 2)), 1003)
INSERT [dbo].[Entrada_almacen] ([id_entrada], [codigo_barra], [fecha], [cantidad], [importe], [id_proveedor]) VALUES (1014, 1214, CAST(N'2021-12-06T20:02:58.000' AS DateTime), CAST(2.000 AS Decimal(10, 3)), CAST(19.80 AS Decimal(10, 2)), 1004)
SET IDENTITY_INSERT [dbo].[Entrada_almacen] OFF
SET IDENTITY_INSERT [dbo].[Movimientos] ON 

INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (18, N'Entrada', CAST(N'2021-12-06T19:48:28.980' AS DateTime), CAST(0.70 AS Decimal(10, 2)), CAST(1582.00 AS Decimal(10, 2)), N'

Prueba 1')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (19, N'Entrada', CAST(N'2021-12-06T19:49:15.043' AS DateTime), CAST(8.00 AS Decimal(10, 2)), CAST(1590.00 AS Decimal(10, 2)), N'
Prueba 2
')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (20, N'Entrada', CAST(N'2021-12-06T19:49:46.440' AS DateTime), CAST(90.00 AS Decimal(10, 2)), CAST(1680.00 AS Decimal(10, 2)), N'
Prueba 3')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (21, N'Salida', CAST(N'2021-12-06T19:50:56.793' AS DateTime), CAST(680.00 AS Decimal(10, 2)), CAST(1000.00 AS Decimal(10, 2)), N'

Prueba 4')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (22, N'Entrada', CAST(N'2021-12-06T19:51:21.157' AS DateTime), CAST(50.00 AS Decimal(10, 2)), CAST(1050.00 AS Decimal(10, 2)), N'

Prueba 5')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (23, N'Salida', CAST(N'2021-12-06T19:52:31.920' AS DateTime), CAST(100.00 AS Decimal(10, 2)), CAST(950.00 AS Decimal(10, 2)), N'

Porque sí')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (24, N'Salida', CAST(N'2021-12-06T19:54:09.950' AS DateTime), CAST(12.00 AS Decimal(10, 2)), CAST(938.00 AS Decimal(10, 2)), N'

as')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (25, N'Venta', CAST(N'2021-12-06T20:01:22.680' AS DateTime), CAST(12.50 AS Decimal(10, 2)), CAST(950.50 AS Decimal(10, 2)), N'Venta')
SET IDENTITY_INSERT [dbo].[Movimientos] OFF
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1211, N'Pepsi', CAST(12.50 AS Decimal(10, 2)), CAST(8.95 AS Decimal(10, 2)), CAST(29.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1213, N'Pan con quesito.', CAST(15.50 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)), CAST(17.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1214, N'Sabritas Doritos nachos.', CAST(14.90 AS Decimal(10, 2)), CAST(9.90 AS Decimal(10, 2)), CAST(23.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1215, N'Leche entera Yaqui 1L', CAST(23.00 AS Decimal(10, 2)), CAST(19.00 AS Decimal(10, 2)), CAST(19.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1216, N'Cloro 1L', CAST(16.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(19.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_venta], [precio_compra], [cantidad_actual], [medida]) VALUES (1220, N'Frijol Pinto', CAST(32.80 AS Decimal(10, 2)), CAST(23.30 AS Decimal(10, 2)), CAST(27.520 AS Decimal(10, 3)), 1)
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (2, N'Coca Cola SA de CV', 6623596075)
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (1003, N'Distribuidora Bimbo', 6621849384)
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (1004, N'Grupo Gamesa', 6628374059)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (1, 1211, 9, N'Efectivo', CAST(N'2021-11-08T22:49:50.463' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(28.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (2, 1213, 9, N'Efectivo', CAST(N'2021-11-08T22:49:50.660' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(28.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (3, 1211, 9, N'Efectivo', CAST(N'2021-11-08T23:15:01.403' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(103.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (4, 1215, 9, N'Efectivo', CAST(N'2021-11-08T23:15:01.500' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(103.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (5, 1216, 9, N'Efectivo', CAST(N'2021-11-08T23:15:01.503' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(103.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (6, 1215, 9, N'Efectivo', CAST(N'2021-11-08T23:26:15.943' AS DateTime), CAST(4.00 AS Decimal(10, 2)), CAST(168.75 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (7, 1220, 9, N'Efectivo', CAST(N'2021-11-08T23:26:15.990' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(168.75 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (8, 1214, 9, N'Efectivo', CAST(N'2021-11-08T23:28:58.683' AS DateTime), CAST(4.00 AS Decimal(10, 2)), CAST(110.85 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (9, 1220, 9, N'Efectivo', CAST(N'2021-11-08T23:28:58.687' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(110.85 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (10, 1213, 9, N'Efectivo', CAST(N'2021-11-08T23:28:58.687' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(110.85 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (11, 1213, 9, N'Efectivo', CAST(N'2021-11-08T23:31:05.320' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(15.50 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (12, 1211, 9, N'Efectivo', CAST(N'2021-11-09T00:37:42.687' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(12.50 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (13, 1211, 9, N'Efectivo', CAST(N'2021-11-09T01:41:15.870' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(25.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (14, 1211, 9, N'Efectivo', CAST(N'2021-12-04T23:21:51.263' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(43.50 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (15, 1213, 9, N'Efectivo', CAST(N'2021-12-04T23:21:51.277' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(43.50 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (16, 1211, 9, N'Efectivo', CAST(N'2021-12-06T15:54:31.360' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(57.80 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (17, 1220, 9, N'Efectivo', CAST(N'2021-12-06T15:54:31.367' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(57.80 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (18, 1211, 9, N'Efectivo', CAST(N'2021-12-06T20:01:22.687' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(12.50 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (19, 1216, 9, N'Efectivo', CAST(N'2021-12-06T22:25:37.160' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Venta] OFF
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
