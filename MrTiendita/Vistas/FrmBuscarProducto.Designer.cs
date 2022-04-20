
namespace MrTiendita.Vistas
{
    partial class FrmBuscarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.pnl_MenuSuperior = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.tlp_Categorias = new System.Windows.Forms.TableLayoutPanel();
            this.btn_FrutasVerduras = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Panaderia = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Carniceria = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Lacteos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Abarrotes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Limpieza = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Hogar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Mascotas = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Refrigerados = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Productos = new System.Windows.Forms.Panel();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.dgv_TablaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.tb_BuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.pnl_MenuSuperior.SuspendLayout();
            this.tlp_Categorias.SuspendLayout();
            this.pnl_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(862, 6);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 41;
            this.btn_Cerrar.TabStop = false;
            // 
            // pnl_MenuSuperior
            // 
            this.pnl_MenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.pnl_MenuSuperior.Controls.Add(this.btn_Cerrar);
            this.pnl_MenuSuperior.Controls.Add(this.lbl_Titulo);
            this.pnl_MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnl_MenuSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_MenuSuperior.Name = "pnl_MenuSuperior";
            this.pnl_MenuSuperior.Size = new System.Drawing.Size(900, 38);
            this.pnl_MenuSuperior.TabIndex = 40;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(13, 4);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(219, 28);
            this.lbl_Titulo.TabIndex = 40;
            this.lbl_Titulo.Text = "Búsqueda de productos";
            // 
            // tlp_Categorias
            // 
            this.tlp_Categorias.ColumnCount = 3;
            this.tlp_Categorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33858F));
            this.tlp_Categorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.66142F));
            this.tlp_Categorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tlp_Categorias.Controls.Add(this.btn_FrutasVerduras, 0, 0);
            this.tlp_Categorias.Controls.Add(this.btn_Panaderia, 1, 0);
            this.tlp_Categorias.Controls.Add(this.btn_Carniceria, 2, 0);
            this.tlp_Categorias.Controls.Add(this.btn_Lacteos, 0, 1);
            this.tlp_Categorias.Controls.Add(this.btn_Abarrotes, 1, 1);
            this.tlp_Categorias.Controls.Add(this.btn_Limpieza, 2, 1);
            this.tlp_Categorias.Controls.Add(this.btn_Hogar, 0, 2);
            this.tlp_Categorias.Controls.Add(this.btn_Mascotas, 1, 2);
            this.tlp_Categorias.Controls.Add(this.btn_Refrigerados, 2, 2);
            this.tlp_Categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Categorias.Location = new System.Drawing.Point(0, 38);
            this.tlp_Categorias.Name = "tlp_Categorias";
            this.tlp_Categorias.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_Categorias.RowCount = 3;
            this.tlp_Categorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Categorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Categorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlp_Categorias.Size = new System.Drawing.Size(900, 242);
            this.tlp_Categorias.TabIndex = 41;
            // 
            // btn_FrutasVerduras
            // 
            this.btn_FrutasVerduras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_FrutasVerduras.BorderRadius = 5;
            this.btn_FrutasVerduras.BorderThickness = 1;
            this.btn_FrutasVerduras.CheckedState.Parent = this.btn_FrutasVerduras;
            this.btn_FrutasVerduras.CustomImages.Parent = this.btn_FrutasVerduras;
            this.btn_FrutasVerduras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FrutasVerduras.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_FrutasVerduras.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FrutasVerduras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_FrutasVerduras.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_FrutasVerduras.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_FrutasVerduras.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.HoverState.Image")));
            this.btn_FrutasVerduras.HoverState.Parent = this.btn_FrutasVerduras;
            this.btn_FrutasVerduras.Image = ((System.Drawing.Image)(resources.GetObject("btn_FrutasVerduras.Image")));
            this.btn_FrutasVerduras.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_FrutasVerduras.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_FrutasVerduras.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_FrutasVerduras.Location = new System.Drawing.Point(10, 10);
            this.btn_FrutasVerduras.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FrutasVerduras.Name = "btn_FrutasVerduras";
            this.btn_FrutasVerduras.ShadowDecoration.Parent = this.btn_FrutasVerduras;
            this.btn_FrutasVerduras.Size = new System.Drawing.Size(301, 67);
            this.btn_FrutasVerduras.TabIndex = 0;
            this.btn_FrutasVerduras.Text = "Frutas y verduras";
            this.btn_FrutasVerduras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_FrutasVerduras.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Panaderia
            // 
            this.btn_Panaderia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Panaderia.BorderRadius = 5;
            this.btn_Panaderia.BorderThickness = 1;
            this.btn_Panaderia.CheckedState.Parent = this.btn_Panaderia;
            this.btn_Panaderia.CustomImages.Parent = this.btn_Panaderia;
            this.btn_Panaderia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Panaderia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Panaderia.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Panaderia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Panaderia.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Panaderia.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Panaderia.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.HoverState.Image")));
            this.btn_Panaderia.HoverState.Parent = this.btn_Panaderia;
            this.btn_Panaderia.Image = ((System.Drawing.Image)(resources.GetObject("btn_Panaderia.Image")));
            this.btn_Panaderia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Panaderia.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Panaderia.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Panaderia.Location = new System.Drawing.Point(321, 10);
            this.btn_Panaderia.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Panaderia.Name = "btn_Panaderia";
            this.btn_Panaderia.ShadowDecoration.Parent = this.btn_Panaderia;
            this.btn_Panaderia.Size = new System.Drawing.Size(285, 67);
            this.btn_Panaderia.TabIndex = 1;
            this.btn_Panaderia.Text = "Panadería y tortillería";
            this.btn_Panaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Panaderia.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Carniceria
            // 
            this.btn_Carniceria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Carniceria.BorderRadius = 5;
            this.btn_Carniceria.BorderThickness = 1;
            this.btn_Carniceria.CheckedState.Parent = this.btn_Carniceria;
            this.btn_Carniceria.CustomImages.Parent = this.btn_Carniceria;
            this.btn_Carniceria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Carniceria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Carniceria.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Carniceria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Carniceria.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Carniceria.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Carniceria.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.HoverState.Image")));
            this.btn_Carniceria.HoverState.Parent = this.btn_Carniceria;
            this.btn_Carniceria.Image = ((System.Drawing.Image)(resources.GetObject("btn_Carniceria.Image")));
            this.btn_Carniceria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Carniceria.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Carniceria.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Carniceria.Location = new System.Drawing.Point(616, 10);
            this.btn_Carniceria.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Carniceria.Name = "btn_Carniceria";
            this.btn_Carniceria.ShadowDecoration.Parent = this.btn_Carniceria;
            this.btn_Carniceria.Size = new System.Drawing.Size(274, 67);
            this.btn_Carniceria.TabIndex = 2;
            this.btn_Carniceria.Text = "Carnicería";
            this.btn_Carniceria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Carniceria.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Lacteos
            // 
            this.btn_Lacteos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Lacteos.BorderRadius = 5;
            this.btn_Lacteos.BorderThickness = 1;
            this.btn_Lacteos.CheckedState.Parent = this.btn_Lacteos;
            this.btn_Lacteos.CustomImages.Parent = this.btn_Lacteos;
            this.btn_Lacteos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Lacteos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Lacteos.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lacteos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Lacteos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Lacteos.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Lacteos.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.HoverState.Image")));
            this.btn_Lacteos.HoverState.Parent = this.btn_Lacteos;
            this.btn_Lacteos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lacteos.Image")));
            this.btn_Lacteos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Lacteos.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Lacteos.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Lacteos.Location = new System.Drawing.Point(10, 87);
            this.btn_Lacteos.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Lacteos.Name = "btn_Lacteos";
            this.btn_Lacteos.ShadowDecoration.Parent = this.btn_Lacteos;
            this.btn_Lacteos.Size = new System.Drawing.Size(301, 67);
            this.btn_Lacteos.TabIndex = 3;
            this.btn_Lacteos.Text = "Lácteos";
            this.btn_Lacteos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Lacteos.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Abarrotes
            // 
            this.btn_Abarrotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Abarrotes.BorderRadius = 5;
            this.btn_Abarrotes.BorderThickness = 1;
            this.btn_Abarrotes.CheckedState.Parent = this.btn_Abarrotes;
            this.btn_Abarrotes.CustomImages.Parent = this.btn_Abarrotes;
            this.btn_Abarrotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Abarrotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Abarrotes.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abarrotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Abarrotes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Abarrotes.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Abarrotes.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.HoverState.Image")));
            this.btn_Abarrotes.HoverState.Parent = this.btn_Abarrotes;
            this.btn_Abarrotes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Abarrotes.Image")));
            this.btn_Abarrotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Abarrotes.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Abarrotes.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Abarrotes.Location = new System.Drawing.Point(321, 87);
            this.btn_Abarrotes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Abarrotes.Name = "btn_Abarrotes";
            this.btn_Abarrotes.ShadowDecoration.Parent = this.btn_Abarrotes;
            this.btn_Abarrotes.Size = new System.Drawing.Size(285, 67);
            this.btn_Abarrotes.TabIndex = 4;
            this.btn_Abarrotes.Text = "Abarrotes";
            this.btn_Abarrotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Abarrotes.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Limpieza
            // 
            this.btn_Limpieza.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Limpieza.BorderRadius = 5;
            this.btn_Limpieza.BorderThickness = 1;
            this.btn_Limpieza.CheckedState.Parent = this.btn_Limpieza;
            this.btn_Limpieza.CustomImages.Parent = this.btn_Limpieza;
            this.btn_Limpieza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Limpieza.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Limpieza.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpieza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Limpieza.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Limpieza.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Limpieza.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.HoverState.Image")));
            this.btn_Limpieza.HoverState.Parent = this.btn_Limpieza;
            this.btn_Limpieza.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpieza.Image")));
            this.btn_Limpieza.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Limpieza.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Limpieza.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Limpieza.Location = new System.Drawing.Point(616, 87);
            this.btn_Limpieza.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Limpieza.Name = "btn_Limpieza";
            this.btn_Limpieza.ShadowDecoration.Parent = this.btn_Limpieza;
            this.btn_Limpieza.Size = new System.Drawing.Size(274, 67);
            this.btn_Limpieza.TabIndex = 5;
            this.btn_Limpieza.Text = "Limpieza y hogar";
            this.btn_Limpieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Limpieza.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Hogar
            // 
            this.btn_Hogar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Hogar.BorderRadius = 5;
            this.btn_Hogar.BorderThickness = 1;
            this.btn_Hogar.CheckedState.Parent = this.btn_Hogar;
            this.btn_Hogar.CustomImages.Parent = this.btn_Hogar;
            this.btn_Hogar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Hogar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Hogar.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Hogar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Hogar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Hogar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.HoverState.Image")));
            this.btn_Hogar.HoverState.Parent = this.btn_Hogar;
            this.btn_Hogar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hogar.Image")));
            this.btn_Hogar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Hogar.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Hogar.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Hogar.Location = new System.Drawing.Point(10, 164);
            this.btn_Hogar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Hogar.Name = "btn_Hogar";
            this.btn_Hogar.ShadowDecoration.Parent = this.btn_Hogar;
            this.btn_Hogar.Size = new System.Drawing.Size(301, 68);
            this.btn_Hogar.TabIndex = 6;
            this.btn_Hogar.Text = "Higiene personal y salud";
            this.btn_Hogar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Hogar.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Mascotas
            // 
            this.btn_Mascotas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Mascotas.BorderRadius = 5;
            this.btn_Mascotas.BorderThickness = 1;
            this.btn_Mascotas.CheckedState.Parent = this.btn_Mascotas;
            this.btn_Mascotas.CustomImages.Parent = this.btn_Mascotas;
            this.btn_Mascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Mascotas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Mascotas.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Mascotas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Mascotas.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Mascotas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button8.HoverState.Image")));
            this.btn_Mascotas.HoverState.Parent = this.btn_Mascotas;
            this.btn_Mascotas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mascotas.Image")));
            this.btn_Mascotas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Mascotas.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Mascotas.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Mascotas.Location = new System.Drawing.Point(321, 164);
            this.btn_Mascotas.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Mascotas.Name = "btn_Mascotas";
            this.btn_Mascotas.ShadowDecoration.Parent = this.btn_Mascotas;
            this.btn_Mascotas.Size = new System.Drawing.Size(285, 68);
            this.btn_Mascotas.TabIndex = 7;
            this.btn_Mascotas.Text = "Mascotas";
            this.btn_Mascotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Mascotas.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btn_Refrigerados
            // 
            this.btn_Refrigerados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Refrigerados.BorderRadius = 5;
            this.btn_Refrigerados.BorderThickness = 1;
            this.btn_Refrigerados.CheckedState.Parent = this.btn_Refrigerados;
            this.btn_Refrigerados.CustomImages.Parent = this.btn_Refrigerados;
            this.btn_Refrigerados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Refrigerados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Refrigerados.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refrigerados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Refrigerados.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Refrigerados.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Refrigerados.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.HoverState.Image")));
            this.btn_Refrigerados.HoverState.Parent = this.btn_Refrigerados;
            this.btn_Refrigerados.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refrigerados.Image")));
            this.btn_Refrigerados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Refrigerados.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Refrigerados.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_Refrigerados.Location = new System.Drawing.Point(616, 164);
            this.btn_Refrigerados.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Refrigerados.Name = "btn_Refrigerados";
            this.btn_Refrigerados.ShadowDecoration.Parent = this.btn_Refrigerados;
            this.btn_Refrigerados.Size = new System.Drawing.Size(274, 68);
            this.btn_Refrigerados.TabIndex = 8;
            this.btn_Refrigerados.Text = "Refrigerados";
            this.btn_Refrigerados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Refrigerados.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // pnl_Productos
            // 
            this.pnl_Productos.Controls.Add(this.lbl_Producto);
            this.pnl_Productos.Controls.Add(this.tb_BuscarProducto);
            this.pnl_Productos.Controls.Add(this.dgv_TablaProductos);
            this.pnl_Productos.Controls.Add(this.lbl_Categoria);
            this.pnl_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Productos.Location = new System.Drawing.Point(0, 280);
            this.pnl_Productos.Name = "pnl_Productos";
            this.pnl_Productos.Size = new System.Drawing.Size(900, 471);
            this.pnl_Productos.TabIndex = 42;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.White;
            this.lbl_Categoria.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Categoria.Location = new System.Drawing.Point(14, 15);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(126, 32);
            this.lbl_Categoria.TabIndex = 5;
            this.lbl_Categoria.Text = "Categoría";
            // 
            // dgv_TablaProductos
            // 
            this.dgv_TablaProductos.AllowUserToAddRows = false;
            this.dgv_TablaProductos.AllowUserToDeleteRows = false;
            this.dgv_TablaProductos.AllowUserToResizeColumns = false;
            this.dgv_TablaProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TablaProductos.ColumnHeadersHeight = 35;
            this.dgv_TablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Nombre,
            this.col_Telefono,
            this.col_Editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TablaProductos.EnableHeadersVisualStyles = false;
            this.dgv_TablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProductos.Location = new System.Drawing.Point(18, 147);
            this.dgv_TablaProductos.Name = "dgv_TablaProductos";
            this.dgv_TablaProductos.ReadOnly = true;
            this.dgv_TablaProductos.RowHeadersVisible = false;
            this.dgv_TablaProductos.RowHeadersWidth = 65;
            this.dgv_TablaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaProductos.RowTemplate.Height = 35;
            this.dgv_TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaProductos.Size = new System.Drawing.Size(869, 314);
            this.dgv_TablaProductos.TabIndex = 16;
            this.dgv_TablaProductos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaProductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaProductos.ThemeStyle.ReadOnly = true;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.White;
            this.lbl_Producto.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Producto.Location = new System.Drawing.Point(16, 60);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(135, 23);
            this.lbl_Producto.TabIndex = 19;
            this.lbl_Producto.Text = "Buscar producto";
            // 
            // tb_BuscarProducto
            // 
            this.tb_BuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_BuscarProducto.BorderRadius = 5;
            this.tb_BuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_BuscarProducto.DefaultText = "";
            this.tb_BuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_BuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_BuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarProducto.DisabledState.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarProducto.FocusedState.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarProducto.HoverState.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_BuscarProducto.IconLeft")));
            this.tb_BuscarProducto.Location = new System.Drawing.Point(18, 87);
            this.tb_BuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tb_BuscarProducto.Name = "tb_BuscarProducto";
            this.tb_BuscarProducto.PasswordChar = '\0';
            this.tb_BuscarProducto.PlaceholderText = "";
            this.tb_BuscarProducto.SelectedText = "";
            this.tb_BuscarProducto.ShadowDecoration.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.Size = new System.Drawing.Size(501, 40);
            this.tb_BuscarProducto.TabIndex = 18;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Descripción";
            this.col_Nombre.MinimumWidth = 6;
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_Telefono
            // 
            this.col_Telefono.HeaderText = "Precio";
            this.col_Telefono.MinimumWidth = 6;
            this.col_Telefono.Name = "col_Telefono";
            this.col_Telefono.ReadOnly = true;
            // 
            // col_Editar
            // 
            this.col_Editar.HeaderText = "Agregar al carrito";
            this.col_Editar.Image = ((System.Drawing.Image)(resources.GetObject("col_Editar.Image")));
            this.col_Editar.MinimumWidth = 6;
            this.col_Editar.Name = "col_Editar";
            this.col_Editar.ReadOnly = true;
            // 
            // FrmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(900, 753);
            this.Controls.Add(this.pnl_Productos);
            this.Controls.Add(this.tlp_Categorias);
            this.Controls.Add(this.pnl_MenuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarProducto";
            this.Text = "FrmBuscarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.pnl_MenuSuperior.ResumeLayout(false);
            this.pnl_MenuSuperior.PerformLayout();
            this.tlp_Categorias.ResumeLayout(false);
            this.pnl_Productos.ResumeLayout(false);
            this.pnl_Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Panel pnl_MenuSuperior;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TableLayoutPanel tlp_Categorias;
        private Guna.UI2.WinForms.Guna2Button btn_FrutasVerduras;
        private Guna.UI2.WinForms.Guna2Button btn_Panaderia;
        private Guna.UI2.WinForms.Guna2Button btn_Carniceria;
        private Guna.UI2.WinForms.Guna2Button btn_Lacteos;
        private Guna.UI2.WinForms.Guna2Button btn_Abarrotes;
        private Guna.UI2.WinForms.Guna2Button btn_Limpieza;
        private Guna.UI2.WinForms.Guna2Button btn_Hogar;
        private Guna.UI2.WinForms.Guna2Button btn_Mascotas;
        private Guna.UI2.WinForms.Guna2Button btn_Refrigerados;
        private System.Windows.Forms.Panel pnl_Productos;
        private System.Windows.Forms.Label lbl_Categoria;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_TablaProductos;
        private System.Windows.Forms.Label lbl_Producto;
        private Guna.UI2.WinForms.Guna2TextBox tb_BuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefono;
        private System.Windows.Forms.DataGridViewImageColumn col_Editar;
    }
}