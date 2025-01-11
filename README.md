# THY Uçuş Arama Uygulaması

Bu uygulama, Türk Hava Yolları API'sini kullanarak havalimanı listesini görüntüleyen bir .NET MAUI mobil uygulamasıdır.

## Özellikler

- THY API entegrasyonu
- Havalimanı listesi görüntüleme
- Her havalimanı için kod ve şehir bilgisi
- Yükleme animasyonu
- Hata yönetimi

## Teknik Detaylar

- .NET MAUI 8.0 ile geliştirilmiş
- MVVM mimari pattern kullanılmış
- THY API servis entegrasyonu

## Gereksinimler

- .NET 8.0 SDK
- .NET MAUI workload
- Visual Studio 2022
- THY API anahtarı

## Kurulum

1. Projeyi klonlayın
2. API anahtarınızı appsettings.json içinde güncelleyin
3. Projeyi derleyin ve çalıştırın

## Kullanım

Uygulama başlatıldığında otomatik olarak havalimanı listesini yükleyecek ve gösterecektir.

## Geliştirme Notları

- API anahtarı güvenli bir şekilde appsettings.json'da saklanıyor
- Hata durumları için kullanıcı bildirimleri eklendi
- Yükleme durumu için görsel gösterge eklendi

## Son Güncellemeler

- MAUI workload 9.0.22'ye güncellendi
- NuGet paketleri güncellendi
- Hata düzeltmeleri yapıldı