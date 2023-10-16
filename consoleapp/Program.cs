

// /*

// Uygulana 1: Bir öğrencinin aşağıdaki bilgileri için gerekli değişkenleri oluşturunuz.

//     Öğrenci adı
//     Öğrenci soyadı
//     Öğrenci ad  ve soyad
//     Öğrenci numarası
//     Öğrenci cinsiyet
//     Öğrenci kimlik
//     Öğrenci doğum yılı
//     Öğrenci adres bilgisi
//     Öğrenci Yaşı

// Uygukana 2: Aşağıdaki ürünlerin toplam bilgisini hesaplayınız.

//     Ürün 1 => 50 TL
//     Ürün 2 => 60.5 TL
//     Ürün 3 => 356,45 TL
// */

// var ogrenciAdi = "Ahmet ";
// var ogrenciSoyadi = "Turan";
// var adSoyad = ogrenciAdi + ogrenciSoyadi;
// var ogrenciNo = "1025";
// var ogrenciTc = "1111111";
// var ogrenciDogumYili = 2005;
// var ogrenciYas = 2024 - ogrenciDogumYili;
// var ogrenciAdres = "Koceli İzmit";


// Console.WriteLine(ogrenciAdi);
// Console.WriteLine(ogrenciSoyadi);
// Console.WriteLine(adSoyad);
// Console.WriteLine(ogrenciTc);
// Console.WriteLine(ogrenciDogumYili);
// Console.WriteLine(ogrenciYas);
// Console.WriteLine(ogrenciAdres);

// var urun1_fiyat = 50;
// var urun2_fiyat = 60.5;
// var urun3_fiyat = 356.45;

// var toplam = urun1_fiyat + urun2_fiyat + urun3_fiyat;

// Console.WriteLine(toplam);

// /*

//     C# Veri Tipleri

//      Value Types:
//      Tam Sayı : byte, short, int, long
//      Ondalıklı Sayılafr: float, double, decimal
//      Diğer Veri Sayıları char, boolean, struct

//      Reference Types:
//         string, class, array, interface

// */

// int sayi = 200;
// decimal kdvOrani = 1.18m;
// char cinsiyet = 'E';
// string cinsiyet2 = "Kadın";
// string urunAdi = "Samsung S23";
// var satisDurumu = true;

// Console.WriteLine(sayi);
// Console.WriteLine(kdvOrani);
// Console.WriteLine(cinsiyet);
// Console.WriteLine(cinsiyet2);
// Console.WriteLine(urunAdi);
// Console.WriteLine(satisDurumu);



/*

    Veri Tipi Dönüşü
    // implicit casting => bilincçsiz tür dönüşümü.
    // explicitt casting => bilinçli tür dönüşümü.
*/

// int a = 10;
// byte b = a;  // bilinçsiz.

// int d = 10;  
// long e = (int)d;  // bilinçli


// double f = 20.5;
// float g = (float)f; // parantez içinine alırsan değer kaybını kabul edip bir bilinçli tür değişimi yapmak istersin.

// double h = 10.5;
// int i = (int)h; // tam sayı içerisine aktarmak istiyorum.

// Console.WriteLine(i);

// int x = 10;
// string z = x.ToString();


// Console.Write("1.sayı : ");
// var sayi1 = Convert.ToInt32(Console.ReadLine); // string to int // çevirilebilir bir değer vermemiz gerekir. (("a10") olmaz)

// Console.Write("2.sayı : ");
// var sayi2 = Convert.ToInt32(Console.ReadLine);

// var topla = sayi1 + sayi2;  

// Console.WriteLine(topla);


//Nullable Types

using System.Diagnostics.CodeAnalysis;

// int? maas = null;  // eğer bir atama yapılmazsa null değeri alır.

// int? maas  = default;
// bool? isActive = null;

// Console.WriteLine(maas.HasValue);
// Console.WriteLine(maas.GetValueOrDefault());
// Console.WriteLine(isActive.GetValueOrDefault());

/*
    String : Karakter Dizileri - reference => null
*/

// Console.Write("adı: ");
// var ad = Console.ReadLine();

// var soyad = Console.ReadLine();
// Console.Write("soyad: ");

// Console.Write("yas: ");
// var yas = Console.ReadLine();

// // string concat işlemi
// //string mesaj = ad +" "+ soyad + " isimli kişi "+ yas + " yaşındadır.";

// // string interpolation
// string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";

// Console.WriteLine(mesaj);


/*
    String Methods
*/

// string mesaj = "Berkay Kaymak isimli kişi {23} yaşındadır. ";

// //var sonuc = mesaj.Length;
// // var sonuc = mesaj.ToLower();
// // var sonuc = mesaj.ToUpper();
// // var sonuc = mesaj.Trim();
// // var sonuc = mesaj.Split(" ")[3];
// // var sonuc = mesaj [0];
// // var sonuc = mesaj.EndsWith(".");
// // var sonuc = mesaj.Contains("Berkay");
// // var sonuc = mesaj.IndexOf("kişi");
// // var sonuc = mesaj.Substring(6, 5);

// Console.WriteLine(sonuc);

/*
    String Uygulamalar
*/

// string kursAdi = ".Net 7 ile C# Programlama Dili";

// // 1- Kaç karaktere sahiptir?
// // 2- Hepsini küçük harf yapınız.
// // 3- '.' ile mi başlamaktadır?
// // 4- C# bilgisi hangi konumda bulunmaktadır?
// // 5- String 'C#' bilgisini içeriyor mu?
// // 6- 'Dili' kelimesi yerine 'Dersleri' yazınız. (replace)

// var karakterSayisi = kursAdi.Length;
// Console.WriteLine(karakterSayisi); //30

// var kucukHarf = kursAdi.ToLower();
// Console.WriteLine(kucukHarf); // harfleri küçültme

// var nokta = kursAdi.StartsWith('.');
// Console.WriteLine("string . ile başlıyor: " + nokta); // 3?

// var konum = kursAdi.IndexOf("C#"); // 4 
// Console.WriteLine("konum " + konum);

// var iceriyormu = kursAdi.Contains("C#"); // 5 
// Console.WriteLine("C# içeriyor mu: " + iceriyormu);

// var guncellenenString = kursAdi.Replace("Dili","Dersleri"); // 6
// Console.WriteLine(guncellenenString);

/*

    DateTime

*/

// var simdi = DateTime.Now;

// Console.WriteLine(simdi);
// Console.WriteLine(simdi.Year);
// Console.WriteLine(simdi.Month);
// Console.WriteLine(simdi.Day);
// Console.WriteLine(simdi.DayOfWeek);
// Console.WriteLine(simdi.Hour);
// Console.WriteLine(simdi.Minute);
// Console.WriteLine(simdi.Second);

// DateTime dt = new DateTime(2022, 6, 10, 14, 30, 45);
// DateTime dt2 = dt.AddYears(1);
// DateTime dt3 = dt.AddHours(2);

// Console.WriteLine(dt2.Year);
// Console.WriteLine(dt3.Hour);

// var fark = simdi - dt;
// Console.WriteLine(fark.TotalDays);
// Console.WriteLine(fark.TotalHours);








