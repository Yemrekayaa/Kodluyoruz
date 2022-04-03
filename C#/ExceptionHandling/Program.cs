try //Hata alması muhtemel kontrol eilmesi gereken kod bloğu girilecek.
{
    Console.WriteLine("Bir sayı giriniz :");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
}
catch (Exception ex) //Hata alındığında ne yapmasını istediğimiz kod girilecek.
{
    Console.WriteLine("Hata :" + ex.Message.ToString());
}
finally //Koşuldan bağımsız çalışmasını istediğimiz kodları yazıyoruz.
{
    Console.Write("İşlem tamamlandı.");
}


try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-200000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem başarıyla tamamlandı.");
}