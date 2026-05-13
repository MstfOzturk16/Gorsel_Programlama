using System;
using System.Collections.Generic;

namespace Gorsel_Programlama
{
    public static class VeriTabani
    {
        // 1. List: Ana liste
        public static List<Urun> TumUrunler = new List<Urun>();

        // 2. Dictionary: Hızlı stok kontrolü
        public static Dictionary<int, int> StokDurumu = new Dictionary<int, int>();

        // 3. Queue: Sipariş sırası (FIFO)
        public static Queue<Urun> SiparisKuyrugu = new Queue<Urun>();

        // 4. Stack: İşlem geçmişi (LIFO)
        public static Stack<string> IslemGecmisi = new Stack<string>();

        public static void IslemKaydet(string mesaj)
        {
            IslemGecmisi.Push($"{DateTime.Now.ToShortTimeString()}: {mesaj}");
        }
    }
}