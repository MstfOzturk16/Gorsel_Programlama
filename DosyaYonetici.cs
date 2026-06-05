using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace Gorsel_Programlama
{
    public static class DosyaYonetici
    {
        private static readonly string DosyaYolu = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "urunler.json");

        public static void Kaydet()
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(VeriTabani.TumUrunler);
                File.WriteAllText(DosyaYolu, json);
                VeriTabani.IslemKaydet("Veriler JSON'a kaydedildi.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Kayıt hatası: " + ex.Message);
            }
        }

        public static void Yukle()
        {
            try
            {
                if (!File.Exists(DosyaYolu)) return;

                string json = File.ReadAllText(DosyaYolu);
                var serializer = new JavaScriptSerializer();
                var liste = serializer.Deserialize<List<Urun>>(json);

                VeriTabani.TumUrunler.Clear();
                VeriTabani.StokDurumu.Clear();

                foreach (var urun in liste)
                {
                    VeriTabani.TumUrunler.Add(urun);
                    VeriTabani.StokDurumu[urun.Id] = urun.Stok;
                }

                VeriTabani.IslemKaydet("Veriler JSON'dan yüklendi.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Yükleme hatası: " + ex.Message);
            }
        }
    }
}
