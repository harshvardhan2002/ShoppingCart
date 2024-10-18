using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class LineItem
    {
        public int LineItemId { get; set; }
        public int QuantityItem { get; set; }
        public Product Product { get; set; }
        public LineItem(int lineItemId, int quantityItem, Product product)
        {
            LineItemId = lineItemId;
            QuantityItem = quantityItem;
            Product = product;

        }
        public double CalculateLineItemCost()
        {
            double unitCostAfterDiscount = Product.CalculateDiscountedPrice();
            return unitCostAfterDiscount * QuantityItem;
        }
    }
}