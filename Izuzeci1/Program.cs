internal class Program
{
    private static void Main(string[] args)
    {
		//Korisnik unosi 3cifren broj, ako broj nije 3cifren potrebno je baciti i obraditi izuzetak
		try
		{
            string unos = Console.ReadLine();
            int broj = Convert.ToInt32(unos);

            if(broj<100 || broj > 1000)
            {
                throw new ArgumentOutOfRangeException("Unijeli ste broj koji koji nije 3cifren");
            }
            Console.WriteLine(broj);
        }
        catch (ArgumentOutOfRangeException ex)
		{
            Console.WriteLine(ex.Message);
        }
        finally { Console.WriteLine("Zavrsili te sa unosom broja"); }

    }
}