using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<LineItem> LineItems { get; set; }
        const int DEFAULT_TOTAL = 100;
        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            LineItems = new List<LineItem>();

        }
        public double CalculateOrderPrice()
        {
            double totalPrice = DEFAULT_TOTAL;
            foreach (var lineItem in LineItems)
            {
                totalPrice += lineItem.CalculateLineItemCost();
            }
            return totalPrice;
        }
    }
}