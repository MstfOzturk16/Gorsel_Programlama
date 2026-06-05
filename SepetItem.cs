namespace Gorsel_Programlama
{
    public class SepetItem
    {
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public decimal ToplamFiyat => Urun.Fiyat * Adet;

        public override string ToString()
        {
            return $"{Urun.Ad} x{Adet} = {ToplamFiyat:C2}";
        }
    }
}
