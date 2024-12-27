internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Unesite broj");
        try
		{
			string userInput = Console.ReadLine();
			int broj = Convert.ToInt32(userInput);
            Console.WriteLine($"Unijeli ste {broj}.");
            BaciIzuzetak();
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Nije moguce pretvoriti, {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Desila se neka greska {ex.Message}");
        }
        finally { 
            Console.WriteLine("Uvijek se izvrsavam");
        }
    }

    static void BaciIzuzetak()
    {
        throw new NotImplementedException();
    }
}