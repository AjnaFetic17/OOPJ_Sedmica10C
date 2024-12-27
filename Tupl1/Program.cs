internal class Program
{

    static (int ukupnoBodova, int brojPolozenih) AnalizaStudenata((string, int)[] studenti)
    {
        int ukupnoBodova = 0;
        int brojPolozenih = 0;

        foreach (var student in studenti)
        {
            ukupnoBodova = ukupnoBodova + student.Item2;
            if (student.Item2 > 50)
            {
                brojPolozenih++;
            }
        }
        return (ukupnoBodova, brojPolozenih);
    }

    private static void Main(string[] args)
    {
        //Napraviti metodu koja prima niz tupla (svaki sadrzi ime i broj bodova studenta) i vraca tupl koji sadrzi
        //ukupne bodove svih studenata i broj studenata koji su imali vis eod 50 bodova

        var studenti = new(string, int)[]
        {
            ("Marko", 45),
            ("Mujo", 60),
            ("Sara", 70),
            ("Suljo", 50)
        };
        var (ukupnoBodova, brojPolozenih) = AnalizaStudenata(studenti);
        Console.WriteLine(ukupnoBodova);
        Console.WriteLine(brojPolozenih);

    }
}