# 🚗 MECH Otomobil - Araç Alım Satım Otomasyonu

Bu proje, C# Windows Forms ve **MongoDB** kullanılarak geliştirilmiş, galeri ve araç alım-satım işleri için tasarlanmış kapsamlı bir masaüstü otomasyon uygulamasıdır. Proje, NoSQL veritabanı yapısını ilişkisel bir mantıkla (Referans Yöntemi) simüle ederek veri tutarlılığını sağlar.

## 🛠️ Teknolojiler ve Yaklaşım

* **Dil:** C# (.NET Framework)
* **Veritabanı:** MongoDB (NoSQL)
* **Kütüphane:** MongoDB.Driver
* **Mimari Yaklaşım:** **Database First** (Önce veritabanı koleksiyonları MongoDB Compass üzerinde tasarlanmış, ardından C# tarafında Entity sınıfları bu yapıya uygun olarak `[BsonElement]` nitelikleriyle eşleştirilmiştir).

## 📂 Proje Dosya Yapısı

Proje, kod okunabilirliğini artırmak ve yönetilebilirliği sağlamak için katmanlı bir klasör yapısına sahiptir:

* **`Entities/`**: Veritabanındaki koleksiyonların C# tarafındaki karşılıklarıdır (POCO sınıfları).
  * `Arabalar.cs`: Araç bilgilerini tutar.
  * `Marka.cs` & `Model.cs`: Araç marka ve modellerini ilişkisel `ObjectId` ile yönetir.
* **`Services/`**: Veritabanı bağlantı kodları ve CRUD işlemlerini yürüten sınıflar.
  * `MongoDBConnections.cs`: Singleton veya static bağlantı yapılandırması.
  * `ArabaOperations.cs`: Veri ekleme, silme, güncelleme mantıkları.
* **`Forms/`**: Kullanıcı arayüzleri.
  * `AnaEkran.cs`: Tüm işlemlerin yapıldığı ana dashboard.
  * `SonucFormu.cs`: Filtreleme sonuçlarının listelendiği ekran.

## ✨ Özellikler

* **İlişkisel Veri Yönetimi:** Marka ve Model seçimi, MongoDB içinde `ObjectId` referanslarıyla birbirine bağlanmıştır. Marka seçildiğinde sadece o markaya ait modeller listelenir.
* **CRUD İşlemleri:** Araç Ekleme, Silme, Güncelleme ve Listeleme fonksiyonları.
* **Gelişmiş Filtreleme:** Minimum ve Maksimum fiyat aralığına göre araçları `Search` (Bul) fonksiyonu ile filtreleme.
* **Plaka Sorgulama:** Araç plakasına göre veritabanından anlık sorgulama yapma ve verileri ilgili alanlara getirme.
* **Hızlı Düzenleme (Context Menu):** DataGridView üzerinde sağ tıklayarak araç bilgilerini otomatik olarak düzenleme kutucuklarına aktarma.

## 📚 Teşekkür ve Referanslar

Bu proje geliştirilirken **Murat Yücedağ**'ın YouTube üzerindeki **C# Eğitim Kampı** oynatma listesinden yararlanılmış ve eğitim içeriğindeki prensipler MongoDB yapısına uyarlanarak uygulanmıştır.

## 🚀 Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone [https://github.com/mertharmandarli/Araba-Otomasyonu-App.git](https://github.com/mertharmandarli/Araba-Otomasyonu-App.git)
2. Bilgisayarınızda MongoDB'nin kurulu olduğundan emin olun.
3. MongoDB Compass kullanarak Araba_Al_Sat_MongoDBCalisma adında bir veritabanı oluşturun.
4. Visual Studio'da projeyi açın ve NuGet paketlerini yükleyin (MongoDB.Driver).
5. Projeyi çalıştırın.

🇺🇸 English README
🚗 MECH Automobile - Car Trading Automation
This project is a comprehensive desktop automation application designed for car dealerships and trading, developed using C# Windows Forms and MongoDB. The project simulates a relational logic (Reference Method) within a NoSQL database structure to ensure data consistency.

🛠️ Technologies & Approach
Language: C# (.NET Framework)

Database: MongoDB (NoSQL)

Library: MongoDB.Driver

Architectural Approach: Database First (Database collections were first designed in MongoDB Compass, then Entity classes in C# were mapped to this structure using [BsonElement] attributes).

📂 Project File Structure
The project follows a layered folder structure to enhance code readability and manageability:

Entities/: Represents the C# counterparts of database collections (POCO classes).

Arabalar.cs: Holds vehicle information.

Marka.cs & Model.cs: Manages vehicle brands and models relationally using ObjectId.

Services/: Classes handling database connections and CRUD operations.

MongoDBConnections.cs: Connection configuration.

ArabaOperations.cs: Logic for adding, deleting, and updating data.

Forms/: User Interfaces.

AnaEkran.cs: Main dashboard where all operations take place.

SonucFormu.cs: Screen listing the filtering results.

✨ Features
Relational Data Management: Brand and Model selections are linked via ObjectId references within MongoDB. Selecting a brand lists only the models belonging to that brand.

CRUD Operations: Create, Read, Update, and Delete vehicles.

Advanced Filtering: Filter vehicles by Minimum and Maximum price ranges using the Search function.

License Plate Query: Instantly query the database by vehicle license plate and populate the fields.

Quick Edit (Context Menu): Right-click on the DataGridView to automatically transfer vehicle details to input fields for editing.

📚 Acknowledgements & References
This project was developed utilizing Murat Yücedağ's C# Education Camp playlist on YouTube. The principles from the educational content were adapted and applied to the MongoDB structure within this project.

🚀 Installation
Clone the repository:


1. Projeyi Kopyalayın
git clone [https://github.com/mertharmandarli/Araba-Otomasyonu-App.git](https://github.com/mertharmandarli/Araba-Otomasyonu-App.git)

3. Ensure MongoDB is installed on your machine.

2. Create a database named Araba_Al_Sat_MongoDBCalisma using MongoDB Compass.

3. Open the project in Visual Studio and restore NuGet packages (MongoDB.Driver).

4. Run the project.
