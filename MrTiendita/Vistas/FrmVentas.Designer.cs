﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.tlp_PanelSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Atajos = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_CompletarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CancelarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Cambio = new System.Windows.Forms.Label();
            this.lbl_CambioDesc = new System.Windows.Forms.Label();
            this.lbl_EfetivoTb = new System.Windows.Forms.Label();
            this.tb_Efectivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Pago = new System.Windows.Forms.Label();
            this.lbl_Tarjeta = new System.Windows.Forms.Label();
            this.check_Tarjeta = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_Efectivo = new System.Windows.Forms.Label();
            this.check_Efectivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_Metodo = new System.Windows.Forms.Label();
            this.lbl_TotalAPagar = new System.Windows.Forms.Label();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            this.lbl_Atajos = new System.Windows.Forms.Label();
            this.lbl_DescAtajos = new System.Windows.Forms.Label();
            this.pnl_Notificaciones = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_TablaVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_menos = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mas = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.tb_Cantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Buscar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_CodigoBarras = new System.Windows.Forms.Label();
            this.tb_Codigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Notificaciones = new System.Windows.Forms.Label();
            this.lbl_DescNoti = new System.Windows.Forms.Label();
            this.lbl_ErrorCodigoBarras = new System.Windows.Forms.Label();
            this.lbl_ErrorCantidad = new System.Windows.Forms.Label();
            this.tlp_PanelSuperior.SuspendLayout();
            this.pnl_Atajos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tlp_PanelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.pnl_Atajos.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Atajos.Controls.Add(this.lbl_Cambio);
            this.pnl_Atajos.Controls.Add(this.lbl_CambioDesc);
            this.pnl_Atajos.Controls.Add(this.lbl_EfetivoTb);
            this.pnl_Atajos.Controls.Add(this.tb_Efectivo);
            this.pnl_Atajos.Controls.Add(this.lbl_Pago);
            this.pnl_Atajos.Controls.Add(this.lbl_Tarjeta);
            this.pnl_Atajos.Controls.Add(this.check_Tarjeta);
            this.pnl_Atajos.Controls.Add(this.lbl_Efectivo);
            this.pnl_Atajos.Controls.Add(this.check_Efectivo);
            this.pnl_Atajos.Controls.Add(this.lbl_Metodo);
            this.pnl_Atajos.Controls.Add(this.lbl_TotalAPagar);
            this.pnl_Atajos.Controls.Add(this.lbl_Ruta);
            this.pnl_Atajos.Controls.Add(this.lbl_Atajos);
            this.pnl_Atajos.Controls.Add(this.lbl_DescAtajos);
            this.pnl_Atajos.FillColor = System.Drawing.Color.White;
            this.pnl_Atajos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Atajos.Location = new System.Drawing.Point(814, 2);
            this.pnl_Atajos.Margin = new System.Windows.Forms.Padding(8, 2, 3, 2);
            this.pnl_Atajos.Name = "pnl_Atajos";
            this.pnl_Atajos.ShadowDecoration.Parent = this.pnl_Atajos;
            this.pnl_Atajos.Size = new System.Drawing.Size(354, 811);
            this.pnl_Atajos.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_CompletarVenta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_CancelarVenta, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-35, 549);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 39);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // btn_CompletarVenta
            // 
            this.btn_CompletarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CompletarVenta.BorderRadius = 5;
            this.btn_CompletarVenta.CheckedState.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.CustomImages.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CompletarVenta.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompletarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_CompletarVenta.HoverState.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.Location = new System.Drawing.Point(27, 2);
            this.btn_CompletarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CompletarVenta.Name = "btn_CompletarVenta";
            this.btn_CompletarVenta.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_CompletarVenta.ShadowDecoration.Parent = this.btn_CompletarVenta;
            this.btn_CompletarVenta.Size = new System.Drawing.Size(188, 34);
            this.btn_CompletarVenta.TabIndex = 28;
            this.btn_CompletarVenta.Text = "Completar venta";
            // 
            // btn_CancelarVenta
            // 
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
            this.btn_CancelarVenta.Location = new System.Drawing.Point(221, 2);
            this.btn_CancelarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CancelarVenta.Name = "btn_CancelarVenta";
            this.btn_CancelarVenta.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_CancelarVenta.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CancelarVenta.ShadowDecoration.Parent = this.btn_CancelarVenta;
            this.btn_CancelarVenta.Size = new System.Drawing.Size(188, 34);
            this.btn_CancelarVenta.TabIndex = 29;
            this.btn_CancelarVenta.Text = "Cancelar venta";
            // 
            // lbl_Cambio
            // 
            this.lbl_Cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Cambio.AutoSize = true;
            this.lbl_Cambio.BackColor = System.Drawing.Color.White;
            this.lbl_Cambio.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Cambio.Location = new System.Drawing.Point(276, 471);
            this.lbl_Cambio.Name = "lbl_Cambio";
            this.lbl_Cambio.Size = new System.Drawing.Size(56, 25);
            this.lbl_Cambio.TabIndex = 27;
            this.lbl_Cambio.Text = "$0.00";
            // 
            // lbl_CambioDesc
            // 
            this.lbl_CambioDesc.AutoSize = true;
            this.lbl_CambioDesc.BackColor = System.Drawing.Color.White;
            this.lbl_CambioDesc.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CambioDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_CambioDesc.Location = new System.Drawing.Point(20, 471);
            this.lbl_CambioDesc.Name = "lbl_CambioDesc";
            this.lbl_CambioDesc.Size = new System.Drawing.Size(80, 25);
            this.lbl_CambioDesc.TabIndex = 26;
            this.lbl_CambioDesc.Text = "Cambio";
            // 
            // lbl_EfetivoTb
            // 
            this.lbl_EfetivoTb.AutoSize = true;
            this.lbl_EfetivoTb.BackColor = System.Drawing.Color.White;
            this.lbl_EfetivoTb.Location = new System.Drawing.Point(21, 353);
            this.lbl_EfetivoTb.Name = "lbl_EfetivoTb";
            this.lbl_EfetivoTb.Size = new System.Drawing.Size(69, 23);
            this.lbl_EfetivoTb.TabIndex = 25;
            this.lbl_EfetivoTb.Text = "Efectivo";
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
            this.tb_Efectivo.Location = new System.Drawing.Point(24, 382);
            this.tb_Efectivo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_Efectivo.Name = "tb_Efectivo";
            this.tb_Efectivo.PasswordChar = '\0';
            this.tb_Efectivo.PlaceholderText = "";
            this.tb_Efectivo.SelectedText = "";
            this.tb_Efectivo.ShadowDecoration.Parent = this.tb_Efectivo;
            this.tb_Efectivo.Size = new System.Drawing.Size(260, 39);
            this.tb_Efectivo.TabIndex = 24;
            // 
            // lbl_Pago
            // 
            this.lbl_Pago.AutoSize = true;
            this.lbl_Pago.BackColor = System.Drawing.Color.White;
            this.lbl_Pago.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Pago.Location = new System.Drawing.Point(19, 311);
            this.lbl_Pago.Name = "lbl_Pago";
            this.lbl_Pago.Size = new System.Drawing.Size(58, 25);
            this.lbl_Pago.TabIndex = 23;
            this.lbl_Pago.Text = "Pago";
            // 
            // lbl_Tarjeta
            // 
            this.lbl_Tarjeta.AutoSize = true;
            this.lbl_Tarjeta.BackColor = System.Drawing.Color.White;
            this.lbl_Tarjeta.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Tarjeta.Location = new System.Drawing.Point(187, 240);
            this.lbl_Tarjeta.Name = "lbl_Tarjeta";
            this.lbl_Tarjeta.Size = new System.Drawing.Size(70, 25);
            this.lbl_Tarjeta.TabIndex = 22;
            this.lbl_Tarjeta.Text = "Tarjeta";
            // 
            // check_Tarjeta
            // 
            this.check_Tarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_Tarjeta.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_Tarjeta.Checked = false;
            this.check_Tarjeta.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_Tarjeta.ForeColor = System.Drawing.Color.White;
            this.check_Tarjeta.Location = new System.Drawing.Point(160, 242);
            this.check_Tarjeta.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.check_Tarjeta.Name = "check_Tarjeta";
            this.check_Tarjeta.Size = new System.Drawing.Size(20, 20);
            this.check_Tarjeta.TabIndex = 21;
            // 
            // lbl_Efectivo
            // 
            this.lbl_Efectivo.AutoSize = true;
            this.lbl_Efectivo.BackColor = System.Drawing.Color.White;
            this.lbl_Efectivo.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Efectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Efectivo.Location = new System.Drawing.Point(51, 240);
            this.lbl_Efectivo.Name = "lbl_Efectivo";
            this.lbl_Efectivo.Size = new System.Drawing.Size(78, 25);
            this.lbl_Efectivo.TabIndex = 20;
            this.lbl_Efectivo.Text = "Efectivo";
            // 
            // check_Efectivo
            // 
            this.check_Efectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_Efectivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_Efectivo.Checked = true;
            this.check_Efectivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_Efectivo.ForeColor = System.Drawing.Color.White;
            this.check_Efectivo.Location = new System.Drawing.Point(24, 242);
            this.check_Efectivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_Efectivo.Name = "check_Efectivo";
            this.check_Efectivo.Size = new System.Drawing.Size(20, 20);
            this.check_Efectivo.TabIndex = 19;
            // 
            // lbl_Metodo
            // 
            this.lbl_Metodo.AutoSize = true;
            this.lbl_Metodo.BackColor = System.Drawing.Color.White;
            this.lbl_Metodo.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Metodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Metodo.Location = new System.Drawing.Point(19, 201);
            this.lbl_Metodo.Name = "lbl_Metodo";
            this.lbl_Metodo.Size = new System.Drawing.Size(161, 25);
            this.lbl_Metodo.TabIndex = 6;
            this.lbl_Metodo.Text = "Método de pago";
            // 
            // lbl_TotalAPagar
            // 
            this.lbl_TotalAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalAPagar.AutoSize = true;
            this.lbl_TotalAPagar.BackColor = System.Drawing.Color.White;
            this.lbl_TotalAPagar.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_TotalAPagar.Location = new System.Drawing.Point(276, 121);
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
            this.lbl_Ruta.Location = new System.Drawing.Point(19, 121);
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
            this.lbl_Atajos.Location = new System.Drawing.Point(20, 33);
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
            this.pnl_Notificaciones.Controls.Add(this.lbl_ErrorCantidad);
            this.pnl_Notificaciones.Controls.Add(this.lbl_ErrorCodigoBarras);
            this.pnl_Notificaciones.Controls.Add(this.dgv_TablaVentas);
            this.pnl_Notificaciones.Controls.Add(this.btn_Agregar);
            this.pnl_Notificaciones.Controls.Add(this.lbl_Cantidad);
            this.pnl_Notificaciones.Controls.Add(this.tb_Cantidad);
            this.pnl_Notificaciones.Controls.Add(this.btn_Buscar);
            this.pnl_Notificaciones.Controls.Add(this.lbl_CodigoBarras);
            this.pnl_Notificaciones.Controls.Add(this.tb_Codigo);
            this.pnl_Notificaciones.Controls.Add(this.lbl_Notificaciones);
            this.pnl_Notificaciones.Controls.Add(this.lbl_DescNoti);
            this.pnl_Notificaciones.FillColor = System.Drawing.Color.White;
            this.pnl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Notificaciones.Location = new System.Drawing.Point(3, 2);
            this.pnl_Notificaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Notificaciones.Name = "pnl_Notificaciones";
            this.pnl_Notificaciones.ShadowDecoration.Parent = this.pnl_Notificaciones;
            this.pnl_Notificaciones.Size = new System.Drawing.Size(800, 811);
            this.pnl_Notificaciones.TabIndex = 1;
            // 
            // dgv_TablaVentas
            // 
            this.dgv_TablaVentas.AllowUserToAddRows = false;
            this.dgv_TablaVentas.AllowUserToDeleteRows = false;
            this.dgv_TablaVentas.AllowUserToResizeColumns = false;
            this.dgv_TablaVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TablaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TablaVentas.ColumnHeadersHeight = 35;
            this.dgv_TablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Codigo,
            this.col_menos,
            this.col_Cantidad,
            this.col_mas,
            this.col_Descripcion,
            this.col_Precio,
            this.col_Subtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TablaVentas.EnableHeadersVisualStyles = false;
            this.dgv_TablaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaVentas.Location = new System.Drawing.Point(24, 201);
            this.dgv_TablaVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dgv_TablaVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
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
            // col_Codigo
            // 
            this.col_Codigo.HeaderText = "Código";
            this.col_Codigo.MinimumWidth = 6;
            this.col_Codigo.Name = "col_Codigo";
            this.col_Codigo.ReadOnly = true;
            this.col_Codigo.Visible = false;
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
            // btn_Agregar
            // 
            this.btn_Agregar.BorderRadius = 5;
            this.btn_Agregar.CheckedState.Parent = this.btn_Agregar;
            this.btn_Agregar.CustomImages.Parent = this.btn_Agregar;
            this.btn_Agregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Agregar.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.HoverState.Parent = this.btn_Agregar;
            this.btn_Agregar.Location = new System.Drawing.Point(472, 132);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.ShadowDecoration.Parent = this.btn_Agregar;
            this.btn_Agregar.Size = new System.Drawing.Size(152, 39);
            this.btn_Agregar.TabIndex = 13;
            this.btn_Agregar.Text = "Agregar";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.BackColor = System.Drawing.Color.White;
            this.lbl_Cantidad.Location = new System.Drawing.Point(336, 103);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(79, 23);
            this.lbl_Cantidad.TabIndex = 12;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Cantidad.BorderRadius = 5;
            this.tb_Cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cantidad.DefaultText = "";
            this.tb_Cantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Cantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Cantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Cantidad.DisabledState.Parent = this.tb_Cantidad;
            this.tb_Cantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Cantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Cantidad.FocusedState.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Cantidad.HoverState.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Location = new System.Drawing.Point(339, 132);
            this.tb_Cantidad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_Cantidad.MaxLength = 6;
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.PasswordChar = '\0';
            this.tb_Cantidad.PlaceholderText = "";
            this.tb_Cantidad.SelectedText = "";
            this.tb_Cantidad.ShadowDecoration.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Size = new System.Drawing.Size(125, 39);
            this.tb_Cantidad.TabIndex = 11;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.btn_Buscar.BorderRadius = 5;
            this.btn_Buscar.BorderThickness = 1;
            this.btn_Buscar.CheckedState.Parent = this.btn_Buscar;
            this.btn_Buscar.CustomImages.Parent = this.btn_Buscar;
            this.btn_Buscar.FillColor = System.Drawing.Color.White;
            this.btn_Buscar.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Buscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Buscar.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Buscar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.HoverState.Image")));
            this.btn_Buscar.HoverState.Parent = this.btn_Buscar;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Buscar.Location = new System.Drawing.Point(24, 132);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Buscar.ShadowDecoration.Parent = this.btn_Buscar;
            this.btn_Buscar.Size = new System.Drawing.Size(40, 39);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Buscar.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // lbl_CodigoBarras
            // 
            this.lbl_CodigoBarras.AutoSize = true;
            this.lbl_CodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarras.Location = new System.Drawing.Point(68, 103);
            this.lbl_CodigoBarras.Name = "lbl_CodigoBarras";
            this.lbl_CodigoBarras.Size = new System.Drawing.Size(141, 23);
            this.lbl_CodigoBarras.TabIndex = 9;
            this.lbl_CodigoBarras.Text = "Código de barras";
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Codigo.BorderRadius = 5;
            this.tb_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Codigo.DefaultText = "";
            this.tb_Codigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Codigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Codigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Codigo.DisabledState.Parent = this.tb_Codigo;
            this.tb_Codigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Codigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Codigo.FocusedState.Parent = this.tb_Codigo;
            this.tb_Codigo.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Codigo.HoverState.Parent = this.tb_Codigo;
            this.tb_Codigo.Location = new System.Drawing.Point(71, 132);
            this.tb_Codigo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_Codigo.MaxLength = 13;
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.PasswordChar = '\0';
            this.tb_Codigo.PlaceholderText = "";
            this.tb_Codigo.SelectedText = "";
            this.tb_Codigo.ShadowDecoration.Parent = this.tb_Codigo;
            this.tb_Codigo.Size = new System.Drawing.Size(260, 39);
            this.tb_Codigo.TabIndex = 8;
            // 
            // lbl_Notificaciones
            // 
            this.lbl_Notificaciones.AutoSize = true;
            this.lbl_Notificaciones.BackColor = System.Drawing.Color.White;
            this.lbl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Notificaciones.Location = new System.Drawing.Point(20, 33);
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
            // lbl_ErrorCodigoBarras
            // 
            this.lbl_ErrorCodigoBarras.AutoSize = true;
            this.lbl_ErrorCodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_ErrorCodigoBarras.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorCodigoBarras.Location = new System.Drawing.Point(68, 171);
            this.lbl_ErrorCodigoBarras.Name = "lbl_ErrorCodigoBarras";
            this.lbl_ErrorCodigoBarras.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorCodigoBarras.TabIndex = 50;
            this.lbl_ErrorCodigoBarras.Text = "* Error";
            this.lbl_ErrorCodigoBarras.Visible = false;
            // 
            // lbl_ErrorCantidad
            // 
            this.lbl_ErrorCantidad.AutoSize = true;
            this.lbl_ErrorCantidad.BackColor = System.Drawing.Color.White;
            this.lbl_ErrorCantidad.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorCantidad.Location = new System.Drawing.Point(336, 171);
            this.lbl_ErrorCantidad.Name = "lbl_ErrorCantidad";
            this.lbl_ErrorCantidad.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorCantidad.TabIndex = 51;
            this.lbl_ErrorCantidad.Text = "* Error";
            this.lbl_ErrorCantidad.Visible = false;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 839);
            this.Controls.Add(this.tlp_PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.tlp_PanelSuperior.ResumeLayout(false);
            this.pnl_Atajos.ResumeLayout(false);
            this.pnl_Atajos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_Notificaciones.ResumeLayout(false);
            this.pnl_Notificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_PanelSuperior;
        private Guna.UI2.WinForms.Guna2Panel pnl_Atajos;
        private Guna.UI2.WinForms.Guna2Panel pnl_Notificaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lbl_Atajos;
        public System.Windows.Forms.Label lbl_DescAtajos;
        public System.Windows.Forms.Label lbl_Notificaciones;
        public System.Windows.Forms.Label lbl_DescNoti;
        public System.Windows.Forms.Label lbl_CodigoBarras;
        public Guna.UI2.WinForms.Guna2TextBox tb_Codigo;
        public Guna.UI2.WinForms.Guna2Button btn_Buscar;
        public System.Windows.Forms.Label lbl_Cantidad;
        public Guna.UI2.WinForms.Guna2TextBox tb_Cantidad;
        public Guna.UI2.WinForms.Guna2Button btn_Agregar;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaVentas;
        public System.Windows.Forms.Label lbl_Ruta;
        public System.Windows.Forms.Label lbl_Metodo;
        public System.Windows.Forms.Label lbl_TotalAPagar;
        public System.Windows.Forms.Label lbl_Tarjeta;
        public Bunifu.Framework.UI.BunifuCheckbox check_Tarjeta;
        public System.Windows.Forms.Label lbl_Efectivo;
        public Bunifu.Framework.UI.BunifuCheckbox check_Efectivo;
        public System.Windows.Forms.Label lbl_Cambio;
        public System.Windows.Forms.Label lbl_CambioDesc;
        public System.Windows.Forms.Label lbl_EfetivoTb;
        public Guna.UI2.WinForms.Guna2TextBox tb_Efectivo;
        public System.Windows.Forms.Label lbl_Pago;
        public Guna.UI2.WinForms.Guna2Button btn_CompletarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Codigo;
        private System.Windows.Forms.DataGridViewImageColumn col_menos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn col_mas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Subtotal;
        public Guna.UI2.WinForms.Guna2Button btn_CancelarVenta;
        public System.Windows.Forms.Label lbl_ErrorCantidad;
        public System.Windows.Forms.Label lbl_ErrorCodigoBarras;
    }
}