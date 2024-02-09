import java.util.Scanner;

public class Main {

    static boolean isPalindrom(int number){
        int temp = number, lastNumber, reverseNumber = 0;
        while (temp != 0){
            lastNumber = temp % 10;
            reverseNumber = (reverseNumber * 10) + lastNumber;
            temp = temp / 10;
        }
        if (number == reverseNumber) return true;
        else return false;

    }

    public static void main(String[] args) {
        int n;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Bir sayı giriniz: ");
        n = scanner.nextInt();
        boolean isPolindrom = isPalindrom(n);
        System.out.println(n + " sayısı Polindrom bir sayı" + (isPolindrom ? "dır." : " değildir."));
    }
}