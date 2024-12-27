internal class Program
{
    private static void Main(string[] args)
    {
        Func<int, int, int> saberi = (a, b) => a + b;
        Console.WriteLine(saberi(3,4));

        Action<string> pozdrav = ime =>
        {
            string s = $"Zdravo, moje ime je {ime}";
            Console.WriteLine(s);
        };
        pozdrav("Ajna");
    }
}