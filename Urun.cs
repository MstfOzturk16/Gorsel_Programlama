using System;

namespace Gorsel_Programlama
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public string Kategori { get; set; }
        public string Beden { get; set; }

        public override string ToString()
        {
            return $"{Ad} - {Fiyat:C2} ({Kategori}, {Beden}) Stok: {Stok}";
        }
    }
}
