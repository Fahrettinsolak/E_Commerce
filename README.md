# E-Ticaret Mikroservis Projesi


## İçindekiler
- [Genel Bakış](#genel-bakış)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Mimari](#mimari)
- [Kurulum](#kurulum)
- [Özellikler](#özellikler)
- [API Dokümantasyonu](#api-dokümantasyonu)
- [Lisans](#lisans)

---

## Genel Bakış

Bu **E-Ticaret Mikroservis Projesi**, modern teknolojiler kullanılarak oluşturulmuş, ölçeklenebilir ve sürdürülebilir uygulamalar için sağlam bir mimariyi ortaya koyan kapsamlı bir sistemdir. Proje, **CQRS**, **Onion Architecture** ve **Repository Design Pattern** gibi en iyi uygulamaları hayata geçirirken, **Docker**, **Redis**, **MongoDB** ve **PostgreSQL** gibi güçlü araçlardan faydalanmaktadır.

Proje, **Google Drive ile entegre fotoğraf yükleme**, **JWT tabanlı kimlik doğrulama ve yetkilendirme** sağlamakta ve **SignalR** ile gerçek zamanlı iletişim imkanı sunmaktadır.

## Kullanılan Teknolojiler

### Backend
- **Asp.Net Core**: API servislerinin temelini oluşturur.
- **Dapper**: Veritabanı etkileşimleri için hafif ORM.
- **Redis**: Performansı artırmak için cache mekanizması.
- **MongoDB**: Yapılandırılmamış verileri yönetmek için NoSQL veritabanı.
- **PostgreSQL**, **MSSQL**, **SQLite**: Yapılandırılmış veriler için ilişkisel veritabanları.
- **Identity Server**: Kimlik doğrulama ve yetkilendirme yönetimi.
- **Ocelot Gateway**: Mikroservisler arası routing ve yönetim için API Gateway.
- **CQRS**: Okuma ve yazma işlemlerini ayırır.
- **Mediator Design Pattern**: Servisler arasında temiz iletişim sağlamak için.
- **Repository Design Pattern**: İş mantığı ve veritabanı işlemlerini soyutlamak için.
- **JWT**: JWT tabanlı kimlik doğrulama ile API uç noktalarının güvenliği.
- **SignalR**: Gerçek zamanlı veri akışı için.
  
### DevOps
- **Docker**: Kolay dağıtım ve ortam tutarlılığı için konteynerleştirme.
- **Swagger**: API dokümantasyonu ve test arayüzü.
- **Postman**: API testleri ve geliştirme aracı.

### Diğer
- **Google Drive API**: Fotoğraf yüklemeleri için kullanılır.
- **Ajax**: Frontend'den asenkron istekler için.
- **Rapid API**: Harici API tüketimi.

## Mimari

Sistem, katmanlar arası bağımsızlığı sağlamak amacıyla **Onion Architecture** mimarisini takip etmektedir.

- **API Gateway**: İstemci ve servisler arasındaki iletişimi Ocelot ile yönetir.
- **Mikroservisler**: Kullanıcı yönetimi, sipariş işleme, ürün yönetimi gibi sistemin belirli parçalarını ele alan servisler.
- **Veritabanı Katmanı**: Servis ihtiyaçlarına göre **SQL** ve **NoSQL** veritabanları kullanılır.
- **Cache**: Sıkça talep edilen veriler için **Redis** kullanılarak yanıt süreleri iyileştirilir.
- **Güvenlik**: **Identity Server** ve **JWT Bearer Token** kullanılarak güvenlik sağlanır.

### CQRS Uygulaması

Proje, okuma ve yazma işlemlerini ayırmak için **CQRS (Command Query Responsibility Segregation)** desenini kullanır. Bu yaklaşım, ölçeklenebilirliği artırır ve karmaşık iş mantığını daha kolay yönetilebilir hale getirir.

### Mediator Pattern

**Mediator** deseni ile sistem, isteklerin iş mantığından ayrılmasını sağlar, bu da sistemi daha modüler ve sürdürülebilir hale getirir.

## Kurulum

### Gereksinimler
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [PostgreSQL](https://www.postgresql.org/download/)
- [MongoDB](https://www.mongodb.com/try/download/community)

### Yükleme

1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/Fahrettinsolak/E_Commerce.git

2. Proje dizinine gidin:
   ```bash
   cd E_Commerce

3. Docker konteynerlerini oluşturup çalıştırın:
   ```bash
   docker-compose up --build
   
4. Veritabanı migrasyonlarını uygulayın:
   ```bash
   dotnet ef database update
   
5. Uygulama http://localhost:5000 adresinde çalışır durumda olacaktır.

### Ortam Değişkenleri

Projeyi çalıştırmadan önce aşağıdaki **ortam değişkenlerinin** yapılandırıldığından emin olun:

- **DB_CONNECTION_STRING**: PostgreSQL veya MSSQL için bağlantı dizesi.
- **MONGO_CONNECTION_STRING**: MongoDB bağlantı dizesi.
- **REDIS_CONNECTION_STRING**: Redis bağlantı dizesi.
- **GOOGLE_DRIVE_API_KEY**: Google Drive entegrasyonu için API anahtarı.

## Özellikler

- **Kimlik Doğrulama ve Yetkilendirme**: JWT ve Identity Server kullanarak güvenli kimlik doğrulama.
- **Fotoğraf Yükleme**: Sisteme doğrudan Google Drive'a fotoğraf yükleyebilme.
- **Gerçek Zamanlı Bildirimler**: SignalR kullanarak gerçek zamanlı güncellemeler.
- **API Gateway**: Ocelot ile merkezi routing.
- **Postman Koleksiyonu**: Kolay test için önceden yapılandırılmış Postman istekleri.
- **Swagger Entegrasyonu**: API için otomatik oluşturulan dokümantasyon.

## API Dokümantasyonu

API dokümantasyonu Swagger ile sunulmaktadır. Uygulama çalıştırıldıktan sonra aşağıdaki URL üzerinden Swagger arayüzüne ulaşabilirsiniz:

- [Swagger](http://localhost:5000/swagger)
