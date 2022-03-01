
namespace MrTiendita.Vistas
{
    partial class FrmAdvertencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdvertencia));
            this.pb_Icono = new System.Windows.Forms.PictureBox();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.lbl_Confirmacion = new System.Windows.Forms.Label();
            this.btn_Si = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_No = new Bunifu.Framework.UI.BunifuFlatButton();
            this.eli_Borde = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pan_Superior = new System.Windows.Forms.Panel();
            this.sha_Sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Icono
            // 
            this.pb_Icono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.pb_Icono.Image = ((System.Drawing.Image)(resources.GetObject("pb_Icono.Image")));
            this.pb_Icono.Location = new System.Drawing.Point(119, 27);
            this.pb_Icono.Name = "pb_Icono";
            this.pb_Icono.Size = new System.Drawing.Size(102, 90);
            this.pb_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Icono.TabIndex = 0;
            this.pb_Icono.TabStop = false;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoEllipsis = true;
            this.lbl_Mensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensaje.Location = new System.Drawing.Point(27, 171);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(281, 60);
            this.lbl_Mensaje.TabIndex = 6;
            this.lbl_Mensaje.Text = "Mensaje";
            this.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Confirmacion
            // 
            this.lbl_Confirmacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Confirmacion.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirmacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lbl_Confirmacion.Location = new System.Drawing.Point(12, 231);
            this.lbl_Confirmacion.Name = "lbl_Confirmacion";
            this.lbl_Confirmacion.Size = new System.Drawing.Size(306, 67);
            this.lbl_Confirmacion.TabIndex = 7;
            this.lbl_Confirmacion.Text = "¿Está seguro que quiere realizar esta acción?";
            this.lbl_Confirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Si
            // 
            this.btn_Si.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(192)))), ((int)(((byte)(39)))));
            this.btn_Si.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_Si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Si.BorderRadius = 4;
            this.btn_Si.ButtonText = "Sí";
            this.btn_Si.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Si.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Si.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Si.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Si.Iconimage = null;
            this.btn_Si.Iconimage_right = null;
            this.btn_Si.Iconimage_right_Selected = null;
            this.btn_Si.Iconimage_Selected = null;
            this.btn_Si.IconMarginLeft = 0;
            this.btn_Si.IconMarginRight = 0;
            this.btn_Si.IconRightVisible = true;
            this.btn_Si.IconRightZoom = 0D;
            this.btn_Si.IconVisible = true;
            this.btn_Si.IconZoom = 90D;
            this.btn_Si.IsTab = false;
            this.btn_Si.Location = new System.Drawing.Point(60, 318);
            this.btn_Si.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_Si.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(192)))), ((int)(((byte)(39)))));
            this.btn_Si.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Si.selected = false;
            this.btn_Si.Size = new System.Drawing.Size(100, 33);
            this.btn_Si.TabIndex = 8;
            this.btn_Si.Text = "Sí";
            this.btn_Si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Si.Textcolor = System.Drawing.Color.White;
            this.btn_Si.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Si.Click += new System.EventHandler(this.Btn_Si_Click);
            // 
            // btn_No
            // 
            this.btn_No.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.btn_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_No.BorderRadius = 4;
            this.btn_No.ButtonText = "No";
            this.btn_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_No.DisabledColor = System.Drawing.Color.Gray;
            this.btn_No.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_No.Iconimage = null;
            this.btn_No.Iconimage_right = null;
            this.btn_No.Iconimage_right_Selected = null;
            this.btn_No.Iconimage_Selected = null;
            this.btn_No.IconMarginLeft = 0;
            this.btn_No.IconMarginRight = 0;
            this.btn_No.IconRightVisible = true;
            this.btn_No.IconRightZoom = 0D;
            this.btn_No.IconVisible = true;
            this.btn_No.IconZoom = 90D;
            this.btn_No.IsTab = false;
            this.btn_No.Location = new System.Drawing.Point(181, 318);
            this.btn_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_No.Name = "btn_No";
            this.btn_No.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_No.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.btn_No.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_No.selected = false;
            this.btn_No.Size = new System.Drawing.Size(100, 33);
            this.btn_No.TabIndex = 9;
            this.btn_No.Text = "No";
            this.btn_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_No.Textcolor = System.Drawing.Color.White;
            this.btn_No.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.Click += new System.EventHandler(this.Btn_No_Click);
            // 
            // eli_Borde
            // 
            this.eli_Borde.BorderRadius = 10;
            this.eli_Borde.TargetControl = this;
            // 
            // pan_Superior
            // 
            this.pan_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.pan_Superior.Location = new System.Drawing.Point(0, 0);
            this.pan_Superior.Name = "pan_Superior";
            this.pan_Superior.Size = new System.Drawing.Size(335, 160);
            this.pan_Superior.TabIndex = 10;
            // 
            // frmAdvertencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 403);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Si);
            this.Controls.Add(this.lbl_Confirmacion);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.pb_Icono);
            this.Controls.Add(this.pan_Superior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdvertencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdvertencia";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Icono;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Label lbl_Confirmacion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Si;
        private Bunifu.Framework.UI.BunifuFlatButton btn_No;
        private Guna.UI2.WinForms.Guna2Elipse eli_Borde;
        private System.Windows.Forms.Panel pan_Superior;
        private Guna.UI2.WinForms.Guna2ShadowForm sha_Sombra;
    }
}