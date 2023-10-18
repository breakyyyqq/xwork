using System.Drawing;

double sinav1 = 0, sinav2 = 0;

Console.Write("Birinci sayıyı giriniz:");

sinav1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz:");

sinav2 = Convert.ToDouble(Console.ReadLine());

double ortalama = ((sinav1 * 0.4) + (sinav2 * 0.6)) / 2;

Console.WriteLine("Ortalama={0}", ortalama);

if (ortalama >= 60)
{ Console.WriteLine("Sınavdan geçti... "); }
else
{
Console.WriteLine("Sınavdan Kaldı... "); 
}



Console.ReadKey();