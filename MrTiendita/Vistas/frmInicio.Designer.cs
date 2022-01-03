
namespace MrTiendita.Vistas
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.borde = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_Cerrar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_IDEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_claveEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.btn_aceptar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_ErrorClave = new System.Windows.Forms.Label();
            this.lbl_ErrorID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borde
            // 
            this.borde.BorderRadius = 20;
            this.borde.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 453);
            this.panel1.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.lbl_nombre.Location = new System.Drawing.Point(45, 229);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(120, 27);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "MrTiendita";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(62, 141);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 78);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.CheckedState.Parent = this.btn_Cerrar;
            this.btn_Cerrar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.HoverState.Image")));
            this.btn_Cerrar.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.HoverState.Parent = this.btn_Cerrar;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.Location = new System.Drawing.Point(602, 3);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.PressedState.Parent = this.btn_Cerrar;
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 29);
            this.btn_Cerrar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(376, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Quién eres?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(376, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inicia sesión";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_IDEmpleado
            // 
            this.tb_IDEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_IDEmpleado.BorderRadius = 5;
            this.tb_IDEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_IDEmpleado.DefaultText = "";
            this.tb_IDEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_IDEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_IDEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_IDEmpleado.DisabledState.Parent = this.tb_IDEmpleado;
            this.tb_IDEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_IDEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_IDEmpleado.FocusedState.Parent = this.tb_IDEmpleado;
            this.tb_IDEmpleado.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IDEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_IDEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_IDEmpleado.HoverState.Parent = this.tb_IDEmpleado;
            this.tb_IDEmpleado.Location = new System.Drawing.Point(322, 149);
            this.tb_IDEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_IDEmpleado.Name = "tb_IDEmpleado";
            this.tb_IDEmpleado.PasswordChar = '\0';
            this.tb_IDEmpleado.PlaceholderText = "";
            this.tb_IDEmpleado.SelectedText = "";
            this.tb_IDEmpleado.ShadowDecoration.Parent = this.tb_IDEmpleado;
            this.tb_IDEmpleado.Size = new System.Drawing.Size(200, 32);
            this.tb_IDEmpleado.TabIndex = 11;
            // 
            // tb_claveEmpleado
            // 
            this.tb_claveEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_claveEmpleado.BorderRadius = 5;
            this.tb_claveEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_claveEmpleado.DefaultText = "";
            this.tb_claveEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_claveEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_claveEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_claveEmpleado.DisabledState.Parent = this.tb_claveEmpleado;
            this.tb_claveEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_claveEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_claveEmpleado.FocusedState.Parent = this.tb_claveEmpleado;
            this.tb_claveEmpleado.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_claveEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_claveEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_claveEmpleado.HoverState.Parent = this.tb_claveEmpleado;
            this.tb_claveEmpleado.Location = new System.Drawing.Point(322, 229);
            this.tb_claveEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_claveEmpleado.Name = "tb_claveEmpleado";
            this.tb_claveEmpleado.PasswordChar = '\0';
            this.tb_claveEmpleado.PlaceholderText = "";
            this.tb_claveEmpleado.SelectedText = "";
            this.tb_claveEmpleado.ShadowDecoration.Parent = this.tb_claveEmpleado;
            this.tb_claveEmpleado.Size = new System.Drawing.Size(200, 32);
            this.tb_claveEmpleado.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(322, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Usuario:";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_cantidad.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lb_cantidad.Location = new System.Drawing.Point(322, 208);
            this.lb_cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(84, 17);
            this.lb_cantidad.TabIndex = 14;
            this.lb_cantidad.Text = "Contraseña:";
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
            this.btn_aceptar.Location = new System.Drawing.Point(374, 318);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.ShadowDecoration.Parent = this.btn_aceptar;
            this.btn_aceptar.Size = new System.Drawing.Size(98, 32);
            this.btn_aceptar.TabIndex = 15;
            this.btn_aceptar.Text = "Aceptar";
            // 
            // lbl_ErrorClave
            // 
            this.lbl_ErrorClave.AutoSize = true;
            this.lbl_ErrorClave.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorClave.Location = new System.Drawing.Point(322, 266);
            this.lbl_ErrorClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ErrorClave.Name = "lbl_ErrorClave";
            this.lbl_ErrorClave.Size = new System.Drawing.Size(39, 13);
            this.lbl_ErrorClave.TabIndex = 16;
            this.lbl_ErrorClave.Text = "* Error";
            this.lbl_ErrorClave.Visible = false;
            // 
            // lbl_ErrorID
            // 
            this.lbl_ErrorID.AutoSize = true;
            this.lbl_ErrorID.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorID.Location = new System.Drawing.Point(322, 185);
            this.lbl_ErrorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ErrorID.Name = "lbl_ErrorID";
            this.lbl_ErrorID.Size = new System.Drawing.Size(39, 13);
            this.lbl_ErrorID.TabIndex = 17;
            this.lbl_ErrorID.Text = "* Error";
            this.lbl_ErrorID.Visible = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(637, 453);
            this.Controls.Add(this.lbl_ErrorClave);
            this.Controls.Add(this.lbl_ErrorID);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lb_cantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_claveEmpleado);
            this.Controls.Add(this.tb_IDEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse borde;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox tb_claveEmpleado;
        public Guna.UI2.WinForms.Guna2TextBox tb_IDEmpleado;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lb_cantidad;
        public Guna.UI2.WinForms.Guna2Button btn_aceptar;
        public System.Windows.Forms.Label lbl_ErrorClave;
        public System.Windows.Forms.Label lbl_ErrorID;
        public Guna.UI2.WinForms.Guna2ImageButton btn_Cerrar;
    }
}