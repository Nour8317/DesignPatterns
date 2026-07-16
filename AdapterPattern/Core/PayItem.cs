using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Core
{
    internal class PayItem
    {
        public String? Title { get; set; }
        public Decimal? Amount { get; set; }
        public bool Deduct { get; set; } = false;
    }
}
