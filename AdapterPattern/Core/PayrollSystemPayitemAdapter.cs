using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Core
{
    internal class PayrollSystemPayitemAdapter
    {
        private readonly PayItem payitem;
        public PayrollSystemPayitemAdapter(PayItem _payItem)
        {
            payitem = _payItem;
            
        }
        public String? Title => payitem.Title;
        public Decimal? Amount => (payitem.Deduct = true) ? payitem.Amount : payitem.Amount * -1;
    }
}
