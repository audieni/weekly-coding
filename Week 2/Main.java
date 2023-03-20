import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        System.out.println(Arrays.toString(arrayOfMultiples(7, 5))); // [7, 14, 21, 28, 35]
        System.out.println(Arrays.toString(arrayOfMultiples(12, 10))); // [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
        System.out.println(Arrays.toString(arrayOfMultiples(17, 6))); // [17, 34, 51, 68, 85, 102]
    }

    private static int[] arrayOfMultiples(int num, int length) {
        int[] multiples = new int[length];
        for (int i = 0; i < length; i++) {
            multiples[i] = num * (i + 1);
        }
        return multiples;
    }
}