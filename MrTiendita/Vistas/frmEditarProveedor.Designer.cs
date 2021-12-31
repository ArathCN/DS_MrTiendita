
namespace MrTiendita.Vistas
{
    partial class frmEditarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProveedor));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardarProveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(13, 6);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(61, 24);
            this.lbl_Titulo.TabIndex = 6;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(501, 4);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            // 
            // btn_guardarProveedor
            // 
            this.btn_guardarProveedor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(86)))));
            this.btn_guardarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_guardarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarProveedor.BorderRadius = 7;
            this.btn_guardarProveedor.ButtonText = "Guardar";
            this.btn_guardarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarProveedor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_guardarProveedor.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(8)))));
            this.btn_guardarProveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_guardarProveedor.Iconimage = null;
            this.btn_guardarProveedor.Iconimage_right = null;
            this.btn_guardarProveedor.Iconimage_right_Selected = null;
            this.btn_guardarProveedor.Iconimage_Selected = null;
            this.btn_guardarProveedor.IconMarginLeft = 0;
            this.btn_guardarProveedor.IconMarginRight = 0;
            this.btn_guardarProveedor.IconRightVisible = true;
            this.btn_guardarProveedor.IconRightZoom = 0D;
            this.btn_guardarProveedor.IconVisible = true;
            this.btn_guardarProveedor.IconZoom = 40D;
            this.btn_guardarProveedor.IsTab = false;
            this.btn_guardarProveedor.Location = new System.Drawing.Point(17, 191);
            this.btn_guardarProveedor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_guardarProveedor.Name = "btn_guardarProveedor";
            this.btn_guardarProveedor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_guardarProveedor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_guardarProveedor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_guardarProveedor.selected = false;
            this.btn_guardarProveedor.Size = new System.Drawing.Size(497, 39);
            this.btn_guardarProveedor.TabIndex = 35;
            this.btn_guardarProveedor.Text = "Guardar";
            this.btn_guardarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guardarProveedor.Textcolor = System.Drawing.Color.White;
            this.btn_guardarProveedor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tb_nombre
            // 
            this.tb_nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_nombre.BorderRadius = 5;
            this.tb_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nombre.DefaultText = "";
            this.tb_nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nombre.DisabledState.Parent = this.tb_nombre;
            this.tb_nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nombre.FocusedState.Parent = this.tb_nombre;
            this.tb_nombre.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_nombre.HoverState.Parent = this.tb_nombre;
            this.tb_nombre.Location = new System.Drawing.Point(17, 99);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(6);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PasswordChar = '\0';
            this.tb_nombre.PlaceholderText = "";
            this.tb_nombre.SelectedText = "";
            this.tb_nombre.ShadowDecoration.Parent = this.tb_nombre;
            this.tb_nombre.Size = new System.Drawing.Size(276, 39);
            this.tb_nombre.TabIndex = 36;
            // 
            // tb_telefono
            // 
            this.tb_telefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_telefono.BorderRadius = 5;
            this.tb_telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_telefono.DefaultText = "";
            this.tb_telefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_telefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_telefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_telefono.DisabledState.Parent = this.tb_telefono;
            this.tb_telefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_telefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_telefono.FocusedState.Parent = this.tb_telefono;
            this.tb_telefono.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_telefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_telefono.HoverState.Parent = this.tb_telefono;
            this.tb_telefono.Location = new System.Drawing.Point(319, 99);
            this.tb_telefono.Margin = new System.Windows.Forms.Padding(6);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.PasswordChar = '\0';
            this.tb_telefono.PlaceholderText = "";
            this.tb_telefono.SelectedText = "";
            this.tb_telefono.ShadowDecoration.Parent = this.tb_telefono;
            this.tb_telefono.Size = new System.Drawing.Size(195, 39);
            this.tb_telefono.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 35);
            this.panel1.TabIndex = 38;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(514, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 227);
            this.panel2.TabIndex = 39;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // frmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.btn_guardarProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_guardarProveedor;
        public Guna.UI2.WinForms.Guna2TextBox tb_nombre;
        public Guna.UI2.WinForms.Guna2TextBox tb_telefono;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm sombra;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}