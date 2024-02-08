import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n, toplam = 0;
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.print("Sayı Giriniz: ");
            n = scanner.nextInt();
            if(n % 2 != 0) break;
            else if (n % 4 == 0){
                toplam+= n;
            }
        }

        System.out.println("Toplam: " + toplam);

    }
}