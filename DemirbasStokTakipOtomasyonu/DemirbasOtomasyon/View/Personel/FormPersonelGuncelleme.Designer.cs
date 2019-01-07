namespace DemirbasOtomasyon.View
{
    partial class FormPersonelGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelGuncelleme));
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.btnPersonelGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelSil = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDepartmanGuncelle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.calendarControl = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbZimmetIslemleri = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.dgwPersonelListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).BeginInit();
            this.grbZimmetIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(275, 19);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(410, 29);
            this.pnlUrunGrs.TabIndex = 21;
            this.pnlUrunGrs.Text = "PERSONEL GÜNCELLEME İŞLEMLERİ";
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPersonelGuncelle.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.btnPersonelGuncelle.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelGuncelle.Appearance.Options.UseBackColor = true;
            this.btnPersonelGuncelle.Appearance.Options.UseBorderColor = true;
            this.btnPersonelGuncelle.Appearance.Options.UseFont = true;
            this.btnPersonelGuncelle.Appearance.Options.UseForeColor = true;
            this.btnPersonelGuncelle.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPersonelGuncelle.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.btnPersonelGuncelle.AppearanceHovered.Options.UseBackColor = true;
            this.btnPersonelGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPersonelGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGuncelle.ImageOptions.Image")));
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(238, 430);
            this.btnPersonelGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(120, 42);
            this.btnPersonelGuncelle.TabIndex = 29;
            this.btnPersonelGuncelle.Text = "GÜNCELLE";
            this.btnPersonelGuncelle.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPersonelSil.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.btnPersonelSil.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonelSil.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelSil.Appearance.Options.UseBackColor = true;
            this.btnPersonelSil.Appearance.Options.UseBorderColor = true;
            this.btnPersonelSil.Appearance.Options.UseFont = true;
            this.btnPersonelSil.Appearance.Options.UseForeColor = true;
            this.btnPersonelSil.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPersonelSil.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.btnPersonelSil.AppearanceHovered.Options.UseBackColor = true;
            this.btnPersonelSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPersonelSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelSil.ImageOptions.Image")));
            this.btnPersonelSil.Location = new System.Drawing.Point(19, 430);
            this.btnPersonelSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(120, 42);
            this.btnPersonelSil.TabIndex = 28;
            this.btnPersonelSil.Text = "SİL";
            this.btnPersonelSil.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click_1);
            // 
            // cmbDepartmanGuncelle
            // 
            this.cmbDepartmanGuncelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanGuncelle.FormattingEnabled = true;
            this.cmbDepartmanGuncelle.Location = new System.Drawing.Point(128, 139);
            this.cmbDepartmanGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartmanGuncelle.Name = "cmbDepartmanGuncelle";
            this.cmbDepartmanGuncelle.Size = new System.Drawing.Size(172, 25);
            this.cmbDepartmanGuncelle.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Departman:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Personel Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Personel Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(128, 34);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdi.MaxLength = 15;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(172, 24);
            this.txtAdi.TabIndex = 16;
            this.txtAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdi_KeyPress);
            // 
            // calendarControl
            // 
            this.calendarControl.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl.Location = new System.Drawing.Point(128, 179);
            this.calendarControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarControl.Name = "calendarControl";
            this.calendarControl.Size = new System.Drawing.Size(230, 227);
            this.calendarControl.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "İşe Giriş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cep Telefonu:";
            // 
            // grbZimmetIslemleri
            // 
            this.grbZimmetIslemleri.Controls.Add(this.btnPersonelGuncelle);
            this.grbZimmetIslemleri.Controls.Add(this.btnPersonelSil);
            this.grbZimmetIslemleri.Controls.Add(this.cmbDepartmanGuncelle);
            this.grbZimmetIslemleri.Controls.Add(this.label1);
            this.grbZimmetIslemleri.Controls.Add(this.label5);
            this.grbZimmetIslemleri.Controls.Add(this.label2);
            this.grbZimmetIslemleri.Controls.Add(this.txtTelefon);
            this.grbZimmetIslemleri.Controls.Add(this.txtSoyadi);
            this.grbZimmetIslemleri.Controls.Add(this.txtAdi);
            this.grbZimmetIslemleri.Controls.Add(this.calendarControl);
            this.grbZimmetIslemleri.Controls.Add(this.label6);
            this.grbZimmetIslemleri.Controls.Add(this.label7);
            this.grbZimmetIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbZimmetIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbZimmetIslemleri.Location = new System.Drawing.Point(759, 58);
            this.grbZimmetIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmetIslemleri.Name = "grbZimmetIslemleri";
            this.grbZimmetIslemleri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmetIslemleri.Size = new System.Drawing.Size(374, 503);
            this.grbZimmetIslemleri.TabIndex = 23;
            this.grbZimmetIslemleri.TabStop = false;
            this.grbZimmetIslemleri.Text = "Personel Bilgileri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(128, 105);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(172, 24);
            this.txtTelefon.TabIndex = 16;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(128, 70);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyadi.MaxLength = 15;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(172, 24);
            this.txtSoyadi.TabIndex = 16;
            this.txtSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyadi_KeyPress);
            // 
            // dgwPersonelListesi
            // 
            this.dgwPersonelListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListesi.Location = new System.Drawing.Point(12, 68);
            this.dgwPersonelListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwPersonelListesi.Name = "dgwPersonelListesi";
            this.dgwPersonelListesi.ReadOnly = true;
            this.dgwPersonelListesi.RowTemplate.Height = 24;
            this.dgwPersonelListesi.Size = new System.Drawing.Size(741, 488);
            this.dgwPersonelListesi.TabIndex = 22;
            this.dgwPersonelListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonelListesi_CellDoubleClick);
            // 
            // FormPersonelGuncelleme
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 580);
            this.Controls.Add(this.pnlUrunGrs);
            this.Controls.Add(this.grbZimmetIslemleri);
            this.Controls.Add(this.dgwPersonelListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPersonelGuncelleme";
            this.Load += new System.EventHandler(this.FormPersonelGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).EndInit();
            this.grbZimmetIslemleri.ResumeLayout(false);
            this.grbZimmetIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pnlUrunGrs;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelSil;
        private System.Windows.Forms.ComboBox cmbDepartmanGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbZimmetIslemleri;
        private System.Windows.Forms.DataGridView dgwPersonelListesi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyadi;
    }
}