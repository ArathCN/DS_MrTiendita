﻿
namespace MrTiendita.Vistas
{
    partial class FrmExito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExito));
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borde = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoEllipsis = true;
            this.lbl_Mensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensaje.Location = new System.Drawing.Point(27, 171);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(278, 71);
            this.lbl_Mensaje.TabIndex = 1;
            this.lbl_Mensaje.Text = "Mensaje";
            this.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "La tarea se ha completado exitosamente.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(192)))), ((int)(((byte)(39)))));
            this.btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.BorderRadius = 4;
            this.btn_Aceptar.ButtonText = "Aceptar";
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Aceptar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.Iconimage = null;
            this.btn_Aceptar.Iconimage_right = null;
            this.btn_Aceptar.Iconimage_right_Selected = null;
            this.btn_Aceptar.Iconimage_Selected = null;
            this.btn_Aceptar.IconMarginLeft = 0;
            this.btn_Aceptar.IconMarginRight = 0;
            this.btn_Aceptar.IconRightVisible = true;
            this.btn_Aceptar.IconRightZoom = 0D;
            this.btn_Aceptar.IconVisible = true;
            this.btn_Aceptar.IconZoom = 90D;
            this.btn_Aceptar.IsTab = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(101, 318);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.btn_Aceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(192)))), ((int)(((byte)(39)))));
            this.btn_Aceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Aceptar.selected = false;
            this.btn_Aceptar.Size = new System.Drawing.Size(130, 33);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Aceptar.Textcolor = System.Drawing.Color.White;
            this.btn_Aceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 160);
            this.panel1.TabIndex = 11;
            // 
            // borde
            // 
            this.borde.BorderRadius = 10;
            this.borde.TargetControl = this;
            // 
            // frmExito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExito";
            this.Load += new System.EventHandler(this.frmExito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Mensaje;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse borde;
        private Guna.UI2.WinForms.Guna2ShadowForm sombra;
    }
}