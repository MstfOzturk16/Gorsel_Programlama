using System;
using System.Windows.Forms;
using Gorsel_Programlama; // Diğer sınıfları görmesi için şart

namespace FAVNGİYİM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (VeriTabani.TumUrunler.Count == 0)
            {
                // 1. Ürünleri List'e ekle
                VeriTabani.TumUrunler.Add(new Urun { Id = 1, Ad = "Mavi Tişört", Fiyat = 250, Stok = 20 });
                VeriTabani.TumUrunler.Add(new Urun { Id = 2, Ad = "Keten Pantolon", Fiyat = 450, Stok = 15 });
                VeriTabani.TumUrunler.Add(new Urun { Id = 3, Ad = "Deri Ceket", Fiyat = 1200, Stok = 5 });

                // 2. Ürünlerin başlangıç stoklarını Dictionary'e (Hızlı Arama) ekle
                // Key: Ürün Id, Value: Stok Adedi
                VeriTabani.StokDurumu.Add(1, 20);
                VeriTabani.StokDurumu.Add(2, 15);
                VeriTabani.StokDurumu.Add(3, 5);
            }

            UrunleriListele();
        }

        // Eksik olan metot gövdesi burası:
        public void UrunleriListele()
        {
            // Tasarımda FlowLayoutPanel ismini flpUrunler yapmayı unutma!
            if (flpUrunler != null)
            {
                flpUrunler.Controls.Clear();
                foreach (var urun in VeriTabani.TumUrunler)
                {
                    UrunKarti kart = new UrunKarti();
                    kart.BilgileriYukle(urun);
                    flpUrunler.Controls.Add(kart);
                }
            }
        }

        private void flpUrunler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiparisleriIsle_Click(object sender, EventArgs e)
        {
            // Kuyrukta sipariş var mı kontrol et
            if (VeriTabani.SiparisKuyrugu.Count == 0)
            {
                MessageBox.Show("Sırada bekleyen sipariş yok!", "Kasa Boş");
                return;
            }

            int islenenSiparisSayisi = 0;

            // Kuyruk bitene kadar (FIFO - İlk Giren İlk Çıkar mantığıyla) dön
            while (VeriTabani.SiparisKuyrugu.Count > 0)
            {
                // 1. Sıradaki ürünü kuyruktan çıkar (Dequeue)
                Urun siradakiUrun = VeriTabani.SiparisKuyrugu.Dequeue();

                // 2. Dictionary üzerinden stok kontrolü yap
                if (VeriTabani.StokDurumu.ContainsKey(siradakiUrun.Id) && VeriTabani.StokDurumu[siradakiUrun.Id] > 0)
                {
                    // Stoğu 1 azalt
                    VeriTabani.StokDurumu[siradakiUrun.Id]--;

                    // İşlemi Yığına (Stack - Son Giren İlk Çıkar) kaydet
                    VeriTabani.IslemKaydet($"SATIŞ ONAYLANDI: {siradakiUrun.Ad} satıldı. Kalan Stok: {VeriTabani.StokDurumu[siradakiUrun.Id]}");
                    islenenSiparisSayisi++;
                }
                else
                {
                    VeriTabani.IslemKaydet($"İPTAL: {siradakiUrun.Ad} için stok yetersiz!");
                }
            }

            MessageBox.Show($"{islenenSiparisSayisi} adet sipariş başarıyla işlendi ve stoktan düşüldü!", "İşlem Tamam");
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            // Önce listeyi temizle (üst üste binmesin diye)
            lstGecmis.Items.Clear();

            // Stack (Yığın) koleksiyonu LIFO mantığıyla çalıştığı için
            // foreach döngüsü otomatik olarak "en son eklenen" kayıttan başlar.
            foreach (string islem in VeriTabani.IslemGecmisi)
            {
                lstGecmis.Items.Add(islem);
            }

            // Opsiyonel: Hoca görsün diye küçük bir uyarı
            MessageBox.Show("İşlem geçmişi Yığın (Stack) üzerinden LIFO mantığıyla başarıyla çekildi!", "Veri Çekildi");
        }
    }
}