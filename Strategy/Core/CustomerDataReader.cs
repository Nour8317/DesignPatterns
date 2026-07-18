using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Core
{
    internal class CustomerDataReader
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Nour Eldeen" , category = CustomerCategory.silver},
                new Customer { Id = 2, Name = "Mahmoud Adel" , category = CustomerCategory.New},
                new Customer { Id = 3, Name = "Kareem" , category = CustomerCategory.silver}
            };
        }

    }
}
