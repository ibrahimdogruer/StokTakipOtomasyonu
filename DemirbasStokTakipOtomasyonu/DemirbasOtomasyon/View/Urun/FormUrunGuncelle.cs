﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;
using DemirbasOtomasyon.View;

namespace DemirbasOtomasyon.View
{
    public partial class FormUrunGuncelle : DevExpress.XtraEditors.XtraForm
    {
        int urunID = 0;
        
        public FormUrunGuncelle()
        {
            InitializeComponent();
        }

        private void UrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = (from d in db.sp_UrunListeleme() select new { d.urunID,d.urunAd,d.marka,d.model,d.stokMiktari,d.fiyat,d.satınAlınmaTarihi,d.tedarikciFirma} );
            dgwUrunListele.DataSource = data.ToList();
        }

        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            UrunListele();
            UrunRenklendir();
        }

        private void UrunRenklendir()
        {
            try

            {
                for (int i = 0; i < dgwUrunListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwUrunListele.Rows[i].Cells[4].Value) >= 6)
                    {
                        rowColor.BackColor = Color.PaleGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwUrunListele.Rows[i].Cells[4].Value) >= 3 && Convert.ToInt32(dgwUrunListele.Rows[i].Cells[4].Value) <= 5)
                    {
                        rowColor.BackColor = Color.LightGray;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwUrunListele.Rows[i].Cells[4].Value) < 3)
                    {
                        rowColor.BackColor = Color.PaleVioletRed;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwUrunListele.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }

        private void VeriGuncelle()
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtAdet.Text))
                {
                    throw new Exception("Ürün Bilgileri Boş Geçilemez !");
                }
                try
                {
                    if (int.Parse(txtAdet.Text) <= 0)
                    {
                        MessageBox.Show("Stok Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                        txtAdet.Text = "";
                        txtAdet.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Adet için geçerli bir değer girin");
                    txtAdet.Text = "";
                    txtAdet.Focus();
                }
                try
                {
                    if (decimal.Parse(txtFiyat.Text) <= 0)
                    {
                        MessageBox.Show("Fiyat Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                        txtFiyat.Text = "";
                        txtFiyat.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Fiyat için geçerli bir değer girin");
                    txtFiyat.Text = "";
                    txtFiyat.Focus();
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new Exception("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Urunler urun = new Urunler
                {
                    urunID = urunID,
                    urunAd = txtUrunAd.Text,
                    marka = txtMarka.Text,
                    model = txtModel.Text,
                    fiyat = decimal.Parse(txtFiyat.Text),
                    stokMiktari = int.Parse(txtAdet.Text),
                    satınAlınmaTarihi = selectedDate,
                    tedarikciFirma = txtFirma.Text
                };
                UrunController.urunDuzenle(urun);
                MessageBox.Show("Ürün Başarıyla Düzenlendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(txtUrunAd.Text + " İsimli Ürün Silinsin Mi ?", "Karar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                UrunController.UrunSil(urunID);
                MessageBox.Show(txtUrunAd.Text + " İsimli Ürün Silindi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(500);
                UrunListele();
                UrunRenklendir();
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            VeriGuncelle();
            UrunRenklendir();
        }

        private void txtUrunAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtFirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgwUrunListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            urunID = Convert.ToInt32(dgwUrunListele.CurrentRow.Cells[0].Value);
            txtUrunAd.Text = dgwUrunListele.CurrentRow.Cells[1].Value.ToString();
            txtMarka.Text = dgwUrunListele.CurrentRow.Cells[2].Value.ToString();
            txtModel.Text = dgwUrunListele.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = dgwUrunListele.CurrentRow.Cells[4].Value.ToString();
            txtFiyat.Text = dgwUrunListele.CurrentRow.Cells[5].Value.ToString();
            calendarControl1.EditValue = dgwUrunListele.CurrentRow.Cells[6].Value;
            txtFirma.Text = dgwUrunListele.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}