import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        final double armut = 2.14, elma = 3.67, domates = 1.11, muz = 0.95, patlican = 3.00;
        double tutar = 0;

        Scanner scanner = new Scanner(System.in);
        System.out.print("Armut Kaç Kilo ?: ");
        tutar += armut * scanner.nextDouble();
        System.out.print("Elma Kaç Kilo ?: ");
        tutar += elma * scanner.nextDouble();
        System.out.print("Domates Kaç Kilo ?: ");
        tutar += domates * scanner.nextDouble();
        System.out.print("Muz Kaç Kilo ?: ");
        tutar += muz * scanner.nextDouble();
        System.out.print("nPatlıca Kaç Kilo ?: ");
        tutar += patlican * scanner.nextDouble();

        System.out.println("Toplam Tutar: " + tutar);
    }
}