namespace PayrollSystem.Core
{
    public class Employee
    {
        public String? FullName { get; set; }
        public IEnumerable<PayItem>? Items { get; set; }
    }
}
