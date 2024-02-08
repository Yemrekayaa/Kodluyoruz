import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int yil;
        boolean artikYil = false;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Yıl Giriniz: ");
        if((yil = scanner.nextInt()) < 0){
            System.out.println("Hatalı Veri Girdiniz!");
            System.exit(0);
        }

        if(yil % 4 == 0){
            if(yil % 100 == 0){
                if(yil % 400 == 0) artikYil = true;
            }else{
                artikYil = true;
            }
        }

        if(artikYil) System.out.println(yil + " bir artık yıldır!");
        else System.out.println(yil + " bir artık yıl değildir!");
    }
}