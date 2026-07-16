using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Core
{
    internal class Employee
    {
        public String? FullName { get; set; }
        public IEnumerable<PayItem>? Items { get; set; }
    }
}
