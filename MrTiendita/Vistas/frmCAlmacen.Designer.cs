
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCAlmacen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_buscar = new System.Windows.Forms.PictureBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.pb_lupa = new System.Windows.Forms.PictureBox();
            this.tb_busqueda = new System.Windows.Forms.TextBox();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_nuevaEntradaActiva = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_busqueda2 = new System.Windows.Forms.TextBox();
            this.btn_registrarEntrada = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_buscarProducto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_granel = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_nuevaEntradaActiva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_buscar
            // 
            this.pb_buscar.Image = ((System.Drawing.Image)(resources.GetObject("pb_buscar.Image")));
            this.pb_buscar.Location = new System.Drawing.Point(32, 99);
            this.pb_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_buscar.Name = "pb_buscar";
            this.pb_buscar.Size = new System.Drawing.Size(413, 39);
            this.pb_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_buscar.TabIndex = 2;
            this.pb_buscar.TabStop = false;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_buscar.Location = new System.Drawing.Point(28, 75);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(140, 20);
            this.lbl_buscar.TabIndex = 3;
            this.lbl_buscar.Text = "Buscar producto:";
            // 
            // pb_lupa
            // 
            this.pb_lupa.Image = ((System.Drawing.Image)(resources.GetObject("pb_lupa.Image")));
            this.pb_lupa.Location = new System.Drawing.Point(41, 104);
            this.pb_lupa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_lupa.Name = "pb_lupa";
            this.pb_lupa.Size = new System.Drawing.Size(25, 25);
            this.pb_lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_lupa.TabIndex = 4;
            this.pb_lupa.TabStop = false;
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_busqueda.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busqueda.Location = new System.Drawing.Point(75, 106);
            this.tb_busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.Size = new System.Drawing.Size(357, 21);
            this.tb_busqueda.TabIndex = 5;
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToOrderColumns = true;
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
            this.precio_compra});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.tablaProductos.Location = new System.Drawing.Point(32, 211);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaProductos.Size = new System.Drawing.Size(661, 476);
            this.tablaProductos.TabIndex = 6;
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
            // precio_compra
            // 
            this.precio_compra.HeaderText = "Precio";
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
            this.pictureBox2.Size = new System.Drawing.Size(661, 44);
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
            this.label1.TabIndex = 8;
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
            this.label2.TabIndex = 9;
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
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(617, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // pnl_nuevaEntradaActiva
            // 
            this.pnl_nuevaEntradaActiva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_nuevaEntradaActiva.BackgroundImage")));
            this.pnl_nuevaEntradaActiva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_nuevaEntradaActiva.Controls.Add(this.label12);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.label8);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.check_granel);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.bunifuFlatButton1);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.lbl_total);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.tb_cantidad);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.tb_descripcion);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.tb_codigo);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.tb_busqueda2);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.btn_registrarEntrada);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.label11);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.pictureBox6);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.pictureBox8);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.pictureBox7);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.pictureBox4);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.label9);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.lb_cantidad);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.label6);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.pb_buscarProducto);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.label5);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.label7);
            this.pnl_nuevaEntradaActiva.Controls.Add(this.pictureBox3);
            this.pnl_nuevaEntradaActiva.Location = new System.Drawing.Point(713, 168);
            this.pnl_nuevaEntradaActiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_nuevaEntradaActiva.Name = "pnl_nuevaEntradaActiva";
            this.pnl_nuevaEntradaActiva.Size = new System.Drawing.Size(419, 519);
            this.pnl_nuevaEntradaActiva.TabIndex = 33;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Cancelar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(230, 458);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(162, 39);
            this.bunifuFlatButton1.TabIndex = 38;
            this.bunifuFlatButton1.Text = "Cancelar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.lbl_total.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(275, 407);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(53, 20);
            this.lbl_total.TabIndex = 44;
            this.lbl_total.Text = "$0.00";
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_cantidad.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantidad.Location = new System.Drawing.Point(40, 345);
            this.tb_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(166, 21);
            this.tb_cantidad.TabIndex = 43;
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_descripcion.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descripcion.Location = new System.Drawing.Point(40, 181);
            this.tb_descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(341, 21);
            this.tb_descripcion.TabIndex = 42;
            // 
            // tb_codigo
            // 
            this.tb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_codigo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(40, 268);
            this.tb_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(166, 21);
            this.tb_codigo.TabIndex = 41;
            // 
            // tb_busqueda2
            // 
            this.tb_busqueda2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_busqueda2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busqueda2.Location = new System.Drawing.Point(71, 90);
            this.tb_busqueda2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_busqueda2.Name = "tb_busqueda2";
            this.tb_busqueda2.Size = new System.Drawing.Size(311, 21);
            this.tb_busqueda2.TabIndex = 36;
            // 
            // btn_registrarEntrada
            // 
            this.btn_registrarEntrada.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.btn_registrarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_registrarEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarEntrada.BorderRadius = 7;
            this.btn_registrarEntrada.ButtonText = "Registrar entrada";
            this.btn_registrarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrarEntrada.DisabledColor = System.Drawing.Color.Gray;
            this.btn_registrarEntrada.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarEntrada.ForeColor = System.Drawing.Color.White;
            this.btn_registrarEntrada.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_registrarEntrada.Iconimage = null;
            this.btn_registrarEntrada.Iconimage_right = null;
            this.btn_registrarEntrada.Iconimage_right_Selected = null;
            this.btn_registrarEntrada.Iconimage_Selected = null;
            this.btn_registrarEntrada.IconMarginLeft = 0;
            this.btn_registrarEntrada.IconMarginRight = 0;
            this.btn_registrarEntrada.IconRightVisible = true;
            this.btn_registrarEntrada.IconRightZoom = 0D;
            this.btn_registrarEntrada.IconVisible = true;
            this.btn_registrarEntrada.IconZoom = 90D;
            this.btn_registrarEntrada.IsTab = false;
            this.btn_registrarEntrada.Location = new System.Drawing.Point(29, 458);
            this.btn_registrarEntrada.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_registrarEntrada.Name = "btn_registrarEntrada";
            this.btn_registrarEntrada.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_registrarEntrada.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_registrarEntrada.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_registrarEntrada.selected = false;
            this.btn_registrarEntrada.Size = new System.Drawing.Size(176, 39);
            this.btn_registrarEntrada.TabIndex = 36;
            this.btn_registrarEntrada.Text = "Registrar entrada";
            this.btn_registrarEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_registrarEntrada.Textcolor = System.Drawing.Color.White;
            this.btn_registrarEntrada.TextFont = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label11.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Total a pagar:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(29, 338);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(188, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(29, 396);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(363, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 36;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(29, 174);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(363, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 260);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(188, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(25, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Descripción:";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lb_cantidad.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lb_cantidad.Location = new System.Drawing.Point(25, 315);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(81, 20);
            this.lb_cantidad.TabIndex = 36;
            this.lb_cantidad.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(25, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Buscar producto:";
            // 
            // pb_buscarProducto
            // 
            this.pb_buscarProducto.BackColor = System.Drawing.Color.White;
            this.pb_buscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("pb_buscarProducto.Image")));
            this.pb_buscarProducto.Location = new System.Drawing.Point(38, 87);
            this.pb_buscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_buscarProducto.Name = "pb_buscarProducto";
            this.pb_buscarProducto.Size = new System.Drawing.Size(25, 25);
            this.pb_buscarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_buscarProducto.TabIndex = 37;
            this.pb_buscarProducto.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(24, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nueva entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label7.Location = new System.Drawing.Point(25, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Código de barras:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 82);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(363, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(70, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(108, 29);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Almacén";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // check_granel
            // 
            this.check_granel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_granel.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_granel.Checked = false;
            this.check_granel.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.check_granel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_granel.ForeColor = System.Drawing.Color.White;
            this.check_granel.Location = new System.Drawing.Point(259, 268);
            this.check_granel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_granel.Name = "check_granel";
            this.check_granel.Size = new System.Drawing.Size(20, 20);
            this.check_granel.TabIndex = 45;
            this.check_granel.OnChange += new System.EventHandler(this.check_granel_OnChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(292, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Granel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label12.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label12.Location = new System.Drawing.Point(241, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Tipo de medida:";
            // 
            // frmCAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1204, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pnl_nuevaEntradaActiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.tb_busqueda);
            this.Controls.Add(this.pb_lupa);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.pb_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            ";
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_nuevaEntradaActiva.ResumeLayout(false);
            this.pnl_nuevaEntradaActiva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.PictureBox pb_lupa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Panel pnl_nuevaEntradaActiva;
        public System.Windows.Forms.TextBox tb_cantidad;
        public System.Windows.Forms.TextBox tb_codigo;
        public System.Windows.Forms.TextBox tb_busqueda2;
        public Bunifu.Framework.UI.BunifuFlatButton btn_registrarEntrada;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pb_buscarProducto;
        public System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
        public System.Windows.Forms.TextBox tb_busqueda;
        public System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCheckbox check_granel;
    }
}