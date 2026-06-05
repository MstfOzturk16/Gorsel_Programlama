using System;
using System.Collections.Generic;

namespace Gorsel_Programlama
{
    public static class VeriTabani
    {
        public static List<Urun> TumUrunler = new List<Urun>();
        public static Dictionary<int, int> StokDurumu = new Dictionary<int, int>();
        public static Queue<Urun> SiparisKuyrugu = new Queue<Urun>();
        public static Stack<string> IslemGecmisi = new Stack<string>();

        public static void IslemKaydet(string mesaj)
        {
            IslemGecmisi.Push($"{DateTime.Now.ToShortTimeString()}: {mesaj}");
        }

        public static void UrunEkle(Urun urun)
        {
            TumUrunler.Add(urun);
            StokDurumu[urun.Id] = urun.Stok;
            IslemKaydet($"Ürün eklendi: {urun.Ad}");
        }

        public static void UrunSil(int id)
        {
            var urun = TumUrunler.Find(u => u.Id == id);
            if (urun != null)
            {
                TumUrunler.Remove(urun);
                StokDurumu.Remove(id);
                IslemKaydet($"Ürün silindi: {urun.Ad}");
            }
        }

        public static int YeniId()
        {
            int max = 0;
            foreach (var u in TumUrunler)
                if (u.Id > max) max = u.Id;
            return max + 1;
        }
    }
}
