using System.Collections;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("20 adet sayı giriniz:");

        int[] dizi = new int[20];
        for (int i = 0; i < dizi.Length; i++)
        {
            int sayi = 0;
            while (true)
            {
                Console.Write($"Sayı({i + 1}): ");
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Lütfen sayı giriniz!");
                    continue;
                }
                break;
            }
            dizi[i] = sayi;
        }
        Array.Sort(dizi);
        int[] enBuyuk = new int[3]{dizi[dizi.Length-1],dizi[dizi.Length-2],dizi[dizi.Length-3]};
        int[] enKucuk = new int[3]{dizi[0],dizi[1],dizi[2]};

        Console.WriteLine($"En büyük üç sayının ortalaması: {ortalama(enBuyuk)}");
         Console.WriteLine($"En Küçük üç sayının ortalaması: {ortalama(enKucuk)}");
        Console.WriteLine($"İkisinin ortalama toplamı: {ortalama(enKucuk) + ortalama(enBuyuk)}"); 
    }

    public static double ortalama(int[] arr)
    {
        double ort = 0;
        foreach (int i in arr)
            ort += i;
        return ort / arr.Length;
    }
}