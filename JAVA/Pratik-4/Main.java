import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        double gidilenMesafe, taksiAcilis = 10.0, taksiMinimum = 20.0, birimTutar = 2.2, toplamTutar;

        Scanner scanner = new Scanner(System.in);
        System.out.print("Gidilen Mesafeyi Giriniz: ");
        gidilenMesafe = scanner.nextDouble();

        toplamTutar = (gidilenMesafe * birimTutar) + taksiAcilis;
        toplamTutar = toplamTutar < taksiMinimum ? taksiMinimum : toplamTutar;

        System.out.println("Toplam tutar: " + toplamTutar + "₺");
    }
}