using System;

class Program
{
    static void Main()
    {
        double number = 4.3;
        double result = Math.Ceiling(number);

        Console.WriteLine($"Orjinal sayı: {number}");
        Console.WriteLine($"Yukarı yuvarlanmış sayı: {result}");
    }
}
/* C# programlamada Math.Ceiling fonksiyonu, verilen bir ondalık sayıyı veya çift 
 * hassasiyetli bir kayan nokta sayısını bir üst tam sayıya yuvarlar. Bu işlev, System.Math 
 * sınıfının bir üyesidir. İşte Math.Ceiling işlevinin nasıl kullanılacağını gösteren bir örnek:
 * Math.Ceiling işlevini kullanarak diğer ondalık sayıları veya çift hassasiyetli kayan nokta 
 * sayılarını yukarı yuvarlayabilirsiniz. Bu işlev, matematiksel işlemler ve sayıların yuvarlanması 
 * gereken durumlarda kullanışlıdır.
*/

using System;

class Program
{
    static void Main()
    {
        double number = 4.8;
        double result = Math.Floor(number);

        Console.WriteLine($"Orjinal sayı: {number}");
        Console.WriteLine($"Aşağı yuvarlanmış sayı: {result}");
    }
}
/* C# programlamada Math.Floor fonksiyonu, bir ondalık sayıyı veya çift hassasiyetli bir 
 * kayan nokta sayısını bir alt tam sayıya yuvarlar. Bu işlev, System.Math sınıfının bir üyesidir. 
 * İşte Math.Floor işlevinin nasıl kullanılacağını gösteren bir örnek:
 * Math.Floor işlevini kullanarak diğer ondalık sayıları veya çift hassasiyetli kayan nokta 
 * sayılarını aşağı yuvarlayabilirsiniz. Bu işlev, matematiksel işlemler ve sayıların yuvarlanması 
 * gereken durumlarda kullanışlıdır.
*/

using System;

class Program
{
    static void Main()
    {
        var num1 = 5;
        var num2 = 8;

        var comparisonResult = Comparer<int>.Default.Compare(num1, num2);

        if (comparisonResult < 0)
        {
            Console.WriteLine($"{num1} < {num2}");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine($"{num1} > {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} == {num2}");
        }
    }
}

/* C# programlamada iki değeri karşılaştırmak için Compare metodunu kullanabilirsiniz. 
 * Bu metod, iki değeri karşılaştırır ve sonucunu döndürür. 
 * Compare metodunu kullanarak farklı türlerdeki değerleri karşılaştırabilirsiniz. Örneğin, 
 * dizeleri veya tarihleri karşılaştırmak için de kullanabilirsiniz. Bu metod, sıralama ve 
 * karşılaştırma işlemlerinde yaygın olarak kullanılır.
*/

string str1 = "Merhaba, ";
string str2 = "dünya!";
string str3 = "Nasılsınız?";

string result = string.Concat(str1, str2, str3);

Console.WriteLine(result);

string[] words = { "Bu", "bir", "örnektir." };

string sentence = string.Concat(words);

Console.WriteLine(sentence);

/* C# programlama dilinde, String.Concat yöntemi, bir veya daha fazla dizeyi birleştirmek için kullanılır. 
 * Bu yöntem, dize birleştirme işlemleri için kullanışlıdır. 
 * Ayrıca, String.Concat yöntemi ayrıca dizi veya koleksiyonlardan dize birleştirme işlemleri için de kullanılabilir:
 * Bu örnek, words dizisindeki dize öğelerini birleştirir ve sentence adlı yeni bir dizeye atar. Sonuç, "Bu bir örnektir." olacaktır.
*/

/* -Ekrandan ad soyad alacak ve bunları birleştirecek(concat).
 * -Ekrandan userid ve şifre alacak bunların doğruluğunu kontrol edip mesaj verecek.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Adınızı girin: ");
        var ad = Console.ReadLine();

        Console.WriteLine("2. Soyadınızı girin: ");
        var soyad = Console.ReadLine();

        var tamAd = ad + " " + soyad;

        Console.WriteLine("Ad ve soyadınız: " + tamAd);

        Console.WriteLine("Kullanıcı adınızı girin: ");
        var kullaniciAdi = Console.ReadLine();

        Console.WriteLine("Şifrenizi girin: ");
        var sifre = Console.ReadLine();

        var dogrulamaSonucu = KullaniciDogrula(kullaniciAdi, sifre);

        if (dogrulamaSonucu)
        {
            Console.WriteLine("Giriş başarılı. Hoş geldiniz!");
        }
        else
        {
            Console.WriteLine("Kullanıcı adı veya şifre hatalı. Giriş başarısız.");
        }
    }

    static bool KullaniciDogrula(string kullaniciAdi, string sifre)
    {
        // Kullanıcı adı ve şifrenin doğrulama kodları buraya eklenir
        // Bu sadece örnek bir işlemdir, gerçek bir uygulamada daha karmaşık bir doğrulama yapmanız gerekebilir
        return kullaniciAdi == "kullanici" && sifre == "sifre";
    }
}