using System.Security.Cryptography.X509Certificates;

namespace Singleton
{
    internal class CurrencyConverter
    {
        public IEnumerable<ExchangeRate>? ExchangeRates;
        //public static CurrencyConverter? Instance = new(); eager initialization
        public static CurrencyConverter? Instance;
        public static object _lock = new object();
        private CurrencyConverter()
        {
            Load();
        }
        private void Load()
        {
            Thread.Sleep(2000);

            ExchangeRates = new[] {
                new ExchangeRate("USD", "EUR", 0.85m),
                new ExchangeRate("EUR", "USD", 1.18m),
                new ExchangeRate("USD", "GBP", 0.75m)
            };
        }
        public static CurrencyConverter GetInstance()
        {
            //lazy initialization
            //lock for thread safety
            lock (_lock)
            {
                if (Instance == null)
                {
                    Instance = new CurrencyConverter();
                }
            }
            return Instance;
        }
        public static Decimal Convert(String Base, String Target, Decimal Amount)
        {
            CurrencyConverter _instance = GetInstance();
            Decimal result = 0;
            Decimal rate = _instance.ExchangeRates.FirstOrDefault(rate => rate.BaseCurrency == Base && rate.TargetCurrency == Target)?.Rate ?? 0;
            result = Amount * rate;
            return result;
        }
    }
}
