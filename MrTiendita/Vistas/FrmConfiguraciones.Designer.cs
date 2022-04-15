
namespace MrTiendita.Vistas
{
    partial class FrmConfiguraciones
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
            this.pnl_Configuracion = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_CantidadMinima = new System.Windows.Forms.Label();
            this.lbl_ProductoAgotado = new System.Windows.Forms.Label();
            this.check_CantidadMinima = new Bunifu.Framework.UI.BunifuCheckbox();
            this.check_ProductoAgotado = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_CantidadMin = new System.Windows.Forms.Label();
            this.tb_CantidadMin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Notificaciones = new System.Windows.Forms.Label();
            this.btn_GuardarDatos = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_LadaTel = new System.Windows.Forms.Label();
            this.tb_LadaTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_SueldoEncargados = new System.Windows.Forms.Label();
            this.tb_SueldoEncargados = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_SueldoCajeros = new System.Windows.Forms.Label();
            this.tb_SueldoCajeros = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Datos = new System.Windows.Forms.Label();
            this.btn_CambiarRuta = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Ruta = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.pnl_Configuracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Configuracion
            // 
            this.pnl_Configuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Configuracion.BorderRadius = 10;
            this.pnl_Configuracion.Controls.Add(this.lbl_CantidadMinima);
            this.pnl_Configuracion.Controls.Add(this.lbl_ProductoAgotado);
            this.pnl_Configuracion.Controls.Add(this.check_CantidadMinima);
            this.pnl_Configuracion.Controls.Add(this.check_ProductoAgotado);
            this.pnl_Configuracion.Controls.Add(this.lbl_CantidadMin);
            this.pnl_Configuracion.Controls.Add(this.tb_CantidadMin);
            this.pnl_Configuracion.Controls.Add(this.lbl_Notificaciones);
            this.pnl_Configuracion.Controls.Add(this.btn_GuardarDatos);
            this.pnl_Configuracion.Controls.Add(this.lbl_LadaTel);
            this.pnl_Configuracion.Controls.Add(this.tb_LadaTel);
            this.pnl_Configuracion.Controls.Add(this.lbl_SueldoEncargados);
            this.pnl_Configuracion.Controls.Add(this.tb_SueldoEncargados);
            this.pnl_Configuracion.Controls.Add(this.lbl_SueldoCajeros);
            this.pnl_Configuracion.Controls.Add(this.tb_SueldoCajeros);
            this.pnl_Configuracion.Controls.Add(this.lbl_Datos);
            this.pnl_Configuracion.Controls.Add(this.btn_CambiarRuta);
            this.pnl_Configuracion.Controls.Add(this.tb_Ruta);
            this.pnl_Configuracion.Controls.Add(this.lbl_Ruta);
            this.pnl_Configuracion.Controls.Add(this.lbl_Titulo);
            this.pnl_Configuracion.Controls.Add(this.lbl_Descripcion);
            this.pnl_Configuracion.FillColor = System.Drawing.Color.White;
            this.pnl_Configuracion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Configuracion.Location = new System.Drawing.Point(12, 12);
            this.pnl_Configuracion.Name = "pnl_Configuracion";
            this.pnl_Configuracion.ShadowDecoration.Parent = this.pnl_Configuracion;
            this.pnl_Configuracion.Size = new System.Drawing.Size(1171, 815);
            this.pnl_Configuracion.TabIndex = 0;
            // 
            // lbl_CantidadMinima
            // 
            this.lbl_CantidadMinima.AutoSize = true;
            this.lbl_CantidadMinima.BackColor = System.Drawing.Color.White;
            this.lbl_CantidadMinima.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantidadMinima.Location = new System.Drawing.Point(57, 424);
            this.lbl_CantidadMinima.Name = "lbl_CantidadMinima";
            this.lbl_CantidadMinima.Size = new System.Drawing.Size(499, 25);
            this.lbl_CantidadMinima.TabIndex = 21;
            this.lbl_CantidadMinima.Text = "Establecer una cantidad mínima para todos los productos.";
            // 
            // lbl_ProductoAgotado
            // 
            this.lbl_ProductoAgotado.AutoSize = true;
            this.lbl_ProductoAgotado.BackColor = System.Drawing.Color.White;
            this.lbl_ProductoAgotado.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductoAgotado.Location = new System.Drawing.Point(57, 386);
            this.lbl_ProductoAgotado.Name = "lbl_ProductoAgotado";
            this.lbl_ProductoAgotado.Size = new System.Drawing.Size(395, 25);
            this.lbl_ProductoAgotado.TabIndex = 20;
            this.lbl_ProductoAgotado.Text = "Avisar cuando un producto esté por agotarse.";
            // 
            // check_CantidadMinima
            // 
            this.check_CantidadMinima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_CantidadMinima.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_CantidadMinima.Checked = true;
            this.check_CantidadMinima.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_CantidadMinima.ForeColor = System.Drawing.Color.White;
            this.check_CantidadMinima.Location = new System.Drawing.Point(30, 424);
            this.check_CantidadMinima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_CantidadMinima.Name = "check_CantidadMinima";
            this.check_CantidadMinima.Size = new System.Drawing.Size(20, 20);
            this.check_CantidadMinima.TabIndex = 19;
            // 
            // check_ProductoAgotado
            // 
            this.check_ProductoAgotado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_ProductoAgotado.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check_ProductoAgotado.Checked = true;
            this.check_ProductoAgotado.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.check_ProductoAgotado.ForeColor = System.Drawing.Color.White;
            this.check_ProductoAgotado.Location = new System.Drawing.Point(30, 386);
            this.check_ProductoAgotado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_ProductoAgotado.Name = "check_ProductoAgotado";
            this.check_ProductoAgotado.Size = new System.Drawing.Size(20, 20);
            this.check_ProductoAgotado.TabIndex = 18;
            // 
            // lbl_CantidadMin
            // 
            this.lbl_CantidadMin.AutoSize = true;
            this.lbl_CantidadMin.BackColor = System.Drawing.Color.White;
            this.lbl_CantidadMin.Location = new System.Drawing.Point(58, 461);
            this.lbl_CantidadMin.Name = "lbl_CantidadMin";
            this.lbl_CantidadMin.Size = new System.Drawing.Size(141, 23);
            this.lbl_CantidadMin.TabIndex = 17;
            this.lbl_CantidadMin.Text = "Cantidad mínima";
            // 
            // tb_CantidadMin
            // 
            this.tb_CantidadMin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_CantidadMin.BorderRadius = 5;
            this.tb_CantidadMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CantidadMin.DefaultText = "";
            this.tb_CantidadMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CantidadMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CantidadMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CantidadMin.DisabledState.Parent = this.tb_CantidadMin;
            this.tb_CantidadMin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CantidadMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CantidadMin.FocusedState.Parent = this.tb_CantidadMin;
            this.tb_CantidadMin.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CantidadMin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CantidadMin.HoverState.Parent = this.tb_CantidadMin;
            this.tb_CantidadMin.Location = new System.Drawing.Point(61, 490);
            this.tb_CantidadMin.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CantidadMin.Name = "tb_CantidadMin";
            this.tb_CantidadMin.PasswordChar = '\0';
            this.tb_CantidadMin.PlaceholderText = "";
            this.tb_CantidadMin.SelectedText = "";
            this.tb_CantidadMin.ShadowDecoration.Parent = this.tb_CantidadMin;
            this.tb_CantidadMin.Size = new System.Drawing.Size(180, 44);
            this.tb_CantidadMin.TabIndex = 16;
            // 
            // lbl_Notificaciones
            // 
            this.lbl_Notificaciones.AutoSize = true;
            this.lbl_Notificaciones.BackColor = System.Drawing.Color.White;
            this.lbl_Notificaciones.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Notificaciones.Location = new System.Drawing.Point(20, 349);
            this.lbl_Notificaciones.Name = "lbl_Notificaciones";
            this.lbl_Notificaciones.Size = new System.Drawing.Size(266, 25);
            this.lbl_Notificaciones.TabIndex = 13;
            this.lbl_Notificaciones.Text = "Notificaciones del inventario";
            // 
            // btn_GuardarDatos
            // 
            this.btn_GuardarDatos.BorderRadius = 5;
            this.btn_GuardarDatos.CheckedState.Parent = this.btn_GuardarDatos;
            this.btn_GuardarDatos.CustomImages.Parent = this.btn_GuardarDatos;
            this.btn_GuardarDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_GuardarDatos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarDatos.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarDatos.HoverState.Parent = this.btn_GuardarDatos;
            this.btn_GuardarDatos.Location = new System.Drawing.Point(687, 274);
            this.btn_GuardarDatos.Name = "btn_GuardarDatos";
            this.btn_GuardarDatos.ShadowDecoration.Parent = this.btn_GuardarDatos;
            this.btn_GuardarDatos.Size = new System.Drawing.Size(152, 45);
            this.btn_GuardarDatos.TabIndex = 12;
            this.btn_GuardarDatos.Text = "Guardar";
            // 
            // lbl_LadaTel
            // 
            this.lbl_LadaTel.AutoSize = true;
            this.lbl_LadaTel.BackColor = System.Drawing.Color.White;
            this.lbl_LadaTel.Location = new System.Drawing.Point(464, 246);
            this.lbl_LadaTel.Name = "lbl_LadaTel";
            this.lbl_LadaTel.Size = new System.Drawing.Size(138, 23);
            this.lbl_LadaTel.TabIndex = 11;
            this.lbl_LadaTel.Text = "Lada de teléfono";
            // 
            // tb_LadaTel
            // 
            this.tb_LadaTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_LadaTel.BorderRadius = 5;
            this.tb_LadaTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_LadaTel.DefaultText = "";
            this.tb_LadaTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_LadaTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_LadaTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_LadaTel.DisabledState.Parent = this.tb_LadaTel;
            this.tb_LadaTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_LadaTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_LadaTel.FocusedState.Parent = this.tb_LadaTel;
            this.tb_LadaTel.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LadaTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_LadaTel.HoverState.Parent = this.tb_LadaTel;
            this.tb_LadaTel.Location = new System.Drawing.Point(467, 274);
            this.tb_LadaTel.Margin = new System.Windows.Forms.Padding(4);
            this.tb_LadaTel.Name = "tb_LadaTel";
            this.tb_LadaTel.PasswordChar = '\0';
            this.tb_LadaTel.PlaceholderText = "";
            this.tb_LadaTel.SelectedText = "";
            this.tb_LadaTel.ShadowDecoration.Parent = this.tb_LadaTel;
            this.tb_LadaTel.Size = new System.Drawing.Size(213, 44);
            this.tb_LadaTel.TabIndex = 10;
            // 
            // lbl_SueldoEncargados
            // 
            this.lbl_SueldoEncargados.AutoSize = true;
            this.lbl_SueldoEncargados.BackColor = System.Drawing.Color.White;
            this.lbl_SueldoEncargados.Location = new System.Drawing.Point(242, 246);
            this.lbl_SueldoEncargados.Name = "lbl_SueldoEncargados";
            this.lbl_SueldoEncargados.Size = new System.Drawing.Size(179, 23);
            this.lbl_SueldoEncargados.TabIndex = 9;
            this.lbl_SueldoEncargados.Text = "Sueldo de encargados";
            // 
            // tb_SueldoEncargados
            // 
            this.tb_SueldoEncargados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_SueldoEncargados.BorderRadius = 5;
            this.tb_SueldoEncargados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SueldoEncargados.DefaultText = "";
            this.tb_SueldoEncargados.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SueldoEncargados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SueldoEncargados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SueldoEncargados.DisabledState.Parent = this.tb_SueldoEncargados;
            this.tb_SueldoEncargados.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SueldoEncargados.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SueldoEncargados.FocusedState.Parent = this.tb_SueldoEncargados;
            this.tb_SueldoEncargados.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SueldoEncargados.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SueldoEncargados.HoverState.Parent = this.tb_SueldoEncargados;
            this.tb_SueldoEncargados.Location = new System.Drawing.Point(245, 274);
            this.tb_SueldoEncargados.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SueldoEncargados.Name = "tb_SueldoEncargados";
            this.tb_SueldoEncargados.PasswordChar = '\0';
            this.tb_SueldoEncargados.PlaceholderText = "";
            this.tb_SueldoEncargados.SelectedText = "";
            this.tb_SueldoEncargados.ShadowDecoration.Parent = this.tb_SueldoEncargados;
            this.tb_SueldoEncargados.Size = new System.Drawing.Size(213, 44);
            this.tb_SueldoEncargados.TabIndex = 8;
            // 
            // lbl_SueldoCajeros
            // 
            this.lbl_SueldoCajeros.AutoSize = true;
            this.lbl_SueldoCajeros.BackColor = System.Drawing.Color.White;
            this.lbl_SueldoCajeros.Location = new System.Drawing.Point(21, 246);
            this.lbl_SueldoCajeros.Name = "lbl_SueldoCajeros";
            this.lbl_SueldoCajeros.Size = new System.Drawing.Size(144, 23);
            this.lbl_SueldoCajeros.TabIndex = 7;
            this.lbl_SueldoCajeros.Text = "Sueldo de cajeros";
            // 
            // tb_SueldoCajeros
            // 
            this.tb_SueldoCajeros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_SueldoCajeros.BorderRadius = 5;
            this.tb_SueldoCajeros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SueldoCajeros.DefaultText = "";
            this.tb_SueldoCajeros.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SueldoCajeros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SueldoCajeros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SueldoCajeros.DisabledState.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SueldoCajeros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SueldoCajeros.FocusedState.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SueldoCajeros.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SueldoCajeros.HoverState.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.Location = new System.Drawing.Point(24, 274);
            this.tb_SueldoCajeros.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SueldoCajeros.Name = "tb_SueldoCajeros";
            this.tb_SueldoCajeros.PasswordChar = '\0';
            this.tb_SueldoCajeros.PlaceholderText = "";
            this.tb_SueldoCajeros.SelectedText = "";
            this.tb_SueldoCajeros.ShadowDecoration.Parent = this.tb_SueldoCajeros;
            this.tb_SueldoCajeros.Size = new System.Drawing.Size(213, 44);
            this.tb_SueldoCajeros.TabIndex = 6;
            // 
            // lbl_Datos
            // 
            this.lbl_Datos.AutoSize = true;
            this.lbl_Datos.BackColor = System.Drawing.Color.White;
            this.lbl_Datos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Datos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Datos.Location = new System.Drawing.Point(20, 207);
            this.lbl_Datos.Name = "lbl_Datos";
            this.lbl_Datos.Size = new System.Drawing.Size(221, 25);
            this.lbl_Datos.TabIndex = 5;
            this.lbl_Datos.Text = "Datos predeterminados";
            // 
            // btn_CambiarRuta
            // 
            this.btn_CambiarRuta.BorderRadius = 5;
            this.btn_CambiarRuta.CheckedState.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.CustomImages.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CambiarRuta.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CambiarRuta.ForeColor = System.Drawing.Color.White;
            this.btn_CambiarRuta.HoverState.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.Location = new System.Drawing.Point(687, 146);
            this.btn_CambiarRuta.Name = "btn_CambiarRuta";
            this.btn_CambiarRuta.ShadowDecoration.Parent = this.btn_CambiarRuta;
            this.btn_CambiarRuta.Size = new System.Drawing.Size(152, 45);
            this.btn_CambiarRuta.TabIndex = 4;
            this.btn_CambiarRuta.Text = "Cambiar ruta";
            // 
            // tb_Ruta
            // 
            this.tb_Ruta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Ruta.BorderRadius = 5;
            this.tb_Ruta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Ruta.DefaultText = "";
            this.tb_Ruta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Ruta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Ruta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Ruta.DisabledState.Parent = this.tb_Ruta;
            this.tb_Ruta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Ruta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Ruta.FocusedState.Parent = this.tb_Ruta;
            this.tb_Ruta.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ruta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Ruta.HoverState.Parent = this.tb_Ruta;
            this.tb_Ruta.Location = new System.Drawing.Point(23, 146);
            this.tb_Ruta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ruta.Name = "tb_Ruta";
            this.tb_Ruta.PasswordChar = '\0';
            this.tb_Ruta.PlaceholderText = "";
            this.tb_Ruta.SelectedText = "";
            this.tb_Ruta.ShadowDecoration.Parent = this.tb_Ruta;
            this.tb_Ruta.Size = new System.Drawing.Size(657, 44);
            this.tb_Ruta.TabIndex = 3;
            // 
            // lbl_Ruta
            // 
            this.lbl_Ruta.AutoSize = true;
            this.lbl_Ruta.BackColor = System.Drawing.Color.White;
            this.lbl_Ruta.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ruta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Ruta.Location = new System.Drawing.Point(20, 115);
            this.lbl_Ruta.Name = "lbl_Ruta";
            this.lbl_Ruta.Size = new System.Drawing.Size(357, 25);
            this.lbl_Ruta.TabIndex = 2;
            this.lbl_Ruta.Text = "Ruta de guardado de tickets y reportes";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(18, 33);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(178, 32);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Configuración";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(20, 64);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(334, 23);
            this.lbl_Descripcion.TabIndex = 1;
            this.lbl_Descripcion.Text = "Personaliza las características de tu tienda.";
            // 
            // FrmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 839);
            this.Controls.Add(this.pnl_Configuracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguraciones";
            this.Text = "FrmConfiguraciones";
            this.pnl_Configuracion.ResumeLayout(false);
            this.pnl_Configuracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Configuracion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Ruta;
        private Guna.UI2.WinForms.Guna2TextBox tb_Ruta;
        private Guna.UI2.WinForms.Guna2Button btn_CambiarRuta;
        private Guna.UI2.WinForms.Guna2Button btn_GuardarDatos;
        private System.Windows.Forms.Label lbl_LadaTel;
        private Guna.UI2.WinForms.Guna2TextBox tb_LadaTel;
        private System.Windows.Forms.Label lbl_SueldoEncargados;
        private Guna.UI2.WinForms.Guna2TextBox tb_SueldoEncargados;
        private System.Windows.Forms.Label lbl_SueldoCajeros;
        private Guna.UI2.WinForms.Guna2TextBox tb_SueldoCajeros;
        private System.Windows.Forms.Label lbl_Datos;
        private System.Windows.Forms.Label lbl_Notificaciones;
        private System.Windows.Forms.Label lbl_CantidadMin;
        private Guna.UI2.WinForms.Guna2TextBox tb_CantidadMin;
        private System.Windows.Forms.Label lbl_CantidadMinima;
        private System.Windows.Forms.Label lbl_ProductoAgotado;
        private Bunifu.Framework.UI.BunifuCheckbox check_CantidadMinima;
        private Bunifu.Framework.UI.BunifuCheckbox check_ProductoAgotado;
    }
}