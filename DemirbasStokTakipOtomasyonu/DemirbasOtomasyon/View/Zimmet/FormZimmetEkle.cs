using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;


namespace DemirbasOtomasyon.View
{
    public partial class FormZimmetEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormZimmetEkle()
        {
            InitializeComponent();
        }

        int urunID = 0;
        ComboBox cmbKullanicilar = new ComboBox();

        private void ZimmetEkleRenklendir()
        {
            try

            {
                for (int i = 0; i < dgwZimmetListesi.Rows.Count; i++)         
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[4].Value) >=6)
                    {
                        rowColor.BackColor = Color.PaleGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if(Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[4].Value) >=3 && Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[4].Value) <=5)
                    {
                        rowColor.BackColor = Color.LightGray;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if(Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[4].Value) <3)
                    {
                        rowColor.BackColor = Color.PaleVioletRed;                
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwZimmetListesi.Rows[i].DefaultCellStyle = rowColor;   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " +ex);
            }
        }
        private void FormZimmetEkle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            Araclar.ComboBoxPersonelGetir(cmbPersonel);
            Araclar.ComboBoxKullaniciGetir(cmbKullanicilar);
            ZimmetUrunListele();
            cmbPersonel.SelectedItem = null;
            cmbPersonel.SelectedText = "Personel Seçiniz...";
        }
        private void ZimmetUrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = (from d in db.sp_UrunListeleme() select new { d.urunID, d.urunAd, d.marka, d.model, d.stokMiktari, d.fiyat, d.satınAlınmaTarihi, d.tedarikciFirma });
            dgwZimmetListesi.DataSource = data.ToList();
            ZimmetEkleRenklendir();
        }

        private void BtnZimmetKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl.SelectionStart.ToShortDateString());
            
                try
                {
                    if (string.IsNullOrEmpty(txtAdet.Text) || (short.Parse(txtAdet.Text) <= 0))
                    {
                        MessageBox.Show("Adet Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
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
                if (short.Parse(txtAdet.Text) > Convert.ToInt16(dgwZimmetListesi.CurrentRow.Cells[4].Value))
                {
                    throw new Exception("Stok Miktarındakinden Fazla Ürün Zimmete Eklenemez ! !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new Exception("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Zimmetler zimmet = new Zimmetler
                {
                    urunID = urunID,
                    zimmetAdet = int.Parse(txtAdet.Text),
                    personelID = Convert.ToInt32(cmbPersonel.SelectedValue),
                    kullaniciID = FormKullaniciSecim._userIdSession,
                    zimmetTarihi = selectedDate
                };
                
                ZimmetController.ZimmetEkle(zimmet, int.Parse(txtAdet.Text));
                MessageBox.Show("Zimmet Başarıyla Eklendi !", "Zimmet Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ZimmetUrunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgwZimmetListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            urunID = Convert.ToInt32(dgwZimmetListesi.CurrentRow.Cells[0].Value);
            txtUrunAd.Text = dgwZimmetListesi.CurrentRow.Cells[1].Value.ToString();
            txtMarka.Text = dgwZimmetListesi.CurrentRow.Cells[2].Value.ToString();
            txtModel.Text = dgwZimmetListesi.CurrentRow.Cells[3].Value.ToString();
            calendarControl.EditValue = dgwZimmetListesi.CurrentRow.Cells[6].Value;
        }

        private void txtUrunAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
