

// Diktörgenin alanını hesaplayan bir metodun 4 farklı bir şekilde kullanılması

#region 1. Geriye değer döndürmeyen ve parametre almayan metot

{
    // 1. region

    Console.WriteLine("Kısa kenar : ");

    int kk = (int)Convert.ToUInt32(Console.ReadLine());

    Console.WriteLine("Uzun kenar : ");

    int uk = (int)Convert.ToUInt32(Console.ReadLine());

    int alan = kk * uk;

    Console.WriteLine("Alan : {0}'dır", alan);

}
#endregion
#region 2. Geriye değer döndürmeyen ve parametre alan metot 

Console.WriteLine("Kısa Kenar: ");
int kk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Uzun Kenar: ");
int uk = Convert.ToInt32(Console.ReadLine());   
int alan = kk * uk;

#endregion
#region 3. Geriye değer döndüren ve parametre almayan metot 
#endregion
#region 4. Geriye değer döndüren ve parametre alan
#endregion