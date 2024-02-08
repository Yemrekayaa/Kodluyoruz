import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n1, n2, ebob = 1, ekok = 0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Birinci Sayıyı Giriniz: ");
        n1 = scanner.nextInt();
        System.out.print("İkinci Sayıyı Giriniz: ");
        n2 = scanner.nextInt();

        int temp1 = n1, temp2 = n2;
        while (temp2 > 0){
            if(temp1 < temp2){
                int tempN = temp1;
                temp1 = temp2;
                temp2 = tempN;
            }
            if(temp1 % temp2 == 0){
                ebob = temp2;
                break;
            }
            temp1 = temp1 - temp2;
            System.out.println("n1: " + n1 + ", n2: " + n2);
        }

        ekok = (n1 * n2) / ebob;
        System.out.println("EBOB:" + ebob);
        System.out.println("EKOK:" + ekok);


    }
}