namespace KütüphaneOtomasyon
{
    partial class UyeSayfasi
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
            btn_Ara = new Button();
            txt_KitapID = new TextBox();
            btn_Yenile = new Button();
            btn_CıkısYap = new Button();
            dgw_Kitaplar_UyeSayfasi = new DataGridView();
            kitapId = new DataGridViewTextBoxColumn();
            kitapİsim = new DataGridViewTextBoxColumn();
            kitapYazar = new DataGridViewTextBoxColumn();
            kitapDili = new DataGridViewTextBoxColumn();
            yayinEvi = new DataGridViewTextBoxColumn();
            kitapTürü = new DataGridViewTextBoxColumn();
            kitapAdet = new DataGridViewTextBoxColumn();
            kitapSayfa = new DataGridViewTextBoxColumn();
            basimYili = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgw_Kitaplar_UyeSayfasi).BeginInit();
            SuspendLayout();
            // 
            // btn_Ara
            // 
            btn_Ara.Location = new Point(12, 29);
            btn_Ara.Name = "btn_Ara";
            btn_Ara.Size = new Size(75, 23);
            btn_Ara.TabIndex = 0;
            btn_Ara.Text = "Ara";
            btn_Ara.UseVisualStyleBackColor = true;
            btn_Ara.Click += btn_Ara_Click;
            // 
            // txt_KitapID
            // 
            txt_KitapID.Location = new Point(105, 29);
            txt_KitapID.Name = "txt_KitapID";
            txt_KitapID.Size = new Size(100, 23);
            txt_KitapID.TabIndex = 1;
            // 
            // btn_Yenile
            // 
            btn_Yenile.Location = new Point(229, 29);
            btn_Yenile.Name = "btn_Yenile";
            btn_Yenile.Size = new Size(75, 23);
            btn_Yenile.TabIndex = 2;
            btn_Yenile.Text = "Yenile";
            btn_Yenile.UseVisualStyleBackColor = true;
            btn_Yenile.Click += btn_Yenile_Click;
            // 
            // btn_CıkısYap
            // 
            btn_CıkısYap.Location = new Point(655, 404);
            btn_CıkısYap.Name = "btn_CıkısYap";
            btn_CıkısYap.Size = new Size(75, 24);
            btn_CıkısYap.TabIndex = 4;
            btn_CıkısYap.Text = "Çıkış Yap";
            btn_CıkısYap.UseVisualStyleBackColor = true;
            btn_CıkısYap.Click += btn_CıkısYap_Click;
            // 
            // dgw_Kitaplar_UyeSayfasi
            // 
            dgw_Kitaplar_UyeSayfasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Kitaplar_UyeSayfasi.Columns.AddRange(new DataGridViewColumn[] { kitapId, kitapİsim, kitapYazar, kitapDili, yayinEvi, kitapTürü, kitapAdet, kitapSayfa, basimYili });
            dgw_Kitaplar_UyeSayfasi.Location = new Point(12, 71);
            dgw_Kitaplar_UyeSayfasi.Name = "dgw_Kitaplar_UyeSayfasi";
            dgw_Kitaplar_UyeSayfasi.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgw_Kitaplar_UyeSayfasi.Size = new Size(718, 327);
            dgw_Kitaplar_UyeSayfasi.TabIndex = 5;
            dgw_Kitaplar_UyeSayfasi.CellContentClick += dgw_Kitaplar_UyeSayfasi_CellContentClick;
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
            // UyeSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgw_Kitaplar_UyeSayfasi);
            Controls.Add(btn_CıkısYap);
            Controls.Add(btn_Yenile);
            Controls.Add(txt_KitapID);
            Controls.Add(btn_Ara);
            Name = "UyeSayfasi";
            Text = "UyeSayfasi";
            Load += UyeSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_Kitaplar_UyeSayfasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Ara;
        private TextBox txt_KitapID;
        private Button btn_Yenile;
        private Button btn_CıkısYap;
        private DataGridView dgw_Kitaplar_UyeSayfasi;
        private DataGridViewTextBoxColumn kitapId;
        private DataGridViewTextBoxColumn kitapİsim;
        private DataGridViewTextBoxColumn kitapYazar;
        private DataGridViewTextBoxColumn kitapDili;
        private DataGridViewTextBoxColumn yayinEvi;
        private DataGridViewTextBoxColumn kitapTürü;
        private DataGridViewTextBoxColumn kitapAdet;
        private DataGridViewTextBoxColumn kitapSayfa;
        private DataGridViewTextBoxColumn basimYili;
    }
}