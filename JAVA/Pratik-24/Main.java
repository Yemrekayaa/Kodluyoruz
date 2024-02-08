import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n;
        double sonuc = 0.0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("N Giriniz: ");
        n = scanner.nextInt();

        for (double i = 1; i <= n; i++) {
            sonuc += (1/i);
        }

        System.out.println(sonuc);

    }
}