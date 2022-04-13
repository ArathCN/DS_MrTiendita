USE [master]
GO
/****** Object:  Database [MrTiendita]    Script Date: 13/04/2022 12:24:42 a. m. ******/
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
/****** Object:  Table [dbo].[Caja]    Script Date: 13/04/2022 12:24:42 a. m. ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 13/04/2022 12:24:42 a. m. ******/
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
	[estado] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada_almacen]    Script Date: 13/04/2022 12:24:42 a. m. ******/
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
/****** Object:  Table [dbo].[Movimientos]    Script Date: 13/04/2022 12:24:42 a. m. ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 13/04/2022 12:24:42 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[codigo_barra] [bigint] NOT NULL,
	[descripcion] [varchar](120) NULL,
	[precio_compra] [decimal](10, 2) NOT NULL,
	[cantidad_actual] [decimal](10, 3) NOT NULL,
	[medida] [bit] NULL,
	[categoria] [varchar](100) NOT NULL,
	[minimo] [decimal](10, 3) NOT NULL,
	[ganancia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_barra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 13/04/2022 12:24:42 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[telefono] [bigint] NOT NULL,
	[estado] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 13/04/2022 12:24:42 a. m. ******/
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
INSERT [dbo].[Caja] ([atributo], [valor]) VALUES (N'Total', N'467.9')
INSERT [dbo].[Caja] ([atributo], [valor]) VALUES (N'UltimoCorte', N'2021-11-08 09:00:00')
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (16, N'admin', N'admin', N'admin', 9999999999, CAST(9999.99 AS Decimal(10, 2)), N'Encargado', N'$2a$10$khbJCyrVsEFIzCDuKsqxauDlutfb1qBR9d1uPXmtaey9TalqP9iX6', N'admin', N'Activo')
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (19, N'Sebastian Arath', N'Cañedoo', N'Nuñez', 6623596075, CAST(1230.55 AS Decimal(10, 2)), N'Cajero', N'$2a$10$kxy9TOl5jYcax0HuZQ0P/Oqg3xhxtCzITpQTZvyVeWs/3eOkN9PYK', N'Arath', N'Activo')
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (23, N'maria', N'morales', N'martinez', 6621202092, CAST(1.00 AS Decimal(10, 2)), N'Cajero', N'$2a$10$lYqNVrYls90JYB9twOUpMOv8X8WiuGeVgzwyC2qTg9kSb1aHz8a7O', N'maria', N'Activo')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[Entrada_almacen] ON 

INSERT [dbo].[Entrada_almacen] ([id_entrada], [codigo_barra], [fecha], [cantidad], [importe], [id_proveedor]) VALUES (1022, 1112223334445, CAST(N'2022-01-01T12:00:00.000' AS DateTime), CAST(1.000 AS Decimal(10, 3)), CAST(12.55 AS Decimal(10, 2)), 1009)
SET IDENTITY_INSERT [dbo].[Entrada_almacen] OFF
SET IDENTITY_INSERT [dbo].[Movimientos] ON 

INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (35, N'Venta', CAST(N'2022-01-02T22:59:57.010' AS DateTime), CAST(60.90 AS Decimal(10, 2)), CAST(183.90 AS Decimal(10, 2)), N'Venta')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (36, N'Venta', CAST(N'2022-01-04T12:30:25.063' AS DateTime), CAST(15.00 AS Decimal(10, 2)), CAST(198.90 AS Decimal(10, 2)), N'Venta')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (37, N'Entrada', CAST(N'2022-01-07T01:59:54.110' AS DateTime), CAST(100.00 AS Decimal(10, 2)), CAST(298.90 AS Decimal(10, 2)), N'prueba')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (38, N'Salida', CAST(N'2022-01-07T14:51:28.003' AS DateTime), CAST(8.90 AS Decimal(10, 2)), CAST(290.00 AS Decimal(10, 2)), N'para que quede')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (39, N'Entrada', CAST(N'2022-03-02T11:46:07.360' AS DateTime), CAST(100.00 AS Decimal(10, 2)), CAST(390.00 AS Decimal(10, 2)), N'Dinero inicial')
INSERT [dbo].[Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (40, N'Venta', CAST(N'2022-03-02T11:47:31.497' AS DateTime), CAST(77.90 AS Decimal(10, 2)), CAST(467.90 AS Decimal(10, 2)), N'Venta')
SET IDENTITY_INSERT [dbo].[Movimientos] OFF
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_compra], [cantidad_actual], [medida], [categoria], [minimo], [ganancia]) VALUES (1112223334445, N'Sabritas Doritos Nachos 65 Gr.', CAST(12.55 AS Decimal(10, 2)), CAST(9.000 AS Decimal(10, 3)), 0, N'Sin categoria', CAST(1.000 AS Decimal(10, 3)), 30)
INSERT [dbo].[Producto] ([codigo_barra], [descripcion], [precio_compra], [cantidad_actual], [medida], [categoria], [minimo], [ganancia]) VALUES (1213141516178, N'Coca Cola 3L', CAST(28.45 AS Decimal(10, 2)), CAST(8.000 AS Decimal(10, 3)), 0, N'Sin categoria', CAST(1.000 AS Decimal(10, 3)), 30)
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono], [estado]) VALUES (1008, N'Coca Cola SA de CV', 6621293845, N'Activo')
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono], [estado]) VALUES (1009, N'Sabritas SA de CV', 6620143732, N'Activo')
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [telefono], [estado]) VALUES (1010, N'holayh', 6612121212, N'Activo')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (26, 1213141516178, 16, N'Efectivo', CAST(N'2022-01-02T22:59:56.873' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(60.90 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (27, 1112223334445, 16, N'Efectivo', CAST(N'2022-01-02T22:59:57.007' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(60.90 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (28, 1112223334445, 16, N'Efectivo', CAST(N'2022-01-04T12:30:25.037' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (29, 1112223334445, 16, N'Efectivo', CAST(N'2022-03-02T11:47:31.487' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(77.90 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (30, 1213141516178, 16, N'Efectivo', CAST(N'2022-03-02T11:47:31.497' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(77.90 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Venta] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Empleado__9AFF8FC65D77A33B]    Script Date: 13/04/2022 12:24:42 a. m. ******/
ALTER TABLE [dbo].[Empleado] ADD UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ('Activo') FOR [estado]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('Sin categoria') FOR [categoria]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((1)) FOR [minimo]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((30)) FOR [ganancia]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT ('Activo') FOR [estado]
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
