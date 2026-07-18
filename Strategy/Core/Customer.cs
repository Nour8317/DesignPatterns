using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Core
{
    internal class Customer
    {
        public int? Id { get; set; }
        public String? Name { get; set; }
        public CustomerCategory category { get; set; }
    }
}
