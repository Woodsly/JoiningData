using JoiningData;

List<Customer> Customers = new List<Customer>()
{
    new Customer("Acme Hardware", "Mouse", 25m, 3),
    new Customer("Acme Hardware", "Keyboard", 45m, 2),
    new Customer("Falls Realty", "Macbook", 800m, 2),
    new Customer("Julie's Morning Diner", "iPad", 525m, 1),
    new Customer("Julie's Morning Diner", "Credit Card Reader", 45, 1)
};

List<Customer> distinctCustomerOrders = Customers.GroupBy(o => o.CustomerName).Select(c => c.First()).ToList();

//exercise 1
//foreach (Customer distinctCustomer in distinctCustomerOrders)
//{
//    Console.WriteLine(distinctCustomer.CustomerName);
//    List<Customer> CustomerOrders = Customers.Where(o => o.CustomerName == distinctCustomer.CustomerName).ToList();
//    Console.WriteLine("Item\tPrice\tQuantity\tTotal");
//    foreach (Customer o in CustomerOrders)
//    {
//        Console.WriteLine($"{o.Item}\t{o.Price}\t{o.Quantity}\t{o.Price * o.Quantity}");
//    }
//    Console.WriteLine();
//}

//exercise 2
//foreach (Customer distinctCustomer in distinctCustomerOrders)
//{
//    decimal total = 0;
//    Console.WriteLine(distinctCustomer.CustomerName);
//    List<Customer> CustomerOrders = Customers.Where(o => o.CustomerName == distinctCustomer.CustomerName).ToList();
//    Console.WriteLine("Customer\tItem\tPrice\tQuantity\tTotal");
//    foreach (Customer o in CustomerOrders)
//    {
//        Console.WriteLine($"{o.Item}\t{o.Price}\t{o.Quantity}\t{o.Price * o.Quantity}");
//        total += o.Price * o.Quantity;
//    }
//    Console.WriteLine(total);
//    Console.WriteLine();
//}

//exercise 3
foreach (Customer distinctCustomer in distinctCustomerOrders)
{
    decimal total = 0;
    Console.WriteLine(distinctCustomer.CustomerName);
    List<Customer> CustomerOrders = Customers.Where(o => o.CustomerName == distinctCustomer.CustomerName).ToList();
    Console.WriteLine("Customer\tItem\tPrice\tQuantity\tTotal");
    foreach (Customer o in CustomerOrders)
    {
        Console.WriteLine($"{o.Item}\t{o.Price}\t{o.Quantity}\t{o.Price * o.Quantity}");
        total += o.Price * o.Quantity;
    }
    Console.WriteLine(total);
    Console.WriteLine();
}

//foreach (Customer c in Customers)
//{
//    if (UniqueCustomers.Contains(c.CustomerName))
//    {
//        continue;
//    }
//    else
//    {
//        UniqueCustomers.Add(c.CustomerName);
//    }
//}