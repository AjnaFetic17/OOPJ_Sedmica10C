internal class Program
{
    private static void Main(string[] args)
    {
        //Napisati program koji koristi lambda izraz za racunanje faktorijela.
        //za n = 4
        //1*2*3*4
        Func<int, int> faktorijel = n =>
        {
            int rezultat = 1;
            for(int i = 1; i <= n; i++)
            {
                rezultat *= i;
            }
            return rezultat;
        };

        Console.WriteLine(faktorijel(4));
        Console.WriteLine(faktorijel(6));
    }
}