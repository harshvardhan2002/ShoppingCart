using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Order> OrderList { get; set; }
        public Customer(int customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            OrderList = new List<Order>();
        }
    }

}