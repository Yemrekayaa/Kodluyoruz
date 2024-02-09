import java.util.Scanner;

public class Main {

    static int getFibonacci(int sayac){
        if (sayac == 1 || sayac == 2) return 1;

        return getFibonacci(sayac - 1) + getFibonacci(sayac - 2);
    }

    public static void main(String[] args) {
        int n;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Bir sayı giriniz: ");
        n = scanner.nextInt();
        System.out.println(getFibonacci(n));
    }
}