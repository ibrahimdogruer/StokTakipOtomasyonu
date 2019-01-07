namespace DemirbasOtomasyon.View
{
    partial class FormZimmetGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZimmetGuncelleme));
            this.dgwZimmetGuncellemeListele = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.cmbPersonelGuncelle = new System.Windows.Forms.ComboBox();
            this.grbUrunIslemleri = new System.Windows.Forms.GroupBox();
            this.btnZimmetKaldir = new DevExpress.XtraEditors.SimpleButton();
            this.btnZimmetGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetGuncellemeListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.grbUrunIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwZimmetGuncellemeListele
            // 
            this.dgwZimmetGuncellemeListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwZimmetGuncellemeListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZimmetGuncellemeListele.Location = new System.Drawing.Point(10, 73);
            this.dgwZimmetGuncellemeListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwZimmetGuncellemeListele.Name = "dgwZimmetGuncellemeListele";
            this.dgwZimmetGuncellemeListele.ReadOnly = true;
            this.dgwZimmetGuncellemeListele.RowTemplate.Height = 24;
            this.dgwZimmetGuncellemeListele.Size = new System.Drawing.Size(704, 440);
            this.dgwZimmetGuncellemeListele.TabIndex = 19;
            this.dgwZimmetGuncellemeListele.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgwZimmetGuncellemeListele_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Personel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Zimmet Tarihi:";
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(145, 22);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdet.MaxLength = 3;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(172, 24);
            this.txtAdet.TabIndex = 2;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.DateTime = new System.DateTime(2018, 12, 26, 0, 0, 0, 0);
            this.calendarControl1.EditValue = new System.DateTime(2018, 12, 26, 0, 0, 0, 0);
            this.calendarControl1.Location = new System.Drawing.Point(118, 96);
            this.calendarControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(230, 227);
            this.calendarControl1.TabIndex = 14;
            // 
            // cmbPersonelGuncelle
            // 
            this.cmbPersonelGuncelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelGuncelle.FormattingEnabled = true;
            this.cmbPersonelGuncelle.Location = new System.Drawing.Point(145, 54);
            this.cmbPersonelGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPersonelGuncelle.Name = "cmbPersonelGuncelle";
            this.cmbPersonelGuncelle.Size = new System.Drawing.Size(172, 25);
            this.cmbPersonelGuncelle.TabIndex = 21;
            // 
            // grbUrunIslemleri
            // 
            this.grbUrunIslemleri.Controls.Add(this.btnZimmetKaldir);
            this.grbUrunIslemleri.Controls.Add(this.btnZimmetGuncelle);
            this.grbUrunIslemleri.Controls.Add(this.cmbPersonelGuncelle);
            this.grbUrunIslemleri.Controls.Add(this.calendarControl1);
            this.grbUrunIslemleri.Controls.Add(this.txtAdet);
            this.grbUrunIslemleri.Controls.Add(this.label6);
            this.grbUrunIslemleri.Controls.Add(this.label4);
            this.grbUrunIslemleri.Controls.Add(this.label3);
            this.grbUrunIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunIslemleri.Location = new System.Drawing.Point(720, 64);
            this.grbUrunIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbUrunIslemleri.Name = "grbUrunIslemleri";
            this.grbUrunIslemleri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbUrunIslemleri.Size = new System.Drawing.Size(354, 448);
            this.grbUrunIslemleri.TabIndex = 20;
            this.grbUrunIslemleri.TabStop = false;
            this.grbUrunIslemleri.Text = "Zimmet Detayları";
            // 
            // btnZimmetKaldir
            // 
            this.btnZimmetKaldir.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnZimmetKaldir.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.btnZimmetKaldir.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnZimmetKaldir.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetKaldir.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnZimmetKaldir.Appearance.Options.UseBackColor = true;
            this.btnZimmetKaldir.Appearance.Options.UseBorderColor = true;
            this.btnZimmetKaldir.Appearance.Options.UseFont = true;
            this.btnZimmetKaldir.Appearance.Options.UseForeColor = true;
            this.btnZimmetKaldir.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZimmetKaldir.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.btnZimmetKaldir.AppearanceHovered.Options.UseBackColor = true;
            this.btnZimmetKaldir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnZimmetKaldir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.ImageOptions.Image")));
            this.btnZimmetKaldir.Location = new System.Drawing.Point(21, 362);
            this.btnZimmetKaldir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZimmetKaldir.Name = "btnZimmetKaldir";
            this.btnZimmetKaldir.Size = new System.Drawing.Size(153, 42);
            this.btnZimmetKaldir.TabIndex = 30;
            this.btnZimmetKaldir.Text = "ZİMMET KALDIR";
            this.btnZimmetKaldir.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnZimmetKaldir.Click += new System.EventHandler(this.btnZimmetKaldir_Click);
            // 
            // btnZimmetGuncelle
            // 
            this.btnZimmetGuncelle.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnZimmetGuncelle.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.btnZimmetGuncelle.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnZimmetGuncelle.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnZimmetGuncelle.Appearance.Options.UseBackColor = true;
            this.btnZimmetGuncelle.Appearance.Options.UseBorderColor = true;
            this.btnZimmetGuncelle.Appearance.Options.UseFont = true;
            this.btnZimmetGuncelle.Appearance.Options.UseForeColor = true;
            this.btnZimmetGuncelle.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZimmetGuncelle.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.btnZimmetGuncelle.AppearanceHovered.Options.UseBackColor = true;
            this.btnZimmetGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnZimmetGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunGuncelle.ImageOptions.Image")));
            this.btnZimmetGuncelle.Location = new System.Drawing.Point(195, 362);
            this.btnZimmetGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZimmetGuncelle.Name = "btnZimmetGuncelle";
            this.btnZimmetGuncelle.Size = new System.Drawing.Size(153, 42);
            this.btnZimmetGuncelle.TabIndex = 31;
            this.btnZimmetGuncelle.Text = "GÜNCELLE";
            this.btnZimmetGuncelle.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnZimmetGuncelle.Click += new System.EventHandler(this.btnZimmetGuncelle_Click);
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(326, 20);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(380, 29);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ZİMMET GÜNCELLEME İŞLEMLERİ";
            // 
            // FormZimmetGuncelleme
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 529);
            this.Controls.Add(this.pnlUrunGrs);
            this.Controls.Add(this.grbUrunIslemleri);
            this.Controls.Add(this.dgwZimmetGuncellemeListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormZimmetGuncelleme";
            this.Load += new System.EventHandler(this.FormZimmetGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetGuncellemeListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.grbUrunIslemleri.ResumeLayout(false);
            this.grbUrunIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwZimmetGuncellemeListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdet;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.ComboBox cmbPersonelGuncelle;
        private System.Windows.Forms.GroupBox grbUrunIslemleri;
        private System.Windows.Forms.Label pnlUrunGrs;
        private DevExpress.XtraEditors.SimpleButton btnZimmetKaldir;
        private DevExpress.XtraEditors.SimpleButton btnZimmetGuncelle;
    }
}