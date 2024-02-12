import java.sql.SQLOutput;

public class Main {

    public static void printMatris(int[][] matris){
        for (int[] i: matris){
            for (int j: i){
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }

    public static void main(String[] args) {

        int[][] matris = {  {1, 2, 3},
                            {4 ,5 ,6}};
        
        int[][] transpose = new int[matris[0].length][matris.length];

        for (int i = 0; i < matris.length; i++) {
            for (int j = 0; j < matris[0].length; j++) {
                transpose[j][i] = matris[i][j];
            }
        }
        System.out.println("Matris: ");
        printMatris(matris);

        System.out.println("Transpoze: ");
        printMatris(transpose);
    }
}