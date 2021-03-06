
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
            this.lbl_EfetivoCaja = new System.Windows.Forms.Label();
            this.lbl_DescEfectivo = new System.Windows.Forms.Label();
            this.btn_AtajoCorte = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Estadisticas = new System.Windows.Forms.Label();
            this.btn_AtajoSalida = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AtajoEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AtajoProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AtajoVenta = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Atajos = new System.Windows.Forms.Label();
            this.lbl_DescAtajos = new System.Windows.Forms.Label();
            this.tlp_PanelSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_MensajeNoHay = new System.Windows.Forms.Panel();
            this.lbl_NoHayProductos = new System.Windows.Forms.Label();
            this.pb_caritaFeliz = new System.Windows.Forms.PictureBox();
            this.pnl_MensajeDesactivadas = new System.Windows.Forms.Panel();
            this.lbl_Desactivadas = new System.Windows.Forms.Label();
            this.pb_caritaConfundida = new System.Windows.Forms.PictureBox();
            this.btn_Configuracion = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Notificaciones.SuspendLayout();
            this.pnl_Atajos.SuspendLayout();
            this.tlp_PanelSuperior.SuspendLayout();
            this.pnl_MensajeNoHay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_caritaFeliz)).BeginInit();
            this.pnl_MensajeDesactivadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_caritaConfundida)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Notificaciones
            // 
            this.pnl_Notificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Notificaciones.BorderRadius = 10;
            this.pnl_Notificaciones.Controls.Add(this.pnl_MensajeDesactivadas);
            this.pnl_Notificaciones.Controls.Add(this.pnl_MensajeNoHay);
            this.pnl_Notificaciones.Controls.Add(this.flp_ListaNotificaciones);
            this.pnl_Notificaciones.Controls.Add(this.lbl_Notificaciones);
            this.pnl_Notificaciones.Controls.Add(this.lbl_DescNoti);
            this.pnl_Notificaciones.FillColor = System.Drawing.Color.White;
            this.pnl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Notificaciones.Location = new System.Drawing.Point(3, 2);
            this.pnl_Notificaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Notificaciones.Name = "pnl_Notificaciones";
            this.pnl_Notificaciones.ShadowDecoration.Parent = this.pnl_Notificaciones;
            this.pnl_Notificaciones.Size = new System.Drawing.Size(800, 812);
            this.pnl_Notificaciones.TabIndex = 1;
            // 
            // flp_ListaNotificaciones
            // 
            this.flp_ListaNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_ListaNotificaciones.AutoScroll = true;
            this.flp_ListaNotificaciones.BackColor = System.Drawing.Color.White;
            this.flp_ListaNotificaciones.Location = new System.Drawing.Point(24, 108);
            this.flp_ListaNotificaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_ListaNotificaciones.Name = "flp_ListaNotificaciones";
            this.flp_ListaNotificaciones.Size = new System.Drawing.Size(763, 688);
            this.flp_ListaNotificaciones.TabIndex = 6;
            // 
            // lbl_Notificaciones
            // 
            this.lbl_Notificaciones.AutoSize = true;
            this.lbl_Notificaciones.BackColor = System.Drawing.Color.White;
            this.lbl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Notificaciones.Location = new System.Drawing.Point(19, 33);
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
            this.pnl_Atajos.Controls.Add(this.lbl_EfetivoCaja);
            this.pnl_Atajos.Controls.Add(this.lbl_DescEfectivo);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoCorte);
            this.pnl_Atajos.Controls.Add(this.lbl_Estadisticas);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoSalida);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoEntrada);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoProductos);
            this.pnl_Atajos.Controls.Add(this.btn_AtajoVenta);
            this.pnl_Atajos.Controls.Add(this.lbl_Atajos);
            this.pnl_Atajos.Controls.Add(this.lbl_DescAtajos);
            this.pnl_Atajos.FillColor = System.Drawing.Color.White;
            this.pnl_Atajos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Atajos.Location = new System.Drawing.Point(814, 2);
            this.pnl_Atajos.Margin = new System.Windows.Forms.Padding(8, 2, 3, 2);
            this.pnl_Atajos.Name = "pnl_Atajos";
            this.pnl_Atajos.ShadowDecoration.Parent = this.pnl_Atajos;
            this.pnl_Atajos.Size = new System.Drawing.Size(354, 812);
            this.pnl_Atajos.TabIndex = 2;
            // 
            // lbl_EfetivoCaja
            // 
            this.lbl_EfetivoCaja.AutoSize = true;
            this.lbl_EfetivoCaja.BackColor = System.Drawing.Color.White;
            this.lbl_EfetivoCaja.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EfetivoCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_EfetivoCaja.Location = new System.Drawing.Point(39, 499);
            this.lbl_EfetivoCaja.Name = "lbl_EfetivoCaja";
            this.lbl_EfetivoCaja.Size = new System.Drawing.Size(161, 38);
            this.lbl_EfetivoCaja.TabIndex = 7;
            this.lbl_EfetivoCaja.Text = "$1,000,000";
            // 
            // lbl_DescEfectivo
            // 
            this.lbl_DescEfectivo.AutoSize = true;
            this.lbl_DescEfectivo.BackColor = System.Drawing.Color.White;
            this.lbl_DescEfectivo.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_DescEfectivo.Location = new System.Drawing.Point(21, 462);
            this.lbl_DescEfectivo.Name = "lbl_DescEfectivo";
            this.lbl_DescEfectivo.Size = new System.Drawing.Size(195, 23);
            this.lbl_DescEfectivo.TabIndex = 6;
            this.lbl_DescEfectivo.Text = "Total de efectivo en caja";
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
            this.btn_AtajoCorte.Location = new System.Drawing.Point(24, 313);
            this.btn_AtajoCorte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AtajoCorte.Name = "btn_AtajoCorte";
            this.btn_AtajoCorte.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoCorte.ShadowDecoration.Parent = this.btn_AtajoCorte;
            this.btn_AtajoCorte.Size = new System.Drawing.Size(311, 39);
            this.btn_AtajoCorte.TabIndex = 8;
            this.btn_AtajoCorte.Text = "Realizar corte de caja";
            this.btn_AtajoCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AtajoCorte.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // lbl_Estadisticas
            // 
            this.lbl_Estadisticas.AutoSize = true;
            this.lbl_Estadisticas.BackColor = System.Drawing.Color.White;
            this.lbl_Estadisticas.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Estadisticas.Location = new System.Drawing.Point(19, 430);
            this.lbl_Estadisticas.Name = "lbl_Estadisticas";
            this.lbl_Estadisticas.Size = new System.Drawing.Size(106, 32);
            this.lbl_Estadisticas.TabIndex = 4;
            this.lbl_Estadisticas.Text = "Efectivo";
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
            this.btn_AtajoSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AtajoSalida.Name = "btn_AtajoSalida";
            this.btn_AtajoSalida.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoSalida.ShadowDecoration.Parent = this.btn_AtajoSalida;
            this.btn_AtajoSalida.Size = new System.Drawing.Size(311, 39);
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
            this.btn_AtajoEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AtajoEntrada.Name = "btn_AtajoEntrada";
            this.btn_AtajoEntrada.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoEntrada.ShadowDecoration.Parent = this.btn_AtajoEntrada;
            this.btn_AtajoEntrada.Size = new System.Drawing.Size(311, 39);
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
            this.btn_AtajoProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AtajoProductos.Name = "btn_AtajoProductos";
            this.btn_AtajoProductos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoProductos.ShadowDecoration.Parent = this.btn_AtajoProductos;
            this.btn_AtajoProductos.Size = new System.Drawing.Size(311, 39);
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
            this.btn_AtajoVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AtajoVenta.Name = "btn_AtajoVenta";
            this.btn_AtajoVenta.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AtajoVenta.ShadowDecoration.Parent = this.btn_AtajoVenta;
            this.btn_AtajoVenta.Size = new System.Drawing.Size(311, 39);
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
            this.lbl_Atajos.Location = new System.Drawing.Point(19, 33);
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
            // tlp_PanelSuperior
            // 
            this.tlp_PanelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_PanelSuperior.ColumnCount = 2;
            this.tlp_PanelSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.83006F));
            this.tlp_PanelSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.16994F));
            this.tlp_PanelSuperior.Controls.Add(this.pnl_Atajos, 1, 0);
            this.tlp_PanelSuperior.Controls.Add(this.pnl_Notificaciones, 0, 0);
            this.tlp_PanelSuperior.Location = new System.Drawing.Point(12, 12);
            this.tlp_PanelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_PanelSuperior.Name = "tlp_PanelSuperior";
            this.tlp_PanelSuperior.RowCount = 1;
            this.tlp_PanelSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PanelSuperior.Size = new System.Drawing.Size(1171, 816);
            this.tlp_PanelSuperior.TabIndex = 3;
            // 
            // pnl_MensajeNoHay
            // 
            this.pnl_MensajeNoHay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MensajeNoHay.BackColor = System.Drawing.Color.White;
            this.pnl_MensajeNoHay.Controls.Add(this.panel1);
            this.pnl_MensajeNoHay.Location = new System.Drawing.Point(24, 108);
            this.pnl_MensajeNoHay.Name = "pnl_MensajeNoHay";
            this.pnl_MensajeNoHay.Size = new System.Drawing.Size(763, 688);
            this.pnl_MensajeNoHay.TabIndex = 0;
            this.pnl_MensajeNoHay.Visible = false;
            // 
            // lbl_NoHayProductos
            // 
            this.lbl_NoHayProductos.AutoSize = true;
            this.lbl_NoHayProductos.BackColor = System.Drawing.Color.White;
            this.lbl_NoHayProductos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoHayProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_NoHayProductos.Location = new System.Drawing.Point(158, 254);
            this.lbl_NoHayProductos.Name = "lbl_NoHayProductos";
            this.lbl_NoHayProductos.Size = new System.Drawing.Size(417, 28);
            this.lbl_NoHayProductos.TabIndex = 7;
            this.lbl_NoHayProductos.Text = "No hay productos por agotarse o agotados.";
            // 
            // pb_caritaFeliz
            // 
            this.pb_caritaFeliz.Image = ((System.Drawing.Image)(resources.GetObject("pb_caritaFeliz.Image")));
            this.pb_caritaFeliz.Location = new System.Drawing.Point(311, 124);
            this.pb_caritaFeliz.Name = "pb_caritaFeliz";
            this.pb_caritaFeliz.Size = new System.Drawing.Size(110, 100);
            this.pb_caritaFeliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_caritaFeliz.TabIndex = 8;
            this.pb_caritaFeliz.TabStop = false;
            // 
            // pnl_MensajeDesactivadas
            // 
            this.pnl_MensajeDesactivadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MensajeDesactivadas.BackColor = System.Drawing.Color.White;
            this.pnl_MensajeDesactivadas.Controls.Add(this.panel2);
            this.pnl_MensajeDesactivadas.Location = new System.Drawing.Point(24, 108);
            this.pnl_MensajeDesactivadas.Name = "pnl_MensajeDesactivadas";
            this.pnl_MensajeDesactivadas.Size = new System.Drawing.Size(763, 688);
            this.pnl_MensajeDesactivadas.TabIndex = 11;
            this.pnl_MensajeDesactivadas.Visible = false;
            // 
            // lbl_Desactivadas
            // 
            this.lbl_Desactivadas.AutoSize = true;
            this.lbl_Desactivadas.BackColor = System.Drawing.Color.White;
            this.lbl_Desactivadas.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desactivadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Desactivadas.Location = new System.Drawing.Point(117, 256);
            this.lbl_Desactivadas.Name = "lbl_Desactivadas";
            this.lbl_Desactivadas.Size = new System.Drawing.Size(498, 84);
            this.lbl_Desactivadas.TabIndex = 10;
            this.lbl_Desactivadas.Text = "Tienes desactivadas las notificaciones.\r\nActívalas en la configuración para ver l" +
    "os productos\r\nque estén por agotarse o agotados.";
            this.lbl_Desactivadas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pb_caritaConfundida
            // 
            this.pb_caritaConfundida.Image = ((System.Drawing.Image)(resources.GetObject("pb_caritaConfundida.Image")));
            this.pb_caritaConfundida.Location = new System.Drawing.Point(311, 124);
            this.pb_caritaConfundida.Name = "pb_caritaConfundida";
            this.pb_caritaConfundida.Size = new System.Drawing.Size(110, 100);
            this.pb_caritaConfundida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_caritaConfundida.TabIndex = 9;
            this.pb_caritaConfundida.TabStop = false;
            // 
            // btn_Configuracion
            // 
            this.btn_Configuracion.BackColor = System.Drawing.Color.White;
            this.btn_Configuracion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.btn_Configuracion.BorderRadius = 5;
            this.btn_Configuracion.BorderThickness = 1;
            this.btn_Configuracion.CheckedState.Parent = this.btn_Configuracion;
            this.btn_Configuracion.CustomImages.Parent = this.btn_Configuracion;
            this.btn_Configuracion.FillColor = System.Drawing.Color.White;
            this.btn_Configuracion.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Configuracion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Configuracion.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_Configuracion.HoverState.Parent = this.btn_Configuracion;
            this.btn_Configuracion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Configuracion.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_Configuracion.Location = new System.Drawing.Point(211, 407);
            this.btn_Configuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Configuracion.Name = "btn_Configuracion";
            this.btn_Configuracion.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Configuracion.ShadowDecoration.Parent = this.btn_Configuracion;
            this.btn_Configuracion.Size = new System.Drawing.Size(311, 39);
            this.btn_Configuracion.TabIndex = 11;
            this.btn_Configuracion.Text = "Ir a configuración";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_caritaFeliz);
            this.panel1.Controls.Add(this.lbl_NoHayProductos);
            this.panel1.Location = new System.Drawing.Point(19, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 492);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Configuracion);
            this.panel2.Controls.Add(this.lbl_Desactivadas);
            this.panel2.Controls.Add(this.pb_caritaConfundida);
            this.panel2.Location = new System.Drawing.Point(19, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 492);
            this.panel2.TabIndex = 0;
            // 
            // FrmTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 839);
            this.Controls.Add(this.tlp_PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTablero";
            this.Text = "FrmTablero";
            this.pnl_Notificaciones.ResumeLayout(false);
            this.pnl_Notificaciones.PerformLayout();
            this.pnl_Atajos.ResumeLayout(false);
            this.pnl_Atajos.PerformLayout();
            this.tlp_PanelSuperior.ResumeLayout(false);
            this.pnl_MensajeNoHay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_caritaFeliz)).EndInit();
            this.pnl_MensajeDesactivadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_caritaConfundida)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Notificaciones;
        private Guna.UI2.WinForms.Guna2Panel pnl_Atajos;
        private System.Windows.Forms.Label lbl_Notificaciones;
        private System.Windows.Forms.Label lbl_DescNoti;
        private System.Windows.Forms.Label lbl_Estadisticas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TableLayoutPanel tlp_PanelSuperior;
        public System.Windows.Forms.FlowLayoutPanel flp_ListaNotificaciones;
        public System.Windows.Forms.Label lbl_Atajos;
        public System.Windows.Forms.Label lbl_DescAtajos;
        public Guna.UI2.WinForms.Guna2Button btn_AtajoCorte;
        public Guna.UI2.WinForms.Guna2Button btn_AtajoSalida;
        public Guna.UI2.WinForms.Guna2Button btn_AtajoEntrada;
        public Guna.UI2.WinForms.Guna2Button btn_AtajoProductos;
        public Guna.UI2.WinForms.Guna2Button btn_AtajoVenta;
        private System.Windows.Forms.Label lbl_DescEfectivo;
        public System.Windows.Forms.Label lbl_EfetivoCaja;
        private System.Windows.Forms.PictureBox pb_caritaFeliz;
        private System.Windows.Forms.Label lbl_NoHayProductos;
        private System.Windows.Forms.Label lbl_Desactivadas;
        private System.Windows.Forms.PictureBox pb_caritaConfundida;
        public Guna.UI2.WinForms.Guna2Button btn_Configuracion;
        public System.Windows.Forms.Panel pnl_MensajeNoHay;
        public System.Windows.Forms.Panel pnl_MensajeDesactivadas;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
    }
}