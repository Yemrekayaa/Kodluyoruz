class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Yunus Emre";
        ogrenci.Soyisim = "Kaya";
        ogrenci.Ogrno = 2341;
        ogrenci.Sinif = 4;
        ogrenci.OgrenciBilgileriniGetir();

    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrno;
        private int sinif;


        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Ogrno { get => ogrno; set => ogrno = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)

                    Console.WriteLine("Sınıf en az 1 olabilir!");
                else
                    sinif = value;
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrno, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Ogrno = ogrno;
            Sinif = sinif;
        }

        public Ogrenci()
        {
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********** Öğrenci Bilgileri **********");
            Console.WriteLine($"Öğrenci Adı: {Isım}");
            Console.WriteLine($"Öğrenci Soyadı: {Soyisim}");
            Console.WriteLine($"Öğrenci No: {Ogrno}");
            Console.WriteLine($"Öğrenci Sınıfı: {Sinif}");

        }

        public void SinifAtlat()
        {
            Sinif += 1;
        }

        public void SinifDusur()
        {
            Sinif -= 1;
        }
    }
}
