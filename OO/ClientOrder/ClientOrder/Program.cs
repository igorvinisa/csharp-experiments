using ClientOrder.Entities;
using ClientOrder.Entities.Enums;
using System.Globalization;

namespace ClientOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string emailClient = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDateClient = DateTime.Parse(Console.ReadLine());

            Client clientOrder = new Client(nameClient, emailClient, birthDateClient);
            Order order = new Order(DateTime.Now, OrderStatus.PROCESSING, clientOrder);

            Console.WriteLine("Enter order data:");
            Console.WriteLine($"Status: {order.Status}");
            Console.Write("How many items to this order? ");
            int itemsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemsCount; i++)
            { 
                Console.WriteLine($"Enter {i} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }
    }
}
