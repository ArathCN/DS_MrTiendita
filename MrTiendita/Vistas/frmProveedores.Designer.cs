﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Seccion = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_FiltroEmpleados = new Guna.UI2.WinForms.Guna2Button();
            this.btn_NuevoEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_CodigoBarras = new System.Windows.Forms.Label();
            this.tb_BuscarEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_TablaProveedores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Estado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_Estadisticas = new System.Windows.Forms.Label();
            this.lbl_DescEstadisticas = new System.Windows.Forms.Label();
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
            this.pnl_Seccion.Controls.Add(this.btn_FiltroEmpleados);
            this.pnl_Seccion.Controls.Add(this.btn_NuevoEmpleado);
            this.pnl_Seccion.Controls.Add(this.lbl_CodigoBarras);
            this.pnl_Seccion.Controls.Add(this.tb_BuscarEmpleado);
            this.pnl_Seccion.Controls.Add(this.dgv_TablaProveedores);
            this.pnl_Seccion.Controls.Add(this.lbl_Estadisticas);
            this.pnl_Seccion.Controls.Add(this.lbl_DescEstadisticas);
            this.pnl_Seccion.FillColor = System.Drawing.Color.White;
            this.pnl_Seccion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Seccion.Location = new System.Drawing.Point(12, 12);
            this.pnl_Seccion.Name = "pnl_Seccion";
            this.pnl_Seccion.ShadowDecoration.Parent = this.pnl_Seccion;
            this.pnl_Seccion.Size = new System.Drawing.Size(1165, 815);
            this.pnl_Seccion.TabIndex = 5;
            // 
            // btn_FiltroEmpleados
            // 
            this.btn_FiltroEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FiltroEmpleados.BackColor = System.Drawing.Color.White;
            this.btn_FiltroEmpleados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_FiltroEmpleados.BorderRadius = 5;
            this.btn_FiltroEmpleados.CheckedState.Parent = this.btn_FiltroEmpleados;
            this.btn_FiltroEmpleados.CustomImages.Parent = this.btn_FiltroEmpleados;
            this.btn_FiltroEmpleados.FillColor = System.Drawing.Color.White;
            this.btn_FiltroEmpleados.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FiltroEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_FiltroEmpleados.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_FiltroEmpleados.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.btn_FiltroEmpleados.HoverState.Parent = this.btn_FiltroEmpleados;
            this.btn_FiltroEmpleados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_FiltroEmpleados.ImageOffset = new System.Drawing.Point(9, 0);
            this.btn_FiltroEmpleados.Location = new System.Drawing.Point(879, 131);
            this.btn_FiltroEmpleados.Name = "btn_FiltroEmpleados";
            this.btn_FiltroEmpleados.PressedColor = System.Drawing.Color.White;
            this.btn_FiltroEmpleados.ShadowDecoration.Parent = this.btn_FiltroEmpleados;
            this.btn_FiltroEmpleados.Size = new System.Drawing.Size(259, 40);
            this.btn_FiltroEmpleados.TabIndex = 19;
            this.btn_FiltroEmpleados.Text = "Ver proveedores inactivos";
            // 
            // btn_NuevoEmpleado
            // 
            this.btn_NuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NuevoEmpleado.BorderRadius = 5;
            this.btn_NuevoEmpleado.CheckedState.Parent = this.btn_NuevoEmpleado;
            this.btn_NuevoEmpleado.CustomImages.Parent = this.btn_NuevoEmpleado;
            this.btn_NuevoEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_NuevoEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoEmpleado.HoverState.Parent = this.btn_NuevoEmpleado;
            this.btn_NuevoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_NuevoEmpleado.Image")));
            this.btn_NuevoEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_NuevoEmpleado.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_NuevoEmpleado.Location = new System.Drawing.Point(642, 131);
            this.btn_NuevoEmpleado.Name = "btn_NuevoEmpleado";
            this.btn_NuevoEmpleado.ShadowDecoration.Parent = this.btn_NuevoEmpleado;
            this.btn_NuevoEmpleado.Size = new System.Drawing.Size(231, 40);
            this.btn_NuevoEmpleado.TabIndex = 18;
            this.btn_NuevoEmpleado.Text = "Nuevo proveedor";
            this.btn_NuevoEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_NuevoEmpleado.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_NuevoEmpleado.Click += new System.EventHandler(this.btn_NuevoEmpleado_Click);
            // 
            // lbl_CodigoBarras
            // 
            this.lbl_CodigoBarras.AutoSize = true;
            this.lbl_CodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarras.Location = new System.Drawing.Point(21, 104);
            this.lbl_CodigoBarras.Name = "lbl_CodigoBarras";
            this.lbl_CodigoBarras.Size = new System.Drawing.Size(143, 23);
            this.lbl_CodigoBarras.TabIndex = 17;
            this.lbl_CodigoBarras.Text = "Buscar proveedor";
            // 
            // tb_BuscarEmpleado
            // 
            this.tb_BuscarEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_BuscarEmpleado.BorderRadius = 5;
            this.tb_BuscarEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_BuscarEmpleado.DefaultText = "";
            this.tb_BuscarEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_BuscarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_BuscarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarEmpleado.DisabledState.Parent = this.tb_BuscarEmpleado;
            this.tb_BuscarEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarEmpleado.FocusedState.Parent = this.tb_BuscarEmpleado;
            this.tb_BuscarEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BuscarEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarEmpleado.HoverState.Parent = this.tb_BuscarEmpleado;
            this.tb_BuscarEmpleado.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_BuscarEmpleado.IconLeft")));
            this.tb_BuscarEmpleado.Location = new System.Drawing.Point(23, 131);
            this.tb_BuscarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.tb_BuscarEmpleado.Name = "tb_BuscarEmpleado";
            this.tb_BuscarEmpleado.PasswordChar = '\0';
            this.tb_BuscarEmpleado.PlaceholderText = "";
            this.tb_BuscarEmpleado.SelectedText = "";
            this.tb_BuscarEmpleado.ShadowDecoration.Parent = this.tb_BuscarEmpleado;
            this.tb_BuscarEmpleado.Size = new System.Drawing.Size(501, 40);
            this.tb_BuscarEmpleado.TabIndex = 16;
            // 
            // dgv_TablaProveedores
            // 
            this.dgv_TablaProveedores.AllowUserToAddRows = false;
            this.dgv_TablaProveedores.AllowUserToDeleteRows = false;
            this.dgv_TablaProveedores.AllowUserToResizeColumns = false;
            this.dgv_TablaProveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TablaProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TablaProveedores.ColumnHeadersHeight = 35;
            this.dgv_TablaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Nombre,
            this.col_Telefono,
            this.col_Estado,
            this.col_Editar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaProveedores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TablaProveedores.EnableHeadersVisualStyles = false;
            this.dgv_TablaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProveedores.Location = new System.Drawing.Point(23, 197);
            this.dgv_TablaProveedores.Name = "dgv_TablaProveedores";
            this.dgv_TablaProveedores.ReadOnly = true;
            this.dgv_TablaProveedores.RowHeadersVisible = false;
            this.dgv_TablaProveedores.RowHeadersWidth = 65;
            this.dgv_TablaProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaProveedores.RowTemplate.Height = 35;
            this.dgv_TablaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaProveedores.Size = new System.Drawing.Size(1115, 562);
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
            // col_Estado
            // 
            this.col_Estado.HeaderText = "Estado";
            this.col_Estado.MinimumWidth = 6;
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.ReadOnly = true;
            this.col_Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_Editar
            // 
            this.col_Editar.HeaderText = "Editar";
            this.col_Editar.Image = ((System.Drawing.Image)(resources.GetObject("col_Editar.Image")));
            this.col_Editar.MinimumWidth = 6;
            this.col_Editar.Name = "col_Editar";
            this.col_Editar.ReadOnly = true;
            // 
            // lbl_Estadisticas
            // 
            this.lbl_Estadisticas.AutoSize = true;
            this.lbl_Estadisticas.BackColor = System.Drawing.Color.White;
            this.lbl_Estadisticas.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Estadisticas.Location = new System.Drawing.Point(18, 33);
            this.lbl_Estadisticas.Name = "lbl_Estadisticas";
            this.lbl_Estadisticas.Size = new System.Drawing.Size(158, 32);
            this.lbl_Estadisticas.TabIndex = 4;
            this.lbl_Estadisticas.Text = "Proveedores";
            // 
            // lbl_DescEstadisticas
            // 
            this.lbl_DescEstadisticas.AutoSize = true;
            this.lbl_DescEstadisticas.BackColor = System.Drawing.Color.White;
            this.lbl_DescEstadisticas.Location = new System.Drawing.Point(20, 64);
            this.lbl_DescEstadisticas.Name = "lbl_DescEstadisticas";
            this.lbl_DescEstadisticas.Size = new System.Drawing.Size(433, 23);
            this.lbl_DescEstadisticas.TabIndex = 5;
            this.lbl_DescEstadisticas.Text = "Consulta, agrega o modifica los datos de un proveedor.";
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 839);
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
        private Guna.UI2.WinForms.Guna2Button btn_FiltroEmpleados;
        private Guna.UI2.WinForms.Guna2Button btn_NuevoEmpleado;
        private System.Windows.Forms.Label lbl_CodigoBarras;
        private Guna.UI2.WinForms.Guna2TextBox tb_BuscarEmpleado;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_TablaProveedores;
        private System.Windows.Forms.Label lbl_Estadisticas;
        private System.Windows.Forms.Label lbl_DescEstadisticas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefono;
        private System.Windows.Forms.DataGridViewButtonColumn col_Estado;
        private System.Windows.Forms.DataGridViewImageColumn col_Editar;
    }
}