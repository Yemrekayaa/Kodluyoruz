import java.util.Scanner;

public class Main {

    static void pattern(int n, int temp, boolean durum){
        System.out.print(n + " ");
        if(n <= 0)
            durum = false;

        n = durum ? n - 5 : n + 5;

        if(n <= temp)
            pattern(n,temp,durum);

    }

    public static void main(String[] args) {
        int n;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Sayı giriniz: ");
        n = scanner.nextInt();
        pattern(n, n,true);
    }
}