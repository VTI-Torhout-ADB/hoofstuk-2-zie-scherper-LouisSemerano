namespace Euro_naar_dollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bedragInEuro = 78.65;
            double dollarwaarde = bedragInEuro * 1.01;
            Console.WriteLine($"{bedragInEuro} EUR is gelijk aan {dollarwaarde} USD");
        }
    }
}
