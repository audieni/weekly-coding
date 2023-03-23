public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Sum(3, 2)); // 5
        Console.WriteLine(Sum(-3, -6)); // -9
        Console.WriteLine(Sum(7, 3)); // 10
    }

    private static int Sum(int x, int y)
    {
        return x + y;
    }
}