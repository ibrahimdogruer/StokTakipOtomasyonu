using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.View;
using DemirbasOtomasyon.Model;

namespace UnitTestStokTakip
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdminGirisi()
        {
            FormAdminGiris a = new FormAdminGiris();
            a.txtKullaniciAdi.Text = "Admin";
            a.txtSifre.Text = "159654";
            a.BtnGiris.PerformClick();
        }

        [TestMethod]
        public void UrunBul()
        {
            FormUrunListele u = new FormUrunListele();
            u.txtUrunID.Text = "1";
            u.BtnUrunBul.PerformClick();
        }
        [TestMethod]
        public void DepartmanaGorePersonelListele()
        {
            FormPersonelListele p = new FormPersonelListele();
            p.cmbDepartmanTip.Text = "3";
        }
        [TestMethod]
        public void PersonelEkle()
        {
            FormPersonelEkleme p = new FormPersonelEkleme();
            p.txtPersonelAd.Text = "Sezen";
            p.txtPersonelSoyadi.Text = "Aksu";
            p.txtCepTelefonu.Text = "09876787656";
            p.calendarControl2.Text = "2018/06/05";
            p.btnPersonelEkle.PerformClick();
        }
        [TestMethod]
        public void UrunlerinRaporu()
        {
            FormUrunListele u = new FormUrunListele();
            u.BtnRapor.PerformClick();
        }
    }
}
