import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Dizinin boyutunu giriniz: ");
        int length = scanner.nextInt();
        int[] array = new int[length];
        
        System.out.println("Dizinin Elemanlarını giriniz: ");
        for (int i = 0; i < length; i++) {
            System.out.print((i + 1) + ". Elemanı Giriniz: ");
            array[i] = scanner.nextInt();
        }

        Arrays.sort(array);
        System.out.println(Arrays.toString(array));


    }
}