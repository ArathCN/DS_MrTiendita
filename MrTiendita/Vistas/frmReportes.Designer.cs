
namespace MrTiendita.Vistas
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.btn_entradasAlmacen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.dp_hasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dp_desde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_entradasAlmacen
            // 
            this.btn_entradasAlmacen.Activecolor = System.Drawing.Color.Transparent;
            this.btn_entradasAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.btn_entradasAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entradasAlmacen.BorderRadius = 0;
            this.btn_entradasAlmacen.ButtonText = "Entradas a almacén";
            this.btn_entradasAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entradasAlmacen.DisabledColor = System.Drawing.Color.Gray;
            this.btn_entradasAlmacen.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_entradasAlmacen.Iconimage = null;
            this.btn_entradasAlmacen.Iconimage_right = null;
            this.btn_entradasAlmacen.Iconimage_right_Selected = null;
            this.btn_entradasAlmacen.Iconimage_Selected = null;
            this.btn_entradasAlmacen.IconMarginLeft = 0;
            this.btn_entradasAlmacen.IconMarginRight = 0;
            this.btn_entradasAlmacen.IconRightVisible = true;
            this.btn_entradasAlmacen.IconRightZoom = 0D;
            this.btn_entradasAlmacen.IconVisible = true;
            this.btn_entradasAlmacen.IconZoom = 90D;
            this.btn_entradasAlmacen.IsTab = false;
            this.btn_entradasAlmacen.Location = new System.Drawing.Point(-30, 67);
            this.btn_entradasAlmacen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_entradasAlmacen.Name = "btn_entradasAlmacen";
            this.btn_entradasAlmacen.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_entradasAlmacen.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_entradasAlmacen.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.btn_entradasAlmacen.selected = false;
            this.btn_entradasAlmacen.Size = new System.Drawing.Size(302, 40);
            this.btn_entradasAlmacen.TabIndex = 24;
            this.btn_entradasAlmacen.Text = "Entradas a almacén";
            this.btn_entradasAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_entradasAlmacen.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(140)))));
            this.btn_entradasAlmacen.TextFont = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entradasAlmacen.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Activecolor = System.Drawing.Color.Transparent;
            this.btn_ventas.BackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ventas.BorderRadius = 0;
            this.btn_ventas.ButtonText = "Ventas";
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ventas.Iconimage = null;
            this.btn_ventas.Iconimage_right = null;
            this.btn_ventas.Iconimage_right_Selected = null;
            this.btn_ventas.Iconimage_Selected = null;
            this.btn_ventas.IconMarginLeft = 0;
            this.btn_ventas.IconMarginRight = 0;
            this.btn_ventas.IconRightVisible = true;
            this.btn_ventas.IconRightZoom = 0D;
            this.btn_ventas.IconVisible = true;
            this.btn_ventas.IconZoom = 90D;
            this.btn_ventas.IsTab = false;
            this.btn_ventas.Location = new System.Drawing.Point(241, 67);
            this.btn_ventas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_ventas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_ventas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.btn_ventas.selected = false;
            this.btn_ventas.Size = new System.Drawing.Size(149, 40);
            this.btn_ventas.TabIndex = 25;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ventas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(140)))));
            this.btn_ventas.TextFont = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(27, 215);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1111, 634);
            this.Contenedor.TabIndex = 26;
            // 
            // dp_hasta
            // 
            this.dp_hasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dp_hasta.BorderRadius = 7;
            this.dp_hasta.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_hasta.ForeColor = System.Drawing.Color.White;
            this.dp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dp_hasta.FormatCustom = null;
            this.dp_hasta.Location = new System.Drawing.Point(548, 144);
            this.dp_hasta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dp_hasta.Name = "dp_hasta";
            this.dp_hasta.Size = new System.Drawing.Size(469, 38);
            this.dp_hasta.TabIndex = 28;
            this.dp_hasta.Value = new System.DateTime(2021, 10, 13, 15, 37, 5, 510);
            // 
            // dp_desde
            // 
            this.dp_desde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dp_desde.BorderRadius = 7;
            this.dp_desde.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_desde.ForeColor = System.Drawing.Color.White;
            this.dp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dp_desde.FormatCustom = null;
            this.dp_desde.Location = new System.Drawing.Point(32, 144);
            this.dp_desde.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dp_desde.Name = "dp_desde";
            this.dp_desde.Size = new System.Drawing.Size(469, 38);
            this.dp_desde.TabIndex = 29;
            this.dp_desde.Value = new System.DateTime(2021, 10, 13, 15, 37, 5, 510);
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_desde.Location = new System.Drawing.Point(35, 119);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(61, 20);
            this.lbl_desde.TabIndex = 30;
            this.lbl_desde.Text = "Desde:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl_hasta.Location = new System.Drawing.Point(551, 119);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(58, 20);
            this.lbl_hasta.TabIndex = 31;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(70, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(112, 29);
            this.lbl_Titulo.TabIndex = 35;
            this.lbl_Titulo.Text = "Reportes";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1168, 886);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.dp_hasta);
            this.Controls.Add(this.dp_desde);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_entradasAlmacen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_entradasAlmacen;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ventas;
        private System.Windows.Forms.Panel Contenedor;
        private Bunifu.Framework.UI.BunifuDatepicker dp_hasta;
        private Bunifu.Framework.UI.BunifuDatepicker dp_desde;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}