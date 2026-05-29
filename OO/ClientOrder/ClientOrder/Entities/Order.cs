using System;
using System.Collections.Generic;
using System.Text;
using ClientOrder.Entities.Enums;
using System.Globalization;

namespace ClientOrder.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in Items)
            {
                total += item.Price;
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("ORDER SUMMARY:");
            str.AppendLine($"Order moment: {Moment.ToString()}");
            str.AppendLine($"Order status: {Status.ToString()}");
            str.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            str.AppendLine("Order items:");

            foreach(OrderItem item in Items)
            {
                str.Append($"{item.Product.Name}, {item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
                str.AppendLine($"Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            str.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }
    }
}
