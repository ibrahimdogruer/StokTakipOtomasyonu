namespace DemirbasOtomasyon.View
{
    partial class FormUrunListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunListele));
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwUrunListesi = new System.Windows.Forms.DataGridView();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.BtnUrunBul = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTumUrunler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRapor = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(385, 18);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(167, 29);
            this.pnlUrunGrs.TabIndex = 40;
            this.pnlUrunGrs.Text = "ÜRÜN LİSTESİ";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(82, 86);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunID.MaxLength = 5;
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(91, 24);
            this.txtUrunID.TabIndex = 41;
            this.txtUrunID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunID_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ürün ID:";
            // 
            // dgwUrunListesi
            // 
            this.dgwUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUrunListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunListesi.Location = new System.Drawing.Point(14, 115);
            this.dgwUrunListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwUrunListesi.Name = "dgwUrunListesi";
            this.dgwUrunListesi.ReadOnly = true;
            this.dgwUrunListesi.RowTemplate.Height = 24;
            this.dgwUrunListesi.Size = new System.Drawing.Size(954, 327);
            this.dgwUrunListesi.TabIndex = 43;
            // 
            // ppdDialog
            // 
            this.ppdDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdDialog.Document = this.pdYazici;
            this.ppdDialog.Enabled = true;
            this.ppdDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdDialog.Icon")));
            this.ppdDialog.Name = "ppdDialog";
            this.ppdDialog.Text = "Baskı önizleme";
            this.ppdDialog.Visible = false;
            // 
            // pdYazici
            // 
            this.pdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdYazici_PrintPage_1);
            // 
            // BtnUrunBul
            // 
            this.BtnUrunBul.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.BtnUrunBul.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.BtnUrunBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnUrunBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunBul.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnUrunBul.Appearance.Options.UseBackColor = true;
            this.BtnUrunBul.Appearance.Options.UseBorderColor = true;
            this.BtnUrunBul.Appearance.Options.UseFont = true;
            this.BtnUrunBul.Appearance.Options.UseForeColor = true;
            this.BtnUrunBul.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnUrunBul.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnUrunBul.AppearanceHovered.Options.UseBackColor = true;
            this.BtnUrunBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.BtnUrunBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunBul.ImageOptions.Image")));
            this.BtnUrunBul.Location = new System.Drawing.Point(179, 77);
            this.BtnUrunBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUrunBul.Name = "BtnUrunBul";
            this.BtnUrunBul.Size = new System.Drawing.Size(37, 40);
            this.BtnUrunBul.TabIndex = 46;
            this.BtnUrunBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnUrunBul.Click += new System.EventHandler(this.BtnUrunBul_Click);
            // 
            // BtnTumUrunler
            // 
            this.BtnTumUrunler.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnTumUrunler.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.BtnTumUrunler.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnTumUrunler.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumUrunler.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTumUrunler.Appearance.Options.UseBackColor = true;
            this.BtnTumUrunler.Appearance.Options.UseBorderColor = true;
            this.BtnTumUrunler.Appearance.Options.UseFont = true;
            this.BtnTumUrunler.Appearance.Options.UseForeColor = true;
            this.BtnTumUrunler.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnTumUrunler.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnTumUrunler.AppearanceHovered.Options.UseBackColor = true;
            this.BtnTumUrunler.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTumUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTumUrunler.ImageOptions.Image")));
            this.BtnTumUrunler.Location = new System.Drawing.Point(383, 76);
            this.BtnTumUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTumUrunler.Name = "BtnTumUrunler";
            this.BtnTumUrunler.Size = new System.Drawing.Size(169, 34);
            this.BtnTumUrunler.TabIndex = 45;
            this.BtnTumUrunler.Text = "TÜMÜNÜ LİSTELE";
            this.BtnTumUrunler.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnTumUrunler.Click += new System.EventHandler(this.BtnTumUrunler_Click_1);
            // 
            // BtnRapor
            // 
            this.BtnRapor.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnRapor.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.BtnRapor.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnRapor.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRapor.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnRapor.Appearance.Options.UseBackColor = true;
            this.BtnRapor.Appearance.Options.UseBorderColor = true;
            this.BtnRapor.Appearance.Options.UseFont = true;
            this.BtnRapor.Appearance.Options.UseForeColor = true;
            this.BtnRapor.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRapor.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnRapor.AppearanceHovered.Options.UseBackColor = true;
            this.BtnRapor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRapor.ImageOptions.Image")));
            this.BtnRapor.Location = new System.Drawing.Point(848, 69);
            this.BtnRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(120, 42);
            this.BtnRapor.TabIndex = 44;
            this.BtnRapor.Text = "RAPOR";
            this.BtnRapor.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click_1);
            // 
            // FormUrunListele
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 457);
            this.Controls.Add(this.pnlUrunGrs);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwUrunListesi);
            this.Controls.Add(this.BtnUrunBul);
            this.Controls.Add(this.BtnTumUrunler);
            this.Controls.Add(this.BtnRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormUrunListele";
            this.Load += new System.EventHandler(this.FormUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwUrunListesi;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private DevExpress.XtraEditors.SimpleButton BtnTumUrunler;
        public System.Windows.Forms.TextBox txtUrunID;
        public DevExpress.XtraEditors.SimpleButton BtnUrunBul;
        public DevExpress.XtraEditors.SimpleButton BtnRapor;
    }
}