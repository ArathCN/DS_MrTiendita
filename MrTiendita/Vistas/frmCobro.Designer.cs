
namespace MrTiendita.Vistas
{
    partial class frmCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobro));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_metodoPago = new Bunifu.Framework.UI.BunifuDropdown();
            this.tb_efectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_aceptarEfectivo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cambio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(10, 5);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(142, 19);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Pago de productos";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(241, 3);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(19, 20);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(10, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Método de pago:";
            // 
            // cb_metodoPago
            // 
            this.cb_metodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_metodoPago.BorderRadius = 7;
            this.cb_metodoPago.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_metodoPago.ForeColor = System.Drawing.Color.White;
            this.cb_metodoPago.Items = new string[] {
        "Efectivo",
        "Tarjeta"};
            this.cb_metodoPago.Location = new System.Drawing.Point(13, 72);
            this.cb_metodoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_metodoPago.Name = "cb_metodoPago";
            this.cb_metodoPago.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.cb_metodoPago.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.cb_metodoPago.selectedIndex = -1;
            this.cb_metodoPago.Size = new System.Drawing.Size(235, 30);
            this.cb_metodoPago.TabIndex = 42;
            // 
            // tb_efectivo
            // 
            this.tb_efectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_efectivo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_efectivo.Location = new System.Drawing.Point(26, 141);
            this.tb_efectivo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_efectivo.Name = "tb_efectivo";
            this.tb_efectivo.Size = new System.Drawing.Size(102, 17);
            this.tb_efectivo.TabIndex = 45;
            this.tb_efectivo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Efectivo:";
            this.label1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 135);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btn_aceptarEfectivo
            // 
            this.btn_aceptarEfectivo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(86)))));
            this.btn_aceptarEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptarEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptarEfectivo.BorderRadius = 7;
            this.btn_aceptarEfectivo.ButtonText = "Aceptar";
            this.btn_aceptarEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptarEfectivo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_aceptarEfectivo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(8)))));
            this.btn_aceptarEfectivo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_aceptarEfectivo.Iconimage = null;
            this.btn_aceptarEfectivo.Iconimage_right = null;
            this.btn_aceptarEfectivo.Iconimage_right_Selected = null;
            this.btn_aceptarEfectivo.Iconimage_Selected = null;
            this.btn_aceptarEfectivo.IconMarginLeft = 0;
            this.btn_aceptarEfectivo.IconMarginRight = 0;
            this.btn_aceptarEfectivo.IconRightVisible = true;
            this.btn_aceptarEfectivo.IconRightZoom = 0D;
            this.btn_aceptarEfectivo.IconVisible = true;
            this.btn_aceptarEfectivo.IconZoom = 90D;
            this.btn_aceptarEfectivo.IsTab = false;
            this.btn_aceptarEfectivo.Location = new System.Drawing.Point(157, 136);
            this.btn_aceptarEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_aceptarEfectivo.Name = "btn_aceptarEfectivo";
            this.btn_aceptarEfectivo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptarEfectivo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptarEfectivo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_aceptarEfectivo.selected = false;
            this.btn_aceptarEfectivo.Size = new System.Drawing.Size(91, 32);
            this.btn_aceptarEfectivo.TabIndex = 46;
            this.btn_aceptarEfectivo.Text = "Aceptar";
            this.btn_aceptarEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_aceptarEfectivo.Textcolor = System.Drawing.Color.White;
            this.btn_aceptarEfectivo.TextFont = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarEfectivo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "El cambio es:";
            this.label2.Visible = false;
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.Location = new System.Drawing.Point(100, 187);
            this.lbl_cambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(28, 17);
            this.lbl_cambio.TabIndex = 48;
            this.lbl_cambio.Text = "--.--";
            this.lbl_cambio.Visible = false;
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 229);
            this.Controls.Add(this.lbl_cambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_aceptarEfectivo);
            this.Controls.Add(this.tb_efectivo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_metodoPago);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_Titulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCobro";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_efectivo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public Bunifu.Framework.UI.BunifuFlatButton btn_aceptarEfectivo;
        public Bunifu.Framework.UI.BunifuDropdown cb_metodoPago;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_cambio;
    }
}