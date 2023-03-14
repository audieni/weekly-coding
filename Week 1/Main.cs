public class Main
{
    public static void Main(string[] args)
    {
        Console.WriteLine(sum(3, 2)); // 5
        Console.WriteLine(sum(-3, -6)); // -9
        Console.WriteLine(sum(7, 3)); // 10
    }

    private static int sum(int x, int y)
    {
        return x + y;
    }
}