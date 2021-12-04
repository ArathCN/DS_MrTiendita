
namespace MrTiendita.Vistas
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_busqueda = new System.Windows.Forms.TextBox();
            this.pb_lupa = new System.Windows.Forms.PictureBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.pb_buscar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tablaProveedores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_nuevoProveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_busqueda.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busqueda.Location = new System.Drawing.Point(56, 86);
            this.tb_busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.Size = new System.Drawing.Size(268, 17);
            this.tb_busqueda.TabIndex = 24;
            // 
            // pb_lupa
            // 
            this.pb_lupa.Image = ((System.Drawing.Image)(resources.GetObject("pb_lupa.Image")));
            this.pb_lupa.Location = new System.Drawing.Point(31, 84);
            this.pb_lupa.Margin = new System.Windows.Forms.Padding(2);
            this.pb_lupa.Name = "pb_lupa";
            this.pb_lupa.Size = new System.Drawing.Size(19, 20);
            this.pb_lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_lupa.TabIndex = 23;
            this.pb_lupa.TabStop = false;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(21, 61);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(121, 17);
            this.lbl_buscar.TabIndex = 22;
            this.lbl_buscar.Text = "Buscar proveedor:";
            // 
            // pb_buscar
            // 
            this.pb_buscar.Image = ((System.Drawing.Image)(resources.GetObject("pb_buscar.Image")));
            this.pb_buscar.Location = new System.Drawing.Point(24, 80);
            this.pb_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.pb_buscar.Name = "pb_buscar";
            this.pb_buscar.Size = new System.Drawing.Size(310, 32);
            this.pb_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_buscar.TabIndex = 21;
            this.pb_buscar.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(670, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Eliminar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(541, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 136);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(739, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // tablaProveedores
            // 
            this.tablaProveedores.AllowUserToOrderColumns = true;
            this.tablaProveedores.AllowUserToResizeColumns = false;
            this.tablaProveedores.AllowUserToResizeRows = false;
            this.tablaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tablaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProveedores.ColumnHeadersVisible = false;
            this.tablaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.telefono,
            this.editar,
            this.eliminar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProveedores.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.tablaProveedores.Location = new System.Drawing.Point(24, 171);
            this.tablaProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tablaProveedores.Name = "tablaProveedores";
            this.tablaProveedores.ReadOnly = true;
            this.tablaProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaProveedores.RowHeadersVisible = false;
            this.tablaProveedores.RowHeadersWidth = 51;
            this.tablaProveedores.RowTemplate.Height = 24;
            this.tablaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaProveedores.Size = new System.Drawing.Size(739, 387);
            this.tablaProveedores.TabIndex = 33;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(52, 15);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(119, 23);
            this.lbl_Titulo.TabIndex = 35;
            this.lbl_Titulo.Text = "Proveedores";
            // 
            // btn_nuevoProveedor
            // 
            this.btn_nuevoProveedor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(86)))));
            this.btn_nuevoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_nuevoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevoProveedor.BorderRadius = 7;
            this.btn_nuevoProveedor.ButtonText = "Agregar proveedor";
            this.btn_nuevoProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevoProveedor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nuevoProveedor.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(8)))));
            this.btn_nuevoProveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nuevoProveedor.Iconimage = null;
            this.btn_nuevoProveedor.Iconimage_right = null;
            this.btn_nuevoProveedor.Iconimage_right_Selected = null;
            this.btn_nuevoProveedor.Iconimage_Selected = null;
            this.btn_nuevoProveedor.IconMarginLeft = 0;
            this.btn_nuevoProveedor.IconMarginRight = 0;
            this.btn_nuevoProveedor.IconRightVisible = true;
            this.btn_nuevoProveedor.IconRightZoom = 0D;
            this.btn_nuevoProveedor.IconVisible = true;
            this.btn_nuevoProveedor.IconZoom = 90D;
            this.btn_nuevoProveedor.IsTab = false;
            this.btn_nuevoProveedor.Location = new System.Drawing.Point(350, 79);
            this.btn_nuevoProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_nuevoProveedor.Name = "btn_nuevoProveedor";
            this.btn_nuevoProveedor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_nuevoProveedor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_nuevoProveedor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nuevoProveedor.selected = false;
            this.btn_nuevoProveedor.Size = new System.Drawing.Size(130, 32);
            this.btn_nuevoProveedor.TabIndex = 37;
            this.btn_nuevoProveedor.Text = "Agregar proveedor";
            this.btn_nuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nuevoProveedor.Textcolor = System.Drawing.Color.White;
            this.btn_nuevoProveedor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(890, 640);
            this.Controls.Add(this.btn_nuevoProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.tablaProveedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_busqueda);
            this.Controls.Add(this.pb_lupa);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.pb_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_lupa;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.PictureBox pb_buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView tablaProveedores;
        public System.Windows.Forms.TextBox tb_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Titulo;
        public Bunifu.Framework.UI.BunifuFlatButton btn_nuevoProveedor;
    }
}