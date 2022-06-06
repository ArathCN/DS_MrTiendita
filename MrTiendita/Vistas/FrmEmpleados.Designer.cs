
namespace MrTiendita.Vistas
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_ConsultarEmpleados = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_CodigoBarras = new System.Windows.Forms.Label();
            this.tb_busqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.tablaEmpleados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TipoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_Estadisticas = new System.Windows.Forms.Label();
            this.lbl_DescEstadisticas = new System.Windows.Forms.Label();
            this.tlp_Display = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_MenuProductos = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_RegistrarEmpleado = new System.Windows.Forms.Panel();
            this.lbl_ErrorClave = new System.Windows.Forms.Label();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.tb_Clave = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ErrorSueldo = new System.Windows.Forms.Label();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.tb_Sueldo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ErrorTelefono = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.tb_Telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Cajero = new System.Windows.Forms.Label();
            this.cb_Cajero = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_ApellidoMa = new System.Windows.Forms.Label();
            this.lbl_ErrorApellidoMa = new System.Windows.Forms.Label();
            this.tb_ApellidoMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ApellidoPa = new System.Windows.Forms.Label();
            this.lbl_ErrorApeliidoPa = new System.Windows.Forms.Label();
            this.tb_ApellidoPa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Encargado = new System.Windows.Forms.Label();
            this.lbl_TipoEmpleado = new System.Windows.Forms.Label();
            this.cb_Encargado = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_ErrorNombre = new System.Windows.Forms.Label();
            this.lbl_ErrorUsuario = new System.Windows.Forms.Label();
            this.btn_AgregarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.tb_Usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.btn_ModificarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btn_RegistrarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.Separador = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnl_ConsultarEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).BeginInit();
            this.tlp_Display.SuspendLayout();
            this.pnl_MenuProductos.SuspendLayout();
            this.pnl_RegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ConsultarEmpleados
            // 
            this.pnl_ConsultarEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ConsultarEmpleados.BorderRadius = 10;
            this.pnl_ConsultarEmpleados.Controls.Add(this.lbl_CodigoBarras);
            this.pnl_ConsultarEmpleados.Controls.Add(this.tb_busqueda);
            this.pnl_ConsultarEmpleados.Controls.Add(this.tablaEmpleados);
            this.pnl_ConsultarEmpleados.Controls.Add(this.lbl_Estadisticas);
            this.pnl_ConsultarEmpleados.Controls.Add(this.lbl_DescEstadisticas);
            this.pnl_ConsultarEmpleados.FillColor = System.Drawing.Color.White;
            this.pnl_ConsultarEmpleados.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_ConsultarEmpleados.Location = new System.Drawing.Point(3, 2);
            this.pnl_ConsultarEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 5);
            this.pnl_ConsultarEmpleados.Name = "pnl_ConsultarEmpleados";
            this.pnl_ConsultarEmpleados.ShadowDecoration.Parent = this.pnl_ConsultarEmpleados;
            this.pnl_ConsultarEmpleados.Size = new System.Drawing.Size(1170, 391);
            this.pnl_ConsultarEmpleados.TabIndex = 4;
            // 
            // lbl_CodigoBarras
            // 
            this.lbl_CodigoBarras.AutoSize = true;
            this.lbl_CodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarras.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lbl_CodigoBarras.Location = new System.Drawing.Point(21, 96);
            this.lbl_CodigoBarras.Name = "lbl_CodigoBarras";
            this.lbl_CodigoBarras.Size = new System.Drawing.Size(130, 20);
            this.lbl_CodigoBarras.TabIndex = 17;
            this.lbl_CodigoBarras.Text = "Buscar empleados";
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_busqueda.BorderRadius = 5;
            this.tb_busqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_busqueda.DefaultText = "";
            this.tb_busqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_busqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_busqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_busqueda.DisabledState.Parent = this.tb_busqueda;
            this.tb_busqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_busqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_busqueda.FocusedState.Parent = this.tb_busqueda;
            this.tb_busqueda.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_busqueda.HoverState.Parent = this.tb_busqueda;
            this.tb_busqueda.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_busqueda.IconLeft")));
            this.tb_busqueda.Location = new System.Drawing.Point(24, 121);
            this.tb_busqueda.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_busqueda.MaxLength = 20;
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.PasswordChar = '\0';
            this.tb_busqueda.PlaceholderText = "";
            this.tb_busqueda.SelectedText = "";
            this.tb_busqueda.ShadowDecoration.Parent = this.tb_busqueda;
            this.tb_busqueda.Size = new System.Drawing.Size(501, 36);
            this.tb_busqueda.TabIndex = 16;
            // 
            // tablaEmpleados
            // 
            this.tablaEmpleados.AllowUserToAddRows = false;
            this.tablaEmpleados.AllowUserToDeleteRows = false;
            this.tablaEmpleados.AllowUserToResizeColumns = false;
            this.tablaEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablaEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.tablaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEmpleados.ColumnHeadersHeight = 35;
            this.tablaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_Nombre,
            this.col_Telefono,
            this.col_Sueldo,
            this.col_TipoEmpleado,
            this.col_Usuario,
            this.col_Editar,
            this.col_Borrar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaEmpleados.EnableHeadersVisualStyles = false;
            this.tablaEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.tablaEmpleados.Location = new System.Drawing.Point(24, 172);
            this.tablaEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaEmpleados.Name = "tablaEmpleados";
            this.tablaEmpleados.ReadOnly = true;
            this.tablaEmpleados.RowHeadersVisible = false;
            this.tablaEmpleados.RowHeadersWidth = 65;
            this.tablaEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaEmpleados.RowTemplate.Height = 35;
            this.tablaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaEmpleados.Size = new System.Drawing.Size(1126, 206);
            this.tablaEmpleados.TabIndex = 15;
            this.tablaEmpleados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tablaEmpleados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaEmpleados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaEmpleados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaEmpleados.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaEmpleados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.tablaEmpleados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tablaEmpleados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaEmpleados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.tablaEmpleados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.tablaEmpleados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaEmpleados.ThemeStyle.HeaderStyle.Height = 35;
            this.tablaEmpleados.ThemeStyle.ReadOnly = true;
            this.tablaEmpleados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaEmpleados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaEmpleados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.tablaEmpleados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.tablaEmpleados.ThemeStyle.RowsStyle.Height = 35;
            this.tablaEmpleados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.tablaEmpleados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // col_Id
            // 
            this.col_Id.HeaderText = "Id";
            this.col_Id.MinimumWidth = 6;
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.MinimumWidth = 6;
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_Telefono
            // 
            this.col_Telefono.HeaderText = "Teléfono";
            this.col_Telefono.MinimumWidth = 6;
            this.col_Telefono.Name = "col_Telefono";
            this.col_Telefono.ReadOnly = true;
            // 
            // col_Sueldo
            // 
            this.col_Sueldo.HeaderText = "Sueldo";
            this.col_Sueldo.MinimumWidth = 6;
            this.col_Sueldo.Name = "col_Sueldo";
            this.col_Sueldo.ReadOnly = true;
            // 
            // col_TipoEmpleado
            // 
            this.col_TipoEmpleado.HeaderText = "Tipo";
            this.col_TipoEmpleado.MinimumWidth = 6;
            this.col_TipoEmpleado.Name = "col_TipoEmpleado";
            this.col_TipoEmpleado.ReadOnly = true;
            // 
            // col_Usuario
            // 
            this.col_Usuario.HeaderText = "Usuario";
            this.col_Usuario.MinimumWidth = 6;
            this.col_Usuario.Name = "col_Usuario";
            this.col_Usuario.ReadOnly = true;
            // 
            // col_Editar
            // 
            this.col_Editar.HeaderText = "Editar";
            this.col_Editar.Image = ((System.Drawing.Image)(resources.GetObject("col_Editar.Image")));
            this.col_Editar.MinimumWidth = 6;
            this.col_Editar.Name = "col_Editar";
            this.col_Editar.ReadOnly = true;
            // 
            // col_Borrar
            // 
            this.col_Borrar.HeaderText = "Borrar";
            this.col_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("col_Borrar.Image")));
            this.col_Borrar.MinimumWidth = 6;
            this.col_Borrar.Name = "col_Borrar";
            this.col_Borrar.ReadOnly = true;
            // 
            // lbl_Estadisticas
            // 
            this.lbl_Estadisticas.AutoSize = true;
            this.lbl_Estadisticas.BackColor = System.Drawing.Color.White;
            this.lbl_Estadisticas.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Estadisticas.Location = new System.Drawing.Point(20, 33);
            this.lbl_Estadisticas.Name = "lbl_Estadisticas";
            this.lbl_Estadisticas.Size = new System.Drawing.Size(139, 32);
            this.lbl_Estadisticas.TabIndex = 4;
            this.lbl_Estadisticas.Text = "Empleados";
            // 
            // lbl_DescEstadisticas
            // 
            this.lbl_DescEstadisticas.AutoSize = true;
            this.lbl_DescEstadisticas.BackColor = System.Drawing.Color.White;
            this.lbl_DescEstadisticas.Location = new System.Drawing.Point(21, 65);
            this.lbl_DescEstadisticas.Name = "lbl_DescEstadisticas";
            this.lbl_DescEstadisticas.Size = new System.Drawing.Size(431, 23);
            this.lbl_DescEstadisticas.TabIndex = 5;
            this.lbl_DescEstadisticas.Text = "Consulta, agrega o modifica los datos de un empleado.";
            // 
            // tlp_Display
            // 
            this.tlp_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Display.ColumnCount = 1;
            this.tlp_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.Controls.Add(this.pnl_MenuProductos, 0, 1);
            this.tlp_Display.Controls.Add(this.pnl_ConsultarEmpleados, 0, 0);
            this.tlp_Display.Location = new System.Drawing.Point(12, 15);
            this.tlp_Display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_Display.Name = "tlp_Display";
            this.tlp_Display.RowCount = 2;
            this.tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tlp_Display.Size = new System.Drawing.Size(1176, 727);
            this.tlp_Display.TabIndex = 5;
            // 
            // pnl_MenuProductos
            // 
            this.pnl_MenuProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuProductos.BorderRadius = 10;
            this.pnl_MenuProductos.Controls.Add(this.pnl_RegistrarEmpleado);
            this.pnl_MenuProductos.Controls.Add(this.btn_ModificarEmpleado);
            this.pnl_MenuProductos.Controls.Add(this.btn_RegistrarEmpleado);
            this.pnl_MenuProductos.Controls.Add(this.Separador);
            this.pnl_MenuProductos.FillColor = System.Drawing.Color.White;
            this.pnl_MenuProductos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MenuProductos.Location = new System.Drawing.Point(3, 400);
            this.pnl_MenuProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_MenuProductos.Name = "pnl_MenuProductos";
            this.pnl_MenuProductos.ShadowDecoration.Parent = this.pnl_MenuProductos;
            this.pnl_MenuProductos.Size = new System.Drawing.Size(1170, 325);
            this.pnl_MenuProductos.TabIndex = 1;
            // 
            // pnl_RegistrarEmpleado
            // 
            this.pnl_RegistrarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_RegistrarEmpleado.AutoScroll = true;
            this.pnl_RegistrarEmpleado.BackColor = System.Drawing.Color.White;
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorClave);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Clave);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_Clave);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorSueldo);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Sueldo);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_Sueldo);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorTelefono);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Telefono);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_Telefono);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Cajero);
            this.pnl_RegistrarEmpleado.Controls.Add(this.cb_Cajero);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ApellidoMa);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorApellidoMa);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_ApellidoMa);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ApellidoPa);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorApeliidoPa);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_ApellidoPa);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Encargado);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_TipoEmpleado);
            this.pnl_RegistrarEmpleado.Controls.Add(this.cb_Encargado);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorNombre);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorUsuario);
            this.pnl_RegistrarEmpleado.Controls.Add(this.btn_AgregarEmpleado);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_Nombre);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Nombre);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Usuario);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_Usuario);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Titulo);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Descripcion);
            this.pnl_RegistrarEmpleado.Location = new System.Drawing.Point(19, 62);
            this.pnl_RegistrarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_RegistrarEmpleado.Name = "pnl_RegistrarEmpleado";
            this.pnl_RegistrarEmpleado.Size = new System.Drawing.Size(1138, 257);
            this.pnl_RegistrarEmpleado.TabIndex = 0;
            // 
            // lbl_ErrorClave
            // 
            this.lbl_ErrorClave.AutoSize = true;
            this.lbl_ErrorClave.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorClave.Location = new System.Drawing.Point(461, 233);
            this.lbl_ErrorClave.Name = "lbl_ErrorClave";
            this.lbl_ErrorClave.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorClave.TabIndex = 91;
            this.lbl_ErrorClave.Text = "* Error";
            this.lbl_ErrorClave.Visible = false;
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.BackColor = System.Drawing.Color.White;
            this.lbl_Clave.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clave.Location = new System.Drawing.Point(461, 167);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(83, 20);
            this.lbl_Clave.TabIndex = 90;
            this.lbl_Clave.Text = "Contraseña";
            // 
            // tb_Clave
            // 
            this.tb_Clave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Clave.BorderRadius = 5;
            this.tb_Clave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Clave.DefaultText = "";
            this.tb_Clave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Clave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Clave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Clave.DisabledState.Parent = this.tb_Clave;
            this.tb_Clave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Clave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Clave.FocusedState.Parent = this.tb_Clave;
            this.tb_Clave.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Clave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Clave.HoverState.Parent = this.tb_Clave;
            this.tb_Clave.Location = new System.Drawing.Point(465, 194);
            this.tb_Clave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tb_Clave.MaxLength = 20;
            this.tb_Clave.Name = "tb_Clave";
            this.tb_Clave.PasswordChar = '*';
            this.tb_Clave.PlaceholderText = "";
            this.tb_Clave.SelectedText = "";
            this.tb_Clave.ShadowDecoration.Parent = this.tb_Clave;
            this.tb_Clave.Size = new System.Drawing.Size(221, 36);
            this.tb_Clave.TabIndex = 89;
            // 
            // lbl_ErrorSueldo
            // 
            this.lbl_ErrorSueldo.AutoSize = true;
            this.lbl_ErrorSueldo.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorSueldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorSueldo.Location = new System.Drawing.Point(241, 233);
            this.lbl_ErrorSueldo.Name = "lbl_ErrorSueldo";
            this.lbl_ErrorSueldo.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorSueldo.TabIndex = 88;
            this.lbl_ErrorSueldo.Text = "* Error";
            this.lbl_ErrorSueldo.Visible = false;
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.BackColor = System.Drawing.Color.White;
            this.lbl_Sueldo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sueldo.Location = new System.Drawing.Point(241, 167);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(55, 20);
            this.lbl_Sueldo.TabIndex = 87;
            this.lbl_Sueldo.Text = "Sueldo";
            // 
            // tb_Sueldo
            // 
            this.tb_Sueldo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Sueldo.BorderRadius = 5;
            this.tb_Sueldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Sueldo.DefaultText = "";
            this.tb_Sueldo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Sueldo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Sueldo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Sueldo.DisabledState.Parent = this.tb_Sueldo;
            this.tb_Sueldo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Sueldo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Sueldo.FocusedState.Parent = this.tb_Sueldo;
            this.tb_Sueldo.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sueldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Sueldo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Sueldo.HoverState.Parent = this.tb_Sueldo;
            this.tb_Sueldo.Location = new System.Drawing.Point(245, 194);
            this.tb_Sueldo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tb_Sueldo.MaxLength = 6;
            this.tb_Sueldo.Name = "tb_Sueldo";
            this.tb_Sueldo.PasswordChar = '\0';
            this.tb_Sueldo.PlaceholderText = "";
            this.tb_Sueldo.SelectedText = "";
            this.tb_Sueldo.ShadowDecoration.Parent = this.tb_Sueldo;
            this.tb_Sueldo.Size = new System.Drawing.Size(213, 36);
            this.tb_Sueldo.TabIndex = 86;
            // 
            // lbl_ErrorTelefono
            // 
            this.lbl_ErrorTelefono.AutoSize = true;
            this.lbl_ErrorTelefono.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorTelefono.Location = new System.Drawing.Point(21, 233);
            this.lbl_ErrorTelefono.Name = "lbl_ErrorTelefono";
            this.lbl_ErrorTelefono.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorTelefono.TabIndex = 85;
            this.lbl_ErrorTelefono.Text = "* Error";
            this.lbl_ErrorTelefono.Visible = false;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.BackColor = System.Drawing.Color.White;
            this.lbl_Telefono.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(21, 167);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(68, 20);
            this.lbl_Telefono.TabIndex = 84;
            this.lbl_Telefono.Text = "Teléfono";
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Telefono.BorderRadius = 5;
            this.tb_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Telefono.DefaultText = "";
            this.tb_Telefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Telefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Telefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Telefono.DisabledState.Parent = this.tb_Telefono;
            this.tb_Telefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Telefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Telefono.FocusedState.Parent = this.tb_Telefono;
            this.tb_Telefono.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Telefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Telefono.HoverState.Parent = this.tb_Telefono;
            this.tb_Telefono.Location = new System.Drawing.Point(25, 194);
            this.tb_Telefono.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tb_Telefono.MaxLength = 10;
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.PasswordChar = '\0';
            this.tb_Telefono.PlaceholderText = "";
            this.tb_Telefono.SelectedText = "";
            this.tb_Telefono.ShadowDecoration.Parent = this.tb_Telefono;
            this.tb_Telefono.Size = new System.Drawing.Size(213, 36);
            this.tb_Telefono.TabIndex = 83;
            // 
            // lbl_Cajero
            // 
            this.lbl_Cajero.AutoSize = true;
            this.lbl_Cajero.BackColor = System.Drawing.Color.White;
            this.lbl_Cajero.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lbl_Cajero.Location = new System.Drawing.Point(1067, 111);
            this.lbl_Cajero.Name = "lbl_Cajero";
            this.lbl_Cajero.Size = new System.Drawing.Size(52, 20);
            this.lbl_Cajero.TabIndex = 79;
            this.lbl_Cajero.Text = "Cajero";
            // 
            // cb_Cajero
            // 
            this.cb_Cajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_Cajero.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_Cajero.Checked = false;
            this.cb_Cajero.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.cb_Cajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Cajero.ForeColor = System.Drawing.Color.White;
            this.cb_Cajero.Location = new System.Drawing.Point(1039, 111);
            this.cb_Cajero.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.cb_Cajero.Name = "cb_Cajero";
            this.cb_Cajero.Size = new System.Drawing.Size(20, 20);
            this.cb_Cajero.TabIndex = 78;
            // 
            // lbl_ApellidoMa
            // 
            this.lbl_ApellidoMa.AutoSize = true;
            this.lbl_ApellidoMa.BackColor = System.Drawing.Color.White;
            this.lbl_ApellidoMa.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoMa.Location = new System.Drawing.Point(684, 78);
            this.lbl_ApellidoMa.Name = "lbl_ApellidoMa";
            this.lbl_ApellidoMa.Size = new System.Drawing.Size(126, 20);
            this.lbl_ApellidoMa.TabIndex = 77;
            this.lbl_ApellidoMa.Text = "Apellido materno";
            // 
            // lbl_ErrorApellidoMa
            // 
            this.lbl_ErrorApellidoMa.AutoSize = true;
            this.lbl_ErrorApellidoMa.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorApellidoMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorApellidoMa.Location = new System.Drawing.Point(684, 145);
            this.lbl_ErrorApellidoMa.Name = "lbl_ErrorApellidoMa";
            this.lbl_ErrorApellidoMa.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorApellidoMa.TabIndex = 76;
            this.lbl_ErrorApellidoMa.Text = "* Error";
            this.lbl_ErrorApellidoMa.Visible = false;
            // 
            // tb_ApellidoMa
            // 
            this.tb_ApellidoMa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_ApellidoMa.BorderRadius = 5;
            this.tb_ApellidoMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ApellidoMa.DefaultText = "";
            this.tb_ApellidoMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ApellidoMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ApellidoMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoMa.DisabledState.Parent = this.tb_ApellidoMa;
            this.tb_ApellidoMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoMa.FocusedState.Parent = this.tb_ApellidoMa;
            this.tb_ApellidoMa.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ApellidoMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ApellidoMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoMa.HoverState.Parent = this.tb_ApellidoMa;
            this.tb_ApellidoMa.Location = new System.Drawing.Point(688, 105);
            this.tb_ApellidoMa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tb_ApellidoMa.MaxLength = 25;
            this.tb_ApellidoMa.Name = "tb_ApellidoMa";
            this.tb_ApellidoMa.PasswordChar = '\0';
            this.tb_ApellidoMa.PlaceholderText = "";
            this.tb_ApellidoMa.SelectedText = "";
            this.tb_ApellidoMa.ShadowDecoration.Parent = this.tb_ApellidoMa;
            this.tb_ApellidoMa.Size = new System.Drawing.Size(213, 36);
            this.tb_ApellidoMa.TabIndex = 75;
            // 
            // lbl_ApellidoPa
            // 
            this.lbl_ApellidoPa.AutoSize = true;
            this.lbl_ApellidoPa.BackColor = System.Drawing.Color.White;
            this.lbl_ApellidoPa.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoPa.Location = new System.Drawing.Point(464, 78);
            this.lbl_ApellidoPa.Name = "lbl_ApellidoPa";
            this.lbl_ApellidoPa.Size = new System.Drawing.Size(122, 20);
            this.lbl_ApellidoPa.TabIndex = 74;
            this.lbl_ApellidoPa.Text = "Apellido paterno";
            // 
            // lbl_ErrorApeliidoPa
            // 
            this.lbl_ErrorApeliidoPa.AutoSize = true;
            this.lbl_ErrorApeliidoPa.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorApeliidoPa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorApeliidoPa.Location = new System.Drawing.Point(464, 145);
            this.lbl_ErrorApeliidoPa.Name = "lbl_ErrorApeliidoPa";
            this.lbl_ErrorApeliidoPa.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorApeliidoPa.TabIndex = 73;
            this.lbl_ErrorApeliidoPa.Text = "* Error";
            this.lbl_ErrorApeliidoPa.Visible = false;
            // 
            // tb_ApellidoPa
            // 
            this.tb_ApellidoPa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_ApellidoPa.BorderRadius = 5;
            this.tb_ApellidoPa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ApellidoPa.DefaultText = "";
            this.tb_ApellidoPa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ApellidoPa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ApellidoPa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoPa.DisabledState.Parent = this.tb_ApellidoPa;
            this.tb_ApellidoPa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoPa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoPa.FocusedState.Parent = this.tb_ApellidoPa;
            this.tb_ApellidoPa.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ApellidoPa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ApellidoPa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoPa.HoverState.Parent = this.tb_ApellidoPa;
            this.tb_ApellidoPa.Location = new System.Drawing.Point(465, 105);
            this.tb_ApellidoPa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_ApellidoPa.MaxLength = 25;
            this.tb_ApellidoPa.Name = "tb_ApellidoPa";
            this.tb_ApellidoPa.PasswordChar = '\0';
            this.tb_ApellidoPa.PlaceholderText = "";
            this.tb_ApellidoPa.SelectedText = "";
            this.tb_ApellidoPa.ShadowDecoration.Parent = this.tb_ApellidoPa;
            this.tb_ApellidoPa.Size = new System.Drawing.Size(213, 36);
            this.tb_ApellidoPa.TabIndex = 71;
            // 
            // lbl_Encargado
            // 
            this.lbl_Encargado.AutoSize = true;
            this.lbl_Encargado.BackColor = System.Drawing.Color.White;
            this.lbl_Encargado.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lbl_Encargado.Location = new System.Drawing.Point(941, 111);
            this.lbl_Encargado.Name = "lbl_Encargado";
            this.lbl_Encargado.Size = new System.Drawing.Size(80, 20);
            this.lbl_Encargado.TabIndex = 70;
            this.lbl_Encargado.Text = "Encargado";
            // 
            // lbl_TipoEmpleado
            // 
            this.lbl_TipoEmpleado.AutoSize = true;
            this.lbl_TipoEmpleado.BackColor = System.Drawing.Color.White;
            this.lbl_TipoEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoEmpleado.Location = new System.Drawing.Point(909, 80);
            this.lbl_TipoEmpleado.Name = "lbl_TipoEmpleado";
            this.lbl_TipoEmpleado.Size = new System.Drawing.Size(132, 20);
            this.lbl_TipoEmpleado.TabIndex = 69;
            this.lbl_TipoEmpleado.Text = "Tipo de empleado";
            // 
            // cb_Encargado
            // 
            this.cb_Encargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_Encargado.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_Encargado.Checked = false;
            this.cb_Encargado.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.cb_Encargado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Encargado.ForeColor = System.Drawing.Color.White;
            this.cb_Encargado.Location = new System.Drawing.Point(915, 111);
            this.cb_Encargado.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.cb_Encargado.Name = "cb_Encargado";
            this.cb_Encargado.Size = new System.Drawing.Size(20, 20);
            this.cb_Encargado.TabIndex = 68;
            // 
            // lbl_ErrorNombre
            // 
            this.lbl_ErrorNombre.AutoSize = true;
            this.lbl_ErrorNombre.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorNombre.Location = new System.Drawing.Point(248, 145);
            this.lbl_ErrorNombre.Name = "lbl_ErrorNombre";
            this.lbl_ErrorNombre.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorNombre.TabIndex = 49;
            this.lbl_ErrorNombre.Text = "* Error";
            this.lbl_ErrorNombre.Visible = false;
            // 
            // lbl_ErrorUsuario
            // 
            this.lbl_ErrorUsuario.AutoSize = true;
            this.lbl_ErrorUsuario.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorUsuario.Location = new System.Drawing.Point(21, 145);
            this.lbl_ErrorUsuario.Name = "lbl_ErrorUsuario";
            this.lbl_ErrorUsuario.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorUsuario.TabIndex = 48;
            this.lbl_ErrorUsuario.Text = "* Error";
            this.lbl_ErrorUsuario.Visible = false;
            // 
            // btn_AgregarEmpleado
            // 
            this.btn_AgregarEmpleado.BorderRadius = 5;
            this.btn_AgregarEmpleado.CheckedState.Parent = this.btn_AgregarEmpleado;
            this.btn_AgregarEmpleado.CustomImages.Parent = this.btn_AgregarEmpleado;
            this.btn_AgregarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AgregarEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarEmpleado.HoverState.Parent = this.btn_AgregarEmpleado;
            this.btn_AgregarEmpleado.Location = new System.Drawing.Point(915, 194);
            this.btn_AgregarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AgregarEmpleado.Name = "btn_AgregarEmpleado";
            this.btn_AgregarEmpleado.ShadowDecoration.Parent = this.btn_AgregarEmpleado;
            this.btn_AgregarEmpleado.Size = new System.Drawing.Size(203, 36);
            this.btn_AgregarEmpleado.TabIndex = 47;
            this.btn_AgregarEmpleado.Text = "Registrar empleado";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Nombre.BorderRadius = 5;
            this.tb_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Nombre.DefaultText = "";
            this.tb_Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Nombre.DisabledState.Parent = this.tb_Nombre;
            this.tb_Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Nombre.FocusedState.Parent = this.tb_Nombre;
            this.tb_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Nombre.HoverState.Parent = this.tb_Nombre;
            this.tb_Nombre.Location = new System.Drawing.Point(245, 105);
            this.tb_Nombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Nombre.MaxLength = 45;
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.PasswordChar = '\0';
            this.tb_Nombre.PlaceholderText = "";
            this.tb_Nombre.SelectedText = "";
            this.tb_Nombre.ShadowDecoration.Parent = this.tb_Nombre;
            this.tb_Nombre.Size = new System.Drawing.Size(213, 36);
            this.tb_Nombre.TabIndex = 27;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.White;
            this.lbl_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(248, 80);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(64, 20);
            this.lbl_Nombre.TabIndex = 28;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.White;
            this.lbl_Usuario.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(21, 80);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(59, 20);
            this.lbl_Usuario.TabIndex = 25;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Usuario.BorderRadius = 5;
            this.tb_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Usuario.DefaultText = "";
            this.tb_Usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Usuario.DisabledState.Parent = this.tb_Usuario;
            this.tb_Usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Usuario.FocusedState.Parent = this.tb_Usuario;
            this.tb_Usuario.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Usuario.HoverState.Parent = this.tb_Usuario;
            this.tb_Usuario.Location = new System.Drawing.Point(25, 105);
            this.tb_Usuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Usuario.MaxLength = 20;
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.PasswordChar = '\0';
            this.tb_Usuario.PlaceholderText = "";
            this.tb_Usuario.SelectedText = "";
            this.tb_Usuario.ShadowDecoration.Parent = this.tb_Usuario;
            this.tb_Usuario.Size = new System.Drawing.Size(213, 36);
            this.tb_Usuario.TabIndex = 24;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 12);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(296, 32);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Registrar a un empleado";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Descripcion.Location = new System.Drawing.Point(13, 43);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(330, 23);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Registra los datos de un nuevo empleado.";
            // 
            // btn_ModificarEmpleado
            // 
            this.btn_ModificarEmpleado.CheckedState.Parent = this.btn_ModificarEmpleado;
            this.btn_ModificarEmpleado.CustomImages.Parent = this.btn_ModificarEmpleado;
            this.btn_ModificarEmpleado.FillColor = System.Drawing.Color.White;
            this.btn_ModificarEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ModificarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_ModificarEmpleado.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_ModificarEmpleado.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_ModificarEmpleado.HoverState.Parent = this.btn_ModificarEmpleado;
            this.btn_ModificarEmpleado.Location = new System.Drawing.Point(285, 7);
            this.btn_ModificarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ModificarEmpleado.Name = "btn_ModificarEmpleado";
            this.btn_ModificarEmpleado.PressedColor = System.Drawing.Color.White;
            this.btn_ModificarEmpleado.ShadowDecoration.Parent = this.btn_ModificarEmpleado;
            this.btn_ModificarEmpleado.Size = new System.Drawing.Size(253, 46);
            this.btn_ModificarEmpleado.TabIndex = 1;
            this.btn_ModificarEmpleado.Text = "Modificar empleado";
            this.btn_ModificarEmpleado.Visible = false;
            // 
            // btn_RegistrarEmpleado
            // 
            this.btn_RegistrarEmpleado.CheckedState.Parent = this.btn_RegistrarEmpleado;
            this.btn_RegistrarEmpleado.CustomImages.Parent = this.btn_RegistrarEmpleado;
            this.btn_RegistrarEmpleado.FillColor = System.Drawing.Color.White;
            this.btn_RegistrarEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_RegistrarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_RegistrarEmpleado.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_RegistrarEmpleado.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_RegistrarEmpleado.HoverState.Parent = this.btn_RegistrarEmpleado;
            this.btn_RegistrarEmpleado.Location = new System.Drawing.Point(13, 7);
            this.btn_RegistrarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RegistrarEmpleado.Name = "btn_RegistrarEmpleado";
            this.btn_RegistrarEmpleado.PressedColor = System.Drawing.Color.White;
            this.btn_RegistrarEmpleado.ShadowDecoration.Parent = this.btn_RegistrarEmpleado;
            this.btn_RegistrarEmpleado.Size = new System.Drawing.Size(253, 46);
            this.btn_RegistrarEmpleado.TabIndex = 4;
            this.btn_RegistrarEmpleado.Text = "Registrar empleado";
            // 
            // Separador
            // 
            this.Separador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Separador.BackColor = System.Drawing.Color.White;
            this.Separador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Separador.Enabled = false;
            this.Separador.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Separador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Separador.Location = new System.Drawing.Point(19, 27);
            this.Separador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Separador.Name = "Separador";
            this.Separador.PasswordChar = '\0';
            this.Separador.ReadOnly = true;
            this.Separador.SelectedText = "";
            this.Separador.Size = new System.Drawing.Size(1138, 37);
            this.Separador.TabIndex = 34;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 750);
            this.Controls.Add(this.tlp_Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.pnl_ConsultarEmpleados.ResumeLayout(false);
            this.pnl_ConsultarEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).EndInit();
            this.tlp_Display.ResumeLayout(false);
            this.pnl_MenuProductos.ResumeLayout(false);
            this.pnl_RegistrarEmpleado.ResumeLayout(false);
            this.pnl_RegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnl_ConsultarEmpleados;
        private System.Windows.Forms.Label lbl_Estadisticas;
        private System.Windows.Forms.Label lbl_DescEstadisticas;
        private System.Windows.Forms.Label lbl_CodigoBarras;
        private System.Windows.Forms.TableLayoutPanel tlp_Display;
        public Guna.UI2.WinForms.Guna2Panel pnl_MenuProductos;
        public System.Windows.Forms.Panel pnl_RegistrarEmpleado;
        private System.Windows.Forms.Label lbl_ApellidoPa;
        public System.Windows.Forms.Label lbl_ErrorApeliidoPa;
        public Guna.UI2.WinForms.Guna2TextBox tb_ApellidoPa;
        private System.Windows.Forms.Label lbl_Encargado;
        private System.Windows.Forms.Label lbl_TipoEmpleado;
        public Bunifu.Framework.UI.BunifuCheckbox cb_Encargado;
        public System.Windows.Forms.Label lbl_ErrorNombre;
        public System.Windows.Forms.Label lbl_ErrorUsuario;
        public Guna.UI2.WinForms.Guna2Button btn_AgregarEmpleado;
        public Guna.UI2.WinForms.Guna2TextBox tb_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Usuario;
        public Guna.UI2.WinForms.Guna2TextBox tb_Usuario;
        public System.Windows.Forms.Label lbl_Titulo;
        public System.Windows.Forms.Label lbl_Descripcion;
        public Guna.UI2.WinForms.Guna2Button btn_ModificarEmpleado;
        public Guna.UI2.WinForms.Guna2Button btn_RegistrarEmpleado;
        private Guna.UI.WinForms.GunaLineTextBox Separador;
        public System.Windows.Forms.Label lbl_ErrorClave;
        private System.Windows.Forms.Label lbl_Clave;
        public Guna.UI2.WinForms.Guna2TextBox tb_Clave;
        public System.Windows.Forms.Label lbl_ErrorSueldo;
        private System.Windows.Forms.Label lbl_Sueldo;
        public Guna.UI2.WinForms.Guna2TextBox tb_Sueldo;
        public System.Windows.Forms.Label lbl_ErrorTelefono;
        private System.Windows.Forms.Label lbl_Telefono;
        public Guna.UI2.WinForms.Guna2TextBox tb_Telefono;
        private System.Windows.Forms.Label lbl_Cajero;
        public Bunifu.Framework.UI.BunifuCheckbox cb_Cajero;
        private System.Windows.Forms.Label lbl_ApellidoMa;
        public System.Windows.Forms.Label lbl_ErrorApellidoMa;
        public Guna.UI2.WinForms.Guna2TextBox tb_ApellidoMa;
        public Guna.UI2.WinForms.Guna2DataGridView tablaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Usuario;
        private System.Windows.Forms.DataGridViewImageColumn col_Editar;
        private System.Windows.Forms.DataGridViewImageColumn col_Borrar;
        public Guna.UI2.WinForms.Guna2TextBox tb_busqueda;
    }
}