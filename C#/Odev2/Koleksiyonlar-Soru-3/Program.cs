using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bir cümle giriniz: ");
        char[] cumle = Console.ReadLine().Trim().ToLower().ToCharArray();
        string sesliHarfler = "aeıoöuü";
        string sonuc = "";
        foreach(char i in cumle){
            if(sesliHarfler.Contains(i))
                sonuc += i;
        }
        char[] sonucDizisi = sonuc.ToCharArray();
        Array.Sort(sonucDizisi);
        foreach(char i in sonucDizisi){
            Console.Write($"[{i}] ");
        }

    }
    
}