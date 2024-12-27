internal class Program
{
    private static void Main(string[] args)
    {
        (int, int) tupl1 = (2, 3);
        int x = tupl1.Item1;
        int y = tupl1.Item2;
        Console.WriteLine(x);
        Console.WriteLine(y);

        var tupl2 = (3, 4);
        Console.WriteLine(tupl2);

        (int a, int b) tupl3 = (a: 5, b: 6);
        Console.WriteLine(tupl3.a);
        Console.WriteLine(tupl3.b);

        var tupl4 = (a:3, b:4);
        Console.WriteLine(tupl4.a);
        Console.WriteLine(tupl4.b);

        int[] niz = {1,2,3,4,5,6,7,8,9};
        try
        {
            var res = PronadiMinMax(niz);
            Console.WriteLine(res);
            var (min, max) = PronadiMinMax(niz);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }

    static (int namjanji, int najveci) PronadiMinMax(int[] niz)
    {
        if(niz is null || niz.Length == 0)
        {
            throw new Exception("Prazan niz");
        }

        var min = int.MaxValue; 
        var max =int.MinValue;
        foreach(int n in niz)
        {
            if(n<min) { min = n; }
            if (n > max) { max = n; }
        }
        return (min, max);
    }
}