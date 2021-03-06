USE [MARSS]
GO
CREATE TABLE [Caja](
	[atributo] [varchar](100) PRIMARY KEY,
	[valor] [varchar](100) NOT NULL
);

CREATE TABLE [Empleado](
	[id_empleado] [int] IDENTITY(1,1) PRIMARY KEY,
	[nombre] [varchar](100) NOT NULL,
	[ap_materno] [varchar](60) NOT NULL,
	[ap_paterno] [varchar](60) NOT NULL,
	[telefono] [bigint] NOT NULL,
	[sueldo] [decimal](10, 2) NOT NULL,
	[tipo_empleado] [varchar](50) NOT NULL,
	[clave] [varchar](255) NOT NULL,
	[usuario] [varchar](50) NOT NULL
);

CREATE TABLE [EmpleadoUserView](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_Empleado] [int] NOT NULL
);

CREATE TABLE [Entrada_almacen](
	[id_entrada] [int] IDENTITY(1,1) PRIMARY KEY,
	[codigo_barra] [bigint] NOT NULL,
	[fecha] [datetime] NULL,
	[cantidad] [decimal](10, 3) NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
	[id_proveedor] [int] NOT NULL
);

CREATE TABLE [Movimientos](
	[id_movimiento] [int] IDENTITY(1,1) PRIMARY KEY,
	[tipo] [varchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
	[caja] [decimal](10, 2) NOT NULL,
	[concepto] [varchar](200) NOT NULL
);

CREATE TABLE [Producto](
	[codigo_barra] [bigint] PRIMARY KEY,
	[descripcion] [varchar](120) NULL,
	[precio_compra] [decimal](10, 2) NOT NULL,
	[cantidad_actual] [decimal](10, 3) NOT NULL,
	[medida] [bit] NULL,
	[categoria] [varchar](100) NOT NULL,
	[minimo] [decimal](10, 3) NOT NULL,
	[ganancia] [int] NOT NULL
);

CREATE TABLE [ProductoUserView](
	[id] [bigint] IDENTITY(1,1) PRIMARY KEY,
	[id_Producto] [bigint] NOT NULL
);

CREATE TABLE [Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) PRIMARY KEY,
	[nombre] [varchar](60) NOT NULL,
	[telefono] [bigint] NOT NULL
);

CREATE TABLE [ProveedorUserView](
	[id] [int] IDENTITY(1,1)PRIMARY KEY,
	[id_Proveedor] [int] NOT NULL
);

CREATE TABLE [Venta](
	[id_venta] [int] IDENTITY(1,1) PRIMARY KEY,
	[codigo_barra] [bigint] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[metodo_pago] [varchar](60) NOT NULL,
	[fecha] [datetime] NULL,
	[cantidad] [decimal](10, 2) NOT NULL,
	[importe] [decimal](10, 2) NOT NULL
);

ALTER TABLE [Producto] ADD  DEFAULT ('Sin categoria') FOR [categoria];
GO
ALTER TABLE [Producto] ADD  DEFAULT ((1)) FOR [minimo];
GO
ALTER TABLE [Producto] ADD  DEFAULT ((30)) FOR [ganancia];
GO
ALTER TABLE [EmpleadoUserView]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoUserView_Empleado] FOREIGN KEY([id_Empleado])
REFERENCES [Empleado] ([id_empleado]);
GO
ALTER TABLE [EmpleadoUserView] CHECK CONSTRAINT [FK_EmpleadoUserView_Empleado];
GO
ALTER TABLE [Entrada_almacen]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_almacen_Producto] FOREIGN KEY([codigo_barra])
REFERENCES [Producto] ([codigo_barra]);
GO
ALTER TABLE [Entrada_almacen] CHECK CONSTRAINT [FK_Entrada_almacen_Producto];
GO
ALTER TABLE [Entrada_almacen]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_almacen_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [Proveedor] ([id_proveedor]);
GO
ALTER TABLE [Entrada_almacen] CHECK CONSTRAINT [FK_Entrada_almacen_Proveedor];
GO
ALTER TABLE [ProductoUserView]  WITH CHECK ADD  CONSTRAINT [FK_ProductoUserView_Producto] FOREIGN KEY([id_Producto])
REFERENCES [Producto] ([codigo_barra]);
GO
ALTER TABLE [ProductoUserView] CHECK CONSTRAINT [FK_ProductoUserView_Producto];
GO
ALTER TABLE [ProveedorUserView]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorUserView_Proveedor] FOREIGN KEY([id_Proveedor])
REFERENCES [Proveedor] ([id_proveedor]);
GO
ALTER TABLE [ProveedorUserView] CHECK CONSTRAINT [FK_ProveedorUserView_Proveedor];
GO
ALTER TABLE [Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([id_empleado])
REFERENCES [Empleado] ([id_empleado]);
GO
ALTER TABLE [Venta] CHECK CONSTRAINT [FK_Venta_Empleado];
GO
ALTER TABLE [Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([codigo_barra])
REFERENCES [Producto] ([codigo_barra]);
GO
ALTER TABLE [Venta] CHECK CONSTRAINT [FK_Venta_Producto];
GO
