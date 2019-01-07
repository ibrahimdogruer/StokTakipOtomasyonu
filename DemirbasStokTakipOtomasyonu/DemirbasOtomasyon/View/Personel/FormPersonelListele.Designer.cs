namespace DemirbasOtomasyon.View
{
    partial class FormPersonelListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelListele));
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartmanTip = new System.Windows.Forms.ComboBox();
            this.dgwPersonelListele = new System.Windows.Forms.DataGridView();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.BtnPersonelBul = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTumPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRapor = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(383, 14);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(220, 29);
            this.pnlUrunGrs.TabIndex = 32;
            this.pnlUrunGrs.Text = "PERSONEL LİSTESİ";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.Location = new System.Drawing.Point(106, 111);
            this.txtPersonelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelID.MaxLength = 10;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(91, 24);
            this.txtPersonelID.TabIndex = 33;
            this.txtPersonelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelID_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Personel ID:";
            // 
            // cmbDepartmanTip
            // 
            this.cmbDepartmanTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanTip.FormattingEnabled = true;
            this.cmbDepartmanTip.Location = new System.Drawing.Point(784, 21);
            this.cmbDepartmanTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartmanTip.Name = "cmbDepartmanTip";
            this.cmbDepartmanTip.Size = new System.Drawing.Size(182, 21);
            this.cmbDepartmanTip.TabIndex = 35;
            this.cmbDepartmanTip.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanTip_SelectedIndexChanged);
            // 
            // dgwPersonelListele
            // 
            this.dgwPersonelListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPersonelListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListele.Location = new System.Drawing.Point(249, 96);
            this.dgwPersonelListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwPersonelListele.Name = "dgwPersonelListele";
            this.dgwPersonelListele.ReadOnly = true;
            this.dgwPersonelListele.RowTemplate.Height = 24;
            this.dgwPersonelListele.Size = new System.Drawing.Size(718, 327);
            this.dgwPersonelListele.TabIndex = 36;
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
            // BtnPersonelBul
            // 
            this.BtnPersonelBul.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonelBul.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.BtnPersonelBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnPersonelBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonelBul.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnPersonelBul.Appearance.Options.UseBackColor = true;
            this.BtnPersonelBul.Appearance.Options.UseBorderColor = true;
            this.BtnPersonelBul.Appearance.Options.UseFont = true;
            this.BtnPersonelBul.Appearance.Options.UseForeColor = true;
            this.BtnPersonelBul.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnPersonelBul.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnPersonelBul.AppearanceHovered.Options.UseBackColor = true;
            this.BtnPersonelBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.BtnPersonelBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelBul.ImageOptions.Image")));
            this.BtnPersonelBul.Location = new System.Drawing.Point(203, 102);
            this.BtnPersonelBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPersonelBul.Name = "BtnPersonelBul";
            this.BtnPersonelBul.Size = new System.Drawing.Size(37, 40);
            this.BtnPersonelBul.TabIndex = 39;
            this.BtnPersonelBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnPersonelBul.Click += new System.EventHandler(this.BtnPersonelBul_Click);
            // 
            // BtnTumPersonel
            // 
            this.BtnTumPersonel.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnTumPersonel.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.BtnTumPersonel.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnTumPersonel.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumPersonel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTumPersonel.Appearance.Options.UseBackColor = true;
            this.BtnTumPersonel.Appearance.Options.UseBorderColor = true;
            this.BtnTumPersonel.Appearance.Options.UseFont = true;
            this.BtnTumPersonel.Appearance.Options.UseForeColor = true;
            this.BtnTumPersonel.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnTumPersonel.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnTumPersonel.AppearanceHovered.Options.UseBackColor = true;
            this.BtnTumPersonel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTumPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTumPersonel.ImageOptions.Image")));
            this.BtnTumPersonel.Location = new System.Drawing.Point(249, 58);
            this.BtnTumPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTumPersonel.Name = "BtnTumPersonel";
            this.BtnTumPersonel.Size = new System.Drawing.Size(169, 34);
            this.BtnTumPersonel.TabIndex = 38;
            this.BtnTumPersonel.Text = "TÜMÜNÜ LİSTELE";
            this.BtnTumPersonel.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnTumPersonel.Click += new System.EventHandler(this.BtnTumPersonel_Click_1);
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
            this.BtnRapor.Location = new System.Drawing.Point(847, 427);
            this.BtnRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(120, 42);
            this.BtnRapor.TabIndex = 37;
            this.BtnRapor.Text = "RAPOR";
            this.BtnRapor.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click_1);
            // 
            // FormPersonelListele
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 476);
            this.Controls.Add(this.pnlUrunGrs);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDepartmanTip);
            this.Controls.Add(this.dgwPersonelListele);
            this.Controls.Add(this.BtnPersonelBul);
            this.Controls.Add(this.BtnTumPersonel);
            this.Controls.Add(this.BtnRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPersonelListele";
            this.Load += new System.EventHandler(this.FormPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwPersonelListele;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private DevExpress.XtraEditors.SimpleButton BtnPersonelBul;
        private DevExpress.XtraEditors.SimpleButton BtnTumPersonel;
        private DevExpress.XtraEditors.SimpleButton BtnRapor;
        public System.Windows.Forms.ComboBox cmbDepartmanTip;
    }
}