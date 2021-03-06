
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
            this.pan_Superior = new System.Windows.Forms.Panel();
            this.sha_Sombra = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btn_Si = new Guna.UI2.WinForms.Guna2Button();
            this.btn_No = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Icono
            // 
            this.pb_Icono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pb_Icono.Image = ((System.Drawing.Image)(resources.GetObject("pb_Icono.Image")));
            this.pb_Icono.Location = new System.Drawing.Point(87, 22);
            this.pb_Icono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Icono.Name = "pb_Icono";
            this.pb_Icono.Size = new System.Drawing.Size(76, 73);
            this.pb_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Icono.TabIndex = 0;
            this.pb_Icono.TabStop = false;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoEllipsis = true;
            this.lbl_Mensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.lbl_Mensaje.Location = new System.Drawing.Point(20, 139);
            this.lbl_Mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(211, 49);
            this.lbl_Mensaje.TabIndex = 6;
            this.lbl_Mensaje.Text = "Mensaje";
            this.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Confirmacion
            // 
            this.lbl_Confirmacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Confirmacion.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirmacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lbl_Confirmacion.Location = new System.Drawing.Point(9, 188);
            this.lbl_Confirmacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Confirmacion.Name = "lbl_Confirmacion";
            this.lbl_Confirmacion.Size = new System.Drawing.Size(230, 54);
            this.lbl_Confirmacion.TabIndex = 7;
            this.lbl_Confirmacion.Text = "¿Está seguro que quiere realizar esta acción?";
            this.lbl_Confirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Superior
            // 
            this.pan_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pan_Superior.Location = new System.Drawing.Point(0, 0);
            this.pan_Superior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pan_Superior.Name = "pan_Superior";
            this.pan_Superior.Size = new System.Drawing.Size(251, 130);
            this.pan_Superior.TabIndex = 10;
            // 
            // btn_Si
            // 
            this.btn_Si.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Si.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Si.BorderRadius = 5;
            this.btn_Si.BorderThickness = 1;
            this.btn_Si.CheckedState.Parent = this.btn_Si;
            this.btn_Si.CustomImages.Parent = this.btn_Si;
            this.btn_Si.FillColor = System.Drawing.Color.White;
            this.btn_Si.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Si.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Si.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Si.HoverState.Parent = this.btn_Si;
            this.btn_Si.Location = new System.Drawing.Point(23, 266);
            this.btn_Si.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_Si.ShadowDecoration.Parent = this.btn_Si;
            this.btn_Si.Size = new System.Drawing.Size(94, 32);
            this.btn_Si.TabIndex = 31;
            this.btn_Si.Text = "Sí";
            this.btn_Si.Click += new System.EventHandler(this.btn_Si_Click_1);
            // 
            // btn_No
            // 
            this.btn_No.BorderRadius = 5;
            this.btn_No.CheckedState.Parent = this.btn_No;
            this.btn_No.CustomImages.Parent = this.btn_No;
            this.btn_No.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btn_No.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ForeColor = System.Drawing.Color.White;
            this.btn_No.HoverState.Parent = this.btn_No;
            this.btn_No.Location = new System.Drawing.Point(136, 266);
            this.btn_No.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_No.Name = "btn_No";
            this.btn_No.ShadowDecoration.Parent = this.btn_No;
            this.btn_No.Size = new System.Drawing.Size(94, 32);
            this.btn_No.TabIndex = 30;
            this.btn_No.Text = "No";
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click_1);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pan_Superior;
            // 
            // FrmAdvertencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(251, 327);
            this.Controls.Add(this.btn_Si);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.lbl_Confirmacion);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.pb_Icono);
            this.Controls.Add(this.pan_Superior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAdvertencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdvertencia";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Icono;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Label lbl_Confirmacion;
        private System.Windows.Forms.Panel pan_Superior;
        private Guna.UI2.WinForms.Guna2ShadowForm sha_Sombra;
        private Guna.UI2.WinForms.Guna2Button btn_Si;
        private Guna.UI2.WinForms.Guna2Button btn_No;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}