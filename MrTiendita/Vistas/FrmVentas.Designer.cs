
namespace MrTiendita.Vistas
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.tlp_PanelSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Atajos = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_CancelarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CompletarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Efectivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.check_Tarjeta = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_Efectivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TotalAPagar = new System.Windows.Forms.Label();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            this.lbl_Atajos = new System.Windows.Forms.Label();
            this.lbl_DescAtajos = new System.Windows.Forms.Label();
            this.pnl_Notificaciones = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_TablaVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_menos = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mas = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CambiarRuta = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Tablero = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_SueldoCajeros = new System.Windows.Forms.Label();
            this.tb_SueldoCajeros = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Notificaciones = new System.Windows.Forms.Label();
            this.lbl_DescNoti = new System.Windows.Forms.Label();
            this.tlp_PanelSuperior.SuspendLayout();
            this.pnl_Atajos.SuspendLayout();
            this.pnl_Notificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaVentas)).BeginInit();
            this.SuspendLayout();
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
            this.tlp_PanelSuperior.Name = "tlp_PanelSuperior";
            this.tlp_PanelSuperior.RowCount = 1;
            this.tlp_PanelSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PanelSuperior.Size = new System.Drawing.Size(1171, 815);
            this.tlp_PanelSuperior.TabIndex = 4;
            // 
            // pnl_Atajos
            // 
            this.pnl_Atajos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Atajos.BorderRadius = 10;
            this.pnl_Atajos.Controls.Add(this.btn_CancelarVenta);
            this.pnl_Atajos.Controls.Add(this.btn_CompletarVenta);
            this.pnl_Atajos.Controls.Add(this.label8);
            this.pnl_Atajos.Controls.Add(this.label9);
            this.pnl_Atajos.Controls.Add(this.label7);
            this.pnl_Atajos.Controls.Add(this.tb_Efectivo);
            this.pnl_Atajos.Controls.Add(this.label6);
            this.pnl_Atajos.Controls.Add(this.label5);
            this.pnl_Atajos.Controls.Add(this.check_Tarjeta);
            this.pnl_Atajos.Controls.Add(this.label4);
            this.pnl_Atajos.Controls.Add(this.check_Efectivo);
            this.pnl_Atajos.Controls.Add(this.label3);
            this.pnl_Atajos.Controls.Add(this.lbl_TotalAPagar);
            this.pnl_Atajos.Controls.Add(this.lbl_Ruta);
            this.pnl_Atajos.Controls.Add(this.lbl_Atajos);
            this.pnl_Atajos.Controls.Add(this.lbl_DescAtajos);
            this.pnl_Atajos.FillColor = System.Drawing.Color.White;
            this.pnl_Atajos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Atajos.Location = new System.Drawing.Point(814, 3);
            this.pnl_Atajos.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.pnl_Atajos.Name = "pnl_Atajos";
            this.pnl_Atajos.ShadowDecoration.Parent = this.pnl_Atajos;
            this.pnl_Atajos.Size = new System.Drawing.Size(354, 809);
            this.pnl_Atajos.TabIndex = 2;
            // 
            // btn_CancelarVenta
            // 
            this.btn_CancelarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelarVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CancelarVenta.BorderRadius = 5;
            this.btn_CancelarVenta.BorderThickness = 1;
            this.btn_CancelarVenta.CheckedState.Parent = this.btn_CancelarVenta;
            this.btn_CancelarVenta.CustomImages.Parent = this.btn_CancelarVenta;
            this.btn_CancelarVenta.FillColor = System.Drawing.Color.White;
            this.btn_CancelarVenta.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CancelarVenta.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_CancelarVenta.HoverState.Parent = this.btn_CancelarVenta;
            this.btn_CancelarVenta.Location = new System.Drawing.Point(145, 544);
            this.btn_CancelarVenta.Name = "btn_CancelarVenta";
            this.btn_CancelarVenta.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CancelarVenta.ShadowDecoration.Parent = this.btn_CancelarVenta;
            this.btn_CancelarVenta.Size = new System.Drawing.Size(188, 40);
            this.btn_CancelarVenta.TabIndex = 29;
            this.btn_CancelarVenta.Text = "Cancelar venta";
            // 
            // btn_CompletarVenta
            // 
            this.btn_CompletarVenta.BorderRadius = 5;
            this.btn_CompletarVenta.CheckedState.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.CustomImages.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CompletarVenta.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompletarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_CompletarVenta.HoverState.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.Location = new System.Drawing.Point(24, 544);
            this.btn_CompletarVenta.Name = "btn_CompletarVenta";
            this.btn_CompletarVenta.ShadowDecoration.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.Size = new System.Drawing.Size(188, 40);
            this.btn_CompletarVenta.TabIndex = 28;
            this.btn_CompletarVenta.Text = "Completar venta";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(278, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "$0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(20, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cambio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Efectivo";
            // 
            // tb_Efectivo
            // 
            this.tb_Efectivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Efectivo.BorderRadius = 5;
            this.tb_Efectivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Efectivo.DefaultText = "";
            this.tb_Efectivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Efectivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Efectivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Efectivo.DisabledState.Parent = this.tb_Efectivo;
            this.tb_Efectivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Efectivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Efectivo.FocusedState.Parent = this.tb_Efectivo;
            this.tb_Efectivo.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Efectivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Efectivo.HoverState.Parent = this.tb_Efectivo;
            this.tb_Efectivo.Location = new System.Drawing.Point(24, 381);
            this.tb_Efectivo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Efectivo.Name = "tb_Efectivo";
            this.tb_Efectivo.PasswordChar = '\0';
            this.tb_Efectivo.PlaceholderText = "";
            this.tb_Efectivo.SelectedText = "";
            this.tb_Efectivo.ShadowDecoration.Parent = this.tb_Efectivo;
            this.tb_Efectivo.Size = new System.Drawing.Size(260, 40);
            this.tb_Efectivo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(19, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(187, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tarjeta";
            // 
            // check_Tarjeta
            // 
            this.check_Tarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_Tarjeta.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_Tarjeta.Checked = false;
            this.check_Tarjeta.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_Tarjeta.ForeColor = System.Drawing.Color.White;
            this.check_Tarjeta.Location = new System.Drawing.Point(160, 243);
            this.check_Tarjeta.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.check_Tarjeta.Name = "check_Tarjeta";
            this.check_Tarjeta.Size = new System.Drawing.Size(20, 20);
            this.check_Tarjeta.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(51, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Efectivo";
            // 
            // check_Efectivo
            // 
            this.check_Efectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_Efectivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_Efectivo.Checked = true;
            this.check_Efectivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_Efectivo.ForeColor = System.Drawing.Color.White;
            this.check_Efectivo.Location = new System.Drawing.Point(24, 243);
            this.check_Efectivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_Efectivo.Name = "check_Efectivo";
            this.check_Efectivo.Size = new System.Drawing.Size(20, 20);
            this.check_Efectivo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(19, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Método de pago";
            // 
            // lbl_TotalAPagar
            // 
            this.lbl_TotalAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalAPagar.AutoSize = true;
            this.lbl_TotalAPagar.BackColor = System.Drawing.Color.White;
            this.lbl_TotalAPagar.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_TotalAPagar.Location = new System.Drawing.Point(277, 120);
            this.lbl_TotalAPagar.Name = "lbl_TotalAPagar";
            this.lbl_TotalAPagar.Size = new System.Drawing.Size(56, 25);
            this.lbl_TotalAPagar.TabIndex = 5;
            this.lbl_TotalAPagar.Text = "$0.00";
            // 
            // lbl_Ruta
            // 
            this.lbl_Ruta.AutoSize = true;
            this.lbl_Ruta.BackColor = System.Drawing.Color.White;
            this.lbl_Ruta.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ruta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Ruta.Location = new System.Drawing.Point(19, 120);
            this.lbl_Ruta.Name = "lbl_Ruta";
            this.lbl_Ruta.Size = new System.Drawing.Size(129, 25);
            this.lbl_Ruta.TabIndex = 4;
            this.lbl_Ruta.Text = "Total a pagar";
            // 
            // lbl_Atajos
            // 
            this.lbl_Atajos.AutoSize = true;
            this.lbl_Atajos.BackColor = System.Drawing.Color.White;
            this.lbl_Atajos.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Atajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Atajos.Location = new System.Drawing.Point(18, 33);
            this.lbl_Atajos.Name = "lbl_Atajos";
            this.lbl_Atajos.Size = new System.Drawing.Size(85, 32);
            this.lbl_Atajos.TabIndex = 2;
            this.lbl_Atajos.Text = "Cobro";
            // 
            // lbl_DescAtajos
            // 
            this.lbl_DescAtajos.AutoSize = true;
            this.lbl_DescAtajos.BackColor = System.Drawing.Color.White;
            this.lbl_DescAtajos.Location = new System.Drawing.Point(20, 64);
            this.lbl_DescAtajos.Name = "lbl_DescAtajos";
            this.lbl_DescAtajos.Size = new System.Drawing.Size(313, 23);
            this.lbl_DescAtajos.TabIndex = 3;
            this.lbl_DescAtajos.Text = "Añade el pago de la compra del cliente.";
            // 
            // pnl_Notificaciones
            // 
            this.pnl_Notificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Notificaciones.BorderRadius = 10;
            this.pnl_Notificaciones.Controls.Add(this.dgv_TablaVentas);
            this.pnl_Notificaciones.Controls.Add(this.btn_CambiarRuta);
            this.pnl_Notificaciones.Controls.Add(this.label1);
            this.pnl_Notificaciones.Controls.Add(this.guna2TextBox1);
            this.pnl_Notificaciones.Controls.Add(this.btn_Tablero);
            this.pnl_Notificaciones.Controls.Add(this.lbl_SueldoCajeros);
            this.pnl_Notificaciones.Controls.Add(this.tb_SueldoCajeros);
            this.pnl_Notificaciones.Controls.Add(this.lbl_Notificaciones);
            this.pnl_Notificaciones.Controls.Add(this.lbl_DescNoti);
            this.pnl_Notificaciones.FillColor = System.Drawing.Color.White;
            this.pnl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Notificaciones.Location = new System.Drawing.Point(3, 3);
            this.pnl_Notificaciones.Name = "pnl_Notificaciones";
            this.pnl_Notificaciones.ShadowDecoration.Parent = this.pnl_Notificaciones;
            this.pnl_Notificaciones.Size = new System.Drawing.Size(800, 809);
            this.pnl_Notificaciones.TabIndex = 1;
            // 
            // dgv_TablaVentas
            // 
            this.dgv_TablaVentas.AllowUserToAddRows = false;
            this.dgv_TablaVentas.AllowUserToDeleteRows = false;
            this.dgv_TablaVentas.AllowUserToResizeColumns = false;
            this.dgv_TablaVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TablaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TablaVentas.ColumnHeadersHeight = 35;
            this.dgv_TablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_menos,
            this.col_Cantidad,
            this.col_mas,
            this.col_Descripcion,
            this.col_Precio,
            this.col_Subtotal,
            this.col_Codigo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TablaVentas.EnableHeadersVisualStyles = false;
            this.dgv_TablaVentas.GridColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.Location = new System.Drawing.Point(24, 201);
            this.dgv_TablaVentas.Name = "dgv_TablaVentas";
            this.dgv_TablaVentas.ReadOnly = true;
            this.dgv_TablaVentas.RowHeadersVisible = false;
            this.dgv_TablaVentas.RowHeadersWidth = 51;
            this.dgv_TablaVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaVentas.RowTemplate.Height = 35;
            this.dgv_TablaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaVentas.Size = new System.Drawing.Size(752, 583);
            this.dgv_TablaVentas.TabIndex = 14;
            this.dgv_TablaVentas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaVentas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TablaVentas.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaVentas.ThemeStyle.ReadOnly = true;
            this.dgv_TablaVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaVentas.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // col_menos
            // 
            this.col_menos.HeaderText = "";
            this.col_menos.Image = ((System.Drawing.Image)(resources.GetObject("col_menos.Image")));
            this.col_menos.MinimumWidth = 6;
            this.col_menos.Name = "col_menos";
            this.col_menos.ReadOnly = true;
            this.col_menos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_Cantidad
            // 
            this.col_Cantidad.HeaderText = "Cantidad";
            this.col_Cantidad.MinimumWidth = 6;
            this.col_Cantidad.Name = "col_Cantidad";
            this.col_Cantidad.ReadOnly = true;
            // 
            // col_mas
            // 
            this.col_mas.HeaderText = "";
            this.col_mas.Image = ((System.Drawing.Image)(resources.GetObject("col_mas.Image")));
            this.col_mas.MinimumWidth = 6;
            this.col_mas.Name = "col_mas";
            this.col_mas.ReadOnly = true;
            this.col_mas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_mas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.MinimumWidth = 6;
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
            // 
            // col_Precio
            // 
            this.col_Precio.HeaderText = "Precio";
            this.col_Precio.MinimumWidth = 6;
            this.col_Precio.Name = "col_Precio";
            this.col_Precio.ReadOnly = true;
            // 
            // col_Subtotal
            // 
            this.col_Subtotal.HeaderText = "Subtotal";
            this.col_Subtotal.MinimumWidth = 6;
            this.col_Subtotal.Name = "col_Subtotal";
            this.col_Subtotal.ReadOnly = true;
            // 
            // col_Codigo
            // 
            this.col_Codigo.HeaderText = "Código";
            this.col_Codigo.MinimumWidth = 6;
            this.col_Codigo.Name = "col_Codigo";
            this.col_Codigo.ReadOnly = true;
            this.col_Codigo.Visible = false;
            // 
            // btn_CambiarRuta
            // 
            this.btn_CambiarRuta.BorderRadius = 5;
            this.btn_CambiarRuta.CheckedState.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.CustomImages.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CambiarRuta.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CambiarRuta.ForeColor = System.Drawing.Color.White;
            this.btn_CambiarRuta.HoverState.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.Location = new System.Drawing.Point(472, 132);
            this.btn_CambiarRuta.Name = "btn_CambiarRuta";
            this.btn_CambiarRuta.ShadowDecoration.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.Size = new System.Drawing.Size(152, 40);
            this.btn_CambiarRuta.TabIndex = 13;
            this.btn_CambiarRuta.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(339, 132);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(126, 40);
            this.guna2TextBox1.TabIndex = 11;
            // 
            // btn_Tablero
            // 
            this.btn_Tablero.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tablero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.btn_Tablero.BorderRadius = 5;
            this.btn_Tablero.BorderThickness = 1;
            this.btn_Tablero.CheckedState.Parent = this.btn_Tablero;
            this.btn_Tablero.CustomImages.Parent = this.btn_Tablero;
            this.btn_Tablero.FillColor = System.Drawing.Color.White;
            this.btn_Tablero.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tablero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Tablero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Tablero.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Tablero.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Tablero.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tablero.HoverState.Image")));
            this.btn_Tablero.HoverState.Parent = this.btn_Tablero;
            this.btn_Tablero.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tablero.Image")));
            this.btn_Tablero.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Tablero.Location = new System.Drawing.Point(24, 132);
            this.btn_Tablero.Name = "btn_Tablero";
            this.btn_Tablero.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Tablero.ShadowDecoration.Parent = this.btn_Tablero;
            this.btn_Tablero.Size = new System.Drawing.Size(40, 40);
            this.btn_Tablero.TabIndex = 10;
            this.btn_Tablero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Tablero.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // lbl_SueldoCajeros
            // 
            this.lbl_SueldoCajeros.AutoSize = true;
            this.lbl_SueldoCajeros.BackColor = System.Drawing.Color.White;
            this.lbl_SueldoCajeros.Location = new System.Drawing.Point(68, 104);
            this.lbl_SueldoCajeros.Name = "lbl_SueldoCajeros";
            this.lbl_SueldoCajeros.Size = new System.Drawing.Size(141, 23);
            this.lbl_SueldoCajeros.TabIndex = 9;
            this.lbl_SueldoCajeros.Text = "Código de barras";
            // 
            // tb_SueldoCajeros
            // 
            this.tb_SueldoCajeros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_SueldoCajeros.BorderRadius = 5;
            this.tb_SueldoCajeros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SueldoCajeros.DefaultText = "";
            this.tb_SueldoCajeros.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SueldoCajeros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SueldoCajeros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SueldoCajeros.DisabledState.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SueldoCajeros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SueldoCajeros.FocusedState.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SueldoCajeros.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SueldoCajeros.HoverState.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.Location = new System.Drawing.Point(71, 132);
            this.tb_SueldoCajeros.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SueldoCajeros.Name = "tb_SueldoCajeros";
            this.tb_SueldoCajeros.PasswordChar = '\0';
            this.tb_SueldoCajeros.PlaceholderText = "";
            this.tb_SueldoCajeros.SelectedText = "";
            this.tb_SueldoCajeros.ShadowDecoration.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.Size = new System.Drawing.Size(260, 40);
            this.tb_SueldoCajeros.TabIndex = 8;
            // 
            // lbl_Notificaciones
            // 
            this.lbl_Notificaciones.AutoSize = true;
            this.lbl_Notificaciones.BackColor = System.Drawing.Color.White;
            this.lbl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Notificaciones.Location = new System.Drawing.Point(18, 33);
            this.lbl_Notificaciones.Name = "lbl_Notificaciones";
            this.lbl_Notificaciones.Size = new System.Drawing.Size(223, 32);
            this.lbl_Notificaciones.TabIndex = 4;
            this.lbl_Notificaciones.Text = "Carrito de compra";
            // 
            // lbl_DescNoti
            // 
            this.lbl_DescNoti.AutoSize = true;
            this.lbl_DescNoti.BackColor = System.Drawing.Color.White;
            this.lbl_DescNoti.Location = new System.Drawing.Point(20, 64);
            this.lbl_DescNoti.Name = "lbl_DescNoti";
            this.lbl_DescNoti.Size = new System.Drawing.Size(408, 23);
            this.lbl_DescNoti.TabIndex = 5;
            this.lbl_DescNoti.Text = "Añade los productos del cliente a la lista de compra.";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 839);
            this.Controls.Add(this.tlp_PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.tlp_PanelSuperior.ResumeLayout(false);
            this.pnl_Atajos.ResumeLayout(false);
            this.pnl_Atajos.PerformLayout();
            this.pnl_Notificaciones.ResumeLayout(false);
            this.pnl_Notificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_PanelSuperior;
        private Guna.UI2.WinForms.Guna2Panel pnl_Atajos;
        private System.Windows.Forms.Label lbl_Atajos;
        private System.Windows.Forms.Label lbl_DescAtajos;
        private Guna.UI2.WinForms.Guna2Panel pnl_Notificaciones;
        private System.Windows.Forms.Label lbl_Notificaciones;
        private System.Windows.Forms.Label lbl_DescNoti;
        private System.Windows.Forms.Label lbl_SueldoCajeros;
        private Guna.UI2.WinForms.Guna2TextBox tb_SueldoCajeros;
        private Guna.UI2.WinForms.Guna2Button btn_Tablero;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btn_CambiarRuta;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_TablaVentas;
        private System.Windows.Forms.DataGridViewImageColumn col_menos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn col_mas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Codigo;
        private System.Windows.Forms.Label lbl_Ruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TotalAPagar;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox check_Tarjeta;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox check_Efectivo;
        private Guna.UI2.WinForms.Guna2Button btn_CancelarVenta;
        private Guna.UI2.WinForms.Guna2Button btn_CompletarVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tb_Efectivo;
        private System.Windows.Forms.Label label6;
    }
}