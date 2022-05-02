﻿
namespace MrTiendita.Vistas
{
    partial class FrmMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_ConsultarMovimientos = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_CorteCaja = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ConsultarMovimientos = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_TablaMovimientos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.cb_FiltroMovimientos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.col_TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_DisplayConsultar = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_MenuProductos = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ErrorCodigoBarras = new System.Windows.Forms.Label();
            this.btn_LimpiarEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_ErrorCantidad = new System.Windows.Forms.Label();
            this.btn_RegistrarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_ErrorProveedor = new System.Windows.Forms.Label();
            this.cb_Proveedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.tb_Cantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_NuevaEntrada = new System.Windows.Forms.Label();
            this.lbl_DescripcionNueva = new System.Windows.Forms.Label();
            this.lbl_CodigoBarra = new System.Windows.Forms.Label();
            this.tb_CodigoBarra = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_MenuSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ConsultarProductos = new System.Windows.Forms.Label();
            this.lbl_DescripcionConsultar = new System.Windows.Forms.Label();
            this.lbl_Hoy = new System.Windows.Forms.Label();
            this.lbl_EstaSemana = new System.Windows.Forms.Label();
            this.lbl_EsteMes = new System.Windows.Forms.Label();
            this.tlp_DisplayCorte = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_CorteCaja = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_DescCorte = new System.Windows.Forms.Label();
            this.lbl_CorteIniciado = new System.Windows.Forms.Label();
            this.lbl_FechaCorte = new System.Windows.Forms.Label();
            this.pb_VentasTotales = new System.Windows.Forms.PictureBox();
            this.lbl_DescVentasTotales = new System.Windows.Forms.Label();
            this.pnl_Totales = new System.Windows.Forms.Panel();
            this.lbl_VentasTotales = new System.Windows.Forms.Label();
            this.pb_GananciasTotales = new System.Windows.Forms.PictureBox();
            this.lbl_GananciasTotales = new System.Windows.Forms.Label();
            this.lbl_DescGanancias = new System.Windows.Forms.Label();
            this.pnl_VentasTotales = new System.Windows.Forms.Panel();
            this.pnl_GananciasTotales = new System.Windows.Forms.Panel();
            this.lbl_DescVentas = new System.Windows.Forms.Label();
            this.pb_Ventas = new System.Windows.Forms.PictureBox();
            this.lbl_DescVentasEfectivo = new System.Windows.Forms.Label();
            this.lbl_DescVentasTarjeta = new System.Windows.Forms.Label();
            this.lbl_VentasEfectivo = new System.Windows.Forms.Label();
            this.lbl_VentasTarjeta = new System.Windows.Forms.Label();
            this.pnl_VentasMetodos = new System.Windows.Forms.Panel();
            this.pnl_VentasCategoria = new System.Windows.Forms.Panel();
            this.pb_VentasCategoria = new System.Windows.Forms.PictureBox();
            this.lbl_DesVentasCategoria = new System.Windows.Forms.Label();
            this.pnl_CorteDesplegado = new System.Windows.Forms.Panel();
            this.Separador = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_DescRefrigerados = new System.Windows.Forms.Label();
            this.lbl_VentasRefrigerados = new System.Windows.Forms.Label();
            this.pb_Refrigerados = new System.Windows.Forms.PictureBox();
            this.lbl_DescSinCategoria = new System.Windows.Forms.Label();
            this.lbl_VentasSinCategoria = new System.Windows.Forms.Label();
            this.pb_SinCategoria = new System.Windows.Forms.PictureBox();
            this.lbl_DescPanaderia = new System.Windows.Forms.Label();
            this.lbl_DescFrutas = new System.Windows.Forms.Label();
            this.lbl_VentaFrutas = new System.Windows.Forms.Label();
            this.lbl_VentasPanaderia = new System.Windows.Forms.Label();
            this.lbl_DescCarniceria = new System.Windows.Forms.Label();
            this.lbl_DescLacteos = new System.Windows.Forms.Label();
            this.lbl_DescAbarrotes = new System.Windows.Forms.Label();
            this.lbl_DescLimpieza = new System.Windows.Forms.Label();
            this.lbl_Higiene = new System.Windows.Forms.Label();
            this.lbl_DescMascotas = new System.Windows.Forms.Label();
            this.lbl_VentasCarniceria = new System.Windows.Forms.Label();
            this.lbl_VentasLacteos = new System.Windows.Forms.Label();
            this.lbl_VentasAbarrotes = new System.Windows.Forms.Label();
            this.lbl_VentasLimpieza = new System.Windows.Forms.Label();
            this.lbl_VentasHigiene = new System.Windows.Forms.Label();
            this.lbl_VentasMascotas = new System.Windows.Forms.Label();
            this.pb_Frutas = new System.Windows.Forms.PictureBox();
            this.pb_Panaderia = new System.Windows.Forms.PictureBox();
            this.pb_Carniceria = new System.Windows.Forms.PictureBox();
            this.pb_Lacteos = new System.Windows.Forms.PictureBox();
            this.pb_Abarrotes = new System.Windows.Forms.PictureBox();
            this.pb_Limpieza = new System.Windows.Forms.PictureBox();
            this.pb_Higiene = new System.Windows.Forms.PictureBox();
            this.pb_Mascotas = new System.Windows.Forms.PictureBox();
            this.pnl_GananciasCategoria = new System.Windows.Forms.Panel();
            this.pb_SinCategoria2 = new System.Windows.Forms.PictureBox();
            this.lbl_GananciaSinCategoria = new System.Windows.Forms.Label();
            this.lbl_DescSinCategoria2 = new System.Windows.Forms.Label();
            this.pb_Refrigerados2 = new System.Windows.Forms.PictureBox();
            this.pb_Mascotas2 = new System.Windows.Forms.PictureBox();
            this.pb_Higiene2 = new System.Windows.Forms.PictureBox();
            this.pb_Limpieza2 = new System.Windows.Forms.PictureBox();
            this.pb_Abarrotes2 = new System.Windows.Forms.PictureBox();
            this.pb_Lacteos2 = new System.Windows.Forms.PictureBox();
            this.pb_Carniceria2 = new System.Windows.Forms.PictureBox();
            this.pb_Panaderia2 = new System.Windows.Forms.PictureBox();
            this.pb_Frutas2 = new System.Windows.Forms.PictureBox();
            this.lbl_GananciaRefrigerados = new System.Windows.Forms.Label();
            this.lbl_GananciaMascotas = new System.Windows.Forms.Label();
            this.lbl_GananciaHigiene = new System.Windows.Forms.Label();
            this.lbl_GananciaLimpieza = new System.Windows.Forms.Label();
            this.lbl_GananciaAbarrotes = new System.Windows.Forms.Label();
            this.lbl_GananciaLacteos = new System.Windows.Forms.Label();
            this.lbl_GananciaCarniceria = new System.Windows.Forms.Label();
            this.lbl_DescRefrigerados2 = new System.Windows.Forms.Label();
            this.lbl_DescMascotas2 = new System.Windows.Forms.Label();
            this.lbl_DescHigiene2 = new System.Windows.Forms.Label();
            this.lbl_DescLimpieza2 = new System.Windows.Forms.Label();
            this.lbl_DescAbarrotes2 = new System.Windows.Forms.Label();
            this.lbl_DescLacteos2 = new System.Windows.Forms.Label();
            this.lbl_DescCarniceria2 = new System.Windows.Forms.Label();
            this.pb_Categoria = new System.Windows.Forms.PictureBox();
            this.lbl_GananciaPanaderia = new System.Windows.Forms.Label();
            this.lbl_GananciasCategoria = new System.Windows.Forms.Label();
            this.lbl_GananciaFrutas = new System.Windows.Forms.Label();
            this.lbl_DescFrutas2 = new System.Windows.Forms.Label();
            this.lbl_DescPanaderia2 = new System.Windows.Forms.Label();
            this.pnl_Entradas = new System.Windows.Forms.Panel();
            this.pb_Entradas = new System.Windows.Forms.PictureBox();
            this.lbl_DescEntradas = new System.Windows.Forms.Label();
            this.lbl_EntradasTotales = new System.Windows.Forms.Label();
            this.lbl_DescEntradasTotales = new System.Windows.Forms.Label();
            this.pnl_Salidas = new System.Windows.Forms.Panel();
            this.pb_Salidas = new System.Windows.Forms.PictureBox();
            this.lbl_DescSalidas = new System.Windows.Forms.Label();
            this.lbl_SalidasTotales = new System.Windows.Forms.Label();
            this.lbl_DescSalidasTotales = new System.Windows.Forms.Label();
            this.dgv_TablaEntradas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_DescripcionCorteEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ImporteCorteEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_TablaSalidas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_DescripcionCorteSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ImporteCorteSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_GuardarArchivo = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_ConsultarMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaMovimientos)).BeginInit();
            this.tlp_DisplayConsultar.SuspendLayout();
            this.pnl_MenuProductos.SuspendLayout();
            this.pnl_MenuSuperior.SuspendLayout();
            this.tlp_DisplayCorte.SuspendLayout();
            this.pnl_CorteCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VentasTotales)).BeginInit();
            this.pnl_Totales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GananciasTotales)).BeginInit();
            this.pnl_VentasTotales.SuspendLayout();
            this.pnl_GananciasTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ventas)).BeginInit();
            this.pnl_VentasMetodos.SuspendLayout();
            this.pnl_VentasCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VentasCategoria)).BeginInit();
            this.pnl_CorteDesplegado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refrigerados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SinCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Frutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Panaderia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Carniceria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lacteos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Abarrotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Limpieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Higiene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mascotas)).BeginInit();
            this.pnl_GananciasCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SinCategoria2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refrigerados2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mascotas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Higiene2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Limpieza2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Abarrotes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lacteos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Carniceria2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Panaderia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Frutas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Categoria)).BeginInit();
            this.pnl_Entradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Entradas)).BeginInit();
            this.pnl_Salidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Salidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ConsultarMovimientos
            // 
            this.pnl_ConsultarMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ConsultarMovimientos.BorderRadius = 10;
            this.pnl_ConsultarMovimientos.Controls.Add(this.lbl_EsteMes);
            this.pnl_ConsultarMovimientos.Controls.Add(this.lbl_EstaSemana);
            this.pnl_ConsultarMovimientos.Controls.Add(this.lbl_Hoy);
            this.pnl_ConsultarMovimientos.Controls.Add(this.lbl_ConsultarProductos);
            this.pnl_ConsultarMovimientos.Controls.Add(this.lbl_DescripcionConsultar);
            this.pnl_ConsultarMovimientos.Controls.Add(this.cb_FiltroMovimientos);
            this.pnl_ConsultarMovimientos.Controls.Add(this.lbl_Producto);
            this.pnl_ConsultarMovimientos.Controls.Add(this.dgv_TablaMovimientos);
            this.pnl_ConsultarMovimientos.FillColor = System.Drawing.Color.White;
            this.pnl_ConsultarMovimientos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_ConsultarMovimientos.Location = new System.Drawing.Point(0, 2);
            this.pnl_ConsultarMovimientos.Margin = new System.Windows.Forms.Padding(0, 2, 3, 5);
            this.pnl_ConsultarMovimientos.Name = "pnl_ConsultarMovimientos";
            this.pnl_ConsultarMovimientos.ShadowDecoration.Parent = this.pnl_ConsultarMovimientos;
            this.pnl_ConsultarMovimientos.Size = new System.Drawing.Size(1168, 375);
            this.pnl_ConsultarMovimientos.TabIndex = 35;
            // 
            // btn_CorteCaja
            // 
            this.btn_CorteCaja.CheckedState.Parent = this.btn_CorteCaja;
            this.btn_CorteCaja.CustomImages.Parent = this.btn_CorteCaja;
            this.btn_CorteCaja.FillColor = System.Drawing.Color.White;
            this.btn_CorteCaja.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_CorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_CorteCaja.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_CorteCaja.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CorteCaja.HoverState.Parent = this.btn_CorteCaja;
            this.btn_CorteCaja.Location = new System.Drawing.Point(285, 7);
            this.btn_CorteCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CorteCaja.Name = "btn_CorteCaja";
            this.btn_CorteCaja.PressedColor = System.Drawing.Color.White;
            this.btn_CorteCaja.ShadowDecoration.Parent = this.btn_CorteCaja;
            this.btn_CorteCaja.Size = new System.Drawing.Size(253, 46);
            this.btn_CorteCaja.TabIndex = 4;
            this.btn_CorteCaja.Text = "Corte de caja";
            // 
            // btn_ConsultarMovimientos
            // 
            this.btn_ConsultarMovimientos.CheckedState.Parent = this.btn_ConsultarMovimientos;
            this.btn_ConsultarMovimientos.CustomImages.Parent = this.btn_ConsultarMovimientos;
            this.btn_ConsultarMovimientos.FillColor = System.Drawing.Color.White;
            this.btn_ConsultarMovimientos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ConsultarMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_ConsultarMovimientos.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_ConsultarMovimientos.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_ConsultarMovimientos.HoverState.Parent = this.btn_ConsultarMovimientos;
            this.btn_ConsultarMovimientos.Location = new System.Drawing.Point(13, 7);
            this.btn_ConsultarMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ConsultarMovimientos.Name = "btn_ConsultarMovimientos";
            this.btn_ConsultarMovimientos.PressedColor = System.Drawing.Color.White;
            this.btn_ConsultarMovimientos.ShadowDecoration.Parent = this.btn_ConsultarMovimientos;
            this.btn_ConsultarMovimientos.Size = new System.Drawing.Size(253, 46);
            this.btn_ConsultarMovimientos.TabIndex = 3;
            this.btn_ConsultarMovimientos.Text = "Movimientos";
            // 
            // dgv_TablaMovimientos
            // 
            this.dgv_TablaMovimientos.AllowUserToAddRows = false;
            this.dgv_TablaMovimientos.AllowUserToDeleteRows = false;
            this.dgv_TablaMovimientos.AllowUserToResizeColumns = false;
            this.dgv_TablaMovimientos.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgv_TablaMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_TablaMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_TablaMovimientos.ColumnHeadersHeight = 35;
            this.dgv_TablaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TipoMovimiento,
            this.col_Descripcion,
            this.col_Fecha,
            this.col_Importe});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaMovimientos.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_TablaMovimientos.EnableHeadersVisualStyles = false;
            this.dgv_TablaMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaMovimientos.Location = new System.Drawing.Point(25, 157);
            this.dgv_TablaMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TablaMovimientos.Name = "dgv_TablaMovimientos";
            this.dgv_TablaMovimientos.RowHeadersVisible = false;
            this.dgv_TablaMovimientos.RowHeadersWidth = 65;
            this.dgv_TablaMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaMovimientos.RowTemplate.Height = 35;
            this.dgv_TablaMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaMovimientos.Size = new System.Drawing.Size(1129, 204);
            this.dgv_TablaMovimientos.TabIndex = 35;
            this.dgv_TablaMovimientos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaMovimientos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaMovimientos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaMovimientos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaMovimientos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaMovimientos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaMovimientos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaMovimientos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaMovimientos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaMovimientos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaMovimientos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaMovimientos.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaMovimientos.ThemeStyle.ReadOnly = false;
            this.dgv_TablaMovimientos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaMovimientos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaMovimientos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaMovimientos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaMovimientos.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaMovimientos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaMovimientos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.White;
            this.lbl_Producto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Producto.Location = new System.Drawing.Point(21, 96);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(47, 20);
            this.lbl_Producto.TabIndex = 37;
            this.lbl_Producto.Text = "Filtrar";
            // 
            // cb_FiltroMovimientos
            // 
            this.cb_FiltroMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.cb_FiltroMovimientos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.cb_FiltroMovimientos.BorderRadius = 5;
            this.cb_FiltroMovimientos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_FiltroMovimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FiltroMovimientos.FocusedColor = System.Drawing.Color.Empty;
            this.cb_FiltroMovimientos.FocusedState.Parent = this.cb_FiltroMovimientos;
            this.cb_FiltroMovimientos.Font = new System.Drawing.Font("Leelawadee UI", 10.2F);
            this.cb_FiltroMovimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_FiltroMovimientos.FormattingEnabled = true;
            this.cb_FiltroMovimientos.HoverState.Parent = this.cb_FiltroMovimientos;
            this.cb_FiltroMovimientos.ItemHeight = 20;
            this.cb_FiltroMovimientos.Items.AddRange(new object[] {
            "Todos los movimientos",
            "Entradas",
            "Salidas",
            "Ventas"});
            this.cb_FiltroMovimientos.ItemsAppearance.Parent = this.cb_FiltroMovimientos;
            this.cb_FiltroMovimientos.Location = new System.Drawing.Point(25, 118);
            this.cb_FiltroMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_FiltroMovimientos.Name = "cb_FiltroMovimientos";
            this.cb_FiltroMovimientos.ShadowDecoration.Parent = this.cb_FiltroMovimientos;
            this.cb_FiltroMovimientos.Size = new System.Drawing.Size(301, 26);
            this.cb_FiltroMovimientos.TabIndex = 52;
            // 
            // col_TipoMovimiento
            // 
            this.col_TipoMovimiento.HeaderText = "Tipo de movimiento";
            this.col_TipoMovimiento.MinimumWidth = 6;
            this.col_TipoMovimiento.Name = "col_TipoMovimiento";
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripción";
            this.col_Descripcion.MinimumWidth = 6;
            this.col_Descripcion.Name = "col_Descripcion";
            // 
            // col_Fecha
            // 
            this.col_Fecha.HeaderText = "Fecha";
            this.col_Fecha.MinimumWidth = 6;
            this.col_Fecha.Name = "col_Fecha";
            // 
            // col_Importe
            // 
            this.col_Importe.HeaderText = "Importe";
            this.col_Importe.MinimumWidth = 6;
            this.col_Importe.Name = "col_Importe";
            // 
            // tlp_DisplayConsultar
            // 
            this.tlp_DisplayConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_DisplayConsultar.ColumnCount = 1;
            this.tlp_DisplayConsultar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_DisplayConsultar.Controls.Add(this.pnl_ConsultarMovimientos, 0, 0);
            this.tlp_DisplayConsultar.Controls.Add(this.pnl_MenuProductos, 0, 1);
            this.tlp_DisplayConsultar.Location = new System.Drawing.Point(12, 94);
            this.tlp_DisplayConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_DisplayConsultar.Name = "tlp_DisplayConsultar";
            this.tlp_DisplayConsultar.RowCount = 2;
            this.tlp_DisplayConsultar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_DisplayConsultar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlp_DisplayConsultar.Size = new System.Drawing.Size(1171, 642);
            this.tlp_DisplayConsultar.TabIndex = 36;
            // 
            // pnl_MenuProductos
            // 
            this.pnl_MenuProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuProductos.BorderRadius = 10;
            this.pnl_MenuProductos.Controls.Add(this.lbl_ErrorCodigoBarras);
            this.pnl_MenuProductos.Controls.Add(this.btn_LimpiarEntrada);
            this.pnl_MenuProductos.Controls.Add(this.lbl_ErrorCantidad);
            this.pnl_MenuProductos.Controls.Add(this.btn_RegistrarProducto);
            this.pnl_MenuProductos.Controls.Add(this.lbl_ErrorProveedor);
            this.pnl_MenuProductos.Controls.Add(this.cb_Proveedor);
            this.pnl_MenuProductos.Controls.Add(this.lbl_Proveedor);
            this.pnl_MenuProductos.Controls.Add(this.tb_Cantidad);
            this.pnl_MenuProductos.Controls.Add(this.lbl_Cantidad);
            this.pnl_MenuProductos.Controls.Add(this.lbl_NuevaEntrada);
            this.pnl_MenuProductos.Controls.Add(this.lbl_DescripcionNueva);
            this.pnl_MenuProductos.Controls.Add(this.lbl_CodigoBarra);
            this.pnl_MenuProductos.Controls.Add(this.tb_CodigoBarra);
            this.pnl_MenuProductos.FillColor = System.Drawing.Color.White;
            this.pnl_MenuProductos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MenuProductos.Location = new System.Drawing.Point(0, 384);
            this.pnl_MenuProductos.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.pnl_MenuProductos.Name = "pnl_MenuProductos";
            this.pnl_MenuProductos.ShadowDecoration.Parent = this.pnl_MenuProductos;
            this.pnl_MenuProductos.Size = new System.Drawing.Size(1168, 256);
            this.pnl_MenuProductos.TabIndex = 1;
            // 
            // lbl_ErrorCodigoBarras
            // 
            this.lbl_ErrorCodigoBarras.AutoSize = true;
            this.lbl_ErrorCodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_ErrorCodigoBarras.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorCodigoBarras.Location = new System.Drawing.Point(331, 226);
            this.lbl_ErrorCodigoBarras.Name = "lbl_ErrorCodigoBarras";
            this.lbl_ErrorCodigoBarras.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorCodigoBarras.TabIndex = 75;
            this.lbl_ErrorCodigoBarras.Text = "* Error";
            this.lbl_ErrorCodigoBarras.Visible = false;
            // 
            // btn_LimpiarEntrada
            // 
            this.btn_LimpiarEntrada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.BorderRadius = 5;
            this.btn_LimpiarEntrada.BorderThickness = 1;
            this.btn_LimpiarEntrada.CheckedState.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.CustomImages.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.FillColor = System.Drawing.Color.White;
            this.btn_LimpiarEntrada.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimpiarEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.HoverState.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.Location = new System.Drawing.Point(639, 159);
            this.btn_LimpiarEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LimpiarEntrada.Name = "btn_LimpiarEntrada";
            this.btn_LimpiarEntrada.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.ShadowDecoration.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.Size = new System.Drawing.Size(152, 32);
            this.btn_LimpiarEntrada.TabIndex = 74;
            this.btn_LimpiarEntrada.Text = "Limpiar";
            // 
            // lbl_ErrorCantidad
            // 
            this.lbl_ErrorCantidad.AutoSize = true;
            this.lbl_ErrorCantidad.BackColor = System.Drawing.Color.White;
            this.lbl_ErrorCantidad.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorCantidad.Location = new System.Drawing.Point(21, 151);
            this.lbl_ErrorCantidad.Name = "lbl_ErrorCantidad";
            this.lbl_ErrorCantidad.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorCantidad.TabIndex = 76;
            this.lbl_ErrorCantidad.Text = "* Error";
            this.lbl_ErrorCantidad.Visible = false;
            // 
            // btn_RegistrarProducto
            // 
            this.btn_RegistrarProducto.BorderRadius = 5;
            this.btn_RegistrarProducto.CheckedState.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.CustomImages.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_RegistrarProducto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarProducto.HoverState.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.Location = new System.Drawing.Point(639, 119);
            this.btn_RegistrarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RegistrarProducto.Name = "btn_RegistrarProducto";
            this.btn_RegistrarProducto.ShadowDecoration.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.Size = new System.Drawing.Size(152, 32);
            this.btn_RegistrarProducto.TabIndex = 73;
            this.btn_RegistrarProducto.Text = "Registrar";
            // 
            // lbl_ErrorProveedor
            // 
            this.lbl_ErrorProveedor.AutoSize = true;
            this.lbl_ErrorProveedor.BackColor = System.Drawing.Color.White;
            this.lbl_ErrorProveedor.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorProveedor.Location = new System.Drawing.Point(22, 226);
            this.lbl_ErrorProveedor.Name = "lbl_ErrorProveedor";
            this.lbl_ErrorProveedor.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorProveedor.TabIndex = 77;
            this.lbl_ErrorProveedor.Text = "* Error";
            this.lbl_ErrorProveedor.Visible = false;
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.cb_Proveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.cb_Proveedor.BorderRadius = 5;
            this.cb_Proveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Proveedor.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Proveedor.FocusedState.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Font = new System.Drawing.Font("Leelawadee UI", 10.2F);
            this.cb_Proveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.HoverState.Parent = this.cb_Proveedor;
            this.cb_Proveedor.ItemHeight = 20;
            this.cb_Proveedor.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cb_Proveedor.ItemsAppearance.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Location = new System.Drawing.Point(25, 119);
            this.cb_Proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.ShadowDecoration.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Size = new System.Drawing.Size(280, 26);
            this.cb_Proveedor.TabIndex = 71;
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.BackColor = System.Drawing.Color.White;
            this.lbl_Proveedor.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proveedor.Location = new System.Drawing.Point(21, 99);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(144, 20);
            this.lbl_Proveedor.TabIndex = 72;
            this.lbl_Proveedor.Text = "Tipo de movimiento";
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
            this.tb_Cantidad.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cantidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Cantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Cantidad.HoverState.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Location = new System.Drawing.Point(335, 119);
            this.tb_Cantidad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Cantidad.Multiline = true;
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.PasswordChar = '\0';
            this.tb_Cantidad.PlaceholderText = "";
            this.tb_Cantidad.SelectedText = "";
            this.tb_Cantidad.ShadowDecoration.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Size = new System.Drawing.Size(269, 107);
            this.tb_Cantidad.TabIndex = 69;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.BackColor = System.Drawing.Color.White;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(331, 99);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(87, 20);
            this.lbl_Cantidad.TabIndex = 70;
            this.lbl_Cantidad.Text = "Descripción";
            // 
            // lbl_NuevaEntrada
            // 
            this.lbl_NuevaEntrada.AutoSize = true;
            this.lbl_NuevaEntrada.BackColor = System.Drawing.Color.White;
            this.lbl_NuevaEntrada.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_NuevaEntrada.Location = new System.Drawing.Point(20, 33);
            this.lbl_NuevaEntrada.Name = "lbl_NuevaEntrada";
            this.lbl_NuevaEntrada.Size = new System.Drawing.Size(235, 32);
            this.lbl_NuevaEntrada.TabIndex = 65;
            this.lbl_NuevaEntrada.Text = "Nuevo movimiento";
            // 
            // lbl_DescripcionNueva
            // 
            this.lbl_DescripcionNueva.AutoSize = true;
            this.lbl_DescripcionNueva.BackColor = System.Drawing.Color.White;
            this.lbl_DescripcionNueva.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_DescripcionNueva.Location = new System.Drawing.Point(21, 65);
            this.lbl_DescripcionNueva.Name = "lbl_DescripcionNueva";
            this.lbl_DescripcionNueva.Size = new System.Drawing.Size(375, 23);
            this.lbl_DescripcionNueva.TabIndex = 66;
            this.lbl_DescripcionNueva.Text = "Registra la entrada o salida de dinero de la caja.\r\n";
            // 
            // lbl_CodigoBarra
            // 
            this.lbl_CodigoBarra.AutoSize = true;
            this.lbl_CodigoBarra.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarra.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoBarra.Location = new System.Drawing.Point(22, 174);
            this.lbl_CodigoBarra.Name = "lbl_CodigoBarra";
            this.lbl_CodigoBarra.Size = new System.Drawing.Size(62, 20);
            this.lbl_CodigoBarra.TabIndex = 68;
            this.lbl_CodigoBarra.Text = "Importe";
            // 
            // tb_CodigoBarra
            // 
            this.tb_CodigoBarra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_CodigoBarra.BorderRadius = 5;
            this.tb_CodigoBarra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CodigoBarra.DefaultText = "";
            this.tb_CodigoBarra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CodigoBarra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CodigoBarra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodigoBarra.DisabledState.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodigoBarra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodigoBarra.FocusedState.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CodigoBarra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_CodigoBarra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodigoBarra.HoverState.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.Location = new System.Drawing.Point(26, 194);
            this.tb_CodigoBarra.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_CodigoBarra.Name = "tb_CodigoBarra";
            this.tb_CodigoBarra.PasswordChar = '\0';
            this.tb_CodigoBarra.PlaceholderText = "";
            this.tb_CodigoBarra.SelectedText = "";
            this.tb_CodigoBarra.ShadowDecoration.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.Size = new System.Drawing.Size(279, 32);
            this.tb_CodigoBarra.TabIndex = 67;
            // 
            // pnl_MenuSuperior
            // 
            this.pnl_MenuSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuSuperior.BorderRadius = 10;
            this.pnl_MenuSuperior.Controls.Add(this.btn_ConsultarMovimientos);
            this.pnl_MenuSuperior.Controls.Add(this.btn_CorteCaja);
            this.pnl_MenuSuperior.FillColor = System.Drawing.Color.White;
            this.pnl_MenuSuperior.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MenuSuperior.Location = new System.Drawing.Point(12, 15);
            this.pnl_MenuSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_MenuSuperior.Name = "pnl_MenuSuperior";
            this.pnl_MenuSuperior.ShadowDecoration.Parent = this.pnl_MenuSuperior;
            this.pnl_MenuSuperior.Size = new System.Drawing.Size(1168, 75);
            this.pnl_MenuSuperior.TabIndex = 78;
            // 
            // lbl_ConsultarProductos
            // 
            this.lbl_ConsultarProductos.AutoSize = true;
            this.lbl_ConsultarProductos.BackColor = System.Drawing.Color.White;
            this.lbl_ConsultarProductos.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConsultarProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_ConsultarProductos.Location = new System.Drawing.Point(20, 33);
            this.lbl_ConsultarProductos.Name = "lbl_ConsultarProductos";
            this.lbl_ConsultarProductos.Size = new System.Drawing.Size(281, 32);
            this.lbl_ConsultarProductos.TabIndex = 55;
            this.lbl_ConsultarProductos.Text = "Consultar movimientos";
            // 
            // lbl_DescripcionConsultar
            // 
            this.lbl_DescripcionConsultar.AutoSize = true;
            this.lbl_DescripcionConsultar.BackColor = System.Drawing.Color.White;
            this.lbl_DescripcionConsultar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_DescripcionConsultar.Location = new System.Drawing.Point(21, 65);
            this.lbl_DescripcionConsultar.Name = "lbl_DescripcionConsultar";
            this.lbl_DescripcionConsultar.Size = new System.Drawing.Size(690, 23);
            this.lbl_DescripcionConsultar.TabIndex = 56;
            this.lbl_DescripcionConsultar.Text = "Consulta la lista de todos los movimientos hechos en la tienda: entradas, salidas" +
    " y ventas.\r\n";
            // 
            // lbl_Hoy
            // 
            this.lbl_Hoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hoy.AutoSize = true;
            this.lbl_Hoy.BackColor = System.Drawing.Color.White;
            this.lbl_Hoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Hoy.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.lbl_Hoy.Location = new System.Drawing.Point(927, 124);
            this.lbl_Hoy.Name = "lbl_Hoy";
            this.lbl_Hoy.Size = new System.Drawing.Size(36, 20);
            this.lbl_Hoy.TabIndex = 57;
            this.lbl_Hoy.Text = "Hoy";
            // 
            // lbl_EstaSemana
            // 
            this.lbl_EstaSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EstaSemana.AutoSize = true;
            this.lbl_EstaSemana.BackColor = System.Drawing.Color.White;
            this.lbl_EstaSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EstaSemana.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstaSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.lbl_EstaSemana.Location = new System.Drawing.Point(979, 124);
            this.lbl_EstaSemana.Name = "lbl_EstaSemana";
            this.lbl_EstaSemana.Size = new System.Drawing.Size(91, 20);
            this.lbl_EstaSemana.TabIndex = 58;
            this.lbl_EstaSemana.Text = "Esta semana";
            // 
            // lbl_EsteMes
            // 
            this.lbl_EsteMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EsteMes.AutoSize = true;
            this.lbl_EsteMes.BackColor = System.Drawing.Color.White;
            this.lbl_EsteMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EsteMes.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsteMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.lbl_EsteMes.Location = new System.Drawing.Point(1086, 124);
            this.lbl_EsteMes.Name = "lbl_EsteMes";
            this.lbl_EsteMes.Size = new System.Drawing.Size(67, 20);
            this.lbl_EsteMes.TabIndex = 59;
            this.lbl_EsteMes.Text = "Este mes";
            // 
            // tlp_DisplayCorte
            // 
            this.tlp_DisplayCorte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_DisplayCorte.ColumnCount = 1;
            this.tlp_DisplayCorte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_DisplayCorte.Controls.Add(this.pnl_CorteCaja, 0, 0);
            this.tlp_DisplayCorte.Location = new System.Drawing.Point(12, 94);
            this.tlp_DisplayCorte.Name = "tlp_DisplayCorte";
            this.tlp_DisplayCorte.RowCount = 1;
            this.tlp_DisplayCorte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_DisplayCorte.Size = new System.Drawing.Size(1171, 642);
            this.tlp_DisplayCorte.TabIndex = 79;
            this.tlp_DisplayCorte.Visible = false;
            // 
            // pnl_CorteCaja
            // 
            this.pnl_CorteCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CorteCaja.BorderRadius = 10;
            this.pnl_CorteCaja.Controls.Add(this.btn_GuardarArchivo);
            this.pnl_CorteCaja.Controls.Add(this.lbl_FechaCorte);
            this.pnl_CorteCaja.Controls.Add(this.lbl_CorteIniciado);
            this.pnl_CorteCaja.Controls.Add(this.Separador);
            this.pnl_CorteCaja.Controls.Add(this.pnl_CorteDesplegado);
            this.pnl_CorteCaja.Controls.Add(this.lbl_Titulo);
            this.pnl_CorteCaja.Controls.Add(this.lbl_DescCorte);
            this.pnl_CorteCaja.FillColor = System.Drawing.Color.White;
            this.pnl_CorteCaja.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_CorteCaja.Location = new System.Drawing.Point(3, 2);
            this.pnl_CorteCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_CorteCaja.Name = "pnl_CorteCaja";
            this.pnl_CorteCaja.ShadowDecoration.Parent = this.pnl_CorteCaja;
            this.pnl_CorteCaja.Size = new System.Drawing.Size(1165, 638);
            this.pnl_CorteCaja.TabIndex = 79;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(20, 33);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(164, 32);
            this.lbl_Titulo.TabIndex = 6;
            this.lbl_Titulo.Text = "Corte de caja";
            // 
            // lbl_DescCorte
            // 
            this.lbl_DescCorte.AutoSize = true;
            this.lbl_DescCorte.BackColor = System.Drawing.Color.White;
            this.lbl_DescCorte.Location = new System.Drawing.Point(21, 65);
            this.lbl_DescCorte.Name = "lbl_DescCorte";
            this.lbl_DescCorte.Size = new System.Drawing.Size(448, 23);
            this.lbl_DescCorte.TabIndex = 7;
            this.lbl_DescCorte.Text = "Compara el dinero de la caja física con el total registrado.";
            // 
            // lbl_CorteIniciado
            // 
            this.lbl_CorteIniciado.AutoSize = true;
            this.lbl_CorteIniciado.BackColor = System.Drawing.Color.White;
            this.lbl_CorteIniciado.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CorteIniciado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_CorteIniciado.Location = new System.Drawing.Point(21, 120);
            this.lbl_CorteIniciado.Name = "lbl_CorteIniciado";
            this.lbl_CorteIniciado.Size = new System.Drawing.Size(156, 25);
            this.lbl_CorteIniciado.TabIndex = 8;
            this.lbl_CorteIniciado.Text = "Corte iniciado el";
            // 
            // lbl_FechaCorte
            // 
            this.lbl_FechaCorte.AutoSize = true;
            this.lbl_FechaCorte.BackColor = System.Drawing.Color.White;
            this.lbl_FechaCorte.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.lbl_FechaCorte.Location = new System.Drawing.Point(180, 120);
            this.lbl_FechaCorte.Name = "lbl_FechaCorte";
            this.lbl_FechaCorte.Size = new System.Drawing.Size(191, 25);
            this.lbl_FechaCorte.TabIndex = 9;
            this.lbl_FechaCorte.Text = "01 de mayo de 2021";
            // 
            // pb_VentasTotales
            // 
            this.pb_VentasTotales.BackColor = System.Drawing.Color.Transparent;
            this.pb_VentasTotales.Image = ((System.Drawing.Image)(resources.GetObject("pb_VentasTotales.Image")));
            this.pb_VentasTotales.Location = new System.Drawing.Point(29, 10);
            this.pb_VentasTotales.Name = "pb_VentasTotales";
            this.pb_VentasTotales.Size = new System.Drawing.Size(32, 32);
            this.pb_VentasTotales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_VentasTotales.TabIndex = 10;
            this.pb_VentasTotales.TabStop = false;
            // 
            // lbl_DescVentasTotales
            // 
            this.lbl_DescVentasTotales.AutoSize = true;
            this.lbl_DescVentasTotales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DescVentasTotales.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescVentasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescVentasTotales.Location = new System.Drawing.Point(85, 14);
            this.lbl_DescVentasTotales.Name = "lbl_DescVentasTotales";
            this.lbl_DescVentasTotales.Size = new System.Drawing.Size(136, 25);
            this.lbl_DescVentasTotales.TabIndex = 11;
            this.lbl_DescVentasTotales.Text = "Ventas totales";
            // 
            // pnl_Totales
            // 
            this.pnl_Totales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Totales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnl_Totales.Controls.Add(this.pnl_GananciasTotales);
            this.pnl_Totales.Controls.Add(this.pnl_VentasTotales);
            this.pnl_Totales.Location = new System.Drawing.Point(3, 3);
            this.pnl_Totales.Name = "pnl_Totales";
            this.pnl_Totales.Size = new System.Drawing.Size(1121, 74);
            this.pnl_Totales.TabIndex = 12;
            // 
            // lbl_VentasTotales
            // 
            this.lbl_VentasTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasTotales.AutoSize = true;
            this.lbl_VentasTotales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VentasTotales.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasTotales.Location = new System.Drawing.Point(350, 14);
            this.lbl_VentasTotales.Name = "lbl_VentasTotales";
            this.lbl_VentasTotales.Size = new System.Drawing.Size(137, 25);
            this.lbl_VentasTotales.TabIndex = 12;
            this.lbl_VentasTotales.Text = "$1,000,000.00";
            // 
            // pb_GananciasTotales
            // 
            this.pb_GananciasTotales.BackColor = System.Drawing.Color.Transparent;
            this.pb_GananciasTotales.Image = ((System.Drawing.Image)(resources.GetObject("pb_GananciasTotales.Image")));
            this.pb_GananciasTotales.Location = new System.Drawing.Point(29, 10);
            this.pb_GananciasTotales.Name = "pb_GananciasTotales";
            this.pb_GananciasTotales.Size = new System.Drawing.Size(32, 32);
            this.pb_GananciasTotales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_GananciasTotales.TabIndex = 13;
            this.pb_GananciasTotales.TabStop = false;
            // 
            // lbl_GananciasTotales
            // 
            this.lbl_GananciasTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciasTotales.AutoSize = true;
            this.lbl_GananciasTotales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GananciasTotales.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciasTotales.Location = new System.Drawing.Point(350, 14);
            this.lbl_GananciasTotales.Name = "lbl_GananciasTotales";
            this.lbl_GananciasTotales.Size = new System.Drawing.Size(137, 25);
            this.lbl_GananciasTotales.TabIndex = 15;
            this.lbl_GananciasTotales.Text = "$1,000,000.00";
            // 
            // lbl_DescGanancias
            // 
            this.lbl_DescGanancias.AutoSize = true;
            this.lbl_DescGanancias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DescGanancias.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescGanancias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescGanancias.Location = new System.Drawing.Point(85, 14);
            this.lbl_DescGanancias.Name = "lbl_DescGanancias";
            this.lbl_DescGanancias.Size = new System.Drawing.Size(166, 25);
            this.lbl_DescGanancias.TabIndex = 14;
            this.lbl_DescGanancias.Text = "Ganancias totales";
            // 
            // pnl_VentasTotales
            // 
            this.pnl_VentasTotales.Controls.Add(this.lbl_DescVentasTotales);
            this.pnl_VentasTotales.Controls.Add(this.lbl_VentasTotales);
            this.pnl_VentasTotales.Controls.Add(this.pb_VentasTotales);
            this.pnl_VentasTotales.Location = new System.Drawing.Point(9, 9);
            this.pnl_VentasTotales.Name = "pnl_VentasTotales";
            this.pnl_VentasTotales.Size = new System.Drawing.Size(504, 54);
            this.pnl_VentasTotales.TabIndex = 13;
            // 
            // pnl_GananciasTotales
            // 
            this.pnl_GananciasTotales.Controls.Add(this.lbl_GananciasTotales);
            this.pnl_GananciasTotales.Controls.Add(this.pb_GananciasTotales);
            this.pnl_GananciasTotales.Controls.Add(this.lbl_DescGanancias);
            this.pnl_GananciasTotales.Location = new System.Drawing.Point(528, 9);
            this.pnl_GananciasTotales.Name = "pnl_GananciasTotales";
            this.pnl_GananciasTotales.Size = new System.Drawing.Size(504, 54);
            this.pnl_GananciasTotales.TabIndex = 14;
            // 
            // lbl_DescVentas
            // 
            this.lbl_DescVentas.AutoSize = true;
            this.lbl_DescVentas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DescVentas.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescVentas.Location = new System.Drawing.Point(85, 35);
            this.lbl_DescVentas.Name = "lbl_DescVentas";
            this.lbl_DescVentas.Size = new System.Drawing.Size(262, 25);
            this.lbl_DescVentas.TabIndex = 14;
            this.lbl_DescVentas.Text = "Ventas por método de pago";
            // 
            // pb_Ventas
            // 
            this.pb_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.pb_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("pb_Ventas.Image")));
            this.pb_Ventas.Location = new System.Drawing.Point(29, 28);
            this.pb_Ventas.Name = "pb_Ventas";
            this.pb_Ventas.Size = new System.Drawing.Size(32, 32);
            this.pb_Ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Ventas.TabIndex = 13;
            this.pb_Ventas.TabStop = false;
            // 
            // lbl_DescVentasEfectivo
            // 
            this.lbl_DescVentasEfectivo.AutoSize = true;
            this.lbl_DescVentasEfectivo.BackColor = System.Drawing.Color.White;
            this.lbl_DescVentasEfectivo.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescVentasEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescVentasEfectivo.Location = new System.Drawing.Point(85, 73);
            this.lbl_DescVentasEfectivo.Name = "lbl_DescVentasEfectivo";
            this.lbl_DescVentasEfectivo.Size = new System.Drawing.Size(104, 25);
            this.lbl_DescVentasEfectivo.TabIndex = 15;
            this.lbl_DescVentasEfectivo.Text = "En efectivo";
            // 
            // lbl_DescVentasTarjeta
            // 
            this.lbl_DescVentasTarjeta.AutoSize = true;
            this.lbl_DescVentasTarjeta.BackColor = System.Drawing.Color.White;
            this.lbl_DescVentasTarjeta.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescVentasTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescVentasTarjeta.Location = new System.Drawing.Point(85, 115);
            this.lbl_DescVentasTarjeta.Name = "lbl_DescVentasTarjeta";
            this.lbl_DescVentasTarjeta.Size = new System.Drawing.Size(105, 25);
            this.lbl_DescVentasTarjeta.TabIndex = 16;
            this.lbl_DescVentasTarjeta.Text = "Con tarjeta";
            // 
            // lbl_VentasEfectivo
            // 
            this.lbl_VentasEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasEfectivo.AutoSize = true;
            this.lbl_VentasEfectivo.BackColor = System.Drawing.Color.White;
            this.lbl_VentasEfectivo.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasEfectivo.Location = new System.Drawing.Point(363, 73);
            this.lbl_VentasEfectivo.Name = "lbl_VentasEfectivo";
            this.lbl_VentasEfectivo.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasEfectivo.TabIndex = 17;
            this.lbl_VentasEfectivo.Text = "$1,000,000.00";
            // 
            // lbl_VentasTarjeta
            // 
            this.lbl_VentasTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasTarjeta.AutoSize = true;
            this.lbl_VentasTarjeta.BackColor = System.Drawing.Color.White;
            this.lbl_VentasTarjeta.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasTarjeta.Location = new System.Drawing.Point(363, 115);
            this.lbl_VentasTarjeta.Name = "lbl_VentasTarjeta";
            this.lbl_VentasTarjeta.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasTarjeta.TabIndex = 18;
            this.lbl_VentasTarjeta.Text = "$1,000,000.00";
            // 
            // pnl_VentasMetodos
            // 
            this.pnl_VentasMetodos.BackColor = System.Drawing.Color.White;
            this.pnl_VentasMetodos.Controls.Add(this.pb_Ventas);
            this.pnl_VentasMetodos.Controls.Add(this.lbl_VentasTarjeta);
            this.pnl_VentasMetodos.Controls.Add(this.lbl_DescVentas);
            this.pnl_VentasMetodos.Controls.Add(this.lbl_VentasEfectivo);
            this.pnl_VentasMetodos.Controls.Add(this.lbl_DescVentasEfectivo);
            this.pnl_VentasMetodos.Controls.Add(this.lbl_DescVentasTarjeta);
            this.pnl_VentasMetodos.Location = new System.Drawing.Point(12, 90);
            this.pnl_VentasMetodos.Name = "pnl_VentasMetodos";
            this.pnl_VentasMetodos.Size = new System.Drawing.Size(504, 151);
            this.pnl_VentasMetodos.TabIndex = 19;
            // 
            // pnl_VentasCategoria
            // 
            this.pnl_VentasCategoria.BackColor = System.Drawing.Color.White;
            this.pnl_VentasCategoria.Controls.Add(this.pb_SinCategoria);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasSinCategoria);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescSinCategoria);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Refrigerados);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Mascotas);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Higiene);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Limpieza);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Abarrotes);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Lacteos);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Carniceria);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Panaderia);
            this.pnl_VentasCategoria.Controls.Add(this.pb_Frutas);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasRefrigerados);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasMascotas);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasHigiene);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasLimpieza);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasAbarrotes);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasLacteos);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasCarniceria);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescRefrigerados);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescMascotas);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_Higiene);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescLimpieza);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescAbarrotes);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescLacteos);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescCarniceria);
            this.pnl_VentasCategoria.Controls.Add(this.pb_VentasCategoria);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentasPanaderia);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DesVentasCategoria);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_VentaFrutas);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescFrutas);
            this.pnl_VentasCategoria.Controls.Add(this.lbl_DescPanaderia);
            this.pnl_VentasCategoria.Location = new System.Drawing.Point(531, 90);
            this.pnl_VentasCategoria.Name = "pnl_VentasCategoria";
            this.pnl_VentasCategoria.Size = new System.Drawing.Size(504, 483);
            this.pnl_VentasCategoria.TabIndex = 20;
            // 
            // pb_VentasCategoria
            // 
            this.pb_VentasCategoria.BackColor = System.Drawing.Color.Transparent;
            this.pb_VentasCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pb_VentasCategoria.Image")));
            this.pb_VentasCategoria.Location = new System.Drawing.Point(29, 28);
            this.pb_VentasCategoria.Name = "pb_VentasCategoria";
            this.pb_VentasCategoria.Size = new System.Drawing.Size(32, 32);
            this.pb_VentasCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_VentasCategoria.TabIndex = 13;
            this.pb_VentasCategoria.TabStop = false;
            // 
            // lbl_DesVentasCategoria
            // 
            this.lbl_DesVentasCategoria.AutoSize = true;
            this.lbl_DesVentasCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DesVentasCategoria.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DesVentasCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DesVentasCategoria.Location = new System.Drawing.Point(85, 35);
            this.lbl_DesVentasCategoria.Name = "lbl_DesVentasCategoria";
            this.lbl_DesVentasCategoria.Size = new System.Drawing.Size(198, 25);
            this.lbl_DesVentasCategoria.TabIndex = 14;
            this.lbl_DesVentasCategoria.Text = "Ventas por categoría";
            // 
            // pnl_CorteDesplegado
            // 
            this.pnl_CorteDesplegado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CorteDesplegado.AutoScroll = true;
            this.pnl_CorteDesplegado.BackColor = System.Drawing.Color.White;
            this.pnl_CorteDesplegado.Controls.Add(this.pnl_Salidas);
            this.pnl_CorteDesplegado.Controls.Add(this.pnl_Entradas);
            this.pnl_CorteDesplegado.Controls.Add(this.pnl_GananciasCategoria);
            this.pnl_CorteDesplegado.Controls.Add(this.pnl_Totales);
            this.pnl_CorteDesplegado.Controls.Add(this.pnl_VentasCategoria);
            this.pnl_CorteDesplegado.Controls.Add(this.pnl_VentasMetodos);
            this.pnl_CorteDesplegado.Location = new System.Drawing.Point(26, 157);
            this.pnl_CorteDesplegado.Name = "pnl_CorteDesplegado";
            this.pnl_CorteDesplegado.Size = new System.Drawing.Size(1124, 478);
            this.pnl_CorteDesplegado.TabIndex = 21;
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
            this.Separador.Location = new System.Drawing.Point(26, 115);
            this.Separador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Separador.Name = "Separador";
            this.Separador.PasswordChar = '\0';
            this.Separador.ReadOnly = true;
            this.Separador.SelectedText = "";
            this.Separador.Size = new System.Drawing.Size(1125, 37);
            this.Separador.TabIndex = 35;
            // 
            // lbl_DescRefrigerados
            // 
            this.lbl_DescRefrigerados.AutoSize = true;
            this.lbl_DescRefrigerados.BackColor = System.Drawing.Color.White;
            this.lbl_DescRefrigerados.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescRefrigerados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescRefrigerados.Location = new System.Drawing.Point(85, 395);
            this.lbl_DescRefrigerados.Name = "lbl_DescRefrigerados";
            this.lbl_DescRefrigerados.Size = new System.Drawing.Size(119, 25);
            this.lbl_DescRefrigerados.TabIndex = 25;
            this.lbl_DescRefrigerados.Text = "Refrigerados";
            // 
            // lbl_VentasRefrigerados
            // 
            this.lbl_VentasRefrigerados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasRefrigerados.AutoSize = true;
            this.lbl_VentasRefrigerados.BackColor = System.Drawing.Color.White;
            this.lbl_VentasRefrigerados.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasRefrigerados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasRefrigerados.Location = new System.Drawing.Point(363, 395);
            this.lbl_VentasRefrigerados.Name = "lbl_VentasRefrigerados";
            this.lbl_VentasRefrigerados.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasRefrigerados.TabIndex = 32;
            this.lbl_VentasRefrigerados.Text = "$1,000,000.00";
            // 
            // pb_Refrigerados
            // 
            this.pb_Refrigerados.Image = ((System.Drawing.Image)(resources.GetObject("pb_Refrigerados.Image")));
            this.pb_Refrigerados.Location = new System.Drawing.Point(33, 393);
            this.pb_Refrigerados.Name = "pb_Refrigerados";
            this.pb_Refrigerados.Size = new System.Drawing.Size(28, 28);
            this.pb_Refrigerados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Refrigerados.TabIndex = 41;
            this.pb_Refrigerados.TabStop = false;
            // 
            // lbl_DescSinCategoria
            // 
            this.lbl_DescSinCategoria.AutoSize = true;
            this.lbl_DescSinCategoria.BackColor = System.Drawing.Color.White;
            this.lbl_DescSinCategoria.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescSinCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescSinCategoria.Location = new System.Drawing.Point(85, 436);
            this.lbl_DescSinCategoria.Name = "lbl_DescSinCategoria";
            this.lbl_DescSinCategoria.Size = new System.Drawing.Size(122, 25);
            this.lbl_DescSinCategoria.TabIndex = 42;
            this.lbl_DescSinCategoria.Text = "Sin categoría";
            // 
            // lbl_VentasSinCategoria
            // 
            this.lbl_VentasSinCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasSinCategoria.AutoSize = true;
            this.lbl_VentasSinCategoria.BackColor = System.Drawing.Color.White;
            this.lbl_VentasSinCategoria.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasSinCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasSinCategoria.Location = new System.Drawing.Point(363, 436);
            this.lbl_VentasSinCategoria.Name = "lbl_VentasSinCategoria";
            this.lbl_VentasSinCategoria.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasSinCategoria.TabIndex = 43;
            this.lbl_VentasSinCategoria.Text = "$1,000,000.00";
            // 
            // pb_SinCategoria
            // 
            this.pb_SinCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pb_SinCategoria.Image")));
            this.pb_SinCategoria.Location = new System.Drawing.Point(33, 434);
            this.pb_SinCategoria.Name = "pb_SinCategoria";
            this.pb_SinCategoria.Size = new System.Drawing.Size(28, 28);
            this.pb_SinCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_SinCategoria.TabIndex = 44;
            this.pb_SinCategoria.TabStop = false;
            // 
            // lbl_DescPanaderia
            // 
            this.lbl_DescPanaderia.AutoSize = true;
            this.lbl_DescPanaderia.BackColor = System.Drawing.Color.White;
            this.lbl_DescPanaderia.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescPanaderia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescPanaderia.Location = new System.Drawing.Point(85, 115);
            this.lbl_DescPanaderia.Name = "lbl_DescPanaderia";
            this.lbl_DescPanaderia.Size = new System.Drawing.Size(193, 25);
            this.lbl_DescPanaderia.TabIndex = 16;
            this.lbl_DescPanaderia.Text = "Panadería y tortillería";
            // 
            // lbl_DescFrutas
            // 
            this.lbl_DescFrutas.AutoSize = true;
            this.lbl_DescFrutas.BackColor = System.Drawing.Color.White;
            this.lbl_DescFrutas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescFrutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescFrutas.Location = new System.Drawing.Point(85, 75);
            this.lbl_DescFrutas.Name = "lbl_DescFrutas";
            this.lbl_DescFrutas.Size = new System.Drawing.Size(155, 25);
            this.lbl_DescFrutas.TabIndex = 15;
            this.lbl_DescFrutas.Text = "Frutas y verduras";
            // 
            // lbl_VentaFrutas
            // 
            this.lbl_VentaFrutas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentaFrutas.AutoSize = true;
            this.lbl_VentaFrutas.BackColor = System.Drawing.Color.White;
            this.lbl_VentaFrutas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentaFrutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentaFrutas.Location = new System.Drawing.Point(363, 73);
            this.lbl_VentaFrutas.Name = "lbl_VentaFrutas";
            this.lbl_VentaFrutas.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentaFrutas.TabIndex = 17;
            this.lbl_VentaFrutas.Text = "$1,000,000.00";
            // 
            // lbl_VentasPanaderia
            // 
            this.lbl_VentasPanaderia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasPanaderia.AutoSize = true;
            this.lbl_VentasPanaderia.BackColor = System.Drawing.Color.White;
            this.lbl_VentasPanaderia.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasPanaderia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasPanaderia.Location = new System.Drawing.Point(363, 116);
            this.lbl_VentasPanaderia.Name = "lbl_VentasPanaderia";
            this.lbl_VentasPanaderia.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasPanaderia.TabIndex = 18;
            this.lbl_VentasPanaderia.Text = "$1,000,000.00";
            // 
            // lbl_DescCarniceria
            // 
            this.lbl_DescCarniceria.AutoSize = true;
            this.lbl_DescCarniceria.BackColor = System.Drawing.Color.White;
            this.lbl_DescCarniceria.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescCarniceria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescCarniceria.Location = new System.Drawing.Point(85, 155);
            this.lbl_DescCarniceria.Name = "lbl_DescCarniceria";
            this.lbl_DescCarniceria.Size = new System.Drawing.Size(98, 25);
            this.lbl_DescCarniceria.TabIndex = 19;
            this.lbl_DescCarniceria.Text = "Carnicería";
            // 
            // lbl_DescLacteos
            // 
            this.lbl_DescLacteos.AutoSize = true;
            this.lbl_DescLacteos.BackColor = System.Drawing.Color.White;
            this.lbl_DescLacteos.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescLacteos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescLacteos.Location = new System.Drawing.Point(85, 195);
            this.lbl_DescLacteos.Name = "lbl_DescLacteos";
            this.lbl_DescLacteos.Size = new System.Drawing.Size(75, 25);
            this.lbl_DescLacteos.TabIndex = 20;
            this.lbl_DescLacteos.Text = "Lácteos";
            // 
            // lbl_DescAbarrotes
            // 
            this.lbl_DescAbarrotes.AutoSize = true;
            this.lbl_DescAbarrotes.BackColor = System.Drawing.Color.White;
            this.lbl_DescAbarrotes.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescAbarrotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescAbarrotes.Location = new System.Drawing.Point(85, 235);
            this.lbl_DescAbarrotes.Name = "lbl_DescAbarrotes";
            this.lbl_DescAbarrotes.Size = new System.Drawing.Size(94, 25);
            this.lbl_DescAbarrotes.TabIndex = 21;
            this.lbl_DescAbarrotes.Text = "Abarrotes";
            // 
            // lbl_DescLimpieza
            // 
            this.lbl_DescLimpieza.AutoSize = true;
            this.lbl_DescLimpieza.BackColor = System.Drawing.Color.White;
            this.lbl_DescLimpieza.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescLimpieza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescLimpieza.Location = new System.Drawing.Point(85, 275);
            this.lbl_DescLimpieza.Name = "lbl_DescLimpieza";
            this.lbl_DescLimpieza.Size = new System.Drawing.Size(156, 25);
            this.lbl_DescLimpieza.TabIndex = 22;
            this.lbl_DescLimpieza.Text = "Limpieza y hogar";
            // 
            // lbl_Higiene
            // 
            this.lbl_Higiene.AutoSize = true;
            this.lbl_Higiene.BackColor = System.Drawing.Color.White;
            this.lbl_Higiene.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Higiene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Higiene.Location = new System.Drawing.Point(85, 315);
            this.lbl_Higiene.Name = "lbl_Higiene";
            this.lbl_Higiene.Size = new System.Drawing.Size(219, 25);
            this.lbl_Higiene.TabIndex = 23;
            this.lbl_Higiene.Text = "Higiene personal y salud";
            // 
            // lbl_DescMascotas
            // 
            this.lbl_DescMascotas.AutoSize = true;
            this.lbl_DescMascotas.BackColor = System.Drawing.Color.White;
            this.lbl_DescMascotas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescMascotas.Location = new System.Drawing.Point(85, 355);
            this.lbl_DescMascotas.Name = "lbl_DescMascotas";
            this.lbl_DescMascotas.Size = new System.Drawing.Size(91, 25);
            this.lbl_DescMascotas.TabIndex = 24;
            this.lbl_DescMascotas.Text = "Mascotas";
            // 
            // lbl_VentasCarniceria
            // 
            this.lbl_VentasCarniceria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasCarniceria.AutoSize = true;
            this.lbl_VentasCarniceria.BackColor = System.Drawing.Color.White;
            this.lbl_VentasCarniceria.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasCarniceria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasCarniceria.Location = new System.Drawing.Point(363, 155);
            this.lbl_VentasCarniceria.Name = "lbl_VentasCarniceria";
            this.lbl_VentasCarniceria.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasCarniceria.TabIndex = 26;
            this.lbl_VentasCarniceria.Text = "$1,000,000.00";
            // 
            // lbl_VentasLacteos
            // 
            this.lbl_VentasLacteos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasLacteos.AutoSize = true;
            this.lbl_VentasLacteos.BackColor = System.Drawing.Color.White;
            this.lbl_VentasLacteos.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasLacteos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasLacteos.Location = new System.Drawing.Point(363, 195);
            this.lbl_VentasLacteos.Name = "lbl_VentasLacteos";
            this.lbl_VentasLacteos.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasLacteos.TabIndex = 27;
            this.lbl_VentasLacteos.Text = "$1,000,000.00";
            // 
            // lbl_VentasAbarrotes
            // 
            this.lbl_VentasAbarrotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasAbarrotes.AutoSize = true;
            this.lbl_VentasAbarrotes.BackColor = System.Drawing.Color.White;
            this.lbl_VentasAbarrotes.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasAbarrotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasAbarrotes.Location = new System.Drawing.Point(363, 235);
            this.lbl_VentasAbarrotes.Name = "lbl_VentasAbarrotes";
            this.lbl_VentasAbarrotes.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasAbarrotes.TabIndex = 28;
            this.lbl_VentasAbarrotes.Text = "$1,000,000.00";
            // 
            // lbl_VentasLimpieza
            // 
            this.lbl_VentasLimpieza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasLimpieza.AutoSize = true;
            this.lbl_VentasLimpieza.BackColor = System.Drawing.Color.White;
            this.lbl_VentasLimpieza.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasLimpieza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasLimpieza.Location = new System.Drawing.Point(363, 275);
            this.lbl_VentasLimpieza.Name = "lbl_VentasLimpieza";
            this.lbl_VentasLimpieza.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasLimpieza.TabIndex = 29;
            this.lbl_VentasLimpieza.Text = "$1,000,000.00";
            // 
            // lbl_VentasHigiene
            // 
            this.lbl_VentasHigiene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasHigiene.AutoSize = true;
            this.lbl_VentasHigiene.BackColor = System.Drawing.Color.White;
            this.lbl_VentasHigiene.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasHigiene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasHigiene.Location = new System.Drawing.Point(363, 315);
            this.lbl_VentasHigiene.Name = "lbl_VentasHigiene";
            this.lbl_VentasHigiene.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasHigiene.TabIndex = 30;
            this.lbl_VentasHigiene.Text = "$1,000,000.00";
            // 
            // lbl_VentasMascotas
            // 
            this.lbl_VentasMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VentasMascotas.AutoSize = true;
            this.lbl_VentasMascotas.BackColor = System.Drawing.Color.White;
            this.lbl_VentasMascotas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_VentasMascotas.Location = new System.Drawing.Point(363, 354);
            this.lbl_VentasMascotas.Name = "lbl_VentasMascotas";
            this.lbl_VentasMascotas.Size = new System.Drawing.Size(124, 25);
            this.lbl_VentasMascotas.TabIndex = 31;
            this.lbl_VentasMascotas.Text = "$1,000,000.00";
            // 
            // pb_Frutas
            // 
            this.pb_Frutas.Image = ((System.Drawing.Image)(resources.GetObject("pb_Frutas.Image")));
            this.pb_Frutas.Location = new System.Drawing.Point(31, 73);
            this.pb_Frutas.Name = "pb_Frutas";
            this.pb_Frutas.Size = new System.Drawing.Size(28, 28);
            this.pb_Frutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Frutas.TabIndex = 33;
            this.pb_Frutas.TabStop = false;
            // 
            // pb_Panaderia
            // 
            this.pb_Panaderia.Image = ((System.Drawing.Image)(resources.GetObject("pb_Panaderia.Image")));
            this.pb_Panaderia.Location = new System.Drawing.Point(33, 113);
            this.pb_Panaderia.Name = "pb_Panaderia";
            this.pb_Panaderia.Size = new System.Drawing.Size(28, 28);
            this.pb_Panaderia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Panaderia.TabIndex = 34;
            this.pb_Panaderia.TabStop = false;
            // 
            // pb_Carniceria
            // 
            this.pb_Carniceria.Image = ((System.Drawing.Image)(resources.GetObject("pb_Carniceria.Image")));
            this.pb_Carniceria.Location = new System.Drawing.Point(33, 153);
            this.pb_Carniceria.Name = "pb_Carniceria";
            this.pb_Carniceria.Size = new System.Drawing.Size(28, 28);
            this.pb_Carniceria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Carniceria.TabIndex = 35;
            this.pb_Carniceria.TabStop = false;
            // 
            // pb_Lacteos
            // 
            this.pb_Lacteos.Image = ((System.Drawing.Image)(resources.GetObject("pb_Lacteos.Image")));
            this.pb_Lacteos.Location = new System.Drawing.Point(33, 193);
            this.pb_Lacteos.Name = "pb_Lacteos";
            this.pb_Lacteos.Size = new System.Drawing.Size(28, 28);
            this.pb_Lacteos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Lacteos.TabIndex = 36;
            this.pb_Lacteos.TabStop = false;
            // 
            // pb_Abarrotes
            // 
            this.pb_Abarrotes.Image = ((System.Drawing.Image)(resources.GetObject("pb_Abarrotes.Image")));
            this.pb_Abarrotes.Location = new System.Drawing.Point(33, 233);
            this.pb_Abarrotes.Name = "pb_Abarrotes";
            this.pb_Abarrotes.Size = new System.Drawing.Size(28, 28);
            this.pb_Abarrotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Abarrotes.TabIndex = 37;
            this.pb_Abarrotes.TabStop = false;
            // 
            // pb_Limpieza
            // 
            this.pb_Limpieza.Image = ((System.Drawing.Image)(resources.GetObject("pb_Limpieza.Image")));
            this.pb_Limpieza.Location = new System.Drawing.Point(33, 273);
            this.pb_Limpieza.Name = "pb_Limpieza";
            this.pb_Limpieza.Size = new System.Drawing.Size(28, 28);
            this.pb_Limpieza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Limpieza.TabIndex = 38;
            this.pb_Limpieza.TabStop = false;
            // 
            // pb_Higiene
            // 
            this.pb_Higiene.Image = ((System.Drawing.Image)(resources.GetObject("pb_Higiene.Image")));
            this.pb_Higiene.Location = new System.Drawing.Point(33, 313);
            this.pb_Higiene.Name = "pb_Higiene";
            this.pb_Higiene.Size = new System.Drawing.Size(28, 28);
            this.pb_Higiene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Higiene.TabIndex = 39;
            this.pb_Higiene.TabStop = false;
            // 
            // pb_Mascotas
            // 
            this.pb_Mascotas.Image = ((System.Drawing.Image)(resources.GetObject("pb_Mascotas.Image")));
            this.pb_Mascotas.Location = new System.Drawing.Point(33, 353);
            this.pb_Mascotas.Name = "pb_Mascotas";
            this.pb_Mascotas.Size = new System.Drawing.Size(28, 28);
            this.pb_Mascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Mascotas.TabIndex = 40;
            this.pb_Mascotas.TabStop = false;
            // 
            // pnl_GananciasCategoria
            // 
            this.pnl_GananciasCategoria.BackColor = System.Drawing.Color.White;
            this.pnl_GananciasCategoria.Controls.Add(this.pb_SinCategoria2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaSinCategoria);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescSinCategoria2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Refrigerados2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Mascotas2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Higiene2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Limpieza2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Abarrotes2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Lacteos2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Carniceria2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Panaderia2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Frutas2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaRefrigerados);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaMascotas);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaHigiene);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaLimpieza);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaAbarrotes);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaLacteos);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaCarniceria);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescRefrigerados2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescMascotas2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescHigiene2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescLimpieza2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescAbarrotes2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescLacteos2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescCarniceria2);
            this.pnl_GananciasCategoria.Controls.Add(this.pb_Categoria);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaPanaderia);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciasCategoria);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_GananciaFrutas);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescFrutas2);
            this.pnl_GananciasCategoria.Controls.Add(this.lbl_DescPanaderia2);
            this.pnl_GananciasCategoria.Location = new System.Drawing.Point(531, 587);
            this.pnl_GananciasCategoria.Name = "pnl_GananciasCategoria";
            this.pnl_GananciasCategoria.Size = new System.Drawing.Size(504, 483);
            this.pnl_GananciasCategoria.TabIndex = 45;
            // 
            // pb_SinCategoria2
            // 
            this.pb_SinCategoria2.Image = ((System.Drawing.Image)(resources.GetObject("pb_SinCategoria2.Image")));
            this.pb_SinCategoria2.Location = new System.Drawing.Point(33, 434);
            this.pb_SinCategoria2.Name = "pb_SinCategoria2";
            this.pb_SinCategoria2.Size = new System.Drawing.Size(28, 28);
            this.pb_SinCategoria2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_SinCategoria2.TabIndex = 44;
            this.pb_SinCategoria2.TabStop = false;
            // 
            // lbl_GananciaSinCategoria
            // 
            this.lbl_GananciaSinCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaSinCategoria.AutoSize = true;
            this.lbl_GananciaSinCategoria.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaSinCategoria.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaSinCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaSinCategoria.Location = new System.Drawing.Point(363, 436);
            this.lbl_GananciaSinCategoria.Name = "lbl_GananciaSinCategoria";
            this.lbl_GananciaSinCategoria.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaSinCategoria.TabIndex = 43;
            this.lbl_GananciaSinCategoria.Text = "$1,000,000.00";
            // 
            // lbl_DescSinCategoria2
            // 
            this.lbl_DescSinCategoria2.AutoSize = true;
            this.lbl_DescSinCategoria2.BackColor = System.Drawing.Color.White;
            this.lbl_DescSinCategoria2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescSinCategoria2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescSinCategoria2.Location = new System.Drawing.Point(85, 436);
            this.lbl_DescSinCategoria2.Name = "lbl_DescSinCategoria2";
            this.lbl_DescSinCategoria2.Size = new System.Drawing.Size(122, 25);
            this.lbl_DescSinCategoria2.TabIndex = 42;
            this.lbl_DescSinCategoria2.Text = "Sin categoría";
            // 
            // pb_Refrigerados2
            // 
            this.pb_Refrigerados2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Refrigerados2.Image")));
            this.pb_Refrigerados2.Location = new System.Drawing.Point(33, 393);
            this.pb_Refrigerados2.Name = "pb_Refrigerados2";
            this.pb_Refrigerados2.Size = new System.Drawing.Size(28, 28);
            this.pb_Refrigerados2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Refrigerados2.TabIndex = 41;
            this.pb_Refrigerados2.TabStop = false;
            // 
            // pb_Mascotas2
            // 
            this.pb_Mascotas2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Mascotas2.Image")));
            this.pb_Mascotas2.Location = new System.Drawing.Point(33, 353);
            this.pb_Mascotas2.Name = "pb_Mascotas2";
            this.pb_Mascotas2.Size = new System.Drawing.Size(28, 28);
            this.pb_Mascotas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Mascotas2.TabIndex = 40;
            this.pb_Mascotas2.TabStop = false;
            // 
            // pb_Higiene2
            // 
            this.pb_Higiene2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Higiene2.Image")));
            this.pb_Higiene2.Location = new System.Drawing.Point(33, 313);
            this.pb_Higiene2.Name = "pb_Higiene2";
            this.pb_Higiene2.Size = new System.Drawing.Size(28, 28);
            this.pb_Higiene2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Higiene2.TabIndex = 39;
            this.pb_Higiene2.TabStop = false;
            // 
            // pb_Limpieza2
            // 
            this.pb_Limpieza2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Limpieza2.Image")));
            this.pb_Limpieza2.Location = new System.Drawing.Point(33, 273);
            this.pb_Limpieza2.Name = "pb_Limpieza2";
            this.pb_Limpieza2.Size = new System.Drawing.Size(28, 28);
            this.pb_Limpieza2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Limpieza2.TabIndex = 38;
            this.pb_Limpieza2.TabStop = false;
            // 
            // pb_Abarrotes2
            // 
            this.pb_Abarrotes2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Abarrotes2.Image")));
            this.pb_Abarrotes2.Location = new System.Drawing.Point(33, 233);
            this.pb_Abarrotes2.Name = "pb_Abarrotes2";
            this.pb_Abarrotes2.Size = new System.Drawing.Size(28, 28);
            this.pb_Abarrotes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Abarrotes2.TabIndex = 37;
            this.pb_Abarrotes2.TabStop = false;
            // 
            // pb_Lacteos2
            // 
            this.pb_Lacteos2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Lacteos2.Image")));
            this.pb_Lacteos2.Location = new System.Drawing.Point(33, 193);
            this.pb_Lacteos2.Name = "pb_Lacteos2";
            this.pb_Lacteos2.Size = new System.Drawing.Size(28, 28);
            this.pb_Lacteos2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Lacteos2.TabIndex = 36;
            this.pb_Lacteos2.TabStop = false;
            // 
            // pb_Carniceria2
            // 
            this.pb_Carniceria2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Carniceria2.Image")));
            this.pb_Carniceria2.Location = new System.Drawing.Point(33, 153);
            this.pb_Carniceria2.Name = "pb_Carniceria2";
            this.pb_Carniceria2.Size = new System.Drawing.Size(28, 28);
            this.pb_Carniceria2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Carniceria2.TabIndex = 35;
            this.pb_Carniceria2.TabStop = false;
            // 
            // pb_Panaderia2
            // 
            this.pb_Panaderia2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Panaderia2.Image")));
            this.pb_Panaderia2.Location = new System.Drawing.Point(33, 113);
            this.pb_Panaderia2.Name = "pb_Panaderia2";
            this.pb_Panaderia2.Size = new System.Drawing.Size(28, 28);
            this.pb_Panaderia2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Panaderia2.TabIndex = 34;
            this.pb_Panaderia2.TabStop = false;
            // 
            // pb_Frutas2
            // 
            this.pb_Frutas2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Frutas2.Image")));
            this.pb_Frutas2.Location = new System.Drawing.Point(31, 73);
            this.pb_Frutas2.Name = "pb_Frutas2";
            this.pb_Frutas2.Size = new System.Drawing.Size(28, 28);
            this.pb_Frutas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Frutas2.TabIndex = 33;
            this.pb_Frutas2.TabStop = false;
            // 
            // lbl_GananciaRefrigerados
            // 
            this.lbl_GananciaRefrigerados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaRefrigerados.AutoSize = true;
            this.lbl_GananciaRefrigerados.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaRefrigerados.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaRefrigerados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaRefrigerados.Location = new System.Drawing.Point(363, 395);
            this.lbl_GananciaRefrigerados.Name = "lbl_GananciaRefrigerados";
            this.lbl_GananciaRefrigerados.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaRefrigerados.TabIndex = 32;
            this.lbl_GananciaRefrigerados.Text = "$1,000,000.00";
            // 
            // lbl_GananciaMascotas
            // 
            this.lbl_GananciaMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaMascotas.AutoSize = true;
            this.lbl_GananciaMascotas.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaMascotas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaMascotas.Location = new System.Drawing.Point(363, 354);
            this.lbl_GananciaMascotas.Name = "lbl_GananciaMascotas";
            this.lbl_GananciaMascotas.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaMascotas.TabIndex = 31;
            this.lbl_GananciaMascotas.Text = "$1,000,000.00";
            // 
            // lbl_GananciaHigiene
            // 
            this.lbl_GananciaHigiene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaHigiene.AutoSize = true;
            this.lbl_GananciaHigiene.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaHigiene.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaHigiene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaHigiene.Location = new System.Drawing.Point(363, 315);
            this.lbl_GananciaHigiene.Name = "lbl_GananciaHigiene";
            this.lbl_GananciaHigiene.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaHigiene.TabIndex = 30;
            this.lbl_GananciaHigiene.Text = "$1,000,000.00";
            // 
            // lbl_GananciaLimpieza
            // 
            this.lbl_GananciaLimpieza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaLimpieza.AutoSize = true;
            this.lbl_GananciaLimpieza.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaLimpieza.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaLimpieza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaLimpieza.Location = new System.Drawing.Point(363, 275);
            this.lbl_GananciaLimpieza.Name = "lbl_GananciaLimpieza";
            this.lbl_GananciaLimpieza.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaLimpieza.TabIndex = 29;
            this.lbl_GananciaLimpieza.Text = "$1,000,000.00";
            // 
            // lbl_GananciaAbarrotes
            // 
            this.lbl_GananciaAbarrotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaAbarrotes.AutoSize = true;
            this.lbl_GananciaAbarrotes.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaAbarrotes.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaAbarrotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaAbarrotes.Location = new System.Drawing.Point(363, 235);
            this.lbl_GananciaAbarrotes.Name = "lbl_GananciaAbarrotes";
            this.lbl_GananciaAbarrotes.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaAbarrotes.TabIndex = 28;
            this.lbl_GananciaAbarrotes.Text = "$1,000,000.00";
            // 
            // lbl_GananciaLacteos
            // 
            this.lbl_GananciaLacteos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaLacteos.AutoSize = true;
            this.lbl_GananciaLacteos.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaLacteos.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaLacteos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaLacteos.Location = new System.Drawing.Point(363, 195);
            this.lbl_GananciaLacteos.Name = "lbl_GananciaLacteos";
            this.lbl_GananciaLacteos.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaLacteos.TabIndex = 27;
            this.lbl_GananciaLacteos.Text = "$1,000,000.00";
            // 
            // lbl_GananciaCarniceria
            // 
            this.lbl_GananciaCarniceria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaCarniceria.AutoSize = true;
            this.lbl_GananciaCarniceria.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaCarniceria.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaCarniceria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaCarniceria.Location = new System.Drawing.Point(363, 155);
            this.lbl_GananciaCarniceria.Name = "lbl_GananciaCarniceria";
            this.lbl_GananciaCarniceria.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaCarniceria.TabIndex = 26;
            this.lbl_GananciaCarniceria.Text = "$1,000,000.00";
            // 
            // lbl_DescRefrigerados2
            // 
            this.lbl_DescRefrigerados2.AutoSize = true;
            this.lbl_DescRefrigerados2.BackColor = System.Drawing.Color.White;
            this.lbl_DescRefrigerados2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescRefrigerados2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescRefrigerados2.Location = new System.Drawing.Point(85, 395);
            this.lbl_DescRefrigerados2.Name = "lbl_DescRefrigerados2";
            this.lbl_DescRefrigerados2.Size = new System.Drawing.Size(119, 25);
            this.lbl_DescRefrigerados2.TabIndex = 25;
            this.lbl_DescRefrigerados2.Text = "Refrigerados";
            // 
            // lbl_DescMascotas2
            // 
            this.lbl_DescMascotas2.AutoSize = true;
            this.lbl_DescMascotas2.BackColor = System.Drawing.Color.White;
            this.lbl_DescMascotas2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescMascotas2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescMascotas2.Location = new System.Drawing.Point(85, 355);
            this.lbl_DescMascotas2.Name = "lbl_DescMascotas2";
            this.lbl_DescMascotas2.Size = new System.Drawing.Size(91, 25);
            this.lbl_DescMascotas2.TabIndex = 24;
            this.lbl_DescMascotas2.Text = "Mascotas";
            // 
            // lbl_DescHigiene2
            // 
            this.lbl_DescHigiene2.AutoSize = true;
            this.lbl_DescHigiene2.BackColor = System.Drawing.Color.White;
            this.lbl_DescHigiene2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescHigiene2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescHigiene2.Location = new System.Drawing.Point(85, 315);
            this.lbl_DescHigiene2.Name = "lbl_DescHigiene2";
            this.lbl_DescHigiene2.Size = new System.Drawing.Size(219, 25);
            this.lbl_DescHigiene2.TabIndex = 23;
            this.lbl_DescHigiene2.Text = "Higiene personal y salud";
            // 
            // lbl_DescLimpieza2
            // 
            this.lbl_DescLimpieza2.AutoSize = true;
            this.lbl_DescLimpieza2.BackColor = System.Drawing.Color.White;
            this.lbl_DescLimpieza2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescLimpieza2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescLimpieza2.Location = new System.Drawing.Point(85, 275);
            this.lbl_DescLimpieza2.Name = "lbl_DescLimpieza2";
            this.lbl_DescLimpieza2.Size = new System.Drawing.Size(156, 25);
            this.lbl_DescLimpieza2.TabIndex = 22;
            this.lbl_DescLimpieza2.Text = "Limpieza y hogar";
            // 
            // lbl_DescAbarrotes2
            // 
            this.lbl_DescAbarrotes2.AutoSize = true;
            this.lbl_DescAbarrotes2.BackColor = System.Drawing.Color.White;
            this.lbl_DescAbarrotes2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescAbarrotes2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescAbarrotes2.Location = new System.Drawing.Point(85, 235);
            this.lbl_DescAbarrotes2.Name = "lbl_DescAbarrotes2";
            this.lbl_DescAbarrotes2.Size = new System.Drawing.Size(94, 25);
            this.lbl_DescAbarrotes2.TabIndex = 21;
            this.lbl_DescAbarrotes2.Text = "Abarrotes";
            // 
            // lbl_DescLacteos2
            // 
            this.lbl_DescLacteos2.AutoSize = true;
            this.lbl_DescLacteos2.BackColor = System.Drawing.Color.White;
            this.lbl_DescLacteos2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescLacteos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescLacteos2.Location = new System.Drawing.Point(85, 195);
            this.lbl_DescLacteos2.Name = "lbl_DescLacteos2";
            this.lbl_DescLacteos2.Size = new System.Drawing.Size(75, 25);
            this.lbl_DescLacteos2.TabIndex = 20;
            this.lbl_DescLacteos2.Text = "Lácteos";
            // 
            // lbl_DescCarniceria2
            // 
            this.lbl_DescCarniceria2.AutoSize = true;
            this.lbl_DescCarniceria2.BackColor = System.Drawing.Color.White;
            this.lbl_DescCarniceria2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescCarniceria2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescCarniceria2.Location = new System.Drawing.Point(85, 155);
            this.lbl_DescCarniceria2.Name = "lbl_DescCarniceria2";
            this.lbl_DescCarniceria2.Size = new System.Drawing.Size(98, 25);
            this.lbl_DescCarniceria2.TabIndex = 19;
            this.lbl_DescCarniceria2.Text = "Carnicería";
            // 
            // pb_Categoria
            // 
            this.pb_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.pb_Categoria.Image = ((System.Drawing.Image)(resources.GetObject("pb_Categoria.Image")));
            this.pb_Categoria.Location = new System.Drawing.Point(29, 28);
            this.pb_Categoria.Name = "pb_Categoria";
            this.pb_Categoria.Size = new System.Drawing.Size(32, 32);
            this.pb_Categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Categoria.TabIndex = 13;
            this.pb_Categoria.TabStop = false;
            // 
            // lbl_GananciaPanaderia
            // 
            this.lbl_GananciaPanaderia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaPanaderia.AutoSize = true;
            this.lbl_GananciaPanaderia.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaPanaderia.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaPanaderia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaPanaderia.Location = new System.Drawing.Point(363, 116);
            this.lbl_GananciaPanaderia.Name = "lbl_GananciaPanaderia";
            this.lbl_GananciaPanaderia.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaPanaderia.TabIndex = 18;
            this.lbl_GananciaPanaderia.Text = "$1,000,000.00";
            // 
            // lbl_GananciasCategoria
            // 
            this.lbl_GananciasCategoria.AutoSize = true;
            this.lbl_GananciasCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GananciasCategoria.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciasCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciasCategoria.Location = new System.Drawing.Point(85, 35);
            this.lbl_GananciasCategoria.Name = "lbl_GananciasCategoria";
            this.lbl_GananciasCategoria.Size = new System.Drawing.Size(228, 25);
            this.lbl_GananciasCategoria.TabIndex = 14;
            this.lbl_GananciasCategoria.Text = "Ganancias por categoría";
            // 
            // lbl_GananciaFrutas
            // 
            this.lbl_GananciaFrutas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GananciaFrutas.AutoSize = true;
            this.lbl_GananciaFrutas.BackColor = System.Drawing.Color.White;
            this.lbl_GananciaFrutas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GananciaFrutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_GananciaFrutas.Location = new System.Drawing.Point(363, 73);
            this.lbl_GananciaFrutas.Name = "lbl_GananciaFrutas";
            this.lbl_GananciaFrutas.Size = new System.Drawing.Size(124, 25);
            this.lbl_GananciaFrutas.TabIndex = 17;
            this.lbl_GananciaFrutas.Text = "$1,000,000.00";
            // 
            // lbl_DescFrutas2
            // 
            this.lbl_DescFrutas2.AutoSize = true;
            this.lbl_DescFrutas2.BackColor = System.Drawing.Color.White;
            this.lbl_DescFrutas2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescFrutas2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescFrutas2.Location = new System.Drawing.Point(85, 75);
            this.lbl_DescFrutas2.Name = "lbl_DescFrutas2";
            this.lbl_DescFrutas2.Size = new System.Drawing.Size(155, 25);
            this.lbl_DescFrutas2.TabIndex = 15;
            this.lbl_DescFrutas2.Text = "Frutas y verduras";
            // 
            // lbl_DescPanaderia2
            // 
            this.lbl_DescPanaderia2.AutoSize = true;
            this.lbl_DescPanaderia2.BackColor = System.Drawing.Color.White;
            this.lbl_DescPanaderia2.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescPanaderia2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescPanaderia2.Location = new System.Drawing.Point(85, 115);
            this.lbl_DescPanaderia2.Name = "lbl_DescPanaderia2";
            this.lbl_DescPanaderia2.Size = new System.Drawing.Size(193, 25);
            this.lbl_DescPanaderia2.TabIndex = 16;
            this.lbl_DescPanaderia2.Text = "Panadería y tortillería";
            // 
            // pnl_Entradas
            // 
            this.pnl_Entradas.BackColor = System.Drawing.Color.White;
            this.pnl_Entradas.Controls.Add(this.dgv_TablaEntradas);
            this.pnl_Entradas.Controls.Add(this.pb_Entradas);
            this.pnl_Entradas.Controls.Add(this.lbl_DescEntradas);
            this.pnl_Entradas.Controls.Add(this.lbl_EntradasTotales);
            this.pnl_Entradas.Controls.Add(this.lbl_DescEntradasTotales);
            this.pnl_Entradas.Location = new System.Drawing.Point(12, 254);
            this.pnl_Entradas.Name = "pnl_Entradas";
            this.pnl_Entradas.Size = new System.Drawing.Size(504, 319);
            this.pnl_Entradas.TabIndex = 20;
            // 
            // pb_Entradas
            // 
            this.pb_Entradas.BackColor = System.Drawing.Color.Transparent;
            this.pb_Entradas.Image = ((System.Drawing.Image)(resources.GetObject("pb_Entradas.Image")));
            this.pb_Entradas.Location = new System.Drawing.Point(29, 28);
            this.pb_Entradas.Name = "pb_Entradas";
            this.pb_Entradas.Size = new System.Drawing.Size(32, 32);
            this.pb_Entradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Entradas.TabIndex = 13;
            this.pb_Entradas.TabStop = false;
            // 
            // lbl_DescEntradas
            // 
            this.lbl_DescEntradas.AutoSize = true;
            this.lbl_DescEntradas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DescEntradas.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescEntradas.Location = new System.Drawing.Point(85, 35);
            this.lbl_DescEntradas.Name = "lbl_DescEntradas";
            this.lbl_DescEntradas.Size = new System.Drawing.Size(191, 25);
            this.lbl_DescEntradas.TabIndex = 14;
            this.lbl_DescEntradas.Text = "Entradas de efectivo";
            // 
            // lbl_EntradasTotales
            // 
            this.lbl_EntradasTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EntradasTotales.AutoSize = true;
            this.lbl_EntradasTotales.BackColor = System.Drawing.Color.White;
            this.lbl_EntradasTotales.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EntradasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_EntradasTotales.Location = new System.Drawing.Point(363, 73);
            this.lbl_EntradasTotales.Name = "lbl_EntradasTotales";
            this.lbl_EntradasTotales.Size = new System.Drawing.Size(124, 25);
            this.lbl_EntradasTotales.TabIndex = 17;
            this.lbl_EntradasTotales.Text = "$1,000,000.00";
            // 
            // lbl_DescEntradasTotales
            // 
            this.lbl_DescEntradasTotales.AutoSize = true;
            this.lbl_DescEntradasTotales.BackColor = System.Drawing.Color.White;
            this.lbl_DescEntradasTotales.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescEntradasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescEntradasTotales.Location = new System.Drawing.Point(85, 73);
            this.lbl_DescEntradasTotales.Name = "lbl_DescEntradasTotales";
            this.lbl_DescEntradasTotales.Size = new System.Drawing.Size(146, 25);
            this.lbl_DescEntradasTotales.TabIndex = 15;
            this.lbl_DescEntradasTotales.Text = "Entradas totales";
            // 
            // pnl_Salidas
            // 
            this.pnl_Salidas.BackColor = System.Drawing.Color.White;
            this.pnl_Salidas.Controls.Add(this.dgv_TablaSalidas);
            this.pnl_Salidas.Controls.Add(this.pb_Salidas);
            this.pnl_Salidas.Controls.Add(this.lbl_DescSalidas);
            this.pnl_Salidas.Controls.Add(this.lbl_SalidasTotales);
            this.pnl_Salidas.Controls.Add(this.lbl_DescSalidasTotales);
            this.pnl_Salidas.Location = new System.Drawing.Point(12, 587);
            this.pnl_Salidas.Name = "pnl_Salidas";
            this.pnl_Salidas.Size = new System.Drawing.Size(504, 319);
            this.pnl_Salidas.TabIndex = 21;
            // 
            // pb_Salidas
            // 
            this.pb_Salidas.BackColor = System.Drawing.Color.Transparent;
            this.pb_Salidas.Image = ((System.Drawing.Image)(resources.GetObject("pb_Salidas.Image")));
            this.pb_Salidas.Location = new System.Drawing.Point(29, 28);
            this.pb_Salidas.Name = "pb_Salidas";
            this.pb_Salidas.Size = new System.Drawing.Size(32, 32);
            this.pb_Salidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Salidas.TabIndex = 13;
            this.pb_Salidas.TabStop = false;
            // 
            // lbl_DescSalidas
            // 
            this.lbl_DescSalidas.AutoSize = true;
            this.lbl_DescSalidas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DescSalidas.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescSalidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescSalidas.Location = new System.Drawing.Point(85, 35);
            this.lbl_DescSalidas.Name = "lbl_DescSalidas";
            this.lbl_DescSalidas.Size = new System.Drawing.Size(175, 25);
            this.lbl_DescSalidas.TabIndex = 14;
            this.lbl_DescSalidas.Text = "Salidas de efectivo";
            // 
            // lbl_SalidasTotales
            // 
            this.lbl_SalidasTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SalidasTotales.AutoSize = true;
            this.lbl_SalidasTotales.BackColor = System.Drawing.Color.White;
            this.lbl_SalidasTotales.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalidasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_SalidasTotales.Location = new System.Drawing.Point(363, 73);
            this.lbl_SalidasTotales.Name = "lbl_SalidasTotales";
            this.lbl_SalidasTotales.Size = new System.Drawing.Size(124, 25);
            this.lbl_SalidasTotales.TabIndex = 17;
            this.lbl_SalidasTotales.Text = "$1,000,000.00";
            // 
            // lbl_DescSalidasTotales
            // 
            this.lbl_DescSalidasTotales.AutoSize = true;
            this.lbl_DescSalidasTotales.BackColor = System.Drawing.Color.White;
            this.lbl_DescSalidasTotales.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescSalidasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_DescSalidasTotales.Location = new System.Drawing.Point(85, 73);
            this.lbl_DescSalidasTotales.Name = "lbl_DescSalidasTotales";
            this.lbl_DescSalidasTotales.Size = new System.Drawing.Size(132, 25);
            this.lbl_DescSalidasTotales.TabIndex = 15;
            this.lbl_DescSalidasTotales.Text = "Salidas totales";
            // 
            // dgv_TablaEntradas
            // 
            this.dgv_TablaEntradas.AllowUserToAddRows = false;
            this.dgv_TablaEntradas.AllowUserToDeleteRows = false;
            this.dgv_TablaEntradas.AllowUserToResizeColumns = false;
            this.dgv_TablaEntradas.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_TablaEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaEntradas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_TablaEntradas.ColumnHeadersHeight = 35;
            this.dgv_TablaEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DescripcionCorteEntrada,
            this.col_ImporteCorteEntrada});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaEntradas.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_TablaEntradas.EnableHeadersVisualStyles = false;
            this.dgv_TablaEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaEntradas.Location = new System.Drawing.Point(29, 111);
            this.dgv_TablaEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TablaEntradas.Name = "dgv_TablaEntradas";
            this.dgv_TablaEntradas.RowHeadersVisible = false;
            this.dgv_TablaEntradas.RowHeadersWidth = 65;
            this.dgv_TablaEntradas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaEntradas.RowTemplate.Height = 35;
            this.dgv_TablaEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaEntradas.Size = new System.Drawing.Size(458, 187);
            this.dgv_TablaEntradas.TabIndex = 36;
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
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaEntradas.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaEntradas.ThemeStyle.ReadOnly = false;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaEntradas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // col_DescripcionCorteEntrada
            // 
            this.col_DescripcionCorteEntrada.HeaderText = "Descripcion";
            this.col_DescripcionCorteEntrada.MinimumWidth = 6;
            this.col_DescripcionCorteEntrada.Name = "col_DescripcionCorteEntrada";
            // 
            // col_ImporteCorteEntrada
            // 
            this.col_ImporteCorteEntrada.HeaderText = "Importe";
            this.col_ImporteCorteEntrada.MinimumWidth = 6;
            this.col_ImporteCorteEntrada.Name = "col_ImporteCorteEntrada";
            // 
            // dgv_TablaSalidas
            // 
            this.dgv_TablaSalidas.AllowUserToAddRows = false;
            this.dgv_TablaSalidas.AllowUserToDeleteRows = false;
            this.dgv_TablaSalidas.AllowUserToResizeColumns = false;
            this.dgv_TablaSalidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dgv_TablaSalidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_TablaSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaSalidas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaSalidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaSalidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaSalidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_TablaSalidas.ColumnHeadersHeight = 35;
            this.dgv_TablaSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DescripcionCorteSalida,
            this.col_ImporteCorteSalida});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaSalidas.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_TablaSalidas.EnableHeadersVisualStyles = false;
            this.dgv_TablaSalidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaSalidas.Location = new System.Drawing.Point(29, 111);
            this.dgv_TablaSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TablaSalidas.Name = "dgv_TablaSalidas";
            this.dgv_TablaSalidas.RowHeadersVisible = false;
            this.dgv_TablaSalidas.RowHeadersWidth = 65;
            this.dgv_TablaSalidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaSalidas.RowTemplate.Height = 35;
            this.dgv_TablaSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaSalidas.Size = new System.Drawing.Size(458, 187);
            this.dgv_TablaSalidas.TabIndex = 37;
            this.dgv_TablaSalidas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaSalidas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaSalidas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaSalidas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaSalidas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaSalidas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaSalidas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaSalidas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaSalidas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaSalidas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaSalidas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaSalidas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaSalidas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaSalidas.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaSalidas.ThemeStyle.ReadOnly = false;
            this.dgv_TablaSalidas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaSalidas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaSalidas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaSalidas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaSalidas.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaSalidas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaSalidas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // col_DescripcionCorteSalida
            // 
            this.col_DescripcionCorteSalida.HeaderText = "Descripcion";
            this.col_DescripcionCorteSalida.MinimumWidth = 6;
            this.col_DescripcionCorteSalida.Name = "col_DescripcionCorteSalida";
            // 
            // col_ImporteCorteSalida
            // 
            this.col_ImporteCorteSalida.HeaderText = "Importe";
            this.col_ImporteCorteSalida.MinimumWidth = 6;
            this.col_ImporteCorteSalida.Name = "col_ImporteCorteSalida";
            // 
            // btn_GuardarArchivo
            // 
            this.btn_GuardarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GuardarArchivo.BorderRadius = 5;
            this.btn_GuardarArchivo.CheckedState.Parent = this.btn_GuardarArchivo;
            this.btn_GuardarArchivo.CustomImages.Parent = this.btn_GuardarArchivo;
            this.btn_GuardarArchivo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_GuardarArchivo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarArchivo.HoverState.Parent = this.btn_GuardarArchivo;
            this.btn_GuardarArchivo.Location = new System.Drawing.Point(980, 113);
            this.btn_GuardarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GuardarArchivo.Name = "btn_GuardarArchivo";
            this.btn_GuardarArchivo.ShadowDecoration.Parent = this.btn_GuardarArchivo;
            this.btn_GuardarArchivo.Size = new System.Drawing.Size(171, 32);
            this.btn_GuardarArchivo.TabIndex = 74;
            this.btn_GuardarArchivo.Text = "Guardar archivo";
            // 
            // FrmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 750);
            this.Controls.Add(this.tlp_DisplayCorte);
            this.Controls.Add(this.pnl_MenuSuperior);
            this.Controls.Add(this.tlp_DisplayConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMovimientos";
            this.Text = "FrmMovimientos";
            this.pnl_ConsultarMovimientos.ResumeLayout(false);
            this.pnl_ConsultarMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaMovimientos)).EndInit();
            this.tlp_DisplayConsultar.ResumeLayout(false);
            this.pnl_MenuProductos.ResumeLayout(false);
            this.pnl_MenuProductos.PerformLayout();
            this.pnl_MenuSuperior.ResumeLayout(false);
            this.tlp_DisplayCorte.ResumeLayout(false);
            this.pnl_CorteCaja.ResumeLayout(false);
            this.pnl_CorteCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VentasTotales)).EndInit();
            this.pnl_Totales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GananciasTotales)).EndInit();
            this.pnl_VentasTotales.ResumeLayout(false);
            this.pnl_VentasTotales.PerformLayout();
            this.pnl_GananciasTotales.ResumeLayout(false);
            this.pnl_GananciasTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ventas)).EndInit();
            this.pnl_VentasMetodos.ResumeLayout(false);
            this.pnl_VentasMetodos.PerformLayout();
            this.pnl_VentasCategoria.ResumeLayout(false);
            this.pnl_VentasCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VentasCategoria)).EndInit();
            this.pnl_CorteDesplegado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refrigerados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SinCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Frutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Panaderia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Carniceria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lacteos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Abarrotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Limpieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Higiene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mascotas)).EndInit();
            this.pnl_GananciasCategoria.ResumeLayout(false);
            this.pnl_GananciasCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SinCategoria2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refrigerados2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mascotas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Higiene2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Limpieza2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Abarrotes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lacteos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Carniceria2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Panaderia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Frutas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Categoria)).EndInit();
            this.pnl_Entradas.ResumeLayout(false);
            this.pnl_Entradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Entradas)).EndInit();
            this.pnl_Salidas.ResumeLayout(false);
            this.pnl_Salidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Salidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaSalidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Panel pnl_ConsultarMovimientos;
        public Guna.UI2.WinForms.Guna2Button btn_CorteCaja;
        public Guna.UI2.WinForms.Guna2Button btn_ConsultarMovimientos;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaMovimientos;
        public Guna.UI2.WinForms.Guna2ComboBox cb_FiltroMovimientos;
        public System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Importe;
        public Guna.UI2.WinForms.Guna2Panel pnl_MenuProductos;
        public System.Windows.Forms.Label lbl_ErrorCodigoBarras;
        public Guna.UI2.WinForms.Guna2Button btn_LimpiarEntrada;
        public System.Windows.Forms.Label lbl_ErrorCantidad;
        public Guna.UI2.WinForms.Guna2Button btn_RegistrarProducto;
        public System.Windows.Forms.Label lbl_ErrorProveedor;
        public Guna.UI2.WinForms.Guna2ComboBox cb_Proveedor;
        private System.Windows.Forms.Label lbl_Proveedor;
        public Guna.UI2.WinForms.Guna2TextBox tb_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_NuevaEntrada;
        private System.Windows.Forms.Label lbl_DescripcionNueva;
        private System.Windows.Forms.Label lbl_CodigoBarra;
        public Guna.UI2.WinForms.Guna2TextBox tb_CodigoBarra;
        public System.Windows.Forms.TableLayoutPanel tlp_DisplayConsultar;
        public Guna.UI2.WinForms.Guna2Panel pnl_MenuSuperior;
        public System.Windows.Forms.Label lbl_ConsultarProductos;
        public System.Windows.Forms.Label lbl_DescripcionConsultar;
        public System.Windows.Forms.Label lbl_Hoy;
        public System.Windows.Forms.Label lbl_EsteMes;
        public System.Windows.Forms.Label lbl_EstaSemana;
        public System.Windows.Forms.TableLayoutPanel tlp_DisplayCorte;
        public Guna.UI2.WinForms.Guna2Panel pnl_CorteCaja;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_DescCorte;
        private System.Windows.Forms.Label lbl_CorteIniciado;
        private System.Windows.Forms.Label lbl_DescVentasTotales;
        private System.Windows.Forms.PictureBox pb_VentasTotales;
        private System.Windows.Forms.Panel pnl_Totales;
        private System.Windows.Forms.Label lbl_DescGanancias;
        private System.Windows.Forms.PictureBox pb_GananciasTotales;
        private System.Windows.Forms.Panel pnl_GananciasTotales;
        private System.Windows.Forms.Panel pnl_VentasTotales;
        private System.Windows.Forms.Label lbl_DescVentas;
        private System.Windows.Forms.PictureBox pb_Ventas;
        private System.Windows.Forms.Panel pnl_VentasCategoria;
        private System.Windows.Forms.PictureBox pb_VentasCategoria;
        private System.Windows.Forms.Label lbl_DesVentasCategoria;
        private System.Windows.Forms.Panel pnl_VentasMetodos;
        private System.Windows.Forms.Label lbl_DescVentasEfectivo;
        private System.Windows.Forms.Label lbl_DescVentasTarjeta;
        private System.Windows.Forms.Panel pnl_CorteDesplegado;
        private Guna.UI.WinForms.GunaLineTextBox Separador;
        private System.Windows.Forms.Panel pnl_GananciasCategoria;
        private System.Windows.Forms.PictureBox pb_SinCategoria2;
        private System.Windows.Forms.Label lbl_DescSinCategoria2;
        private System.Windows.Forms.PictureBox pb_Refrigerados2;
        private System.Windows.Forms.PictureBox pb_Mascotas2;
        private System.Windows.Forms.PictureBox pb_Higiene2;
        private System.Windows.Forms.PictureBox pb_Limpieza2;
        private System.Windows.Forms.PictureBox pb_Abarrotes2;
        private System.Windows.Forms.PictureBox pb_Lacteos2;
        private System.Windows.Forms.PictureBox pb_Carniceria2;
        private System.Windows.Forms.PictureBox pb_Panaderia2;
        private System.Windows.Forms.PictureBox pb_Frutas2;
        private System.Windows.Forms.Label lbl_DescRefrigerados2;
        private System.Windows.Forms.Label lbl_DescMascotas2;
        private System.Windows.Forms.Label lbl_DescHigiene2;
        private System.Windows.Forms.Label lbl_DescLimpieza2;
        private System.Windows.Forms.Label lbl_DescAbarrotes2;
        private System.Windows.Forms.Label lbl_DescLacteos2;
        private System.Windows.Forms.Label lbl_DescCarniceria2;
        private System.Windows.Forms.PictureBox pb_Categoria;
        private System.Windows.Forms.Label lbl_GananciasCategoria;
        private System.Windows.Forms.Label lbl_DescFrutas2;
        private System.Windows.Forms.Label lbl_DescPanaderia2;
        private System.Windows.Forms.PictureBox pb_SinCategoria;
        private System.Windows.Forms.Label lbl_DescSinCategoria;
        private System.Windows.Forms.PictureBox pb_Refrigerados;
        private System.Windows.Forms.PictureBox pb_Mascotas;
        private System.Windows.Forms.PictureBox pb_Higiene;
        private System.Windows.Forms.PictureBox pb_Limpieza;
        private System.Windows.Forms.PictureBox pb_Abarrotes;
        private System.Windows.Forms.PictureBox pb_Lacteos;
        private System.Windows.Forms.PictureBox pb_Carniceria;
        private System.Windows.Forms.PictureBox pb_Panaderia;
        private System.Windows.Forms.PictureBox pb_Frutas;
        private System.Windows.Forms.Label lbl_DescRefrigerados;
        private System.Windows.Forms.Label lbl_DescMascotas;
        private System.Windows.Forms.Label lbl_Higiene;
        private System.Windows.Forms.Label lbl_DescLimpieza;
        private System.Windows.Forms.Label lbl_DescAbarrotes;
        private System.Windows.Forms.Label lbl_DescLacteos;
        private System.Windows.Forms.Label lbl_DescCarniceria;
        private System.Windows.Forms.Label lbl_DescFrutas;
        private System.Windows.Forms.Label lbl_DescPanaderia;
        private System.Windows.Forms.Panel pnl_Salidas;
        private System.Windows.Forms.PictureBox pb_Salidas;
        private System.Windows.Forms.Label lbl_DescSalidas;
        private System.Windows.Forms.Label lbl_DescSalidasTotales;
        private System.Windows.Forms.Panel pnl_Entradas;
        private System.Windows.Forms.PictureBox pb_Entradas;
        private System.Windows.Forms.Label lbl_DescEntradas;
        private System.Windows.Forms.Label lbl_DescEntradasTotales;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DescripcionCorteSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ImporteCorteSalida;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DescripcionCorteEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ImporteCorteEntrada;
        public System.Windows.Forms.Label lbl_FechaCorte;
        public System.Windows.Forms.Label lbl_GananciasTotales;
        public System.Windows.Forms.Label lbl_VentasTotales;
        public System.Windows.Forms.Label lbl_VentasTarjeta;
        public System.Windows.Forms.Label lbl_VentasEfectivo;
        public System.Windows.Forms.Label lbl_GananciaSinCategoria;
        public System.Windows.Forms.Label lbl_GananciaRefrigerados;
        public System.Windows.Forms.Label lbl_GananciaMascotas;
        public System.Windows.Forms.Label lbl_GananciaHigiene;
        public System.Windows.Forms.Label lbl_GananciaLimpieza;
        public System.Windows.Forms.Label lbl_GananciaAbarrotes;
        public System.Windows.Forms.Label lbl_GananciaLacteos;
        public System.Windows.Forms.Label lbl_GananciaCarniceria;
        public System.Windows.Forms.Label lbl_GananciaPanaderia;
        public System.Windows.Forms.Label lbl_GananciaFrutas;
        public System.Windows.Forms.Label lbl_VentasSinCategoria;
        public System.Windows.Forms.Label lbl_VentasRefrigerados;
        public System.Windows.Forms.Label lbl_VentasMascotas;
        public System.Windows.Forms.Label lbl_VentasHigiene;
        public System.Windows.Forms.Label lbl_VentasLimpieza;
        public System.Windows.Forms.Label lbl_VentasAbarrotes;
        public System.Windows.Forms.Label lbl_VentasLacteos;
        public System.Windows.Forms.Label lbl_VentasCarniceria;
        public System.Windows.Forms.Label lbl_VentasPanaderia;
        public System.Windows.Forms.Label lbl_VentaFrutas;
        public System.Windows.Forms.Label lbl_SalidasTotales;
        public System.Windows.Forms.Label lbl_EntradasTotales;
        public Guna.UI2.WinForms.Guna2Button btn_GuardarArchivo;
    }
}