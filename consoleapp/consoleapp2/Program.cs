namespace Basit4Islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program ekrandan 2 adet sayı alacak
            // bu sayıları 4 işleme tabi tutacak
            // Sonuçları herbiri ayrı ayrı olacak şekilde ekrana basacak.


            Console.Clear(); // tüm ekranı temizler
            //Console.BackgroundColor = ConsoleColor.Gray; // ekran arka plan rengi


            // ekranda birinci sayıyı alıyorum.

            // önce değişgenleri tanımlıyorum
            double sayi1, sayi2,toplam,fark,carpma,bolme;

            Console.WriteLine("Lütfen 1.sayınızı giriniz : ");
            sayi1= double.Parse(Console.ReadLine()); // Convertfonksiyonu dönüştürme eşdeğeri...Burada kullanıcının ekrandan girmiş olduğu değeri sayi1 değişgenine aktarıyorum.

            Console.WriteLine("Lütfen 2.sayınızı giriniz : ");
            sayi2 = double.Parse(Console.ReadLine()); // Convertfonksiyonu dönüştürme eşdeğeri...Burada kullanıcının ekrandan girmiş olduğu değeri sayi1 değişgenine aktarıyorum.

            // aşağıda hesaplamalar yapılıyor.
            toplam = sayi1 + sayi2;

            fark = sayi1 - sayi2;

            carpma = sayi1 * sayi2;

            bolme = sayi1 / sayi2;

            // Şimdi yazdıralım

            Console.WriteLine("Toplama işleminin sonucu = " + toplam);

            Console.WriteLine("Çıkarma işleminin sonucu = " + fark);
            
            Console.WriteLine("Çarpma işleminin sonucu = " + carpma);
            
            Console.WriteLine("Bölme işleminin sonucu = " + bolme);


            Console.ReadKey();





        }
    }
}