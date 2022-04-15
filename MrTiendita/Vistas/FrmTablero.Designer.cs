
namespace MrTiendita.Vistas
{
    partial class FrmTablero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTablero));
            this.pnl_Notificaciones = new Guna.UI2.WinForms.Guna2Panel();
            this.flp_ListaNotificaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Notificaciones = new System.Windows.Forms.Label();
            this.lbl_DescNoti = new System.Windows.Forms.Label();
            this.pnl_Atajos = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_AtajoCorte = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AtajoSalida = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AtajoEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AtajoProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AtajoVenta = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Atajos = new System.Windows.Forms.Label();
            this.lbl_DescAtajos = new System.Windows.Forms.Label();
            this.pnl_Estadisticas = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Estadisticas = new System.Windows.Forms.Label();
            this.lbl_DescEstadisticas = new System.Windows.Forms.Label();
            this.tlp_PanelSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_Notificaciones.SuspendLayout();
            this.pnl_Atajos.SuspendLayout();
            this.pnl_Estadisticas.SuspendLayout();
            this.tlp_PanelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Notificaciones
            // 
            this.pnl_Notificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Notificaciones.BorderRadius = 10;
            this.pnl_Notificaciones.Controls.Add(this.flp_ListaNotificaciones);
            this.pnl_Notificaciones.Controls.Add(this.lbl_Notificaciones);
            this.pnl_Notificaciones.Controls.Add(this.lbl_DescNoti);
            this.pnl_Notificaciones.FillColor = System.Drawing.Color.White;
            this.pnl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Notificaciones.Location = new System.Drawing.Point(3, 3);
            this.pnl_Notificaciones.Name = "pnl_Notificaciones";
            this.pnl_Notificaciones.ShadowDecoration.Parent = this.pnl_Notificaciones;
            this.pnl_Notificaciones.Size = new System.Drawing.Size(800, 438);
            this.pnl_Notificaciones.TabIndex = 1;
            // 
            // flp_ListaNotificaciones
            // 
            this.flp_ListaNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_ListaNotificaciones.AutoScroll = true;
            this.flp_ListaNotificaciones.BackColor = System.Drawing.Color.White;
            this.flp_ListaNotificaciones.Location = new System.Drawing.Point(24, 108);
            this.flp_ListaNotificaciones.Name = "flp_ListaNotificaciones";
            this.flp_ListaNotificaciones.Size = new System.Drawing.Size(762, 315);
            this.flp_ListaNotificaciones.TabIndex = 6;
            // 
            // lbl_Notificaciones
            // 
            this.lbl_Notificaciones.AutoSize = true;
            this.lbl_Notificaciones.BackColor = System.Drawing.Color.White;
            this.lbl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Notificaciones.Location = new System.Drawing.Point(18, 33);
            this.lbl_Notificaciones.Name = "lbl_Notificaciones";
            this.lbl_Notificaciones.Size = new System.Drawing.Size(179, 32);
            this.lbl_Notificaciones.TabIndex = 4;
            this.lbl_Notificaciones.Text = "Notificaciones";
            // 
            // lbl_DescNoti
            // 
            this.lbl_DescNoti.AutoSize = true;
            this.lbl_DescNoti.BackColor = System.Drawing.Color.White;
            this.lbl_DescNoti.Location = new System.Drawing.Point(20, 64);
            this.lbl_DescNoti.Name = "lbl_DescNoti";
            this.lbl_DescNoti.Size = new System.Drawing.Size(367, 23);
            this.lbl_DescNoti.TabIndex = 5;
            this.lbl_DescNoti.Text = "Avisos de productos casi agotados o agotados.";
            // 
            // pnl_Atajos
            // 
            this.pnl_Atajos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Atajos.BorderRadius = 10;
            this.pnl_Atajos.Controls.Add(this.btn_AtajoCorte);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoSalida);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoEntrada);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoProductos);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoVenta);
            this.pnl_Atajos.Controls.Add(this.lbl_Atajos);
            this.pnl_Atajos.Controls.Add(this.lbl_DescAtajos);
            this.pnl_Atajos.FillColor = System.Drawing.Color.White;
            this.pnl_Atajos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Atajos.Location = new System.Drawing.Point(814, 3);
            this.pnl_Atajos.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.pnl_Atajos.Name = "pnl_Atajos";
            this.pnl_Atajos.ShadowDecoration.Parent = this.pnl_Atajos;
            this.pnl_Atajos.Size = new System.Drawing.Size(354, 438);
            this.pnl_Atajos.TabIndex = 2;
            // 
            // btn_AtajoCorte
            // 
            this.btn_AtajoCorte.BackColor = System.Drawing.Color.White;
            this.btn_AtajoCorte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoCorte.BorderRadius = 5;
            this.btn_AtajoCorte.CheckedState.Parent = this.btn_AtajoCorte;
            this.btn_AtajoCorte.CustomImages.Parent = this.btn_AtajoCorte;
            this.btn_AtajoCorte.FillColor = System.Drawing.Color.White;
            this.btn_AtajoCorte.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtajoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_AtajoCorte.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoCorte.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_AtajoCorte.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoCorte.HoverState.Image")));
            this.btn_AtajoCorte.HoverState.Parent = this.btn_AtajoCorte;
            this.btn_AtajoCorte.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoCorte.Image")));
            this.btn_AtajoCorte.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoCorte.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_AtajoCorte.Location = new System.Drawing.Point(24, 312);
            this.btn_AtajoCorte.Name = "btn_AtajoCorte";
            this.btn_AtajoCorte.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoCorte.ShadowDecoration.Parent = this.btn_AtajoCorte;
            this.btn_AtajoCorte.Size = new System.Drawing.Size(311, 40);
            this.btn_AtajoCorte.TabIndex = 8;
            this.btn_AtajoCorte.Text = "Realizar corte de caja";
            this.btn_AtajoCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoCorte.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // btn_AtajoSalida
            // 
            this.btn_AtajoSalida.BackColor = System.Drawing.Color.White;
            this.btn_AtajoSalida.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoSalida.BorderRadius = 5;
            this.btn_AtajoSalida.CheckedState.Parent = this.btn_AtajoSalida;
            this.btn_AtajoSalida.CustomImages.Parent = this.btn_AtajoSalida;
            this.btn_AtajoSalida.FillColor = System.Drawing.Color.White;
            this.btn_AtajoSalida.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtajoSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_AtajoSalida.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoSalida.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_AtajoSalida.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoSalida.HoverState.Image")));
            this.btn_AtajoSalida.HoverState.Parent = this.btn_AtajoSalida;
            this.btn_AtajoSalida.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoSalida.Image")));
            this.btn_AtajoSalida.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoSalida.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_AtajoSalida.Location = new System.Drawing.Point(24, 261);
            this.btn_AtajoSalida.Name = "btn_AtajoSalida";
            this.btn_AtajoSalida.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoSalida.ShadowDecoration.Parent = this.btn_AtajoSalida;
            this.btn_AtajoSalida.Size = new System.Drawing.Size(311, 40);
            this.btn_AtajoSalida.TabIndex = 7;
            this.btn_AtajoSalida.Text = "Registrar salida de dinero";
            this.btn_AtajoSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoSalida.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // btn_AtajoEntrada
            // 
            this.btn_AtajoEntrada.BackColor = System.Drawing.Color.White;
            this.btn_AtajoEntrada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoEntrada.BorderRadius = 5;
            this.btn_AtajoEntrada.CheckedState.Parent = this.btn_AtajoEntrada;
            this.btn_AtajoEntrada.CustomImages.Parent = this.btn_AtajoEntrada;
            this.btn_AtajoEntrada.FillColor = System.Drawing.Color.White;
            this.btn_AtajoEntrada.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtajoEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_AtajoEntrada.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoEntrada.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_AtajoEntrada.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoEntrada.HoverState.Image")));
            this.btn_AtajoEntrada.HoverState.Parent = this.btn_AtajoEntrada;
            this.btn_AtajoEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoEntrada.Image")));
            this.btn_AtajoEntrada.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoEntrada.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_AtajoEntrada.Location = new System.Drawing.Point(24, 210);
            this.btn_AtajoEntrada.Name = "btn_AtajoEntrada";
            this.btn_AtajoEntrada.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoEntrada.ShadowDecoration.Parent = this.btn_AtajoEntrada;
            this.btn_AtajoEntrada.Size = new System.Drawing.Size(311, 40);
            this.btn_AtajoEntrada.TabIndex = 6;
            this.btn_AtajoEntrada.Text = "Registrar entrada de dinero";
            this.btn_AtajoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoEntrada.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // btn_AtajoProductos
            // 
            this.btn_AtajoProductos.BackColor = System.Drawing.Color.White;
            this.btn_AtajoProductos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoProductos.BorderRadius = 5;
            this.btn_AtajoProductos.CheckedState.Parent = this.btn_AtajoProductos;
            this.btn_AtajoProductos.CustomImages.Parent = this.btn_AtajoProductos;
            this.btn_AtajoProductos.FillColor = System.Drawing.Color.White;
            this.btn_AtajoProductos.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtajoProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_AtajoProductos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoProductos.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_AtajoProductos.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoProductos.HoverState.Image")));
            this.btn_AtajoProductos.HoverState.Parent = this.btn_AtajoProductos;
            this.btn_AtajoProductos.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoProductos.Image")));
            this.btn_AtajoProductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoProductos.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_AtajoProductos.Location = new System.Drawing.Point(24, 159);
            this.btn_AtajoProductos.Name = "btn_AtajoProductos";
            this.btn_AtajoProductos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoProductos.ShadowDecoration.Parent = this.btn_AtajoProductos;
            this.btn_AtajoProductos.Size = new System.Drawing.Size(311, 40);
            this.btn_AtajoProductos.TabIndex = 5;
            this.btn_AtajoProductos.Text = "Ingresar productos";
            this.btn_AtajoProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoProductos.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // btn_AtajoVenta
            // 
            this.btn_AtajoVenta.BackColor = System.Drawing.Color.White;
            this.btn_AtajoVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoVenta.BorderRadius = 5;
            this.btn_AtajoVenta.CheckedState.Parent = this.btn_AtajoVenta;
            this.btn_AtajoVenta.CustomImages.Parent = this.btn_AtajoVenta;
            this.btn_AtajoVenta.FillColor = System.Drawing.Color.White;
            this.btn_AtajoVenta.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtajoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_AtajoVenta.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AtajoVenta.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_AtajoVenta.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoVenta.HoverState.Image")));
            this.btn_AtajoVenta.HoverState.Parent = this.btn_AtajoVenta;
            this.btn_AtajoVenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AtajoVenta.Image")));
            this.btn_AtajoVenta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoVenta.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_AtajoVenta.Location = new System.Drawing.Point(24, 108);
            this.btn_AtajoVenta.Name = "btn_AtajoVenta";
            this.btn_AtajoVenta.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoVenta.ShadowDecoration.Parent = this.btn_AtajoVenta;
            this.btn_AtajoVenta.Size = new System.Drawing.Size(311, 40);
            this.btn_AtajoVenta.TabIndex = 4;
            this.btn_AtajoVenta.Text = "Realizar una venta";
            this.btn_AtajoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoVenta.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // lbl_Atajos
            // 
            this.lbl_Atajos.AutoSize = true;
            this.lbl_Atajos.BackColor = System.Drawing.Color.White;
            this.lbl_Atajos.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Atajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Atajos.Location = new System.Drawing.Point(18, 33);
            this.lbl_Atajos.Name = "lbl_Atajos";
            this.lbl_Atajos.Size = new System.Drawing.Size(87, 32);
            this.lbl_Atajos.TabIndex = 2;
            this.lbl_Atajos.Text = "Atajos";
            // 
            // lbl_DescAtajos
            // 
            this.lbl_DescAtajos.AutoSize = true;
            this.lbl_DescAtajos.BackColor = System.Drawing.Color.White;
            this.lbl_DescAtajos.Location = new System.Drawing.Point(20, 64);
            this.lbl_DescAtajos.Name = "lbl_DescAtajos";
            this.lbl_DescAtajos.Size = new System.Drawing.Size(229, 23);
            this.lbl_DescAtajos.TabIndex = 3;
            this.lbl_DescAtajos.Text = "Accesos directos a las tareas.";
            // 
            // pnl_Estadisticas
            // 
            this.pnl_Estadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Estadisticas.BorderRadius = 10;
            this.pnl_Estadisticas.Controls.Add(this.lbl_Estadisticas);
            this.pnl_Estadisticas.Controls.Add(this.lbl_DescEstadisticas);
            this.pnl_Estadisticas.FillColor = System.Drawing.Color.White;
            this.pnl_Estadisticas.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Estadisticas.Location = new System.Drawing.Point(15, 462);
            this.pnl_Estadisticas.Name = "pnl_Estadisticas";
            this.pnl_Estadisticas.ShadowDecoration.Parent = this.pnl_Estadisticas;
            this.pnl_Estadisticas.Size = new System.Drawing.Size(1165, 365);
            this.pnl_Estadisticas.TabIndex = 2;
            // 
            // lbl_Estadisticas
            // 
            this.lbl_Estadisticas.AutoSize = true;
            this.lbl_Estadisticas.BackColor = System.Drawing.Color.White;
            this.lbl_Estadisticas.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Estadisticas.Location = new System.Drawing.Point(18, 33);
            this.lbl_Estadisticas.Name = "lbl_Estadisticas";
            this.lbl_Estadisticas.Size = new System.Drawing.Size(147, 32);
            this.lbl_Estadisticas.TabIndex = 4;
            this.lbl_Estadisticas.Text = "Estadísticas";
            // 
            // lbl_DescEstadisticas
            // 
            this.lbl_DescEstadisticas.AutoSize = true;
            this.lbl_DescEstadisticas.BackColor = System.Drawing.Color.White;
            this.lbl_DescEstadisticas.Location = new System.Drawing.Point(20, 64);
            this.lbl_DescEstadisticas.Name = "lbl_DescEstadisticas";
            this.lbl_DescEstadisticas.Size = new System.Drawing.Size(370, 23);
            this.lbl_DescEstadisticas.TabIndex = 5;
            this.lbl_DescEstadisticas.Text = "Consulta las estadísticas generales de la tienda.";
            // 
            // tlp_PanelSuperior
            // 
            this.tlp_PanelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_PanelSuperior.ColumnCount = 2;
            this.tlp_PanelSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.83006F));
            this.tlp_PanelSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.16994F));
            this.tlp_PanelSuperior.Controls.Add(this.pnl_Atajos, 1, 0);
            this.tlp_PanelSuperior.Controls.Add(this.pnl_Notificaciones, 0, 0);
            this.tlp_PanelSuperior.Location = new System.Drawing.Point(12, 12);
            this.tlp_PanelSuperior.Name = "tlp_PanelSuperior";
            this.tlp_PanelSuperior.RowCount = 1;
            this.tlp_PanelSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PanelSuperior.Size = new System.Drawing.Size(1171, 444);
            this.tlp_PanelSuperior.TabIndex = 3;
            // 
            // FrmTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 839);
            this.Controls.Add(this.tlp_PanelSuperior);
            this.Controls.Add(this.pnl_Estadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTablero";
            this.Text = "FrmTablero";
            this.pnl_Notificaciones.ResumeLayout(false);
            this.pnl_Notificaciones.PerformLayout();
            this.pnl_Atajos.ResumeLayout(false);
            this.pnl_Atajos.PerformLayout();
            this.pnl_Estadisticas.ResumeLayout(false);
            this.pnl_Estadisticas.PerformLayout();
            this.tlp_PanelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Notificaciones;
        private Guna.UI2.WinForms.Guna2Panel pnl_Atajos;
        private Guna.UI2.WinForms.Guna2Panel pnl_Estadisticas;
        private System.Windows.Forms.TableLayoutPanel tlp_PanelSuperior;
        private System.Windows.Forms.Label lbl_Atajos;
        private System.Windows.Forms.Label lbl_DescAtajos;
        private System.Windows.Forms.Label lbl_Notificaciones;
        private System.Windows.Forms.Label lbl_DescNoti;
        private System.Windows.Forms.Label lbl_Estadisticas;
        private System.Windows.Forms.Label lbl_DescEstadisticas;
        private Guna.UI2.WinForms.Guna2Button btn_AtajoCorte;
        private Guna.UI2.WinForms.Guna2Button btn_AtajoSalida;
        private Guna.UI2.WinForms.Guna2Button btn_AtajoEntrada;
        private Guna.UI2.WinForms.Guna2Button btn_AtajoProductos;
        private Guna.UI2.WinForms.Guna2Button btn_AtajoVenta;
        private System.Windows.Forms.FlowLayoutPanel flp_ListaNotificaciones;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}