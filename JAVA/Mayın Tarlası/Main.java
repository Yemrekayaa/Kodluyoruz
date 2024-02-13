import java.util.Scanner;

public class Main {


    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Oyun Boyutunu Giriniz: ");
        MineSwepper ms = new MineSwepper(scanner.nextInt());
        ms.run();


    }
}

