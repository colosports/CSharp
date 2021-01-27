using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);

            //var customer = new Customer(1, "john");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }

}
