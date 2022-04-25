
namespace MrTiendita.Vistas
{
    partial class FrmPrincipal_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal_));
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_MARSS = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_CerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Inventario = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Configuracion = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reportes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Movimientos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Proveedores = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ventas = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Empleados = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Herramientas = new System.Windows.Forms.Label();
            this.btn_Tablero = new Guna.UI2.WinForms.Guna2Button();
            this.pb_Linea = new System.Windows.Forms.PictureBox();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Linea)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.BackColor = System.Drawing.Color.White;
            this.pnl_Superior.Controls.Add(this.btn_Maximizar);
            this.pnl_Superior.Controls.Add(this.btn_Minimizar);
            this.pnl_Superior.Controls.Add(this.btn_Cerrar);
            this.pnl_Superior.Controls.Add(this.lbl_MARSS);
            this.pnl_Superior.Controls.Add(this.pb_Logo);
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(1395, 60);
            this.pnl_Superior.TabIndex = 0;
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximizar.Image")));
            this.btn_Maximizar.Location = new System.Drawing.Point(1326, 14);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(24, 24);
            this.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Maximizar.TabIndex = 4;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(1296, 14);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(24, 24);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Minimizar.TabIndex = 3;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1356, 14);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_MARSS
            // 
            this.lbl_MARSS.AutoSize = true;
            this.lbl_MARSS.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MARSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.lbl_MARSS.Location = new System.Drawing.Point(66, 14);
            this.lbl_MARSS.Name = "lbl_MARSS";
            this.lbl_MARSS.Size = new System.Drawing.Size(97, 32);
            this.lbl_MARSS.TabIndex = 1;
            this.lbl_MARSS.Text = "MARSS";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(20, 10);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(40, 40);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btn_CerrarSesion);
            this.pnl_Menu.Controls.Add(this.btn_Inventario);
            this.pnl_Menu.Controls.Add(this.btn_Configuracion);
            this.pnl_Menu.Controls.Add(this.btn_Reportes);
            this.pnl_Menu.Controls.Add(this.btn_Movimientos);
            this.pnl_Menu.Controls.Add(this.btn_Proveedores);
            this.pnl_Menu.Controls.Add(this.btn_Ventas);
            this.pnl_Menu.Controls.Add(this.btn_Empleados);
            this.pnl_Menu.Controls.Add(this.lbl_Herramientas);
            this.pnl_Menu.Controls.Add(this.btn_Tablero);
            this.pnl_Menu.Controls.Add(this.pb_Linea);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 60);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(200, 839);
            this.pnl_Menu.TabIndex = 1;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CerrarSesion.BorderRadius = 5;
            this.btn_CerrarSesion.CheckedState.Parent = this.btn_CerrarSesion;
            this.btn_CerrarSesion.CustomImages.Parent = this.btn_CerrarSesion;
            this.btn_CerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_CerrarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_CerrarSesion.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarSesion.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.HoverState.Image")));
            this.btn_CerrarSesion.HoverState.Parent = this.btn_CerrarSesion;
            this.btn_CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.Image")));
            this.btn_CerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CerrarSesion.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_CerrarSesion.Location = new System.Drawing.Point(20, 787);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.ShadowDecoration.Parent = this.btn_CerrarSesion;
            this.btn_CerrarSesion.Size = new System.Drawing.Size(160, 40);
            this.btn_CerrarSesion.TabIndex = 10;
            this.btn_CerrarSesion.Text = "Cerrar sesión";
            this.btn_CerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CerrarSesion.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.BorderRadius = 5;
            this.btn_Inventario.CheckedState.Parent = this.btn_Inventario;
            this.btn_Inventario.CustomImages.Parent = this.btn_Inventario;
            this.btn_Inventario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Inventario.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Inventario.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Inventario.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Inventario.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inventario.HoverState.Image")));
            this.btn_Inventario.HoverState.Parent = this.btn_Inventario;
            this.btn_Inventario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inventario.Image")));
            this.btn_Inventario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Inventario.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Inventario.Location = new System.Drawing.Point(20, 198);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.ShadowDecoration.Parent = this.btn_Inventario;
            this.btn_Inventario.Size = new System.Drawing.Size(160, 40);
            this.btn_Inventario.TabIndex = 5;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Inventario.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // btn_Configuracion
            // 
            this.btn_Configuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Configuracion.BorderRadius = 5;
            this.btn_Configuracion.CheckedState.Parent = this.btn_Configuracion;
            this.btn_Configuracion.CustomImages.Parent = this.btn_Configuracion;
            this.btn_Configuracion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Configuracion.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Configuracion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Configuracion.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Configuracion.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Configuracion.HoverState.Image")));
            this.btn_Configuracion.HoverState.Parent = this.btn_Configuracion;
            this.btn_Configuracion.Image = ((System.Drawing.Image)(resources.GetObject("btn_Configuracion.Image")));
            this.btn_Configuracion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Configuracion.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Configuracion.Location = new System.Drawing.Point(20, 731);
            this.btn_Configuracion.Name = "btn_Configuracion";
            this.btn_Configuracion.ShadowDecoration.Parent = this.btn_Configuracion;
            this.btn_Configuracion.Size = new System.Drawing.Size(160, 40);
            this.btn_Configuracion.TabIndex = 6;
            this.btn_Configuracion.Text = "Configuración";
            this.btn_Configuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Configuracion.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_Configuracion.Click += new System.EventHandler(this.btn_Configuracion_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BorderRadius = 5;
            this.btn_Reportes.CheckedState.Parent = this.btn_Reportes;
            this.btn_Reportes.CustomImages.Parent = this.btn_Reportes;
            this.btn_Reportes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Reportes.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Reportes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Reportes.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Reportes.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.HoverState.Image")));
            this.btn_Reportes.HoverState.Parent = this.btn_Reportes;
            this.btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.Image")));
            this.btn_Reportes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Reportes.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Reportes.Location = new System.Drawing.Point(20, 422);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.ShadowDecoration.Parent = this.btn_Reportes;
            this.btn_Reportes.Size = new System.Drawing.Size(160, 40);
            this.btn_Reportes.TabIndex = 9;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Reportes.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Movimientos
            // 
            this.btn_Movimientos.BorderRadius = 5;
            this.btn_Movimientos.CheckedState.Parent = this.btn_Movimientos;
            this.btn_Movimientos.CustomImages.Parent = this.btn_Movimientos;
            this.btn_Movimientos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Movimientos.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Movimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Movimientos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Movimientos.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Movimientos.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Movimientos.HoverState.Image")));
            this.btn_Movimientos.HoverState.Parent = this.btn_Movimientos;
            this.btn_Movimientos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Movimientos.Image")));
            this.btn_Movimientos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Movimientos.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Movimientos.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_Movimientos.Location = new System.Drawing.Point(20, 254);
            this.btn_Movimientos.Name = "btn_Movimientos";
            this.btn_Movimientos.ShadowDecoration.Parent = this.btn_Movimientos;
            this.btn_Movimientos.Size = new System.Drawing.Size(160, 40);
            this.btn_Movimientos.TabIndex = 4;
            this.btn_Movimientos.Text = "Movimientos";
            this.btn_Movimientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Movimientos.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_Movimientos.Click += new System.EventHandler(this.btn_Movimientos_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BorderRadius = 5;
            this.btn_Proveedores.CheckedState.Parent = this.btn_Proveedores;
            this.btn_Proveedores.CustomImages.Parent = this.btn_Proveedores;
            this.btn_Proveedores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Proveedores.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Proveedores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Proveedores.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Proveedores.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Proveedores.HoverState.Image")));
            this.btn_Proveedores.HoverState.Parent = this.btn_Proveedores;
            this.btn_Proveedores.Image = ((System.Drawing.Image)(resources.GetObject("btn_Proveedores.Image")));
            this.btn_Proveedores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Proveedores.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Proveedores.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_Proveedores.Location = new System.Drawing.Point(20, 366);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.ShadowDecoration.Parent = this.btn_Proveedores;
            this.btn_Proveedores.Size = new System.Drawing.Size(160, 40);
            this.btn_Proveedores.TabIndex = 8;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Proveedores.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.BorderRadius = 5;
            this.btn_Ventas.CheckedState.Parent = this.btn_Ventas;
            this.btn_Ventas.CustomImages.Parent = this.btn_Ventas;
            this.btn_Ventas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Ventas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Ventas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Ventas.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Ventas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ventas.HoverState.Image")));
            this.btn_Ventas.HoverState.Parent = this.btn_Ventas;
            this.btn_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ventas.Image")));
            this.btn_Ventas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Ventas.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Ventas.Location = new System.Drawing.Point(20, 142);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.ShadowDecoration.Parent = this.btn_Ventas;
            this.btn_Ventas.Size = new System.Drawing.Size(160, 40);
            this.btn_Ventas.TabIndex = 3;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Ventas.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BorderRadius = 5;
            this.btn_Empleados.CheckedState.Parent = this.btn_Empleados;
            this.btn_Empleados.CustomImages.Parent = this.btn_Empleados;
            this.btn_Empleados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Empleados.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Empleados.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Empleados.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Empleados.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Empleados.HoverState.Image")));
            this.btn_Empleados.HoverState.Parent = this.btn_Empleados;
            this.btn_Empleados.Image = ((System.Drawing.Image)(resources.GetObject("btn_Empleados.Image")));
            this.btn_Empleados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Empleados.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Empleados.Location = new System.Drawing.Point(20, 310);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.ShadowDecoration.Parent = this.btn_Empleados;
            this.btn_Empleados.Size = new System.Drawing.Size(160, 40);
            this.btn_Empleados.TabIndex = 7;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Empleados.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // lbl_Herramientas
            // 
            this.lbl_Herramientas.AutoSize = true;
            this.lbl_Herramientas.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Herramientas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Herramientas.Location = new System.Drawing.Point(20, 106);
            this.lbl_Herramientas.Name = "lbl_Herramientas";
            this.lbl_Herramientas.Size = new System.Drawing.Size(118, 23);
            this.lbl_Herramientas.TabIndex = 2;
            this.lbl_Herramientas.Text = "Herramientas";
            // 
            // btn_Tablero
            // 
            this.btn_Tablero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Tablero.BorderRadius = 5;
            this.btn_Tablero.CheckedState.Parent = this.btn_Tablero;
            this.btn_Tablero.CustomImages.Parent = this.btn_Tablero;
            this.btn_Tablero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Tablero.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tablero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Tablero.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Tablero.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Tablero.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tablero.HoverState.Image")));
            this.btn_Tablero.HoverState.Parent = this.btn_Tablero;
            this.btn_Tablero.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tablero.Image")));
            this.btn_Tablero.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Tablero.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Tablero.Location = new System.Drawing.Point(20, 40);
            this.btn_Tablero.Name = "btn_Tablero";
            this.btn_Tablero.ShadowDecoration.Parent = this.btn_Tablero;
            this.btn_Tablero.Size = new System.Drawing.Size(160, 40);
            this.btn_Tablero.TabIndex = 0;
            this.btn_Tablero.Text = "Tablero";
            this.btn_Tablero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Tablero.TextOffset = new System.Drawing.Point(16, 0);
            this.btn_Tablero.Click += new System.EventHandler(this.btn_Tablero_Click);
            // 
            // pb_Linea
            // 
            this.pb_Linea.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_Linea.Image = ((System.Drawing.Image)(resources.GetObject("pb_Linea.Image")));
            this.pb_Linea.Location = new System.Drawing.Point(195, 0);
            this.pb_Linea.Name = "pb_Linea";
            this.pb_Linea.Size = new System.Drawing.Size(5, 839);
            this.pb_Linea.TabIndex = 0;
            this.pb_Linea.TabStop = false;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Contenedor.Location = new System.Drawing.Point(200, 60);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(1195, 839);
            this.pnl_Contenedor.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnl_Superior;
            // 
            // FrmPrincipal_
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1395, 899);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal_";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal__FormClosing);
            this.pnl_Superior.ResumeLayout(false);
            this.pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Linea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Superior;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_MARSS;
        private System.Windows.Forms.PictureBox pb_Linea;
        private System.Windows.Forms.Label lbl_Herramientas;
        public Guna.UI2.WinForms.Guna2Button btn_Tablero;
        public Guna.UI2.WinForms.Guna2Button btn_Inventario;
        public Guna.UI2.WinForms.Guna2Button btn_Movimientos;
        public Guna.UI2.WinForms.Guna2Button btn_Ventas;
        public Guna.UI2.WinForms.Guna2Button btn_Configuracion;
        public Guna.UI2.WinForms.Guna2Button btn_CerrarSesion;
        public Guna.UI2.WinForms.Guna2Button btn_Reportes;
        public Guna.UI2.WinForms.Guna2Button btn_Proveedores;
        public Guna.UI2.WinForms.Guna2Button btn_Empleados;
        public System.Windows.Forms.Panel pnl_Contenedor;
        public System.Windows.Forms.PictureBox btn_Maximizar;
        public System.Windows.Forms.PictureBox btn_Minimizar;
        public System.Windows.Forms.PictureBox btn_Cerrar;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}