internal class Program
{
    delegate double Kalkulator(double x, double y);
    private static void Main(string[] args)
    {
        Kalkulator kalkulator = delegate (double x, double y)
        {
            return x + y;
        };

        Console.WriteLine(kalkulator(2,3));

        var osoba = new
        {
            Ime="Mujo",
            Prezime="Mujic",
            Godine=30
        };

        Console.WriteLine($"Ime: {osoba.Ime}, Prezime: {osoba.Prezime}, Godine: {osoba.Godine}");
    }
}