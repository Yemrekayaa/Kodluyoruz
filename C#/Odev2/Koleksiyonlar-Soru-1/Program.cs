using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("20 adet pozitif sayı giriniz:");

        ArrayList asal = new ArrayList();
        ArrayList asalDegil = new ArrayList();

        for (int i = 0; i < 20; i++)
        {
            int sayi = 0;
            while (true)
            {
                Console.Write($"Sayı({i + 1}): ");
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 0)
                        throw new Exception("Hata!");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Lütfen sayı giriniz!");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lütfen pozitif sayı giriniz!");
                    continue;
                }
                break;
            }
            if (Asalmi(sayi))
                asal.Add(sayi);
            else
                asalDegil.Add(sayi);
        }
        asal.Sort();
        asal.Reverse();
        asalDegil.Sort();
        asalDegil.Reverse();

        Console.WriteLine($"Toplam {asal.Count} asal sayı var ve ortalaması {ortalama(asal)}.");
        foreach (var i in asal)
        {
            Console.Write($"[{i}] ");
        }
        Console.WriteLine("\n--------------------------------------------");
        Console.WriteLine($"Toplam {asalDegil.Count} asal olmayan sayı var ve ortalaması {ortalama(asalDegil)}.");
        foreach (var i in asalDegil)
        {
            Console.Write($"[{i}] ");
        }
    }
    public static bool Asalmi(int a)
    {
        if (a <= 1) return false;
        if (a == 2) return true;
        if (a % 2 == 0) return false;

        var ort = (int)Math.Floor(Math.Sqrt(a));

        for (int i = 3; i <= ort; i += 2)
            if (a % i == 0)
                return false;

        return true;
    }

    public static double ortalama(ArrayList arr)
    {
        double ort = 0;
        foreach (int i in arr)
            ort += i;
        return ort / arr.Count;
    }
}