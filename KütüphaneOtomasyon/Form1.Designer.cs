namespace KütüphaneOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblKullaniciAdi = new Label();
            text_kullaniciAdi = new TextBox();
            label1 = new Label();
            text_sifre = new TextBox();
            btn_girisYap = new Button();
            btn_temizle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(219, 41);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(79, 15);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adı: ";
            // 
            // text_kullaniciAdi
            // 
            text_kullaniciAdi.Location = new Point(338, 38);
            text_kullaniciAdi.Name = "text_kullaniciAdi";
            text_kullaniciAdi.Size = new Size(150, 23);
            text_kullaniciAdi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 88);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Şifre:";
            // 
            // text_sifre
            // 
            text_sifre.Location = new Point(338, 80);
            text_sifre.Name = "text_sifre";
            text_sifre.Size = new Size(150, 23);
            text_sifre.TabIndex = 4;
            // 
            // btn_girisYap
            // 
            btn_girisYap.Location = new Point(338, 130);
            btn_girisYap.Name = "btn_girisYap";
            btn_girisYap.Size = new Size(75, 25);
            btn_girisYap.TabIndex = 5;
            btn_girisYap.Text = "Giriş Yap";
            btn_girisYap.UseVisualStyleBackColor = true;
            btn_girisYap.Click += btn_girisYap_Click;
            // 
            // btn_temizle
            // 
            btn_temizle.Location = new Point(413, 130);
            btn_temizle.Name = "btn_temizle";
            btn_temizle.Size = new Size(75, 25);
            btn_temizle.TabIndex = 6;
            btn_temizle.Text = "Temizle";
            btn_temizle.UseVisualStyleBackColor = true;
            btn_temizle.Click += btn_temizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 178);
            Controls.Add(btn_temizle);
            Controls.Add(btn_girisYap);
            Controls.Add(text_sifre);
            Controls.Add(label1);
            Controls.Add(text_kullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblKullaniciAdi;
        private TextBox text_kullaniciAdi;
        private Label label1;
        private TextBox text_sifre;
        private Button btn_girisYap;
        private Button btn_temizle;
    }
}
