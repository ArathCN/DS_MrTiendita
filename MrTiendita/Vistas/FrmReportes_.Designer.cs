﻿
namespace MrTiendita.Vistas
{
    partial class FrmReportes_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlp_Display = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_MenuProductos = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_EntradasAlmacen = new System.Windows.Forms.Panel();
            this.dp_HastaEntradas = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dp_DesdeEntradas = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_Hasta2 = new System.Windows.Forms.Label();
            this.lbl_Desde2 = new System.Windows.Forms.Label();
            this.lbl_Seleccione2 = new System.Windows.Forms.Label();
            this.lbl_EsteMesEntradas = new System.Windows.Forms.Label();
            this.lbl_EstaSemanaEntradas = new System.Windows.Forms.Label();
            this.lbl_HoyEntradas = new System.Windows.Forms.Label();
            this.dgv_TablaEntradas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_Titulo2 = new System.Windows.Forms.Label();
            this.lbl_Desc2 = new System.Windows.Forms.Label();
            this.pnl_Ventas = new System.Windows.Forms.Panel();
            this.dp_HastaVentas = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dp_DesdeVentas = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.lbl_Seleccione = new System.Windows.Forms.Label();
            this.lbl_EsteMesVentas = new System.Windows.Forms.Label();
            this.lbl_EstaSemanaVentas = new System.Windows.Forms.Label();
            this.lbl_HoyVentas = new System.Windows.Forms.Label();
            this.dgv_TablaReporteVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.btn_Entradas = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ventas = new Guna.UI2.WinForms.Guna2Button();
            this.Separador = new Guna.UI.WinForms.GunaLineTextBox();
            this.col_IDEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CodigoBarrasEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DescripcionEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CantidadEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ImporteEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_Display.SuspendLayout();
            this.pnl_MenuProductos.SuspendLayout();
            this.pnl_EntradasAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaEntradas)).BeginInit();
            this.pnl_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Display
            // 
            this.tlp_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Display.ColumnCount = 1;
            this.tlp_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.Controls.Add(this.pnl_MenuProductos, 0, 0);
            this.tlp_Display.Location = new System.Drawing.Point(12, 14);
            this.tlp_Display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_Display.Name = "tlp_Display";
            this.tlp_Display.RowCount = 1;
            this.tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.Size = new System.Drawing.Size(1171, 722);
            this.tlp_Display.TabIndex = 6;
            // 
            // pnl_MenuProductos
            // 
            this.pnl_MenuProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuProductos.BorderRadius = 10;
            this.pnl_MenuProductos.Controls.Add(this.pnl_EntradasAlmacen);
            this.pnl_MenuProductos.Controls.Add(this.pnl_Ventas);
            this.pnl_MenuProductos.Controls.Add(this.btn_Entradas);
            this.pnl_MenuProductos.Controls.Add(this.btn_Ventas);
            this.pnl_MenuProductos.Controls.Add(this.Separador);
            this.pnl_MenuProductos.FillColor = System.Drawing.Color.White;
            this.pnl_MenuProductos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MenuProductos.Location = new System.Drawing.Point(3, 2);
            this.pnl_MenuProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_MenuProductos.Name = "pnl_MenuProductos";
            this.pnl_MenuProductos.ShadowDecoration.Parent = this.pnl_MenuProductos;
            this.pnl_MenuProductos.Size = new System.Drawing.Size(1165, 718);
            this.pnl_MenuProductos.TabIndex = 1;
            // 
            // pnl_EntradasAlmacen
            // 
            this.pnl_EntradasAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_EntradasAlmacen.AutoScroll = true;
            this.pnl_EntradasAlmacen.BackColor = System.Drawing.Color.White;
            this.pnl_EntradasAlmacen.Controls.Add(this.dp_HastaEntradas);
            this.pnl_EntradasAlmacen.Controls.Add(this.dp_DesdeEntradas);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_Hasta2);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_Desde2);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_Seleccione2);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_EsteMesEntradas);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_EstaSemanaEntradas);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_HoyEntradas);
            this.pnl_EntradasAlmacen.Controls.Add(this.dgv_TablaEntradas);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_Titulo2);
            this.pnl_EntradasAlmacen.Controls.Add(this.lbl_Desc2);
            this.pnl_EntradasAlmacen.Location = new System.Drawing.Point(19, 75);
            this.pnl_EntradasAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_EntradasAlmacen.Name = "pnl_EntradasAlmacen";
            this.pnl_EntradasAlmacen.Size = new System.Drawing.Size(1133, 625);
            this.pnl_EntradasAlmacen.TabIndex = 70;
            // 
            // dp_HastaEntradas
            // 
            this.dp_HastaEntradas.BackColor = System.Drawing.Color.Transparent;
            this.dp_HastaEntradas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_HastaEntradas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_HastaEntradas.BorderSize = 1;
            this.dp_HastaEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dp_HastaEntradas.CustomFormat = null;
            this.dp_HastaEntradas.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_HastaEntradas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_HastaEntradas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_HastaEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_HastaEntradas.Location = new System.Drawing.Point(344, 143);
            this.dp_HastaEntradas.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dp_HastaEntradas.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dp_HastaEntradas.Name = "dp_HastaEntradas";
            this.dp_HastaEntradas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_HastaEntradas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_HastaEntradas.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_HastaEntradas.OnPressedColor = System.Drawing.Color.Gray;
            this.dp_HastaEntradas.OnPressedDepth = 5;
            this.dp_HastaEntradas.Radius = 5;
            this.dp_HastaEntradas.Size = new System.Drawing.Size(299, 35);
            this.dp_HastaEntradas.TabIndex = 69;
            this.dp_HastaEntradas.Text = "lunes, 2 de mayo de 2022";
            this.dp_HastaEntradas.Value = new System.DateTime(2022, 5, 2, 19, 6, 34, 315);
            // 
            // dp_DesdeEntradas
            // 
            this.dp_DesdeEntradas.BackColor = System.Drawing.Color.Transparent;
            this.dp_DesdeEntradas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_DesdeEntradas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_DesdeEntradas.BorderSize = 1;
            this.dp_DesdeEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dp_DesdeEntradas.CustomFormat = null;
            this.dp_DesdeEntradas.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_DesdeEntradas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_DesdeEntradas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_DesdeEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_DesdeEntradas.Location = new System.Drawing.Point(18, 143);
            this.dp_DesdeEntradas.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dp_DesdeEntradas.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dp_DesdeEntradas.Name = "dp_DesdeEntradas";
            this.dp_DesdeEntradas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_DesdeEntradas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_DesdeEntradas.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_DesdeEntradas.OnPressedColor = System.Drawing.Color.Gray;
            this.dp_DesdeEntradas.OnPressedDepth = 5;
            this.dp_DesdeEntradas.Radius = 5;
            this.dp_DesdeEntradas.Size = new System.Drawing.Size(299, 35);
            this.dp_DesdeEntradas.TabIndex = 68;
            this.dp_DesdeEntradas.Text = "lunes, 2 de mayo de 2022";
            this.dp_DesdeEntradas.Value = new System.DateTime(2022, 5, 2, 19, 6, 34, 315);
            // 
            // lbl_Hasta2
            // 
            this.lbl_Hasta2.AutoSize = true;
            this.lbl_Hasta2.BackColor = System.Drawing.Color.White;
            this.lbl_Hasta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Hasta2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Hasta2.Location = new System.Drawing.Point(340, 114);
            this.lbl_Hasta2.Name = "lbl_Hasta2";
            this.lbl_Hasta2.Size = new System.Drawing.Size(50, 20);
            this.lbl_Hasta2.TabIndex = 67;
            this.lbl_Hasta2.Text = "Hasta:";
            // 
            // lbl_Desde2
            // 
            this.lbl_Desde2.AutoSize = true;
            this.lbl_Desde2.BackColor = System.Drawing.Color.White;
            this.lbl_Desde2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Desde2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desde2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Desde2.Location = new System.Drawing.Point(14, 114);
            this.lbl_Desde2.Name = "lbl_Desde2";
            this.lbl_Desde2.Size = new System.Drawing.Size(54, 20);
            this.lbl_Desde2.TabIndex = 66;
            this.lbl_Desde2.Text = "Desde:";
            // 
            // lbl_Seleccione2
            // 
            this.lbl_Seleccione2.AutoSize = true;
            this.lbl_Seleccione2.BackColor = System.Drawing.Color.White;
            this.lbl_Seleccione2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Seleccione2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Seleccione2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Seleccione2.Location = new System.Drawing.Point(14, 84);
            this.lbl_Seleccione2.Name = "lbl_Seleccione2";
            this.lbl_Seleccione2.Size = new System.Drawing.Size(233, 20);
            this.lbl_Seleccione2.TabIndex = 65;
            this.lbl_Seleccione2.Text = "Seleccione un período de tiempo:";
            // 
            // lbl_EsteMesEntradas
            // 
            this.lbl_EsteMesEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EsteMesEntradas.AutoSize = true;
            this.lbl_EsteMesEntradas.BackColor = System.Drawing.Color.White;
            this.lbl_EsteMesEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EsteMesEntradas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsteMesEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_EsteMesEntradas.Location = new System.Drawing.Point(1046, 158);
            this.lbl_EsteMesEntradas.Name = "lbl_EsteMesEntradas";
            this.lbl_EsteMesEntradas.Size = new System.Drawing.Size(67, 20);
            this.lbl_EsteMesEntradas.TabIndex = 62;
            this.lbl_EsteMesEntradas.Text = "Este mes";
            // 
            // lbl_EstaSemanaEntradas
            // 
            this.lbl_EstaSemanaEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EstaSemanaEntradas.AutoSize = true;
            this.lbl_EstaSemanaEntradas.BackColor = System.Drawing.Color.White;
            this.lbl_EstaSemanaEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EstaSemanaEntradas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstaSemanaEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_EstaSemanaEntradas.Location = new System.Drawing.Point(939, 158);
            this.lbl_EstaSemanaEntradas.Name = "lbl_EstaSemanaEntradas";
            this.lbl_EstaSemanaEntradas.Size = new System.Drawing.Size(91, 20);
            this.lbl_EstaSemanaEntradas.TabIndex = 61;
            this.lbl_EstaSemanaEntradas.Text = "Esta semana";
            // 
            // lbl_HoyEntradas
            // 
            this.lbl_HoyEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HoyEntradas.AutoSize = true;
            this.lbl_HoyEntradas.BackColor = System.Drawing.Color.White;
            this.lbl_HoyEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_HoyEntradas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoyEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_HoyEntradas.Location = new System.Drawing.Point(887, 158);
            this.lbl_HoyEntradas.Name = "lbl_HoyEntradas";
            this.lbl_HoyEntradas.Size = new System.Drawing.Size(36, 20);
            this.lbl_HoyEntradas.TabIndex = 60;
            this.lbl_HoyEntradas.Text = "Hoy";
            // 
            // dgv_TablaEntradas
            // 
            this.dgv_TablaEntradas.AllowUserToAddRows = false;
            this.dgv_TablaEntradas.AllowUserToDeleteRows = false;
            this.dgv_TablaEntradas.AllowUserToResizeColumns = false;
            this.dgv_TablaEntradas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TablaEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaEntradas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TablaEntradas.ColumnHeadersHeight = 35;
            this.dgv_TablaEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDEntrada,
            this.col_CodigoBarrasEntrada,
            this.col_DescripcionEntrada,
            this.col_CantidadEntrada,
            this.col_FechaEntrada,
            this.col_PrecioCompra,
            this.col_PrecioVenta,
            this.col_ImporteEntrada});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaEntradas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TablaEntradas.EnableHeadersVisualStyles = false;
            this.dgv_TablaEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaEntradas.Location = new System.Drawing.Point(18, 198);
            this.dgv_TablaEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TablaEntradas.Name = "dgv_TablaEntradas";
            this.dgv_TablaEntradas.ReadOnly = true;
            this.dgv_TablaEntradas.RowHeadersVisible = false;
            this.dgv_TablaEntradas.RowHeadersWidth = 65;
            this.dgv_TablaEntradas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaEntradas.RowTemplate.Height = 35;
            this.dgv_TablaEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaEntradas.Size = new System.Drawing.Size(1095, 392);
            this.dgv_TablaEntradas.TabIndex = 16;
            this.dgv_TablaEntradas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaEntradas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaEntradas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaEntradas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaEntradas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaEntradas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaEntradas.ThemeStyle.ReadOnly = true;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // lbl_Titulo2
            // 
            this.lbl_Titulo2.AutoSize = true;
            this.lbl_Titulo2.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Titulo2.Location = new System.Drawing.Point(12, 12);
            this.lbl_Titulo2.Name = "lbl_Titulo2";
            this.lbl_Titulo2.Size = new System.Drawing.Size(398, 32);
            this.lbl_Titulo2.TabIndex = 4;
            this.lbl_Titulo2.Text = "Reporte de entradas al inventario";
            // 
            // lbl_Desc2
            // 
            this.lbl_Desc2.AutoSize = true;
            this.lbl_Desc2.BackColor = System.Drawing.Color.White;
            this.lbl_Desc2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Desc2.Location = new System.Drawing.Point(13, 43);
            this.lbl_Desc2.Name = "lbl_Desc2";
            this.lbl_Desc2.Size = new System.Drawing.Size(578, 23);
            this.lbl_Desc2.TabIndex = 5;
            this.lbl_Desc2.Text = "Consulta las entradas de productos al inventario en un período de tiempo.";
            // 
            // pnl_Ventas
            // 
            this.pnl_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Ventas.AutoScroll = true;
            this.pnl_Ventas.BackColor = System.Drawing.Color.White;
            this.pnl_Ventas.Controls.Add(this.dp_HastaVentas);
            this.pnl_Ventas.Controls.Add(this.dp_DesdeVentas);
            this.pnl_Ventas.Controls.Add(this.lbl_Hasta);
            this.pnl_Ventas.Controls.Add(this.lbl_Desde);
            this.pnl_Ventas.Controls.Add(this.lbl_Seleccione);
            this.pnl_Ventas.Controls.Add(this.lbl_EsteMesVentas);
            this.pnl_Ventas.Controls.Add(this.lbl_EstaSemanaVentas);
            this.pnl_Ventas.Controls.Add(this.lbl_HoyVentas);
            this.pnl_Ventas.Controls.Add(this.dgv_TablaReporteVentas);
            this.pnl_Ventas.Controls.Add(this.lbl_Titulo);
            this.pnl_Ventas.Controls.Add(this.lbl_Descripcion);
            this.pnl_Ventas.Location = new System.Drawing.Point(19, 75);
            this.pnl_Ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Ventas.Name = "pnl_Ventas";
            this.pnl_Ventas.Size = new System.Drawing.Size(1133, 625);
            this.pnl_Ventas.TabIndex = 0;
            // 
            // dp_HastaVentas
            // 
            this.dp_HastaVentas.BackColor = System.Drawing.Color.Transparent;
            this.dp_HastaVentas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_HastaVentas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_HastaVentas.BorderSize = 1;
            this.dp_HastaVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dp_HastaVentas.CustomFormat = null;
            this.dp_HastaVentas.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_HastaVentas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_HastaVentas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_HastaVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_HastaVentas.Location = new System.Drawing.Point(344, 143);
            this.dp_HastaVentas.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dp_HastaVentas.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dp_HastaVentas.Name = "dp_HastaVentas";
            this.dp_HastaVentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_HastaVentas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_HastaVentas.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_HastaVentas.OnPressedColor = System.Drawing.Color.Gray;
            this.dp_HastaVentas.OnPressedDepth = 5;
            this.dp_HastaVentas.Radius = 5;
            this.dp_HastaVentas.Size = new System.Drawing.Size(299, 35);
            this.dp_HastaVentas.TabIndex = 69;
            this.dp_HastaVentas.Text = "lunes, 2 de mayo de 2022";
            this.dp_HastaVentas.Value = new System.DateTime(2022, 5, 2, 19, 6, 34, 315);
            // 
            // dp_DesdeVentas
            // 
            this.dp_DesdeVentas.BackColor = System.Drawing.Color.Transparent;
            this.dp_DesdeVentas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_DesdeVentas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_DesdeVentas.BorderSize = 1;
            this.dp_DesdeVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dp_DesdeVentas.CustomFormat = null;
            this.dp_DesdeVentas.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_DesdeVentas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dp_DesdeVentas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_DesdeVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_DesdeVentas.Location = new System.Drawing.Point(18, 143);
            this.dp_DesdeVentas.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dp_DesdeVentas.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dp_DesdeVentas.Name = "dp_DesdeVentas";
            this.dp_DesdeVentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_DesdeVentas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dp_DesdeVentas.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.dp_DesdeVentas.OnPressedColor = System.Drawing.Color.Gray;
            this.dp_DesdeVentas.OnPressedDepth = 5;
            this.dp_DesdeVentas.Radius = 5;
            this.dp_DesdeVentas.Size = new System.Drawing.Size(299, 35);
            this.dp_DesdeVentas.TabIndex = 68;
            this.dp_DesdeVentas.Text = "lunes, 2 de mayo de 2022";
            this.dp_DesdeVentas.Value = new System.DateTime(2022, 5, 2, 19, 6, 34, 315);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.Color.White;
            this.lbl_Hasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Hasta.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Hasta.Location = new System.Drawing.Point(340, 114);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(50, 20);
            this.lbl_Hasta.TabIndex = 67;
            this.lbl_Hasta.Text = "Hasta:";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.Color.White;
            this.lbl_Desde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Desde.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Desde.Location = new System.Drawing.Point(14, 114);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(54, 20);
            this.lbl_Desde.TabIndex = 66;
            this.lbl_Desde.Text = "Desde:";
            // 
            // lbl_Seleccione
            // 
            this.lbl_Seleccione.AutoSize = true;
            this.lbl_Seleccione.BackColor = System.Drawing.Color.White;
            this.lbl_Seleccione.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Seleccione.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Seleccione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Seleccione.Location = new System.Drawing.Point(14, 84);
            this.lbl_Seleccione.Name = "lbl_Seleccione";
            this.lbl_Seleccione.Size = new System.Drawing.Size(233, 20);
            this.lbl_Seleccione.TabIndex = 65;
            this.lbl_Seleccione.Text = "Seleccione un período de tiempo:";
            // 
            // lbl_EsteMesVentas
            // 
            this.lbl_EsteMesVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EsteMesVentas.AutoSize = true;
            this.lbl_EsteMesVentas.BackColor = System.Drawing.Color.White;
            this.lbl_EsteMesVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EsteMesVentas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsteMesVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_EsteMesVentas.Location = new System.Drawing.Point(1046, 158);
            this.lbl_EsteMesVentas.Name = "lbl_EsteMesVentas";
            this.lbl_EsteMesVentas.Size = new System.Drawing.Size(67, 20);
            this.lbl_EsteMesVentas.TabIndex = 62;
            this.lbl_EsteMesVentas.Text = "Este mes";
            // 
            // lbl_EstaSemanaVentas
            // 
            this.lbl_EstaSemanaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EstaSemanaVentas.AutoSize = true;
            this.lbl_EstaSemanaVentas.BackColor = System.Drawing.Color.White;
            this.lbl_EstaSemanaVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EstaSemanaVentas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstaSemanaVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_EstaSemanaVentas.Location = new System.Drawing.Point(939, 158);
            this.lbl_EstaSemanaVentas.Name = "lbl_EstaSemanaVentas";
            this.lbl_EstaSemanaVentas.Size = new System.Drawing.Size(91, 20);
            this.lbl_EstaSemanaVentas.TabIndex = 61;
            this.lbl_EstaSemanaVentas.Text = "Esta semana";
            // 
            // lbl_HoyVentas
            // 
            this.lbl_HoyVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HoyVentas.AutoSize = true;
            this.lbl_HoyVentas.BackColor = System.Drawing.Color.White;
            this.lbl_HoyVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_HoyVentas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoyVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_HoyVentas.Location = new System.Drawing.Point(887, 158);
            this.lbl_HoyVentas.Name = "lbl_HoyVentas";
            this.lbl_HoyVentas.Size = new System.Drawing.Size(36, 20);
            this.lbl_HoyVentas.TabIndex = 60;
            this.lbl_HoyVentas.Text = "Hoy";
            // 
            // dgv_TablaReporteVentas
            // 
            this.dgv_TablaReporteVentas.AllowUserToAddRows = false;
            this.dgv_TablaReporteVentas.AllowUserToDeleteRows = false;
            this.dgv_TablaReporteVentas.AllowUserToResizeColumns = false;
            this.dgv_TablaReporteVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_TablaReporteVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TablaReporteVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaReporteVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaReporteVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaReporteVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaReporteVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaReporteVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaReporteVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TablaReporteVentas.ColumnHeadersHeight = 35;
            this.dgv_TablaReporteVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDVenta,
            this.col_CodigoBarras,
            this.col_Descripcion,
            this.col_IDEmpleado,
            this.col_MetodoPago,
            this.col_Fecha,
            this.col_Cantidad,
            this.col_Importe,
            this.col_ID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaReporteVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TablaReporteVentas.EnableHeadersVisualStyles = false;
            this.dgv_TablaReporteVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaReporteVentas.Location = new System.Drawing.Point(18, 198);
            this.dgv_TablaReporteVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TablaReporteVentas.Name = "dgv_TablaReporteVentas";
            this.dgv_TablaReporteVentas.ReadOnly = true;
            this.dgv_TablaReporteVentas.RowHeadersVisible = false;
            this.dgv_TablaReporteVentas.RowHeadersWidth = 65;
            this.dgv_TablaReporteVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaReporteVentas.RowTemplate.Height = 35;
            this.dgv_TablaReporteVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaReporteVentas.Size = new System.Drawing.Size(1095, 408);
            this.dgv_TablaReporteVentas.TabIndex = 16;
            this.dgv_TablaReporteVentas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaReporteVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaReporteVentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaReporteVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaReporteVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaReporteVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaReporteVentas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaReporteVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaReporteVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaReporteVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaReporteVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.dgv_TablaReporteVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaReporteVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TablaReporteVentas.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaReporteVentas.ThemeStyle.ReadOnly = true;
            this.dgv_TablaReporteVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaReporteVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaReporteVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.dgv_TablaReporteVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaReporteVentas.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaReporteVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaReporteVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // col_IDVenta
            // 
            this.col_IDVenta.HeaderText = "#";
            this.col_IDVenta.MinimumWidth = 6;
            this.col_IDVenta.Name = "col_IDVenta";
            this.col_IDVenta.ReadOnly = true;
            // 
            // col_CodigoBarras
            // 
            this.col_CodigoBarras.HeaderText = "Código de barras";
            this.col_CodigoBarras.MinimumWidth = 6;
            this.col_CodigoBarras.Name = "col_CodigoBarras";
            this.col_CodigoBarras.ReadOnly = true;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripción";
            this.col_Descripcion.MinimumWidth = 6;
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
            // 
            // col_IDEmpleado
            // 
            this.col_IDEmpleado.HeaderText = "ID de empleado";
            this.col_IDEmpleado.MinimumWidth = 6;
            this.col_IDEmpleado.Name = "col_IDEmpleado";
            this.col_IDEmpleado.ReadOnly = true;
            // 
            // col_MetodoPago
            // 
            this.col_MetodoPago.HeaderText = "Método de pago";
            this.col_MetodoPago.MinimumWidth = 6;
            this.col_MetodoPago.Name = "col_MetodoPago";
            this.col_MetodoPago.ReadOnly = true;
            // 
            // col_Fecha
            // 
            this.col_Fecha.HeaderText = "Fecha";
            this.col_Fecha.MinimumWidth = 6;
            this.col_Fecha.Name = "col_Fecha";
            this.col_Fecha.ReadOnly = true;
            // 
            // col_Cantidad
            // 
            this.col_Cantidad.HeaderText = "Cantidad";
            this.col_Cantidad.MinimumWidth = 6;
            this.col_Cantidad.Name = "col_Cantidad";
            this.col_Cantidad.ReadOnly = true;
            // 
            // col_Importe
            // 
            this.col_Importe.HeaderText = "Importe";
            this.col_Importe.MinimumWidth = 6;
            this.col_Importe.Name = "col_Importe";
            this.col_Importe.ReadOnly = true;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Visible = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 12);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(222, 32);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Reporte de ventas";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Descripcion.Location = new System.Drawing.Point(13, 43);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(436, 23);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Consulta las ventas realizadas en un periodo de tiempo.";
            // 
            // btn_Entradas
            // 
            this.btn_Entradas.CheckedState.Parent = this.btn_Entradas;
            this.btn_Entradas.CustomImages.Parent = this.btn_Entradas;
            this.btn_Entradas.FillColor = System.Drawing.Color.White;
            this.btn_Entradas.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Entradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Entradas.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Entradas.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Entradas.HoverState.Parent = this.btn_Entradas;
            this.btn_Entradas.Location = new System.Drawing.Point(285, 7);
            this.btn_Entradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Entradas.Name = "btn_Entradas";
            this.btn_Entradas.PressedColor = System.Drawing.Color.White;
            this.btn_Entradas.ShadowDecoration.Parent = this.btn_Entradas;
            this.btn_Entradas.Size = new System.Drawing.Size(253, 46);
            this.btn_Entradas.TabIndex = 1;
            this.btn_Entradas.Text = "Entradas al inventario";
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.CheckedState.Parent = this.btn_Ventas;
            this.btn_Ventas.CustomImages.Parent = this.btn_Ventas;
            this.btn_Ventas.FillColor = System.Drawing.Color.White;
            this.btn_Ventas.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_Ventas.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Ventas.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Ventas.HoverState.Parent = this.btn_Ventas;
            this.btn_Ventas.Location = new System.Drawing.Point(13, 7);
            this.btn_Ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.PressedColor = System.Drawing.Color.White;
            this.btn_Ventas.ShadowDecoration.Parent = this.btn_Ventas;
            this.btn_Ventas.Size = new System.Drawing.Size(253, 46);
            this.btn_Ventas.TabIndex = 4;
            this.btn_Ventas.Text = "Ventas";
            // 
            // Separador
            // 
            this.Separador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Separador.BackColor = System.Drawing.Color.White;
            this.Separador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Separador.Enabled = false;
            this.Separador.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Separador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Separador.Location = new System.Drawing.Point(19, 27);
            this.Separador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Separador.Name = "Separador";
            this.Separador.PasswordChar = '\0';
            this.Separador.ReadOnly = true;
            this.Separador.SelectedText = "";
            this.Separador.Size = new System.Drawing.Size(1133, 37);
            this.Separador.TabIndex = 34;
            // 
            // col_IDEntrada
            // 
            this.col_IDEntrada.HeaderText = "#";
            this.col_IDEntrada.MinimumWidth = 6;
            this.col_IDEntrada.Name = "col_IDEntrada";
            this.col_IDEntrada.ReadOnly = true;
            // 
            // col_CodigoBarrasEntrada
            // 
            this.col_CodigoBarrasEntrada.HeaderText = "Código de barras";
            this.col_CodigoBarrasEntrada.MinimumWidth = 6;
            this.col_CodigoBarrasEntrada.Name = "col_CodigoBarrasEntrada";
            this.col_CodigoBarrasEntrada.ReadOnly = true;
            // 
            // col_DescripcionEntrada
            // 
            this.col_DescripcionEntrada.HeaderText = "Descripción";
            this.col_DescripcionEntrada.MinimumWidth = 6;
            this.col_DescripcionEntrada.Name = "col_DescripcionEntrada";
            this.col_DescripcionEntrada.ReadOnly = true;
            // 
            // col_CantidadEntrada
            // 
            this.col_CantidadEntrada.HeaderText = "Cantidad";
            this.col_CantidadEntrada.MinimumWidth = 6;
            this.col_CantidadEntrada.Name = "col_CantidadEntrada";
            this.col_CantidadEntrada.ReadOnly = true;
            // 
            // col_FechaEntrada
            // 
            this.col_FechaEntrada.HeaderText = "Fecha";
            this.col_FechaEntrada.MinimumWidth = 6;
            this.col_FechaEntrada.Name = "col_FechaEntrada";
            this.col_FechaEntrada.ReadOnly = true;
            // 
            // col_PrecioCompra
            // 
            this.col_PrecioCompra.HeaderText = "Precio de compra";
            this.col_PrecioCompra.MinimumWidth = 6;
            this.col_PrecioCompra.Name = "col_PrecioCompra";
            this.col_PrecioCompra.ReadOnly = true;
            // 
            // col_PrecioVenta
            // 
            this.col_PrecioVenta.HeaderText = "Precio de venta";
            this.col_PrecioVenta.MinimumWidth = 6;
            this.col_PrecioVenta.Name = "col_PrecioVenta";
            this.col_PrecioVenta.ReadOnly = true;
            // 
            // col_ImporteEntrada
            // 
            this.col_ImporteEntrada.HeaderText = "Importe";
            this.col_ImporteEntrada.MinimumWidth = 6;
            this.col_ImporteEntrada.Name = "col_ImporteEntrada";
            this.col_ImporteEntrada.ReadOnly = true;
            // 
            // FrmReportes_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 750);
            this.Controls.Add(this.tlp_Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes_";
            this.Text = "FrmReportes_";
            this.tlp_Display.ResumeLayout(false);
            this.pnl_MenuProductos.ResumeLayout(false);
            this.pnl_EntradasAlmacen.ResumeLayout(false);
            this.pnl_EntradasAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaEntradas)).EndInit();
            this.pnl_Ventas.ResumeLayout(false);
            this.pnl_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaReporteVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Display;
        public Guna.UI2.WinForms.Guna2Panel pnl_MenuProductos;
        public System.Windows.Forms.Panel pnl_Ventas;
        public System.Windows.Forms.Label lbl_Titulo;
        public System.Windows.Forms.Label lbl_Descripcion;
        public Guna.UI2.WinForms.Guna2Button btn_Entradas;
        public Guna.UI2.WinForms.Guna2Button btn_Ventas;
        private Guna.UI.WinForms.GunaLineTextBox Separador;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaReporteVentas;
        public System.Windows.Forms.Label lbl_EsteMesVentas;
        public System.Windows.Forms.Label lbl_EstaSemanaVentas;
        public System.Windows.Forms.Label lbl_HoyVentas;
        public System.Windows.Forms.Label lbl_Hasta;
        public System.Windows.Forms.Label lbl_Desde;
        public System.Windows.Forms.Label lbl_Seleccione;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        public Guna.UI.WinForms.GunaDateTimePicker dp_DesdeVentas;
        public Guna.UI.WinForms.GunaDateTimePicker dp_HastaVentas;
        public System.Windows.Forms.Panel pnl_EntradasAlmacen;
        public Guna.UI.WinForms.GunaDateTimePicker dp_HastaEntradas;
        public Guna.UI.WinForms.GunaDateTimePicker dp_DesdeEntradas;
        public System.Windows.Forms.Label lbl_Hasta2;
        public System.Windows.Forms.Label lbl_Desde2;
        public System.Windows.Forms.Label lbl_Seleccione2;
        public System.Windows.Forms.Label lbl_EsteMesEntradas;
        public System.Windows.Forms.Label lbl_EstaSemanaEntradas;
        public System.Windows.Forms.Label lbl_HoyEntradas;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaEntradas;
        public System.Windows.Forms.Label lbl_Titulo2;
        public System.Windows.Forms.Label lbl_Desc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CodigoBarrasEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DescripcionEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CantidadEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ImporteEntrada;
    }
}