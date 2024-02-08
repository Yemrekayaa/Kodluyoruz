import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n, result, lastResult = 1, tempResult = 0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Bir sayı giriniz: ");
        n = scanner.nextInt();

        System.out.print(0 + " " + 1);
        for (int i = 2; i < n; i++) {
            result = tempResult + lastResult;
            System.out.print(" " + result);
            tempResult = lastResult;
            lastResult = result;

        }

    }
}