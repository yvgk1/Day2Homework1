using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Name = "Test";
            customer.LastName = "Test";
            customer.Id = 1;
            customer.City = "Test";

            Customer customer2 = new Customer
            {
                Id = 2,City = "Ankara",Name = "Derin",LastName = "Test"
            };

            Console.WriteLine(customer2.Name);

            Console.ReadLine();
        }
    }
}
