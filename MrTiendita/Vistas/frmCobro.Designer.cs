
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.cb_metodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_efectivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_aceptar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
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
            // cb_metodoPago
            // 
            this.cb_metodoPago.BackColor = System.Drawing.Color.Transparent;
            this.cb_metodoPago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.cb_metodoPago.BorderRadius = 5;
            this.cb_metodoPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_metodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_metodoPago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.cb_metodoPago.FocusedColor = System.Drawing.Color.Empty;
            this.cb_metodoPago.FocusedState.Parent = this.cb_metodoPago;
            this.cb_metodoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_metodoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cb_metodoPago.FormattingEnabled = true;
            this.cb_metodoPago.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.cb_metodoPago.HoverState.Parent = this.cb_metodoPago;
            this.cb_metodoPago.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_metodoPago.ItemHeight = 30;
            this.cb_metodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cb_metodoPago.ItemsAppearance.Parent = this.cb_metodoPago;
            this.cb_metodoPago.Location = new System.Drawing.Point(13, 70);
            this.cb_metodoPago.Margin = new System.Windows.Forms.Padding(2);
            this.cb_metodoPago.Name = "cb_metodoPago";
            this.cb_metodoPago.ShadowDecoration.Parent = this.cb_metodoPago;
            this.cb_metodoPago.Size = new System.Drawing.Size(236, 36);
            this.cb_metodoPago.TabIndex = 83;
            // 
            // tb_efectivo
            // 
            this.tb_efectivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_efectivo.BorderRadius = 5;
            this.tb_efectivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_efectivo.DefaultText = "";
            this.tb_efectivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_efectivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_efectivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_efectivo.DisabledState.Parent = this.tb_efectivo;
            this.tb_efectivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_efectivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_efectivo.FocusedState.Parent = this.tb_efectivo;
            this.tb_efectivo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_efectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_efectivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_efectivo.HoverState.Parent = this.tb_efectivo;
            this.tb_efectivo.Location = new System.Drawing.Point(13, 136);
            this.tb_efectivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_efectivo.MaxLength = 7;
            this.tb_efectivo.Name = "tb_efectivo";
            this.tb_efectivo.PasswordChar = '\0';
            this.tb_efectivo.PlaceholderText = "";
            this.tb_efectivo.SelectedText = "";
            this.tb_efectivo.ShadowDecoration.Parent = this.tb_efectivo;
            this.tb_efectivo.Size = new System.Drawing.Size(125, 32);
            this.tb_efectivo.TabIndex = 84;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.BorderRadius = 5;
            this.btn_aceptar.BorderThickness = 1;
            this.btn_aceptar.CheckedState.Parent = this.btn_aceptar;
            this.btn_aceptar.CustomImages.Parent = this.btn_aceptar;
            this.btn_aceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(14)))));
            this.btn_aceptar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btn_aceptar.HoverState.Parent = this.btn_aceptar;
            this.btn_aceptar.Location = new System.Drawing.Point(157, 136);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.ShadowDecoration.Parent = this.btn_aceptar;
            this.btn_aceptar.Size = new System.Drawing.Size(91, 32);
            this.btn_aceptar.TabIndex = 85;
            this.btn_aceptar.Text = "Aceptar";
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 229);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.tb_efectivo);
            this.Controls.Add(this.cb_metodoPago);
            this.Controls.Add(this.lbl_cambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_Titulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCobro";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_cambio;
        public Guna.UI2.WinForms.Guna2ComboBox cb_metodoPago;
        public Guna.UI2.WinForms.Guna2TextBox tb_efectivo;
        public Guna.UI2.WinForms.Guna2Button btn_aceptar;
    }
}