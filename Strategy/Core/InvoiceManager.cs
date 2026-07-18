using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Core.DescountStrategy;

namespace Strategy.Core
{
    internal class InvoiceManager
    {
        public ICustomerDiscountStrategy _discountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double price)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new List<InvoiceLine>
                {
                    new InvoiceLine { quantity = quantity, price = price }
                }
            };
            invoice.DiscountPercentage = _discountStrategy.CalculateDiscount();
            return invoice;
        }
    }
}
