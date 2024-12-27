internal class Program
{
    delegate double Operacija (double x, double y);
    private static void Main(string[] args)
    {
        //Napisati program koji koristi anonimne metode za obavljanje razlicitih matematickih operacija (+,*,-,/)
        //Koristit delegat za pohranu svake operacije i pozvati svaku operaciju za svaki broj u nizu brojeva i broj 5
        double[] brojevi = { 10, 20, 30, 40, 50 };

        Operacija sabiranje = delegate (double x, double y) { return x + y; };
        Operacija mnozenje = delegate (double x, double y) { return x * y; };
        Operacija oduzimanje = delegate (double x, double y) { return x - y; };
        Operacija dijeljenje = delegate (double x, double y) { return y != 0 ? x / y : 0; };

        foreach (var broj  in brojevi)
        {
            Console.WriteLine($"Za broj {broj}");
            Console.WriteLine($"sabiranje {sabiranje(broj, 5)}");
            Console.WriteLine($"mnozenje {mnozenje(broj, 5)}");
            Console.WriteLine($"oduzimanje {oduzimanje(broj, 5)}");
            Console.WriteLine($"dijeljenje {dijeljenje(broj, 5)}");
        }

    }
}