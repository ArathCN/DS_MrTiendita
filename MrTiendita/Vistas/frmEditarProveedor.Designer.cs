
namespace MrTiendita.Vistas
{
    partial class FrmEditarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProveedor));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lbl_ErrorNombre = new System.Windows.Forms.Label();
            this.lbl_ErrorTel = new System.Windows.Forms.Label();
            this.btn_guardarProveedor = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
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
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
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
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(315, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
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
            this.tb_nombre.Font = new System.Drawing.Font("Leelawadee UI", 10.8F);
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
            this.tb_telefono.Font = new System.Drawing.Font("Leelawadee UI", 10.8F);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 35);
            this.panel1.TabIndex = 38;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // lbl_ErrorNombre
            // 
            this.lbl_ErrorNombre.AutoSize = true;
            this.lbl_ErrorNombre.Font = new System.Drawing.Font("Leelawadee UI", 7.8F);
            this.lbl_ErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorNombre.Location = new System.Drawing.Point(13, 144);
            this.lbl_ErrorNombre.Name = "lbl_ErrorNombre";
            this.lbl_ErrorNombre.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorNombre.TabIndex = 62;
            this.lbl_ErrorNombre.Text = "* Error";
            this.lbl_ErrorNombre.Visible = false;
            // 
            // lbl_ErrorTel
            // 
            this.lbl_ErrorTel.AutoSize = true;
            this.lbl_ErrorTel.Font = new System.Drawing.Font("Leelawadee UI", 7.8F);
            this.lbl_ErrorTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorTel.Location = new System.Drawing.Point(315, 144);
            this.lbl_ErrorTel.Name = "lbl_ErrorTel";
            this.lbl_ErrorTel.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorTel.TabIndex = 63;
            this.lbl_ErrorTel.Text = "* Error";
            this.lbl_ErrorTel.Visible = false;
            // 
            // btn_guardarProveedor
            // 
            this.btn_guardarProveedor.BorderRadius = 5;
            this.btn_guardarProveedor.CheckedState.Parent = this.btn_guardarProveedor;
            this.btn_guardarProveedor.CustomImages.Parent = this.btn_guardarProveedor;
            this.btn_guardarProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_guardarProveedor.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_guardarProveedor.HoverState.Parent = this.btn_guardarProveedor;
            this.btn_guardarProveedor.Location = new System.Drawing.Point(17, 197);
            this.btn_guardarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardarProveedor.Name = "btn_guardarProveedor";
            this.btn_guardarProveedor.ShadowDecoration.Parent = this.btn_guardarProveedor;
            this.btn_guardarProveedor.Size = new System.Drawing.Size(497, 39);
            this.btn_guardarProveedor.TabIndex = 69;
            this.btn_guardarProveedor.Text = "Aceptar";
            // 
            // FrmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.btn_guardarProveedor);
            this.Controls.Add(this.lbl_ErrorTel);
            this.Controls.Add(this.lbl_ErrorNombre);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEditarProveedor";
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
        public Guna.UI2.WinForms.Guna2TextBox tb_nombre;
        public Guna.UI2.WinForms.Guna2TextBox tb_telefono;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ShadowForm sombra;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public System.Windows.Forms.Label lbl_ErrorTel;
        public System.Windows.Forms.Label lbl_ErrorNombre;
        public Guna.UI2.WinForms.Guna2Button btn_guardarProveedor;
    }
}