using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Core.DescountStrategy
{
    public interface ICustomerDiscountStrategy
    {
        public double CalculateDiscount();
    }
}
