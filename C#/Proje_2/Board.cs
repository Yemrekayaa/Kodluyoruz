namespace ToDo;

class Board
{
    private List<Kart> kartlar = new List<Kart>();

    public Board()
    {
        Kart kart1 = new Kart("Deneme Başlık", "Deneme İçerik", 1, (Kart.buyuklukler)1);
        kart1.Durum = Kart.durumlar.DONE;
        kartlar.Add(kart1);
        Kart kart2 = new Kart("Deneme Başlık 2", "Deneme İçerik 2", 2, (Kart.buyuklukler)2);
        kart2.Durum = Kart.durumlar.INPROGRESS;
        kartlar.Add(kart2);
        Kart kart3 = new Kart("Deneme Başlık 3", "Deneme İçerik 3", 3, (Kart.buyuklukler)3);
        kartlar.Add(kart3);
    }

    public void KartEkle()
    {

        Console.Write("Başlık Giriniz                                 : ");
        string baslik = Console.ReadLine();
        Console.Write("İçerik Giriniz                                 : ");
        string icerik = Console.ReadLine();
        Kart.buyuklukler buyukluk;
        while (true)
        {

            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)   :");
            int buyuklukInt = Convert.ToInt32(Console.ReadLine());
            if (buyuklukInt > 5 || buyuklukInt <= 0)
                Console.WriteLine("Hatalı Giriş!");
            else
            {
                buyukluk = (Kart.buyuklukler)buyuklukInt;
                break;
            }

        }

        int kisi;
        while (true)
        {
            Console.Write("Kişi Seçiniz                                    : ");
            kisi = Convert.ToInt32(Console.ReadLine());
            if (kisi >= uyeler.Count() || kisi < 0)
                Console.WriteLine("Kişi bulunamadı!");
            else
                break;
        }
        kartlar.Add(new Kart(baslik, icerik, kisi, buyukluk));
        Console.WriteLine($"{baslik} başlıklı kart eklendi!");

    }

    public void KartSil()
    {
        while (true)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();
            List<Kart> kart = KartBul(baslik);
            if (kart.Count == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                    break;
                else
                    continue;
            }
            else
                foreach (Kart silKart in kart)
                {
                    kartlar.Remove(silKart);
                }
            Console.WriteLine($"\"{baslik}\" başlığına sahip {kart.Count} kart silindi!");
            break;
        }
    }

    public void KartTasi()
    {
        while (true)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();
            List<Kart> kart = KartBul(baslik);
            if (kart.Count == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                    break;
                else
                    continue;
            }
            else
                Console.WriteLine("Bulunan kart bilgileri:");
            Console.WriteLine("********************************");
            Console.WriteLine(kart.First().ToString());
            Console.WriteLine($"Line: {kart.First().Durum}\n");

            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
            int girdi = Convert.ToInt32(Console.ReadLine());
            if (girdi == 1)
                kart.First().Durum = Kart.durumlar.TODO;
            else if (girdi == 2)
                kart.First().Durum = Kart.durumlar.INPROGRESS;
            else if (girdi == 3)
                kart.First().Durum = Kart.durumlar.DONE;
            else
            {
                Console.WriteLine("Hatalı Girdi!");
                break;
            }
            kartlariListele();
            break;
        }
    }
    public List<Kart> KartBul(string kartBaslik)
    {
        try
        {
            return kartlar.FindAll(kart => kart.Baslik == kartBaslik);
        }
        catch
        {
            return null;
        }
    }
    public void kartlariListele()
    {
        Console.WriteLine("TODO Line");
        Console.WriteLine("************************");
        foreach (Kart kart in kartlar.FindAll(kart => kart.Durum == Kart.durumlar.TODO))
        {
            Console.WriteLine(kart.ToString());
            Console.WriteLine("-");
        }

        Console.WriteLine("IN PROGRESS Line");
        Console.WriteLine("************************");
        foreach (Kart kart in kartlar.FindAll(kart => kart.Durum == Kart.durumlar.INPROGRESS))
        {
            Console.WriteLine(kart.ToString());
            Console.WriteLine("-");
        }

        Console.WriteLine("DONE Line");
        Console.WriteLine("************************");
        foreach (Kart kart in kartlar.FindAll(kart => kart.Durum == Kart.durumlar.DONE))
        {
            Console.WriteLine(kart.ToString());
            Console.WriteLine("-");
        }
    }

    public static Dictionary<int, string> uyeler = new Dictionary<int, string>(){
        {0,"Yunus Emre"},
        {1,"Furkan"},
        {2,"Volkan"},
        {3,"Alperen"}
    };


}