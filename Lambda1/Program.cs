internal class Program
{
    private static void Main(string[] args)
    {
        //Napisati program koji koristi lambda izraz za filtriranje i ispisivanje svih rijeci u recenici koje pocinju velikim slovom 

        string recenica = "Ovo je primjer za testiranje lambda izraza. Ovdje imamo Veliko i malo slovo.";

        string[] rijeci =recenica.Split(' ');

        foreach(var rijec in rijeci)
        {
            if(IsPrvoVelikoSlovo(rijec))
            {
                Console.WriteLine(rijec);
            }
        }
    }

    static bool IsPrvoVelikoSlovo(string rijec) => char.IsUpper(rijec[0]);
}