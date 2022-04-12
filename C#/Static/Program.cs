class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");
        Calisan calisan1 = new Calisan("Yunus Emre", "Kaya", "IT");
        Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");
        Calisan calisan2 = new Calisan("Volkan", "Keleş", "IT");
        Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");

        Console.WriteLine($"2 + 5 = {Islemler.Topla(2,5)}");
        Console.WriteLine($"5 - 2 = {Islemler.Cikar(5,2)}");
    }

    class Calisan
    {

        private static int calisanSayisi;
        private string ad;
        private string soyad;
        private string departman;

        static Calisan()
        {
            CalisanSayisi = 0;
        }

        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
            CalisanSayisi++;
        }

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Departman { get => departman; set => departman = value; }

    }
}

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}