using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double DiscountPercentage { get; set; }
        const int DIVISOR_NUMBER = 100;
        public Product(int productId, string productName, double productPrice, double discountPercentage)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            DiscountPercentage = discountPercentage;
        }
        public double CalculateDiscountedPrice()
        {
            int divisor = DIVISOR_NUMBER;
            return ProductPrice - (ProductPrice * DiscountPercentage / divisor);
        }
    }
}