namespace ToDo;

class Program
{

    static void Main(string[] args)
    {
        Board board = new Board();
        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int girdi;
            try
            {
                girdi = Convert.ToInt32(Console.ReadLine());
                if (girdi > 4 || girdi < 1)
                {
                    Console.WriteLine("Hatalı girdi!\n");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Hatalı girdi!\n");
                continue;
            }
            if(girdi == 1)
                board.kartlariListele();
            else if(girdi == 2)
                board.KartEkle();
            else if(girdi == 3)
                board.KartSil();
            else if(girdi == 4)
                board.KartTasi();
            Console.ReadKey();

        }

    }
}