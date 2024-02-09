import java.util.Scanner;

public class Main {

    static boolean isPrime(int n, int i){
        if(n == 2) return true;
        if(n % i == 0 || n == 1) return false;
        if(i == Math.ceil(Math.sqrt(n))) return true;

        return isPrime(n, i + 1);
    }

    public static void main(String[] args) {
        int n;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Sayı giriniz: ");
        n = scanner.nextInt();
        System.out.println(n + " sayısı ASAL" + (isPrime(n,2) ? "DIR!" : " DEĞİLDİR!"));
    }
}