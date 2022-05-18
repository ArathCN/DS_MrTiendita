
namespace MrTiendita.Vistas
{
    partial class FrmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Seccion = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_CodigoBarras = new System.Windows.Forms.Label();
            this.tb_BuscarProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_TablaProveedores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.tlp_Display = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_MenuProductos = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_RegistrarEmpleado = new System.Windows.Forms.Panel();
            this.lbl_ErrorTelefono = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.tb_Telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ErrorNombre = new System.Windows.Forms.Label();
            this.btn_form = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_TituloForm = new System.Windows.Forms.Label();
            this.lbl_DescripcionProveedor = new System.Windows.Forms.Label();
            this.btn_ModificarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btn_RegistrarProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.Separador = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnl_Seccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProveedores)).BeginInit();
            this.tlp_Display.SuspendLayout();
            this.pnl_MenuProductos.SuspendLayout();
            this.pnl_RegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Seccion
            // 
            this.pnl_Seccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Seccion.BorderRadius = 10;
            this.pnl_Seccion.Controls.Add(this.lbl_CodigoBarras);
            this.pnl_Seccion.Controls.Add(this.tb_BuscarProveedor);
            this.pnl_Seccion.Controls.Add(this.dgv_TablaProveedores);
            this.pnl_Seccion.Controls.Add(this.lbl_Titulo);
            this.pnl_Seccion.Controls.Add(this.lbl_Descripcion);
            this.pnl_Seccion.FillColor = System.Drawing.Color.White;
            this.pnl_Seccion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Seccion.Location = new System.Drawing.Point(2, 2);
            this.pnl_Seccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.pnl_Seccion.Name = "pnl_Seccion";
            this.pnl_Seccion.ShadowDecoration.Parent = this.pnl_Seccion;
            this.pnl_Seccion.Size = new System.Drawing.Size(874, 314);
            this.pnl_Seccion.TabIndex = 5;
            // 
            // lbl_CodigoBarras
            // 
            this.lbl_CodigoBarras.AutoSize = true;
            this.lbl_CodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarras.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.lbl_CodigoBarras.Location = new System.Drawing.Point(16, 78);
            this.lbl_CodigoBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CodigoBarras.Name = "lbl_CodigoBarras";
            this.lbl_CodigoBarras.Size = new System.Drawing.Size(99, 15);
            this.lbl_CodigoBarras.TabIndex = 17;
            this.lbl_CodigoBarras.Text = "Buscar proveedor";
            // 
            // tb_BuscarProveedor
            // 
            this.tb_BuscarProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_BuscarProveedor.BorderRadius = 5;
            this.tb_BuscarProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_BuscarProveedor.DefaultText = "";
            this.tb_BuscarProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_BuscarProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_BuscarProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarProveedor.DisabledState.Parent = this.tb_BuscarProveedor;
            this.tb_BuscarProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarProveedor.FocusedState.Parent = this.tb_BuscarProveedor;
            this.tb_BuscarProveedor.Font = new System.Drawing.Font("Leelawadee UI", 10.2F);
            this.tb_BuscarProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarProveedor.HoverState.Parent = this.tb_BuscarProveedor;
            this.tb_BuscarProveedor.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_BuscarProveedor.IconLeft")));
            this.tb_BuscarProveedor.Location = new System.Drawing.Point(18, 98);
            this.tb_BuscarProveedor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_BuscarProveedor.Name = "tb_BuscarProveedor";
            this.tb_BuscarProveedor.PasswordChar = '\0';
            this.tb_BuscarProveedor.PlaceholderText = "";
            this.tb_BuscarProveedor.SelectedText = "";
            this.tb_BuscarProveedor.ShadowDecoration.Parent = this.tb_BuscarProveedor;
            this.tb_BuscarProveedor.Size = new System.Drawing.Size(376, 29);
            this.tb_BuscarProveedor.TabIndex = 16;
            // 
            // dgv_TablaProveedores
            // 
            this.dgv_TablaProveedores.AllowUserToAddRows = false;
            this.dgv_TablaProveedores.AllowUserToDeleteRows = false;
            this.dgv_TablaProveedores.AllowUserToResizeColumns = false;
            this.dgv_TablaProveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TablaProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TablaProveedores.ColumnHeadersHeight = 35;
            this.dgv_TablaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Nombre,
            this.col_Telefono,
            this.col_Editar,
            this.col_Borrar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TablaProveedores.EnableHeadersVisualStyles = false;
            this.dgv_TablaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProveedores.Location = new System.Drawing.Point(18, 140);
            this.dgv_TablaProveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_TablaProveedores.Name = "dgv_TablaProveedores";
            this.dgv_TablaProveedores.ReadOnly = true;
            this.dgv_TablaProveedores.RowHeadersVisible = false;
            this.dgv_TablaProveedores.RowHeadersWidth = 65;
            this.dgv_TablaProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaProveedores.RowTemplate.Height = 35;
            this.dgv_TablaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaProveedores.Size = new System.Drawing.Size(842, 163);
            this.dgv_TablaProveedores.TabIndex = 15;
            this.dgv_TablaProveedores.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaProveedores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaProveedores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaProveedores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaProveedores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaProveedores.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaProveedores.ThemeStyle.ReadOnly = true;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Visible = false;
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
            this.col_Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(15, 27);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(124, 25);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Proveedores";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(16, 53);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(337, 17);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Consulta, agrega o modifica los datos de un proveedor.";
            // 
            // tlp_Display
            // 
            this.tlp_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Display.ColumnCount = 1;
            this.tlp_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.Controls.Add(this.pnl_MenuProductos, 0, 1);
            this.tlp_Display.Controls.Add(this.pnl_Seccion, 0, 0);
            this.tlp_Display.Location = new System.Drawing.Point(9, 12);
            this.tlp_Display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlp_Display.Name = "tlp_Display";
            this.tlp_Display.RowCount = 2;
            this.tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tlp_Display.Size = new System.Drawing.Size(878, 587);
            this.tlp_Display.TabIndex = 6;
            // 
            // pnl_MenuProductos
            // 
            this.pnl_MenuProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuProductos.BorderRadius = 10;
            this.pnl_MenuProductos.Controls.Add(this.pnl_RegistrarEmpleado);
            this.pnl_MenuProductos.Controls.Add(this.btn_ModificarEmpleado);
            this.pnl_MenuProductos.Controls.Add(this.btn_RegistrarProveedor);
            this.pnl_MenuProductos.Controls.Add(this.Separador);
            this.pnl_MenuProductos.FillColor = System.Drawing.Color.White;
            this.pnl_MenuProductos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MenuProductos.Location = new System.Drawing.Point(2, 322);
            this.pnl_MenuProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_MenuProductos.Name = "pnl_MenuProductos";
            this.pnl_MenuProductos.ShadowDecoration.Parent = this.pnl_MenuProductos;
            this.pnl_MenuProductos.Size = new System.Drawing.Size(874, 263);
            this.pnl_MenuProductos.TabIndex = 6;
            // 
            // pnl_RegistrarEmpleado
            // 
            this.pnl_RegistrarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_RegistrarEmpleado.AutoScroll = true;
            this.pnl_RegistrarEmpleado.BackColor = System.Drawing.Color.White;
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorTelefono);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Telefono);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_Telefono);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_ErrorNombre);
            this.pnl_RegistrarEmpleado.Controls.Add(this.btn_form);
            this.pnl_RegistrarEmpleado.Controls.Add(this.tb_Nombre);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_Nombre);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_TituloForm);
            this.pnl_RegistrarEmpleado.Controls.Add(this.lbl_DescripcionProveedor);
            this.pnl_RegistrarEmpleado.Location = new System.Drawing.Point(14, 50);
            this.pnl_RegistrarEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_RegistrarEmpleado.Name = "pnl_RegistrarEmpleado";
            this.pnl_RegistrarEmpleado.Size = new System.Drawing.Size(850, 209);
            this.pnl_RegistrarEmpleado.TabIndex = 0;
            // 
            // lbl_ErrorTelefono
            // 
            this.lbl_ErrorTelefono.AutoSize = true;
            this.lbl_ErrorTelefono.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorTelefono.Location = new System.Drawing.Point(352, 117);
            this.lbl_ErrorTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ErrorTelefono.Name = "lbl_ErrorTelefono";
            this.lbl_ErrorTelefono.Size = new System.Drawing.Size(40, 13);
            this.lbl_ErrorTelefono.TabIndex = 85;
            this.lbl_ErrorTelefono.Text = "* Error";
            this.lbl_ErrorTelefono.Visible = false;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.BackColor = System.Drawing.Color.White;
            this.lbl_Telefono.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(352, 64);
            this.lbl_Telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(54, 15);
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
            this.tb_Telefono.Location = new System.Drawing.Point(355, 85);
            this.tb_Telefono.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tb_Telefono.MaxLength = 10;
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.PasswordChar = '\0';
            this.tb_Telefono.PlaceholderText = "";
            this.tb_Telefono.SelectedText = "";
            this.tb_Telefono.ShadowDecoration.Parent = this.tb_Telefono;
            this.tb_Telefono.Size = new System.Drawing.Size(160, 29);
            this.tb_Telefono.TabIndex = 83;
            // 
            // lbl_ErrorNombre
            // 
            this.lbl_ErrorNombre.AutoSize = true;
            this.lbl_ErrorNombre.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorNombre.Location = new System.Drawing.Point(16, 118);
            this.lbl_ErrorNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ErrorNombre.Name = "lbl_ErrorNombre";
            this.lbl_ErrorNombre.Size = new System.Drawing.Size(40, 13);
            this.lbl_ErrorNombre.TabIndex = 49;
            this.lbl_ErrorNombre.Text = "* Error";
            this.lbl_ErrorNombre.Visible = false;
            // 
            // btn_form
            // 
            this.btn_form.BorderRadius = 5;
            this.btn_form.CheckedState.Parent = this.btn_form;
            this.btn_form.CustomImages.Parent = this.btn_form;
            this.btn_form.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_form.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form.ForeColor = System.Drawing.Color.White;
            this.btn_form.HoverState.Parent = this.btn_form;
            this.btn_form.Location = new System.Drawing.Point(686, 158);
            this.btn_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_form.Name = "btn_form";
            this.btn_form.ShadowDecoration.Parent = this.btn_form;
            this.btn_form.Size = new System.Drawing.Size(152, 29);
            this.btn_form.TabIndex = 47;
            this.btn_form.Text = "Registrar proveedor";
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
            this.tb_Nombre.Location = new System.Drawing.Point(19, 85);
            this.tb_Nombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.PasswordChar = '\0';
            this.tb_Nombre.PlaceholderText = "";
            this.tb_Nombre.SelectedText = "";
            this.tb_Nombre.ShadowDecoration.Parent = this.tb_Nombre;
            this.tb_Nombre.Size = new System.Drawing.Size(330, 29);
            this.tb_Nombre.TabIndex = 27;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.White;
            this.lbl_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(16, 65);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 28;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_TituloForm
            // 
            this.lbl_TituloForm.AutoSize = true;
            this.lbl_TituloForm.BackColor = System.Drawing.Color.White;
            this.lbl_TituloForm.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_TituloForm.Location = new System.Drawing.Point(9, 10);
            this.lbl_TituloForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TituloForm.Name = "lbl_TituloForm";
            this.lbl_TituloForm.Size = new System.Drawing.Size(240, 25);
            this.lbl_TituloForm.TabIndex = 4;
            this.lbl_TituloForm.Text = "Registrar a  un proveedor";
            // 
            // lbl_DescripcionProveedor
            // 
            this.lbl_DescripcionProveedor.AutoSize = true;
            this.lbl_DescripcionProveedor.BackColor = System.Drawing.Color.White;
            this.lbl_DescripcionProveedor.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_DescripcionProveedor.Location = new System.Drawing.Point(10, 35);
            this.lbl_DescripcionProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DescripcionProveedor.Name = "lbl_DescripcionProveedor";
            this.lbl_DescripcionProveedor.Size = new System.Drawing.Size(259, 17);
            this.lbl_DescripcionProveedor.TabIndex = 5;
            this.lbl_DescripcionProveedor.Text = "Registra los datos de un nuevo proveedor.";
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
            this.btn_ModificarEmpleado.Location = new System.Drawing.Point(214, 6);
            this.btn_ModificarEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ModificarEmpleado.Name = "btn_ModificarEmpleado";
            this.btn_ModificarEmpleado.PressedColor = System.Drawing.Color.White;
            this.btn_ModificarEmpleado.ShadowDecoration.Parent = this.btn_ModificarEmpleado;
            this.btn_ModificarEmpleado.Size = new System.Drawing.Size(190, 37);
            this.btn_ModificarEmpleado.TabIndex = 1;
            this.btn_ModificarEmpleado.Text = "Modificar proveedor";
            this.btn_ModificarEmpleado.Visible = false;
            // 
            // btn_RegistrarProveedor
            // 
            this.btn_RegistrarProveedor.CheckedState.Parent = this.btn_RegistrarProveedor;
            this.btn_RegistrarProveedor.CustomImages.Parent = this.btn_RegistrarProveedor;
            this.btn_RegistrarProveedor.FillColor = System.Drawing.Color.White;
            this.btn_RegistrarProveedor.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_RegistrarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_RegistrarProveedor.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_RegistrarProveedor.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_RegistrarProveedor.HoverState.Parent = this.btn_RegistrarProveedor;
            this.btn_RegistrarProveedor.Location = new System.Drawing.Point(10, 6);
            this.btn_RegistrarProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_RegistrarProveedor.Name = "btn_RegistrarProveedor";
            this.btn_RegistrarProveedor.PressedColor = System.Drawing.Color.White;
            this.btn_RegistrarProveedor.ShadowDecoration.Parent = this.btn_RegistrarProveedor;
            this.btn_RegistrarProveedor.Size = new System.Drawing.Size(190, 37);
            this.btn_RegistrarProveedor.TabIndex = 4;
            this.btn_RegistrarProveedor.Text = "Registrar Proveedor";
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
            this.Separador.Location = new System.Drawing.Point(14, 22);
            this.Separador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Separador.Name = "Separador";
            this.Separador.PasswordChar = '\0';
            this.Separador.ReadOnly = true;
            this.Separador.SelectedText = "";
            this.Separador.Size = new System.Drawing.Size(850, 30);
            this.Separador.TabIndex = 34;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(896, 609);
            this.Controls.Add(this.tlp_Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.pnl_Seccion.ResumeLayout(false);
            this.pnl_Seccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProveedores)).EndInit();
            this.tlp_Display.ResumeLayout(false);
            this.pnl_MenuProductos.ResumeLayout(false);
            this.pnl_RegistrarEmpleado.ResumeLayout(false);
            this.pnl_RegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Seccion;
        private System.Windows.Forms.Label lbl_CodigoBarras;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Descripcion;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaProveedores;
        public Guna.UI2.WinForms.Guna2TextBox tb_BuscarProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefono;
        private System.Windows.Forms.DataGridViewImageColumn col_Editar;
        private System.Windows.Forms.DataGridViewImageColumn col_Borrar;
        private System.Windows.Forms.TableLayoutPanel tlp_Display;
        public Guna.UI2.WinForms.Guna2Panel pnl_MenuProductos;
        public System.Windows.Forms.Panel pnl_RegistrarEmpleado;
        public System.Windows.Forms.Label lbl_ErrorTelefono;
        private System.Windows.Forms.Label lbl_Telefono;
        public Guna.UI2.WinForms.Guna2TextBox tb_Telefono;
        public System.Windows.Forms.Label lbl_ErrorNombre;
        public Guna.UI2.WinForms.Guna2Button btn_form;
        public Guna.UI2.WinForms.Guna2TextBox tb_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        public System.Windows.Forms.Label lbl_TituloForm;
        public System.Windows.Forms.Label lbl_DescripcionProveedor;
        public Guna.UI2.WinForms.Guna2Button btn_ModificarEmpleado;
        public Guna.UI2.WinForms.Guna2Button btn_RegistrarProveedor;
        private Guna.UI.WinForms.GunaLineTextBox Separador;
    }
}