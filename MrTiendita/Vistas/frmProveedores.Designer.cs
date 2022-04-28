
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
            this.btn_nuevoProveedor = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnl_Seccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Seccion
            // 
            this.pnl_Seccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Seccion.BorderRadius = 10;
            this.pnl_Seccion.Controls.Add(this.btn_nuevoProveedor);
            this.pnl_Seccion.Controls.Add(this.lbl_CodigoBarras);
            this.pnl_Seccion.Controls.Add(this.tb_BuscarProveedor);
            this.pnl_Seccion.Controls.Add(this.dgv_TablaProveedores);
            this.pnl_Seccion.Controls.Add(this.lbl_Titulo);
            this.pnl_Seccion.Controls.Add(this.lbl_Descripcion);
            this.pnl_Seccion.FillColor = System.Drawing.Color.White;
            this.pnl_Seccion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Seccion.Location = new System.Drawing.Point(12, 12);
            this.pnl_Seccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Seccion.Name = "pnl_Seccion";
            this.pnl_Seccion.ShadowDecoration.Parent = this.pnl_Seccion;
            this.pnl_Seccion.Size = new System.Drawing.Size(1165, 727);
            this.pnl_Seccion.TabIndex = 5;
            // 
            // btn_nuevoProveedor
            // 
            this.btn_nuevoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevoProveedor.BorderRadius = 5;
            this.btn_nuevoProveedor.CheckedState.Parent = this.btn_nuevoProveedor;
            this.btn_nuevoProveedor.CustomImages.Parent = this.btn_nuevoProveedor;
            this.btn_nuevoProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_nuevoProveedor.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_nuevoProveedor.HoverState.Parent = this.btn_nuevoProveedor;
            this.btn_nuevoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevoProveedor.Image")));
            this.btn_nuevoProveedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_nuevoProveedor.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_nuevoProveedor.Location = new System.Drawing.Point(907, 130);
            this.btn_nuevoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nuevoProveedor.Name = "btn_nuevoProveedor";
            this.btn_nuevoProveedor.ShadowDecoration.Parent = this.btn_nuevoProveedor;
            this.btn_nuevoProveedor.Size = new System.Drawing.Size(231, 39);
            this.btn_nuevoProveedor.TabIndex = 18;
            this.btn_nuevoProveedor.Text = "Nuevo proveedor";
            this.btn_nuevoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_nuevoProveedor.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_nuevoProveedor.Click += new System.EventHandler(this.btn_NuevoEmpleado_Click);
            // 
            // lbl_CodigoBarras
            // 
            this.lbl_CodigoBarras.AutoSize = true;
            this.lbl_CodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarras.Location = new System.Drawing.Point(21, 103);
            this.lbl_CodigoBarras.Name = "lbl_CodigoBarras";
            this.lbl_CodigoBarras.Size = new System.Drawing.Size(143, 23);
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
            this.tb_BuscarProveedor.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BuscarProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarProveedor.HoverState.Parent = this.tb_BuscarProveedor;
            this.tb_BuscarProveedor.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_BuscarProveedor.IconLeft")));
            this.tb_BuscarProveedor.Location = new System.Drawing.Point(23, 130);
            this.tb_BuscarProveedor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_BuscarProveedor.Name = "tb_BuscarProveedor";
            this.tb_BuscarProveedor.PasswordChar = '\0';
            this.tb_BuscarProveedor.PlaceholderText = "";
            this.tb_BuscarProveedor.SelectedText = "";
            this.tb_BuscarProveedor.ShadowDecoration.Parent = this.tb_BuscarProveedor;
            this.tb_BuscarProveedor.Size = new System.Drawing.Size(501, 39);
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
            this.dgv_TablaProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TablaProveedores.EnableHeadersVisualStyles = false;
            this.dgv_TablaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProveedores.Location = new System.Drawing.Point(23, 197);
            this.dgv_TablaProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TablaProveedores.Name = "dgv_TablaProveedores";
            this.dgv_TablaProveedores.ReadOnly = true;
            this.dgv_TablaProveedores.RowHeadersVisible = false;
            this.dgv_TablaProveedores.RowHeadersWidth = 65;
            this.dgv_TablaProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaProveedores.RowTemplate.Height = 35;
            this.dgv_TablaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaProveedores.Size = new System.Drawing.Size(1115, 512);
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
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TablaProveedores.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaProveedores.ThemeStyle.ReadOnly = true;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProveedores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbl_Titulo.Location = new System.Drawing.Point(19, 33);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(158, 32);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Proveedores";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(20, 64);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(433, 23);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Consulta, agrega o modifica los datos de un proveedor.";
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 750);
            this.Controls.Add(this.pnl_Seccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.pnl_Seccion.ResumeLayout(false);
            this.pnl_Seccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Seccion;
        private System.Windows.Forms.Label lbl_CodigoBarras;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Descripcion;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaProveedores;
        public Guna.UI2.WinForms.Guna2TextBox tb_BuscarProveedor;
        public Guna.UI2.WinForms.Guna2Button btn_nuevoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefono;
        private System.Windows.Forms.DataGridViewImageColumn col_Editar;
        private System.Windows.Forms.DataGridViewImageColumn col_Borrar;
    }
}