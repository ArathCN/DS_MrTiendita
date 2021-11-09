
namespace MrTiendita.Vistas
{
    partial class frmCCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCCaja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_aceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tablaMovimientos = new System.Windows.Forms.DataGridView();
            this.tipo_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tipoMov = new Bunifu.Framework.UI.BunifuDropdown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_importe = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(86)))));
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.BorderRadius = 7;
            this.btn_aceptar.ButtonText = "Aceptar";
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_aceptar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(8)))));
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
            this.btn_aceptar.Location = new System.Drawing.Point(16, 242);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_aceptar.selected = false;
            this.btn_aceptar.Size = new System.Drawing.Size(121, 39);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_aceptar.Textcolor = System.Drawing.Color.White;
            this.btn_aceptar.TextFont = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(294, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Últimos movimientos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(296, 145);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(834, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // tablaMovimientos
            // 
            this.tablaMovimientos.AllowUserToOrderColumns = true;
            this.tablaMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tablaMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMovimientos.ColumnHeadersVisible = false;
            this.tablaMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_mov,
            this.fecha,
            this.importe,
            this.total_caja});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaMovimientos.DefaultCellStyle = dataGridViewCellStyle7;
            this.tablaMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.tablaMovimientos.Location = new System.Drawing.Point(296, 184);
            this.tablaMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaMovimientos.Name = "tablaMovimientos";
            this.tablaMovimientos.ReadOnly = true;
            this.tablaMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaMovimientos.RowHeadersVisible = false;
            this.tablaMovimientos.RowHeadersWidth = 51;
            this.tablaMovimientos.RowTemplate.Height = 24;
            this.tablaMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaMovimientos.Size = new System.Drawing.Size(834, 324);
            this.tablaMovimientos.TabIndex = 20;
            // 
            // tipo_mov
            // 
            this.tipo_mov.HeaderText = "Tipo de movimiento";
            this.tipo_mov.MinimumWidth = 6;
            this.tipo_mov.Name = "tipo_mov";
            this.tipo_mov.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.MinimumWidth = 6;
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // total_caja
            // 
            this.total_caja.HeaderText = "Total en caja";
            this.total_caja.MinimumWidth = 6;
            this.total_caja.Name = "total_caja";
            this.total_caja.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de movimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(807, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Importe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(986, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total en caja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(575, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tipo de movimiento:";
            // 
            // cb_tipoMov
            // 
            this.cb_tipoMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_tipoMov.BorderRadius = 7;
            this.cb_tipoMov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_tipoMov.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipoMov.ForeColor = System.Drawing.Color.White;
            this.cb_tipoMov.Items = new string[] {
        "Entrada de dinero",
        "Salida de dinero"};
            this.cb_tipoMov.Location = new System.Drawing.Point(16, 82);
            this.cb_tipoMov.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_tipoMov.Name = "cb_tipoMov";
            this.cb_tipoMov.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.cb_tipoMov.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.cb_tipoMov.selectedIndex = -1;
            this.cb_tipoMov.Size = new System.Drawing.Size(210, 37);
            this.cb_tipoMov.TabIndex = 40;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 170);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Nuevo movimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(12, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Importe:";
            // 
            // tb_importe
            // 
            this.tb_importe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_importe.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_importe.Location = new System.Drawing.Point(24, 177);
            this.tb_importe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_importe.Name = "tb_importe";
            this.tb_importe.Size = new System.Drawing.Size(193, 21);
            this.tb_importe.TabIndex = 47;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 16);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(69, 18);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(61, 29);
            this.lbl_Titulo.TabIndex = 48;
            this.lbl_Titulo.Text = "Caja";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cb_tipoMov);
            this.panel2.Controls.Add(this.btn_aceptar);
            this.panel2.Controls.Add(this.tb_importe);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(32, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 410);
            this.panel2.TabIndex = 51;
            // 
            // frmCCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1204, 788);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaMovimientos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCCaja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuFlatButton btn_aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.DataGridView tablaMovimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_caja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tb_importe;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuDropdown cb_tipoMov;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}