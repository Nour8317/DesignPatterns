using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the base currency please: ");
            string baseCurrency = Console.ReadLine();
            Console.WriteLine("Enter the target currency please: ");
            string targetCurrency = Console.ReadLine();
            Console.WriteLine("Enter the amount: ");
            decimal amount = decimal.Parse(Console.ReadLine()!);
            decimal result = CurrencyConverter.Convert(baseCurrency, targetCurrency, amount);
            Console.WriteLine(result.ToString());
            Console.WriteLine("--------------------------------------------");

        }
    }
}