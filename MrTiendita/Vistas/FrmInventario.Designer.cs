
namespace MrTiendita.Vistas
{
    partial class FrmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.pnl_MenuProductos = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_CrearProducto = new System.Windows.Forms.Panel();
            this.lbl_ErrorCategoria = new System.Windows.Forms.Label();
            this.lbl_ErrorPrecioVenta = new System.Windows.Forms.Label();
            this.lbl_ErrorPrecioCompra = new System.Windows.Forms.Label();
            this.lbl_ErrorMinimo = new System.Windows.Forms.Label();
            this.lbl_ErrorGanancia = new System.Windows.Forms.Label();
            this.lbl_ErrorDescripcion = new System.Windows.Forms.Label();
            this.lbl_ErrrCodigo = new System.Windows.Forms.Label();
            this.lbl_PrecioVenta = new System.Windows.Forms.Label();
            this.btn_AgregarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.tb_PrecioVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_PrecioCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_PrecioCompra = new System.Windows.Forms.Label();
            this.lbl_CantidadMinima = new System.Windows.Forms.Label();
            this.tb_Minima = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Porcentaje = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Ganancia = new System.Windows.Forms.Label();
            this.cb_Categoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.tb_Descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_CodigoBarras = new System.Windows.Forms.Label();
            this.tb_CodigoBarras = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.btn_ModificarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_NuevaEntrada = new System.Windows.Forms.Panel();
            this.lbl_ErrorProveedor = new System.Windows.Forms.Label();
            this.lbl_ErrorCantidad = new System.Windows.Forms.Label();
            this.lbl_ErrorCodigoBarras = new System.Windows.Forms.Label();
            this.btn_LimpiarEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.btn_RegistrarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.cb_Proveedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.tb_Cantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_CodigoBarra = new System.Windows.Forms.Label();
            this.tb_CodigoBarra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_NuevaEntrada = new System.Windows.Forms.Label();
            this.lbl_DescripcionNueva = new System.Windows.Forms.Label();
            this.btn_CrearProducto = new Guna.UI2.WinForms.Guna2Button();
            this.btn_NuevaEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.Separador = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnl_Contenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ConsultarProductos = new System.Windows.Forms.Label();
            this.dgv_TablaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CantidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_DescripcionConsultar = new System.Windows.Forms.Label();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.tb_BuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.tlp_Display = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_MenuProductos.SuspendLayout();
            this.pnl_CrearProducto.SuspendLayout();
            this.pnl_NuevaEntrada.SuspendLayout();
            this.pnl_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProductos)).BeginInit();
            this.tlp_Display.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MenuProductos
            // 
            this.pnl_MenuProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuProductos.BorderRadius = 10;
            this.pnl_MenuProductos.Controls.Add(this.pnl_CrearProducto);
            this.pnl_MenuProductos.Controls.Add(this.btn_ModificarProducto);
            this.pnl_MenuProductos.Controls.Add(this.pnl_NuevaEntrada);
            this.pnl_MenuProductos.Controls.Add(this.btn_CrearProducto);
            this.pnl_MenuProductos.Controls.Add(this.btn_NuevaEntrada);
            this.pnl_MenuProductos.Controls.Add(this.Separador);
            this.pnl_MenuProductos.FillColor = System.Drawing.Color.White;
            this.pnl_MenuProductos.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MenuProductos.Location = new System.Drawing.Point(3, 436);
            this.pnl_MenuProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_MenuProductos.Name = "pnl_MenuProductos";
            this.pnl_MenuProductos.ShadowDecoration.Parent = this.pnl_MenuProductos;
            this.pnl_MenuProductos.Size = new System.Drawing.Size(1165, 374);
            this.pnl_MenuProductos.TabIndex = 1;
            // 
            // pnl_CrearProducto
            // 
            this.pnl_CrearProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CrearProducto.BackColor = System.Drawing.Color.White;
            this.pnl_CrearProducto.Controls.Add(this.lbl_ErrorCategoria);
            this.pnl_CrearProducto.Controls.Add(this.lbl_ErrorPrecioVenta);
            this.pnl_CrearProducto.Controls.Add(this.lbl_ErrorPrecioCompra);
            this.pnl_CrearProducto.Controls.Add(this.lbl_ErrorMinimo);
            this.pnl_CrearProducto.Controls.Add(this.lbl_ErrorGanancia);
            this.pnl_CrearProducto.Controls.Add(this.lbl_ErrorDescripcion);
            this.pnl_CrearProducto.Controls.Add(this.lbl_ErrrCodigo);
            this.pnl_CrearProducto.Controls.Add(this.lbl_PrecioVenta);
            this.pnl_CrearProducto.Controls.Add(this.btn_AgregarProducto);
            this.pnl_CrearProducto.Controls.Add(this.tb_PrecioVenta);
            this.pnl_CrearProducto.Controls.Add(this.tb_PrecioCompra);
            this.pnl_CrearProducto.Controls.Add(this.lbl_PrecioCompra);
            this.pnl_CrearProducto.Controls.Add(this.lbl_CantidadMinima);
            this.pnl_CrearProducto.Controls.Add(this.tb_Minima);
            this.pnl_CrearProducto.Controls.Add(this.tb_Porcentaje);
            this.pnl_CrearProducto.Controls.Add(this.lbl_Ganancia);
            this.pnl_CrearProducto.Controls.Add(this.cb_Categoria);
            this.pnl_CrearProducto.Controls.Add(this.lbl_Categoria);
            this.pnl_CrearProducto.Controls.Add(this.tb_Descripcion);
            this.pnl_CrearProducto.Controls.Add(this.lbl_Nombre);
            this.pnl_CrearProducto.Controls.Add(this.lbl_CodigoBarras);
            this.pnl_CrearProducto.Controls.Add(this.tb_CodigoBarras);
            this.pnl_CrearProducto.Controls.Add(this.lbl_Titulo);
            this.pnl_CrearProducto.Controls.Add(this.lbl_Descripcion);
            this.pnl_CrearProducto.Location = new System.Drawing.Point(18, 62);
            this.pnl_CrearProducto.Name = "pnl_CrearProducto";
            this.pnl_CrearProducto.Size = new System.Drawing.Size(1134, 380);
            this.pnl_CrearProducto.TabIndex = 0;
            this.pnl_CrearProducto.Visible = false;
            // 
            // lbl_ErrorCategoria
            // 
            this.lbl_ErrorCategoria.AutoSize = true;
            this.lbl_ErrorCategoria.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorCategoria.Location = new System.Drawing.Point(839, 165);
            this.lbl_ErrorCategoria.Name = "lbl_ErrorCategoria";
            this.lbl_ErrorCategoria.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorCategoria.TabIndex = 54;
            this.lbl_ErrorCategoria.Text = "* Error";
            this.lbl_ErrorCategoria.Visible = false;
            // 
            // lbl_ErrorPrecioVenta
            // 
            this.lbl_ErrorPrecioVenta.AutoSize = true;
            this.lbl_ErrorPrecioVenta.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorPrecioVenta.Location = new System.Drawing.Point(675, 270);
            this.lbl_ErrorPrecioVenta.Name = "lbl_ErrorPrecioVenta";
            this.lbl_ErrorPrecioVenta.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorPrecioVenta.TabIndex = 53;
            this.lbl_ErrorPrecioVenta.Text = "* Error";
            this.lbl_ErrorPrecioVenta.Visible = false;
            // 
            // lbl_ErrorPrecioCompra
            // 
            this.lbl_ErrorPrecioCompra.AutoSize = true;
            this.lbl_ErrorPrecioCompra.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorPrecioCompra.Location = new System.Drawing.Point(457, 270);
            this.lbl_ErrorPrecioCompra.Name = "lbl_ErrorPrecioCompra";
            this.lbl_ErrorPrecioCompra.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorPrecioCompra.TabIndex = 52;
            this.lbl_ErrorPrecioCompra.Text = "* Error";
            this.lbl_ErrorPrecioCompra.Visible = false;
            // 
            // lbl_ErrorMinimo
            // 
            this.lbl_ErrorMinimo.AutoSize = true;
            this.lbl_ErrorMinimo.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorMinimo.Location = new System.Drawing.Point(243, 270);
            this.lbl_ErrorMinimo.Name = "lbl_ErrorMinimo";
            this.lbl_ErrorMinimo.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorMinimo.TabIndex = 51;
            this.lbl_ErrorMinimo.Text = "* Error";
            this.lbl_ErrorMinimo.Visible = false;
            // 
            // lbl_ErrorGanancia
            // 
            this.lbl_ErrorGanancia.AutoSize = true;
            this.lbl_ErrorGanancia.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorGanancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorGanancia.Location = new System.Drawing.Point(21, 270);
            this.lbl_ErrorGanancia.Name = "lbl_ErrorGanancia";
            this.lbl_ErrorGanancia.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorGanancia.TabIndex = 50;
            this.lbl_ErrorGanancia.Text = "* Error";
            this.lbl_ErrorGanancia.Visible = false;
            // 
            // lbl_ErrorDescripcion
            // 
            this.lbl_ErrorDescripcion.AutoSize = true;
            this.lbl_ErrorDescripcion.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorDescripcion.Location = new System.Drawing.Point(310, 164);
            this.lbl_ErrorDescripcion.Name = "lbl_ErrorDescripcion";
            this.lbl_ErrorDescripcion.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorDescripcion.TabIndex = 49;
            this.lbl_ErrorDescripcion.Text = "* Error";
            this.lbl_ErrorDescripcion.Visible = false;
            // 
            // lbl_ErrrCodigo
            // 
            this.lbl_ErrrCodigo.AutoSize = true;
            this.lbl_ErrrCodigo.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrrCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrrCodigo.Location = new System.Drawing.Point(21, 165);
            this.lbl_ErrrCodigo.Name = "lbl_ErrrCodigo";
            this.lbl_ErrrCodigo.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrrCodigo.TabIndex = 48;
            this.lbl_ErrrCodigo.Text = "* Error";
            this.lbl_ErrrCodigo.Visible = false;
            // 
            // lbl_PrecioVenta
            // 
            this.lbl_PrecioVenta.AutoSize = true;
            this.lbl_PrecioVenta.BackColor = System.Drawing.Color.White;
            this.lbl_PrecioVenta.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_PrecioVenta.Location = new System.Drawing.Point(675, 197);
            this.lbl_PrecioVenta.Name = "lbl_PrecioVenta";
            this.lbl_PrecioVenta.Size = new System.Drawing.Size(128, 23);
            this.lbl_PrecioVenta.TabIndex = 46;
            this.lbl_PrecioVenta.Text = "Precio de venta";
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.BorderRadius = 5;
            this.btn_AgregarProducto.CheckedState.Parent = this.btn_AgregarProducto;
            this.btn_AgregarProducto.CustomImages.Parent = this.btn_AgregarProducto;
            this.btn_AgregarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarProducto.HoverState.Parent = this.btn_AgregarProducto;
            this.btn_AgregarProducto.Location = new System.Drawing.Point(927, 226);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.ShadowDecoration.Parent = this.btn_AgregarProducto;
            this.btn_AgregarProducto.Size = new System.Drawing.Size(186, 40);
            this.btn_AgregarProducto.TabIndex = 47;
            this.btn_AgregarProducto.Text = "Crear producto";
            // 
            // tb_PrecioVenta
            // 
            this.tb_PrecioVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_PrecioVenta.BorderRadius = 5;
            this.tb_PrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_PrecioVenta.DefaultText = "";
            this.tb_PrecioVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_PrecioVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_PrecioVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PrecioVenta.DisabledState.Parent = this.tb_PrecioVenta;
            this.tb_PrecioVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PrecioVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PrecioVenta.FocusedState.Parent = this.tb_PrecioVenta;
            this.tb_PrecioVenta.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PrecioVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PrecioVenta.HoverState.Parent = this.tb_PrecioVenta;
            this.tb_PrecioVenta.Location = new System.Drawing.Point(669, 226);
            this.tb_PrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PrecioVenta.Name = "tb_PrecioVenta";
            this.tb_PrecioVenta.PasswordChar = '\0';
            this.tb_PrecioVenta.PlaceholderText = "";
            this.tb_PrecioVenta.SelectedText = "";
            this.tb_PrecioVenta.ShadowDecoration.Parent = this.tb_PrecioVenta;
            this.tb_PrecioVenta.Size = new System.Drawing.Size(205, 40);
            this.tb_PrecioVenta.TabIndex = 45;
            // 
            // tb_PrecioCompra
            // 
            this.tb_PrecioCompra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_PrecioCompra.BorderRadius = 5;
            this.tb_PrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_PrecioCompra.DefaultText = "";
            this.tb_PrecioCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_PrecioCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_PrecioCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PrecioCompra.DisabledState.Parent = this.tb_PrecioCompra;
            this.tb_PrecioCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PrecioCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PrecioCompra.FocusedState.Parent = this.tb_PrecioCompra;
            this.tb_PrecioCompra.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PrecioCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PrecioCompra.HoverState.Parent = this.tb_PrecioCompra;
            this.tb_PrecioCompra.Location = new System.Drawing.Point(454, 226);
            this.tb_PrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PrecioCompra.Name = "tb_PrecioCompra";
            this.tb_PrecioCompra.PasswordChar = '\0';
            this.tb_PrecioCompra.PlaceholderText = "";
            this.tb_PrecioCompra.SelectedText = "";
            this.tb_PrecioCompra.ShadowDecoration.Parent = this.tb_PrecioCompra;
            this.tb_PrecioCompra.Size = new System.Drawing.Size(205, 40);
            this.tb_PrecioCompra.TabIndex = 43;
            // 
            // lbl_PrecioCompra
            // 
            this.lbl_PrecioCompra.AutoSize = true;
            this.lbl_PrecioCompra.BackColor = System.Drawing.Color.White;
            this.lbl_PrecioCompra.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_PrecioCompra.Location = new System.Drawing.Point(457, 197);
            this.lbl_PrecioCompra.Name = "lbl_PrecioCompra";
            this.lbl_PrecioCompra.Size = new System.Drawing.Size(144, 23);
            this.lbl_PrecioCompra.TabIndex = 44;
            this.lbl_PrecioCompra.Text = "Precio de compra";
            // 
            // lbl_CantidadMinima
            // 
            this.lbl_CantidadMinima.AutoSize = true;
            this.lbl_CantidadMinima.BackColor = System.Drawing.Color.White;
            this.lbl_CantidadMinima.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_CantidadMinima.Location = new System.Drawing.Point(241, 197);
            this.lbl_CantidadMinima.Name = "lbl_CantidadMinima";
            this.lbl_CantidadMinima.Size = new System.Drawing.Size(138, 23);
            this.lbl_CantidadMinima.TabIndex = 42;
            this.lbl_CantidadMinima.Text = "Mínima cantidad\r\n";
            // 
            // tb_Minima
            // 
            this.tb_Minima.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Minima.BorderRadius = 5;
            this.tb_Minima.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Minima.DefaultText = "";
            this.tb_Minima.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Minima.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Minima.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Minima.DisabledState.Parent = this.tb_Minima;
            this.tb_Minima.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Minima.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Minima.FocusedState.Parent = this.tb_Minima;
            this.tb_Minima.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Minima.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Minima.HoverState.Parent = this.tb_Minima;
            this.tb_Minima.Location = new System.Drawing.Point(238, 226);
            this.tb_Minima.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Minima.Name = "tb_Minima";
            this.tb_Minima.PasswordChar = '\0';
            this.tb_Minima.PlaceholderText = "";
            this.tb_Minima.SelectedText = "";
            this.tb_Minima.ShadowDecoration.Parent = this.tb_Minima;
            this.tb_Minima.Size = new System.Drawing.Size(205, 40);
            this.tb_Minima.TabIndex = 41;
            // 
            // tb_Porcentaje
            // 
            this.tb_Porcentaje.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Porcentaje.BorderRadius = 5;
            this.tb_Porcentaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Porcentaje.DefaultText = "";
            this.tb_Porcentaje.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Porcentaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Porcentaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Porcentaje.DisabledState.Parent = this.tb_Porcentaje;
            this.tb_Porcentaje.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Porcentaje.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Porcentaje.FocusedState.Parent = this.tb_Porcentaje;
            this.tb_Porcentaje.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Porcentaje.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Porcentaje.HoverState.Parent = this.tb_Porcentaje;
            this.tb_Porcentaje.Location = new System.Drawing.Point(19, 226);
            this.tb_Porcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Porcentaje.Name = "tb_Porcentaje";
            this.tb_Porcentaje.PasswordChar = '\0';
            this.tb_Porcentaje.PlaceholderText = "";
            this.tb_Porcentaje.SelectedText = "";
            this.tb_Porcentaje.ShadowDecoration.Parent = this.tb_Porcentaje;
            this.tb_Porcentaje.Size = new System.Drawing.Size(205, 40);
            this.tb_Porcentaje.TabIndex = 39;
            // 
            // lbl_Ganancia
            // 
            this.lbl_Ganancia.AutoSize = true;
            this.lbl_Ganancia.BackColor = System.Drawing.Color.White;
            this.lbl_Ganancia.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Ganancia.Location = new System.Drawing.Point(20, 197);
            this.lbl_Ganancia.Name = "lbl_Ganancia";
            this.lbl_Ganancia.Size = new System.Drawing.Size(189, 23);
            this.lbl_Ganancia.TabIndex = 40;
            this.lbl_Ganancia.Text = "Porcentaje de ganancia";
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.cb_Categoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.cb_Categoria.BorderRadius = 5;
            this.cb_Categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categoria.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Categoria.FocusedState.Parent = this.cb_Categoria;
            this.cb_Categoria.Font = new System.Drawing.Font("Leelawadee UI", 11.25F);
            this.cb_Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.HoverState.Parent = this.cb_Categoria;
            this.cb_Categoria.ItemHeight = 30;
            this.cb_Categoria.Items.AddRange(new object[] {
            "Frutas y verduras ",
            "Panadería y tortillería ",
            "Carnicería ",
            "Lácteos ",
            "Abarrotes ",
            "Limpieza y hogar ",
            "Higiene personal y salud ",
            "Mascotas ",
            "Refrigerados",
            "Sin categoría"});
            this.cb_Categoria.ItemsAppearance.Parent = this.cb_Categoria;
            this.cb_Categoria.Location = new System.Drawing.Point(698, 119);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.ShadowDecoration.Parent = this.cb_Categoria;
            this.cb_Categoria.Size = new System.Drawing.Size(282, 36);
            this.cb_Categoria.TabIndex = 29;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.White;
            this.lbl_Categoria.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Categoria.Location = new System.Drawing.Point(700, 93);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(84, 23);
            this.lbl_Categoria.TabIndex = 30;
            this.lbl_Categoria.Text = "Categoría";
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Descripcion.BorderRadius = 5;
            this.tb_Descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Descripcion.DefaultText = "";
            this.tb_Descripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Descripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Descripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Descripcion.DisabledState.Parent = this.tb_Descripcion;
            this.tb_Descripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Descripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Descripcion.FocusedState.Parent = this.tb_Descripcion;
            this.tb_Descripcion.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Descripcion.HoverState.Parent = this.tb_Descripcion;
            this.tb_Descripcion.Location = new System.Drawing.Point(272, 119);
            this.tb_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.PasswordChar = '\0';
            this.tb_Descripcion.PlaceholderText = "";
            this.tb_Descripcion.SelectedText = "";
            this.tb_Descripcion.ShadowDecoration.Parent = this.tb_Descripcion;
            this.tb_Descripcion.Size = new System.Drawing.Size(417, 40);
            this.tb_Descripcion.TabIndex = 27;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.White;
            this.lbl_Nombre.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Nombre.Location = new System.Drawing.Point(273, 91);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(98, 23);
            this.lbl_Nombre.TabIndex = 28;
            this.lbl_Nombre.Text = "Descripción";
            // 
            // lbl_CodigoBarras
            // 
            this.lbl_CodigoBarras.AutoSize = true;
            this.lbl_CodigoBarras.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarras.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_CodigoBarras.Location = new System.Drawing.Point(20, 92);
            this.lbl_CodigoBarras.Name = "lbl_CodigoBarras";
            this.lbl_CodigoBarras.Size = new System.Drawing.Size(141, 23);
            this.lbl_CodigoBarras.TabIndex = 25;
            this.lbl_CodigoBarras.Text = "Código de barras";
            // 
            // tb_CodigoBarras
            // 
            this.tb_CodigoBarras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_CodigoBarras.BorderRadius = 5;
            this.tb_CodigoBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CodigoBarras.DefaultText = "";
            this.tb_CodigoBarras.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CodigoBarras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CodigoBarras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodigoBarras.DisabledState.Parent = this.tb_CodigoBarras;
            this.tb_CodigoBarras.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodigoBarras.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodigoBarras.FocusedState.Parent = this.tb_CodigoBarras;
            this.tb_CodigoBarras.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CodigoBarras.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodigoBarras.HoverState.Parent = this.tb_CodigoBarras;
            this.tb_CodigoBarras.Location = new System.Drawing.Point(18, 120);
            this.tb_CodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CodigoBarras.Name = "tb_CodigoBarras";
            this.tb_CodigoBarras.PasswordChar = '\0';
            this.tb_CodigoBarras.PlaceholderText = "";
            this.tb_CodigoBarras.SelectedText = "";
            this.tb_CodigoBarras.ShadowDecoration.Parent = this.tb_CodigoBarras;
            this.tb_CodigoBarras.Size = new System.Drawing.Size(245, 40);
            this.tb_CodigoBarras.TabIndex = 24;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 12);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(304, 32);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Crear un producto nuevo\r\n";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Descripcion.Location = new System.Drawing.Point(14, 43);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(491, 46);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Crea un producto nuevo para empezar a venderlo en la tienda.\r\n\r\n";
            // 
            // btn_ModificarProducto
            // 
            this.btn_ModificarProducto.CheckedState.Parent = this.btn_ModificarProducto;
            this.btn_ModificarProducto.CustomImages.Parent = this.btn_ModificarProducto;
            this.btn_ModificarProducto.FillColor = System.Drawing.Color.White;
            this.btn_ModificarProducto.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_ModificarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_ModificarProducto.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_ModificarProducto.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_ModificarProducto.HoverState.Parent = this.btn_ModificarProducto;
            this.btn_ModificarProducto.Location = new System.Drawing.Point(559, 7);
            this.btn_ModificarProducto.Name = "btn_ModificarProducto";
            this.btn_ModificarProducto.PressedColor = System.Drawing.Color.White;
            this.btn_ModificarProducto.ShadowDecoration.Parent = this.btn_ModificarProducto;
            this.btn_ModificarProducto.Size = new System.Drawing.Size(253, 45);
            this.btn_ModificarProducto.TabIndex = 1;
            this.btn_ModificarProducto.Text = "Modificar producto";
            // 
            // pnl_NuevaEntrada
            // 
            this.pnl_NuevaEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_NuevaEntrada.AutoScroll = true;
            this.pnl_NuevaEntrada.BackColor = System.Drawing.Color.White;
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_ErrorProveedor);
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_ErrorCantidad);
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_ErrorCodigoBarras);
            this.pnl_NuevaEntrada.Controls.Add(this.btn_LimpiarEntrada);
            this.pnl_NuevaEntrada.Controls.Add(this.btn_RegistrarProducto);
            this.pnl_NuevaEntrada.Controls.Add(this.cb_Proveedor);
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_Proveedor);
            this.pnl_NuevaEntrada.Controls.Add(this.tb_Cantidad);
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_Cantidad);
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_CodigoBarra);
            this.pnl_NuevaEntrada.Controls.Add(this.tb_CodigoBarra);
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_NuevaEntrada);
            this.pnl_NuevaEntrada.Controls.Add(this.lbl_DescripcionNueva);
            this.pnl_NuevaEntrada.Location = new System.Drawing.Point(18, 62);
            this.pnl_NuevaEntrada.Name = "pnl_NuevaEntrada";
            this.pnl_NuevaEntrada.Size = new System.Drawing.Size(1134, 256);
            this.pnl_NuevaEntrada.TabIndex = 35;
            this.pnl_NuevaEntrada.Visible = false;
            // 
            // lbl_ErrorProveedor
            // 
            this.lbl_ErrorProveedor.AutoSize = true;
            this.lbl_ErrorProveedor.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorProveedor.Location = new System.Drawing.Point(496, 169);
            this.lbl_ErrorProveedor.Name = "lbl_ErrorProveedor";
            this.lbl_ErrorProveedor.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorProveedor.TabIndex = 51;
            this.lbl_ErrorProveedor.Text = "* Error";
            this.lbl_ErrorProveedor.Visible = false;
            // 
            // lbl_ErrorCantidad
            // 
            this.lbl_ErrorCantidad.AutoSize = true;
            this.lbl_ErrorCantidad.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorCantidad.Location = new System.Drawing.Point(312, 169);
            this.lbl_ErrorCantidad.Name = "lbl_ErrorCantidad";
            this.lbl_ErrorCantidad.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorCantidad.TabIndex = 50;
            this.lbl_ErrorCantidad.Text = "* Error";
            this.lbl_ErrorCantidad.Visible = false;
            // 
            // lbl_ErrorCodigoBarras
            // 
            this.lbl_ErrorCodigoBarras.AutoSize = true;
            this.lbl_ErrorCodigoBarras.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(76)))));
            this.lbl_ErrorCodigoBarras.Location = new System.Drawing.Point(21, 164);
            this.lbl_ErrorCodigoBarras.Name = "lbl_ErrorCodigoBarras";
            this.lbl_ErrorCodigoBarras.Size = new System.Drawing.Size(49, 19);
            this.lbl_ErrorCodigoBarras.TabIndex = 49;
            this.lbl_ErrorCodigoBarras.Text = "* Error";
            this.lbl_ErrorCodigoBarras.Visible = false;
            // 
            // btn_LimpiarEntrada
            // 
            this.btn_LimpiarEntrada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.BorderRadius = 5;
            this.btn_LimpiarEntrada.BorderThickness = 1;
            this.btn_LimpiarEntrada.CheckedState.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.CustomImages.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.FillColor = System.Drawing.Color.White;
            this.btn_LimpiarEntrada.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimpiarEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.HoverState.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.Location = new System.Drawing.Point(194, 217);
            this.btn_LimpiarEntrada.Name = "btn_LimpiarEntrada";
            this.btn_LimpiarEntrada.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_LimpiarEntrada.ShadowDecoration.Parent = this.btn_LimpiarEntrada;
            this.btn_LimpiarEntrada.Size = new System.Drawing.Size(152, 40);
            this.btn_LimpiarEntrada.TabIndex = 44;
            this.btn_LimpiarEntrada.Text = "Limpiar";
            // 
            // btn_RegistrarProducto
            // 
            this.btn_RegistrarProducto.BorderRadius = 5;
            this.btn_RegistrarProducto.CheckedState.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.CustomImages.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_RegistrarProducto.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarProducto.HoverState.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.Location = new System.Drawing.Point(18, 217);
            this.btn_RegistrarProducto.Name = "btn_RegistrarProducto";
            this.btn_RegistrarProducto.ShadowDecoration.Parent = this.btn_RegistrarProducto;
            this.btn_RegistrarProducto.Size = new System.Drawing.Size(152, 40);
            this.btn_RegistrarProducto.TabIndex = 43;
            this.btn_RegistrarProducto.Text = "Registrar";
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.cb_Proveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.cb_Proveedor.BorderRadius = 5;
            this.cb_Proveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Proveedor.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Proveedor.FocusedState.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Font = new System.Drawing.Font("Leelawadee UI", 11.25F);
            this.cb_Proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.HoverState.Parent = this.cb_Proveedor;
            this.cb_Proveedor.ItemHeight = 30;
            this.cb_Proveedor.ItemsAppearance.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Location = new System.Drawing.Point(492, 120);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.ShadowDecoration.Parent = this.cb_Proveedor;
            this.cb_Proveedor.Size = new System.Drawing.Size(329, 36);
            this.cb_Proveedor.TabIndex = 41;
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.BackColor = System.Drawing.Color.White;
            this.lbl_Proveedor.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Proveedor.Location = new System.Drawing.Point(496, 94);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(88, 23);
            this.lbl_Proveedor.TabIndex = 42;
            this.lbl_Proveedor.Text = "Proveedor\r\n";
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_Cantidad.BorderRadius = 5;
            this.tb_Cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cantidad.DefaultText = "";
            this.tb_Cantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Cantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Cantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Cantidad.DisabledState.Parent = this.tb_Cantidad;
            this.tb_Cantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Cantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Cantidad.FocusedState.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Cantidad.HoverState.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Location = new System.Drawing.Point(309, 120);
            this.tb_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.PasswordChar = '\0';
            this.tb_Cantidad.PlaceholderText = "";
            this.tb_Cantidad.SelectedText = "";
            this.tb_Cantidad.ShadowDecoration.Parent = this.tb_Cantidad;
            this.tb_Cantidad.Size = new System.Drawing.Size(173, 40);
            this.tb_Cantidad.TabIndex = 39;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.BackColor = System.Drawing.Color.White;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Cantidad.Location = new System.Drawing.Point(312, 93);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(79, 23);
            this.lbl_Cantidad.TabIndex = 40;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_CodigoBarra
            // 
            this.lbl_CodigoBarra.AutoSize = true;
            this.lbl_CodigoBarra.BackColor = System.Drawing.Color.White;
            this.lbl_CodigoBarra.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_CodigoBarra.Location = new System.Drawing.Point(21, 92);
            this.lbl_CodigoBarra.Name = "lbl_CodigoBarra";
            this.lbl_CodigoBarra.Size = new System.Drawing.Size(141, 23);
            this.lbl_CodigoBarra.TabIndex = 37;
            this.lbl_CodigoBarra.Text = "Código de barras";
            // 
            // tb_CodigoBarra
            // 
            this.tb_CodigoBarra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_CodigoBarra.BorderRadius = 5;
            this.tb_CodigoBarra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CodigoBarra.DefaultText = "";
            this.tb_CodigoBarra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CodigoBarra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CodigoBarra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodigoBarra.DisabledState.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodigoBarra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodigoBarra.FocusedState.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CodigoBarra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodigoBarra.HoverState.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.Location = new System.Drawing.Point(18, 120);
            this.tb_CodigoBarra.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CodigoBarra.Name = "tb_CodigoBarra";
            this.tb_CodigoBarra.PasswordChar = '\0';
            this.tb_CodigoBarra.PlaceholderText = "";
            this.tb_CodigoBarra.SelectedText = "";
            this.tb_CodigoBarra.ShadowDecoration.Parent = this.tb_CodigoBarra;
            this.tb_CodigoBarra.Size = new System.Drawing.Size(279, 40);
            this.tb_CodigoBarra.TabIndex = 36;
            // 
            // lbl_NuevaEntrada
            // 
            this.lbl_NuevaEntrada.AutoSize = true;
            this.lbl_NuevaEntrada.BackColor = System.Drawing.Color.White;
            this.lbl_NuevaEntrada.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_NuevaEntrada.Location = new System.Drawing.Point(12, 12);
            this.lbl_NuevaEntrada.Name = "lbl_NuevaEntrada";
            this.lbl_NuevaEntrada.Size = new System.Drawing.Size(334, 32);
            this.lbl_NuevaEntrada.TabIndex = 34;
            this.lbl_NuevaEntrada.Text = "Nueva entrada al inventario";
            // 
            // lbl_DescripcionNueva
            // 
            this.lbl_DescripcionNueva.AutoSize = true;
            this.lbl_DescripcionNueva.BackColor = System.Drawing.Color.White;
            this.lbl_DescripcionNueva.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_DescripcionNueva.Location = new System.Drawing.Point(14, 43);
            this.lbl_DescripcionNueva.Name = "lbl_DescripcionNueva";
            this.lbl_DescripcionNueva.Size = new System.Drawing.Size(450, 23);
            this.lbl_DescripcionNueva.TabIndex = 35;
            this.lbl_DescripcionNueva.Text = "Registra la entrega de productos por parte del proveedor.\r\n";
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.CheckedState.Parent = this.btn_CrearProducto;
            this.btn_CrearProducto.CustomImages.Parent = this.btn_CrearProducto;
            this.btn_CrearProducto.FillColor = System.Drawing.Color.White;
            this.btn_CrearProducto.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_CrearProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_CrearProducto.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_CrearProducto.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_CrearProducto.HoverState.Parent = this.btn_CrearProducto;
            this.btn_CrearProducto.Location = new System.Drawing.Point(286, 7);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.PressedColor = System.Drawing.Color.White;
            this.btn_CrearProducto.ShadowDecoration.Parent = this.btn_CrearProducto;
            this.btn_CrearProducto.Size = new System.Drawing.Size(253, 45);
            this.btn_CrearProducto.TabIndex = 4;
            this.btn_CrearProducto.Text = "Crear producto";
            // 
            // btn_NuevaEntrada
            // 
            this.btn_NuevaEntrada.CheckedState.Parent = this.btn_NuevaEntrada;
            this.btn_NuevaEntrada.CustomImages.Parent = this.btn_NuevaEntrada;
            this.btn_NuevaEntrada.FillColor = System.Drawing.Color.White;
            this.btn_NuevaEntrada.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_NuevaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btn_NuevaEntrada.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_NuevaEntrada.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_NuevaEntrada.HoverState.Parent = this.btn_NuevaEntrada;
            this.btn_NuevaEntrada.Location = new System.Drawing.Point(13, 7);
            this.btn_NuevaEntrada.Name = "btn_NuevaEntrada";
            this.btn_NuevaEntrada.PressedColor = System.Drawing.Color.White;
            this.btn_NuevaEntrada.ShadowDecoration.Parent = this.btn_NuevaEntrada;
            this.btn_NuevaEntrada.Size = new System.Drawing.Size(253, 45);
            this.btn_NuevaEntrada.TabIndex = 3;
            this.btn_NuevaEntrada.Text = "Nueva entrada";
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
            this.Separador.Location = new System.Drawing.Point(18, 27);
            this.Separador.Name = "Separador";
            this.Separador.PasswordChar = '\0';
            this.Separador.ReadOnly = true;
            this.Separador.SelectedText = "";
            this.Separador.Size = new System.Drawing.Size(1134, 30);
            this.Separador.TabIndex = 34;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Contenedor.BorderRadius = 10;
            this.pnl_Contenedor.Controls.Add(this.lbl_ConsultarProductos);
            this.pnl_Contenedor.Controls.Add(this.dgv_TablaProductos);
            this.pnl_Contenedor.Controls.Add(this.lbl_DescripcionConsultar);
            this.pnl_Contenedor.Controls.Add(this.lbl_Producto);
            this.pnl_Contenedor.Controls.Add(this.tb_BuscarProducto);
            this.pnl_Contenedor.FillColor = System.Drawing.Color.White;
            this.pnl_Contenedor.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Contenedor.Location = new System.Drawing.Point(3, 2);
            this.pnl_Contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 5);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.ShadowDecoration.Parent = this.pnl_Contenedor;
            this.pnl_Contenedor.Size = new System.Drawing.Size(1165, 427);
            this.pnl_Contenedor.TabIndex = 2;
            // 
            // lbl_ConsultarProductos
            // 
            this.lbl_ConsultarProductos.AutoSize = true;
            this.lbl_ConsultarProductos.BackColor = System.Drawing.Color.White;
            this.lbl_ConsultarProductos.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConsultarProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.lbl_ConsultarProductos.Location = new System.Drawing.Point(20, 33);
            this.lbl_ConsultarProductos.Name = "lbl_ConsultarProductos";
            this.lbl_ConsultarProductos.Size = new System.Drawing.Size(249, 32);
            this.lbl_ConsultarProductos.TabIndex = 28;
            this.lbl_ConsultarProductos.Text = "Consultar productos";
            // 
            // dgv_TablaProductos
            // 
            this.dgv_TablaProductos.AllowUserToAddRows = false;
            this.dgv_TablaProductos.AllowUserToDeleteRows = false;
            this.dgv_TablaProductos.AllowUserToResizeColumns = false;
            this.dgv_TablaProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TablaProductos.ColumnHeadersHeight = 35;
            this.dgv_TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CodigoBarras,
            this.col_Descripcion,
            this.col_PrecioCompra,
            this.col_PrecioVenta,
            this.col_Ganancia,
            this.col_Categoria,
            this.col_CantidadActual,
            this.col_Minimo,
            this.col_Editar,
            this.col_Borrar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TablaProductos.EnableHeadersVisualStyles = false;
            this.dgv_TablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProductos.Location = new System.Drawing.Point(24, 188);
            this.dgv_TablaProductos.Name = "dgv_TablaProductos";
            this.dgv_TablaProductos.RowHeadersVisible = false;
            this.dgv_TablaProductos.RowHeadersWidth = 65;
            this.dgv_TablaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TablaProductos.RowTemplate.Height = 35;
            this.dgv_TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TablaProductos.Size = new System.Drawing.Size(1123, 224);
            this.dgv_TablaProductos.TabIndex = 32;
            this.dgv_TablaProductos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TablaProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TablaProductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TablaProductos.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_TablaProductos.ThemeStyle.ReadOnly = false;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.Height = 35;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            // 
            // col_CodigoBarras
            // 
            this.col_CodigoBarras.HeaderText = "Código de barras";
            this.col_CodigoBarras.MinimumWidth = 6;
            this.col_CodigoBarras.Name = "col_CodigoBarras";
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripción";
            this.col_Descripcion.MinimumWidth = 6;
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
            this.col_Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_PrecioCompra
            // 
            this.col_PrecioCompra.HeaderText = "Precio de compra";
            this.col_PrecioCompra.MinimumWidth = 6;
            this.col_PrecioCompra.Name = "col_PrecioCompra";
            this.col_PrecioCompra.ReadOnly = true;
            this.col_PrecioCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_PrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_PrecioVenta
            // 
            this.col_PrecioVenta.HeaderText = "Precio de venta";
            this.col_PrecioVenta.MinimumWidth = 6;
            this.col_PrecioVenta.Name = "col_PrecioVenta";
            // 
            // col_Ganancia
            // 
            this.col_Ganancia.HeaderText = "Ganancia";
            this.col_Ganancia.MinimumWidth = 6;
            this.col_Ganancia.Name = "col_Ganancia";
            // 
            // col_Categoria
            // 
            this.col_Categoria.HeaderText = "Categoria";
            this.col_Categoria.MinimumWidth = 6;
            this.col_Categoria.Name = "col_Categoria";
            this.col_Categoria.ReadOnly = true;
            this.col_Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_CantidadActual
            // 
            this.col_CantidadActual.HeaderText = "Cantidad";
            this.col_CantidadActual.MinimumWidth = 6;
            this.col_CantidadActual.Name = "col_CantidadActual";
            this.col_CantidadActual.ReadOnly = true;
            this.col_CantidadActual.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_CantidadActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Minimo
            // 
            this.col_Minimo.HeaderText = "Minimo";
            this.col_Minimo.MinimumWidth = 6;
            this.col_Minimo.Name = "col_Minimo";
            // 
            // col_Editar
            // 
            this.col_Editar.HeaderText = "Editar";
            this.col_Editar.Image = ((System.Drawing.Image)(resources.GetObject("col_Editar.Image")));
            this.col_Editar.MinimumWidth = 6;
            this.col_Editar.Name = "col_Editar";
            this.col_Editar.ReadOnly = true;
            this.col_Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col_Borrar
            // 
            this.col_Borrar.HeaderText = "Borrar";
            this.col_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("col_Borrar.Image")));
            this.col_Borrar.MinimumWidth = 6;
            this.col_Borrar.Name = "col_Borrar";
            // 
            // lbl_DescripcionConsultar
            // 
            this.lbl_DescripcionConsultar.AutoSize = true;
            this.lbl_DescripcionConsultar.BackColor = System.Drawing.Color.White;
            this.lbl_DescripcionConsultar.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_DescripcionConsultar.Location = new System.Drawing.Point(20, 64);
            this.lbl_DescripcionConsultar.Name = "lbl_DescripcionConsultar";
            this.lbl_DescripcionConsultar.Size = new System.Drawing.Size(405, 23);
            this.lbl_DescripcionConsultar.TabIndex = 29;
            this.lbl_DescripcionConsultar.Text = "Consulta la lista de todos los productos de la tienda\r\n";
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.White;
            this.lbl_Producto.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Producto.Location = new System.Drawing.Point(20, 104);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(135, 23);
            this.lbl_Producto.TabIndex = 31;
            this.lbl_Producto.Text = "Buscar producto";
            // 
            // tb_BuscarProducto
            // 
            this.tb_BuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.tb_BuscarProducto.BorderRadius = 5;
            this.tb_BuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_BuscarProducto.DefaultText = "";
            this.tb_BuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_BuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_BuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarProducto.DisabledState.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_BuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarProducto.FocusedState.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_BuscarProducto.HoverState.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_BuscarProducto.IconLeft")));
            this.tb_BuscarProducto.Location = new System.Drawing.Point(26, 132);
            this.tb_BuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tb_BuscarProducto.Name = "tb_BuscarProducto";
            this.tb_BuscarProducto.PasswordChar = '\0';
            this.tb_BuscarProducto.PlaceholderText = "";
            this.tb_BuscarProducto.SelectedText = "";
            this.tb_BuscarProducto.ShadowDecoration.Parent = this.tb_BuscarProducto;
            this.tb_BuscarProducto.Size = new System.Drawing.Size(501, 40);
            this.tb_BuscarProducto.TabIndex = 30;
            // 
            // tlp_Display
            // 
            this.tlp_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Display.ColumnCount = 1;
            this.tlp_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.Controls.Add(this.pnl_Contenedor, 0, 0);
            this.tlp_Display.Controls.Add(this.pnl_MenuProductos, 0, 1);
            this.tlp_Display.Location = new System.Drawing.Point(12, 15);
            this.tlp_Display.Name = "tlp_Display";
            this.tlp_Display.RowCount = 2;
            this.tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tlp_Display.Size = new System.Drawing.Size(1171, 812);
            this.tlp_Display.TabIndex = 3;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1195, 839);
            this.Controls.Add(this.tlp_Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.pnl_MenuProductos.ResumeLayout(false);
            this.pnl_CrearProducto.ResumeLayout(false);
            this.pnl_CrearProducto.PerformLayout();
            this.pnl_NuevaEntrada.ResumeLayout(false);
            this.pnl_NuevaEntrada.PerformLayout();
            this.pnl_Contenedor.ResumeLayout(false);
            this.pnl_Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProductos)).EndInit();
            this.tlp_Display.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel pnl_MenuProductos;
        public Guna.UI2.WinForms.Guna2Panel pnl_Contenedor;
        public Guna.UI2.WinForms.Guna2Button btn_CrearProducto;
        public Guna.UI2.WinForms.Guna2Button btn_ModificarProducto;
        public Guna.UI2.WinForms.Guna2Button btn_NuevaEntrada;
        public System.Windows.Forms.Label lbl_ConsultarProductos;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_TablaProductos;
        public System.Windows.Forms.Label lbl_DescripcionConsultar;
        public System.Windows.Forms.Label lbl_Producto;
        public Guna.UI2.WinForms.Guna2TextBox tb_BuscarProducto;
        private Guna.UI.WinForms.GunaLineTextBox Separador;
        public Guna.UI2.WinForms.Guna2Button btn_LimpiarEntrada;
        public Guna.UI2.WinForms.Guna2Button btn_RegistrarProducto;
        public Guna.UI2.WinForms.Guna2ComboBox cb_Proveedor;
        private System.Windows.Forms.Label lbl_Proveedor;
        public Guna.UI2.WinForms.Guna2TextBox tb_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_CodigoBarra;
        public Guna.UI2.WinForms.Guna2TextBox tb_CodigoBarra;
        private System.Windows.Forms.Label lbl_NuevaEntrada;
        private System.Windows.Forms.Label lbl_DescripcionNueva;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_CodigoBarras;
        public Guna.UI2.WinForms.Guna2TextBox tb_CodigoBarras;
        public Guna.UI2.WinForms.Guna2TextBox tb_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        public Guna.UI2.WinForms.Guna2ComboBox cb_Categoria;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_CantidadMinima;
        public Guna.UI2.WinForms.Guna2TextBox tb_Minima;
        public Guna.UI2.WinForms.Guna2TextBox tb_Porcentaje;
        private System.Windows.Forms.Label lbl_Ganancia;
        private System.Windows.Forms.Label lbl_PrecioVenta;
        public Guna.UI2.WinForms.Guna2Button btn_AgregarProducto;
        public Guna.UI2.WinForms.Guna2TextBox tb_PrecioVenta;
        public Guna.UI2.WinForms.Guna2TextBox tb_PrecioCompra;
        private System.Windows.Forms.Label lbl_PrecioCompra;
        public System.Windows.Forms.Panel pnl_NuevaEntrada;
        public System.Windows.Forms.Panel pnl_CrearProducto;
        public System.Windows.Forms.Label lbl_ErrorCategoria;
        public System.Windows.Forms.Label lbl_ErrorPrecioVenta;
        public System.Windows.Forms.Label lbl_ErrorPrecioCompra;
        public System.Windows.Forms.Label lbl_ErrorMinimo;
        public System.Windows.Forms.Label lbl_ErrorGanancia;
        public System.Windows.Forms.Label lbl_ErrorDescripcion;
        public System.Windows.Forms.Label lbl_ErrrCodigo;
        public System.Windows.Forms.Label lbl_ErrorProveedor;
        public System.Windows.Forms.Label lbl_ErrorCantidad;
        public System.Windows.Forms.Label lbl_ErrorCodigoBarras;
        private System.Windows.Forms.TableLayoutPanel tlp_Display;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CantidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Minimo;
        private System.Windows.Forms.DataGridViewImageColumn col_Editar;
        private System.Windows.Forms.DataGridViewImageColumn col_Borrar;
    }
}