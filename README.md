# FAVN — Modern Giyim Mağazası Yönetim Sistemi

**FAVN**, bir giyim mağazasının ürün yönetimi, sipariş takibi ve satış işlemlerini simüle eden C# Windows Forms masaüstü uygulamasıdır. Proje ismi ekip üyelerinin isimlerinden ilham alınarak oluşturulmuştur.

---

## Ekip & Görev Dağılımı

| Ad Soyad | Rol | Üstlenilen Modüller |
| :--- | :--- | :--- |
| **Mustafa Öztürk** | Grup Lideri & Backend | Veri yapıları (VeriTabani), JSON kalıcılığı (DosyaYonetici), Form1 mantığı (filtreleme, arama, sıralama), mimari tasarım |
| **Nihad Gasimzade** | Arayüz Geliştirici | Form1 tasarımı (header, filtre paneli), UrunKarti (özel çizim, gradient, hover efekti) |
| **M. Furkan Yavuz** | Test & Dokümantasyon | Program.cs, test senaryoları, proje raporu hazırlığı |
| **Yusuf M. Karataş** | Form Geliştirici | UrunYonetimiForm, SatisForm, IslemGecmisiForm |

---

## Kullanılan Veri Yapıları

| Koleksiyon | Tür | Kullanım Amacı |
| :--- | :--- | :--- |
| **TumUrunler** | `List<Urun>` | Tüm ürünlerin tutulduğu ana liste; filtreleme ve sıralama burada yapılır |
| **StokDurumu** | `Dictionary<int, int>` | Ürün Id'sine göre anlık stok takibi; O(1) hızında erişim |
| **SiparisKuyrugu** | `Queue<Urun>` | FIFO sipariş sırası; kasada Dequeue ile işlenir |
| **IslemGecmisi** | `Stack<string>` | LIFO işlem kaydı; Undo (geri al) mekanizması için kullanılır |

---

## Özellikler

- 12 ürünlük giyim kataloğu — kategori, beden, fiyat ve stok bilgileriyle
- Gerçek zamanlı arama (her tuşa basışta anlık filtreleme)
- Kategori filtresi: Üst Giyim, Alt Giyim, Aksesuar
- Beden filtresi: S, M, L, XL
- Fiyat artan/azalan ve isim A→Z sıralama
- Sepete ürün ekleme ve FIFO sipariş kuyruğu yönetimi
- Ürün ekleme, güncelleme ve silme (CRUD)
- LIFO işlem geçmişi ve Undo (geri alma) mekanizması
- Sağ tık context menüsü ile hızlı düzenle/sil
- Boş ekran paneli (filtre sonuç vermediğinde)
- Kapanışta JSON'a otomatik kayıt, açılışta yükleme

---

## Form Yapısı

| Form | Açıklama |
| :--- | :--- |
| **Form1** | Ana ekran — ürün kartları, arama, filtre paneli, sıralama |
| **UrunKarti** | Özel çizimli ürün kartı — gradient, hover efekti, badge'ler |
| **UrunYonetimiForm** | Ürün yönetim paneli — ekle, güncelle, sil |
| **SatisForm** | Sepet ve sipariş işleme — Queue görüntüleme, kasa onayı |
| **IslemGecmisiForm** | İşlem geçmişi — Stack LIFO listesi, Undo ve Temizle |

---

## Teknik Detaylar

- **Dil / Platform:** C# · .NET Framework 4.7.2 · Windows Forms
- **IDE:** Visual Studio 2022
- **Veri Kalıcılığı:** JSON dosyası (`JavaScriptSerializer`)
- **Özel Çizim:** `UrunKarti` sınıfı `Control.OnPaint` override edilerek tamamen manuel çizildi
- **Formlar Arası İletişim:** `Form1` referansı constructor ile geçirilerek sağlandı

---

## Proje Raporu

Proje raporu `FAVN_Proje_Raporu.docx` dosyasında mevcuttur.  
İçerik: Proje tanıtımı, veri yapıları açıklaması, Use-Case modeller, Use-Case diyagramı, Class diyagramı.
