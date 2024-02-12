public class Main {
    public static void main(String[] args) {

        int[] numbers = {1, 2, 3, 4, 5};
        double harmonikToplam = 0;
        for (int i : numbers){
            harmonikToplam += 1.0 / i;
        }
        System.out.println(numbers.length / harmonikToplam);

    }
}