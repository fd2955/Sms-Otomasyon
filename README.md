# 📲 SMS Otomasyon (Windows Forms - C#)

Bu proje, Twilio API kullanarak SMS göndermeyi sağlayan basit ve görsel bir **C# Windows Forms** uygulamasıdır.  
Amaç, tek numaraya veya toplu olarak mesaj gönderimini kullanıcı dostu bir arayüzle sağlamaktır.

---

## 🛠️ Özellikler

- 📤 SMS gönderimi (Twilio ile)
- 🧾 Numara ve mesaj girilebilir form
- ✅ Gönderim sonucu ekranda gösterilir
- 🐞 Basit hata yönetimi ve mesaj durumu

---

## ⚙️ Gereksinimler

- [.NET Framework](https://dotnet.microsoft.com/en-us/download) (4.x veya .NET 6/7/8)
- Visual Studio (WinForms destekli)
- Twilio hesabı
- NuGet Paketleri:
  - `Twilio`

## 🔐 Gerekli Bilgiler

Twilio’dan gereken bilgiler:

- ✅ `ACCOUNT SID`
- ✅ `API KEY SID`
- ✅ `API SECRET`
- ✅ `FROM PHONE` (Twilio’dan alınan numara)

---

## ⚙️ Kurulum

1. **Projeyi klonla:**

```bash
git clone https://github.com/fd2955/Sms-Otomasyon
```

2. **Gerekli NuGet paketlerini yükle:**

```powershell
Install-Package Twilio
```

3. **Projeyi çalıştır ve test et 🎯**

## 🖼️ Uygulama Arayüzü

- `TextBox` → Numara girişi
- `TextBox (Multiline)` → Mesaj girişi
- `Button` → Gönder
- `Label` → Durum göstergesi (başarılı / hata)

## ❗️Uyarılar

- Ücretsiz Twilio hesaplarında sadece **doğrulanmış numaralara** SMS gönderilebilir.
- Hedef ülke SMS izinleri kontrol edilmelidir (örneğin Türkiye numaralarına ücretsiz gönderim desteklenmez).
