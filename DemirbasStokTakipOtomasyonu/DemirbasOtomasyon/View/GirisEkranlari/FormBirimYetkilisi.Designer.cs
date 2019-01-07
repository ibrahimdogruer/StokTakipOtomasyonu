namespace DemirbasOtomasyon.View
{
    partial class FormBirimYetkilisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirimYetkilisi));
            this.btnPersonelListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnZimmetListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.grbZimmet = new System.Windows.Forms.GroupBox();
            this.grbZimmet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPersonelListele.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnPersonelListele.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPersonelListele.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelListele.Appearance.Options.UseBackColor = true;
            this.btnPersonelListele.Appearance.Options.UseBorderColor = true;
            this.btnPersonelListele.Appearance.Options.UseFont = true;
            this.btnPersonelListele.Appearance.Options.UseForeColor = true;
            this.btnPersonelListele.AppearanceHovered.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPersonelListele.AppearanceHovered.Options.UseBackColor = true;
            this.btnPersonelListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelListele.ImageOptions.Image")));
            this.btnPersonelListele.Location = new System.Drawing.Point(30, 132);
            this.btnPersonelListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(218, 78);
            this.btnPersonelListele.TabIndex = 0;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnZimmetListele
            // 
            this.btnZimmetListele.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnZimmetListele.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetListele.Appearance.Options.UseBackColor = true;
            this.btnZimmetListele.Appearance.Options.UseFont = true;
            this.btnZimmetListele.AppearanceHovered.BackColor = System.Drawing.Color.CadetBlue;
            this.btnZimmetListele.AppearanceHovered.Options.UseBackColor = true;
            this.btnZimmetListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetListele.ImageOptions.Image")));
            this.btnZimmetListele.Location = new System.Drawing.Point(30, 35);
            this.btnZimmetListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZimmetListele.Name = "btnZimmetListele";
            this.btnZimmetListele.Size = new System.Drawing.Size(218, 78);
            this.btnZimmetListele.TabIndex = 3;
            this.btnZimmetListele.Text = "Zimmet Listele";
            this.btnZimmetListele.Click += new System.EventHandler(this.btnZimmetListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCikis.Appearance.BackColor2 = System.Drawing.Color.OliveDrab;
            this.btnCikis.Appearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnCikis.Appearance.Options.UseBackColor = true;
            this.btnCikis.Appearance.Options.UseBorderColor = true;
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.Appearance.Options.UseForeColor = true;
            this.btnCikis.AppearanceHovered.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.AppearanceHovered.Options.UseBackColor = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(385, 11);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(41, 40);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // grbZimmet
            // 
            this.grbZimmet.BackColor = System.Drawing.Color.OliveDrab;
            this.grbZimmet.Controls.Add(this.btnPersonelListele);
            this.grbZimmet.Controls.Add(this.btnZimmetListele);
            this.grbZimmet.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbZimmet.Location = new System.Drawing.Point(70, 37);
            this.grbZimmet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmet.Name = "grbZimmet";
            this.grbZimmet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbZimmet.Size = new System.Drawing.Size(282, 242);
            this.grbZimmet.TabIndex = 22;
            this.grbZimmet.TabStop = false;
            this.grbZimmet.Text = "Listeleme İşlemleri";
            // 
            // FormBirimYetkilisi
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 317);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.grbZimmet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormBirimYetkilisi";
            this.Text = "Birim Yetkili Paneli";
            this.Load += new System.EventHandler(this.FormBirimYetkilisi_Load);
            this.grbZimmet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPersonelListele;
        private DevExpress.XtraEditors.SimpleButton btnZimmetListele;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.GroupBox grbZimmet;
    }
}