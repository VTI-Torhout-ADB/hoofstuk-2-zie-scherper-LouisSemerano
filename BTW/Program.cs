namespace BTW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prijs = 20;
            const double BTW = 1.21;
            double totaal = prijs * BTW;
            Console.WriteLine($"{prijs} euro zonder btw. Met BTW: {totaal} euro.");
        }
    }
}
