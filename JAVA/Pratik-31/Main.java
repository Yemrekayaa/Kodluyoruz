import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        int n;
        

        for (int i = 2; i <= 100; i++) {
            if(i == 2) System.out.print(i + " ");
            if(i % 2 == 0) continue;
            boolean asal = true;
            for (int j = 2; j < i - 1; j++) {
                if(i % j == 0){
                    asal = false;
                }
            }
            System.out.print(asal ? i + " " : "");
        }

    }
}