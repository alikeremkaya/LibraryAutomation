using KütüphaneOtomasyon.Model;

namespace KütüphaneOtomasyon
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            text_kullaniciAdi.Text = string.Empty;
            text_sifre.Text = string.Empty;

        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = text_kullaniciAdi.Text;
            sifre = text_sifre.Text;
            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                   AdminSayfasi adminSayfasi=new AdminSayfasi(kisilerim,kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol= true;

                    break;
                }
                else if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    UyeSayfasi uyeSayfasi=new UyeSayfasi(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                
            }
            if (!kontrol)
            {
                MessageBox.Show("Hatalı Giriş ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
          

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi (1, "Enes","Bayram", DateTime.Now, "enes","1", "admin"));
            kisilerim.Add(new Kisi (2, "Yakup","Reçber", DateTime.Now, "yakup","2", "uye"));
            kisilerim.Add(new Kisi (3, "Bilal","Çamur", DateTime.Now, "bilal","3", "uye"));
            kisilerim.Add(new Kisi (4, "Yasin","Yazıcı", DateTime.Now, "yasin","4 ", "uye"));

            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 350, 760, 2015));
            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest yayıncılık", "Roman", 100, 350, 2010));
            kitaplarim.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupery", "İngilizce", "Can çocuk yayınları", "Roman", 50, 60, 2018));
            kitaplarim.Add(new Kitap(5, "Kürk Mantolu Madonna", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 650, 220, 2015));
            kitaplarim.Add(new Kitap(6, "Tehlikeli Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 420, 500, 2018));


        }
    }
}
