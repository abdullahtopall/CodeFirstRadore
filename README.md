# CodeFirstRadore

Bu proje, Code First yaklaşımı kullanılarak ASP.NET Core ile birlikte bir blog sitesi oluşturmayı amaçlamaktadır. Proje, Radore Hosting tarafından düzenlenen ASP.NET Core Bootcamp eğitimi kapsamında geliştirilmiştir.

## Proje Yapısı

Proje, aşağıdaki katmanlardan oluşmaktadır:

- **CodeFirstRadore.WebUI:** ASP.NET Core web uygulaması
- **CodeFirstRadore.Business:** İş mantığı katmanı
- **CodeFirstRadore.DataAccess:** Veri erişim katmanı
- **CodeFirstRadore.Entities:** Veritabanı nesneleri

## Kullanılan Teknolojiler

Proje, aşağıdaki teknolojileri kullanmaktadır:

- ASP.NET Core 3.1
- Entity Framework Core 3.1
- Microsoft SQL Server
- Bootstrap 4

## Kurulum

Proje dosyalarını indirdikten sonra, aşağıdaki adımları takip ederek projeyi çalıştırabilirsiniz:

1. `appsettings.json` dosyasındaki `DefaultConnection` ayarını kendi veritabanı bağlantı dizesinize göre güncelleyin.
2. Visual Studio'da `CodeFirstRadore.WebUI` projesini açın.
3. Package Manager Console'u açın ve `Update-Database` komutunu çalıştırın. Bu, veritabanı tablolarını oluşturacaktır.
4. Projeyi çalıştırın.

## Lisans

Bu proje MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakabilirsiniz.
