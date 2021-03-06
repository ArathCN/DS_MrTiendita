
namespace MrTiendita.Vistas
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.pb_Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.pb_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 558);
            this.panel1.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.lbl_nombre.Location = new System.Drawing.Point(76, 282);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(122, 41);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "MARSS";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(83, 174);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.ShadowDecoration.Parent = this.pb_Logo;
            this.pb_Logo.Size = new System.Drawing.Size(107, 96);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.CheckedState.Parent = this.btn_Cerrar;
            this.btn_Cerrar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.HoverState.Image")));
            this.btn_Cerrar.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.HoverState.Parent = this.btn_Cerrar;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.Location = new System.Drawing.Point(803, 4);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.PressedState.Parent = this.btn_Cerrar;
            this.btn_Cerrar.Size = new System.Drawing.Size(39, 36);
            this.btn_Cerrar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(501, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Quién eres?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(501, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
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
            this.tb_IDEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IDEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_IDEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_IDEmpleado.HoverState.Parent = this.tb_IDEmpleado;
            this.tb_IDEmpleado.Location = new System.Drawing.Point(429, 183);
            this.tb_IDEmpleado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_IDEmpleado.Name = "tb_IDEmpleado";
            this.tb_IDEmpleado.PasswordChar = '\0';
            this.tb_IDEmpleado.PlaceholderText = "";
            this.tb_IDEmpleado.SelectedText = "";
            this.tb_IDEmpleado.ShadowDecoration.Parent = this.tb_IDEmpleado;
            this.tb_IDEmpleado.Size = new System.Drawing.Size(267, 39);
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
            this.tb_claveEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_claveEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_claveEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_claveEmpleado.HoverState.Parent = this.tb_claveEmpleado;
            this.tb_claveEmpleado.Location = new System.Drawing.Point(429, 289);
            this.tb_claveEmpleado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_claveEmpleado.Name = "tb_claveEmpleado";
            this.tb_claveEmpleado.PasswordChar = '*';
            this.tb_claveEmpleado.PlaceholderText = "";
            this.tb_claveEmpleado.SelectedText = "";
            this.tb_claveEmpleado.ShadowDecoration.Parent = this.tb_claveEmpleado;
            this.tb_claveEmpleado.Size = new System.Drawing.Size(267, 39);
            this.tb_claveEmpleado.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(429, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Usuario:";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_cantidad.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lb_cantidad.Location = new System.Drawing.Point(429, 263);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(101, 23);
            this.lb_cantidad.TabIndex = 14;
            this.lb_cantidad.Text = "Contraseña:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_aceptar.BorderRadius = 5;
            this.btn_aceptar.BorderThickness = 1;
            this.btn_aceptar.CheckedState.Parent = this.btn_aceptar;
            this.btn_aceptar.CustomImages.Parent = this.btn_aceptar;
            this.btn_aceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.HoverState.Parent = this.btn_aceptar;
            this.btn_aceptar.Location = new System.Drawing.Point(499, 393);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.ShadowDecoration.Parent = this.btn_aceptar;
            this.btn_aceptar.Size = new System.Drawing.Size(131, 39);
            this.btn_aceptar.TabIndex = 15;
            this.btn_aceptar.Text = "Aceptar";
            // 
            // lbl_ErrorClave
            // 
            this.lbl_ErrorClave.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorClave.Location = new System.Drawing.Point(429, 334);
            this.lbl_ErrorClave.Name = "lbl_ErrorClave";
            this.lbl_ErrorClave.Size = new System.Drawing.Size(267, 32);
            this.lbl_ErrorClave.TabIndex = 16;
            this.lbl_ErrorClave.Text = "* Error";
            this.lbl_ErrorClave.Visible = false;
            // 
            // lbl_ErrorID
            // 
            this.lbl_ErrorID.AutoSize = true;
            this.lbl_ErrorID.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorID.Location = new System.Drawing.Point(429, 228);
            this.lbl_ErrorID.Name = "lbl_ErrorID";
            this.lbl_ErrorID.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorID.TabIndex = 17;
            this.lbl_ErrorID.Text = "* Error";
            this.lbl_ErrorID.Visible = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(849, 558);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pb_Logo;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
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
        private Guna.UI2.WinForms.Guna2ShadowForm sombra;
    }
}