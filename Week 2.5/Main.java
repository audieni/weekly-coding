public class Main {
    public static void main(String[] args) {
        System.out.println(isSameNum(4, 8)); // false
        System.out.println(isSameNum(2, 2)); // true
        System.out.println(isSameNum(42, 32)); // false
    }

    private static boolean isSameNum(int x, int y) {
        return x == y;
    }
}