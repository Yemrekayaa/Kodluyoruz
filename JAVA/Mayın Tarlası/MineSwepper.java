import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class MineSwepper {
    String[][] gameArea;
    String[][] playerArea;
    private int mineCount;
    private int openedCell;


    public MineSwepper(int boyut) {
        this.gameArea = new String[boyut][boyut];
        this.playerArea = new String[boyut][boyut];
        this.mineCount = (boyut * boyut) / 4;
        this.openedCell = 0;
    }

    public void loadArea(){
        for (int i = 0; i < gameArea.length; i++) {
            Arrays.fill(gameArea[i], " - ");
            Arrays.fill(playerArea[i], " - ");
        }

        Random rand = new Random();
        for (int i = 0; i < this.mineCount; i++) {
            do {
                int satir = rand.nextInt(gameArea.length);
                int sutun = rand.nextInt(gameArea.length);
                if(gameArea[satir][sutun] == " * ") continue;
                else {
                    gameArea[satir][sutun] = " * ";
                    break;
                }
            }while (true);
        }
    }

    public void printArea(){
        for(String[] area : playerArea){
            for(String str : area){
                System.out.print(str);
            }
            System.out.println();
        }
    }

    public void selectCell(int satir, int sutun){
        if(!playerArea[satir][sutun].equals(" - ")){
            System.out.println("Zaten burayı seçtiniz!");
        }
        else if(gameArea[satir][sutun].equals(" * ")){
            System.out.println("--- Game Over! ---");
            System.exit(0);
        } else if (gameArea[satir][sutun].equals(" - ")) {
            int mineCount = 0;
            for (int i = sutun - 1; i <= sutun + 1 ; i++) {
                    if(i == -1 || i == gameArea.length) continue;
                for (int j = satir -1; j <= satir + 1; j++) {
                    if(j == -1 || j == gameArea.length) continue;
                    if(gameArea[j][i].equals(" * ")) mineCount++;
                }
            }
            playerArea[satir][sutun] = (" " + mineCount + " ");
            openedCell++;
            if(openedCell == (gameArea.length * gameArea.length) - this.mineCount){
                System.out.println("--- Oyunu Kazandınız! ---");
                printArea();
                System.exit(0);
            }
        }
    }


    public void run(){
        loadArea();
        printArea();
        Scanner scanner = new Scanner(System.in);

        do {
            System.out.print("Satır Giriniz: ");
            int satir = scanner.nextInt();
            System.out.print("Sutun Giriniz: ");
            int sutun = scanner.nextInt();
            if(satir < 0 || satir > gameArea.length - 1 || sutun < 0 || sutun > gameArea.length - 1){
                System.out.println("Geçerli bir yer değil! Tekrar Deneyiniz! ");
                continue;
            }
            selectCell(satir,sutun);
            printArea();
        }while (true);
    }
}
