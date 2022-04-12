class Program
{
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen = new Dikdortgen();
        Console.WriteLine($"Class Alan Hesabı: {dikdortgen.AlanHesapla()}");

        Dikdortgen_Struct dikdortgen_Struct;
        dikdortgen_Struct.kisaKenar = 3;
        dikdortgen_Struct.uzunKenar = 4;
        Console.WriteLine($"Struct Alan Hesabı: {dikdortgen_Struct.AlanHesapla()}");
    }

}

class Dikdortgen
{
    public int kisaKenar;
    public int uzunKenar;

    public Dikdortgen()
    {
        kisaKenar = 3;
        uzunKenar = 4;
    }

    public long AlanHesapla()
    {
        return kisaKenar * uzunKenar;
    }
}

struct Dikdortgen_Struct
{
    public int kisaKenar;
    public int uzunKenar;

    public Dikdortgen_Struct(int KisaKenar, int UzunKenar)
    {
        kisaKenar = KisaKenar;
        uzunKenar = UzunKenar;
    }

    public long AlanHesapla()
    {
        return kisaKenar * uzunKenar;
    }
}