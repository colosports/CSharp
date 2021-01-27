using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
            //this.Id = 1;
            //this.Name = "Ty";
        }

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
