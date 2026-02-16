
Kütüphane Otomasyonu
Temel Özellikler
Rol Bazlı Erişim: Admin ve Üye için ayrı giriş, kayıt ve yetkilendirme sistemi.

Kitap Yönetimi: Kitap ekleme, barkod ve isimle arama, düzenleme, silme.

Kategori Yönetimi: Dinamik kitap türü ekleme ve güncelleme.

Ödünç İşlemleri: Kitap verme, iade alma ve teslim edilmeyen kitapların takibi.

Dışa Aktarım: Mevcut kitap listesini .csv formatında raporlama.

Medya Yönetimi: Kitaplara kapak fotoğrafı ekleme ve yerel dizinde saklama (\resimler\).

Teknik Altyapı
Dil & Çerçeve: C#, Windows Forms (.NET 8.0)

Veritabanı: SQLite (System.Data.SQLite v1.0.118)

Kurulum: Visual Studio Setup Project (.vdproj) entegrasyonu.

Kurulum ve Çalıştırma Adımları
Projeyi klonlayın ve Visual Studio'da KutuphaneOtomasyonu.sln dosyasını açın.

Solution Explorer üzerinden projeye sağ tıklayıp "Manage NuGet Packages" sekmesinden System.Data.SQLite paketinin kurulu olduğunu doğrulayın (veya Restore yapın).

Derleme (Build) işleminden önce, derleme dizininde (bin/Debug/net8.0-windows/ veya bin/Release/net8.0-windows/) aşağıdaki klasörlerin ve dosyaların bulunduğundan emin olun:

vt/kutuphane2024.db3 (Veritabanı dosyası)

resimler/ (Kitap kapak fotoğraflarının kaydedileceği klasör)

Uygulamayı başlatmak için F5 tuşuna basın.

Veritabanı Bağlantı Bilgisi
Uygulama içi varsayılan bağlantı dizesi aşağıdaki gibidir. Dosya yolunun proje kök dizini veya bin klasörü içinde doğru yapılandırıldığından emin olun:
Data Source=vt\kutuphane2024.db3;Version=3;
