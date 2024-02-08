import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int dogumYili;
        String[] burclar = {"Maymun","Horoz","Köpek","Domuz","Fare","Öküz","Kaplan","Tavşan","Ejderha","Yılan","At","Koyun"};
        Scanner scanner = new Scanner(System.in);

        System.out.print("Doğum Yılını Giriniz: ");
        if((dogumYili = scanner.nextInt()) < 0 || dogumYili > 2024){
            System.out.println("Hatalı Veri Girdiniz!");
            System.exit(0);
        }

        System.out.println("Çin Zodyağı Burcunuz: " + burclar[dogumYili % 12]);


    }
}