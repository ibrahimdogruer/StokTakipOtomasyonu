namespace DemirbasOtomasyon.View
{
    partial class FormBYGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBYGiris));
            this.pnlGiris1 = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.lblGiris = new System.Windows.Forms.Label();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlGiris1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGiris1
            // 
            this.pnlGiris1.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlGiris1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiris1.Controls.Add(this.txtSifre);
            this.pnlGiris1.Controls.Add(this.txtKullaniciAdi);
            this.pnlGiris1.Controls.Add(this.btnGiris);
            this.pnlGiris1.Controls.Add(this.btnVazgec);
            this.pnlGiris1.Controls.Add(this.lblGiris);
            this.pnlGiris1.Controls.Add(this.pbLock);
            this.pnlGiris1.Controls.Add(this.pbUser);
            this.pnlGiris1.ForeColor = System.Drawing.Color.White;
            this.pnlGiris1.Location = new System.Drawing.Point(0, -1);
            this.pnlGiris1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGiris1.Name = "pnlGiris1";
            this.pnlGiris1.Size = new System.Drawing.Size(369, 292);
            this.pnlGiris1.TabIndex = 20;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(83, 148);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(241, 30);
            this.txtSifre.TabIndex = 18;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(83, 93);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.MaxLength = 10;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(241, 30);
            this.txtKullaniciAdi.TabIndex = 17;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGiris.Appearance.BackColor2 = System.Drawing.Color.OliveDrab;
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.AppearanceHovered.BackColor = System.Drawing.Color.Olive;
            this.btnGiris.AppearanceHovered.Options.UseBackColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGiris.Location = new System.Drawing.Point(125, 201);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(124, 40);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
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
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.White;
            this.lblGiris.Location = new System.Drawing.Point(77, 18);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(237, 33);
            this.lblGiris.TabIndex = 4;
            this.lblGiris.Text = "Birim Yetkilisi Girişi";
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
            // FormBYGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 291);
            this.Controls.Add(this.pnlGiris1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormBYGiris";
            this.Load += new System.EventHandler(this.FormBYGiris_Load);
            this.pnlGiris1.ResumeLayout(false);
            this.pnlGiris1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGiris1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.PictureBox pbUser;
    }
}