using Strategy.Core;
using Strategy.Core.DescountStrategy;

var Customers = CustomerDataReader.GetCustomers();

while (true)
{
    Console.WriteLine("customer list: customer 1, customer 2");
    Console.Write("enter customer number: ");
    var customerId = int.Parse(Console.ReadLine());
    Console.Write("Enter Item quantity: ");
    var quantity = double.Parse(Console.ReadLine());
    Console.Write("Enter Item price: ");
    var price = double.Parse(Console.ReadLine());

    var customer = Customers.First(x=> x.Id == customerId);
    ICustomerDiscountStrategy discountStrategy = null;
    if(customer.category == CustomerCategory.silver)
    {
        discountStrategy = new SilverCustomerDiscountStrategy();
    }
    else if (customer.category == CustomerCategory.New)
    {
        discountStrategy = new NewCustomerDiscountStrategy();
    }
    else
    {
        throw new Exception("customer category not supported");
    }
    var invoiceManager = new InvoiceManager();
    invoiceManager.SetDiscountStrategy(discountStrategy);
    var invoice = invoiceManager.CreateInvoice(customer, quantity, price);
    Console.WriteLine($"invoice created for {customer.Name} with net price = {invoice.TotalPrice}");
    Console.WriteLine("enter any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("----------------------------------------");
}