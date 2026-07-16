using System.Diagnostics;

namespace PayrollSystem.Core
{
    public class PayrollCalculator
    {
        public Decimal Calculate(Employee employee)
        {
            Debug.WriteLine($"Calculating payroll for employee: {employee.FullName}");

            IEnumerable<PayItem> items = employee.Items ?? Enumerable.Empty<PayItem>();
            Decimal total = 0;
            foreach (var item in items)
            {
                if (item.Amount.HasValue)
                {
                    total += item.Amount.Value;
                }
            }
            return total/30;
        }
    }
}
