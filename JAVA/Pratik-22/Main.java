import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n1, n2;
        double sonuc;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Sayı Giriniz: ");
        n1 = scanner.nextInt();
        System.out.print("Üs Giriniz: ");
        n2 = scanner.nextInt();

        if(n2 < 0){
            n2 *= -1;
        }

        for(sonuc = 1; n2 > 0 ; n2--){
            sonuc *= n1;
        }

        if(n2 < 0){
            sonuc = 1 / sonuc;
        }
        
        System.out.print(sonuc);
    }
}