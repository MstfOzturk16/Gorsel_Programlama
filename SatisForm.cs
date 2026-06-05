using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gorsel_Programlama;

namespace FAVNGİYİM
{
    public partial class SatisForm : Form
    {
        private List<SepetItem> _sepet = new List<SepetItem>();

        public SatisForm()
        {
            InitializeComponent();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            SepetYenile();
            SiparisKuyruguYenile();
        }

        private void SepetYenile()
        {
            lstSepet.Items.Clear();
            decimal toplam = 0;

            var gruplar = new Dictionary<int, (Urun urun, int adet)>();
            foreach (var urun in VeriTabani.SiparisKuyrugu)
            {
                if (gruplar.ContainsKey(urun.Id))
                    gruplar[urun.Id] = (urun, gruplar[urun.Id].adet + 1);
                else
                    gruplar[urun.Id] = (urun, 1);
            }

            foreach (var kvp in gruplar.Values)
            {
                decimal satir = kvp.urun.Fiyat * kvp.adet;
                lstSepet.Items.Add($"{kvp.urun.Ad}  ×{kvp.adet}  =  {satir:C2}");
                toplam += satir;
            }

            lblToplam.Text = "Toplam: " + toplam.ToString("C2");
        }

        private void SiparisKuyruguYenile()
        {
            lstSiparisler.Items.Clear();
            foreach (var urun in VeriTabani.SiparisKuyrugu)
                lstSiparisler.Items.Add(urun.ToString());
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            if (VeriTabani.SiparisKuyrugu.Count == 0)
            {
                MessageBox.Show("Kuyrukta sipariş yok!", "Bilgi");
                return;
            }

            int islenendi = 0;
            while (VeriTabani.SiparisKuyrugu.Count > 0)
            {
                var urun = VeriTabani.SiparisKuyrugu.Dequeue();
                if (VeriTabani.StokDurumu.ContainsKey(urun.Id) && VeriTabani.StokDurumu[urun.Id] > 0)
                {
                    VeriTabani.StokDurumu[urun.Id]--;
                    var tumUrun = VeriTabani.TumUrunler.Find(u => u.Id == urun.Id);
                    if (tumUrun != null) tumUrun.Stok = VeriTabani.StokDurumu[urun.Id];
                    VeriTabani.IslemKaydet($"SATIŞ: {urun.Ad} satıldı. Kalan stok: {VeriTabani.StokDurumu[urun.Id]}");
                    islenendi++;
                }
                else
                {
                    VeriTabani.IslemKaydet($"İPTAL: {urun.Ad} stok yetersiz!");
                }
            }

            SiparisKuyruguYenile();
            MessageBox.Show($"{islenendi} sipariş işlendi.", "Kasa");
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
                SiparisKuyruguYenile();
        }
    }
}
