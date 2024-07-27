# .Net MenuProject

**dotNetMenuProject**, ASP.NET Core 6.0 MVC kullanarak hazırladığımız kapsamlı bir web uygulamasıdır. Kullanıcılar, rezervasyon yapabilir, sipariş verebilir, menüyü görüntüleyebilir ve mesaj gönderebilir. Yönetici paneli kullanarak ürün ekleme, silme, güncelleme ve kategori yönetimi gibi CRUD işlemlerini yapabilirsiniz. Ayrıca, Rapid API kullanarak projede Instagram bilgilerini, hava durumu verilerini ve döviz kuru bilgilerini API’ler aracılığıyla görüntüleyebilirsiniz.

**Projede Kullandığım Teknolojiler:**
- ASP.NET Core 6.0 MVC
- Entity Framework Core
- LINQ
- PostgreSQL
- Instagram API
- Hava Durumu API
- Döviz Kuru API

## Çalıştırma Talimatları

### Gereksinimler
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) veya üzeri
- [PostgreSQL](https://www.postgresql.org/download/) veritabanı sunucusu
- [RapidAPI](https://rapidapi.com/) hesabı ve gerekli API anahtarları

### Kurulum

1. **Depoyu Klonlayın**

   ```bash
   git clone https://github.com/kullaniciadi/dotNetMenuProject.git
   
2.	**Proje Dizini İçine Girin**

  ```bash
  cd dotNetMenuProject
```
3.	**Bağımlılıkları Yükleyin**
 ```bash
   dotnet restore
```
4.	**Veritabanını Uygulayın**
   •	PostgreSQL veritabanınızı oluşturun ve bağlantı dizesini yapılandırma dosyanıza ekleyin. Context dosyasındaki [optionsBuilder.UseNpgsql](https://github.com/enesaks/dotNetMenuProject/blob/main/dotNetMenuProject/Context/MenuContext.cs) kısmını uygun veritabanı bağlantı dizesi ile güncelleyin.
  	
5.	**Veritabanı Göçlerini Uygulayın**
 ```bash
   dotnet ef database update
```

6.	**API Anahtarları**
  •	[Controller/ApiController](https://github.com/enesaks/dotNetMenuProject/blob/main/dotNetMenuProject/Controllers/ApiController.cs) dosyasındaki API anahtarlarını ve diğer yapılandırma bilgilerini güncelleyin. RapidAPI’den aldığınız API anahtarlarını ilgili kısımlara ekleyin.

Bu talimatları takip ederek projeyi kolaylıkla çalıştırabilirsiniz.

**Proje Ressimleri**
<img width="1470" alt="Ekran Resmi 2024-07-27 15 32 23" src="https://github.com/user-attachments/assets/0fb2ae99-ccdb-46b9-b6d6-49818b07e5e0">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 31 44" src="https://github.com/user-attachments/assets/3f166e5a-b679-4fc8-9f4c-9d2329badf21">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 32 34" src="https://github.com/user-attachments/assets/45c5ad86-7166-43be-b798-b63486825d4f">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 32 43" src="https://github.com/user-attachments/assets/78f7e78a-43e4-4f52-92d1-de12952fe339">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 32 58" src="https://github.com/user-attachments/assets/62b072ec-011d-463b-840f-1f74d7ad0d4d">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 33 05" src="https://github.com/user-attachments/assets/3fc50df1-3dde-432d-8294-07628bef5c27">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 33 15" src="https://github.com/user-attachments/assets/d885fffe-9421-4674-948e-054899e0d840">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 33 25" src="https://github.com/user-attachments/assets/140efbc4-d4f1-4439-b95b-5ec41bc6b889">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 33 36" src="https://github.com/user-attachments/assets/afe7ffc2-9bc7-4270-a71c-d93f85b410c0">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 34 04" src="https://github.com/user-attachments/assets/59594f8f-76ba-47e8-be3d-294eaaad9014">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 34 12" src="https://github.com/user-attachments/assets/ce451f83-6770-4b8c-8bdc-bf4f233063f1">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 34 24" src="https://github.com/user-attachments/assets/424e475e-fcdc-4d05-89e3-31fc5f3ba51c">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 34 36" src="https://github.com/user-attachments/assets/958d0993-8bfa-4b2b-a5ad-3b4fe14ccb44">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 34 47" src="https://github.com/user-attachments/assets/9765263a-28d0-4221-b462-cc1cd64f3a7a">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 35 01" src="https://github.com/user-attachments/assets/9951d0d5-d1fe-41b3-ba87-a576fbc93025">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 35 15" src="https://github.com/user-attachments/assets/1637f475-2407-4f99-b65e-822bbbd838c4">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 35 24" src="https://github.com/user-attachments/assets/1fcc7de9-ed4b-4641-a646-3768ca3d737e">
<img width="1470" alt="Ekran Resmi 2024-07-27 15 35 33" src="https://github.com/user-attachments/assets/5c5e2f6b-4047-43c9-b27a-e4509e7356de">

