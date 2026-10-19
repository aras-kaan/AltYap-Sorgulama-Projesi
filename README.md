Altyapı Sorgulama Uygulaması (Internet Infrastructure Query App)

Bu proje, C# ve Windows Forms (.NET Framework 4.7.2) kullanılarak geliştirilmiş kademeli bir İnternet Altyapı Sorgulama masaüstü uygulamasıdır.

Kullanıcılar sırasıyla İl, İlçe, Mahalle, Sokak/Cadde ve Apartman No seçimleri yaparak, ilgili adrese ait mevcut internet altyapı türlerini (Fiber, VDSL, ADSL vb.) ve sunulan maksimum hızları görüntüleyebilirler.

🚀 Özellikler

Kademeli (Cascading) Seçim Alanları: ComboBox bileşenleri birbiriyle ilişkili şekilde çalışır. İl seçildikten sonra ilçeler, ilçe seçildikten sonra mahalleler dinamik olarak filtrelenir.

Detaylı Adres Katmanı: İl -> İlçe -> Mahalle -> Sokak -> Apartman sırasıyla tam adres sorgulaması.

Altyapı Listeleme: Seçilen apartmana/adrese tanımlı internet servis sağlayıcıları ve hız seçenekleri ListBox üzerinde listelenir.

Nesne Yönelimli Mimari (OOP): Adres ve altyapı verileri C# sınıfları (Il, Ilce, Mahalle, Sokak, ApartmanNo) ile modellenmiştir.

🛠 Kullanılan Teknolojiler

Dil: C#

Platform: .NET Framework 4.7.2

Arayüz: Windows Forms (WinForms)

Veri Sorgulama: LINQ (Language Integrated Query)

📂 Proje Yapısı

projenin ana dosyaları ve görevleri:

AltyapiSorgulama/
│
├── Form1.cs            # Form kodları, veri yükleme ve ComboBox olay (event) yönetimi
├── Form1.Designer.cs   # Windows Forms arayüz tasarım bileşenleri
├── Siniflar1.cs        # Il, Ilce, Mahalle, Sokak ve ApartmanNo model sınıfları
├── Program.cs          # Uygulamanın başlangıç noktası (Main)
└── AltyapiSorgulama.csproj # C# Proje yapılandırma dosyası


💻 Kurulum ve Çalıştırma

Bu depoyu bilgisayarınıza indirin veya klonlayın:

git clone [https://github.com/aras-kaan/AltyapiSorgulama.git](https://github.com/aras-kaan/AltYap-Sorgulama-Projesi)


Visual Studio (2019 veya daha yeni bir sürüm) programını açın.

AltyapiSorgulama.csproj veya .sln dosyasını çift tıklayarak projeyi yükleyin.

Yukarıdaki menüden Start (Başlat) butonuna basarak veya F5 tuşuna basarak uygulamayı çalıştırın.

📋 Örnek Kullanım Akışı

İl Seçimi: "İstanbul" seçilir.

İlçe Seçimi: İstanbul'a ait ilçelerden "Kadıköy" seçilir.

Mahalle Seçimi: "Moda (Caferağa)" seçilir.

Sokak Seçimi: "Moda Caddesi" seçilir.

Apartman No: "Köşk Apt. No: 45" seçilir.

Sonuç: Aşağıdaki ListBox alanında mevcut altyapılar görüntülenir:

TurkNet GigaFiber 1000 Mbps

Superonline Fiber 1000 Mbps

📄 Lisans

Bu proje eğitim ve geliştirme amaçlı hazırlanmıştır. Serbestçe kullanılabilir ve geliştirilebilir.
