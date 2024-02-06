import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // Değişkenler
        int mat, fizik, kimya, turkce, tarih, muzik;

        // Scanner tanımlama
        Scanner scanner = new Scanner(System.in);

        // Kullanıcıdan veri al
        System.out.println("Matematik Notunuz: ");
        mat = scanner.nextInt();

        System.out.println("Fizik Notunuz: ");
        fizik = scanner.nextInt();

        System.out.println("Kimya Notunuz: ");
        kimya = scanner.nextInt();

        System.out.println("Türkçe Notunuz: ");
        turkce = scanner.nextInt();

        System.out.println("Tarih Notunuz: ");
        tarih = scanner.nextInt();

        System.out.println("Müzik Notunuz: ");
        muzik = scanner.nextInt();

        int toplam = mat + fizik + kimya + turkce + tarih + muzik;
        double sonuc = toplam / 6.0;
        String durum = sonuc >= 60 ? "Sınıfı Geçti" : "Sınıfta kaldı";
        System.out.println(durum);
    }
}