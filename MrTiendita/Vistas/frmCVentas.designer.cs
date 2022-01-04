
namespace MrTiendita.Vistas
{
    partial class frmCVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.btn_aceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.restar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cantidad_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumar = new System.Windows.Forms.DataGridViewImageColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_totaltxt = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_finalizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_productos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_cantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_codigo = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 16);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(69, 18);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(84, 28);
            this.lbl_Titulo.TabIndex = 50;
            this.lbl_Titulo.Text = "Ventas";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_buscar.Location = new System.Drawing.Point(27, 76);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(144, 20);
            this.lbl_buscar.TabIndex = 53;
            this.lbl_buscar.Text = "Código de barras:";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lb_cantidad.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lb_cantidad.Location = new System.Drawing.Point(368, 76);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(81, 20);
            this.lb_cantidad.TabIndex = 56;
            this.lb_cantidad.Text = "Cantidad:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.BorderRadius = 7;
            this.btn_aceptar.ButtonText = "Aceptar";
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_aceptar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_aceptar.Iconimage = null;
            this.btn_aceptar.Iconimage_right = null;
            this.btn_aceptar.Iconimage_right_Selected = null;
            this.btn_aceptar.Iconimage_Selected = null;
            this.btn_aceptar.IconMarginLeft = 0;
            this.btn_aceptar.IconMarginRight = 0;
            this.btn_aceptar.IconRightVisible = true;
            this.btn_aceptar.IconRightZoom = 0D;
            this.btn_aceptar.IconVisible = true;
            this.btn_aceptar.IconZoom = 90D;
            this.btn_aceptar.IsTab = false;
            this.btn_aceptar.Location = new System.Drawing.Point(849, 98);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_aceptar.selected = false;
            this.btn_aceptar.Size = new System.Drawing.Size(125, 45);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_aceptar.Textcolor = System.Drawing.Color.White;
            this.btn_aceptar.TextFont = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(643, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Cantidad";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 167);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(944, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(828, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Subtotal";
            // 
            // tablaVentas
            // 
            this.tablaVentas.AllowUserToAddRows = false;
            this.tablaVentas.AllowUserToDeleteRows = false;
            this.tablaVentas.AllowUserToResizeColumns = false;
            this.tablaVentas.AllowUserToResizeRows = false;
            this.tablaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.ColumnHeadersVisible = false;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restar,
            this.cantidad_actual,
            this.sumar,
            this.descripcion,
            this.precio,
            this.subtotal,
            this.codigo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaVentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.tablaVentas.Location = new System.Drawing.Point(32, 210);
            this.tablaVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.ReadOnly = true;
            this.tablaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaVentas.RowHeadersVisible = false;
            this.tablaVentas.RowHeadersWidth = 51;
            this.tablaVentas.RowTemplate.Height = 24;
            this.tablaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaVentas.Size = new System.Drawing.Size(944, 338);
            this.tablaVentas.TabIndex = 72;
            // 
            // restar
            // 
            this.restar.HeaderText = "Restar";
            this.restar.Image = ((System.Drawing.Image)(resources.GetObject("restar.Image")));
            this.restar.MinimumWidth = 6;
            this.restar.Name = "restar";
            this.restar.ReadOnly = true;
            // 
            // cantidad_actual
            // 
            this.cantidad_actual.HeaderText = "Cantidad";
            this.cantidad_actual.MinimumWidth = 6;
            this.cantidad_actual.Name = "cantidad_actual";
            this.cantidad_actual.ReadOnly = true;
            // 
            // sumar
            // 
            this.sumar.HeaderText = "Sumar";
            this.sumar.Image = ((System.Drawing.Image)(resources.GetObject("sumar.Image")));
            this.sumar.MinimumWidth = 6;
            this.sumar.Name = "sumar";
            this.sumar.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 576);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(944, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_totaltxt
            // 
            this.lbl_totaltxt.AutoSize = true;
            this.lbl_totaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.lbl_totaltxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totaltxt.ForeColor = System.Drawing.Color.White;
            this.lbl_totaltxt.Location = new System.Drawing.Point(36, 588);
            this.lbl_totaltxt.Name = "lbl_totaltxt";
            this.lbl_totaltxt.Size = new System.Drawing.Size(112, 20);
            this.lbl_totaltxt.TabIndex = 74;
            this.lbl_totaltxt.Text = "Total a pagar:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.lbl_total.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(819, 588);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(43, 20);
            this.lbl_total.TabIndex = 75;
            this.lbl_total.Text = "0.00";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_finalizar.BorderRadius = 7;
            this.btn_finalizar.ButtonText = "Finalizar compra";
            this.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finalizar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_finalizar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.Color.White;
            this.btn_finalizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_finalizar.Iconimage = null;
            this.btn_finalizar.Iconimage_right = null;
            this.btn_finalizar.Iconimage_right_Selected = null;
            this.btn_finalizar.Iconimage_Selected = null;
            this.btn_finalizar.IconMarginLeft = 0;
            this.btn_finalizar.IconMarginRight = 0;
            this.btn_finalizar.IconRightVisible = true;
            this.btn_finalizar.IconRightZoom = 0D;
            this.btn_finalizar.IconVisible = true;
            this.btn_finalizar.IconZoom = 90D;
            this.btn_finalizar.IsTab = false;
            this.btn_finalizar.Location = new System.Drawing.Point(690, 642);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_finalizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_finalizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_finalizar.selected = false;
            this.btn_finalizar.Size = new System.Drawing.Size(149, 39);
            this.btn_finalizar.TabIndex = 5;
            this.btn_finalizar.Text = "Finalizar compra";
            this.btn_finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_finalizar.Textcolor = System.Drawing.Color.White;
            this.btn_finalizar.TextFont = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.BorderRadius = 7;
            this.btn_cancelar.ButtonText = "Cancelar";
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancelar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Iconimage = null;
            this.btn_cancelar.Iconimage_right = null;
            this.btn_cancelar.Iconimage_right_Selected = null;
            this.btn_cancelar.Iconimage_Selected = null;
            this.btn_cancelar.IconMarginLeft = 0;
            this.btn_cancelar.IconMarginRight = 0;
            this.btn_cancelar.IconRightVisible = true;
            this.btn_cancelar.IconRightZoom = 0D;
            this.btn_cancelar.IconVisible = true;
            this.btn_cancelar.IconZoom = 90D;
            this.btn_cancelar.IsTab = false;
            this.btn_cancelar.Location = new System.Drawing.Point(849, 642);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.btn_cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancelar.selected = false;
            this.btn_cancelar.Size = new System.Drawing.Size(125, 39);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Textcolor = System.Drawing.Color.White;
            this.btn_cancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(547, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Buscar un producto:";
            // 
            // cb_productos
            // 
            this.cb_productos.BackColor = System.Drawing.Color.Transparent;
            this.cb_productos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.cb_productos.BorderRadius = 5;
            this.cb_productos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_productos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.cb_productos.FocusedColor = System.Drawing.Color.Empty;
            this.cb_productos.FocusedState.Parent = this.cb_productos;
            this.cb_productos.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cb_productos.FormattingEnabled = true;
            this.cb_productos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.cb_productos.HoverState.Parent = this.cb_productos;
            this.cb_productos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_productos.ItemHeight = 30;
            this.cb_productos.ItemsAppearance.Parent = this.cb_productos;
            this.cb_productos.Location = new System.Drawing.Point(549, 99);
            this.cb_productos.Name = "cb_productos";
            this.cb_productos.ShadowDecoration.Parent = this.cb_productos;
            this.cb_productos.Size = new System.Drawing.Size(290, 36);
            this.cb_productos.TabIndex = 84;
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
            this.tb_cantidad.Location = new System.Drawing.Point(372, 99);
            this.tb_cantidad.Margin = new System.Windows.Forms.Padding(6);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.PasswordChar = '\0';
            this.tb_cantidad.PlaceholderText = "";
            this.tb_cantidad.SelectedText = "";
            this.tb_cantidad.ShadowDecoration.Parent = this.tb_cantidad;
            this.tb_cantidad.Size = new System.Drawing.Size(165, 44);
            this.tb_cantidad.TabIndex = 85;
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
            this.tb_codigo.Location = new System.Drawing.Point(32, 99);
            this.tb_codigo.Margin = new System.Windows.Forms.Padding(6);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.PasswordChar = '\0';
            this.tb_codigo.PlaceholderText = "";
            this.tb_codigo.SelectedText = "";
            this.tb_codigo.ShadowDecoration.Parent = this.tb_codigo;
            this.tb_codigo.Size = new System.Drawing.Size(331, 44);
            this.tb_codigo.TabIndex = 86;
            // 
            // frmCVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1187, 741);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.cb_productos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_totaltxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tablaVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lb_cantidad);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCVentas";
            this.Text = "frmCVentas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lb_cantidad;
        public Bunifu.Framework.UI.BunifuFlatButton btn_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tablaVentas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_totaltxt;
        public Bunifu.Framework.UI.BunifuFlatButton btn_finalizar;
        public System.Windows.Forms.Label lbl_total;
        public Bunifu.Framework.UI.BunifuFlatButton btn_cancelar;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2ComboBox cb_productos;
        public Guna.UI2.WinForms.Guna2TextBox tb_cantidad;
        public Guna.UI2.WinForms.Guna2TextBox tb_codigo;
        private System.Windows.Forms.DataGridViewImageColumn restar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_actual;
        private System.Windows.Forms.DataGridViewImageColumn sumar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
    }
}