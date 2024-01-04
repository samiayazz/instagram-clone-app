# Instagram Clone

<br>

## Dil Seçimi / Language Selection

[Türkçe](#türkçe) / [English](#english)

<br>

## Türkçe

> [!Note]
> Geliştirilme aşamasında.
> 
> Lütfen öneri ve tavsiyeleriniz için `issue` oluşturmaktan çekinmeyin.

<br>

Bu proje, .NET Core kullanılarak geliştirilen bir Instagram klonu uygulamasıdır. <br>
Uygulama, çeşitli modern teknolojileri kullanarak geliştirilmiş ve **Clean Architecture, TDD (Test Driven Development) ve CQRS prensiplerine dayalı olarak yapılandırılmıştır**. <br>

_Aşağıda uygulamada kullanılan teknolojiler ve mimari yaklaşımlarının özeti bulunmaktadır._

### Kullanılan Teknolojiler

- **Clean Architecture:** Proje, Clean Architecture prensiplerine göre yapılandırılmıştır.
- **TDD (Test Driven Development):** Geliştirme süreci test odaklı bir yaklaşımı benimser.
    - **xUnit:** Birim testleri için kullanılan test çerçevesi.
- **CQRS (Command Query Responsibility Segregation):** Komut ve sorgu sorumluluğu ayrımı ilkesiyle çalışan bir mimari
  kullanılmıştır.
    - **Write Db: PostgreSQL, Read Db: MongoDB:** Veri depolama için yazma işlemleri PostgreSQL, okuma işlemleri MongoDB
      kullanılmıştır.
    - **Entity Framework Core:** Write Db işlemleri için Entity Framework Core kullanılmıştır.
    - **ElasticSearch:** Arama işlemleri için ElasticSearch entegre edilmiştir.
    - **Redis:** Veri önbellekleme için Redis kullanılmıştır.
- **Güvenlik**
    - **Identity Framework:** Kimlik doğrulama ve yetkilendirme işlemleri için Identity Framework kullanılmıştır.
    - **JWT Security:** JSON Web Token tabanlı güvenlik sağlanmıştır.
- **Ekstra**
    - **FluentValidation:** Uygulama içinde doğrulama için kullanılmıştır.
    - **AutoMapper:** Nesne dönüşümleri için kullanılmıştır.
    - **Mediatr:** İstek/cevap mantığını bağımsızlaştırmak için Mediator deseni kullanılmıştır.

### Kurulum

Projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. PostgreSQL ve MongoDB veritabanlarını kurun ve yapılandırın.
2. Redis, ElasticSearch gibi servisleri kurun.
3. Proje dosyalarını klonlayın.
4. `appsettings.json` dosyasında gerekli ayarlamaları yapın.
5. Proje klasöründe terminali açın ve bağımlılıkları yüklemek için `dotnet restore` komutunu çalıştırın.
6. Uygulamayı başlatmak için `dotnet run` komutunu kullanın.

<br>

## English

> [!Note]
> Under development.
>
> Please feel free to create an `issue` for your suggestions and recommendations.

<br>

This project is an Instagram clone application developed using .NET Core. <br>
The application is structured based on various modern technologies and **follows the principles of Clean Architecture, TDD (Test Driven Development) and CQRS**. <br>

_Below is a summary of the technologies and architectural approaches used in the application._

### Technologies Used

- **Clean Architecture:** The project is structured according to Clean Architecture principles.
- **TDD (Test Driven Development):** The development process follows a test-driven approach.
    - **xUnit:** The testing framework used for unit testing.
- **CQRS (Command Query Responsibility Segregation):** An architecture that separates command and query responsibilities
  is used.
    - **Write Db: PostgreSQL, Read Db: MongoDB:** PostgreSQL for write operations and MongoDB for read operations are
      used for data storage.
    - **Entity Framework Core:** Used for Write Db operations.
    - **ElasticSearch:** ElasticSearch is integrated for search operations.
    - **Redis:** Redis is used for data caching.
- **Security**
    - **Identity Framework:** Identity Framework is utilized for authentication and authorization processes.
    - **JWT Security:** Security is provided using JSON Web Tokens.
- **Extras**
    - **FluentValidation:** Used for validation within the application.
    - **AutoMapper:** Utilized for object-to-object mapping.
    - **Mediatr:** Mediator pattern implementation for decoupling request/response logic.

### Installation

To run the project, follow these steps:

1. Install and configure PostgreSQL and MongoDB databases.
2. Set up services such as Redis, ElasticSearch, etc.
3. Clone the project files.
4. Configure necessary settings in the `appsettings.json` file.
5. Open the terminal in the project folder and run `dotnet restore` to install dependencies.
6. Start the application by using the command `dotnet run`.
