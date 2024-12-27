internal class Program
{
    private static void Main(string[] args)
    {
        //Napraviti progrm koji koristi anonimne metode za filtriranje niz anonimnih tipova
        //Filtrirati osobe koje imaju vise od 25 godina

        var ljudi = new[]
        {
            new { Ime="Mujo", Prezime="Mujic", Godine=30},
            new { Ime="Suljo", Prezime="Suljic", Godine=28},
            new { Ime="Anto", Prezime="Antic", Godine=24},
            new { Ime="Ivo", Prezime="Ivic", Godine=25},
        };

        Func<dynamic, bool> starijiOd25 = delegate (dynamic osoba) {
            return osoba.Godine>25;
        };

        foreach (var osoba in ljudi)
        {
            if (starijiOd25(osoba))
            {
                Console.WriteLine($"Ime: {osoba.Ime}, Prezime: {osoba.Prezime}, Godine: {osoba.Godine}");
            }
        }
    }
}