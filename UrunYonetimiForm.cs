using System;
using System.Windows.Forms;
using Gorsel_Programlama;

namespace FAVNGİYİM
{
    public partial class UrunYonetimiForm : Form
    {
        private Form1 _anaForm;
        private Urun _seciliUrun;

        public UrunYonetimiForm(Form1 anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        private void UrunYonetimiForm_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.AddRange(new string[] { "Üst Giyim", "Alt Giyim", "Aksesuar" });
            cmbBeden.Items.AddRange(new string[] { "S", "M", "L", "XL" });
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            lstUrunler.Items.Clear();
            foreach (var urun in VeriTabani.TumUrunler)
                lstUrunler.Items.Add(urun);
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem is Urun urun)
            {
                _seciliUrun = urun;
                txtAd.Text = urun.Ad;
                txtFiyat.Text = urun.Fiyat.ToString();
                txtStok.Text = urun.Stok.ToString();
                cmbKategori.SelectedItem = urun.Kategori;
                cmbBeden.SelectedItem = urun.Beden;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!FormuDogrula()) return;

            var yeniUrun = new Urun
            {
                Id = VeriTabani.YeniId(),
                Ad = txtAd.Text.Trim(),
                Fiyat = decimal.Parse(txtFiyat.Text),
                Stok = int.Parse(txtStok.Text),
                Kategori = cmbKategori.SelectedItem.ToString(),
                Beden = cmbBeden.SelectedItem.ToString()
            };

            VeriTabani.UrunEkle(yeniUrun);
            ListeyiYenile();
            _anaForm?.UrunleriListele();
            FormuTemizle();
            MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliUrun == null) { MessageBox.Show("Lütfen güncellenecek ürünü seçin."); return; }
            if (!FormuDogrula()) return;

            _seciliUrun.Ad = txtAd.Text.Trim();
            _seciliUrun.Fiyat = decimal.Parse(txtFiyat.Text);
            _seciliUrun.Stok = int.Parse(txtStok.Text);
            _seciliUrun.Kategori = cmbKategori.SelectedItem.ToString();
            _seciliUrun.Beden = cmbBeden.SelectedItem.ToString();
            VeriTabani.StokDurumu[_seciliUrun.Id] = _seciliUrun.Stok;
            VeriTabani.IslemKaydet($"Ürün güncellendi: {_seciliUrun.Ad}");

            ListeyiYenile();
            _anaForm?.UrunleriListele();
            FormuTemizle();
            MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_seciliUrun == null) { MessageBox.Show("Lütfen silinecek ürünü seçin."); return; }

            var onay = MessageBox.Show($"{_seciliUrun.Ad} silinsin mi?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                VeriTabani.UrunSil(_seciliUrun.Id);
                ListeyiYenile();
                _anaForm?.UrunleriListele();
                FormuTemizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e) => FormuTemizle();

        private bool FormuDogrula()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            { MessageBox.Show("Ürün adı boş olamaz."); return false; }
            if (!decimal.TryParse(txtFiyat.Text, out _))
            { MessageBox.Show("Geçerli bir fiyat girin."); return false; }
            if (!int.TryParse(txtStok.Text, out _))
            { MessageBox.Show("Geçerli bir stok miktarı girin."); return false; }
            if (cmbKategori.SelectedIndex < 0)
            { MessageBox.Show("Kategori seçin."); return false; }
            if (cmbBeden.SelectedIndex < 0)
            { MessageBox.Show("Beden seçin."); return false; }
            return true;
        }

        public void UrunSec(Gorsel_Programlama.Urun urun)
        {
            for (int i = 0; i < lstUrunler.Items.Count; i++)
                if (lstUrunler.Items[i] is Gorsel_Programlama.Urun u && u.Id == urun.Id)
                { lstUrunler.SelectedIndex = i; break; }
        }

        private void FormuTemizle()
        {
            txtAd.Clear(); txtFiyat.Clear(); txtStok.Clear();
            cmbKategori.SelectedIndex = -1;
            cmbBeden.SelectedIndex = -1;
            lstUrunler.ClearSelected();
            _seciliUrun = null;
        }
    }
}
