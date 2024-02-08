import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int sicaklik;

        Scanner scanner = new Scanner(System.in);

        System.out.print("Sıcaklık giriniz: ");
        sicaklik = scanner.nextInt();

        if(sicaklik > 25){
            System.out.println("Yüzmeye gidebilirisiniz!");
        } else {
            if (sicaklik >= 10) {
                System.out.println("Piknik yapmaya gidin!");
            }
            if (sicaklik >= 5 && sicaklik <= 15) {
                System.out.println("Sinemaya gidin!");
            }else {
                System.out.println("Kayak yapmaya gidin!");
            }

        }
        
    }
}