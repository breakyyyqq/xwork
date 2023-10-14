internal class Program
{
    private static void Main(string[] args)
    {
        ///" String'i çoklu karakterlerde kullanırız."

        string name = null;

        string surname = null;

        string day = null;

        string month = null;

        string years = null;

        string coverletter = null;

        string idcard = null;

        string phonenumber = null;

        name = "xxxxxx ";

        surname = "xxxxxx ";

        day = "xx ";

        month = " ";

        years = "xxxx ";

        idcard = "11111111111 ";

        phonenumber = "05XXXXXXXXX";

        coverletter = "xxxxxxxxxxxxxxxxxxxxxxdx ";

        Console.WriteLine(name + surname + day + month + years + coverletter + idcard + phonenumber);

        ///"int le yapılmış bir toplama işlemi genellikle böyle işlemlerde int değerini kullanırız"

        int a = 99;

        int b = 243;

        int toplam = a + b;
        
        Console.WriteLine(toplam);

        #region Ekrandan ad ve soyad alım 

        string namesname = "";

        Console.WriteLine("lütfen adını ve soyadını yaz");

        namesname = Console.ReadLine();

        Console.WriteLine("merhaba kullanıcı hoşgeldin " + namesname);


        ///"region - endregion komutu iki aralıkta açıp kapatmamızı sağlayan bir sekme tarzı bir şey oluştutur"

        #endregion

        ///"Float kesirli sayıların gösterimi"
        float e = 25.4f;

        Console.WriteLine(e);

        ///"Double kesirli sayıların daha fazla bit'li gösterimi"
        double d = 22.4d;

        Console.WriteLine(d);
         
        ///"bool iki verinin doğru veya yanlış olduğunu gösteren komutun örneği"
        int sayi = 22;
        bool sonuc = sayi > 21.9;
        Console.WriteLine(sonuc);
        Console.ReadLine();

        ///"bool iki verinin doğru veya yanlış olduğunu gösteren komutun örneği"
        int deger = 23;
        bool veri = deger < 22;
        Console.WriteLine(veri);
        Console.ReadLine();



       
        Console.ReadKey();
        
    }
}

