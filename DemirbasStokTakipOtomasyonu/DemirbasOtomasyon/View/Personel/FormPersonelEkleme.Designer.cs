namespace DemirbasOtomasyon.View
{
    partial class FormPersonelEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelEkleme));
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.calendarControl2 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbZimmetIslemleri = new System.Windows.Forms.GroupBox();
            this.cmbDepartmanSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCepTelefonu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl2.CalendarTimeProperties)).BeginInit();
            this.grbZimmetIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(223, 22);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(349, 29);
            this.pnlUrunGrs.TabIndex = 19;
            this.pnlUrunGrs.Text = "PERSONEL EKLEME İŞLEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Personel Adı:";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAd.Location = new System.Drawing.Point(128, 30);
            this.txtPersonelAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelAd.MaxLength = 15;
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(172, 24);
            this.txtPersonelAd.TabIndex = 16;
            this.txtPersonelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAd_KeyPress);
            // 
            // calendarControl2
            // 
            this.calendarControl2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl2.Location = new System.Drawing.Point(128, 133);
            this.calendarControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarControl2.Name = "calendarControl2";
            this.calendarControl2.Size = new System.Drawing.Size(229, 227);
            this.calendarControl2.TabIndex = 15;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPersonelEkle.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.btnPersonelEkle.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonelEkle.Appearance.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPersonelEkle.Appearance.Options.UseBackColor = true;
            this.btnPersonelEkle.Appearance.Options.UseBorderColor = true;
            this.btnPersonelEkle.Appearance.Options.UseFont = true;
            this.btnPersonelEkle.Appearance.Options.UseForeColor = true;
            this.btnPersonelEkle.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPersonelEkle.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.btnPersonelEkle.AppearanceHovered.Options.UseBackColor = true;
            this.btnPersonelEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPersonelEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelEkle.ImageOptions.Image")));
            this.btnPersonelEkle.Location = new System.Drawing.Point(411, 193);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(136, 81);
            this.btnPersonelEkle.TabIndex = 12;
            this.btnPersonelEkle.Text = "EKLE";
            this.btnPersonelEkle.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "İşe Giriş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cep Telefonu:";
            // 
            // grbZimmetIslemleri
            // 
            this.grbZimmetIslemleri.Controls.Add(this.cmbDepartmanSec);
            this.grbZimmetIslemleri.Controls.Add(this.label1);
            this.grbZimmetIslemleri.Controls.Add(this.txtCepTelefonu);
            this.grbZimmetIslemleri.Controls.Add(this.label5);
            this.grbZimmetIslemleri.Controls.Add(this.label2);
            this.grbZimmetIslemleri.Controls.Add(this.txtPersonelSoyadi);
            this.grbZimmetIslemleri.Controls.Add(this.txtPersonelAd);
            this.grbZimmetIslemleri.Controls.Add(this.calendarControl2);
            this.grbZimmetIslemleri.Controls.Add(this.btnPersonelEkle);
            this.grbZimmetIslemleri.Controls.Add(this.label6);
            this.grbZimmetIslemleri.Controls.Add(this.label7);
            this.grbZimmetIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbZimmetIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbZimmetIslemleri.Location = new System.Drawing.Point(80, 84);
            this.grbZimmetIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmetIslemleri.Name = "grbZimmetIslemleri";
            this.grbZimmetIslemleri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmetIslemleri.Size = new System.Drawing.Size(628, 385);
            this.grbZimmetIslemleri.TabIndex = 20;
            this.grbZimmetIslemleri.TabStop = false;
            this.grbZimmetIslemleri.Text = "Personel Bilgileri";
            // 
            // cmbDepartmanSec
            // 
            this.cmbDepartmanSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanSec.FormattingEnabled = true;
            this.cmbDepartmanSec.Location = new System.Drawing.Point(435, 75);
            this.cmbDepartmanSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartmanSec.Name = "cmbDepartmanSec";
            this.cmbDepartmanSec.Size = new System.Drawing.Size(172, 25);
            this.cmbDepartmanSec.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(342, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Departman:";
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCepTelefonu.Location = new System.Drawing.Point(128, 76);
            this.txtCepTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCepTelefonu.MaxLength = 11;
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(172, 24);
            this.txtCepTelefonu.TabIndex = 25;
            this.txtCepTelefonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCepTelefonu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(315, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Personel Soyadı:";
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(435, 28);
            this.txtPersonelSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelSoyadi.MaxLength = 15;
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(172, 24);
            this.txtPersonelSoyadi.TabIndex = 16;
            this.txtPersonelSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyad_KeyPress);
            // 
            // FormPersonelEkleme
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 508);
            this.Controls.Add(this.pnlUrunGrs);
            this.Controls.Add(this.grbZimmetIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPersonelEkleme";
            this.Load += new System.EventHandler(this.FormPersonelEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl2.CalendarTimeProperties)).EndInit();
            this.grbZimmetIslemleri.ResumeLayout(false);
            this.grbZimmetIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbZimmetIslemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPersonelAd;
        public DevExpress.XtraEditors.Controls.CalendarControl calendarControl2;
        public DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        public System.Windows.Forms.ComboBox cmbDepartmanSec;
        public System.Windows.Forms.TextBox txtCepTelefonu;
        public System.Windows.Forms.TextBox txtPersonelSoyadi;
    }
}