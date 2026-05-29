using System;
using System.Collections.Generic;
using System.Text;

namespace ClientOrder.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = SubTotal();
        }

        public double SubTotal()
        {
           return Quantity * Product.Price;
        }
    }
}
