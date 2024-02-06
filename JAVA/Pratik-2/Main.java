import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        double tutar, kdvOran, kdvTutar, kdvliTutar;

        Scanner scanner = new Scanner(System.in);


        System.out.print("Ücret Tutarını Giriniz: ");
        tutar = scanner.nextDouble();

        kdvOran = tutar > 1000 ? 0.08 : 0.18;
        kdvTutar = tutar * kdvOran;
        kdvliTutar = tutar + kdvTutar;

        System.out.println("KDV'siz Tutar: " + tutar + "₺");
        System.out.println("KDV Oranı: %" + (kdvOran * 100));
        System.out.println("KDV Tutarı: " + kdvTutar + "₺");
        System.out.println("KDV'li Tutar: " + kdvliTutar + "₺");
    }
}