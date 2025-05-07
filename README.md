![image](https://github.com/user-attachments/assets/bc5edae5-1af6-4c43-af64-896b3c618165)
# Yapay Sinir Ağları

Bu proje, C# dilinde geliştirilmiş bir Windows Forms uygulaması kullanarak basit bir yapay sinir ağı (Artificial Neural Network - ANN) modelini göstermeyi amaçlamaktadır. Proje, eğitilebilir nöronlar ve katmanlardan oluşan bir sinir ağının temel mantığını uygulamalı olarak sunar.

## İçerik

Proje aşağıdaki dosya ve sınıfları içermektedir:

* `MainForm.cs`: Kullanıcı arayüzü ve giriş/eğitim işlevlerinin bulunduğu ana form.
* `Neuron.cs`: Yapay bir nöron nesnesini tanımlar. Ağırlıklar, bias ve aktivasyon fonksiyonu içerir.
* `Layer.cs`: Nöronların katmanlar halinde organize edilmesini sağlar.
* `Network.cs`: Birden fazla katman ve nöron içeren sinir ağı yapısını kontrol eder. İleri besleme (feedforward) ve eğitim algoritmalarını uygular.
* `Program.cs`: Uygulamanın başlangıç noktasi.
* `MainForm.Designer.cs` & `MainForm.resx`: Arayüz tasarımı ve kaynak dosyaları.

## Özellikler

* Basit yapay sinir ağı mimarisi
* Katman ve nöron yapılarını tanımlama
* Aktivasyon fonksiyonu uygulaması (muhtemelen sigmoid)
* Eğitim verisi ile ağı eğitme yeteneği
* Kullanıcı dostu grafik arayüz

## Gereksinimler

* Visual Studio 2022 veya üzeri
* .NET 8.0 SDK
* Windows işletim sistemi


## Nasıl Çalışır?

Program şu adımlarla çalışır:

1. Kullanıcı, giriş verilerini ve hedef çıktıyı form aracılığıyla girer.
2. Sinir ağı oluşturulur ve bağlantı ağırlıkları rastgele atanır.
3. Feedforward algoritması ile veriler işlenerek çıktı alınır.
4. Eğitim işlemi ile hata değeri minimize edilmeye çalışılır (geri yayılım yoksa elle güncellenir).

## Katkı

Projeye katkıda bulunmak isterseniz lütfen bir çekme isteği (pull request) oluşturun veya konu açarak bize bildirin.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Ayrıntılar için `LICENSE` dosyasına bakabilirsiniz.

