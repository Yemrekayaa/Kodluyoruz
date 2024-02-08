import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        double mesafe, mesafeBirimTutar = 0.10, toplamTutar, indirim = 0;
        int yas, yolculukTipi;

        Scanner scanner = new Scanner(System.in);

        System.out.print("Mesafeyi km türünden giriniz: ");
        if((mesafe = scanner.nextDouble()) < 0.0){
            System.out.println("Hatalı Veri Girdiniz!");
            System.exit(0);
        }
        System.out.print("Yaşınızı giriniz: ");
        if((yas = scanner.nextInt()) < 0){
            System.out.println("Hatalı Veri Girdiniz!");
            System.exit(0);
        }
        System.out.print("Yolculuk tipini giriniz (1 => Tek Yön , 2 => Gidiş Dönüş ):");
        if((yolculukTipi = scanner.nextInt()) != 1 && yolculukTipi != 2){
            System.out.println("Hatalı Veri Girdiniz!");
            System.exit(0);
        }

        if(yolculukTipi == 2) {
            toplamTutar = mesafe * (mesafeBirimTutar * 2);
            toplamTutar -= toplamTutar * 0.2;
        }
        else toplamTutar = mesafe * mesafeBirimTutar;


        if(yas < 12) indirim = 0.5;
        else if (yas < 24) indirim = 0.1;
        else if (yas > 65) indirim = 0.3;

        toplamTutar -= toplamTutar * indirim;


        System.out.println("Toplam Tutar: " + toplamTutar + "₺");

    }
}