import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static int isFind(int[][] array, int value){
        for (int i = 0; i < array.length; i++) {
            if(array[i][0] == value)
                return i;
        }
        return -1;
    }

    public static void main(String[] args) {

        int[] array = {1,1,2,3,3,4,5,5,5,6,7};
        int[][] frekans = new int[array.length][2];
        int index = 0;

        for (int i = 0; i < array.length; i++) {

            int frekansIndex = isFind(frekans,array[i]);
            if(frekansIndex == -1 ){
                frekans[index][0] = array[i];
                frekans[index][1] = 1;
                index++;
            }else{
                frekans[frekansIndex][1] += 1;
            }
        }

        for (int i = 0; i < frekans.length; i++) {
            if(frekans[i][1] != 0){
                System.out.println(frekans[i][0] + " sayısı " + frekans[i][1] + " kere tekrar edildi.");
            }
        }

    }
}