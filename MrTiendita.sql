USE [MrTiendita]
GO
ALTER TABLE [Venta] DROP CONSTRAINT [FK_Venta_Producto]
GO
ALTER TABLE [Venta] DROP CONSTRAINT [FK_Venta_Empleado]
GO
ALTER TABLE [ProveedorUserView] DROP CONSTRAINT [FK_ProveedorUserView_Proveedor]
GO
ALTER TABLE [ProductoUserView] DROP CONSTRAINT [FK_ProductoUserView_Producto]
GO
ALTER TABLE [Entrada_almacen] DROP CONSTRAINT [FK_Entrada_almacen_Proveedor]
GO
ALTER TABLE [Entrada_almacen] DROP CONSTRAINT [FK_Entrada_almacen_Producto]
GO
ALTER TABLE [Producto] DROP CONSTRAINT [DF__Producto__gananc__33D4B598]
GO
ALTER TABLE [Producto] DROP CONSTRAINT [DF__Producto__minimo__32E0915F]
GO
ALTER TABLE [Producto] DROP CONSTRAINT [DF__Producto__catego__31EC6D26]
GO
ALTER TABLE [Empleado] DROP CONSTRAINT [DF__Empleado__estado__30F848ED]
GO
ALTER TABLE [Empleado] DROP CONSTRAINT [UQ__Empleado__9AFF8FC691A597AE]
GO
DROP TABLE [Venta]
GO
DROP TABLE [ProveedorUserView]
GO
DROP TABLE [Proveedor]
GO
DROP TABLE [ProductoUserView]
GO
DROP TABLE [Producto]
GO
DROP TABLE [Movimientos]
GO
DROP TABLE [Entrada_almacen]
GO
DROP TABLE [Empleado]
GO
DROP TABLE [Caja]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Caja](
	[atributo] [varchar](100) NOT NULL,
	[valor] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED 
(
	[atributo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empleado](
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Entrada_almacen](
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Movimientos](
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Producto](
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ProductoUserView](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_Producto] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[telefono] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ProveedorUserView](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Proveedor] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Venta](
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
INSERT [Caja] ([atributo], [valor]) VALUES (N'Total', N'681.1')
INSERT [Caja] ([atributo], [valor]) VALUES (N'UltimoCorte', N'2021-11-08 09:00:00')
SET IDENTITY_INSERT [Empleado] ON 

INSERT [Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (16, N'admin', N'admin', N'admin', 9999999999, CAST(9999.99 AS Decimal(10, 2)), N'Encargado', N'$2a$10$khbJCyrVsEFIzCDuKsqxauDlutfb1qBR9d1uPXmtaey9TalqP9iX6', N'admin', N'Activo')
INSERT [Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (19, N'Sebastian Arath', N'Cañed', N'Nuñez', 6623596075, CAST(1230.55 AS Decimal(10, 2)), N'Cajero', N'$2a$10$kxy9TOl5jYcax0HuZQ0P/Oqg3xhxtCzITpQTZvyVeWs/3eOkN9PYK', N'Arath', N'Inactivo')
INSERT [Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (23, N'maria', N'morales', N'martinez', 6621202092, CAST(1.00 AS Decimal(10, 2)), N'Cajero', N'$2a$10$lYqNVrYls90JYB9twOUpMOv8X8WiuGeVgzwyC2qTg9kSb1aHz8a7O', N'maria', N'Activo')
INSERT [Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (25, N'Ana Belem', N'Nuñez', N'Valencia', 6621274001, CAST(1200.00 AS Decimal(10, 2)), N'Encargado', N'$2a$10$Ug.UUZ3lulD07yHauXi/I.JeyYbzc6NgCx/qAsInhBKikT7MK6.W2', N'prueba24040', N'Inactivo')
INSERT [Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (26, N'arath', N'arath', N'arath', 6624567892, CAST(1000.00 AS Decimal(10, 2)), N'Cajero', N'$2a$10$wBqbizea5SX/CCX9pm0z8O4zlNbucTa1D4FHB.XO8FjdvGFtC0n0y', N'prueba2504-', N'Inactivo')
INSERT [Empleado] ([id_empleado], [nombre], [ap_materno], [ap_paterno], [telefono], [sueldo], [tipo_empleado], [clave], [usuario], [estado]) VALUES (27, N'ppppp', N'ppppp', N'ppppp', 6624567896, CAST(1000.00 AS Decimal(10, 2)), N'Cajero', N'$2a$10$ojVERtQDsCRN0hdw2sUQA.1Gv/.Lc9ouLhTODcz7FpT.COo6vsAXO', N'ppppp', N'Activo')
SET IDENTITY_INSERT [Empleado] OFF
SET IDENTITY_INSERT [Entrada_almacen] ON 

INSERT [Entrada_almacen] ([id_entrada], [codigo_barra], [fecha], [cantidad], [importe], [id_proveedor]) VALUES (1022, 1112223334445, CAST(N'2022-01-01T12:00:00.000' AS DateTime), CAST(1.000 AS Decimal(10, 3)), CAST(12.55 AS Decimal(10, 2)), 1009)
SET IDENTITY_INSERT [Entrada_almacen] OFF
SET IDENTITY_INSERT [Movimientos] ON 

INSERT [Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (35, N'Venta', CAST(N'2022-01-02T22:59:57.010' AS DateTime), CAST(60.90 AS Decimal(10, 2)), CAST(183.90 AS Decimal(10, 2)), N'Venta')
INSERT [Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (36, N'Venta', CAST(N'2022-01-04T12:30:25.063' AS DateTime), CAST(15.00 AS Decimal(10, 2)), CAST(198.90 AS Decimal(10, 2)), N'Venta')
INSERT [Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (37, N'Entrada', CAST(N'2022-01-07T01:59:54.110' AS DateTime), CAST(100.00 AS Decimal(10, 2)), CAST(298.90 AS Decimal(10, 2)), N'prueba')
INSERT [Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (38, N'Salida', CAST(N'2022-01-07T14:51:28.003' AS DateTime), CAST(8.90 AS Decimal(10, 2)), CAST(290.00 AS Decimal(10, 2)), N'para que quede')
INSERT [Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (39, N'Entrada', CAST(N'2022-03-02T11:46:07.360' AS DateTime), CAST(100.00 AS Decimal(10, 2)), CAST(390.00 AS Decimal(10, 2)), N'Dinero inicial')
INSERT [Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (40, N'Venta', CAST(N'2022-03-02T11:47:31.497' AS DateTime), CAST(77.90 AS Decimal(10, 2)), CAST(467.90 AS Decimal(10, 2)), N'Venta')
INSERT [Movimientos] ([id_movimiento], [tipo], [fecha], [importe], [caja], [concepto]) VALUES (1039, N'Venta', CAST(N'2022-04-21T05:05:41.343' AS DateTime), CAST(213.20 AS Decimal(10, 2)), CAST(681.10 AS Decimal(10, 2)), N'Venta')
SET IDENTITY_INSERT [Movimientos] OFF
INSERT [Producto] ([codigo_barra], [descripcion], [precio_compra], [cantidad_actual], [medida], [categoria], [minimo], [ganancia]) VALUES (1112223334445, N'Sabritas Doritos Nachos 65 Gr.', CAST(12.55 AS Decimal(10, 2)), CAST(5.000 AS Decimal(10, 3)), 0, N'Sin categoria', CAST(1.000 AS Decimal(10, 3)), 30)
INSERT [Producto] ([codigo_barra], [descripcion], [precio_compra], [cantidad_actual], [medida], [categoria], [minimo], [ganancia]) VALUES (1213141516178, N'Coca Cola 3L', CAST(28.45 AS Decimal(10, 2)), CAST(4.000 AS Decimal(10, 3)), 0, N'Sin categoria', CAST(1.000 AS Decimal(10, 3)), 30)
SET IDENTITY_INSERT [ProductoUserView] ON 

INSERT [ProductoUserView] ([id], [id_Producto]) VALUES (1, 1112223334445)
INSERT [ProductoUserView] ([id], [id_Producto]) VALUES (2, 1213141516178)
SET IDENTITY_INSERT [ProductoUserView] OFF
SET IDENTITY_INSERT [Proveedor] ON 

INSERT [Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (1008, N'Coca Cola SA de CV', 6621293845)
INSERT [Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (1009, N'Sabritas SA de CV', 6620143732)
INSERT [Proveedor] ([id_proveedor], [nombre], [telefono]) VALUES (1011, N'qwerty', 6611220087)
SET IDENTITY_INSERT [Proveedor] OFF
SET IDENTITY_INSERT [ProveedorUserView] ON 

INSERT [ProveedorUserView] ([id], [id_Proveedor]) VALUES (1, 1008)
INSERT [ProveedorUserView] ([id], [id_Proveedor]) VALUES (2, 1009)
SET IDENTITY_INSERT [ProveedorUserView] OFF
SET IDENTITY_INSERT [Venta] ON 

INSERT [Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (26, 1213141516178, 16, N'Efectivo', CAST(N'2022-01-02T22:59:56.873' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(60.90 AS Decimal(10, 2)))
INSERT [Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (27, 1112223334445, 16, N'Efectivo', CAST(N'2022-01-02T22:59:57.007' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(60.90 AS Decimal(10, 2)))
INSERT [Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (28, 1112223334445, 16, N'Efectivo', CAST(N'2022-01-04T12:30:25.037' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)))
INSERT [Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (29, 1112223334445, 16, N'Efectivo', CAST(N'2022-03-02T11:47:31.487' AS DateTime), CAST(2.00 AS Decimal(10, 2)), CAST(77.90 AS Decimal(10, 2)))
INSERT [Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (30, 1213141516178, 16, N'Efectivo', CAST(N'2022-03-02T11:47:31.497' AS DateTime), CAST(1.00 AS Decimal(10, 2)), CAST(77.90 AS Decimal(10, 2)))
INSERT [Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (1029, 1112223334445, 16, N'Efectivo', CAST(N'2022-04-21T05:05:41.240' AS DateTime), CAST(4.00 AS Decimal(10, 2)), CAST(213.20 AS Decimal(10, 2)))
INSERT [Venta] ([id_venta], [codigo_barra], [id_empleado], [metodo_pago], [fecha], [cantidad], [importe]) VALUES (1030, 1213141516178, 16, N'Efectivo', CAST(N'2022-04-21T05:05:41.343' AS DateTime), CAST(4.00 AS Decimal(10, 2)), CAST(213.20 AS Decimal(10, 2)))
SET IDENTITY_INSERT [Venta] OFF
SET ANSI_PADDING ON
GO
ALTER TABLE [Empleado] ADD UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Empleado] ADD  DEFAULT ('Activo') FOR [estado]
GO
ALTER TABLE [Producto] ADD  DEFAULT ('Sin categoria') FOR [categoria]
GO
ALTER TABLE [Producto] ADD  DEFAULT ((1)) FOR [minimo]
GO
ALTER TABLE [Producto] ADD  DEFAULT ((30)) FOR [ganancia]
GO
ALTER TABLE [Entrada_almacen]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_almacen_Producto] FOREIGN KEY([codigo_barra])
REFERENCES [Producto] ([codigo_barra])
GO
ALTER TABLE [Entrada_almacen] CHECK CONSTRAINT [FK_Entrada_almacen_Producto]
GO
ALTER TABLE [Entrada_almacen]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_almacen_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [Proveedor] ([id_proveedor])
GO
ALTER TABLE [Entrada_almacen] CHECK CONSTRAINT [FK_Entrada_almacen_Proveedor]
GO
ALTER TABLE [ProductoUserView]  WITH CHECK ADD  CONSTRAINT [FK_ProductoUserView_Producto] FOREIGN KEY([id_Producto])
REFERENCES [Producto] ([codigo_barra])
GO
ALTER TABLE [ProductoUserView] CHECK CONSTRAINT [FK_ProductoUserView_Producto]
GO
ALTER TABLE [ProveedorUserView]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorUserView_Proveedor] FOREIGN KEY([id_Proveedor])
REFERENCES [Proveedor] ([id_proveedor])
GO
ALTER TABLE [ProveedorUserView] CHECK CONSTRAINT [FK_ProveedorUserView_Proveedor]
GO
ALTER TABLE [Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([id_empleado])
REFERENCES [Empleado] ([id_empleado])
GO
ALTER TABLE [Venta] CHECK CONSTRAINT [FK_Venta_Empleado]
GO
ALTER TABLE [Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([codigo_barra])
REFERENCES [Producto] ([codigo_barra])
GO
ALTER TABLE [Venta] CHECK CONSTRAINT [FK_Venta_Producto]
GO
