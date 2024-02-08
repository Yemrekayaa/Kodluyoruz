import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n, toplam = 0, uzunluk = 0;
        double sonuc = 0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Sayı Giriniz: ");
        if((n = scanner.nextInt()) < 0){
            System.out.println("Hatalı Veri Girdiniz!");
            System.exit(0);
        }

        for (int i = 1; i <= n; i++) {
            if(i % 3 == 0 && i % 4 == 0){
                toplam += i;
                uzunluk++;
                System.out.println(i);
            }

        }

        if(uzunluk == 0) System.out.println("Sayı Bulunamadı!");
        else {
            sonuc = toplam / uzunluk;
            System.out.println("Sayıların ortalaması: " + sonuc);
        }
    }
}