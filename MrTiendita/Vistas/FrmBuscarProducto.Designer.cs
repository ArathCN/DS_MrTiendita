
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.pnl_MenuSuperior = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pnl_Productos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Categoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.tb_BuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_TablaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.col_CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TipoMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CantidadAgregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AgregarCarrito = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.pnl_MenuSuperior.SuspendLayout();
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
            this.btn_Cerrar.Location = new System.Drawing.Point(675, 5);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(19, 20);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 41;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pnl_MenuSuperior
            // 
            this.pnl_MenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.pnl_MenuSuperior.Controls.Add(this.btn_Cerrar);
            this.pnl_MenuSuperior.Controls.Add(this.lbl_Titulo);
            this.pnl_MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnl_MenuSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_MenuSuperior.Name = "pnl_MenuSuperior";
            this.pnl_MenuSuperior.Size = new System.Drawing.Size(704, 31);
            this.pnl_MenuSuperior.TabIndex = 40;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(10, 3);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(173, 21);
            this.lbl_Titulo.TabIndex = 40;
            this.lbl_Titulo.Text = "Búsqueda de productos";
            // 
            // pnl_Productos
            // 
            this.pnl_Productos.Controls.Add(this.label1);
            this.pnl_Productos.Controls.Add(this.cb_Categoria);
            this.pnl_Productos.Controls.Add(this.lbl_Producto);
            this.pnl_Productos.Controls.Add(this.tb_BuscarProducto);
            this.pnl_Productos.Controls.Add(this.dgv_TablaProductos);
            this.pnl_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Productos.Location = new System.Drawing.Point(0, 31);
            this.pnl_Productos.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Productos.Name = "pnl_Productos";
            this.pnl_Productos.Size = new System.Drawing.Size(704, 462);
            this.pnl_Productos.TabIndex = 42;
            this.pnl_Productos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Productos_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Categoría de los productos:";
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.cb_Categoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.cb_Categoria.BorderRadius = 5;
            this.cb_Categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categoria.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Categoria.FocusedState.Parent = this.cb_Categoria;
            this.cb_Categoria.Font = new System.Drawing.Font("Leelawadee UI", 11.25F);
            this.cb_Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.HoverState.Parent = this.cb_Categoria;
            this.cb_Categoria.ItemHeight = 30;
            this.cb_Categoria.Items.AddRange(new object[] {
            "Todos",
            "Frutas y verduras ",
            "Panadería y tortillería ",
            "Carnicería ",
            "Lácteos ",
            "Abarrotes ",
            "Limpieza y hogar ",
            "Higiene personal y salud ",
            "Mascotas ",
            "Refrigerados",
            "Sin categoría"});
            this.cb_Categoria.ItemsAppearance.Parent = this.cb_Categoria;
            this.cb_Categoria.Location = new System.Drawing.Point(14, 51);
            this.cb_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.ShadowDecoration.Parent = this.cb_Categoria;
            this.cb_Categoria.Size = new System.Drawing.Size(238, 36);
            this.cb_Categoria.TabIndex = 20;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Producto.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Producto.Location = new System.Drawing.Point(12, 102);
            this.lbl_Producto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(104, 17);
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
            this.tb_BuscarProducto.Location = new System.Drawing.Point(14, 124);
            this.tb_BuscarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.tb_BuscarProducto.Name = "tb_BuscarProducto";
            this.tb_BuscarProducto.PasswordChar = '\0';
            this.tb_BuscarProducto.PlaceholderText = "";
            this.tb_BuscarProducto.SelectedText = "";
            this.tb_BuscarProducto.ShadowDecoration.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.Size = new System.Drawing.Size(376, 32);
            this.tb_BuscarProducto.TabIndex = 18;
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
            this.dgv_TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CodigoBarra,
            this.col_TipoMedida,
            this.col_Nombre,
            this.col_Categoria,
            this.col_Precio,
            this.col_CantidadAgregar,
            this.col_AgregarCarrito});
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
            this.dgv_TablaProductos.Location = new System.Drawing.Point(14, 173);
            this.dgv_TablaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TablaProductos.Name = "dgv_TablaProductos";
            this.dgv_TablaProductos.RowHeadersVisible = false;
            this.dgv_TablaProductos.RowHeadersWidth = 65;
            this.dgv_TablaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaProductos.RowTemplate.Height = 35;
            this.dgv_TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaProductos.Size = new System.Drawing.Size(680, 273);
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
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaProductos.ThemeStyle.ReadOnly = false;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnl_MenuSuperior;
            // 
            // col_CodigoBarra
            // 
            this.col_CodigoBarra.HeaderText = "Codigo de Barras";
            this.col_CodigoBarra.Name = "col_CodigoBarra";
            this.col_CodigoBarra.Visible = false;
            // 
            // col_TipoMedida
            // 
            this.col_TipoMedida.HeaderText = "Medida";
            this.col_TipoMedida.Name = "col_TipoMedida";
            this.col_TipoMedida.ReadOnly = true;
            this.col_TipoMedida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_TipoMedida.Visible = false;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Descripción";
            this.col_Nombre.MinimumWidth = 6;
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            this.col_Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Categoria
            // 
            this.col_Categoria.HeaderText = "Categoria";
            this.col_Categoria.MinimumWidth = 6;
            this.col_Categoria.Name = "col_Categoria";
            this.col_Categoria.ReadOnly = true;
            this.col_Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Precio
            // 
            this.col_Precio.HeaderText = "Precio";
            this.col_Precio.MinimumWidth = 6;
            this.col_Precio.Name = "col_Precio";
            this.col_Precio.ReadOnly = true;
            this.col_Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_CantidadAgregar
            // 
            this.col_CantidadAgregar.HeaderText = "Cantidad a agregar";
            this.col_CantidadAgregar.MaxInputLength = 6;
            this.col_CantidadAgregar.MinimumWidth = 6;
            this.col_CantidadAgregar.Name = "col_CantidadAgregar";
            this.col_CantidadAgregar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_CantidadAgregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_AgregarCarrito
            // 
            this.col_AgregarCarrito.HeaderText = "Agregar";
            this.col_AgregarCarrito.Image = ((System.Drawing.Image)(resources.GetObject("col_AgregarCarrito.Image")));
            this.col_AgregarCarrito.MinimumWidth = 6;
            this.col_AgregarCarrito.Name = "col_AgregarCarrito";
            this.col_AgregarCarrito.ReadOnly = true;
            this.col_AgregarCarrito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(704, 506);
            this.Controls.Add(this.pnl_Productos);
            this.Controls.Add(this.pnl_MenuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.pnl_MenuSuperior.ResumeLayout(false);
            this.pnl_MenuSuperior.PerformLayout();
            this.pnl_Productos.ResumeLayout(false);
            this.pnl_Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Panel pnl_MenuSuperior;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel pnl_Productos;
        private System.Windows.Forms.Label lbl_Producto;
        public Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm sombra;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaProductos;
        public Guna.UI2.WinForms.Guna2TextBox tb_BuscarProducto;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ComboBox cb_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CantidadAgregar;
        private System.Windows.Forms.DataGridViewImageColumn col_AgregarCarrito;
    }
}