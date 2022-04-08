
internal class Program
{

    public static void Main(string[] args)
    {
        Odev odev = new Odev();
        odev.odev1();
        odev.odev2();
        odev.odev3();
        odev.odev4();
    }


}

class Odev
{

    public void odev1()
    {
        int n;
        while (true)
        {
            System.Console.WriteLine("Lütfen bir pozitif sayı giriniz: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                continue;
            }
            if (n > 0)
                break;
        }
        int[] m = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                int sayi = 0;
                System.Console.WriteLine("Lütfen bir pozitif sayı giriniz[" + (i + 1).ToString() + "]:");

                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    continue;
                }

                if (sayi > 0)
                {
                    m[i] = sayi;
                    break;
                }
            }
        }
        System.Console.Write("Çift sayılar:");
        foreach (int i in m)
        {
            if (i % 2 == 0)
                System.Console.Write(" '" + i.ToString() + "'");
        }
    }

    public void odev2()
    {
        int n, k;
        while (true)
        {
            System.Console.WriteLine("Lütfen bir pozitif sayı giriniz: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                continue;
            }
            if (n > 0)
                break;
        }
        while (true)
        {
            System.Console.WriteLine("Lütfen bir pozitif sayı daha giriniz: ");
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("Lütfen bir pozitif sayı giriniz!");
                continue;
            }
            if (k > 0)
                break;
        }
        int[] m = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                int sayi = 0;
                System.Console.WriteLine("Lütfen bir pozitif sayı giriniz[" + (i + 1).ToString() + "]:");
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
                if (sayi > 0)
                {
                    m[i] = sayi;
                    break;
                }
            }
        }
        System.Console.Write("Bölünen sayılar:");
        foreach (int i in m)
        {
            if (i % k == 0)
                System.Console.Write(" '" + i.ToString() + "'");
        }

    }

    public void odev3()
    {
        int n;
        while (true)
        {
            System.Console.WriteLine("Lütfen bir pozitif sayı giriniz: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                continue;
            }
            if (n > 0)
                break;
        }
        string[] m = new string[n];
        for (int i = 0; i < n; i++)
        {

            System.Console.WriteLine("Lütfen kelime giriniz[" + (i + 1).ToString() + "]:");
            string kelime = Console.ReadLine();
            m[i] = kelime;
        }
        System.Console.Write("Kelimeler:");
        foreach (string i in m.Reverse())
            System.Console.Write(" '" + i.ToString() + "'");
    }

 public void odev4(){
        System.Console.WriteLine("Lütfen bir cümle yazınız: ");
        string cumle = Console.ReadLine();
        int kelimeSayisi = cumle.Split(" ").Length;
        int hSayisi = cumle.Replace(" ", String.Empty).Length;
        System.Console.WriteLine("Kelime sayisi: " + kelimeSayisi + "\nHarf sayisi: " + hSayisi);
        
    }
}

