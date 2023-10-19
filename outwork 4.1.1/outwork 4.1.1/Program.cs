//namespace tarıkabinizdowhile
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // 1den 100e kadar olan sayıların toplamını dow hile yöntemiyle yapalım

//            int toplam = 0;
//            int sayac = 0;

//            do
//            {
//                sayac++;  // sayacı 1 arttırıyorum
//                toplam += sayac;
//                Console.WriteLine("Toplam {0} sayısı : {1}", toplam, sayac);
//            } while (sayac < 100);

//            // şu sayıdan şu sayıya baş ve bitiş değerleri alınacak
//            // yine toplam olsun
//            // sayac kadar ekrana belirli miktarda aynı bilgiyi yazmak...

//            int sayac1 = 0;
//            do
//            {
//                sayac1++;
//                for (int i= 1;  i < 6; i++)

//                { Console.WriteLine("Sayac : {0} - Benim adım xxxx.", sayac1); } // yukarıdaki döngü bitince 1 satır
//                //boşluk koyuyor daha okunaklı oluyor.



//            } while (sayac1<10); // Kontrol olmazsa sonsuza dçngü dediğimiz oluyor

//            // sabit olan kullancı adı ve şifreyi
//            // ekran girmiş olduguğum userid ve passw değerlerine göre kontrolünü yapılacak
//            // eğer herşey doğruysa sisteme girsin eğer
//            // eğer yanlışsa bilgiler hatalı tekrar deneyiz diyerek bilgileri tekrardan istiyeniz. 
//            // do - while yapısını kurunuz.
using System;

class Program
{
    static void Main()
    {
        // Sabit kullanıcı adı ve şifre
        string sabitKullaniciAdi = "kullanici";
        string sabitSifre = "sifre";

        string girilenKullaniciAdi;
        string girilenSifre;

        do
        {
            Console.Write("Kullanıcı Adı: ");
            girilenKullaniciAdi = Console.ReadLine();

            Console.Write("Şifre: ");
            girilenSifre = Console.ReadLine();

            if (girilenKullaniciAdi == sabitKullaniciAdi && girilenSifre == sabitSifre)
            {
                Console.WriteLine("Giriş başarılı! Hoş geldiniz, " + sabitKullaniciAdi);
                break; // Do-while döngüsünden çık
            }
            else
            {
                Console.WriteLine("Bilgiler hatalı. Tekrar deneyin.");
            }
        } while (true);
    }
}
