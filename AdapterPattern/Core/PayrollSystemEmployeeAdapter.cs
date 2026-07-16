using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Core
{

    internal class PayrollSystemEmployeeAdapter
    {
        private readonly Employee employee;
        private readonly IEnumerable<PayrollSystemPayitemAdapter> payitmes;
        public PayrollSystemEmployeeAdapter(Employee _employee)
        {
            employee = _employee;
            payitmes = employee.Items.Select(items => new PayrollSystemPayitemAdapter(items)).ToList();
        }
        public String? FullName => employee.FullName;
        public IEnumerable<PayrollSystemPayitemAdapter>? Items => payitmes;
    }
}
