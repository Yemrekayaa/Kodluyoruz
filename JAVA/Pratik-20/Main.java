import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Sayı Giriniz: ");
        n = scanner.nextInt();

        for (int i = 1; i <= n; i++) {
            int tempI = i;
            int j = 0;
            if(tempI % 4 == 0){
                while (tempI % 4 == 0){
                    tempI /= 4;
                    j++;
                }
                if(tempI == 1) System.out.println(" 4^" + j + " = " + i);
            }
            tempI = i;
            j = 0;
            if(tempI % 5 == 0){
                while (tempI % 5 == 0){
                    tempI /= 5;
                    j++;
                }
                if(tempI == 1) System.out.println(" 5^" + j + " = " + i);
            }
        }
    }
}