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
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.View
{
    public partial class FormAdminGiris : DevExpress.XtraEditors.XtraForm
    {
        public FormAdminGiris()
        {
            InitializeComponent();
        }

        private void FormAdminGiris_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 150);
        }

        private void BtnGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                Kullanıcılar kullanici = new Kullanıcılar
                {
                    kullaniciAdi = txtKullaniciAdi.Text,
                    kullaniciSifre = int.Parse(txtSifre.Text)
                };
                if (string.IsNullOrEmpty(kullanici.kullaniciAdi) || string.IsNullOrEmpty(kullanici.kullaniciSifre.ToString()))
                {
                    throw new Exception("Kullanıcı Adı ve Şifre Boş Geçilemez !");
                }

                var result = KullaniciController.AdminGiris(kullanici);
                FormKullaniciSecim._session = eRoles.Admin.ToString();
                FormKullaniciSecim._userIdSession = result.kullaniciID;

                FormAdmin fa = new FormAdmin();
                fa.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVazgec_Click_1(object sender, EventArgs e)
        {
            FormKullaniciSecim fks = new FormKullaniciSecim();
            fks.Show();
            this.Hide();
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}