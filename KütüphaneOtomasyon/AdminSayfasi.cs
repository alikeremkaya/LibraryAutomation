using KütüphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;

        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarih(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }
            foreach (Kitap kitap in kitaplarim)
            {
                dgw_Kitaplar.Rows.Add(kitap.getKitapId(), kitap.getKitapİsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getSayfaSayisi(), kitap.getadet(), kitap.getBasimYil());
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyİsim.Text, maskedTextBox1.Text, txt_kullaniciAdi.Text, txt_sifre.Text, txt_Yetki.Text);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textleriDoldur();
        }
        public void textleriDoldur()

        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyİsim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_uyeIslemleri.Controls.Count; i++)
            {
                if (groupBox_uyeIslemleri.Controls[i] is TextBox || groupBox_uyeIslemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_uyeIslemleri.Controls[i].Text = string.Empty;

                }
            }
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyİsim.Text;
            string tarih = maskedTextBox1.Text;
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_Yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, tarih, kullaniciAdi, sifre);



            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(txt_id.Text, txt_isim.Text, txt_soyİsim.Text, maskedTextBox1.Text, txt_kullaniciAdi.Text, txt_sifre.Text, txt_Yetki.Text);

        }

        private void btn_KitapSil_Click(object sender, EventArgs e)
        {
            dgw_Kitaplar.Rows.Remove(dgw_Kitaplar.CurrentRow);
        }

        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            Text_kitapDoldur();
        }
        public void Text_kitapDoldur()
        {
            string kitapid = txt_kitapId.Text;
            string kitapismi = txt_kitapIsim.Text;
            string kitapyazar = txt_kitapYazar.Text;
            string dil = txt_Dil.Text;
            string yayinEvi = txt_yayinEvi.Text;
            string tur = txt_Tur.Text;
            string adet = txt_kitapAdet.Text;
            string sayfa = txt_Sayfa.Text;
            string basimYili = txt_BasimYili.Text;
            dgw_Kitaplar.Rows.Add(kitapid, kitapismi, kitapyazar, dil, yayinEvi, tur, adet, sayfa, basimYili);
        }

        private void btn_KitapGüncelle_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapId.Text;
            string kitapismi = txt_kitapIsim.Text;
            string kitapyazar = txt_kitapYazar.Text;
            string dil = txt_Dil.Text;
            string yayinEvi = txt_yayinEvi.Text;
            string tur = txt_Tur.Text;
            string adet = txt_kitapAdet.Text;
            string sayfa = txt_Sayfa.Text;
            string basimYili = txt_BasimYili.Text;

            dgw_Kitaplar.Rows.Remove(dgw_Kitaplar.CurrentRow);

            dgw_Kitaplar.Rows.Add(kitapid, kitapismi, kitapyazar, dil, yayinEvi, tur, adet, sayfa, basimYili);





        }

        private void btn_KitapTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_Kitap.Controls.Count; i++)
            {
                if (groupBox_Kitap.Controls[i] is TextBox)
                {
                    groupBox_Kitap.Controls[i].Text = string.Empty;

                }
            }
        }

        private void dgw_Kitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapId.Text = dgw_Kitaplar.CurrentRow.Cells[0].Value.ToString();
            txt_kitapIsim.Text = dgw_Kitaplar.CurrentRow.Cells[1].Value.ToString();
            txt_kitapYazar.Text = dgw_Kitaplar.CurrentRow.Cells[2].Value.ToString();
            txt_Dil.Text = dgw_Kitaplar.CurrentRow.Cells[3].Value.ToString();
            txt_yayinEvi.Text = dgw_Kitaplar.CurrentRow.Cells[4].Value.ToString();
            txt_Tur.Text = dgw_Kitaplar.CurrentRow.Cells[5].Value.ToString();
            txt_kitapAdet.Text = dgw_Kitaplar.CurrentRow.Cells[6].Value.ToString();
            txt_Sayfa.Text = dgw_Kitaplar.CurrentRow.Cells[7].Value.ToString();
            txt_BasimYili.Text = dgw_Kitaplar.CurrentRow.Cells[8].Value.ToString();



        }

        private void btn_Kisi_Ara_Click(object sender, EventArgs e)
        {
            Kisi hedefKisi = null;

            int secilenKisiID = Convert.ToInt32(textBox1.Text);

            foreach (Kisi kisi in kisilerim)
            {
                if (kisi.getId() == secilenKisiID)
                {
                    hedefKisi = kisi;
                    break;
                }

            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarih(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
        }

        private void btn_Kisi_Yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach (Kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarih(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
        }

        private void txt_Kitaplar_Ara_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;

            int secilenKitapID = Convert.ToInt32(textBox2.Text);

            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == secilenKitapID)
                {
                    hedefKitap = kitap;
                    break;
                }

            }
            dgw_Kitaplar.Rows.Clear();
            dgw_Kitaplar.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapİsim(), hedefKitap.getkitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getadet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil());


        }

        private void btn_Kitaplar_Yenile_Click(object sender, EventArgs e)
        {
            dgw_Kitaplar.Rows.Remove(dgw_Kitaplar.CurrentRow);

            foreach (Kitap hedefKitap in kitaplarim)
            {
                dgw_Kitaplar.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapİsim(), hedefKitap.getkitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getadet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil());

            }
        }

        private void btn_CikisYap_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void groupBox_uyeIslemleri_Enter(object sender, EventArgs e)
        {

        }
    }
}
