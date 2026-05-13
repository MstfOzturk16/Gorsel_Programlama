# FAVN Giyim Mağazası Uygulaması

**FAVN Giyim**, modern e-ticaret arayüzlerini ve karmaşık veri yapılarını simüle eden, C# ile geliştirilmiş bir Windows Forms uygulamasıdır. Proje ismi, ekip üyelerinin isimlerinden ilham alınarak oluşturulmuştur.

## Grup Üyeleri ve Görev Dağılımı
| Ad Soyad | Rol | Üstlenilen Modüller |
| :--- | :--- | :--- |
| **Mustafa Öztürk** | Grup Lideri | Proje koordinasyonu, GitHub yönetimi, CRUD işlemleri,Backend Geliştirici |
| **Nihad Gasimzade** | Arayüz Geliştirici | MainForm, UrunKarti tasarımı, filtreleme sistemleri |
| **Yusuf M. Karataş** | Veri yapıları (VeriTabani), JSON dosya yönetimi |
| **M. Furkan Yavuz** | Test & Entegrasyon | Birim testleri, UI-veri doğrulama |

## Kullanılan Veri Yapıları (Collections)
Projenin temel amacı, mühendislik yaklaşımlarıyla veri yönetimini simüle etmektir:
* **Queue (Kuyruk - FIFO):** Siparişlerin kasada işlenmek üzere sıraya alınması için kullanıldı.
* **Stack (Yığın - LIFO):** Yapılan satış işlemlerinin geçmişini tutmak ve "Geri Al" (Undo) mantığını sağlamak için kullanıldı.
* **Dictionary (Sözlük):** Ürün ID'leri üzerinden anlık stok takibi ve hızlı erişim için kullanıldı.
* **List:** Dinamik ürün listeleme ve CRUD operasyonları için ana veri yapısı olarak kullanıldı.

## Teknik Özellikler
* **UserControl Tasarımı:** Her ürün için yeniden kullanılabilir `UrunKarti` bileşeni geliştirildi.
* **Mouse Eventleri:** Kullanıcı deneyimi için `MouseEnter` ve `MouseLeave` hover efektleri uygulandı.
* **Dosya Yönetimi:** Verilerin kalıcılığı için JSON formatında dosya okuma/yazma sistemi entegre edildi.
* **OOP Prensipleri:** Nesne yönelimli programlama standartlarına uygun sınıf yapıları (`Urun`, `VeriTabani`, `DosyaYonetici`) oluşturuldu.

## Form Yapısı
1.  **MainForm:** Ürünlerin listelendiği ve kategori/beden filtrelerinin yapıldığı ana ekran.
2.  **UrunYonetimiForm:** Ürün ekleme, silme ve güncelleme işlemlerinin yapıldığı yönetim paneli.
3.  **SatisForm:** Sepet yönetimi ve sipariş kuyruğunun (Queue) izlendiği ekran.
4.  **IslemGecmisiForm:** Satış loglarının (Stack) görüntülendiği geçmiş ekranı.

---
