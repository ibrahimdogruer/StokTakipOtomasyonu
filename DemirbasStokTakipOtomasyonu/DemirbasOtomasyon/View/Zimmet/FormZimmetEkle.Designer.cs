namespace DemirbasOtomasyon.View
{
    partial class FormZimmetEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZimmetEkle));
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwZimmetListesi = new System.Windows.Forms.DataGridView();
            this.BtnZimmetKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calendarControl = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.label4 = new System.Windows.Forms.Label();
            this.grbZimmetIslemleri = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).BeginInit();
            this.grbZimmetIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(328, 15);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(319, 29);
            this.pnlUrunGrs.TabIndex = 17;
            this.pnlUrunGrs.Text = "ZİMMET EKLEME İŞLEMLERİ";
            // 
            // dgwZimmetListesi
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwZimmetListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgwZimmetListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwZimmetListesi.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgwZimmetListesi.Location = new System.Drawing.Point(12, 74);
            this.dgwZimmetListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwZimmetListesi.Name = "dgwZimmetListesi";
            this.dgwZimmetListesi.ReadOnly = true;
            this.dgwZimmetListesi.RowTemplate.Height = 24;
            this.dgwZimmetListesi.Size = new System.Drawing.Size(601, 463);
            this.dgwZimmetListesi.TabIndex = 18;
            this.dgwZimmetListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwZimmetListesi_CellDoubleClick);
            // 
            // BtnZimmetKaydet
            // 
            this.BtnZimmetKaydet.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnZimmetKaydet.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.BtnZimmetKaydet.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnZimmetKaydet.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnZimmetKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnZimmetKaydet.Appearance.Options.UseBackColor = true;
            this.BtnZimmetKaydet.Appearance.Options.UseBorderColor = true;
            this.BtnZimmetKaydet.Appearance.Options.UseFont = true;
            this.BtnZimmetKaydet.Appearance.Options.UseForeColor = true;
            this.BtnZimmetKaydet.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnZimmetKaydet.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnZimmetKaydet.AppearanceHovered.Options.UseBackColor = true;
            this.BtnZimmetKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnZimmetKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnZimmetKaydet.ImageOptions.Image")));
            this.BtnZimmetKaydet.Location = new System.Drawing.Point(175, 417);
            this.BtnZimmetKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnZimmetKaydet.Name = "BtnZimmetKaydet";
            this.BtnZimmetKaydet.Size = new System.Drawing.Size(129, 44);
            this.BtnZimmetKaydet.TabIndex = 24;
            this.BtnZimmetKaydet.Text = "ZİMMETLE";
            this.BtnZimmetKaydet.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnZimmetKaydet.Click += new System.EventHandler(this.BtnZimmetKaydet_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(114, 107);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdet.MaxLength = 3;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(172, 24);
            this.txtAdet.TabIndex = 22;
            this.txtAdet.Text = "1";
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Zimmet Adet:";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(114, 135);
            this.cmbPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(172, 25);
            this.cmbPersonel.TabIndex = 20;
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(114, 78);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.MaxLength = 15;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(172, 24);
            this.txtModel.TabIndex = 16;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModel_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Model:";
            // 
            // txtMarka
            // 
            this.txtMarka.Enabled = false;
            this.txtMarka.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(114, 50);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarka.MaxLength = 15;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(172, 24);
            this.txtMarka.TabIndex = 16;
            this.txtMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Marka:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Enabled = false;
            this.txtUrunAd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(114, 22);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAd.MaxLength = 15;
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(172, 24);
            this.txtUrunAd.TabIndex = 16;
            this.txtUrunAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün Adı:";
            // 
            // calendarControl
            // 
            this.calendarControl.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl.DateTime = new System.DateTime(2018, 12, 26, 0, 0, 0, 0);
            this.calendarControl.EditValue = new System.DateTime(2018, 12, 26, 0, 0, 0, 0);
            this.calendarControl.Location = new System.Drawing.Point(114, 183);
            this.calendarControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarControl.Name = "calendarControl";
            this.calendarControl.Size = new System.Drawing.Size(230, 227);
            this.calendarControl.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Personel:";
            // 
            // grbZimmetIslemleri
            // 
            this.grbZimmetIslemleri.Controls.Add(this.BtnZimmetKaydet);
            this.grbZimmetIslemleri.Controls.Add(this.txtAdet);
            this.grbZimmetIslemleri.Controls.Add(this.label2);
            this.grbZimmetIslemleri.Controls.Add(this.cmbPersonel);
            this.grbZimmetIslemleri.Controls.Add(this.txtModel);
            this.grbZimmetIslemleri.Controls.Add(this.label5);
            this.grbZimmetIslemleri.Controls.Add(this.txtMarka);
            this.grbZimmetIslemleri.Controls.Add(this.label3);
            this.grbZimmetIslemleri.Controls.Add(this.txtUrunAd);
            this.grbZimmetIslemleri.Controls.Add(this.label1);
            this.grbZimmetIslemleri.Controls.Add(this.calendarControl);
            this.grbZimmetIslemleri.Controls.Add(this.label6);
            this.grbZimmetIslemleri.Controls.Add(this.label4);
            this.grbZimmetIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbZimmetIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbZimmetIslemleri.Location = new System.Drawing.Point(619, 65);
            this.grbZimmetIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmetIslemleri.Name = "grbZimmetIslemleri";
            this.grbZimmetIslemleri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmetIslemleri.Size = new System.Drawing.Size(351, 472);
            this.grbZimmetIslemleri.TabIndex = 19;
            this.grbZimmetIslemleri.TabStop = false;
            this.grbZimmetIslemleri.Text = "Zimmet Detayları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(55, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarih:";
            // 
            // FormZimmetEkle
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 552);
            this.Controls.Add(this.pnlUrunGrs);
            this.Controls.Add(this.dgwZimmetListesi);
            this.Controls.Add(this.grbZimmetIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormZimmetEkle";
            this.Load += new System.EventHandler(this.FormZimmetEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).EndInit();
            this.grbZimmetIslemleri.ResumeLayout(false);
            this.grbZimmetIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwZimmetListesi;
        private DevExpress.XtraEditors.SimpleButton BtnZimmetKaydet;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbZimmetIslemleri;
        private System.Windows.Forms.Label label6;
    }
}