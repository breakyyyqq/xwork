using Ornek_Console;

kimlik kml = new kimlik();
Console.WriteLine(kml.AD);
kml.AD = "Berkay";
kml.Soyad = "Kaymak";
kml.MEMELEKET = "İstanbul";
Console.WriteLine(kml.Soyad);
Console.WriteLine(kml.MEMELEKET);
Console.WriteLine(kml.YAS);
Console.WriteLine(kml.CINSIYET);
Console.Read();
