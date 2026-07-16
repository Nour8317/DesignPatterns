using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class ExchangeRate
    {
        public String? BaseCurrency;
        public String? TargetCurrency;
        public Decimal Rate;

        public ExchangeRate(string baseCurrency, string targetCurrency, decimal rate)
        {
            BaseCurrency = baseCurrency;
            TargetCurrency = targetCurrency;
            Rate = rate;
        }
    }
}
