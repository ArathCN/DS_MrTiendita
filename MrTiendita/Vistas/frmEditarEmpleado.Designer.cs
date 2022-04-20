
namespace MrTiendita.Vistas
{
    partial class FrmEditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.tb_idEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_apMaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_encargado = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rb_cajero = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lbl_encargado = new System.Windows.Forms.Label();
            this.lbl_cajero = new System.Windows.Forms.Label();
            this.tb_apPaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_sueldo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_clave = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lbl_ErrorID = new System.Windows.Forms.Label();
            this.lbl_ErrorNombre = new System.Windows.Forms.Label();
            this.lbl_ErrorAp = new System.Windows.Forms.Label();
            this.lbl_ErrorTel = new System.Windows.Forms.Label();
            this.lbl_ErrorAm = new System.Windows.Forms.Label();
            this.lbl_ErrorSue = new System.Windows.Forms.Label();
            this.lbl_ErrorClave = new System.Windows.Forms.Label();
            this.btn_Aceptar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Controls.Add(this.lbl_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 38);
            this.panel1.TabIndex = 39;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(591, 6);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 41;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(13, 4);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(62, 28);
            this.lbl_Titulo.TabIndex = 40;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // tb_idEmpleado
            // 
            this.tb_idEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_idEmpleado.BorderRadius = 5;
            this.tb_idEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_idEmpleado.DefaultText = "";
            this.tb_idEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_idEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_idEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_idEmpleado.DisabledState.Parent = this.tb_idEmpleado;
            this.tb_idEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_idEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_idEmpleado.FocusedState.Parent = this.tb_idEmpleado;
            this.tb_idEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_idEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_idEmpleado.HoverState.Parent = this.tb_idEmpleado;
            this.tb_idEmpleado.Location = new System.Drawing.Point(17, 82);
            this.tb_idEmpleado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_idEmpleado.Name = "tb_idEmpleado";
            this.tb_idEmpleado.PasswordChar = '\0';
            this.tb_idEmpleado.PlaceholderText = "";
            this.tb_idEmpleado.SelectedText = "";
            this.tb_idEmpleado.ShadowDecoration.Parent = this.tb_idEmpleado;
            this.tb_idEmpleado.Size = new System.Drawing.Size(276, 39);
            this.tb_idEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Usuario:";
            // 
            // tb_apMaterno
            // 
            this.tb_apMaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_apMaterno.BorderRadius = 5;
            this.tb_apMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_apMaterno.DefaultText = "";
            this.tb_apMaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_apMaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_apMaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_apMaterno.DisabledState.Parent = this.tb_apMaterno;
            this.tb_apMaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_apMaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_apMaterno.FocusedState.Parent = this.tb_apMaterno;
            this.tb_apMaterno.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_apMaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_apMaterno.HoverState.Parent = this.tb_apMaterno;
            this.tb_apMaterno.Location = new System.Drawing.Point(404, 184);
            this.tb_apMaterno.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_apMaterno.Name = "tb_apMaterno";
            this.tb_apMaterno.PasswordChar = '\0';
            this.tb_apMaterno.PlaceholderText = "";
            this.tb_apMaterno.SelectedText = "";
            this.tb_apMaterno.ShadowDecoration.Parent = this.tb_apMaterno;
            this.tb_apMaterno.Size = new System.Drawing.Size(197, 39);
            this.tb_apMaterno.TabIndex = 6;
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
            this.tb_nombre.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_nombre.HoverState.Parent = this.tb_nombre;
            this.tb_nombre.Location = new System.Drawing.Point(17, 184);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PasswordChar = '\0';
            this.tb_nombre.PlaceholderText = "";
            this.tb_nombre.SelectedText = "";
            this.tb_nombre.ShadowDecoration.Parent = this.tb_nombre;
            this.tb_nombre.Size = new System.Drawing.Size(167, 39);
            this.tb_nombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo de empleado:";
            // 
            // rb_encargado
            // 
            this.rb_encargado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(8)))));
            this.rb_encargado.CheckedState.BorderThickness = 0;
            this.rb_encargado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.rb_encargado.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_encargado.CheckedState.Parent = this.rb_encargado;
            this.rb_encargado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_encargado.Location = new System.Drawing.Point(317, 90);
            this.rb_encargado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_encargado.Name = "rb_encargado";
            this.rb_encargado.ShadowDecoration.Parent = this.rb_encargado;
            this.rb_encargado.Size = new System.Drawing.Size(20, 18);
            this.rb_encargado.TabIndex = 2;
            this.rb_encargado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_encargado.UncheckedState.BorderThickness = 2;
            this.rb_encargado.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_encargado.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_encargado.UncheckedState.Parent = this.rb_encargado;
            // 
            // rb_cajero
            // 
            this.rb_cajero.Checked = true;
            this.rb_cajero.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(8)))));
            this.rb_cajero.CheckedState.BorderThickness = 0;
            this.rb_cajero.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.rb_cajero.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_cajero.CheckedState.Parent = this.rb_cajero;
            this.rb_cajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_cajero.Location = new System.Drawing.Point(477, 90);
            this.rb_cajero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_cajero.Name = "rb_cajero";
            this.rb_cajero.ShadowDecoration.Parent = this.rb_cajero;
            this.rb_cajero.Size = new System.Drawing.Size(20, 18);
            this.rb_cajero.TabIndex = 3;
            this.rb_cajero.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_cajero.UncheckedState.BorderThickness = 2;
            this.rb_cajero.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_cajero.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_cajero.UncheckedState.Parent = this.rb_cajero;
            // 
            // lbl_encargado
            // 
            this.lbl_encargado.AutoSize = true;
            this.lbl_encargado.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encargado.Location = new System.Drawing.Point(343, 87);
            this.lbl_encargado.Name = "lbl_encargado";
            this.lbl_encargado.Size = new System.Drawing.Size(91, 23);
            this.lbl_encargado.TabIndex = 48;
            this.lbl_encargado.Text = "Encargado";
            // 
            // lbl_cajero
            // 
            this.lbl_cajero.AutoSize = true;
            this.lbl_cajero.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cajero.Location = new System.Drawing.Point(506, 87);
            this.lbl_cajero.Name = "lbl_cajero";
            this.lbl_cajero.Size = new System.Drawing.Size(59, 23);
            this.lbl_cajero.TabIndex = 49;
            this.lbl_cajero.Text = "Cajero";
            // 
            // tb_apPaterno
            // 
            this.tb_apPaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_apPaterno.BorderRadius = 5;
            this.tb_apPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_apPaterno.DefaultText = "";
            this.tb_apPaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_apPaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_apPaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_apPaterno.DisabledState.Parent = this.tb_apPaterno;
            this.tb_apPaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_apPaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_apPaterno.FocusedState.Parent = this.tb_apPaterno;
            this.tb_apPaterno.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_apPaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_apPaterno.HoverState.Parent = this.tb_apPaterno;
            this.tb_apPaterno.Location = new System.Drawing.Point(195, 184);
            this.tb_apPaterno.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_apPaterno.Name = "tb_apPaterno";
            this.tb_apPaterno.PasswordChar = '\0';
            this.tb_apPaterno.PlaceholderText = "";
            this.tb_apPaterno.SelectedText = "";
            this.tb_apPaterno.ShadowDecoration.Parent = this.tb_apPaterno;
            this.tb_apPaterno.Size = new System.Drawing.Size(197, 39);
            this.tb_apPaterno.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "Apellido materno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 53;
            this.label7.Text = "Apellido paterno:";
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
            this.tb_telefono.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_telefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_telefono.HoverState.Parent = this.tb_telefono;
            this.tb_telefono.Location = new System.Drawing.Point(19, 286);
            this.tb_telefono.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.PasswordChar = '\0';
            this.tb_telefono.PlaceholderText = "";
            this.tb_telefono.SelectedText = "";
            this.tb_telefono.ShadowDecoration.Parent = this.tb_telefono;
            this.tb_telefono.Size = new System.Drawing.Size(165, 39);
            this.tb_telefono.TabIndex = 7;
            // 
            // tb_sueldo
            // 
            this.tb_sueldo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_sueldo.BorderRadius = 5;
            this.tb_sueldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sueldo.DefaultText = "";
            this.tb_sueldo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_sueldo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_sueldo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_sueldo.DisabledState.Parent = this.tb_sueldo;
            this.tb_sueldo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_sueldo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_sueldo.FocusedState.Parent = this.tb_sueldo;
            this.tb_sueldo.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sueldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_sueldo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_sueldo.HoverState.Parent = this.tb_sueldo;
            this.tb_sueldo.Location = new System.Drawing.Point(195, 286);
            this.tb_sueldo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_sueldo.Name = "tb_sueldo";
            this.tb_sueldo.PasswordChar = '\0';
            this.tb_sueldo.PlaceholderText = "";
            this.tb_sueldo.SelectedText = "";
            this.tb_sueldo.ShadowDecoration.Parent = this.tb_sueldo;
            this.tb_sueldo.Size = new System.Drawing.Size(167, 39);
            this.tb_sueldo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "Teléfono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Sueldo:";
            // 
            // tb_clave
            // 
            this.tb_clave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.tb_clave.BorderRadius = 5;
            this.tb_clave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_clave.DefaultText = "";
            this.tb_clave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_clave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_clave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_clave.DisabledState.Parent = this.tb_clave;
            this.tb_clave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_clave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_clave.FocusedState.Parent = this.tb_clave;
            this.tb_clave.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_clave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.tb_clave.HoverState.Parent = this.tb_clave;
            this.tb_clave.Location = new System.Drawing.Point(373, 286);
            this.tb_clave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_clave.Name = "tb_clave";
            this.tb_clave.PasswordChar = '\0';
            this.tb_clave.PlaceholderText = "";
            this.tb_clave.SelectedText = "";
            this.tb_clave.ShadowDecoration.Parent = this.tb_clave;
            this.tb_clave.Size = new System.Drawing.Size(227, 39);
            this.tb_clave.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 59;
            this.label10.Text = "Contraseña:";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // lbl_ErrorID
            // 
            this.lbl_ErrorID.AutoSize = true;
            this.lbl_ErrorID.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorID.Location = new System.Drawing.Point(17, 128);
            this.lbl_ErrorID.Name = "lbl_ErrorID";
            this.lbl_ErrorID.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorID.TabIndex = 61;
            this.lbl_ErrorID.Text = "* Error";
            this.lbl_ErrorID.Visible = false;
            // 
            // lbl_ErrorNombre
            // 
            this.lbl_ErrorNombre.AutoSize = true;
            this.lbl_ErrorNombre.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorNombre.Location = new System.Drawing.Point(17, 228);
            this.lbl_ErrorNombre.Name = "lbl_ErrorNombre";
            this.lbl_ErrorNombre.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorNombre.TabIndex = 62;
            this.lbl_ErrorNombre.Text = "* Error";
            this.lbl_ErrorNombre.Visible = false;
            // 
            // lbl_ErrorAp
            // 
            this.lbl_ErrorAp.AutoSize = true;
            this.lbl_ErrorAp.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorAp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorAp.Location = new System.Drawing.Point(195, 228);
            this.lbl_ErrorAp.Name = "lbl_ErrorAp";
            this.lbl_ErrorAp.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorAp.TabIndex = 63;
            this.lbl_ErrorAp.Text = "* Error";
            this.lbl_ErrorAp.Visible = false;
            // 
            // lbl_ErrorTel
            // 
            this.lbl_ErrorTel.AutoSize = true;
            this.lbl_ErrorTel.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorTel.Location = new System.Drawing.Point(19, 331);
            this.lbl_ErrorTel.Name = "lbl_ErrorTel";
            this.lbl_ErrorTel.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorTel.TabIndex = 64;
            this.lbl_ErrorTel.Text = "* Error";
            this.lbl_ErrorTel.Visible = false;
            // 
            // lbl_ErrorAm
            // 
            this.lbl_ErrorAm.AutoSize = true;
            this.lbl_ErrorAm.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorAm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorAm.Location = new System.Drawing.Point(404, 228);
            this.lbl_ErrorAm.Name = "lbl_ErrorAm";
            this.lbl_ErrorAm.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorAm.TabIndex = 65;
            this.lbl_ErrorAm.Text = "* Error";
            this.lbl_ErrorAm.Visible = false;
            // 
            // lbl_ErrorSue
            // 
            this.lbl_ErrorSue.AutoSize = true;
            this.lbl_ErrorSue.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorSue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorSue.Location = new System.Drawing.Point(195, 331);
            this.lbl_ErrorSue.Name = "lbl_ErrorSue";
            this.lbl_ErrorSue.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorSue.TabIndex = 66;
            this.lbl_ErrorSue.Text = "* Error";
            this.lbl_ErrorSue.Visible = false;
            // 
            // lbl_ErrorClave
            // 
            this.lbl_ErrorClave.AutoSize = true;
            this.lbl_ErrorClave.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.lbl_ErrorClave.Location = new System.Drawing.Point(373, 331);
            this.lbl_ErrorClave.Name = "lbl_ErrorClave";
            this.lbl_ErrorClave.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorClave.TabIndex = 67;
            this.lbl_ErrorClave.Text = "* Error";
            this.lbl_ErrorClave.Visible = false;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BorderRadius = 5;
            this.btn_Aceptar.CheckedState.Parent = this.btn_Aceptar;
            this.btn_Aceptar.CustomImages.Parent = this.btn_Aceptar;
            this.btn_Aceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Aceptar.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.HoverState.Parent = this.btn_Aceptar;
            this.btn_Aceptar.Location = new System.Drawing.Point(17, 363);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.ShadowDecoration.Parent = this.btn_Aceptar;
            this.btn_Aceptar.Size = new System.Drawing.Size(584, 40);
            this.btn_Aceptar.TabIndex = 68;
            this.btn_Aceptar.Text = "Aceptar";
            // 
            // FrmEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 430);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_ErrorClave);
            this.Controls.Add(this.lbl_ErrorSue);
            this.Controls.Add(this.lbl_ErrorAm);
            this.Controls.Add(this.lbl_ErrorTel);
            this.Controls.Add(this.lbl_ErrorAp);
            this.Controls.Add(this.lbl_ErrorNombre);
            this.Controls.Add(this.lbl_ErrorID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_clave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_sueldo);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_apPaterno);
            this.Controls.Add(this.lbl_cajero);
            this.Controls.Add(this.lbl_encargado);
            this.Controls.Add(this.rb_cajero);
            this.Controls.Add(this.rb_encargado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_apMaterno);
            this.Controls.Add(this.tb_idEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEditarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarEmpleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Guna.UI2.WinForms.Guna2ShadowForm sombra;
        public Guna.UI2.WinForms.Guna2TextBox tb_apMaterno;
        public Guna.UI2.WinForms.Guna2TextBox tb_idEmpleado;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox tb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2TextBox tb_clave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2TextBox tb_sueldo;
        public Guna.UI2.WinForms.Guna2TextBox tb_telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox tb_apPaterno;
        public Guna.UI2.WinForms.Guna2CustomRadioButton rb_cajero;
        public Guna.UI2.WinForms.Guna2CustomRadioButton rb_encargado;
        public System.Windows.Forms.Label lbl_cajero;
        public System.Windows.Forms.Label lbl_encargado;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public System.Windows.Forms.Label lbl_ErrorClave;
        public System.Windows.Forms.Label lbl_ErrorSue;
        public System.Windows.Forms.Label lbl_ErrorAm;
        public System.Windows.Forms.Label lbl_ErrorTel;
        public System.Windows.Forms.Label lbl_ErrorAp;
        public System.Windows.Forms.Label lbl_ErrorNombre;
        public System.Windows.Forms.Label lbl_ErrorID;
        private Guna.UI2.WinForms.Guna2Button btn_Aceptar;
    }
}