import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        double a, b, c, u, alan;

        Scanner scanner = new Scanner(System.in);


        System.out.print("Üçgenin 1. Kenarını Giriniz: ");
        a = scanner.nextDouble();

        System.out.print("Üçgenin 2. Kenarını Giriniz: ");
        b = scanner.nextDouble();

        System.out.print("Üçgenin 3. Kenarını Giriniz: ");
        c = scanner.nextDouble();

        u = (a + b + c) / 2.0;
        alan = Math.sqrt(u * (u - a) * (u - b) * (u - c));

        System.out.println("Üçgenin alanı: " + alan);
    }
}