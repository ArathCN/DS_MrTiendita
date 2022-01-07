
namespace MrTiendita.Vistas
{
    partial class frmCAlmacen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCAlmacen));
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_registrarEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.cb_Proveedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_ErrorCantidad = new System.Windows.Forms.Label();
            this.lbl_ErrorCodigo = new System.Windows.Forms.Label();
            this.tb_cantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_codigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_busqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_buscar.Location = new System.Drawing.Point(28, 75);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(140, 20);
            this.lbl_buscar.TabIndex = 0;
            this.lbl_buscar.Text = "Buscar producto:";
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.AllowUserToOrderColumns = true;
            this.tablaProductos.AllowUserToResizeColumns = false;
            this.tablaProductos.AllowUserToResizeRows = false;
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.ColumnHeadersVisible = false;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_barras,
            this.cantidad_actual,
            this.descripcion,
            this.precio_venta,
            this.precio_compra});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.tablaProductos.Location = new System.Drawing.Point(32, 210);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaProductos.Size = new System.Drawing.Size(800, 476);
            this.tablaProductos.TabIndex = 0;
            this.tablaProductos.TabStop = false;
            // 
            // codigo_barras
            // 
            this.codigo_barras.HeaderText = "Código de barras";
            this.codigo_barras.MinimumWidth = 6;
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            // 
            // cantidad_actual
            // 
            this.cantidad_actual.HeaderText = "Cantidad";
            this.cantidad_actual.MinimumWidth = 6;
            this.cantidad_actual.Name = "cantidad_actual";
            this.cantidad_actual.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio venta";
            this.precio_venta.MinimumWidth = 6;
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            // 
            // precio_compra
            // 
            this.precio_compra.HeaderText = "Precio compra";
            this.precio_compra.MinimumWidth = 6;
            this.precio_compra.Name = "precio_compra";
            this.precio_compra.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 168);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(723, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(17, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Proveedor:";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_cantidad.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lb_cantidad.Location = new System.Drawing.Point(17, 166);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(81, 20);
            this.lb_cantidad.TabIndex = 0;
            this.lb_cantidad.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nueva entrada";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(69, 18);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(108, 29);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Almacén";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(611, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Venta";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_Limpiar.BorderRadius = 5;
            this.btn_Limpiar.BorderThickness = 1;
            this.btn_Limpiar.CheckedState.Parent = this.btn_Limpiar;
            this.btn_Limpiar.CustomImages.Parent = this.btn_Limpiar;
            this.btn_Limpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_Limpiar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(26)))), ((int)(((byte)(19)))));
            this.btn_Limpiar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(40)))), ((int)(((byte)(29)))));
            this.btn_Limpiar.HoverState.Parent = this.btn_Limpiar;
            this.btn_Limpiar.Location = new System.Drawing.Point(157, 372);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.ShadowDecoration.Parent = this.btn_Limpiar;
            this.btn_Limpiar.Size = new System.Drawing.Size(131, 39);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            // 
            // btn_registrarEntrada
            // 
            this.btn_registrarEntrada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_registrarEntrada.BorderRadius = 5;
            this.btn_registrarEntrada.BorderThickness = 1;
            this.btn_registrarEntrada.CheckedState.Parent = this.btn_registrarEntrada;
            this.btn_registrarEntrada.CustomImages.Parent = this.btn_registrarEntrada;
            this.btn_registrarEntrada.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_registrarEntrada.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarEntrada.ForeColor = System.Drawing.Color.White;
            this.btn_registrarEntrada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(14)))));
            this.btn_registrarEntrada.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btn_registrarEntrada.HoverState.Parent = this.btn_registrarEntrada;
            this.btn_registrarEntrada.Location = new System.Drawing.Point(21, 372);
            this.btn_registrarEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registrarEntrada.Name = "btn_registrarEntrada";
            this.btn_registrarEntrada.ShadowDecoration.Parent = this.btn_registrarEntrada;
            this.btn_registrarEntrada.Size = new System.Drawing.Size(131, 39);
            this.btn_registrarEntrada.TabIndex = 4;
            this.btn_registrarEntrada.Text = "Registrar";
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.cb_Proveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.cb_Proveedor.BorderRadius = 5;
            this.cb_Proveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Proveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.cb_Proveedor.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Proveedor.FocusedState.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.cb_Proveedor.HoverState.Parent = this.cb_Proveedor;
            this.cb_Proveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Proveedor.ItemHeight = 30;
            this.cb_Proveedor.ItemsAppearance.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Location = new System.Drawing.Point(21, 286);
            this.cb_Proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.ShadowDecoration.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Size = new System.Drawing.Size(265, 36);
            this.cb_Proveedor.TabIndex = 3;
            // 
            // lbl_ErrorCantidad
            // 
            this.lbl_ErrorCantidad.AutoSize = true;
            this.lbl_ErrorCantidad.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorCantidad.Location = new System.Drawing.Point(28, 233);
            this.lbl_ErrorCantidad.Name = "lbl_ErrorCantidad";
            this.lbl_ErrorCantidad.Size = new System.Drawing.Size(48, 17);
            this.lbl_ErrorCantidad.TabIndex = 0;
            this.lbl_ErrorCantidad.Text = "* Error";
            this.lbl_ErrorCantidad.Visible = false;
            // 
            // lbl_ErrorCodigo
            // 
            this.lbl_ErrorCodigo.AutoSize = true;
            this.lbl_ErrorCodigo.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorCodigo.Location = new System.Drawing.Point(28, 135);
            this.lbl_ErrorCodigo.Name = "lbl_ErrorCodigo";
            this.lbl_ErrorCodigo.Size = new System.Drawing.Size(48, 17);
            this.lbl_ErrorCodigo.TabIndex = 0;
            this.lbl_ErrorCodigo.Text = "* Error";
            this.lbl_ErrorCodigo.Visible = false;
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_cantidad.BorderRadius = 5;
            this.tb_cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_cantidad.DefaultText = "";
            this.tb_cantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_cantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_cantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cantidad.DisabledState.Parent = this.tb_cantidad;
            this.tb_cantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_cantidad.FocusedState.Parent = this.tb_cantidad;
            this.tb_cantidad.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_cantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_cantidad.HoverState.Parent = this.tb_cantidad;
            this.tb_cantidad.Location = new System.Drawing.Point(21, 192);
            this.tb_cantidad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.PasswordChar = '\0';
            this.tb_cantidad.PlaceholderText = "";
            this.tb_cantidad.SelectedText = "";
            this.tb_cantidad.ShadowDecoration.Parent = this.tb_cantidad;
            this.tb_cantidad.Size = new System.Drawing.Size(268, 39);
            this.tb_cantidad.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(17, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código de barras:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_codigo.BorderRadius = 5;
            this.tb_codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_codigo.DefaultText = "";
            this.tb_codigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_codigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_codigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_codigo.DisabledState.Parent = this.tb_codigo;
            this.tb_codigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_codigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_codigo.FocusedState.Parent = this.tb_codigo;
            this.tb_codigo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_codigo.HoverState.Parent = this.tb_codigo;
            this.tb_codigo.Location = new System.Drawing.Point(21, 95);
            this.tb_codigo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.PasswordChar = '\0';
            this.tb_codigo.PlaceholderText = "";
            this.tb_codigo.SelectedText = "";
            this.tb_codigo.ShadowDecoration.Parent = this.tb_codigo;
            this.tb_codigo.Size = new System.Drawing.Size(267, 39);
            this.tb_codigo.TabIndex = 1;
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_busqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_busqueda.BorderRadius = 5;
            this.tb_busqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_busqueda.DefaultText = "";
            this.tb_busqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_busqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_busqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_busqueda.DisabledState.Parent = this.tb_busqueda;
            this.tb_busqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_busqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_busqueda.FocusedState.Parent = this.tb_busqueda;
            this.tb_busqueda.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_busqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_busqueda.HoverState.Parent = this.tb_busqueda;
            this.tb_busqueda.Location = new System.Drawing.Point(32, 101);
            this.tb_busqueda.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.tb_busqueda.PasswordChar = '\0';
            this.tb_busqueda.PlaceholderText = "";
            this.tb_busqueda.SelectedText = "";
            this.tb_busqueda.ShadowDecoration.Parent = this.tb_busqueda;
            this.tb_busqueda.Size = new System.Drawing.Size(429, 39);
            this.tb_busqueda.TabIndex = 1;
            this.tb_busqueda.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 108);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label7.Location = new System.Drawing.Point(965, 721);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "label7";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_Limpiar);
            this.panel2.Controls.Add(this.cb_Proveedor);
            this.panel2.Controls.Add(this.btn_registrarEntrada);
            this.panel2.Controls.Add(this.lb_cantidad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_ErrorCantidad);
            this.panel2.Controls.Add(this.tb_codigo);
            this.panel2.Controls.Add(this.lbl_ErrorCodigo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb_cantidad);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(861, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 519);
            this.panel2.TabIndex = 55;
            // 
            // frmCAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1204, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.tb_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            ";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_ErrorCantidad;
        public System.Windows.Forms.Label lbl_ErrorCodigo;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.PictureBox pictureBox3;
        public Guna.UI2.WinForms.Guna2Button btn_Limpiar;
        public Guna.UI2.WinForms.Guna2Button btn_registrarEntrada;
        public Guna.UI2.WinForms.Guna2ComboBox cb_Proveedor;
        public Guna.UI2.WinForms.Guna2TextBox tb_cantidad;
        public Guna.UI2.WinForms.Guna2TextBox tb_codigo;
        public Guna.UI2.WinForms.Guna2TextBox tb_busqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}