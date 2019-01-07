﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DemirbasOtomasyon.View
{
    public partial class FormKullaniciSecim : DevExpress.XtraEditors.XtraForm
    {
        public FormKullaniciSecim()
        {
            InitializeComponent();
        }
        public static string _session { get; set; }
        public static int _userIdSession { get; set; }

        private void FormKullaniciSecim_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);

        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            FormAdminGiris fag = new FormAdminGiris();
            fag.Show();
            this.Hide();
        }

        private void btnSatinAlma_Click(object sender, EventArgs e)
        {
            FormSAGiris fsag = new FormSAGiris();
            fsag.Show();
            this.Hide();
        }

        private void btnBirimYetkilisi_Click_1(object sender, EventArgs e)
        {
            FormBYGiris fbyg = new FormBYGiris();
            fbyg.Show();
            this.Hide();
        }
    }
}