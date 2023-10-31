Console.WriteLine("İsminizi Giriniz: ");
string isim;
isim = Console.ReadLine();
Console.Clear();

Console.WriteLine("Soyadınızı Giriniz: ");
string soyisim;
soyisim = Console.ReadLine();
Console.Clear();

Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Lütfen Adresinizi Giriniz: ");
string adres;
adres = Console.ReadLine();
Console.Clear();

Console.WriteLine("Teşekkürler:) \n" + isim + "\n" + soyisim + "\n" + yas + "\n" + adres);
Console.Read();
Console.ReadKey();