import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n1, n2, select, sonuc;


        Scanner scanner = new Scanner(System.in);
        System.out.print("İlk Sayıyı Giriniz: ");
        n1 = scanner.nextInt();
        System.out.print("İkinci Sayıyı Giriniz: ");
        n2 = scanner.nextInt();

        System.out.println("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme");
        System.out.print("Seçiminiz: ");
        select = scanner.nextInt();
        if (select == 4 && n2 == 0){

        }

        switch (select){
            case 1:
                sonuc = n1 + n2;
                break;
            case 2:
                sonuc = n1 - n2;
                break;
            case 3:
                sonuc = n1 * n2;
                break;
            case 4:
                if(n2 == 0){
                    System.out.println("0'a bölüm yapılamaz.");
                    return;
                }
                sonuc = n1 / n2;
                break;
            default:
                System.out.println("Yanlış seçim yaptınız lütfen tekrar deneyiniz.");
                return;
        }
        System.out.println(sonuc);
    }
}