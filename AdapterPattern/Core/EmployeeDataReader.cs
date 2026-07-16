using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Core
{
    internal class EmployeeDataReader
    {
        public IEnumerable<Employee> ReadEmployees()
        {
           
            return new List<Employee>
            {
                new Employee
                {
                    FullName = "Nour Eldeen",
                    Items = new List<PayItem>
                    {
                        new PayItem { Title = "Base Salary", Amount = 5000, Deduct = false},
                        new PayItem { Title = "Bonus", Amount = 1000, Deduct = false},
                        new PayItem { Title = "Medical Insurance", Amount = 100, Deduct = true}
                    }
                },
                new Employee
                {
                    FullName = "Jane Smith",
                    Items = new List<PayItem>
                    {
                        new PayItem { Title = "Base Salary", Amount = 6000 , Deduct = false},
                        new PayItem { Title = "Commission", Amount = 1500 , Deduct = false},
                        new PayItem { Title = "Medical Insurance", Amount = 100, Deduct = true}
                    }
                }
            };
        }
    }
}
