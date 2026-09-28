using System;

namespace Gun8
{
    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public Product(string name, decimal price) { Name = name; Price = price; }
    }

    public class Customer
    {
        public string Name { get; }
        public Customer(string name) { Name = name; }
    }

    public class Order
    {
        public Product Product { get; }
        public Customer Customer { get; }
        public int Quantity { get; }
        public decimal Total => Product.Price * Quantity;
        public Order(Product product, Customer customer, int quantity)
        {
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            Product = product;
            Customer = customer;
            Quantity = quantity;
        }
    }

    internal class Program
    {
        static void Main()
        {
            var order = new Order(new Product("Defter", 40m), new Customer("Berkay"), 2);
            Console.WriteLine($"{order.Customer.Name}: {order.Quantity} {order.Product.Name}, toplam {order.Total:C}");
        }
    }
}
