namespace ToDo;

class Kart
{
    private string baslik;
    private string icerik;
    private durumlar durum;
    private buyuklukler buyukluk;
    private int kisi;
    public Kart(){

    }
    public Kart(string baslik, string icerik,int kisi, buyuklukler buyukluk ){
        Baslik = baslik;
        Icerik = icerik;
        Durum = durumlar.TODO;
        Kisi = kisi;
        Buyukluk = buyukluk;
    }

    public override string ToString(){
        return $"Başlık: {Baslik}\nİçerik: {Icerik}\nAtanan Kişi: {Board.uyeler[kisi]}\nBüyüklük: {buyukluk.ToString()}";
    }
    public string Baslik { get => baslik; set => baslik = value; }
    public string Icerik { get => icerik; set => icerik = value; }
    internal durumlar Durum { get => durum; set => durum = value; }
    internal buyuklukler Buyukluk { get => buyukluk; set => buyukluk = value; }
    public int Kisi { get => kisi; set => kisi = value; }

    public enum durumlar{
        TODO,
        INPROGRESS,
        DONE
    }

    public enum buyuklukler{
        XS = 1,
        S= 2,
        M= 3,
        L= 4,
        XL= 5
    }
}