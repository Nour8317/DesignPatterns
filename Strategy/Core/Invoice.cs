using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Strategy.Core;
namespace Strategy.Core
{
    internal class Invoice
    {
        public Customer Customer { get; set;  }
        public IEnumerable<InvoiceLine> Lines { get; set; } = null;  
        public Double? TotalPrice => (double)Lines.Sum(line => line.quantity * line.price) - (double)Lines.Sum(line => line.quantity * line.price) * DiscountPercentage;
        public double DiscountPercentage { get; set; }
    }
}
