using Gorsel_Programlama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAVNGİYİM
{
    public partial class UrunKarti : UserControl
    {
        // Karta bağlanan ürünü hafızada tutar
        public Urun BagliUrun { get; set; }

        public UrunKarti()
        {
            InitializeComponent();
        }

        // Dışarıdan gelen ürün verilerini etiketlere (Label) yazar
        public void BilgileriYukle(Urun urun)
        {
            this.BagliUrun = urun;
            lblAd.Text = urun.Ad;
            lblFiyat.Text = urun.Fiyat.ToString("C2");
        }

        // Satın al butonuna basıldığında çalışacak metot
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (BagliUrun != null)
            {
                // KUYRUK (Queue) Kullanımı
                VeriTabani.SiparisKuyrugu.Enqueue(BagliUrun);

                // YIĞIN (Stack) Kullanımı
                VeriTabani.IslemKaydet($"{BagliUrun.Ad} sipariş kuyruğuna eklendi.");

                MessageBox.Show($"{BagliUrun.Ad} başarıyla sıraya alındı!");
            }
        }

        private void btnSatinAl_Click_1(object sender, EventArgs e)
        {
            if (BagliUrun != null)
            {
                // KUYRUK (Queue) Kullanımı
                VeriTabani.SiparisKuyrugu.Enqueue(BagliUrun);

                // YIĞIN (Stack) Kullanımı
                VeriTabani.IslemKaydet($"{BagliUrun.Ad} sipariş kuyruğuna eklendi.");

                MessageBox.Show($"{BagliUrun.Ad} başarıyla sıraya alındı!");
            }
        }
    }
}