namespace FAVNGİYİM
{
    partial class UrunYonetimiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstUrunler  = new System.Windows.Forms.ListBox();
            this.lblAd       = new System.Windows.Forms.Label();
            this.txtAd       = new System.Windows.Forms.TextBox();
            this.lblFiyat    = new System.Windows.Forms.Label();
            this.txtFiyat    = new System.Windows.Forms.TextBox();
            this.lblStok     = new System.Windows.Forms.Label();
            this.txtStok     = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblBeden    = new System.Windows.Forms.Label();
            this.cmbBeden    = new System.Windows.Forms.ComboBox();
            this.btnEkle     = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil      = new System.Windows.Forms.Button();
            this.btnTemizle  = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lstUrunler
            this.lstUrunler.Location = new System.Drawing.Point(10, 10);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(360, 400);
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);

            // lblAd
            this.lblAd.Location = new System.Drawing.Point(390, 15);
            this.lblAd.Text = "Ürün Adı:";
            this.lblAd.Size = new System.Drawing.Size(80, 20);

            // txtAd
            this.txtAd.Location = new System.Drawing.Point(480, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);

            // lblFiyat
            this.lblFiyat.Location = new System.Drawing.Point(390, 50);
            this.lblFiyat.Text = "Fiyat (TL):";
            this.lblFiyat.Size = new System.Drawing.Size(80, 20);

            // txtFiyat
            this.txtFiyat.Location = new System.Drawing.Point(480, 47);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 22);

            // lblStok
            this.lblStok.Location = new System.Drawing.Point(390, 85);
            this.lblStok.Text = "Stok:";
            this.lblStok.Size = new System.Drawing.Size(80, 20);

            // txtStok
            this.txtStok.Location = new System.Drawing.Point(480, 82);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(200, 22);

            // lblKategori
            this.lblKategori.Location = new System.Drawing.Point(390, 120);
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.Size = new System.Drawing.Size(80, 20);

            // cmbKategori
            this.cmbKategori.Location = new System.Drawing.Point(480, 117);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(200, 22);
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblBeden
            this.lblBeden.Location = new System.Drawing.Point(390, 155);
            this.lblBeden.Text = "Beden:";
            this.lblBeden.Size = new System.Drawing.Size(80, 20);

            // cmbBeden
            this.cmbBeden.Location = new System.Drawing.Point(480, 152);
            this.cmbBeden.Name = "cmbBeden";
            this.cmbBeden.Size = new System.Drawing.Size(200, 22);
            this.cmbBeden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnEkle
            this.btnEkle.Location = new System.Drawing.Point(390, 200);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 35);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            // btnGuncelle
            this.btnGuncelle.Location = new System.Drawing.Point(390, 245);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 35);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            // btnSil
            this.btnSil.Location = new System.Drawing.Point(390, 290);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 35);
            this.btnSil.Text = "Sil";
            this.btnSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // btnTemizle
            this.btnTemizle.Location = new System.Drawing.Point(390, 335);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(130, 35);
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            // UrunYonetimiForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblBeden);
            this.Controls.Add(this.cmbBeden);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Name = "UrunYonetimiForm";
            this.Text = "Ürün Yönetimi — FAVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UrunYonetimiForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblBeden;
        private System.Windows.Forms.ComboBox cmbBeden;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
    }
}
