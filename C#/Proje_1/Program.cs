class Program
{

    static void Main(string[] args)
    {
        TelefonDefteri telefonDefteri = new TelefonDefteri();
        telefonDefteri.KisiEkle(new Kisi("Yunus Emre", "Kaya", "1234567890"));
        telefonDefteri.KisiEkle(new Kisi("Volkan", "Keleş", "0987654321"));
        telefonDefteri.KisiEkle(new Kisi("Furkan", "Duran", "1470258963"));
        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(0) Çıkış");
            int islem = Convert.ToInt32(Console.ReadLine());
            if (islem == 0)
                break;
            else if (islem == 1)
                KisiEkle(telefonDefteri);
            else if (islem == 5)
                KisiBul(telefonDefteri);
            else if (islem == 4)
                telefonDefteri.KisileriGoster();
            else if (islem == 2)
                KisiSil(telefonDefteri);
            else if (islem == 3)
                KisiGuncelle(telefonDefteri);
            else if (islem > 6)
                continue;
            Console.ReadLine();

        }


    }

    public static void KisiEkle(TelefonDefteri tf)
    {
        string isim, soyisim, numara;
        Console.Write("Lütfen isim giriniz             :");
        isim = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          :");
        soyisim = Console.ReadLine();
        while (true)
        {
            Console.Write("Lütfen telefon numarası giriniz :");
            numara = Console.ReadLine();
            if (numara.All(char.IsDigit))
                break;
            else
                Console.WriteLine("Lütfen geçerli bir numara giriniz!");
        }
        Console.WriteLine("Kişi Eklendi!");
        tf.KisiEkle(new Kisi(isim, soyisim, numara));
    }

    public static void KisiBul(TelefonDefteri tf)
    {
        string deger;
        int islem;
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("*******************************************\n");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        islem = Convert.ToInt32(Console.ReadLine());

        if (islem == 1)
            Console.Write("İsim veya soyisim giriniz: ");
        else if (islem == 2)
            Console.Write("Telefon numarasını giriniz: ");
        deger = Console.ReadLine();
        List<Kisi> bulunanKisiler = tf.KisileriBul(deger);
        if (bulunanKisiler.Count <= 0)
            Console.WriteLine("Aradığınız kişi bulunamadı!");
        else
        {
            Console.WriteLine("Arama Sonuçlarınız:");
            Console.WriteLine("*******************************************");
            tf.KisileriGoster(bulunanKisiler);
        }
    }

    public static void KisiSil(TelefonDefteri tF)
    {
        string deger;
        Console.WriteLine("*******************************************");
        Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        deger = Console.ReadLine();
        string girdi;
        if (tF.KisileriBul(deger).Count > 0)
        {
            Console.Write($"{tF.KisileriBul(deger).First().Isim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n):");
            girdi = Console.ReadLine();
            if (girdi.ToLower() == "y")
            {
                tF.KisiSil(tF.KisileriBul(deger).First());
                Console.WriteLine("Kişi Silindi!");
            }
            else
            {
                Console.WriteLine("Silme işlemi iptal edildi!");
            }
        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            girdi = Console.ReadLine();
            if (Convert.ToInt32(girdi) == 2)
                KisiSil(tF);
        }
    }

    public static void KisiGuncelle(TelefonDefteri tF)
    {
        string deger, isim, soyisim, numara;
        Console.WriteLine("*******************************************");
        Console.Write("Lütfen Guncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        deger = Console.ReadLine();
        string girdi;
        Kisi bulunanKisi;
        if (tF.KisileriBul(deger).Count > 0)
        {
            bulunanKisi = tF.KisileriBul(deger).First();
            Console.Write($"İsim({bulunanKisi.Isim}):");
            isim = Console.ReadLine();
            if (isim == string.Empty)
                isim = bulunanKisi.Isim;
            Console.Write($"Soyisim({bulunanKisi.Soyisim}):");
            soyisim = Console.ReadLine();
            if (soyisim == string.Empty)
                soyisim = bulunanKisi.Soyisim;
            while (true)
            {
                Console.Write($"Telefon Numarası({bulunanKisi.Numara}]):");
                numara = Console.ReadLine();
                if (numara == string.Empty)
                {
                    numara = bulunanKisi.Numara; break;
                }
                else if (numara.All(char.IsDigit))
                    break;
                else
                    Console.WriteLine("Lütfen geçerli bir numara giriniz!");
            }
            Console.WriteLine("Kişi Güncellendi!");
            tF.KisiGuncelle(bulunanKisi, new Kisi(isim, soyisim, numara));
        }
        else
        {
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            girdi = Console.ReadLine();
            if (Convert.ToInt32(girdi) == 2)
                KisiGuncelle(tF);
        }
    }
}

class TelefonDefteri
{

    private List<Kisi> kisiListesi = new List<Kisi>();

    public void KisiEkle(Kisi kisi)
    {
        kisiListesi.Add(kisi);
    }
    public void KisiSil(Kisi kisi)
    {
        kisiListesi.Remove(kisi);
    }
    public void KisiGuncelle(Kisi kisi, Kisi kisi2)
    {
        kisiListesi.Find(k => k == kisi).Isim = kisi2.Isim;
        kisiListesi.Find(k => k == kisi).Soyisim = kisi2.Soyisim;
        kisiListesi.Find(k => k == kisi).Numara = kisi2.Numara;
    }

    public void KisileriGoster()
    {
        foreach (Kisi k in kisiListesi)
        {
            Console.WriteLine($"İsim: {k.Isim}");
            Console.WriteLine($"Soyisim: {k.Soyisim}");
            Console.WriteLine($"Telefon Numarası: {k.Numara}\n-");
        }
    }

    public void KisileriGoster(List<Kisi> kisiListesi)
    {
        foreach (Kisi k in kisiListesi)
        {
            Console.WriteLine($"İsim: {k.Isim}");
            Console.WriteLine($"Soyisim: {k.Soyisim}");
            Console.WriteLine($"Telefon Numarası: {k.Numara}\n-");
        }
    }


    public List<Kisi> KisileriBul(string deger)
    {
        List<Kisi> bulunanKisiler = new List<Kisi>();
        foreach (Kisi k in kisiListesi)
        {
            if (deger.All(char.IsDigit))
            {
                if (k.Numara == deger)
                    bulunanKisiler.Add(k);
            }
            else
            {
                if (k.Isim.ToLower() == deger.ToLower() || k.Soyisim.ToLower() == deger.ToLower())
                {
                    bulunanKisiler.Add(k);
                }
            }
        }
        return bulunanKisiler;
    }


}

class Kisi
{
    private string isim;
    private string soyisim;
    private string numara;


    public Kisi(string isim, string soyisim, string numara)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.numara = numara;
    }

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public string Numara { get => numara; set => numara = value; }
}