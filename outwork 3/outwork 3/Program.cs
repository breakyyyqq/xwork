Console.Clear();

Console.WriteLine("************************************");
Console.WriteLine("************************************");
Console.WriteLine("*                                  *");
Console.WriteLine("* MATEMATİKSEL OPERATÖR ÖRNEKLERİ  *");
Console.WriteLine("*                                  *");
Console.WriteLine("************************************");
Console.WriteLine("************************************");


int a = 5 % 2; // 5 sayısının 2 ye bölümünden kalan değer a değişinine atanıyor.

Console.WriteLine("Kod işleminin Sonucu = " + a);

// İlginç bir durum
// Eğer işlem yapılan her iki aperand farklı türdeyse sonuçdaha üst kapasiteli veri türüne dönüştürülür.


float b = 5 / 2f;

Console.WriteLine("İlginç durumun sonucu : " + b);

// Ancak.. durumu

float c = 2 / 5 / 0.4f;

Console.WriteLine("İşlem sonucu = " + c);


float e = 2f / 5 / 2 / 2 / 4 / 8 / 4 / 5 / 3;

Console.WriteLine("Sonucu = " + e);



ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();