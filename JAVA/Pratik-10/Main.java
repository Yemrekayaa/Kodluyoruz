import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // Değişkenler
        int mat, fizik, kimya, turkce, tarih, muzik, toplam = 0, dersSayisi = 0;

        // Scanner tanımlama
        Scanner scanner = new Scanner(System.in);

        // Kullanıcıdan veri al
        System.out.println("Matematik Notunuz: ");
        mat = scanner.nextInt();
        if(mat >= 0 && mat <= 100){
            dersSayisi++;
            toplam += mat;
        }
        System.out.println("Fizik Notunuz: ");
        fizik = scanner.nextInt();
        if(fizik >= 0 && fizik <= 100){
            dersSayisi++;
            toplam += fizik;
        }
        System.out.println("Kimya Notunuz: ");
        kimya = scanner.nextInt();
        if(kimya >= 0 && kimya <= 100){
            dersSayisi++;
            toplam += kimya;
        }
        System.out.println("Türkçe Notunuz: ");
        turkce = scanner.nextInt();
        if(turkce >= 0 && turkce <= 100){
            dersSayisi++;
            toplam += turkce;
        }
        System.out.println("Tarih Notunuz: ");
        tarih = scanner.nextInt();
        if(tarih >= 0 && tarih <= 100){
            dersSayisi++;
            toplam += tarih;
        }
        System.out.println("Müzik Notunuz: ");
        muzik = scanner.nextInt();
        if(muzik >= 0 && muzik <= 100){
            dersSayisi++;
            toplam += muzik;
        }

        double ortalama = toplam / dersSayisi;
        String durum = ortalama > 55 ? "Sınıfı Geçti" : "Sınıfta kaldı";
        System.out.println(durum);
    }
}