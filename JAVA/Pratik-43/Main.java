import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Sayı Giriniz: ");
        int n = scanner.nextInt();

        int[] list = {15,12,788,1,-1,-778,2,0};

        int min = Integer.MIN_VALUE;
        int max = Integer.MAX_VALUE;

        for (int i : list) {
           if(i > n){
               if(i < max){
                   max = i;
               }
           }
           if(i < n){
               if(i > min){
                   min = i;
               }
           }
        }

        System.out.println("Girdiğiniz sayıya yakın Minimum Değer " + min);
        System.out.println("Girdiğiniz sayıya yakın Maximum Değer " + max);

    }


}