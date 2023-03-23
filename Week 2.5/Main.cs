public class Main
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CircuitPower(230, 10)); // 2300
        Console.WriteLine(CircuitPower(110, 3)); // 330
        Console.WriteLine(CircuitPower(480, 20)); // 9600
    }

    private static int CircuitPower(int voltage, int current)
    {
        return voltage * current;
    }
}