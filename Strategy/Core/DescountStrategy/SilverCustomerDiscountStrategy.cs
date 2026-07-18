using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Core.DescountStrategy
{
    internal class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount()
        {
            return  0.1;
        }
    }
    
    
}
