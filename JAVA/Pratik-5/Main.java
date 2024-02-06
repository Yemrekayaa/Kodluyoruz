import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        double r, a, alan;

        Scanner scanner = new Scanner(System.in);
        System.out.print("Yarıçapı Giriniz: ");
        r = scanner.nextDouble();
        System.out.print("Merkez Açısını Giriniz: ");
        a = scanner.nextDouble();

        alan = (Math.PI * (r * r) * a) / 360;

        System.out.println("Dairenin alanı: " + alan);
    }
}