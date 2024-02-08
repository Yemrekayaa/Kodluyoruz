import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n, sonuc = 0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("N Giriniz: ");
        n = scanner.nextInt();
        while (n > 0){
            sonuc += n % 10;
            n /= 10;
        }

        System.out.println(sonuc);

    }
}