import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        double n, sonuc = 0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Bir sayı giriniz: ");
        n = scanner.nextInt();

        for (double i = Math.ceil(n/2); i > 0; i-= 1) {
            if(n % i == 0){
                sonuc += i;
            }
        }
        System.out.println(sonuc == n ? "Mükemmel Sayıdır" : "Mükemmel Sayı Değildir");
    }
}