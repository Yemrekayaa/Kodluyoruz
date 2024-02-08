import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n1, n2, n3, tempNum;

        Scanner scanner = new Scanner(System.in);

        System.out.print("1. Sayı: ");
        n1 = scanner.nextInt();

        System.out.print("2. Sayı: ");
        n2 = scanner.nextInt();
        if(n1 > n2){
            tempNum = n2;
            n2 = n1;
            n1 = tempNum;
        }

        System.out.print("3. Sayı: ");
        n3 = scanner.nextInt();
        if (n2 > n3){
            tempNum = n3;
            n3 = n2;
            n2 = tempNum;
            if(n1 > n2){
                n2 = n1;
                n1 = tempNum;
            }
        }

        System.out.println(n1 + " < " + n2 + " < " + n3);

    }
}