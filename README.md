# C# Dersleri

Bu depo, YouTube kanalımdaki C# eğitim serisinde yazdığım kodları içeriyor. Temel konularla başlayıp Windows Forms masaüstü uygulamalarına kadar ilerliyor. Videoları izlerken buradaki dosyalara bakabilir, kendi bilgisayarınızda açıp deneyebilirsiniz.

Oynatma listesi: [C# Eğitimi](https://www.youtube.com/playlist?list=PLi2glt6IPZ0Vgp-KtflZvYiARqjlNDTGn)

Her dersin kodu kendi klasöründe (`ders-1`, `ders-2`, ...). İlk altı ders konsol uygulaması (`Program.cs`), son iki ders ise Windows Forms örneği (`Form1.cs`). Kodların içindeki yorum satırlarında konuyu adım adım anlatmaya çalıştım.

## Dersler

| Konu | Video | Kod |
| :--- | :--- | :--- |
| 1. Visual Studio Kurulumu ve İlk Program | [Video](https://www.youtube.com/watch?v=6e_e0nLTtgk) | [ders-1](./ders-1) |
| 2. Veri Türleri ve Değişkenler | [Video](https://www.youtube.com/watch?v=9ghunELPZ0M) | [ders-2](./ders-2) |
| 3. Koşullandırma ve Operatörler | [Video](https://www.youtube.com/watch?v=dcY_iSt0Hlg) | [ders-3](./ders-3) |
| 4. Döngüler ve Diziler | [Video](https://www.youtube.com/watch?v=wK-61X75ydk) | [ders-4](./ders-4) |
| 5. Sınıflar | [Video](https://www.youtube.com/watch?v=QfFy_NfXybI) | [ders-5](./ders-5) |
| 6. Hata Yakalama | [Video](https://www.youtube.com/watch?v=QOcqVkMedHs) | [ders-6](./ders-6) |
| 7. Windows Forms | [Video](https://www.youtube.com/watch?v=PbNzPoQP2Co) | [ders-7](./ders-7) |
| 8. Forms ile Öğrenci Yönetim Sistemi | [Video](https://www.youtube.com/watch?v=IMK_1SctnAE) | [ders-8](./ders-8) |

Not: 7 ve 8. derslerde her klasörde yalnızca `Form1.cs` dosyası var. Arayüzü (butonlar, metin kutuları vb.) videolarda Visual Studio tasarımcısıyla oluşturuyoruz; bu dosyalar kodun mantığını göstermek içindir.

## Çalıştırmak için

Windows'ta **Visual Studio 2022** (ücretsiz Community sürümü yeterli) kullanabilirsiniz. Kurulum sırasında **".NET masaüstü geliştirme" (.NET desktop development)** iş yükünü seçmeyi unutmayın; Windows Forms örnekleri bununla çalışıyor.

Depoyu indirmek için:

```shell
git clone https://github.com/dincertekin/youtube-csharp-dersleri.git
cd youtube-csharp-dersleri
```

Bu klasörlerde hazır bir proje dosyası (`.csproj`/`.sln`) yoktur; her klasörde videoda yazdığımız kod dosyası bulunur. Bir dersi çalıştırmak için Visual Studio'da yeni bir proje açıp ilgili dosyanın içeriğini yapıştırabilirsiniz.

Konsol derslerini (1-6) Visual Studio olmadan, yalnızca [.NET SDK](https://dotnet.microsoft.com/download) ile de deneyebilirsiniz. Örneğin:

```shell
dotnet new console -o deneme
cp ders-2/Program.cs deneme/Program.cs
cd deneme
dotnet run
```

## Katkı

Bir hata görürseniz ya da bir örneği iyileştirmek isterseniz issue açabilir veya pull request gönderebilirsiniz.

## Lisans

MIT. Ayrıntılar için [LICENSE](./LICENSE) dosyasına bakın.
