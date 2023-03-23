public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CheckEquality(1, true));
        Console.WriteLine(CheckEquality(0, "0"));
        Console.WriteLine(CheckEquality(1,  1));
    }

    private static bool CheckEquality(object a, object b)
    {
        return a.GetType() == b.GetType() && a.Equals(b);
    }
}