class Program
{
    static void Main(string[] args)
    {

        Calisan calisan1 = new Calisan("Yunus Emre", "Kaya", 1, "Muhasebe");
        calisan1.CalisanBilgileri();

        Console.WriteLine("-*-*-*-*-*-*-");
        Calisan calisan2 = new Calisan("Volkan", "Keleş", 2, "Pazarlama");
        calisan2.CalisanBilgileri();

        Console.WriteLine("-*-*-*-*-*-*-");
        Calisan calisan3 = new Calisan("Alperen", "Güntekin");
        calisan3.CalisanBilgileri();
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
