public class Main {
    public static void main(String[] args) {
         System.out.println(convert(5)); // 300
         System.out.println(convert(3)); // 180
         System.out.println(convert(2)); // 120
    }

    private static int convert(int minutes) {
        return minutes * 60;
    }
}