import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n, r, nfak = 1, rfak = 1, nrfak = 1;
        double sonuc;
        Scanner scanner = new Scanner(System.in);

        System.out.print("N Giriniz: ");
        n = scanner.nextInt();
        System.out.print("R Giriniz: ");
        r = scanner.nextInt();

        for (int i = n; i > 0; i--) {
            nfak *= i;
        }
        for (int i = r; i > 0; i--) {
            rfak *= i;
        }
        for (int i = n - r; i > 0; i--) {
            nrfak *= i;
        }

        sonuc = nfak / (rfak * nrfak);

        System.out.print(sonuc);
    }
}