namespace DemirbasOtomasyon.View
{
    partial class FormAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminGiris));
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.lblGiris = new System.Windows.Forms.Label();
            this.pnlGiris1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlGiris1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGiris.Appearance.BackColor2 = System.Drawing.Color.OliveDrab;
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.Appearance.Options.UseBackColor = true;
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Appearance.Options.UseForeColor = true;
            this.BtnGiris.AppearanceHovered.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnGiris.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnGiris.AppearanceHovered.Options.UseBackColor = true;
            this.BtnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnGiris.Location = new System.Drawing.Point(125, 201);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(124, 40);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click_1);
            // 
            // pbLock
            // 
            this.pbLock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLock.Image = ((System.Drawing.Image)(resources.GetObject("pbLock.Image")));
            this.pbLock.Location = new System.Drawing.Point(31, 137);
            this.pbLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(46, 41);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLock.TabIndex = 16;
            this.pbLock.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.OliveDrab;
            this.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(31, 82);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(46, 41);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 15;
            this.pbUser.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(84, 148);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(241, 30);
            this.txtSifre.TabIndex = 19;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(84, 93);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.MaxLength = 10;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(241, 30);
            this.txtKullaniciAdi.TabIndex = 18;
            this.txtKullaniciAdi.Text = "Admin";
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.btnVazgec.Appearance.BackColor2 = System.Drawing.Color.OliveDrab;
            this.btnVazgec.Appearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnVazgec.Appearance.Options.UseBackColor = true;
            this.btnVazgec.Appearance.Options.UseBorderColor = true;
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.Appearance.Options.UseForeColor = true;
            this.btnVazgec.AppearanceHovered.BackColor = System.Drawing.Color.Olive;
            this.btnVazgec.AppearanceHovered.Options.UseBackColor = true;
            this.btnVazgec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnVazgec.Location = new System.Drawing.Point(333, 2);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(31, 35);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "X";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click_1);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.White;
            this.lblGiris.Location = new System.Drawing.Point(97, 15);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(190, 37);
            this.lblGiris.TabIndex = 4;
            this.lblGiris.Text = "Yönetici Girişi";
            // 
            // pnlGiris1
            // 
            this.pnlGiris1.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlGiris1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiris1.Controls.Add(this.BtnGiris);
            this.pnlGiris1.Controls.Add(this.btnVazgec);
            this.pnlGiris1.Controls.Add(this.lblGiris);
            this.pnlGiris1.Controls.Add(this.pbLock);
            this.pnlGiris1.Controls.Add(this.pbUser);
            this.pnlGiris1.ForeColor = System.Drawing.Color.White;
            this.pnlGiris1.Location = new System.Drawing.Point(0, 0);
            this.pnlGiris1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGiris1.Name = "pnlGiris1";
            this.pnlGiris1.Size = new System.Drawing.Size(369, 291);
            this.pnlGiris1.TabIndex = 20;
            // 
            // FormAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 291);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pnlGiris1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAdminGiris";
            this.Load += new System.EventHandler(this.FormAdminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlGiris1.ResumeLayout(false);
            this.pnlGiris1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.PictureBox pbUser;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Panel pnlGiris1;
        public DevExpress.XtraEditors.SimpleButton BtnGiris;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
    }
}