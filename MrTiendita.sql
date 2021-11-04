USE [master]
GO
/****** Object:  Database [MrTiendita]    Script Date: 22/10/2021 07:00:20 p. m. ******/
CREATE DATABASE [MrTiendita]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mr.Tiendita', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Mr.Tiendita.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mr.Tiendita_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Mr.Tiendita_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 22/10/2021 07:00:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[ap_materno] [varchar](60) NOT NULL,
	[ap_paterno] [varchar](60) NOT NULL,
	[telefono] [int] NOT NULL,
	[sueldo] [decimal](5, 2) NOT NULL,
	[tipo_empleado] [varchar](50) NOT NULL,
	[clave] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada_almacen]    Script Date: 22/10/2021 07:00:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada_almacen](
	[id_entrada] [int] IDENTITY(1,1) NOT NULL,
	[codigo_barra] [bigint] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[no_factura] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[cantidad] [int] NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 22/10/2021 07:00:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[codigo_barra] [bigint] NOT NULL,
	[descripcion] [varchar](120) NULL,
	[precio_venta] [decimal](10, 2) NOT NULL,
	[precio_compra] [decimal](10, 2) NOT NULL,
	[cantidad_actual] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_barra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 22/10/2021 07:00:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[telefono] [bigint] NOT NULL,
	[metodo_pago] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 22/10/2021 07:00:21 p. m. ******/
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
	[cantidad] [int] NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
