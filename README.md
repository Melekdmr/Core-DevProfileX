## 🚀 ASP.NET Core 8.0 Tabanlı Çok Kullanıcılı Blog & Portfolyo Yönetim Paneli

Bu proje, ASP.NET Core 8.0 teknolojisiyle geliştirilmiş, çok katmanlı mimariye sahip (N-Tier Architecture) bir kişisel portfolyo ve içerik yönetim sistemidir. Projede, hem site sahibinin içeriklerini yönetebileceği bir admin paneli, hem de içerik üretecek kullanıcılar (yazarlar) için ayrı bir yazar paneli bulunmaktadır.

#  Projenin Genel Özellikleri
# 👨‍💼 Admin Paneli Detayları
- Tam Yetkili Veri Yönetimi: Tüm içerikler (deneyim, hizmet, referans, blog, istatistik vs.) üzerinde Ekleme, Güncelleme, Silme işlemleri yapılabilir.

- Ajax Destekli CRUD: Özellikle Deneyim yönetiminde, sayfa yenilenmeden Ajax ile tüm işlemler gerçekleştirilebilir.

- İstatistik Takibi: Admin dashboard’da sistem genelindeki sayılar (toplam hizmet, gelen mesaj, yazar sayısı vs.) grafik ve kartlarla gösterilir.

- Mesaj Yönetim Sistemi: Kullanıcı veya yazarlardan gelen mesajları görüntüleme, cevaplama, silme ve okundu işaretleme işlemleri yapılabilir.

- ToDo List: Admin paneline özel görev listesi özelliği vardır. Yapılacak işler eklenebilir, tamamlandığında işaretlenebilir veya silinebilir.

- Rol Bazlı Giriş: Sadece "Admin" rolüne sahip kullanıcılar admin paneline giriş yapabilir. Diğer kullanıcılar yetkisiz sayfasına yönlendirilir.

- Bildirim ve Mesaj Uyarıları: Panel üst kısmında gelen mesaj ve sistem bildirimlerini gösteren simgeler bulunur.

- Panel Geçişleri: Admin, tek tıklamayla yazar paneline veya ana siteye geçiş yapabilir.

- 404 & 401 Hata Sayfaları: Yetkisiz erişim veya bulunamayan sayfalar için özel hazırlanmış kullanıcı dostu hata sayfaları mevcuttur.

# ✍️ Yazar Paneli Detayları
- Profil Güncelleme: Yazarlar kendi adını, şifresini ve profil fotoğrafını (resim yükleme ile) düzenleyebilir.

 - Mesajlaşma Sistemi: Yazarlara site sahibi (admin) tarafından mesaj gönderilebilir. Yazarlar da diğer yazarlara veya admin'e mesaj gönderebilir.

- İstatistik Paneli: Kullanıcıya özel yazdığı içerikler, aldığı mesaj sayısı gibi bilgiler özet halinde gösterilir.

- Hava Durumu Göstergesi: Dashboard’da yaşanılan şehrin anlık hava durumu verisi gösterilir (API üzerinden çekilerek).

- Bildirim Sistemi: Panelde, kullanıcıya gönderilen sistem duyurularını gösteren bir bildirim simgesi yer alır.

- Rol Tabanlı Yetkilendirme: Yazar paneline sadece “Yazar” rolündeki kullanıcılar erişebilir.

# 🛢️ Kullanılan Katmanlar
- Entity Layer: Veritabanı tablolarına karşılık gelen sınıfların yer aldığı katman.

- Data Access Layer (DAL): Veritabanı işlemlerinin gerçekleştirildiği katman (EF Core Repository Pattern ile).

- Business Layer: Tüm iş kuralları ve servis işlemleri bu katmanda yer alır.

- Presentation Layer (WebUI): Kullanıcı arayüzü (admin/yazar/sitedışı sayfalar).

- API Layer: Geliştirilen servislerin dış sistemlerle paylaşımı için RESTful API yapısı oluşturulmuştur.

 # 📦 Projede Kullanılan NuGet Paketleri ve Sürümleri:
 
- Microsoft.EntityFrameworkCore – 9.0.1

- Microsoft.EntityFrameworkCore.SqlServer – 9.0.1

- Microsoft.EntityFrameworkCore.Tools – 9.0.1

- Microsoft.EntityFrameworkCore.Design – 9.0.1

- Microsoft.AspNetCore.Identity – 2.3.0

- Microsoft.AspNetCore.Identity.EntityFrameworkCore – 8.0.0

- FluentValidation.AspNetCore – 11.3.0

# 🛠️ Kullanılan Teknolojiler

- ASP.NET Core 8.0

- Entity Framework Core (Code First)

- ASP.NET Identity & Rol yönetimi

- Ajax işlemleri
- RESTful API

- FluentValidation

- Swagger & Postman ile API testi

- MSSQL Server

- Linq sorguları
 
- N Tier Architecture

- Repository Design Pattern

- Authentication & Authorization



