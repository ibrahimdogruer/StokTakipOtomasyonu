namespace DemirbasOtomasyon.View
{
    partial class FormZimmetListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZimmetListele));
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.txtZimmetID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartmanTip = new System.Windows.Forms.ComboBox();
            this.dgwZimmetListele = new System.Windows.Forms.DataGridView();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.BtnZimmetBul = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTumZimmetler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRapor = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListele)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(383, 13);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(190, 29);
            this.pnlUrunGrs.TabIndex = 40;
            this.pnlUrunGrs.Text = "ZİMMET LİSTESİ";
            // 
            // txtZimmetID
            // 
            this.txtZimmetID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZimmetID.Location = new System.Drawing.Point(106, 110);
            this.txtZimmetID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZimmetID.MaxLength = 5;
            this.txtZimmetID.Name = "txtZimmetID";
            this.txtZimmetID.Size = new System.Drawing.Size(91, 24);
            this.txtZimmetID.TabIndex = 41;
            this.txtZimmetID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZimmetID_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Zimmet ID:";
            // 
            // cmbDepartmanTip
            // 
            this.cmbDepartmanTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanTip.FormattingEnabled = true;
            this.cmbDepartmanTip.Location = new System.Drawing.Point(784, 20);
            this.cmbDepartmanTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartmanTip.Name = "cmbDepartmanTip";
            this.cmbDepartmanTip.Size = new System.Drawing.Size(182, 21);
            this.cmbDepartmanTip.TabIndex = 43;
            this.cmbDepartmanTip.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanTip_SelectedIndexChanged);
            // 
            // dgwZimmetListele
            // 
            this.dgwZimmetListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwZimmetListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwZimmetListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZimmetListele.Location = new System.Drawing.Point(249, 95);
            this.dgwZimmetListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwZimmetListele.Name = "dgwZimmetListele";
            this.dgwZimmetListele.ReadOnly = true;
            this.dgwZimmetListele.RowTemplate.Height = 24;
            this.dgwZimmetListele.Size = new System.Drawing.Size(718, 327);
            this.dgwZimmetListele.TabIndex = 44;
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
            // BtnZimmetBul
            // 
            this.BtnZimmetBul.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.BtnZimmetBul.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.BtnZimmetBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnZimmetBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnZimmetBul.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnZimmetBul.Appearance.Options.UseBackColor = true;
            this.BtnZimmetBul.Appearance.Options.UseBorderColor = true;
            this.BtnZimmetBul.Appearance.Options.UseFont = true;
            this.BtnZimmetBul.Appearance.Options.UseForeColor = true;
            this.BtnZimmetBul.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnZimmetBul.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnZimmetBul.AppearanceHovered.Options.UseBackColor = true;
            this.BtnZimmetBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.BtnZimmetBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnZimmetBul.ImageOptions.Image")));
            this.BtnZimmetBul.Location = new System.Drawing.Point(203, 101);
            this.BtnZimmetBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnZimmetBul.Name = "BtnZimmetBul";
            this.BtnZimmetBul.Size = new System.Drawing.Size(37, 40);
            this.BtnZimmetBul.TabIndex = 47;
            this.BtnZimmetBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnZimmetBul.Click += new System.EventHandler(this.BtnZimmetBul_Click_1);
            // 
            // BtnTumZimmetler
            // 
            this.BtnTumZimmetler.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnTumZimmetler.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.BtnTumZimmetler.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnTumZimmetler.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumZimmetler.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnTumZimmetler.Appearance.Options.UseBackColor = true;
            this.BtnTumZimmetler.Appearance.Options.UseBorderColor = true;
            this.BtnTumZimmetler.Appearance.Options.UseFont = true;
            this.BtnTumZimmetler.Appearance.Options.UseForeColor = true;
            this.BtnTumZimmetler.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnTumZimmetler.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnTumZimmetler.AppearanceHovered.Options.UseBackColor = true;
            this.BtnTumZimmetler.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTumZimmetler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTumZimmetler.ImageOptions.Image")));
            this.BtnTumZimmetler.Location = new System.Drawing.Point(249, 57);
            this.BtnTumZimmetler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTumZimmetler.Name = "BtnTumZimmetler";
            this.BtnTumZimmetler.Size = new System.Drawing.Size(169, 34);
            this.BtnTumZimmetler.TabIndex = 46;
            this.BtnTumZimmetler.Text = "TÜMÜNÜ LİSTELE";
            this.BtnTumZimmetler.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnTumZimmetler.Click += new System.EventHandler(this.BtnTumZimmetler_Click_1);
            // 
            // BtnRapor
            // 
            this.BtnRapor.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnRapor.Appearance.BackColor2 = System.Drawing.Color.SeaGreen;
            this.BtnRapor.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnRapor.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRapor.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnRapor.Appearance.Options.UseBackColor = true;
            this.BtnRapor.Appearance.Options.UseBorderColor = true;
            this.BtnRapor.Appearance.Options.UseFont = true;
            this.BtnRapor.Appearance.Options.UseForeColor = true;
            this.BtnRapor.AppearanceHovered.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRapor.AppearanceHovered.BackColor2 = System.Drawing.Color.Olive;
            this.BtnRapor.AppearanceHovered.Options.UseBackColor = true;
            this.BtnRapor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRapor.ImageOptions.Image")));
            this.BtnRapor.Location = new System.Drawing.Point(847, 426);
            this.BtnRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(120, 42);
            this.BtnRapor.TabIndex = 45;
            this.BtnRapor.Text = "RAPOR";
            this.BtnRapor.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // FormZimmetListele
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 472);
            this.Controls.Add(this.pnlUrunGrs);
            this.Controls.Add(this.txtZimmetID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDepartmanTip);
            this.Controls.Add(this.dgwZimmetListele);
            this.Controls.Add(this.BtnZimmetBul);
            this.Controls.Add(this.BtnTumZimmetler);
            this.Controls.Add(this.BtnRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormZimmetListele";
            this.Load += new System.EventHandler(this.FormZimmetListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.TextBox txtZimmetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartmanTip;
        private System.Windows.Forms.DataGridView dgwZimmetListele;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private DevExpress.XtraEditors.SimpleButton BtnZimmetBul;
        private DevExpress.XtraEditors.SimpleButton BtnTumZimmetler;
        private DevExpress.XtraEditors.SimpleButton BtnRapor;
    }
}