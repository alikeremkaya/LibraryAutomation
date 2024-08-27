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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_CıkısYap_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dgw_Kitaplar_UyeSayfasi.Rows.Add(kitap.getKitapId(), kitap.getKitapİsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getadet(), kitap.getSayfaSayisi(), kitap.getBasimYil());

            }
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32(txt_KitapID.Text);
            Kitap hedefKitap = null;

            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == kitapID)
                {
                    hedefKitap = kitap;
                }
                dgw_Kitaplar_UyeSayfasi.Rows.Clear();
                dgw_Kitaplar_UyeSayfasi.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapİsim(), hedefKitap.getkitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getadet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil());
            }
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            dgw_Kitaplar_UyeSayfasi.Rows.Remove(dgw_Kitaplar_UyeSayfasi.CurrentRow);
            foreach (Kitap hedefKitap in kitaplarim)
            {

                dgw_Kitaplar_UyeSayfasi.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapİsim(), hedefKitap.getkitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getadet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil());
            }
        }

        private void dgw_Kitaplar_UyeSayfasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
