import java.util.Arrays;

public class Main {

    static boolean isFind(int[] array, int value){
        for(int i : array){
            if(i == value)
                return true;
        }
        return false;
    }

    public static void main(String[] args) {
        int[] array = {0,1,1,2,3,4,5,5,6,6,6,7,8,8,9,10};
        int[] newArray = new int[array.length];

        int index = 0;

        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                if ((i != j) && array[i] == array[j]) {
                    if(!isFind(newArray,array[j]) && array[j] % 2 == 0){
                        newArray[index] = array[j];
                        index++;
                    }

                }
            }
        }

        for(int i : newArray){
            if(i != 0)
                System.out.print(i + " ");
        }
    }
}