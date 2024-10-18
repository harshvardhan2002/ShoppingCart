using ShoppingCartApp.Model;

namespace ShoppingCartApp
{
    internal class Program
    {

        const int ORDER_NUMBER = 1;
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Harshvardhan");

            var order1 = new Order(1001, DateTime.Now);
            var order2 = new Order(1002, DateTime.Now);

            var product1 = new Product(101, "wallet", 100.00, 10);
            var product2 = new Product(102, "Shirt", 4000.0, 20);
            var product3 = new Product(103, "Jeans", 2000.0, 15);
            var product4 = new Product(104, "Mouse", 1500.0, 5);
            var product5 = new Product(105, "Cooker", 300.0, 8);

            var lineItem1 = new LineItem(1, 2, product1);
            var lineItem2 = new LineItem(2, 3, product2);
            var lineItem3 = new LineItem(3, 1, product3);
            var lineItem4 = new LineItem(4, 5, product4);
            order1.LineItems.Add(lineItem1);
            order1.LineItems.Add(lineItem2);
            order1.LineItems.Add(lineItem3);
            order1.LineItems.Add(lineItem4);

            var lineItem5 = new LineItem(5, 4, product3);
            var lineItem6 = new LineItem(6, 2, product1);
            var lineItem7 = new LineItem(7, 3, product4);
            var lineItem8 = new LineItem(8, 6, product5);
            order2.LineItems.Add(lineItem5);
            order2.LineItems.Add(lineItem6);
            order2.LineItems.Add(lineItem7);
            order2.LineItems.Add(lineItem8);

            customer.OrderList.Add(order1);
            customer.OrderList.Add(order2);

            Console.WriteLine("Customer Id: " + customer.CustomerId);
            Console.WriteLine("Customer Name: " + customer.CustomerName);
            Console.WriteLine("Order Count: " + customer.OrderList.Count);
            Console.WriteLine();

            int orderNumber = ORDER_NUMBER;
            foreach (var order in customer.OrderList)
            {
                Console.WriteLine("Order Number: " + orderNumber);
                Console.WriteLine("Order Id: " + order.OrderId);
                Console.WriteLine("Order Date: " + order.OrderDate);
                Console.WriteLine();
                PriceDisplay(order);
                orderNumber++;
            }
            static void PriceDisplay(Order order)
            {
                foreach (var lineItem in order.LineItems)
                {
                    var product = lineItem.Product;
                    double unitCostAfterDiscount = product.CalculateDiscountedPrice();
                    double totalLineItemCost = lineItem.CalculateLineItemCost();

                    Console.WriteLine($"LineItemId: {lineItem.LineItemId}, ProductId: {product.ProductId}, ProductName: {product.ProductName}, " +
                        $"Quantity: {lineItem.QuantityItem}, UnitPrice: {product.ProductPrice}, Discount: {product.DiscountPercentage}, " +
                        $"UnitCostAfterDiscount: {unitCostAfterDiscount}, TotalLineItemCost: {totalLineItemCost}");
                }

                double totalCost = order.CalculateOrderPrice();
                Console.WriteLine($"Total Order Cost: {totalCost}\n");
            }
        }
    }
}
            