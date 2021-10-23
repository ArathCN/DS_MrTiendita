
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_entradasAlmacen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dp_desde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 3);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(27, 27);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(119, 29);
            this.lbl_Titulo.TabIndex = 5;
            this.lbl_Titulo.Text = "Reportes";
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
            this.btn_entradasAlmacen.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(191)))));
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
            this.btn_ventas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(191)))));
            this.btn_ventas.TextFont = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(32, 215);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1111, 634);
            this.Contenedor.TabIndex = 26;
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.bunifuDatepicker2.BorderRadius = 7;
            this.bunifuDatepicker2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(548, 144);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(469, 38);
            this.bunifuDatepicker2.TabIndex = 28;
            this.bunifuDatepicker2.Value = new System.DateTime(2021, 10, 13, 15, 37, 5, 510);
            // 
            // dp_desde
            // 
            this.dp_desde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hasta:";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1168, 886);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuDatepicker2);
            this.Controls.Add(this.dp_desde);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_entradasAlmacen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_entradasAlmacen;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ventas;
        private System.Windows.Forms.Panel Contenedor;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private Bunifu.Framework.UI.BunifuDatepicker dp_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}