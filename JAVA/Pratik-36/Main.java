import java.util.Scanner;

public class Main {

    static int pow(int taban, int us){
        if (us == 0) return 1;

        return taban * pow(taban, us - 1);
    }

    public static void main(String[] args) {
        int n1, n2;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Taban giriniz: ");
        n1 = scanner.nextInt();
        System.out.print("Us giriniz: ");
        n2 = scanner.nextInt();
        System.out.println(pow(n1,n2));
    }
}