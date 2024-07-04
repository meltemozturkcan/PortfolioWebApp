 # Dinamik Admin Ve Yazar Panelli Portfolio Sitesi

Bu proje, ASP.NET Core 8.0 sürümü ile hazırlanmış dinamik bir admin ve yazar paneline sahip bir portfolyo projesidir. Proje, dinamik yapıya sahip bir Çok Katmanlı Mimari (N-Tier Architecture) ve admin ile yazar paneli içermektedir.


## Admin Panelinde;

- Veri tabanı tablolarında tüm dinamik CRUD işlemleri yapılabilmektedir. Yapılan işlemler eş zamanlı olarak portfolio sitesindeki görünüme yansır.

-  Gelen ve gönderilen mesajları inceleyebilme, mesaj gönderebilme ve okundu durumunu değiştirebilme özellikleri mevcuttur.

- Dashboard üzerindeki ToDo Listesi kullanımı ile görevleri yönetebilme ve tamamlanan işleri işaretleyebilme imkanı sağlanmaktadır.

- Admin Rol Ataması Sayesinde sadece rolü Admin olan kullanıcılar admin paneline giriş yapabilir.

- Admin üst menüden bildirimleri görebilir ve gelen mesajları görebilir

- Admin, Ajax ile Deneyim Sayfasında tüm veriler üzerinde ajax ile CRUD işlemlerini yapabilir

- Admin kendi panelinden, Yazar paneline ve Siteye giriş yapabilmektedir.

- Erişilemeyen sayfalar ve bulunamayan sayfalar için 404 ve 401 hata sayfaları mevcuttur.

## Yazar Panelinde;

- Kullanıcı işlemleri ile ad, şifre, profil resmi (dosya yükleme) gibi bilgileri güncelleyebilme imkanı sunulmaktadır.

- Site sahibine (admin) ve diğer yazarlara (kullanıcılar) e-posta gönderebilme ve site sahibinden gelen mesajları görüntüleyebilme özellikleri bulunmaktadır.

- Yazar Panelindeki Dashboard üzerinde  hava durumu göstergesi gibi bilgilere erişemk mümkündür.

- Yazar panelinde duyuru bildirim iconu bulunmaktadır

  ## Projemde Kulladığım Katmanlar:
  
📌 Business Layer

📌 Presentation(WebUI) Layer

📌 Entity Layer

📌 Data Access Layer

  ##   Proje kapsamında kullanılan paketler:
  
📌 Microsoft.Entity.FrameworkCore (8.0.5)

📌 Microsoft.Entity.FrameworkCore.Desing (8.0.5)

📌 Microsoft.Entity.FrameworkCore.SqlServer (8.0.5)

📌 Microsoft.Entity.FrameworkCore.Tools (8.0.5)

📌 Microsoft.AspNetCore.Identity(2.2.0)

📌 Microsoft.AspNetCore.Identity.EntityFrameworkCore(8.0.4)

📌FluentValidation.AspNetCore(11.3.0)

 ## Proje kapsamında kullanılan teknolojiler:
 
📌 ASP.NET Core 8.0

📌 Entity Framework Core

📌 Asp.Net Core Identity & Rolleme

📌 N Tier Architecture

📌 Ajax

📌 Fluent Validation

📌 Code First

📌 Repository Design Pattern

📌 Authentication & Authorization

📌 Code First / MSSQL
