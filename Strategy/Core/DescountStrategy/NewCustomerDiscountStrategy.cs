using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Core.DescountStrategy
{
    internal class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount()
        {
            return 0;
        }
    }

}
