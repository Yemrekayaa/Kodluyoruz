import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n, buyuk = 0, kucuk = Integer.MAX_VALUE;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Kaç tane sayı gireceksiniz: ");
        n = scanner.nextInt();

        for (int i = 1; i <= n; i++) {
            System.out.println(i + ". Sayıyı giriniz: ");
            int sayi = scanner.nextInt();
            if (sayi > buyuk) buyuk = sayi;
            else if (sayi < kucuk) kucuk = sayi;

        }

        System.out.println("En büyük sayı: " + buyuk);
        System.out.println("En küçük sayı: " + kucuk);
    }
}