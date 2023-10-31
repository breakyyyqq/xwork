#region Dizi Tanımlama, Değer atama, Kullanma
//int[] dizi = new int[20]; // 20 elemanlı dizi isminde int türünden bir dizi

//dizi[9] = 30; // 10. Elemanına 10 değeri atandı.

//Console.WriteLine("Dizi elemanın içeriği : {0}", +dizi[9]);

//şöyle de olabilir...

//string[] dizi1 = { "Bir", "İki", "Üç" }; //String bir dizi daha tanımlarken ilk değerleri.. initaial atanıyor.

//int[] dizi2 = { 2, -5, 12 };

//float[] dizi3 = { 2f, 1.2f, 7f };

//// Not : Ancak bu şekilde bir dizi bildirimi sadece dizi tanımlamalarında kullanılabiliyor. Yani aşağıdaki gibi kullanamayız.

////int[] dizi4;
////dizi4[0] = {1, 2, 3,};

//int[] dizi5 = new int[] {0, 1, 2, };

//// Dinamşk bir dizi yaratımı.
//Console.WriteLine("lütfen 1 ile 10 arasında bir sayı giriniz : ");

//int boyut = Convert.ToInt32(Console.ReadLine);

//int[] dizi6 = new int[boyut];

//dizi6[7] = 500;

//Console.WriteLine("Eleman : {0}", dizi6[7]);

// Bir string dizimiz var. bu diziyi "ters" sırada ekrana yazdırınız. 

//string[] MyUCC09Team = { "xxxxx", "yyyyyy", "aaaaaa", "ffffff", "kkkkkk", "ddddddddd", 
//    "cccccc","hhhhhh","qqqqqq","rrrrr","eeeeee" };

//int diziIndex = MyUCC09Team.Length - 1; // dizimin boyunca indeximi
//                                        // kaydırmak için . Dizi indexleri 0 dan başladığı için -1 

//for (int i = diziIndex; i >=0; --i)
//{ 
//Console.WriteLine("Elemanın adı: {0} \n\n ",MyUCC09Team[i]);
//}

#endregion
#region
// for/foreach döngüleri 
// Daily Workout_1
// Verilen bir tam sayı dizisinin elemanlarının toplamını for ve foreach döngülerini kullanarak yazınız.

//int[] sayilar1 = { 5, 6, 7, 8, 78, 45, 0, 99, 20, 30 };

//int toplam = 0;

//for (int index = 0; index < sayilar1.Length; index++) 
//toplam += sayilar1[index];
//Console.WriteLine("Dizi elemanlarının toplamı = {0}",toplam);

//// foreach ile

//int toplam1 = 0;

//foreach (int elemandegeri in sayilar1)
//{
//toplam1 += elemandegeri;
//}
//Console.WriteLine("foreach ile = {0} ",toplam1);
#endregion
// daily WO2

// Tanımlanan sayısal bir dizi içindeki elemanların negatif/pozitif/işaretsiz olma durumlarının
// elemanın yanına yazan programcığı yazınız. Negatif/Pozitif/Nötr sayıların adedini de yazdırınız. 

//int pozitifAdet=0, negatifAdet=0, notrAdet=0;
//int[] sayilar2 = { 5, 6, -15, 22, -34, 3, 0, -7, 8, 100, -100 };

//foreach (int sayi in sayilar2)
//{
//	switch (sayi)
//	{
//        case sayi > 0:
//            pozitifAdet++;
//            Console.WriteLine("Sayı : {0} - Pozitiftir..", sayi);

//            break;
//		case < 0:
//            negatifAdet++;
//            Console.WriteLine("Sayı : {0} - Negatiftir..", sayi);
//            break;
//		default:
//            notrAdet++;
//            Console.WriteLine("Sayı : {0} - Nötrdür..", sayi);
//            break;

//    }
//}
//    Console.WriteLine("Pozitiflerin Adedi : {0} \n\n",pozitifAdet);
//    Console.WriteLine("Negatiflerin Adedi : {0} \n\n", negatifAdet);
//    Console.WriteLine("Nötrlerin Adedi : {0} \n\n", notrAdet);


#region
//DWO 3
// Kullanıcan istenen erkan alınan bir metin içindeki sesli harf sayısı bulma / ekrana yazma / farklı bir diziye yerleştirme

//Öncelikle sesli harflerin tutulduğu bir dize yaratıyorum.

//using System.Reflection.Metadata;

//char[] sesliler = { 'a', 'e', 'ı', 'i', 'ö', 'o', 'u', 'ü', };

//char[] hangileri = new char[30]; //içini dolduracağım bulduklarımla - ekrandan girilen 

//int hindex = 0; // hangileri dizinisin indexi

//string metin = ""; // ekrandan alınan metin bilgisinin tutulacak.

//int adet = 0; // Bulacağım seslilerin adedi tutuyor.

//Console.Write(" Lütfen metni giriniz : ");
//metin = Console.ReadLine().ToLower(); // öncelikle küçültürüyorum benim dizeme uysun diye.

//// Bir for döngüsüyle benim tanımlamış olduğum sesliler dizisi üzerinde dolaşacak(kontrol etmek için)

//for (int i = 0; i < sesliler.Length; i++)
//{
//    // ikinci for çevriminde ekrandan aldığım metin için 
//    for (int j = 0; j < metin.Length; j++)
//    {
//        if (metin[j] == sesliler[i]) // girilen metni diziymiş gibi dolaşıyor
//        {
//            hangileri[hindex] = metin[j];   // bulduğum karakteri hangileri dizisine göm.
//            hindex++;
//            adet++;
//        }
//    }
//}
//// artık herşey bitmiştir 

//Console.WriteLine("Girmiş olduğunuz metinde {0} adet sesli harf vardır. ", adet);
//Console.WriteLine(hangileri);
#endregion
#region
// DWO 4 
// 10 elemanlı sayısal bir dizim var.
// Bu dizedeki neg/poz/sıfır değerlerin kaçar adet olduğu 

int[] sayilar5 = { 1, 7, -8, 9, -100, 1001, -10, -20, 0, 0, 0, 0, 0, };

int pozitifSayisi = 0;
int negatifSayisi = 0;
int notrSayisi = 0;

foreach (int eleman in sayilar5)
{
    if (eleman > 0)
        pozitifSayisi++;
    else if (eleman < 0)
        negatifSayisi++;
    else
        notrSayisi++;
}

Console.WriteLine("Pozitif eleman sayısı: " + pozitifSayisi);
Console.WriteLine("Negatif eleman sayısı: " + negatifSayisi);
Console.WriteLine("Nötr eleman sayısı: " + notrSayisi);
#endregion













