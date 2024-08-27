namespace KütüphaneOtomasyon
{
    partial class AdminSayfasi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSayfasi));
            groupBox_uyeIslemleri = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            btn_Temizle = new Button();
            imageList1 = new ImageList(components);
            btn_Güncelle = new Button();
            btn_Sil = new Button();
            btn_Ekle = new Button();
            txt_Yetki = new TextBox();
            label5 = new Label();
            txt_sifre = new TextBox();
            label6 = new Label();
            txt_kullaniciAdi = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txt_soyİsim = new TextBox();
            label3 = new Label();
            txt_isim = new TextBox();
            label2 = new Label();
            txt_id = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            İsim = new DataGridViewTextBoxColumn();
            Soyisim = new DataGridViewTextBoxColumn();
            olusturmaTarih = new DataGridViewTextBoxColumn();
            kullaniciAdi = new DataGridViewTextBoxColumn();
            sifre = new DataGridViewTextBoxColumn();
            yetki = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            dgw_Kitaplar = new DataGridView();
            kitapId = new DataGridViewTextBoxColumn();
            kitapİsim = new DataGridViewTextBoxColumn();
            kitapYazar = new DataGridViewTextBoxColumn();
            kitapDili = new DataGridViewTextBoxColumn();
            yayinEvi = new DataGridViewTextBoxColumn();
            kitapTürü = new DataGridViewTextBoxColumn();
            kitapAdet = new DataGridViewTextBoxColumn();
            kitapSayfa = new DataGridViewTextBoxColumn();
            basimYili = new DataGridViewTextBoxColumn();
            groupBox_Kitap = new GroupBox();
            btn_KitapTemizle = new Button();
            btn_KitapGüncelle = new Button();
            btn_KitapSil = new Button();
            btn_KitapEkle = new Button();
            txt_yayinEvi = new TextBox();
            txt_Dil = new TextBox();
            label17 = new Label();
            txt_kitapAdet = new TextBox();
            label18 = new Label();
            txt_Sayfa = new TextBox();
            label10 = new Label();
            txt_Tur = new TextBox();
            label11 = new Label();
            txt_BasimYili = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txt_kitapYazar = new TextBox();
            label14 = new Label();
            txt_kitapIsim = new TextBox();
            label15 = new Label();
            txt_kitapId = new TextBox();
            label16 = new Label();
            btn_Kisi_Ara = new Button();
            textBox1 = new TextBox();
            btn_Kisi_Yenile = new Button();
            txt_Kitaplar_Ara = new Button();
            textBox2 = new TextBox();
            btn_Kitaplar_Yenile = new Button();
            btn_CikisYap = new Button();
            groupBox_uyeIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Kitaplar).BeginInit();
            groupBox_Kitap.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_uyeIslemleri
            // 
            groupBox_uyeIslemleri.Controls.Add(maskedTextBox1);
            groupBox_uyeIslemleri.Controls.Add(btn_Temizle);
            groupBox_uyeIslemleri.Controls.Add(btn_Güncelle);
            groupBox_uyeIslemleri.Controls.Add(btn_Sil);
            groupBox_uyeIslemleri.Controls.Add(btn_Ekle);
            groupBox_uyeIslemleri.Controls.Add(txt_Yetki);
            groupBox_uyeIslemleri.Controls.Add(label5);
            groupBox_uyeIslemleri.Controls.Add(txt_sifre);
            groupBox_uyeIslemleri.Controls.Add(label6);
            groupBox_uyeIslemleri.Controls.Add(txt_kullaniciAdi);
            groupBox_uyeIslemleri.Controls.Add(label7);
            groupBox_uyeIslemleri.Controls.Add(label4);
            groupBox_uyeIslemleri.Controls.Add(txt_soyİsim);
            groupBox_uyeIslemleri.Controls.Add(label3);
            groupBox_uyeIslemleri.Controls.Add(txt_isim);
            groupBox_uyeIslemleri.Controls.Add(label2);
            groupBox_uyeIslemleri.Controls.Add(txt_id);
            groupBox_uyeIslemleri.Controls.Add(label1);
            groupBox_uyeIslemleri.Location = new Point(2, 253);
            groupBox_uyeIslemleri.Name = "groupBox_uyeIslemleri";
            groupBox_uyeIslemleri.Size = new Size(574, 366);
            groupBox_uyeIslemleri.TabIndex = 0;
            groupBox_uyeIslemleri.TabStop = false;
            groupBox_uyeIslemleri.Text = "Üye İşlemleri";
            groupBox_uyeIslemleri.Enter += groupBox_uyeIslemleri_Enter;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(131, 85);
            maskedTextBox1.Mask = "00/00/0000 90:00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(123, 23);
            maskedTextBox1.TabIndex = 18;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // btn_Temizle
            // 
            btn_Temizle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Temizle.ImageIndex = 3;
            btn_Temizle.ImageList = imageList1;
            btn_Temizle.Location = new Point(7, 328);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(558, 32);
            btn_Temizle.TabIndex = 17;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "indir.jpg");
            imageList1.Images.SetKeyName(1, "png-clipart-graphy-computer-icons-add-to-cart-button-miscellaneous-photography.png");
            imageList1.Images.SetKeyName(2, "png-transparent-button-icon-delete-button-text-sign-signage-thumbnail.png");
            imageList1.Images.SetKeyName(3, "png-transparent-dustpan-computer-icons-iconfinder-clear-miscellaneous-angle-photography.png");
            // 
            // btn_Güncelle
            // 
            btn_Güncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Güncelle.ImageIndex = 0;
            btn_Güncelle.ImageList = imageList1;
            btn_Güncelle.Location = new Point(7, 292);
            btn_Güncelle.Name = "btn_Güncelle";
            btn_Güncelle.Size = new Size(558, 30);
            btn_Güncelle.TabIndex = 16;
            btn_Güncelle.Text = "Güncelle";
            btn_Güncelle.UseVisualStyleBackColor = true;
            btn_Güncelle.Click += btn_Güncelle_Click;
            // 
            // btn_Sil
            // 
            btn_Sil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sil.ImageIndex = 2;
            btn_Sil.ImageList = imageList1;
            btn_Sil.Location = new Point(6, 255);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(559, 31);
            btn_Sil.TabIndex = 15;
            btn_Sil.Text = "Sil";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // btn_Ekle
            // 
            btn_Ekle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Ekle.ImageIndex = 1;
            btn_Ekle.ImageList = imageList1;
            btn_Ekle.Location = new Point(6, 214);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(559, 35);
            btn_Ekle.TabIndex = 14;
            btn_Ekle.Text = "Ekle";
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // txt_Yetki
            // 
            txt_Yetki.Location = new Point(132, 185);
            txt_Yetki.Name = "txt_Yetki";
            txt_Yetki.Size = new Size(123, 23);
            txt_Yetki.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 185);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Yetki:";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(442, 137);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(123, 23);
            txt_sifre.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 137);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Şifre:";
            // 
            // txt_kullaniciAdi
            // 
            txt_kullaniciAdi.Location = new Point(131, 137);
            txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            txt_kullaniciAdi.Size = new Size(123, 23);
            txt_kullaniciAdi.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 140);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 8;
            label7.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 85);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 6;
            label4.Text = "Oluşturulma Tarih:";
            // 
            // txt_soyİsim
            // 
            txt_soyİsim.Location = new Point(442, 77);
            txt_soyİsim.Name = "txt_soyİsim";
            txt_soyİsim.Size = new Size(123, 23);
            txt_soyİsim.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 77);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Soyisim:";
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(442, 31);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(123, 23);
            txt_isim.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 34);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "İsim:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(131, 26);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(123, 23);
            txt_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 26);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "Id: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, İsim, Soyisim, olusturmaTarih, kullaniciAdi, sifre, yetki });
            dataGridView1.Location = new Point(2, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(574, 202);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 75;
            // 
            // İsim
            // 
            İsim.HeaderText = "İsim";
            İsim.Name = "İsim";
            İsim.Width = 75;
            // 
            // Soyisim
            // 
            Soyisim.HeaderText = "Soyisim";
            Soyisim.Name = "Soyisim";
            Soyisim.Width = 75;
            // 
            // olusturmaTarih
            // 
            olusturmaTarih.HeaderText = "Oluşturulma Tarih";
            olusturmaTarih.Name = "olusturmaTarih";
            olusturmaTarih.Width = 75;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.HeaderText = "Kullanıcı Adı";
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Width = 75;
            // 
            // sifre
            // 
            sifre.HeaderText = "Şifre";
            sifre.Name = "sifre";
            sifre.Width = 75;
            // 
            // yetki
            // 
            yetki.HeaderText = "Yetki";
            yetki.Name = "yetki";
            yetki.Width = 75;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(271, 9);
            label8.Name = "label8";
            label8.Size = new Size(85, 22);
            label8.TabIndex = 2;
            label8.Text = "KİŞİLER";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(915, 7);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 3;
            label9.Text = "KİTAPLAR";
            // 
            // dgw_Kitaplar
            // 
            dgw_Kitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Kitaplar.Columns.AddRange(new DataGridViewColumn[] { kitapId, kitapİsim, kitapYazar, kitapDili, yayinEvi, kitapTürü, kitapAdet, kitapSayfa, basimYili });
            dgw_Kitaplar.Location = new Point(594, 34);
            dgw_Kitaplar.Name = "dgw_Kitaplar";
            dgw_Kitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Kitaplar.Size = new Size(718, 202);
            dgw_Kitaplar.TabIndex = 4;
            dgw_Kitaplar.CellClick += dgw_Kitaplar_CellClick;
            // 
            // kitapId
            // 
            kitapId.HeaderText = "Kitap ID";
            kitapId.Name = "kitapId";
            kitapId.Width = 75;
            // 
            // kitapİsim
            // 
            kitapİsim.HeaderText = "Kitap İsim";
            kitapİsim.Name = "kitapİsim";
            kitapİsim.Width = 75;
            // 
            // kitapYazar
            // 
            kitapYazar.HeaderText = "Kitap Yazar";
            kitapYazar.Name = "kitapYazar";
            kitapYazar.Width = 75;
            // 
            // kitapDili
            // 
            kitapDili.HeaderText = "Kitap Dili";
            kitapDili.Name = "kitapDili";
            kitapDili.Width = 75;
            // 
            // yayinEvi
            // 
            yayinEvi.HeaderText = "Yayin Evi";
            yayinEvi.Name = "yayinEvi";
            yayinEvi.Width = 75;
            // 
            // kitapTürü
            // 
            kitapTürü.HeaderText = "Kitap Türü";
            kitapTürü.Name = "kitapTürü";
            kitapTürü.Width = 75;
            // 
            // kitapAdet
            // 
            kitapAdet.HeaderText = "Adet";
            kitapAdet.Name = "kitapAdet";
            kitapAdet.Width = 75;
            // 
            // kitapSayfa
            // 
            kitapSayfa.HeaderText = "Sayfa Sayısı";
            kitapSayfa.Name = "kitapSayfa";
            kitapSayfa.Width = 75;
            // 
            // basimYili
            // 
            basimYili.HeaderText = "Basım Yılı";
            basimYili.Name = "basimYili";
            basimYili.Width = 75;
            // 
            // groupBox_Kitap
            // 
            groupBox_Kitap.Controls.Add(btn_KitapTemizle);
            groupBox_Kitap.Controls.Add(btn_KitapGüncelle);
            groupBox_Kitap.Controls.Add(btn_KitapSil);
            groupBox_Kitap.Controls.Add(btn_KitapEkle);
            groupBox_Kitap.Controls.Add(txt_yayinEvi);
            groupBox_Kitap.Controls.Add(txt_Dil);
            groupBox_Kitap.Controls.Add(label17);
            groupBox_Kitap.Controls.Add(txt_kitapAdet);
            groupBox_Kitap.Controls.Add(label18);
            groupBox_Kitap.Controls.Add(txt_Sayfa);
            groupBox_Kitap.Controls.Add(label10);
            groupBox_Kitap.Controls.Add(txt_Tur);
            groupBox_Kitap.Controls.Add(label11);
            groupBox_Kitap.Controls.Add(txt_BasimYili);
            groupBox_Kitap.Controls.Add(label12);
            groupBox_Kitap.Controls.Add(label13);
            groupBox_Kitap.Controls.Add(txt_kitapYazar);
            groupBox_Kitap.Controls.Add(label14);
            groupBox_Kitap.Controls.Add(txt_kitapIsim);
            groupBox_Kitap.Controls.Add(label15);
            groupBox_Kitap.Controls.Add(txt_kitapId);
            groupBox_Kitap.Controls.Add(label16);
            groupBox_Kitap.Location = new Point(594, 253);
            groupBox_Kitap.Name = "groupBox_Kitap";
            groupBox_Kitap.Size = new Size(565, 366);
            groupBox_Kitap.TabIndex = 5;
            groupBox_Kitap.TabStop = false;
            groupBox_Kitap.Text = "Kitap İşlemleri";
            // 
            // btn_KitapTemizle
            // 
            btn_KitapTemizle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KitapTemizle.ImageIndex = 3;
            btn_KitapTemizle.ImageList = imageList1;
            btn_KitapTemizle.Location = new Point(1, 328);
            btn_KitapTemizle.Name = "btn_KitapTemizle";
            btn_KitapTemizle.Size = new Size(558, 32);
            btn_KitapTemizle.TabIndex = 27;
            btn_KitapTemizle.Text = "Temizle";
            btn_KitapTemizle.UseVisualStyleBackColor = true;
            btn_KitapTemizle.Click += btn_KitapTemizle_Click;
            // 
            // btn_KitapGüncelle
            // 
            btn_KitapGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KitapGüncelle.ImageIndex = 0;
            btn_KitapGüncelle.ImageList = imageList1;
            btn_KitapGüncelle.Location = new Point(-1, 292);
            btn_KitapGüncelle.Name = "btn_KitapGüncelle";
            btn_KitapGüncelle.Size = new Size(558, 30);
            btn_KitapGüncelle.TabIndex = 26;
            btn_KitapGüncelle.Text = "Güncelle";
            btn_KitapGüncelle.UseVisualStyleBackColor = true;
            btn_KitapGüncelle.Click += btn_KitapGüncelle_Click;
            // 
            // btn_KitapSil
            // 
            btn_KitapSil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KitapSil.ImageIndex = 2;
            btn_KitapSil.ImageList = imageList1;
            btn_KitapSil.Location = new Point(0, 255);
            btn_KitapSil.Name = "btn_KitapSil";
            btn_KitapSil.Size = new Size(559, 31);
            btn_KitapSil.TabIndex = 25;
            btn_KitapSil.Text = "Sil";
            btn_KitapSil.UseVisualStyleBackColor = true;
            btn_KitapSil.Click += btn_KitapSil_Click;
            // 
            // btn_KitapEkle
            // 
            btn_KitapEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KitapEkle.ImageIndex = 1;
            btn_KitapEkle.ImageList = imageList1;
            btn_KitapEkle.Location = new Point(1, 214);
            btn_KitapEkle.Name = "btn_KitapEkle";
            btn_KitapEkle.Size = new Size(559, 35);
            btn_KitapEkle.TabIndex = 24;
            btn_KitapEkle.Text = "Ekle";
            btn_KitapEkle.UseVisualStyleBackColor = true;
            btn_KitapEkle.Click += btn_KitapEkle_Click;
            // 
            // txt_yayinEvi
            // 
            txt_yayinEvi.Location = new Point(131, 82);
            txt_yayinEvi.Name = "txt_yayinEvi";
            txt_yayinEvi.Size = new Size(123, 23);
            txt_yayinEvi.TabIndex = 23;
            // 
            // txt_Dil
            // 
            txt_Dil.Location = new Point(421, 178);
            txt_Dil.Name = "txt_Dil";
            txt_Dil.Size = new Size(123, 23);
            txt_Dil.TabIndex = 22;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(302, 187);
            label17.Name = "label17";
            label17.Size = new Size(27, 15);
            label17.TabIndex = 21;
            label17.Text = "Dil: ";
            // 
            // txt_kitapAdet
            // 
            txt_kitapAdet.Location = new Point(421, 141);
            txt_kitapAdet.Name = "txt_kitapAdet";
            txt_kitapAdet.Size = new Size(123, 23);
            txt_kitapAdet.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(302, 150);
            label18.Name = "label18";
            label18.Size = new Size(35, 15);
            label18.TabIndex = 19;
            label18.Text = "Adet:";
            // 
            // txt_Sayfa
            // 
            txt_Sayfa.Location = new Point(132, 185);
            txt_Sayfa.Name = "txt_Sayfa";
            txt_Sayfa.Size = new Size(123, 23);
            txt_Sayfa.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 185);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 12;
            label10.Text = "Sayfa:";
            // 
            // txt_Tur
            // 
            txt_Tur.Location = new Point(421, 97);
            txt_Tur.Name = "txt_Tur";
            txt_Tur.Size = new Size(123, 23);
            txt_Tur.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(302, 106);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 10;
            label11.Text = "Tür:";
            // 
            // txt_BasimYili
            // 
            txt_BasimYili.Location = new Point(131, 137);
            txt_BasimYili.Name = "txt_BasimYili";
            txt_BasimYili.Size = new Size(123, 23);
            txt_BasimYili.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 140);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 8;
            label12.Text = "Basım Yılı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 85);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 6;
            label13.Text = "Yayın Evi:";
            // 
            // txt_kitapYazar
            // 
            txt_kitapYazar.Location = new Point(421, 60);
            txt_kitapYazar.Name = "txt_kitapYazar";
            txt_kitapYazar.Size = new Size(123, 23);
            txt_kitapYazar.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(302, 69);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 4;
            label14.Text = "Kitap Yazar:";
            // 
            // txt_kitapIsim
            // 
            txt_kitapIsim.Location = new Point(421, 22);
            txt_kitapIsim.Name = "txt_kitapIsim";
            txt_kitapIsim.Size = new Size(123, 23);
            txt_kitapIsim.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(302, 34);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 2;
            label15.Text = "Kitap İsim:";
            // 
            // txt_kitapId
            // 
            txt_kitapId.Location = new Point(129, 26);
            txt_kitapId.Name = "txt_kitapId";
            txt_kitapId.Size = new Size(123, 23);
            txt_kitapId.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 26);
            label16.Name = "label16";
            label16.Size = new Size(23, 15);
            label16.TabIndex = 0;
            label16.Text = "Id: ";
            // 
            // btn_Kisi_Ara
            // 
            btn_Kisi_Ara.Location = new Point(2, 7);
            btn_Kisi_Ara.Name = "btn_Kisi_Ara";
            btn_Kisi_Ara.Size = new Size(46, 23);
            btn_Kisi_Ara.TabIndex = 6;
            btn_Kisi_Ara.Text = "Ara";
            btn_Kisi_Ara.UseVisualStyleBackColor = true;
            btn_Kisi_Ara.Click += btn_Kisi_Ara_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // btn_Kisi_Yenile
            // 
            btn_Kisi_Yenile.Location = new Point(160, 8);
            btn_Kisi_Yenile.Name = "btn_Kisi_Yenile";
            btn_Kisi_Yenile.Size = new Size(54, 23);
            btn_Kisi_Yenile.TabIndex = 8;
            btn_Kisi_Yenile.Text = "Yenile";
            btn_Kisi_Yenile.UseVisualStyleBackColor = true;
            btn_Kisi_Yenile.Click += btn_Kisi_Yenile_Click;
            // 
            // txt_Kitaplar_Ara
            // 
            txt_Kitaplar_Ara.Location = new Point(593, 4);
            txt_Kitaplar_Ara.Name = "txt_Kitaplar_Ara";
            txt_Kitaplar_Ara.Size = new Size(50, 23);
            txt_Kitaplar_Ara.TabIndex = 9;
            txt_Kitaplar_Ara.Text = "Ara";
            txt_Kitaplar_Ara.UseVisualStyleBackColor = true;
            txt_Kitaplar_Ara.Click += txt_Kitaplar_Ara_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(659, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // btn_Kitaplar_Yenile
            // 
            btn_Kitaplar_Yenile.Location = new Point(774, 5);
            btn_Kitaplar_Yenile.Name = "btn_Kitaplar_Yenile";
            btn_Kitaplar_Yenile.Size = new Size(50, 23);
            btn_Kitaplar_Yenile.TabIndex = 11;
            btn_Kitaplar_Yenile.Text = "Yenile";
            btn_Kitaplar_Yenile.UseVisualStyleBackColor = true;
            btn_Kitaplar_Yenile.Click += btn_Kitaplar_Yenile_Click;
            // 
            // btn_CikisYap
            // 
            btn_CikisYap.Location = new Point(1217, 590);
            btn_CikisYap.Name = "btn_CikisYap";
            btn_CikisYap.Size = new Size(75, 23);
            btn_CikisYap.TabIndex = 12;
            btn_CikisYap.Text = "Çıkış Yap";
            btn_CikisYap.UseVisualStyleBackColor = true;
            btn_CikisYap.Click += btn_CikisYap_Click;
            // 
            // AdminSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 622);
            Controls.Add(btn_CikisYap);
            Controls.Add(btn_Kitaplar_Yenile);
            Controls.Add(textBox2);
            Controls.Add(txt_Kitaplar_Ara);
            Controls.Add(btn_Kisi_Yenile);
            Controls.Add(textBox1);
            Controls.Add(btn_Kisi_Ara);
            Controls.Add(groupBox_Kitap);
            Controls.Add(dgw_Kitaplar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox_uyeIslemleri);
            Name = "AdminSayfasi";
            Text = "AdminSayfasi";
            Load += AdminSayfasi_Load;
            groupBox_uyeIslemleri.ResumeLayout(false);
            groupBox_uyeIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Kitaplar).EndInit();
            groupBox_Kitap.ResumeLayout(false);
            groupBox_Kitap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_uyeIslemleri;
        private TextBox txt_Yetki;
        private Label label5;
        private TextBox txt_sifre;
        private Label label6;
        private TextBox txt_kullaniciAdi;
        private Label label7;
        private TextBox txt_olusturmaTarih;
        private Label label4;
        private TextBox txt_soyİsim;
        private Label label3;
        private TextBox txt_isim;
        private Label label2;
        private TextBox txt_id;
        private Label label1;
        private Button btn_Temizle;
        private Button btn_Güncelle;
        private Button btn_Sil;
        private Button btn_Ekle;
        private DataGridView dataGridView1;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private Label label9;
        private DataGridView dgw_Kitaplar;
        private DataGridViewTextBoxColumn kitapId;
        private DataGridViewTextBoxColumn kitapİsim;
        private DataGridViewTextBoxColumn kitapYazar;
        private DataGridViewTextBoxColumn kitapDili;
        private DataGridViewTextBoxColumn yayinEvi;
        private DataGridViewTextBoxColumn kitapTürü;
        private DataGridViewTextBoxColumn kitapAdet;
        private DataGridViewTextBoxColumn kitapSayfa;
        private DataGridViewTextBoxColumn basimYili;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn İsim;
        private DataGridViewTextBoxColumn Soyisim;
        private DataGridViewTextBoxColumn olusturmaTarih;
        private DataGridViewTextBoxColumn kullaniciAdi;
        private DataGridViewTextBoxColumn sifre;
        private DataGridViewTextBoxColumn yetki;
        private GroupBox groupBox_Kitap;
        private TextBox txt_Dil;
        private Label label17;
        private TextBox txt_kitapAdet;
        private Label label18;
        private MaskedTextBox maskedTextBox2;
        private TextBox txt_Sayfa;
        private Label label10;
        private TextBox txt_Tur;
        private Label label11;
        private TextBox txt_BasimYili;
        private Label label12;
        private Label label13;
        private TextBox txt_kitapYazar;
        private Label label14;
        private TextBox txt_kitapIsim;
        private Label label15;
        private TextBox txt_kitapId;
        private Label label16;
        private TextBox txt_yayinEvi;
        private ImageList imageList1;
        private Button btn_KitapTemizle;
        private Button btn_KitapGüncelle;
        private Button btn_KitapSil;
        private Button btn_KitapEkle;
        private Button btn_Kisi_Ara;
        private TextBox textBox1;
        private Button btn_Kisi_Yenile;
        private Button txt_Kitaplar_Ara;
        private TextBox textBox2;
        private Button btn_Kitaplar_Yenile;
        private Button btn_CikisYap;
    }
}