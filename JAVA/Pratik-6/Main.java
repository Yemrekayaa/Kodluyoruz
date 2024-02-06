import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        double kilo, boy, VKI;

        Scanner scanner = new Scanner(System.in);
        System.out.print("Lütfen boyunuzu (metre cinsinde) giriniz: ");
        boy = scanner.nextDouble();
        System.out.print("Lütfen kilonuzu giriniz: ");
        kilo = scanner.nextDouble();

        VKI = kilo / Math.pow(boy, 2);

        System.out.println("Vücut Kitle İndeksiniz: " + VKI);
    }
}