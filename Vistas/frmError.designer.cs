
namespace VistasMrTiendita
{
    partial class frmError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.btn_No = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoEllipsis = true;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensaje.Location = new System.Drawing.Point(26, 160);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(281, 60);
            this.lbl_Mensaje.TabIndex = 5;
            this.lbl_Mensaje.Text = "Mensaje";
            this.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_No
            // 
            this.btn_No.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.btn_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_No.BorderRadius = 4;
            this.btn_No.ButtonText = "Aceptar";
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
            this.btn_No.Location = new System.Drawing.Point(101, 318);
            this.btn_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_No.Name = "btn_No";
            this.btn_No.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_No.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.btn_No.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_No.selected = false;
            this.btn_No.Size = new System.Drawing.Size(130, 33);
            this.btn_No.TabIndex = 8;
            this.btn_No.Text = "Aceptar";
            this.btn_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_No.Textcolor = System.Drawing.Color.White;
            this.btn_No.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.lbl_Mensaje);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmError";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbl_Mensaje;
        private Bunifu.Framework.UI.BunifuFlatButton btn_No;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}