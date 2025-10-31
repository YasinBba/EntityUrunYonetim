🏷️ Entity Ürün Yönetim Sistemi

Bu proje, Entity Framework kullanılarak geliştirilmiş bir Windows Forms tabanlı Ürün Yönetim Sistemi uygulamasıdır. Kullanıcılar ürün, kategori, müşteri ve satış işlemlerini kolayca yönetebilir. Ayrıca basit istatistik ekranı ile toplam satışlar ve ürün bilgileri görüntülenebilir.

🚀 Özellikler

🔐 Giriş Ekranı (FrmGiris) → Admin bilgileriyle sisteme giriş yapılır, hatalı girişlerde kullanıcı uyarılır.

🏠 Ana Form (FrmAnaForm) → Uygulamadaki tüm modüllere yönlendirme yapılır, sade bir menü tasarımı vardır.

📦 Ürün Yönetimi (FrmUrun) → Ürün ekleme, silme, güncelleme, listeleme işlemleri; kategorilerle ilişkilendirilmiş ürün yapısı; LINQ sorguları ile kolay veri yönetimi.

📊 İstatistikler (Frmİstatistik) → Toplam ürün sayısı, en pahalı/en ucuz ürün, toplam müşteri sayısı, satış sayısı ve toplam tutar gibi bilgiler.


🧠 Kullanılan Teknolojiler

Teknoloji	Açıklama
💻 C# (.NET Framework)	Uygulamanın geliştirme dili
🧩 Windows Forms	Görsel arayüz oluşturmak için
🗄️ Entity Framework (Database First)	Veritabanı işlemleri için ORM aracı
🧱 SQL Server	Veritabanı yönetim sistemi
⚙️ LINQ	Veri sorgulama işlemleri için


🏗️ Proje Yapısı

EntityUrunYonetim/
├── EntityUrunYonetim.sln
├── App.config
├── Program.cs
├── FrmGiris.cs / FrmGiris.Designer.cs
├── FrmAnaForm.cs / FrmAnaForm.Designer.cs
├── FrmUrun.cs / FrmUrun.Designer.cs
├── Frmİstatistik.cs / Frmİstatistik.Designer.cs
├── Model1.edmx (Entity Framework modeli)
├── Tbl_Admin.cs
├── Tbl_Category.cs
├── Tbl_Customer.cs
├── Tbl_Product.cs
├── Tbl_Sales.cs
└── Properties/
