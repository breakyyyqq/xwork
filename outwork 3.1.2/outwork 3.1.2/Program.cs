Console.WriteLine("Cinsiyetinizi giriniz erkek için e, kız için k yazınız: ");
var cinsiyet = Console.ReadKey().KeyChar;
Console.WriteLine(" Seçtiğiniz Cinsiyet: " + " " + cinsiyet);

if (cinsiyet == 'e')
{

    Console.WriteLine("Seçtiğiniz Cinsiyet Erkektir.");

}
else if (cinsiyet == 'k') { Console.WriteLine("Seçtiğiniz Cinsiyet Kadındır."); }

else
{
    Console.WriteLine("Öyle cinsiyet yok kardeş");

}

Console.ReadKey();