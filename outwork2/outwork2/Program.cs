internal class Program
{

    private static void Main(string[] args)
    {
        byte a = 10;

        short b = 20;

        sbyte c = 30;

        int d = a + b + c;

        Console.WriteLine("toplam = " + d.ToString());

        string e = "Team";

        char f = 'A';

        object g = e + " " + f + d;

        long h = d;

        float i = h;

        double j = i;

        double k = 21.6;

        float l = h + (float)k;

        Console.WriteLine("1. durum : " + d.ToString() + "\n\n");

        Console.WriteLine("2. durum : " + g.ToString() + "\n\n");

        Console.WriteLine("3. durum : " + l.ToString() + "\n\n");

        char m = 'H';

        int n = m;

        Console.WriteLine("4. durum : " + n + "\n\n");

        int r = 1500;

        byte s = (byte)r;

        Console.WriteLine("5. durum : " + (s + r ) + "\n\n");

        Console.ReadKey();




    }
}