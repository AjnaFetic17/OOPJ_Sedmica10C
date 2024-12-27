internal class Program
{
    private static void Main(string[] args)
    {
        int? broj = null;

        int? v = 42;
        if (v.HasValue)
        {
            Console.WriteLine(v.Value);
        }

        int? x = 5;
        int? y = 10;
        bool b = x < y;

        bool c = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;
        Console.WriteLine($"{b},{c}");

        int? d = null;
        int? e = d ?? 5;
        Console.WriteLine(e);
        int? f = null;
        int? g = 2;
        int? h = 4;
        Console.WriteLine(f??g??h);
    }
}